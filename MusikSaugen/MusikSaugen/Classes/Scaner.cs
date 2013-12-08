using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MusikSaugen.Classes
{
    public class Scaner
    {
        public Scaner(WebBrowser wb)
        {
           HtmlElement listOfMusic =  wb.Document.GetElementById("initial_list");
            HtmlElementCollection tracksCollection = null;
            try
            {
                 tracksCollection = listOfMusic.GetElementsByTagName("div");
            }
            catch (Exception)
            {
                
                
            }
           
           for (int i = 7; i < tracksCollection.Count; i+=15)
           {
               // <input type="hidden" id="audio_info43419296_246275409" 
               //value="http://cs4533v4.vk.me/u11379045/audios/18857f202635.mp3?extra=HV4zO4SKu52ZY3WWTeminraRRp4KFK08rgFzG44F-sjCdPCN9E3FsvxQdzv7SNhJSuAbGulqcHAQt9b0MU6nGzeFylkxpkY,204">
               HtmlElementCollection input = tracksCollection[i - 4].GetElementsByTagName("input");
               
               string[] halfurl = input[0].GetAttribute("value").Split(',');
               string url = halfurl[0];
               Track track = new Track(tracksCollection[i].InnerText,url); 
               Downloader.AddDownload(track);
           }
           Selector selector = new Selector();
           selector.Show();
           for (int i = 0; i < Downloader.CountOfTracks(); i++)
           {
               selector.checkedListBox1.Items.Add(Downloader.GetTrack(i).GetName());
           } 
           
        }
    }
}
