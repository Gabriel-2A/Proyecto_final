using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Informe : Form
    {
        public static List<Tarea> tareas;
        public Informe(List<Tarea> tareillas)
        {
            InitializeComponent();
            tareas = tareillas;
        }

        int cantTodo = 0;
        int cantEscuela = 0;
        int cantTrabajo = 0;
        int cantPersonal = 0;
        int cantUrgentes = 0;
        int cantCompletadas = 0;
        int cantNoCompletadas = 0;

        private void Form4_Load(object sender, EventArgs e)
        {
            cantTodo = tareas.Count;

            for (int i = 0; i<tareas.Count ; i++ ) {

                if (tareas[i].esCompletada == true) {
                    cantCompletadas++;
                }else if ( (tareas[i].esCompletada) == false) {
                    cantNoCompletadas++;
                }

                if (tareas[i].categoria.ToLower() == "escuela") 
                { 
                    cantEscuela++;
                }else if (tareas[i].categoria.ToLower() == "trabajo")
                {
                    cantTrabajo++;
                }else if (tareas[i].categoria.ToLower() == "personal")
                {
                    cantPersonal++;
                }else if (tareas[i].categoria.ToLower() == "urgente")
                {
                    cantUrgentes++;
                }
            }

            todo.Text = cantTodo + "";
            escuela.Text = cantEscuela + "";
            trabajo.Text = cantTrabajo + "";
            personal.Text = cantPersonal + "";
            urgente.Text = cantUrgentes + "";
            completadas.Text = cantCompletadas + "";
            noCompletadas.Text = cantNoCompletadas + "";

        }
    }
}
