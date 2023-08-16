using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Resources
{
     class WriterResource:IResource
     {
          private string _title;
          private string _biography;
          private string _imageUrl;

          public WriterResource(string title, string biography, string imageUrl)
          {
               _title = title;
               _biography = biography;
               _imageUrl = imageUrl;
          }
          public string GetImageUrl()
          {
               return _imageUrl;
          }

          public string GetSnippet()
          {
               return _biography;
          }

          public string GetTitle()
          {
               return _title;
          }

     }
}
