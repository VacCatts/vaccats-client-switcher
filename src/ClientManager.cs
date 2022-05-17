using System;
using System.IO;
using System.Windows.Forms;
using ICSharpCode.SharpZipLib.Zip;
using System.Threading;
using System.Diagnostics;

namespace osu_client_switcher
{
    class ClientManager
    {
        public static string[] name = new string[10];
        public static int loadindex = 0;
        static string[] name2 = new string[10];
        static string[] url = new string[10];
        static string[] version = new string[10];
        static int amount = 0;

        public static void downloadClients()
        {
            // create new thread to execute downloadClientsJob()
            Thread thread = new Thread(downloadClientsJob);
            thread.Start();

            MessageBox.Show("downloading clients", "osu! client switcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void downloadClientsJob()
        {
            try
            {
                if (name2[0] == null) {
                    downloadClientList();
                }

                // download clients
                for (int i = 0; i < amount; i++)
                {
                    var filepath = "clients/" + name2[i] + "/";
                    if (!Directory.Exists(filepath))
                        Directory.CreateDirectory(filepath);

                    // download client
                    NetworkManager.DownloadFile(url[i], filepath + "temp.zip");

                    // unzip client
                    FastZip fZip = new FastZip();
                    fZip.ExtractZip(filepath + "temp.zip", filepath, "");

                    File.Delete(filepath + "temp.zip");
                }

                MessageBox.Show("done downloading clients!", "osu! client switcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show("error while downloading clients: " + ex.Message, "osu! client switcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void downloadClientList()
        {
            string clientlist;
            try
            {
                File.WriteAllText("clientlist.txt", NetworkManager.DownloadText("https://pastebin.com/raw/K6S8j9hU"));
                clientlist = File.ReadAllText("clientlist.txt");

                if (clientlist.Length == 0)
                {
                    clientlist = File.ReadAllText("clientlist.txt");
                }

                Console.WriteLine(clientlist);
                var lines = clientlist.Split('\n');
                foreach (var i in lines)
                {
                    var p = i.Split(' ');
                    name2[amount] = p[0];
                    url[amount] = p[1];
                    version[amount] = p[2];

                    amount++;
                }
            } catch (Exception ex)
            {
                MessageBox.Show("error while downloading client list: " + ex.Message, "osu! client switcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void LoadClients()
        {
            foreach(var dir in Directory.GetDirectories("clients"))
            {
                name[loadindex] = dir;
                loadindex++;
            }
        }

        public static void LoadClientToOsuFolderRun(string name)
        {
            // create new thread to execute LoadClientToOsuFolder()
            Thread thread = new Thread(() => LoadClientToOsuFolder(name));
            thread.Start();

            MessageBox.Show("starting client", "osu! client switcher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void LoadClientToOsuFolder(string name)
        {
            name = name.Remove(0, 8);
            var dir = Directory.GetCurrentDirectory() + "\\clients\\" + name;

            // load osu files from backup folder
            if (Directory.Exists(dir))
            {
                string[] files = Directory.GetFiles(dir);

                foreach (string s in files)
                {
                    var fileName = Path.GetFileName(s);
                    var destFile = Path.Combine(SettingsLoader.filepath, fileName);
                    File.Delete(destFile);
                    File.Copy(s, destFile, true);
                }

                try
                {
                    File.Delete(Path.Combine(SettingsLoader.filepath, ".require_update"));
                    Directory.Delete(Path.Combine(SettingsLoader.filepath, "\\_staged"));
                }
                catch
                {

                }
            }

            // run osu! client
            try {
                Process.Start(SettingsLoader.filepath + "/osu!.exe");
            } catch(Exception ex) {
                MessageBox.Show("error while starting game: " + ex.Message, "osu! client switcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
