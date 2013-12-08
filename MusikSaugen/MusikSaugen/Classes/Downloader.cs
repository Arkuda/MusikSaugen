using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusikSaugen.Classes
{
    class Downloader
    {
        public Track[] StackOfDownloads;

        public void AddDownload(Track track)
        {
            StackOfDownloads[StackOfDownloads.Length+1] = track;
        }

    }
}
