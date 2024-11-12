
using System.Diagnostics;
using System.IO.Compression;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Tar;
using ICSharpCode.SharpZipLib.GZip;
using static System.Windows.Forms.LinkLabel;
using System.Management;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Kobo_Ultimate_Experience
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Class to store symlink information
        private class SymlinkInfo
        {
            public string Path { get; set; }
            public string Target { get; set; }
            public int Mode { get; set; }
            public int UserId { get; set; }
            public int GroupId { get; set; }
        }

        private class FontReplaceData
        {
            public string FontPath { get; set; }
            public string FileName { get; set; }
        }

        // Win32 API constants
        private const int OPEN_EXISTING = 3;
        private const uint GENERIC_READ = 0x80000000;
        private const uint GENERIC_WRITE = 0x40000000;
        private const uint IOCTL_STORAGE_EJECT_MEDIA = 0x2D4808;
        private const uint FILE_SHARE_READ = 0x1;
        private const uint FILE_SHARE_WRITE = 0x2;

        // Win32 API imports
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern IntPtr CreateFile(
            string lpFileName,
            uint dwDesiredAccess,
            uint dwShareMode,
            IntPtr lpSecurityAttributes,
            uint dwCreationDisposition,
            uint dwFlagsAndAttributes,
            IntPtr hTemplateFile
        );

        [DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
        private static extern bool DeviceIoControl(
            IntPtr hDevice,
            uint dwIoControlCode,
            IntPtr lpInBuffer,
            uint nInBufferSize,
            IntPtr lpOutBuffer,
            uint nOutBufferSize,
            ref uint lpBytesReturned,
            IntPtr lpOverlapped
        );

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool CloseHandle(IntPtr hObject);

        public static bool EjectDrive(char driveLetter)
        {
            string devicePath = $"\\\\.\\{driveLetter}:";
            IntPtr handle = IntPtr.Zero;
            bool result = false;

            try
            {
                // Flush all pending file operations
                //foreach (var process in System.Diagnostics.Process.GetProcesses())
                //{
                //    try
                //    {
                //        foreach (var module in process.Modules.OfType<System.Diagnostics.ProcessModule>())
                //        {
                //            if (module.FileName.StartsWith($"{driveLetter}:", StringComparison.OrdinalIgnoreCase))
                //            {
                //                throw new IOException($"Drive is in use by process: {process.ProcessName}");
                //            }
                //        }
                //    }
                //    catch (System.ComponentModel.Win32Exception)
                //    {
                //        // Skip processes we can't access
                //        continue;
                //    }
                //}

                // Open the drive
                handle = CreateFile(
                    devicePath,
                    GENERIC_READ | GENERIC_WRITE,
                    FILE_SHARE_READ | FILE_SHARE_WRITE,
                    IntPtr.Zero,
                    OPEN_EXISTING,
                    0,
                    IntPtr.Zero
                );

                if (handle.ToInt64() == -1)
                {
                    throw new IOException($"Failed to open drive {driveLetter}. Error: {Marshal.GetLastWin32Error()}");
                }

                // Eject the drive
                uint bytesReturned = 0;
                result = DeviceIoControl(
                    handle,
                    IOCTL_STORAGE_EJECT_MEDIA,
                    IntPtr.Zero,
                    0,
                    IntPtr.Zero,
                    0,
                    ref bytesReturned,
                    IntPtr.Zero
                );

                if (!result)
                {
                    throw new IOException($"Failed to eject drive {driveLetter}. Error: {Marshal.GetLastWin32Error()}");
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error ejecting drive {driveLetter}: {ex.Message}", ex);
            }
            finally
            {
                if (handle != IntPtr.Zero)
                {
                    CloseHandle(handle);
                }
            }
        }

        public static bool EjectDrive(string driveLetter)
        {
            if (string.IsNullOrEmpty(driveLetter))
                throw new ArgumentNullException(nameof(driveLetter));

            // Clean the drive letter input
            driveLetter = driveLetter.Trim().TrimEnd(':');
            if (driveLetter.Length != 1)
                throw new ArgumentException("Invalid drive letter format");

            return EjectDrive(driveLetter[0]);
        }

        List<FontReplaceData> fontReplaceList { get; set; } = new List<FontReplaceData>()
        {
            new FontReplaceData
            {
                FontPath = "packages/fonts/firmware/ub_arudjingxihei.ttf",
                FileName = "ub_arudjingxihei.ttf"
            },
            new FontReplaceData
            {
                FontPath = "packages/fonts/firmware/ub_arudjingxihei.ttf",
                FileName = "Avenir.ttf"
            },
            new FontReplaceData
            {
                FontPath = "packages/fonts/firmware/ub_arudjingxihei.ttf",
                FileName = "Avenir-Bold.ttf"
            },new FontReplaceData
            {
                FontPath = "packages/fonts/firmware/ub_arudjingxihei.ttf",
                FileName = "Avenir-BoldItalic.ttf"
            },new FontReplaceData
            {
                FontPath = "packages/fonts/firmware/ub_arudjingxihei.ttf",
                FileName = "Avenir-Italic.ttf"
            },new FontReplaceData
            {
                FontPath = "packages/fonts/firmware/ub_arudjingxihei.ttf",
                FileName = "georgia.ttf"
            },new FontReplaceData
            {
                FontPath = "packages/fonts/firmware/ub_arudjingxihei.ttf",
                FileName = "georgiab.ttf"
            },new FontReplaceData
            {
                FontPath = "packages/fonts/firmware/ub_arudjingxihei.ttf",
                FileName = "georgiai.ttf"
            },new FontReplaceData
            {
                FontPath = "packages/fonts/firmware/ub_arudjingxihei.ttf",
                FileName = "georgiaz.ttf"
            },
        };

        private void ReplaceFont(string zipPath, List<FontReplaceData> fonts)
        {
            string tempDir = Path.Combine(Path.GetTempPath(), "KoboUltimateExperience");
            if (Directory.Exists(tempDir))
                Directory.Delete(tempDir, true);
            string extractedTgzPath = Path.Combine(tempDir, "KoboRoot.tgz");
            string extractedTarPath = Path.Combine(tempDir, "KoboRoot.tar");

            var symlinks = new List<SymlinkInfo>();

            progressBar1.Value = 10;

            try
            {
                // Create temp directory
                Directory.CreateDirectory(tempDir);

                // Extract the zip file
                Console.WriteLine("Extracting ZIP file...");
                ZipFile.ExtractToDirectory(zipPath, tempDir);

                progressBar1.Value = 20;

                // Extract the TGZ file
                Console.WriteLine("Extracting TGZ file...");
                using (FileStream tgzStream = File.OpenRead(extractedTgzPath))
                using (GZipInputStream gzipStream = new GZipInputStream(tgzStream))
                using (FileStream tarStream = File.Create(extractedTarPath))
                {
                    byte[] buffer = new byte[4096];
                    int count;
                    while ((count = gzipStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        tarStream.Write(buffer, 0, count);
                    }
                }
                progressBar1.Value = 40;

                // Create a temporary directory for TAR contents
                string tarExtractDir = Path.Combine(tempDir, "tar_contents");
                Directory.CreateDirectory(tarExtractDir);

                // Extract and modify the TAR file
                Console.WriteLine("Processing TAR file and replacing font...");
                using (FileStream tarStream = File.OpenRead(extractedTarPath))
                using (TarInputStream tarIn = new TarInputStream(tarStream))
                {
                    TarEntry tarEntry;
                    while ((tarEntry = tarIn.GetNextEntry()) != null)
                    {
                        // Remove "./" from the beginning of the path if present
                        string entryName = tarEntry.Name.StartsWith("./") ?
                            tarEntry.Name.Substring(2) : tarEntry.Name;

                        string entryPath = Path.Combine(tarExtractDir, entryName);

                        if (tarEntry.TarHeader.TypeFlag == TarHeader.LF_SYMLINK)
                        {
                            symlinks.Add(new SymlinkInfo
                            {
                                Path = entryName,
                                Target = tarEntry.TarHeader.LinkName,
                                Mode = tarEntry.TarHeader.Mode,
                                UserId = tarEntry.UserId,
                                GroupId = tarEntry.GroupId
                            });
                            continue;
                        }

                        if (tarEntry.IsDirectory)
                        {
                            Directory.CreateDirectory(entryPath);
                            continue;
                        }

                        Directory.CreateDirectory(Path.GetDirectoryName(entryPath));
                        using (FileStream fs = File.Create(entryPath))
                        {
                            tarIn.CopyEntryContents(fs);
                        }
                    }
                }

                progressBar1.Value = 70;

                // Replace the font file
                string fontPath = Path.Combine(tarExtractDir, "usr", "local", "Trolltech",
                    "QtEmbedded-4.6.2-arm", "lib", "fonts");
                Directory.CreateDirectory(Path.GetDirectoryName(fontPath));
                foreach (var font in fonts)
                {
                    File.Copy(font.FontPath, Path.Join(fontPath, font.FileName), true);
                }

                progressBar1.Value = 80;


                // Create new TAR file
                string newTarPath = Path.Combine(tempDir, "modified_tar");
                Console.WriteLine("Creating new TAR file...");
                Directory.CreateDirectory(newTarPath);
                using (FileStream tarStream = File.Create(Path.Combine(newTarPath, "KoboRoot.tar")))
                using (TarOutputStream tarOut = new TarOutputStream(tarStream))
                {
                    // Add the root directory entry
                    TarEntry rootEntry = TarEntry.CreateEntryFromFile(tarExtractDir);
                    rootEntry.Name = ".";
                    tarOut.PutNextEntry(rootEntry);
                    tarOut.CloseEntry();

                    AddDirectoryToTar(tarExtractDir, tarExtractDir, tarOut, true);

                    // Add symlinks
                    foreach (var symlink in symlinks)
                    {
                        TarEntry entry = new TarEntry(new TarHeader());

                        // Set symlink properties
                        entry.Name = symlink.Path.StartsWith("./") ? symlink.Path : "./" + symlink.Path;
                        entry.TarHeader.LinkName = symlink.Target;
                        entry.TarHeader.TypeFlag = TarHeader.LF_SYMLINK;
                        entry.TarHeader.Mode = symlink.Mode;
                        entry.UserId = symlink.UserId;
                        entry.GroupId = symlink.GroupId;
                        entry.Size = 0;

                        tarOut.PutNextEntry(entry);
                        tarOut.CloseEntry();
                    }
                }

                progressBar1.Value = 85;

                // Create new TGZ file
                Console.WriteLine("Creating new TGZ file...");
                using (FileStream tarStream = File.OpenRead(Path.Combine(newTarPath, "KoboRoot.tar")))
                using (FileStream tgzStream = File.Create(Path.Combine(newTarPath, "KoboRoot.tgz")))
                using (GZipOutputStream gzipStream = new GZipOutputStream(tgzStream))
                {
                    byte[] buffer = new byte[4096];
                    int count;
                    while ((count = tarStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        gzipStream.Write(buffer, 0, count);
                    }
                }

                if (Directory.Exists("firmware"))
                {
                    Directory.Delete("firmware", true);
                }
                Directory.CreateDirectory("firmware");
                File.Copy(Path.Combine(newTarPath, "KoboRoot.tgz"), Path.Combine("firmware", "KoboRoot.tgz"));

                progressBar1.Value = 100;
            }
            finally
            {
                // Cleanup
                if (Directory.Exists(tempDir))
                {
                    Directory.Delete(tempDir, true);
                }
                Process.Start("explorer.exe", "firmware");
            }
        }

        private static void AddDirectoryToTar(string baseDir, string sourceDir, TarOutputStream tarOutputStream, bool prependDot)
        {
            string[] files = Directory.GetFiles(sourceDir);
            string[] directories = Directory.GetDirectories(sourceDir);

            foreach (string file in files)
            {
                string relativePath = file.Substring(baseDir.Length).TrimStart('\\', '/');
                if (prependDot && !string.IsNullOrEmpty(relativePath))
                {
                    relativePath = "./" + relativePath;
                }

                TarEntry entry = TarEntry.CreateEntryFromFile(file);
                entry.Name = relativePath.Replace('\\', '/');

                tarOutputStream.PutNextEntry(entry);
                using (FileStream fs = File.OpenRead(file))
                {
                    byte[] buffer = new byte[4096];
                    int count;
                    while ((count = fs.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        tarOutputStream.Write(buffer, 0, count);
                    }
                }
                tarOutputStream.CloseEntry();
            }

            foreach (string directory in directories)
            {
                string relativePath = directory.Substring(baseDir.Length).TrimStart('\\', '/');
                if (prependDot && !string.IsNullOrEmpty(relativePath))
                {
                    // Add directory entry with "./" prefix
                    TarEntry entry = TarEntry.CreateEntryFromFile(directory);
                    entry.Name = "./" + relativePath.Replace('\\', '/');
                    tarOutputStream.PutNextEntry(entry);
                    tarOutputStream.CloseEntry();
                }

                AddDirectoryToTar(baseDir, directory, tarOutputStream, prependDot);
            }
        }

        private void OpenWebsite(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to open URL: {ex.Message}");
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void panel1_DragLeave(object sender, EventArgs e)
        {

        }

        private void label2_DragEnter(object sender, DragEventArgs e)
        {
            panel1_DragEnter(sender, e);
        }

        private void label2_DragLeave(object sender, EventArgs e)
        {
            panel1_DragLeave(sender, e);
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop) ?? [];
            List<string> argumentOptions = new();
            if (kepubifyAddDummyTitle.Checked)
            {
                argumentOptions.Add("--add-dummy-titlepage");
            }
            else
            {
                argumentOptions.Add("--no-add-dummy-titlepage");
            }
            if (kepubifySmartPunctuation.Checked)
            {
                argumentOptions.Add("--smarten-punctuation");
            }
            if (kepubifyFullScreenReadingFixes.Checked)
            {
                argumentOptions.Add("--fullscreen-reading-fixes");
            }
            if (kepubifyForceHyphenation.Checked)
            {
                argumentOptions.Add("--hyphenate");
            }
            else
            {
                argumentOptions.Add("--no-hyphenate");
            }
            if (files.Length > 0)
            {
                files = files.Where(x => x.EndsWith(".epub")).ToArray();
                if (files.Length > 0)
                {
                    Directory.CreateDirectory("output");

                    var argumentList = string.Join(" ", Array.ConvertAll(files, file => $"\"{file}\""));
                    ProcessStartInfo processStartInfo = new ProcessStartInfo();
                    processStartInfo.FileName = Path.Join(Application.StartupPath, "packages", "kepubify-windows-64bit.exe");
                    processStartInfo.UseShellExecute = false;
                    processStartInfo.Arguments = argumentList + " -i -o output " + string.Join(" ", argumentOptions);
                    
                    var p = Process.Start(processStartInfo);
                    p.WaitForExit();
                    
                    if (autoCopy.Checked)
                    {
                        DialogResult result = MessageBox.Show("You have auto copy checked!\nThis will copy all files from output directory\n\nDo you want to copy to Kobo Device?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // Handle the result of the dialog
                        if (result == DialogResult.Yes)
                        {
                            string koboBooks = Path.Combine(comboBox1.Text, "books");
                            CopyFiles("output", koboBooks);
                            Process.Start("explorer.exe", koboBooks);
                        }
                        else
                        {
                            Process.Start("explorer.exe", "output");
                        }
                    } else
                    {
                        Process.Start("explorer.exe", "output");
                    }

                    
                }
            }

        }

        private void label2_DragDrop(object sender, DragEventArgs e)
        {
            panel1_DragDrop(sender, e);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWebsite("https://pgaskin.net/KoboStuff/kobofirmware.html");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = null;
            var removeableDrive = DriveInfo.GetDrives().Where(x => x.IsReady && x.DriveType == DriveType.Removable && x.DriveFormat == "FAT32").ToList();
            comboBox1.DataSource = removeableDrive;
            Text += " v" + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog
            {
                Filter = "ZIP Files (*.zip)|*.zip",
                Title = "Select a ZIP file",
                Multiselect = false
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ReplaceFont(ofd.FileName, fontReplaceList);
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.DataSource = null;
            var removeableDrive = DriveInfo.GetDrives().Where(x => x.IsReady && x.DriveType == DriveType.Removable && x.DriveFormat == "FAT32").ToList();
            comboBox1.DataSource = removeableDrive;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label10.Text = "Configurating...";
            label10.ForeColor = Color.Black;
            string filePath = Path.Join(comboBox1.Text, ".kobo", "Kobo", "Kobo eReader.conf");
            string FEATURE_SETTINGS = "[FeatureSettings]";
            string EXCLUDE_SYNC_FOLDERS = "ExcludeSyncFolders";
            string NEW_EXCLUDE_VALUE = @"ExcludeSyncFolders=(\\.(?!kobo|adobe).+|([^.][^/]*/)+\\..+)";

            try
            {
                // Read all lines from the file
                List<string> lines = new List<string>(File.ReadAllLines(filePath));
                bool featureSettingsExists = false;
                int featureSettingsIndex = -1;

                // Find [FeatureSettings] section
                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i].Trim() == FEATURE_SETTINGS)
                    {
                        featureSettingsExists = true;
                        featureSettingsIndex = i;
                        break;
                    }
                }

                if (featureSettingsExists)
                {
                    // Check for ExcludeSyncFolders
                    bool excludeSyncFound = false;
                    for (int i = featureSettingsIndex + 1; i < lines.Count; i++)
                    {
                        string line = lines[i].Trim();

                        // Stop if we hit another section
                        if (line.StartsWith("[") && line.EndsWith("]"))
                            break;

                        if (line.StartsWith(EXCLUDE_SYNC_FOLDERS))
                        {
                            // Replace existing value
                            lines[i] = NEW_EXCLUDE_VALUE;
                            excludeSyncFound = true;
                            break;
                        }
                    }

                    // If ExcludeSyncFolders not found, insert it after [FeatureSettings]
                    if (!excludeSyncFound)
                    {
                        lines.Insert(featureSettingsIndex + 1, NEW_EXCLUDE_VALUE);
                    }
                }
                else
                {
                    // Add new section at the end of file
                    if (lines.Count > 0 && !string.IsNullOrWhiteSpace(lines[lines.Count - 1]))
                    {
                        lines.Add(string.Empty); // Add blank line before new section
                    }
                    lines.Add(FEATURE_SETTINGS);
                    lines.Add(NEW_EXCLUDE_VALUE);
                }

                // Write all lines back to the file
                File.WriteAllLines(filePath, lines);
                label10.Text = "OK";
                label10.ForeColor = Color.DarkGreen;
            }
            catch (Exception ex)
            {
                label10.Text = $"Error updating configuration file: {ex.Message}";
                label10.ForeColor = Color.Red;
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            string filePath = Path.Join(comboBox1.Text, ".kobo", "KoboRoot.tgz");
            File.Copy(Path.Combine("packages", "nickelmenu", "KoboRoot.tgz"), filePath, true);
            // Sleep around 3 secs
            Thread.Sleep(3000);
            EjectDrive(comboBox1.Text.Replace("\\", ""));
        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                label15.Text = "Configurating...";
                label15.ForeColor = Color.Black;
                const string nmConfig = @"menu_item :main       :KOReader           :cmd_spawn          :quiet:exec /mnt/onboard/.adds/koreader/koreader.sh
menu_item :reader     :Dark Mode          :nickel_setting     :toggle                 :dark_mode
menu_item :reader     :Screenshot Mode    :nickel_setting     :toggle                 :screenshots
menu_item :main       :Dark Mode          :nickel_setting     :toggle                 :dark_mode
menu_item :main       :Screenshot Mode    :nickel_setting     :toggle                 :screenshots
menu_item :main       :Refresh USB        :nickel_misc        :force_usb_connection
menu_item :main       :Import books       :nickel_misc        :rescan_books_full
menu_item :library    :Import books       :nickel_misc        :rescan_books_full
";
                string filePath = Path.Join(comboBox1.Text, ".adds", "nm", "config");
                File.WriteAllText(filePath, nmConfig);
                label15.Text = "OK";
                label15.ForeColor = Color.DarkGreen;
            }
            catch (Exception ex)
            {
                {
                    label15.Text = $"Error updating configuration file: {ex.Message}";
                    label15.ForeColor = Color.Red;
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                label16.Text = "Extracting...";
                label16.ForeColor = Color.Black;
                var koReaderPath = Path.Combine("packages", "koreader", "koreader-kobo.zip");
                string targetPath = Path.Join(comboBox1.Text, ".adds");
                ZipFile.ExtractToDirectory(koReaderPath, targetPath, true);
                label16.Text = "OK";
                label16.ForeColor = Color.DarkGreen;
            }
            catch (Exception ex)
            {
                {
                    label16.Text = $"Error installing KoReader: {ex.Message}";
                    label16.ForeColor = Color.Red;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string filePath = Path.Join(comboBox1.Text, ".kobo", "KoboRoot.tgz");
            string clockPath = Path.Join(comboBox1.Text, ".adds", "nickelclock", "settings.ini");
            string clockConfig = @"[General]
Debug=false
Margin=Auto

[Battery]
BatteryType=Level
Enabled=false
LevelTemplate=%1%
Placement=Header
Position=Left

[Clock]
Enabled=true
Placement=Header
Position=Right
";
            File.Copy(Path.Combine("packages", "nickelclock", "KoboRoot.tgz"), filePath, true);
            File.WriteAllText(clockPath, clockConfig);
            // Sleep around 3 secs
            Thread.Sleep(3000);
            EjectDrive(comboBox1.Text.Replace("\\", ""));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string filePath = Path.Join(comboBox1.Text, ".kobo", "KoboRoot.tgz");
            File.Copy(Path.Combine("packages", "nickelseries", "KoboRoot.tgz"), filePath, true);
            Thread.Sleep(3000);
            EjectDrive(comboBox1.Text.Replace("\\", ""));
        }

        // Function to copy all files from source to destination, including subdirectories
        private void CopyFiles(string sourceDirectory, string destinationDirectory)
        {
            // Ensure the destination directory exists
            if (!Directory.Exists(destinationDirectory))
            {
                Directory.CreateDirectory(destinationDirectory);
            }

            // Copy all files from the source to the destination directory
            string[] files = Directory.GetFiles(sourceDirectory);
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string destFile = Path.Combine(destinationDirectory, fileName);

                // Copy the file and overwrite if it already exists
                File.Copy(file, destFile, true);
                Console.WriteLine($"Copied: {fileName}");
            }

            //// Recursively copy all subdirectories
            //string[] subdirectories = Directory.GetDirectories(sourceDirectory);
            //foreach (string subdirectory in subdirectories)
            //{
            //    string subdirectoryName = Path.GetFileName(subdirectory);
            //    string destSubdirectory = Path.Combine(destinationDirectory, subdirectoryName);

            //    // Recursively copy each subdirectory
            //    CopyFiles(subdirectory, destSubdirectory);
            //}
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string fontPath = Path.Combine("packages", "fonts");
            string targetPath = Path.Join(comboBox1.Text, "fonts");

            CopyFiles(fontPath, targetPath);
        }

        private void autoCopy_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
