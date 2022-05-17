
namespace osu_client_switcher
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            this.siticoneAnimateWindow1 = new Siticone.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.nameLabel = new Siticone.UI.WinForms.SiticoneLabel();
            this.osufolderButton = new Siticone.UI.WinForms.SiticoneButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.closesettingsButton = new Siticone.UI.WinForms.SiticoneButton();
            this.closeonlaunchButton = new Siticone.UI.WinForms.SiticoneButton();
            this.osufolderCurrently = new Siticone.UI.WinForms.SiticoneLabel();
            this.closeonlaunchCurrently = new Siticone.UI.WinForms.SiticoneLabel();
            this.backupButton = new Siticone.UI.WinForms.SiticoneButton();
            this.loadbackupButton = new Siticone.UI.WinForms.SiticoneButton();
            this.downloadclientsButton = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.SuspendLayout();
            // 
            // siticoneAnimateWindow1
            // 
            this.siticoneAnimateWindow1.AnimationType = Siticone.UI.WinForms.SiticoneAnimateWindow.AnimateWindowType.AW_SLIDE;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.nameLabel.Location = new System.Drawing.Point(11, 11);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(116, 47);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "settings";
            // 
            // osufolderButton
            // 
            this.osufolderButton.CheckedState.Parent = this.osufolderButton;
            this.osufolderButton.CustomImages.Parent = this.osufolderButton;
            this.osufolderButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.osufolderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osufolderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.osufolderButton.HoveredState.Parent = this.osufolderButton;
            this.osufolderButton.Location = new System.Drawing.Point(12, 63);
            this.osufolderButton.Name = "osufolderButton";
            this.osufolderButton.ShadowDecoration.Parent = this.osufolderButton;
            this.osufolderButton.Size = new System.Drawing.Size(139, 45);
            this.osufolderButton.TabIndex = 2;
            this.osufolderButton.Text = "select osu folder";
            this.osufolderButton.Click += new System.EventHandler(this.osufolderButton_Click);
            // 
            // closesettingsButton
            // 
            this.closesettingsButton.CheckedState.Parent = this.closesettingsButton;
            this.closesettingsButton.CustomImages.Parent = this.closesettingsButton;
            this.closesettingsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.closesettingsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closesettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.closesettingsButton.HoveredState.Parent = this.closesettingsButton;
            this.closesettingsButton.Location = new System.Drawing.Point(315, 12);
            this.closesettingsButton.Name = "closesettingsButton";
            this.closesettingsButton.ShadowDecoration.Parent = this.closesettingsButton;
            this.closesettingsButton.Size = new System.Drawing.Size(73, 45);
            this.closesettingsButton.TabIndex = 3;
            this.closesettingsButton.Text = "done";
            this.closesettingsButton.Click += new System.EventHandler(this.closesettingsButton_Click);
            // 
            // closeonlaunchButton
            // 
            this.closeonlaunchButton.CheckedState.Parent = this.closeonlaunchButton;
            this.closeonlaunchButton.CustomImages.Parent = this.closeonlaunchButton;
            this.closeonlaunchButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.closeonlaunchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeonlaunchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.closeonlaunchButton.HoveredState.Parent = this.closeonlaunchButton;
            this.closeonlaunchButton.Location = new System.Drawing.Point(12, 114);
            this.closeonlaunchButton.Name = "closeonlaunchButton";
            this.closeonlaunchButton.ShadowDecoration.Parent = this.closeonlaunchButton;
            this.closeonlaunchButton.Size = new System.Drawing.Size(139, 45);
            this.closeonlaunchButton.TabIndex = 4;
            this.closeonlaunchButton.Text = "close on launch";
            this.closeonlaunchButton.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // osufolderCurrently
            // 
            this.osufolderCurrently.BackColor = System.Drawing.Color.Transparent;
            this.osufolderCurrently.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.osufolderCurrently.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.osufolderCurrently.Location = new System.Drawing.Point(156, 74);
            this.osufolderCurrently.Margin = new System.Windows.Forms.Padding(2);
            this.osufolderCurrently.Name = "osufolderCurrently";
            this.osufolderCurrently.Size = new System.Drawing.Size(116, 23);
            this.osufolderCurrently.TabIndex = 5;
            this.osufolderCurrently.Text = "examplelocation";
            // 
            // closeonlaunchCurrently
            // 
            this.closeonlaunchCurrently.BackColor = System.Drawing.Color.Transparent;
            this.closeonlaunchCurrently.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeonlaunchCurrently.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.closeonlaunchCurrently.Location = new System.Drawing.Point(156, 125);
            this.closeonlaunchCurrently.Margin = new System.Windows.Forms.Padding(2);
            this.closeonlaunchCurrently.Name = "closeonlaunchCurrently";
            this.closeonlaunchCurrently.Size = new System.Drawing.Size(86, 23);
            this.closeonlaunchCurrently.TabIndex = 6;
            this.closeonlaunchCurrently.Text = "true or false";
            // 
            // backupButton
            // 
            this.backupButton.CheckedState.Parent = this.backupButton;
            this.backupButton.CustomImages.Parent = this.backupButton;
            this.backupButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.backupButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.backupButton.HoveredState.Parent = this.backupButton;
            this.backupButton.Location = new System.Drawing.Point(231, 242);
            this.backupButton.Name = "backupButton";
            this.backupButton.ShadowDecoration.Parent = this.backupButton;
            this.backupButton.Size = new System.Drawing.Size(157, 45);
            this.backupButton.TabIndex = 7;
            this.backupButton.Text = "backup current files";
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // loadbackupButton
            // 
            this.loadbackupButton.CheckedState.Parent = this.loadbackupButton;
            this.loadbackupButton.CustomImages.Parent = this.loadbackupButton;
            this.loadbackupButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.loadbackupButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadbackupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.loadbackupButton.HoveredState.Parent = this.loadbackupButton;
            this.loadbackupButton.Location = new System.Drawing.Point(231, 293);
            this.loadbackupButton.Name = "loadbackupButton";
            this.loadbackupButton.ShadowDecoration.Parent = this.loadbackupButton;
            this.loadbackupButton.Size = new System.Drawing.Size(157, 45);
            this.loadbackupButton.TabIndex = 8;
            this.loadbackupButton.Text = "load files from backup";
            this.loadbackupButton.Click += new System.EventHandler(this.loadbackupButton_Click);
            // 
            // downloadclientsButton
            // 
            this.downloadclientsButton.CheckedState.Parent = this.downloadclientsButton;
            this.downloadclientsButton.CustomImages.Parent = this.downloadclientsButton;
            this.downloadclientsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.downloadclientsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadclientsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.downloadclientsButton.HoveredState.Parent = this.downloadclientsButton;
            this.downloadclientsButton.Location = new System.Drawing.Point(231, 191);
            this.downloadclientsButton.Name = "downloadclientsButton";
            this.downloadclientsButton.ShadowDecoration.Parent = this.downloadclientsButton;
            this.downloadclientsButton.Size = new System.Drawing.Size(157, 45);
            this.downloadclientsButton.TabIndex = 9;
            this.downloadclientsButton.Text = "download clients";
            this.downloadclientsButton.Click += new System.EventHandler(this.downloadclientsButton_Click);
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.siticoneLabel1.Location = new System.Drawing.Point(0, 327);
            this.siticoneLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(222, 23);
            this.siticoneLabel1.TabIndex = 10;
            this.siticoneLabel1.Text = "dm VacCat#6752 for any issues";
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.siticoneLabel1);
            this.Controls.Add(this.downloadclientsButton);
            this.Controls.Add(this.loadbackupButton);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.closeonlaunchCurrently);
            this.Controls.Add(this.osufolderCurrently);
            this.Controls.Add(this.closeonlaunchButton);
            this.Controls.Add(this.closesettingsButton);
            this.Controls.Add(this.osufolderButton);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow1;
        private Siticone.UI.WinForms.SiticoneLabel nameLabel;
        private Siticone.UI.WinForms.SiticoneButton osufolderButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Siticone.UI.WinForms.SiticoneButton closesettingsButton;
        private Siticone.UI.WinForms.SiticoneButton closeonlaunchButton;
        private Siticone.UI.WinForms.SiticoneLabel osufolderCurrently;
        private Siticone.UI.WinForms.SiticoneLabel closeonlaunchCurrently;
        private Siticone.UI.WinForms.SiticoneButton backupButton;
        private Siticone.UI.WinForms.SiticoneButton loadbackupButton;
        private Siticone.UI.WinForms.SiticoneButton downloadclientsButton;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
    }
}