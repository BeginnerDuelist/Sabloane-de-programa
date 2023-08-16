using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Views
{
     class ShortView : View
     {
          public override string Generate()
          {
               string text = "";
               Console.WriteLine("Generating Short view ...");

               text = $"Title: {Resource.GetTitle()}\n" +
                    $"ImageUrl: {Resource.GetImageUrl()}\n";
                   

               return text;
          }
     }
}
