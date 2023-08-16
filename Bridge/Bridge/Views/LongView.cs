using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Views
{
     class LongView : View
     {
          public override string Generate()
          {
               string text = "";
               Console.WriteLine("Generating  Long view ...");

               text = $"Title: {Resource.GetTitle()}\n" +
                    $"ImageUrl: {Resource.GetImageUrl()}\n" +
                    $"Snippet: {Resource.GetSnippet()}\n"; 

               return text;
          }
     }
}
