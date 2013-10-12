using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacto;
using  System.Data;
using  System.Data.SqlClient;



namespace Contacto
{
    public class Empresa:Contacto 
    {
       
        string ruc;
        public string _ruc
        {

            get
            {
                return ruc;
            }
            set
            {
                ruc = value;
            }
        }

        public Empresa(string Nombre, string Telefono, string Direccion, string Ruc)
        {
            _nombre = Nombre;
            _telefono = Telefono;
            _direccion = Direccion;
            _ruc = Ruc;

        }

        
    }
}
