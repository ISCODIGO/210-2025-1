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

        public Tarea(string Nombre, DateTime fechaLimite, EstadoTarea estado)
        {
            this.Nombre = Nombre;
            this.FechaLimite = fechaLimite;
            this.Estado = estado;
        }

        public Tarea(string nombre, DateTime fecha) { 
            this.Nombre = nombre;
            this.FechaLimite = fecha;
            this.Estado = EstadoTarea.PENDIENTE;
        }

        public Tarea(string nombre)
        {
            this.Nombre = nombre;
            this.FechaLimite = DateTime.Now.AddDays(7);
            this.Estado = EstadoTarea.PENDIENTE;
        }

        public void Finalizar()
        {
            this.Estado = EstadoTarea.COMPLETADO;
        }
       
        public bool Posponer(DateTime nuevaFecha)
        {
            if (this.FechaLimite >= nuevaFecha)
            {
                return false;
            }

            if (this.Estado == EstadoTarea.COMPLETADO)
            {
                return false;
            }

            this.FechaLimite = nuevaFecha;
            return true;
        }
    }

}
