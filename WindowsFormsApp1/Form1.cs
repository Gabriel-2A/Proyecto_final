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
        public static List <Tarea> tareas = new List <Tarea>();
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            Tarea tarea = new Tarea("qwq", "qwqw", DateTime.Now, "pepepepe");
            tareas.Add(tarea);

            ListViewItem item = new ListViewItem();
            item.Text = tareas.Last().ToString();
            item.Tag = tareas.Last();

            listView1.Items.Add(item);
        }*/
static int index = 0;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();

            //tareas.Add(new Tarea("Titulo", "descripcion", DateTime.Now, "categoria"));
            //ListBoxItem item = new ListBoxItem();

            //listBox1.Items.Add(""+tareas.Last());
            listBox1.Items.Insert(index, tareas[index].ToString());
            index++;
        }
        
        
        private void Actualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
            
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            tareas.Remove(tareas[listBox1.SelectedIndex]);
        }
    }
}
