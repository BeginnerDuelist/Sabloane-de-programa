using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Resources
{
     interface IResource
     {
          public string GetTitle();
          public string GetImageUrl();
          public string GetSnippet();

     }
}
