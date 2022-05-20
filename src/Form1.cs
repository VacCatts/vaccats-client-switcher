using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace osu_client_switcher
{
    public partial class main : Form
    {
        public int version = 12;
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            // check for updates ((fuck me this code is mess))
            var temp = NetworkManager.DownloadText("https://github.com/VacCatts/vaccats-client-switcher/raw/main/version.txt");
            if (temp == null)
            {
                temp = NetworkManager.DownloadText("https://github.com/VacCatts/vaccats-client-switcher/raw/main/version.txt");
            }
            int temp2 = 0;
            Console.Write(temp);
            temp2 = int.Parse(temp);
            if (temp2 != 0)
            {
                try {
                    if (temp2 > version)
                    {
                        if (MessageBox.Show("new version available!", "osu! client switcher", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            Process.Start("https://github.com/VacCatts/vaccats-client-switcher/releases/");
                            Application.Exit();
                        }
                    }
                } catch { }
            } else
            {
                MessageBox.Show("error while checking updates", "osu! client switcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // do cool fade in animation
            siticoneAnimateWindow1.SetAnimateWindow(this, Siticone.UI.WinForms.SiticoneAnimateWindow.AnimateWindowType.AW_BLEND, 150);

            // check for settings.txt file
            if (!File.Exists("settings.txt"))
            {
                // join discord
                Process.Start("https://discord.gg/MaKghXuEWg");

                // create settings.txt file
                File.Create("settings.txt");

                // show messagebox
                MessageBox.Show("created settings file, please set your osu! folder in the settings", "osu! client switcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                // load stuff
                SettingsLoader.LoadSettings();
                ClientManager.LoadClients();

                // setup client selector
                selectedclientindex.Maximum = ClientManager.loadindex;
                selectedclientLabel.Text = "selected: " + ClientManager.name[(int)selectedclientindex.Value];

            }
            catch
            {

            }
        }

        private void backupcurrentfiles_Click(object sender, EventArgs e)
        {
            Form settingsForm = new SettingsForm();
            settingsForm.Show();
            settingsForm.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            // load client
            if (!((int)selectedclientindex.Value == ClientManager.loadindex)) // custom client selected
                ClientManager.LoadClientToOsuFolderRun(ClientManager.name[(int)selectedclientindex.Value], argsbox.Text);
        }

        private void selectedclientindex_ValueChanged(object sender, EventArgs e)
        {
            if ((int)selectedclientindex.Value == ClientManager.loadindex)
                selectedclientLabel.Text = "selected: no custom client";
            else
                selectedclientLabel.Text = "selected: " + ClientManager.name[(int)selectedclientindex.Value];
        }
    }
}
