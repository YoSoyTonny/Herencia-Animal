using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Ave : Animal
    {
        public string ponerHuevo()
        {
            return Nombre + " puso un huevón";
        }
        override public string desplazar()
        {
            return Nombre + " esta volando weon";
        }
    }
}
