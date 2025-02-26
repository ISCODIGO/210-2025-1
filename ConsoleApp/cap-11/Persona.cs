using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_11
{
    public class Persona
    {
        public string nombre;  // atributo
        public DateOnly fechaNacimiento;
        private string _ciudad;

        public string Ciudad
        {
            get
            {
                return _ciudad;
            }

            /*set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if (!value.Equals("Tegucigalpa"))
                    {
                        _ciudad = value;
                    }
                }
            }*/
        }

    }
}
