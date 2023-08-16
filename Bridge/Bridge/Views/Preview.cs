using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Views
{
     class Preview : View
     {
          public override string Generate()
          {
               string text = "";
               Console.WriteLine("Generating a Preview view ...");

               text = $"ImageUrl: {Resource.GetImageUrl()}\n";
                    

               return text;
          }
     }
}
