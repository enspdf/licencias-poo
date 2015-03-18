using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licencias
{
    class clTransito
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
            get {return _nombreCiudad;}
            set {_nombreCiudad=value;}
        }
        
        private string _codigoTransito;
        public string CodigoTransito
        {
            get {return _codigoTransito;}
            set {_nombreTransito = value;}
        }

        private string _nombreTransito;
        public string NombreTransito
        {
            get { return _nombreTransito; }
            set { _nombreTransito = value; }
        }

        public int ValorLicencia
        {
            get
            {
                if (_nombreTransito == "Caribe" || _nombreTransito == "Municipal")
                {
                    return 125000;
                }
                if (_nombreTransito == "Bello" || _nombreTransito == "Envigado" || _nombreTransito == "Itagui")
                {
                    return 150000;
                }
                else
                {
                    return 80000;
                }
            }
        }
    }
}
