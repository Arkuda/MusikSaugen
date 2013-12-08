using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MusikSaugen.Annotations;

namespace MusikSaugen.Classes
{
    class Downloader
    {
        private static List<Track> StackOfDownloads = new List<Track>(); 
        public static  string FolderToDownload = "C:\\";
        public static CheckedListBox checkedList;
         

        public static void AddDownload(Track track)
        {
            StackOfDownloads.Add(track);
        }

        public static Track GetTrack(int pos)
        {
            return StackOfDownloads[pos];
        }
        public static Track GetTrack(string name)
        {
            Predicate<Track> tPredicate = track => track.GetName() == name;
            return StackOfDownloads.Find(tPredicate);
        }
        

        public static int CountOfTracks()
        {
            return StackOfDownloads.ToArray().Length;
        }

 

        internal static void StartDownload(object obj)
        {
            MessageBox.Show("Downloading Started...");
            List<Track> downloads = new List<Track>();
            for (int i = 0; i < checkedList.Items.Count; i++)
            {
                try
                {
                    Track track = GetTrack(checkedList.CheckedItems[i].ToString());
                    downloads.Add(track);
                    //MessageBox.Show(track.GetName());
                }
                catch (Exception)
                {
                    
                  
                }
                
            }

           // DownloadProgress DP = new DownloadProgress();
            //DP.Show();
            //DP.progressBar1.Maximum = downloads.Count;
            //DP.progressBar1.Maximum = 0;

            for (int i = 0; i < downloads.ToArray().Length; i++)
            {         
                using (WebClient Client = new WebClient())
                {
                    Client.DownloadFile(downloads[i].GetLink(), FolderToDownload + "/" + downloads[i].GetName() + ".mp3");

                    //DP.progressBar1.Value = i;
                    //DP.label1.Text = "Downloading..." + downloads[i].GetName() + "(" + i + "/" + downloads.ToArray().Length + ")";
                    
                }
            }

           // throw new NotImplementedException();
        }

    }
}
