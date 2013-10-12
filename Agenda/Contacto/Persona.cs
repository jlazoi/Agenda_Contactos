using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacto
{
  public  class Persona:Contacto 
    {   string dni;
        public string _dni
        {

            get
            {
                return dni ;
            }
            set
            {
                dni  = value;
            }
        }

        public Persona(string Nombre, string Telefono, string Direccion, string Dni)
        {
            _nombre = Nombre;
            _telefono = Telefono;
            _direccion = Direccion;
            _dni = Dni;

        }
    }
}
