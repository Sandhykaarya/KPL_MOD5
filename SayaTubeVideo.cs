using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace modul5_1302204002
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount = 2147483641;
        Random random = new Random();

        public SayaTubeVideo(string x)
        { 
            id = random.Next(10000,99999);
            playCount = 0;
            this.title = x;

            Contract.Requires(title.Length <= 200);
            Contract.Requires(title != null);
        }

        public void increasePlayCount(int x)
        {
            playCount+=1;
            Contract.Requires(playCount <= 25000000);
            Contract.Requires(playCount > 0);

            checked
            {
                try
                {
                    playCount = 2147483647;
                }
                catch(Exception)
                {
                    Console.WriteLine("Play Count melebihi batas tertinggi integer");
                }
            }
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
