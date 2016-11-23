using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class NoLeerException:Exception
    {
        public NoLeerException():base() 
        {

        }
        public NoLeerException(string message):base(message) 
        {

        }
    }
}
