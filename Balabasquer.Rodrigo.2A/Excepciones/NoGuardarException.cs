using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excepciones
{
    public class NoGuardarException:Exception
    {
        public NoGuardarException():base()
        {

        }
        public NoGuardarException(string message) : base(message) 
        {

        }
        public NoGuardarException(Exception e, string message) : base(message, e) 
        {

        }
    }
}
