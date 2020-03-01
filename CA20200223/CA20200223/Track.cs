using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA20200223
{
    class Track
    {
        public string title;
        public TimeSpan lenght;
        public string album;
        public string url;

        public Track(String sor)
        {
            String[] d = sor.Split(';');
            this.title = d[0];
            this.lenght = TimeSpan.Parse(d[1]);
            this.album = d[2];
            this.url = d[3];
        }
    }
}
