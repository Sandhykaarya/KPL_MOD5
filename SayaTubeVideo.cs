using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204002
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;
        Random random = new Random(); 

        public SayaTubeVideo(string x)
        {
            id = random.Next(10000,99999);
            playCount = 0;
            this.title = x;
        }

        public void increasePlayCount(int x)
        {
            playCount+=1;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Play Count: " + this.playCount);
        }

        public string getTitle()
        {
            return this.title;
        }
    }
}
