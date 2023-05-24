using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        Form1 form = new Form1();

        public TextBox GetTextBox1()
        {
            return this.textBox1;
        }

        public ComboBox GetComboBox()
        {
            return this.comboBox1;
        }

        public DateTimePicker GetDateTimePicker()
        {
            return this.dateTimePicker1;
        }

        public TextBox GetTextBox2()
        {
            return this.textBox2;
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //ListBox listBox = form.GetListBox();

            //textBox1.Lines[0] = Form1.tareas[listBox.SelectedIndex].titulo;
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            ListBox listBox = form.GetListBox();
            Tarea newTarea = new Tarea(textBox1.Text, comboBox1.SelectedItem.ToString(), dateTimePicker1.Value, textBox2.Text);

            Form1.tareas[listBox.SelectedIndex] = newTarea;
        }
    }
}
