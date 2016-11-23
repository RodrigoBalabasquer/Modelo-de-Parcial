using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libreria
{
    public abstract class Local
    {
        protected int _legajo;
        public Local() 
        {

        }
        public Local(int legajo)
        {
            this._legajo = legajo;
        } 
        protected abstract int Legajo
        {
            get;
            set;
        }
        public override string ToString()
        {
            return this._legajo.ToString();
        }
    }
}
