using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
     class MusicPlayer
     {
          private static MusicPlayer _instance = null!;
          private static object locker = new object();

          public int volume { get; set; }
          private MusicPlayer()
          {
               Console.WriteLine("Music player is on!!!");
          }
          public static MusicPlayer GetInstance()
          {
               if (_instance == null)
               {
                    lock (locker)
                    {
                         if (_instance == null)
                              _instance = new MusicPlayer();
                    }
               }
               return _instance;
          }
          public void PlayMusic(string filename)
          {
               Console.WriteLine($"{filename}...");
          }
          public void StopMusic()
          {
               Console.WriteLine("Music Stoped");
          }
     }
}
