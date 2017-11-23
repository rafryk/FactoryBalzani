using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample.Models
{
    public class Baby : IPerson
    {
        public string ShowPerson()
        {
            return "Baby";
        }
    }
}
