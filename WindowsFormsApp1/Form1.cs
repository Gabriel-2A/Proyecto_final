using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public  System.Windows.Forms.ListBox GetListBox()
        {
            return this.listBox1;
        }

        Tarea tarea = new Tarea();
        public static List <Tarea> tareas = new List <Tarea>();
        public List <Tarea> TareasFiltradas = new List <Tarea>();
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private static int index = 0;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try { 
            Form2 form = new Form2();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
                listBox1.Items.Insert(index, tareas[index].ToString());
                index++;
            } catch (Exception ex)
            {
                //MessageBox.Show("El index es" + index);

            }
        }
        
        
        private void Actualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(listBox1);
            
            form.GetTextBox1().Text = tareas[listBox1.SelectedIndex].titulo;
            form.GetComboBox().Text = tareas[listBox1.SelectedIndex].categoria;
            form.GetDateTimePicker().Value = tareas[listBox1.SelectedIndex].fechaVencimiento;
            form.GetTextBox2().Text = tareas[listBox1.SelectedIndex].descripcion;
            form.GetCheckBox().Checked = tareas[listBox1.SelectedIndex].esCompletada;
            form.ShowDialog();

            listBox1.Items.Insert(listBox1.SelectedIndex, tareas[listBox1.SelectedIndex]);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                tareas.Remove(tareas[listBox1.SelectedIndex]);
            } catch (Exception ex) { }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void marcarComoCompletadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tareas[listBox1.SelectedIndex].esCompletada = true;
            
        }

        private void aceparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cat = FiltrarCategoria.SelectedItem.ToString();

            if(cat == "Todo")
            {
                
            } else if(cat == "Escuela" || cat == "Trabajo" || cat == "Personal" || cat == "Urgente")
            {
                FiltrarPorCategoria(cat);
            }
            else if (cat == "Completadas" || cat == "No Completadas")
            {
                FiltrarPorCompletadosONoCompletados(cat);
            }
            InsertarTareasFiltradas(cat);
            
            
        }

        public void FiltrarPorCategoria(string parametro)
        {
            TareasFiltradas.Clear();

            for(int i = 0; i < tareas.Count; i++)
            {
                if (tareas[i].categoria == parametro)
                {
                    TareasFiltradas.Add(tareas[i]);
                } 
            }
        }

        public void FiltrarPorCompletadosONoCompletados(string parametro)
        {
            TareasFiltradas.Clear();

            for (int i = 0; i < tareas.Count; i++)
            {
                if (parametro == "Completadas" && tareas[i].esCompletada == true)
                { 
                    TareasFiltradas.Add(tareas[i]);
                } else if (parametro == "No Completadas" && tareas[i].esCompletada == false)
                {
                    TareasFiltradas.Add(tareas[i]);
                }
                
            }
        }

        public void InsertarTareasFiltradas(string parametro)
        {
            if (string.IsNullOrEmpty(parametro) != true && parametro != "Todo")
            {
                listBox1.Items.Clear();
                for (int i = 0; i < TareasFiltradas.Count; i++)
                {
                    listBox1.Items.Insert(i, TareasFiltradas[i]);
                }
                listBox1.Refresh();
            }
            else
            {
                listBox1.Items.Clear();
                for (int i = 0; i < tareas.Count; i++)
                {
                    listBox1.Items.Insert(i, tareas[i]);
                }
                listBox1.Refresh();
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.DropDownItems.Clear();
            for (int i = 0; i < tareas.Count; i++) 
            {
                if (TareaCercaDeDiaLimite(tareas[i].fechaVencimiento))
                {
                    toolStripDropDownButton1.DropDownItems.Insert(i, new ToolStripMenuItem("" + tareas[i]));
                }

            }
            toolStripDropDownButton1.DropDownDirection = ToolStripDropDownDirection.Left;
            toolStripDropDownButton1.DropDownDirection = ToolStripDropDownDirection.BelowRight;
        }

        private bool TareaCercaDeDiaLimite(DateTime deadLineDate)
        {
            DateTime fechaActual = DateTime.Now;
            TimeSpan diferencia = deadLineDate.Date - fechaActual.Date;

            if (diferencia.Days <= 2)
            {
                return true;
            }
            return false;
        }
    }
}
