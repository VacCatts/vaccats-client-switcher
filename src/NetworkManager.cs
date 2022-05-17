using System;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace osu_client_switcher
{
    class NetworkManager
    {
        // download text from url
        public static string DownloadText(string url)
        {
            try
            {
                // create webclient
                WebClient client = new WebClient();

                // download text
                string text = client.DownloadString(url);

                // return text
                return text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("error while downloading: " + ex.Message, "osu! client switcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        // download file from url
        public static void DownloadFile(string url, string path)
        {
            try
            {
                // create webclient
                WebClient client = new WebClient();

                // download file
                client.DownloadFile(url, path);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error while downloading: " + ex.Message, "osu! client switcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
