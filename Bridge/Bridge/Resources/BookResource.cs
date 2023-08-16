using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Resources
{
     class BookResource : IResource
     {
          private string _title;
          private string _coverText;
          private string _imageUrl;

          public BookResource(string title, string coverText, string imageUrl)
          {
               _title = title;
               _coverText = coverText;
               _imageUrl = imageUrl;
          }
          public string GetImageUrl()
          {
               return _imageUrl;
          }

          public string GetSnippet()
          {
               return _coverText;
          }

          public string GetTitle()
          {
               return _title;
          }
     }
}
