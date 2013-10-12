using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacto
{
     public class Contacto
    {
        string nombre;
        string telefono;
        string direccion;
        public string _nombre
        {

            get
            {
                return nombre;
            }
            set
            { nombre = value;
            }
        }
        public string _telefono
        {

            get
            {
                return telefono ;
            }
            set
            {
                telefono  = value;
            }
        }
        public string _direccion
        {

            get
            {
                return direccion;
            }
            set
            {
                direccion  = value;
            }
        }
        
    }
}
