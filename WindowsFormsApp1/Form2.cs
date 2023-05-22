using System;
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
    public partial class Form2 : Form
    {
        
        
        

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) || comboBox1.SelectedItem == null)
            { 
                MessageBox.Show("Faltan Datos");
            } else
            {
                Tarea tarea = new Tarea(textBox1.Text, textBox2.Text, DateTime.Parse(dateTimePicker1.Text), comboBox1.SelectedItem.ToString());
                Form1.tareas.Add(tarea);

                Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
