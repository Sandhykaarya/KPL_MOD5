using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

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

            Contract.Requires(username.Length <= 100);
            Contract.Requires(username != null);
        }

        public int getTotalVideoPlayCount()
        {
            Contract.Requires(uploadedVideos.Count <= 2147483647);
            return uploadedVideos.Count;
        }

        public void addVideo(SayaTubeVideo x)
        {
            uploadedVideos.Add(x);
            Contract.Requires(uploadedVideos != null);
        }

        public void printAllVideoPlayCount()
        {
            Console.WriteLine("User: " + this.username);
            for(int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i+1) + " judul: " + uploadedVideos[i].getTitle());
            }

            Contract.Ensures(uploadedVideos.Count < 9);
        }
    }
}
