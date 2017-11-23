using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample.Models
{
    static class AgeSelector 
    {
        public static  IPerson Select(int age)
        {
            if(age>0 && age<4)
            {
                return new Baby();
            }
            else if(age>3 && age<13)
            {
                return new Kid();
            }
            else if(age>12 && age<20)
            {
                return new Teen();
            }
            else if(age>19)
            {
                return new Adult();
            }
            else
            {
                throw new Exception("age not valid");
            }
        }
    }
}
