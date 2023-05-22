using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class Tarea
    {
        public string titulo;
        public string descripcion;
        public DateTime fechaVencimiento;
        public DateTime fechaInicio = DateTime.Today;
        public string categoria;

        public Tarea(string titulo, string descripcion, DateTime fechaVencimiento, string categoria)
        {
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.fechaVencimiento = fechaVencimiento;
            this.categoria = categoria;
        }

        public override string ToString()
        {
            return titulo + " " + categoria + " " + fechaVencimiento;
        }
    }
}
