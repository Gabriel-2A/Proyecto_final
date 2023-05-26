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
                MessageBox.Show("El index es" + index);

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
            listBox1.Items.Remove(listBox1.SelectedItem);
            tareas.Remove(tareas[listBox1.SelectedIndex]);
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
            /*switch (cat)
            {
                case "Escuela":
                    Filtrar(cat);
                    listBox1.Items.Clear();
                    for(int i = 0; i < TareasFiltradas.Count; i++) 
                    {
                        listBox1.Items.Insert(i, TareasFiltradas[i]);
                    }
                    listBox1.Refresh();
                    break;

                case "Trabajo":
                    Filtrar(cat);
                    listBox1.Items.Clear();
                    for (int i = 0; i < TareasFiltradas.Count; i++)
                    {
                        listBox1.Items.Insert(i, TareasFiltradas[i]);
                    }
                    listBox1.Refresh();
                    break;

                case "Personal":
                    Filtrar(cat);
                    listBox1.Items.Clear();
                    for (int i = 0; i < TareasFiltradas.Count; i++)
                    {
                        listBox1.Items.Insert(i, TareasFiltradas[i]);
                    }
                    listBox1.Refresh();
                    break;

                case "Urgente":
                    Filtrar(cat);
                    listBox1.Items.Clear();
                    for (int i = 0; i < TareasFiltradas.Count; i++)
                    {
                        listBox1.Items.Insert(i, TareasFiltradas[i]);
                    }
                    listBox1.Refresh();
                    break;

                case "Completadas":
                    Filtrar(cat);
                    listBox1.Items.Clear();
                    for (int i = 0; i < TareasFiltradas.Count; i++)
                    {
                        listBox1.Items.Insert(i, TareasFiltradas[i]);
                    }
                    listBox1.Refresh();
                    break;

                case "No Completadas":
                    Filtrar(cat);
                    listBox1.Items.Clear();
                    for (int i = 0; i < TareasFiltradas.Count; i++)
                    {
                        listBox1.Items.Insert(i, TareasFiltradas[i]);
                    }
                    listBox1.Refresh();
                    break;
            }*/

            InsertarTareasFiltradas(cat);
        }
//listBox1.Sorted.CompareTo(tareas[listBox1.SelectedIndex].categoria);
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

        public void InsertarTareasFiltradas(string parametro)
        {
            if (string.IsNullOrEmpty(parametro) != true)
            {
                FiltrarPorCategoria(parametro);
                listBox1.Items.Clear();
                for (int i = 0; i < TareasFiltradas.Count; i++)
                {
                    listBox1.Items.Insert(i, TareasFiltradas[i]);
                }
                listBox1.Refresh();
            }
            else
            {
                for (int i = 0; i < TareasFiltradas.Count; i++)
                {
                    listBox1.Items.Insert(i, tareas[i]);
                }
            }
        }
    }
}
