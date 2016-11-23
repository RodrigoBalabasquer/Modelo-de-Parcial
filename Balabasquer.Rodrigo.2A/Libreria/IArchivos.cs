using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Libreria
{
    public interface IArchivos<T>
    {
        void Guardar();
        void Leer();
    }
}
