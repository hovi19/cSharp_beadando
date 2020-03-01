using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA20200223
{
    class Album
    {
        public string id;
        public string artist;
        public string title;
        public DateTime relase;

        public Album(String sor)
        {
            String[] d = sor.Split(';');
            this.id = d[0];
            this.artist = d[1];
            this.title = d[2];
            this.relase = DateTime.Parse(d[3]);
        }
    }
}
