using Bridge.Resources;
using Bridge.Views;

namespace Bridge
{
     class Program
     {
          static void Main(string[] args)
          {
               View view = new ShortView();
               view.Resource = new BookResource("Luceafarul", "Mihai Eminescu", "images.png");

               string text = view.Generate();
               Console.WriteLine(text);
          }
     }
}