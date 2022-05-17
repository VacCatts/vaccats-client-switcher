
namespace osu_client_switcher
{
    partial class main
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
            this.settingsButton = new Siticone.UI.WinForms.SiticoneButton();
            this.exitButton = new Siticone.UI.WinForms.SiticoneButton();
            this.launchButton = new Siticone.UI.WinForms.SiticoneButton();
            this.selectedclientindex = new Siticone.UI.WinForms.SiticoneRoundedNumericUpDown();
            this.selectedclientLabel = new Siticone.UI.WinForms.SiticoneLabel();
            ((System.ComponentModel.ISupportInitialize)(this.selectedclientindex)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneAnimateWindow1
            // 
            this.siticoneAnimateWindow1.AnimationType = Siticone.UI.WinForms.SiticoneAnimateWindow.AnimateWindowType.AW_SLIDE;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.nameLabel.Location = new System.Drawing.Point(11, 11);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(392, 47);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "vaccat\'s osu client switcher";
            // 
            // settingsButton
            // 
            this.settingsButton.CheckedState.Parent = this.settingsButton;
            this.settingsButton.CustomImages.Parent = this.settingsButton;
            this.settingsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.settingsButton.HoveredState.Parent = this.settingsButton;
            this.settingsButton.Location = new System.Drawing.Point(515, 62);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.ShadowDecoration.Parent = this.settingsButton;
            this.settingsButton.Size = new System.Drawing.Size(73, 45);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.Text = "settings";
            this.settingsButton.Click += new System.EventHandler(this.backupcurrentfiles_Click);
            // 
            // exitButton
            // 
            this.exitButton.CheckedState.Parent = this.exitButton;
            this.exitButton.CustomImages.Parent = this.exitButton;
            this.exitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.exitButton.HoveredState.Parent = this.exitButton;
            this.exitButton.Location = new System.Drawing.Point(515, 11);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(73, 45);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // launchButton
            // 
            this.launchButton.CheckedState.Parent = this.launchButton;
            this.launchButton.CustomImages.Parent = this.launchButton;
            this.launchButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.launchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.launchButton.HoveredState.Parent = this.launchButton;
            this.launchButton.Location = new System.Drawing.Point(12, 204);
            this.launchButton.Name = "launchButton";
            this.launchButton.ShadowDecoration.Parent = this.launchButton;
            this.launchButton.Size = new System.Drawing.Size(69, 45);
            this.launchButton.TabIndex = 3;
            this.launchButton.Text = "launch";
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // selectedclientindex
            // 
            this.selectedclientindex.BackColor = System.Drawing.Color.Transparent;
            this.selectedclientindex.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.selectedclientindex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.selectedclientindex.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.selectedclientindex.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.selectedclientindex.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.selectedclientindex.DisabledState.Parent = this.selectedclientindex;
            this.selectedclientindex.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.selectedclientindex.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.selectedclientindex.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.selectedclientindex.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.selectedclientindex.FocusedState.Parent = this.selectedclientindex;
            this.selectedclientindex.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedclientindex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.selectedclientindex.Location = new System.Drawing.Point(11, 162);
            this.selectedclientindex.Name = "selectedclientindex";
            this.selectedclientindex.ShadowDecoration.Parent = this.selectedclientindex;
            this.selectedclientindex.Size = new System.Drawing.Size(100, 36);
            this.selectedclientindex.TabIndex = 4;
            this.selectedclientindex.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.selectedclientindex.ValueChanged += new System.EventHandler(this.selectedclientindex_ValueChanged);
            // 
            // selectedclientLabel
            // 
            this.selectedclientLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectedclientLabel.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.selectedclientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(178)))), ((int)(((byte)(192)))));
            this.selectedclientLabel.Location = new System.Drawing.Point(116, 162);
            this.selectedclientLabel.Margin = new System.Windows.Forms.Padding(2);
            this.selectedclientLabel.Name = "selectedclientLabel";
            this.selectedclientLabel.Size = new System.Drawing.Size(93, 33);
            this.selectedclientLabel.TabIndex = 5;
            this.selectedclientLabel.Text = "selected: ";
            // 
            // main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(600, 261);
            this.Controls.Add(this.selectedclientLabel);
            this.Controls.Add(this.selectedclientindex);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "osuclientswitcher";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.selectedclientindex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow1;
        private Siticone.UI.WinForms.SiticoneLabel nameLabel;
        private Siticone.UI.WinForms.SiticoneButton settingsButton;
        private Siticone.UI.WinForms.SiticoneButton exitButton;
        private Siticone.UI.WinForms.SiticoneButton launchButton;
        private Siticone.UI.WinForms.SiticoneRoundedNumericUpDown selectedclientindex;
        private Siticone.UI.WinForms.SiticoneLabel selectedclientLabel;
    }
}

