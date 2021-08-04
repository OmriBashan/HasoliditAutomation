using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure;

namespace Extensions
{
    public static class TopbarExtensions 
    {
        public static HomePage SearchQuery (this HomePage page , string text)
        {
            return page.TopBarComponent.Search(text);
        }
    }
}
