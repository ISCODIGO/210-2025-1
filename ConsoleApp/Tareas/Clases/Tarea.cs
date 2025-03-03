using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas.Clases
{
    internal class Tarea
    {
        public string Nombre { get; set; }
        public DateTime FechaLimite { get; set; }

        public EstadoTarea Estado { get; set; }

        public enum EstadoTarea { PENDIENTE, COMPLETADO, VENCIDO };

        public Tarea(string Nombre, DateTime fechaLimite, EstadoTarea estado)
        {
            this.Nombre = Nombre;
            FechaLimite = fechaLimite;
            Estado = estado;
        }

        public Tarea(string nombre, DateTime fecha)
        {
            Nombre = nombre;
            FechaLimite = fecha;
            Estado = EstadoTarea.PENDIENTE;
        }

        public Tarea(string nombre)
        {
            Nombre = nombre;
            FechaLimite = DateTime.Now.AddDays(7);
            Estado = EstadoTarea.PENDIENTE;
        }

        public void Finalizar()
        {
            Estado = EstadoTarea.COMPLETADO;
        }

        public bool Posponer(DateTime nuevaFecha)
        {
            if (FechaLimite >= nuevaFecha)
            {
                return false;
            }

            if (Estado == EstadoTarea.COMPLETADO)
            {
                return false;
            }

            FechaLimite = nuevaFecha;
            return true;
        }

        override public string ToString()
        {
            return $"{GetEstadoConEmoticono()} {FechaLimite.ToString("d")} {Nombre}";
        }

        private string GetEstadoConEmoticono()
        {
            return this.Estado switch
            {
                Tarea.EstadoTarea.PENDIENTE => "⏳",
                Tarea.EstadoTarea.COMPLETADO => "✅",
                Tarea.EstadoTarea.VENCIDO => "🕒",
                _ => "❓ Desconocido"
            };
        }
    }

}
