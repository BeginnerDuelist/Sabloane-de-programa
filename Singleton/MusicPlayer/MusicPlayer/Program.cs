namespace Singleton
{
     class Program
     {
          public static void Main(string[] args)
          {
               MusicPlayer.GetInstance().volume += 20;
               MusicPlayer.GetInstance().PlayMusic("After Dark.mp3");
               MusicPlayer.GetInstance().StopMusic();
          }
     }
}