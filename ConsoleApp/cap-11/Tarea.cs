using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_11
{
    internal class Tarea
    {
        public string Nombre {  get; set; }
        public DateTime FechaLimite { get; set; }

        public EstadoTarea Estado {  get; set; }


        public enum EstadoTarea { PENDIENTE, COMPLETADO, VENCIDO };


        public Tarea() { 
            Nombre = string.Empty;
            FechaLimite = DateTime.Now.AddDays(7.0);
            Estado = EstadoTarea.PENDIENTE;
        }
    
    }

}
