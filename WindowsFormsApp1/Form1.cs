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
    }
}
