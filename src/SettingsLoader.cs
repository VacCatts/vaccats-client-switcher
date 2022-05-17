using System;
using System.IO;
using System.Windows.Forms;

namespace osu_client_switcher
{
    class SettingsLoader
    {
        public static string filepath = "";
        public static bool closeOnLaunch = false;
        public static string[] osufiles = {};
        public static void LoadSettings()
        {
            try
            {
                // load settings.txt
                string[] lines = File.ReadAllLines("settings.txt");

                // check if settings.txt is empty
                if (lines.Length == 0)
                {
                    // show messagebox
                    MessageBox.Show("please set your osu! folder in the settings", "osu! client switcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // set filepath
                    filepath = lines[0];

                    // set closeOnLaunch
                    if (lines[1] == "True") { closeOnLaunch = true; } else closeOnLaunch = false;
                }

                // set osufiles
                if (File.Exists("osufiles.txt"))
                {
                    osufiles = File.ReadAllLines("osufiles.txt");
                } else
                {
                    File.WriteAllText("osufiles.txt", NetworkManager.DownloadText("https://pastebin.com/raw/mMbbwP2M"));
                    osufiles = File.ReadAllLines("osufiles.txt");

                    if (osufiles.Length == 0)
                    {
                        // no idea why this makes it work properly but it does
                        osufiles = File.ReadAllLines("osufiles.txt");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error while loading settings: " + ex.Message, "osu! client switcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SaveSettings()
        {
            try
            {
                // save filepath and closeOnLaunch to settings.txt
                File.WriteAllText("settings.txt", $"{filepath}\n{closeOnLaunch}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error while saving settings: " + ex.Message, "osu! client switcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
