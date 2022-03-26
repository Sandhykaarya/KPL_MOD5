using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302204002
{
    internal class SayaTubeUser
    {
        private int id;
        List<SayaTubeVideo> uploadedVideos;
        public string username;
        Random random = new Random();

        public SayaTubeUser(string x)
        {
            id = random.Next(10000, 99999);
            uploadedVideos = new List<SayaTubeVideo>();
            this.username = x;
        }

        public int getTotalVideoPlayCount()
        {
            return uploadedVideos.Count;
        }

        public void addVideo(SayaTubeVideo x)
        {
            uploadedVideos.Add(x);
        }

        public void printAllVideoPlayCount()
        {
            Console.WriteLine("User: " + this.username);
            for(int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i+1) + " judul: " + uploadedVideos[i].getTitle());
            }
        }
    }
}
