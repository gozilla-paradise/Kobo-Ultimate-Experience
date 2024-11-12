namespace Kobo_Ultimate_Experience
{
    partial class mainApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            appTabControl = new TabControl();
            kepubifyPage = new TabPage();
            autoCopy = new CheckBox();
            kepubifyAddDummyTitle = new CheckBox();
            kepubifyFullScreenReadingFixes = new CheckBox();
            kepubifyForceHyphenation = new CheckBox();
            kepubifySmartPunctuation = new CheckBox();
            epubDropPanel = new Panel();
            dropPanelLabel = new Label();
            firmwarePage = new TabPage();
            installAlucardButton = new Button();
            firmwareStep5Label = new Label();
            firmwareNoteLabel = new Label();
            firmwareStep4Label = new Label();
            firmwareProgressBar = new ProgressBar();
            firmwarePatchButton = new Button();
            firmwareStep3Label = new Label();
            firmwareStep2Label = new Label();
            downloadLinkLabel = new LinkLabel();
            firmwareStep1Label = new Label();
            koreaderPage = new TabPage();
            koreaderStep7Hint = new Label();
            koreaderStep6Hint = new Label();
            installNickelSeriesButton = new Button();
            koreaderStep7Label = new Label();
            installNickelClockButton = new Button();
            koreaderStep6Label = new Label();
            koreaderStep5Status = new Label();
            koreaderStep4Status = new Label();
            installKoreaderButton = new Button();
            configNickelMenuButton = new Button();
            koreaderStep5Label = new Label();
            koreaderStep4Label = new Label();
            koreaderStep3Hint = new Label();
            installNickelMenuButton = new Button();
            koreaderStep3Label = new Label();
            koreaderStep2Status = new Label();
            configExcludeSyncButton = new Button();
            koreaderStep2Label = new Label();
            koboDriveCombo = new ComboBox();
            koreaderStep1Label = new Label();
            refreshDriveButton = new Button();
            aboutPage = new TabPage();
            specialThanksPos5 = new Label();
            specialThanksPos4 = new Label();
            specialThanksPos3 = new Label();
            specialThanksPos2 = new Label();
            specialThanksPos1 = new Label();
            specialThanksLabel = new Label();
            madeByLabel = new Label();
            mainHeaderLabel = new Label();
            appTabControl.SuspendLayout();
            kepubifyPage.SuspendLayout();
            epubDropPanel.SuspendLayout();
            firmwarePage.SuspendLayout();
            koreaderPage.SuspendLayout();
            aboutPage.SuspendLayout();
            SuspendLayout();
            // 
            // appTabControl
            // 
            appTabControl.Controls.Add(kepubifyPage);
            appTabControl.Controls.Add(firmwarePage);
            appTabControl.Controls.Add(koreaderPage);
            appTabControl.Controls.Add(aboutPage);
            appTabControl.Location = new Point(12, 149);
            appTabControl.Name = "appTabControl";
            appTabControl.SelectedIndex = 0;
            appTabControl.Size = new Size(1032, 519);
            appTabControl.TabIndex = 0;
            // 
            // kepubifyPage
            // 
            kepubifyPage.Controls.Add(autoCopy);
            kepubifyPage.Controls.Add(kepubifyAddDummyTitle);
            kepubifyPage.Controls.Add(kepubifyFullScreenReadingFixes);
            kepubifyPage.Controls.Add(kepubifyForceHyphenation);
            kepubifyPage.Controls.Add(kepubifySmartPunctuation);
            kepubifyPage.Controls.Add(epubDropPanel);
            kepubifyPage.Location = new Point(4, 29);
            kepubifyPage.Name = "kepubifyPage";
            kepubifyPage.Padding = new Padding(3);
            kepubifyPage.Size = new Size(1024, 486);
            kepubifyPage.TabIndex = 0;
            kepubifyPage.Text = "Kepubify";
            kepubifyPage.UseVisualStyleBackColor = true;
            // 
            // autoCopy
            // 
            autoCopy.AutoSize = true;
            autoCopy.Location = new Point(843, 449);
            autoCopy.Name = "autoCopy";
            autoCopy.Size = new Size(161, 24);
            autoCopy.TabIndex = 5;
            autoCopy.Text = "Auto Copy To Kobo";
            autoCopy.UseVisualStyleBackColor = true;
            // 
            // kepubifyAddDummyTitle
            // 
            kepubifyAddDummyTitle.AutoSize = true;
            kepubifyAddDummyTitle.Location = new Point(540, 449);
            kepubifyAddDummyTitle.Name = "kepubifyAddDummyTitle";
            kepubifyAddDummyTitle.Size = new Size(184, 24);
            kepubifyAddDummyTitle.TabIndex = 4;
            kepubifyAddDummyTitle.Text = "Add Dummy Title Page";
            kepubifyAddDummyTitle.UseVisualStyleBackColor = true;
            // 
            // kepubifyFullScreenReadingFixes
            // 
            kepubifyFullScreenReadingFixes.AutoSize = true;
            kepubifyFullScreenReadingFixes.Location = new Point(337, 449);
            kepubifyFullScreenReadingFixes.Name = "kepubifyFullScreenReadingFixes";
            kepubifyFullScreenReadingFixes.Size = new Size(197, 24);
            kepubifyFullScreenReadingFixes.TabIndex = 3;
            kepubifyFullScreenReadingFixes.Text = "Full Screen Reading Fixes";
            kepubifyFullScreenReadingFixes.UseVisualStyleBackColor = true;
            // 
            // kepubifyForceHyphenation
            // 
            kepubifyForceHyphenation.AutoSize = true;
            kepubifyForceHyphenation.Location = new Point(175, 449);
            kepubifyForceHyphenation.Name = "kepubifyForceHyphenation";
            kepubifyForceHyphenation.Size = new Size(156, 24);
            kepubifyForceHyphenation.TabIndex = 2;
            kepubifyForceHyphenation.Text = "Force Hyphenation";
            kepubifyForceHyphenation.UseVisualStyleBackColor = true;
            // 
            // kepubifySmartPunctuation
            // 
            kepubifySmartPunctuation.AutoSize = true;
            kepubifySmartPunctuation.Location = new Point(17, 449);
            kepubifySmartPunctuation.Name = "kepubifySmartPunctuation";
            kepubifySmartPunctuation.Size = new Size(152, 24);
            kepubifySmartPunctuation.TabIndex = 1;
            kepubifySmartPunctuation.Text = "Smart Punctuation";
            kepubifySmartPunctuation.UseVisualStyleBackColor = true;
            // 
            // epubDropPanel
            // 
            epubDropPanel.AllowDrop = true;
            epubDropPanel.BorderStyle = BorderStyle.FixedSingle;
            epubDropPanel.Controls.Add(dropPanelLabel);
            epubDropPanel.Location = new Point(19, 26);
            epubDropPanel.Name = "epubDropPanel";
            epubDropPanel.Size = new Size(985, 413);
            epubDropPanel.TabIndex = 0;
            epubDropPanel.DragDrop += epubDropPanel_DragDrop;
            epubDropPanel.DragEnter += epubDropPanel_DragEnter;
            // 
            // dropPanelLabel
            // 
            dropPanelLabel.AllowDrop = true;
            dropPanelLabel.AutoSize = true;
            dropPanelLabel.Location = new Point(411, 177);
            dropPanelLabel.Name = "dropPanelLabel";
            dropPanelLabel.Size = new Size(170, 20);
            dropPanelLabel.TabIndex = 0;
            dropPanelLabel.Text = "- Drop Epub Files Here -";
            dropPanelLabel.DragDrop += dropPanelLabel_DragDrop;
            dropPanelLabel.DragEnter += dropPanelLabel_DragEnter;
            // 
            // firmwarePage
            // 
            firmwarePage.Controls.Add(installAlucardButton);
            firmwarePage.Controls.Add(firmwareStep5Label);
            firmwarePage.Controls.Add(firmwareNoteLabel);
            firmwarePage.Controls.Add(firmwareStep4Label);
            firmwarePage.Controls.Add(firmwareProgressBar);
            firmwarePage.Controls.Add(firmwarePatchButton);
            firmwarePage.Controls.Add(firmwareStep3Label);
            firmwarePage.Controls.Add(firmwareStep2Label);
            firmwarePage.Controls.Add(downloadLinkLabel);
            firmwarePage.Controls.Add(firmwareStep1Label);
            firmwarePage.Location = new Point(4, 29);
            firmwarePage.Name = "firmwarePage";
            firmwarePage.Padding = new Padding(3);
            firmwarePage.Size = new Size(1024, 486);
            firmwarePage.TabIndex = 1;
            firmwarePage.Text = "Firmware Patcher";
            firmwarePage.UseVisualStyleBackColor = true;
            // 
            // installAlucardButton
            // 
            installAlucardButton.Location = new Point(310, 249);
            installAlucardButton.Name = "installAlucardButton";
            installAlucardButton.Size = new Size(174, 29);
            installAlucardButton.TabIndex = 9;
            installAlucardButton.Text = "Install";
            installAlucardButton.UseVisualStyleBackColor = true;
            installAlucardButton.Click += installFont_Click;
            // 
            // firmwareStep5Label
            // 
            firmwareStep5Label.AutoSize = true;
            firmwareStep5Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firmwareStep5Label.Location = new Point(28, 246);
            firmwareStep5Label.Name = "firmwareStep5Label";
            firmwareStep5Label.Size = new Size(263, 28);
            firmwareStep5Label.TabIndex = 8;
            firmwareStep5Label.Text = "Step 5: Install Alucard™ fonts";
            // 
            // firmwareNoteLabel
            // 
            firmwareNoteLabel.AutoSize = true;
            firmwareNoteLabel.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            firmwareNoteLabel.Location = new Point(703, 421);
            firmwareNoteLabel.Name = "firmwareNoteLabel";
            firmwareNoteLabel.Size = new Size(297, 17);
            firmwareNoteLabel.TabIndex = 7;
            firmwareNoteLabel.Text = "We are using Noto Sans Thai Looped as system font";
            // 
            // firmwareStep4Label
            // 
            firmwareStep4Label.AutoSize = true;
            firmwareStep4Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firmwareStep4Label.Location = new Point(28, 195);
            firmwareStep4Label.Name = "firmwareStep4Label";
            firmwareStep4Label.Size = new Size(189, 28);
            firmwareStep4Label.TabIndex = 6;
            firmwareStep4Label.Text = "Step 4: Restart Kobo";
            // 
            // firmwareProgressBar
            // 
            firmwareProgressBar.Location = new Point(28, 441);
            firmwareProgressBar.Name = "firmwareProgressBar";
            firmwareProgressBar.Size = new Size(972, 29);
            firmwareProgressBar.TabIndex = 5;
            // 
            // firmwarePatchButton
            // 
            firmwarePatchButton.Location = new Point(310, 87);
            firmwarePatchButton.Name = "firmwarePatchButton";
            firmwarePatchButton.Size = new Size(174, 29);
            firmwarePatchButton.TabIndex = 4;
            firmwarePatchButton.Text = "Patch";
            firmwarePatchButton.UseVisualStyleBackColor = true;
            firmwarePatchButton.Click += patchFirmware_Click;
            // 
            // firmwareStep3Label
            // 
            firmwareStep3Label.AutoSize = true;
            firmwareStep3Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firmwareStep3Label.Location = new Point(28, 141);
            firmwareStep3Label.Name = "firmwareStep3Label";
            firmwareStep3Label.Size = new Size(412, 28);
            firmwareStep3Label.TabIndex = 3;
            firmwareStep3Label.Text = "Step 3: Copy KoboRoot.tgz to .kobo directory";
            // 
            // firmwareStep2Label
            // 
            firmwareStep2Label.AutoSize = true;
            firmwareStep2Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firmwareStep2Label.Location = new Point(28, 84);
            firmwareStep2Label.Name = "firmwareStep2Label";
            firmwareStep2Label.Size = new Size(276, 28);
            firmwareStep2Label.TabIndex = 2;
            firmwareStep2Label.Text = "Step 2: Open Downloaded File";
            // 
            // downloadLinkLabel
            // 
            downloadLinkLabel.AutoSize = true;
            downloadLinkLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            downloadLinkLabel.Location = new Point(382, 25);
            downloadLinkLabel.Name = "downloadLinkLabel";
            downloadLinkLabel.Size = new Size(102, 28);
            downloadLinkLabel.TabIndex = 1;
            downloadLinkLabel.TabStop = true;
            downloadLinkLabel.Text = "Download";
            downloadLinkLabel.LinkClicked += linkLabel1_LinkClicked;
            // 
            // firmwareStep1Label
            // 
            firmwareStep1Label.AutoSize = true;
            firmwareStep1Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firmwareStep1Label.Location = new Point(28, 25);
            firmwareStep1Label.Name = "firmwareStep1Label";
            firmwareStep1Label.Size = new Size(348, 28);
            firmwareStep1Label.TabIndex = 0;
            firmwareStep1Label.Text = "Step 1: Download Your Kobo Firmware";
            // 
            // koreaderPage
            // 
            koreaderPage.Controls.Add(koreaderStep7Hint);
            koreaderPage.Controls.Add(koreaderStep6Hint);
            koreaderPage.Controls.Add(installNickelSeriesButton);
            koreaderPage.Controls.Add(koreaderStep7Label);
            koreaderPage.Controls.Add(installNickelClockButton);
            koreaderPage.Controls.Add(koreaderStep6Label);
            koreaderPage.Controls.Add(koreaderStep5Status);
            koreaderPage.Controls.Add(koreaderStep4Status);
            koreaderPage.Controls.Add(installKoreaderButton);
            koreaderPage.Controls.Add(configNickelMenuButton);
            koreaderPage.Controls.Add(koreaderStep5Label);
            koreaderPage.Controls.Add(koreaderStep4Label);
            koreaderPage.Controls.Add(koreaderStep3Hint);
            koreaderPage.Controls.Add(installNickelMenuButton);
            koreaderPage.Controls.Add(koreaderStep3Label);
            koreaderPage.Controls.Add(koreaderStep2Status);
            koreaderPage.Controls.Add(configExcludeSyncButton);
            koreaderPage.Controls.Add(koreaderStep2Label);
            koreaderPage.Controls.Add(koboDriveCombo);
            koreaderPage.Controls.Add(koreaderStep1Label);
            koreaderPage.Controls.Add(refreshDriveButton);
            koreaderPage.Location = new Point(4, 29);
            koreaderPage.Name = "koreaderPage";
            koreaderPage.Size = new Size(1024, 486);
            koreaderPage.TabIndex = 2;
            koreaderPage.Text = "Install KoReader";
            koreaderPage.UseVisualStyleBackColor = true;
            // 
            // koreaderStep7Hint
            // 
            koreaderStep7Hint.AutoSize = true;
            koreaderStep7Hint.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            koreaderStep7Hint.Location = new Point(526, 421);
            koreaderStep7Hint.Name = "koreaderStep7Hint";
            koreaderStep7Hint.Size = new Size(476, 28);
            koreaderStep7Hint.TabIndex = 20;
            koreaderStep7Hint.Text = "A simple plugin that automatic parse series metadata";
            // 
            // koreaderStep6Hint
            // 
            koreaderStep6Hint.AutoSize = true;
            koreaderStep6Hint.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            koreaderStep6Hint.Location = new Point(526, 348);
            koreaderStep6Hint.Name = "koreaderStep6Hint";
            koreaderStep6Hint.Size = new Size(410, 28);
            koreaderStep6Hint.TabIndex = 19;
            koreaderStep6Hint.Text = "A simple plugin that show clock while reading";
            // 
            // installNickelSeriesButton
            // 
            installNickelSeriesButton.Location = new Point(295, 423);
            installNickelSeriesButton.Name = "installNickelSeriesButton";
            installNickelSeriesButton.Size = new Size(225, 30);
            installNickelSeriesButton.TabIndex = 18;
            installNickelSeriesButton.Text = "Install";
            installNickelSeriesButton.UseVisualStyleBackColor = true;
            installNickelSeriesButton.Click += installNickelSeries_Click;
            // 
            // koreaderStep7Label
            // 
            koreaderStep7Label.AutoSize = true;
            koreaderStep7Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            koreaderStep7Label.Location = new Point(28, 397);
            koreaderStep7Label.Name = "koreaderStep7Label";
            koreaderStep7Label.Size = new Size(237, 56);
            koreaderStep7Label.TabIndex = 17;
            koreaderStep7Label.Text = "(Optional)\r\nStep 7: Install NickelSeries";
            // 
            // installNickelClockButton
            // 
            installNickelClockButton.Location = new Point(295, 350);
            installNickelClockButton.Name = "installNickelClockButton";
            installNickelClockButton.Size = new Size(225, 30);
            installNickelClockButton.TabIndex = 16;
            installNickelClockButton.Text = "Install";
            installNickelClockButton.UseVisualStyleBackColor = true;
            installNickelClockButton.Click += installNickelClock_Click;
            // 
            // koreaderStep6Label
            // 
            koreaderStep6Label.AutoSize = true;
            koreaderStep6Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            koreaderStep6Label.Location = new Point(28, 324);
            koreaderStep6Label.Name = "koreaderStep6Label";
            koreaderStep6Label.Size = new Size(234, 56);
            koreaderStep6Label.TabIndex = 15;
            koreaderStep6Label.Text = "(Optional)\r\nStep 6: Install NickelClock";
            // 
            // koreaderStep5Status
            // 
            koreaderStep5Status.AutoSize = true;
            koreaderStep5Status.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            koreaderStep5Status.Location = new Point(526, 277);
            koreaderStep5Status.Name = "koreaderStep5Status";
            koreaderStep5Status.Size = new Size(101, 28);
            koreaderStep5Status.TabIndex = 14;
            koreaderStep5Status.Text = "Waiting...";
            // 
            // koreaderStep4Status
            // 
            koreaderStep4Status.AutoSize = true;
            koreaderStep4Status.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            koreaderStep4Status.Location = new Point(526, 232);
            koreaderStep4Status.Name = "koreaderStep4Status";
            koreaderStep4Status.Size = new Size(101, 28);
            koreaderStep4Status.TabIndex = 13;
            koreaderStep4Status.Text = "Waiting...";
            // 
            // installKoreaderButton
            // 
            installKoreaderButton.Location = new Point(295, 279);
            installKoreaderButton.Name = "installKoreaderButton";
            installKoreaderButton.Size = new Size(225, 30);
            installKoreaderButton.TabIndex = 12;
            installKoreaderButton.Text = "Install";
            installKoreaderButton.UseVisualStyleBackColor = true;
            installKoreaderButton.Click += installKoreader_Click;
            // 
            // configNickelMenuButton
            // 
            configNickelMenuButton.Location = new Point(295, 230);
            configNickelMenuButton.Name = "configNickelMenuButton";
            configNickelMenuButton.Size = new Size(225, 30);
            configNickelMenuButton.TabIndex = 11;
            configNickelMenuButton.Text = "Config";
            configNickelMenuButton.UseVisualStyleBackColor = true;
            configNickelMenuButton.Click += configNickelMenu_Click;
            // 
            // koreaderStep5Label
            // 
            koreaderStep5Label.AutoSize = true;
            koreaderStep5Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            koreaderStep5Label.Location = new Point(28, 277);
            koreaderStep5Label.Name = "koreaderStep5Label";
            koreaderStep5Label.Size = new Size(216, 28);
            koreaderStep5Label.TabIndex = 10;
            koreaderStep5Label.Text = "Step 5: Install KoReader";
            // 
            // koreaderStep4Label
            // 
            koreaderStep4Label.AutoSize = true;
            koreaderStep4Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            koreaderStep4Label.Location = new Point(28, 228);
            koreaderStep4Label.Name = "koreaderStep4Label";
            koreaderStep4Label.Size = new Size(248, 28);
            koreaderStep4Label.TabIndex = 9;
            koreaderStep4Label.Text = "Step 4: Config Nickel Menu";
            // 
            // koreaderStep3Hint
            // 
            koreaderStep3Hint.AutoSize = true;
            koreaderStep3Hint.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            koreaderStep3Hint.Location = new Point(526, 129);
            koreaderStep3Hint.Name = "koreaderStep3Hint";
            koreaderStep3Hint.Size = new Size(402, 84);
            koreaderStep3Hint.TabIndex = 8;
            koreaderStep3Hint.Text = "After device restart, \r\nconnect your kobo to PC, press Refresh Drive\r\nand select the correct kobo drive again.";
            // 
            // installNickelMenuButton
            // 
            installNickelMenuButton.Location = new Point(295, 131);
            installNickelMenuButton.Name = "installNickelMenuButton";
            installNickelMenuButton.Size = new Size(225, 30);
            installNickelMenuButton.TabIndex = 7;
            installNickelMenuButton.Text = "Install";
            installNickelMenuButton.UseVisualStyleBackColor = true;
            installNickelMenuButton.Click += installNickelMenu_Click;
            // 
            // koreaderStep3Label
            // 
            koreaderStep3Label.AutoSize = true;
            koreaderStep3Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            koreaderStep3Label.Location = new Point(28, 131);
            koreaderStep3Label.Name = "koreaderStep3Label";
            koreaderStep3Label.Size = new Size(241, 28);
            koreaderStep3Label.TabIndex = 6;
            koreaderStep3Label.Text = "Step 3: Install Nickel Menu";
            // 
            // koreaderStep2Status
            // 
            koreaderStep2Status.AutoSize = true;
            koreaderStep2Status.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            koreaderStep2Status.Location = new Point(526, 78);
            koreaderStep2Status.Name = "koreaderStep2Status";
            koreaderStep2Status.Size = new Size(101, 28);
            koreaderStep2Status.TabIndex = 5;
            koreaderStep2Status.Text = "Waiting...";
            // 
            // configExcludeSyncButton
            // 
            configExcludeSyncButton.Location = new Point(295, 78);
            configExcludeSyncButton.Name = "configExcludeSyncButton";
            configExcludeSyncButton.Size = new Size(225, 30);
            configExcludeSyncButton.TabIndex = 4;
            configExcludeSyncButton.Text = "Config";
            configExcludeSyncButton.UseVisualStyleBackColor = true;
            configExcludeSyncButton.Click += configSync_Click;
            // 
            // koreaderStep2Label
            // 
            koreaderStep2Label.AutoSize = true;
            koreaderStep2Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            koreaderStep2Label.Location = new Point(28, 76);
            koreaderStep2Label.Name = "koreaderStep2Label";
            koreaderStep2Label.Size = new Size(250, 28);
            koreaderStep2Label.TabIndex = 3;
            koreaderStep2Label.Text = "Step 2: Config Exclude Sync";
            // 
            // koboDriveCombo
            // 
            koboDriveCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            koboDriveCombo.FormattingEnabled = true;
            koboDriveCombo.Location = new Point(295, 29);
            koboDriveCombo.Name = "koboDriveCombo";
            koboDriveCombo.Size = new Size(406, 28);
            koboDriveCombo.TabIndex = 2;
            // 
            // koreaderStep1Label
            // 
            koreaderStep1Label.AutoSize = true;
            koreaderStep1Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            koreaderStep1Label.Location = new Point(28, 25);
            koreaderStep1Label.Name = "koreaderStep1Label";
            koreaderStep1Label.Size = new Size(232, 28);
            koreaderStep1Label.TabIndex = 1;
            koreaderStep1Label.Text = "Step 1: Select Kobo Drive";
            // 
            // refreshDriveButton
            // 
            refreshDriveButton.Location = new Point(719, 27);
            refreshDriveButton.Name = "refreshDriveButton";
            refreshDriveButton.Size = new Size(225, 30);
            refreshDriveButton.TabIndex = 0;
            refreshDriveButton.Text = "Refresh Drive";
            refreshDriveButton.UseVisualStyleBackColor = true;
            refreshDriveButton.Click += refreshDrive_Click;
            // 
            // aboutPage
            // 
            aboutPage.Controls.Add(specialThanksPos5);
            aboutPage.Controls.Add(specialThanksPos4);
            aboutPage.Controls.Add(specialThanksPos3);
            aboutPage.Controls.Add(specialThanksPos2);
            aboutPage.Controls.Add(specialThanksPos1);
            aboutPage.Controls.Add(specialThanksLabel);
            aboutPage.Controls.Add(madeByLabel);
            aboutPage.Location = new Point(4, 29);
            aboutPage.Name = "aboutPage";
            aboutPage.Size = new Size(1024, 486);
            aboutPage.TabIndex = 3;
            aboutPage.Text = "About";
            aboutPage.UseVisualStyleBackColor = true;
            // 
            // specialThanksPos5
            // 
            specialThanksPos5.AutoSize = true;
            specialThanksPos5.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            specialThanksPos5.Location = new Point(359, 325);
            specialThanksPos5.Name = "specialThanksPos5";
            specialThanksPos5.Size = new Size(277, 28);
            specialThanksPos5.TabIndex = 10;
            specialThanksPos5.Text = "Font's Author (Mali, Js Jindara)";
            // 
            // specialThanksPos4
            // 
            specialThanksPos4.AutoSize = true;
            specialThanksPos4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            specialThanksPos4.Location = new Point(279, 297);
            specialThanksPos4.Name = "specialThanksPos4";
            specialThanksPos4.Size = new Size(428, 28);
            specialThanksPos4.TabIndex = 9;
            specialThanksPos4.Text = "Google Fonts (Noto Sans Thai Looped, Sarabun)";
            // 
            // specialThanksPos3
            // 
            specialThanksPos3.AutoSize = true;
            specialThanksPos3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            specialThanksPos3.Location = new Point(437, 269);
            specialThanksPos3.Name = "specialThanksPos3";
            specialThanksPos3.Size = new Size(96, 28);
            specialThanksPos3.TabIndex = 8;
            specialThanksPos3.Text = "KoReader";
            // 
            // specialThanksPos2
            // 
            specialThanksPos2.AutoSize = true;
            specialThanksPos2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            specialThanksPos2.Location = new Point(390, 242);
            specialThanksPos2.Name = "specialThanksPos2";
            specialThanksPos2.Size = new Size(198, 28);
            specialThanksPos2.TabIndex = 7;
            specialThanksPos2.Text = "Shermp (NickelClock)";
            // 
            // specialThanksPos1
            // 
            specialThanksPos1.AutoSize = true;
            specialThanksPos1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            specialThanksPos1.Location = new Point(263, 214);
            specialThanksPos1.Name = "specialThanksPos1";
            specialThanksPos1.Size = new Size(457, 28);
            specialThanksPos1.TabIndex = 6;
            specialThanksPos1.Text = "Patrick Gaskin (Kepubify, NickelMenu, NickelSeries)";
            // 
            // specialThanksLabel
            // 
            specialThanksLabel.AutoSize = true;
            specialThanksLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            specialThanksLabel.Location = new Point(395, 181);
            specialThanksLabel.Name = "specialThanksLabel";
            specialThanksLabel.Size = new Size(193, 31);
            specialThanksLabel.TabIndex = 5;
            specialThanksLabel.Text = "Special Thanks To";
            // 
            // madeByLabel
            // 
            madeByLabel.AutoSize = true;
            madeByLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            madeByLabel.Location = new Point(267, 104);
            madeByLabel.Name = "madeByLabel";
            madeByLabel.Size = new Size(453, 54);
            madeByLabel.TabIndex = 4;
            madeByLabel.Text = "Made by Alucard Lucio";
            // 
            // mainHeaderLabel
            // 
            mainHeaderLabel.AutoSize = true;
            mainHeaderLabel.Font = new Font("Viner Hand ITC", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainHeaderLabel.Location = new Point(9, 17);
            mainHeaderLabel.Name = "mainHeaderLabel";
            mainHeaderLabel.Size = new Size(1028, 129);
            mainHeaderLabel.TabIndex = 1;
            mainHeaderLabel.Text = "Kobo Ultimate Experience";
            // 
            // mainApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 684);
            Controls.Add(mainHeaderLabel);
            Controls.Add(appTabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "mainApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kobo Ultimate Experience [TH Edition]";
            Load += mainApp_Load;
            appTabControl.ResumeLayout(false);
            kepubifyPage.ResumeLayout(false);
            kepubifyPage.PerformLayout();
            epubDropPanel.ResumeLayout(false);
            epubDropPanel.PerformLayout();
            firmwarePage.ResumeLayout(false);
            firmwarePage.PerformLayout();
            koreaderPage.ResumeLayout(false);
            koreaderPage.PerformLayout();
            aboutPage.ResumeLayout(false);
            aboutPage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl appTabControl;
        private TabPage kepubifyPage;
        private TabPage firmwarePage;
        private Label mainHeaderLabel;
        private TabPage koreaderPage;
        private TabPage aboutPage;
        private Panel epubDropPanel;
        private Label dropPanelLabel;
        private CheckBox kepubifySmartPunctuation;
        private CheckBox kepubifyAddDummyTitle;
        private CheckBox kepubifyFullScreenReadingFixes;
        private CheckBox kepubifyForceHyphenation;
        private Label firmwareStep1Label;
        private LinkLabel downloadLinkLabel;
        private Label firmwareStep3Label;
        private Label firmwareStep2Label;
        private Button firmwarePatchButton;
        private ProgressBar firmwareProgressBar;
        private Label firmwareStep4Label;
        private Label firmwareNoteLabel;
        private ComboBox koboDriveCombo;
        private Label koreaderStep1Label;
        private Button refreshDriveButton;
        private Label koreaderStep2Status;
        private Button configExcludeSyncButton;
        private Label koreaderStep2Label;
        private Label koreaderStep3Hint;
        private Button installNickelMenuButton;
        private Label koreaderStep3Label;
        private Button installKoreaderButton;
        private Button configNickelMenuButton;
        private Label koreaderStep5Label;
        private Label koreaderStep4Label;
        private Label koreaderStep5Status;
        private Label koreaderStep4Status;
        private Button installNickelClockButton;
        private Label koreaderStep6Label;
        private Label madeByLabel;
        private Label specialThanksPos3;
        private Label specialThanksPos2;
        private Label specialThanksPos1;
        private Label specialThanksLabel;
        private Button installNickelSeriesButton;
        private Label koreaderStep7Label;
        private Label firmwareStep5Label;
        private Button installAlucardButton;
        private Label specialThanksPos5;
        private Label specialThanksPos4;
        private Label koreaderStep7Hint;
        private Label koreaderStep6Hint;
        private CheckBox autoCopy;
    }
}
