using Bridge.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Views
{
     abstract class View
     {
          public IResource Resource { get; set; }
          public abstract string Generate();
     }
}
