using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CA20200223
{


    class Program
    {
        static List<Album> Albumok = new List<Album>();
        static List<Track> Tracks = new List<Track>(); 
        static void Main(string[] args)
        {
            
            var sr = new StreamReader(@"linkinpark.txt", Encoding.UTF8);
            //var sr = new StreamReader(@"pendulum.txt", Encoding.UTF8);
            var sw = new StreamWriter(@"tabla.txt", false, Encoding.UTF8);
            

            while (sr.ReadLine()!= "[tracks]")
            {
                Albumok.Add(new Album(sr.ReadLine()));
            }
           
            while (!sr.EndOfStream)
            {
                Tracks.Add(new Track(sr.ReadLine()));
            }
           
        
            foreach (var a in Albumok)
            {
                sw.WriteLine("INSERT INTO albums VALUES " + "('" + a.id + "', '" + a.artist + "', '" + a.title + "', '" + a.relase + "');");
            }
            
            foreach (var t in Tracks)
            {
                sw.WriteLine("INSERT INTO tracks VALUES "+"('" +t.title+"', '"+t.lenght+"', '"+t.album+"', '" + t.url+"');");
            }

            sw.Close();
            sr.Close();
            Console.ReadKey();



        }
    }
}
