using System;

namespace modul5_1302204002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo stv1 = new SayaTubeVideo("Attack On Titan");
            SayaTubeVideo stv2 = new SayaTubeVideo("Sword Art Online");
            SayaTubeVideo stv3 = new SayaTubeVideo("OreApo");

            SayaTubeUser stu = new SayaTubeUser("Sandhyka");
            stu.addVideo(stv1);
            stu.addVideo(stv2);
            stu.addVideo(stv3);

            stu.printAllVideoPlayCount();

        }
    }
}