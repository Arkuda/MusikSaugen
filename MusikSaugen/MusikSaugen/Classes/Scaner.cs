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
           HtmlElementCollection tracksCollection = listOfMusic.GetElementsByTagName("div");
           for (int i = 7; i < tracksCollection.Count; i+=15)
           {
               // <input type="hidden" id="audio_info43419296_246275409" 
               //value="http://cs4533v4.vk.me/u11379045/audios/18857f202635.mp3?extra=HV4zO4SKu52ZY3WWTeminraRRp4KFK08rgFzG44F-sjCdPCN9E3FsvxQdzv7SNhJSuAbGulqcHAQt9b0MU6nGzeFylkxpkY,204">
               var input = tracksCollection[i - 4].GetElementsByTagName("input");
               var url = input[0].GetAttribute("value");
               Track track = new Track(tracksCollection[i].InnerText,url); 
           }
        }
    }
}
