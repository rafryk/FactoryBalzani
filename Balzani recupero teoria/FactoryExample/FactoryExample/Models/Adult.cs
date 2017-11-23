using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample.Models
{
    public class Adult : IPerson
    {
        public string ShowPerson()
        {
            return "Adult";
        }
    }
}
