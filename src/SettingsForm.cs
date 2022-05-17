using System;
using System.Windows.Forms;
using System.IO;

namespace osu_client_switcher
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // set osufolderCurrently and closeonlaunchCurrently
            osufolderCurrently.Text = SettingsLoader.filepath;
            closeonlaunchCurrently.Text = SettingsLoader.closeOnLaunch.ToString();

            // do cool fade in animation #2
            siticoneAnimateWindow1.SetAnimateWindow(this, Siticone.UI.WinForms.SiticoneAnimateWindow.AnimateWindowType.AW_BLEND, 150);
        }

        private void osufolderButton_Click(object sender, EventArgs e)
        {
            // open file dialog
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                // change settings
                SettingsLoader.filepath = folderBrowserDialog1.SelectedPath;

                // set osufolderCurrently
                osufolderCurrently.Text = SettingsLoader.filepath;
            }
        }

        private void closesettingsButton_Click(object sender, EventArgs e)
        {
            SettingsLoader.SaveSettings();
            ActiveForm.Close();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            //! actually closeonlaunchButton

            // change settings
            SettingsLoader.closeOnLaunch = !SettingsLoader.closeOnLaunch;

            // set closeonlaunchCurrently
            closeonlaunchCurrently.Text = SettingsLoader.closeOnLaunch.ToString();
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            // save important files from osu! folder to backup folder
            if (!Directory.Exists("backup"))
                Directory.CreateDirectory("backup");

            foreach (var f in Directory.GetFiles("backup")) {
                // delete old backup files first
                // doesnt work if you dont delete them first for some reason?
                File.Delete(f);
            }

            foreach (var f in SettingsLoader.osufiles)
            {
                var filepath = SettingsLoader.filepath + "/" + f;
                if (File.Exists(filepath))
                {
                    try
                    {
                        File.Copy(filepath, "backup/" + f, true);
                    } catch (Exception ex)
                    {
                        MessageBox.Show("error copying file: " + ex.ToString(), "osu! client switcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // messagebox
            MessageBox.Show("done backing up", "osu! client switcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadbackupButton_Click(object sender, EventArgs e)
        {
            // load osu files from backup folder
            if (Directory.Exists("backup"))
            {
                foreach (var f in SettingsLoader.osufiles)
                {
                    var filepath = SettingsLoader.filepath + "/" + f;
                    if (File.Exists(filepath))
                    {
                        try
                        {
                            File.Copy("backup/" + f, filepath, true);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("error copying file: " + ex.ToString(), "osu! client switcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                // messagebox
                MessageBox.Show("done loading files from backup", "osu! client switcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("you havent backed up your files!", "osu! client switcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void downloadclientsButton_Click(object sender, EventArgs e)
        {
            ClientManager.downloadClients();
        }
    }
}
