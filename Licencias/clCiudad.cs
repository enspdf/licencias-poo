using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licencias
{
    class clCiudad
    {
        private string _codigoCiudad;
        public string CodigoCiudad
        {
            get { return _codigoCiudad; }
            set { _codigoCiudad = value; }
        }

        private string _nombreCiudad;
        public string NombreCiudad
        {
            get { return _nombreCiudad; }
            set { _nombreCiudad = value; }
        }

    }
}
