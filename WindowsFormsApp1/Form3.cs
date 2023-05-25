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
        private ListBox listBox;

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

        public CheckBox GetCheckBox()
        {
            return this.checkBox1;
        }

        public Form3(ListBox listBox)
        {
            InitializeComponent();
            this.listBox = listBox;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //ListBox listBox = form.GetListBox();

            //textBox1.Lines[0] = Form1.tareas[listBox.SelectedIndex].titulo;
        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            
            
            Tarea newTarea = new Tarea(textBox1.Text, textBox2.Text, dateTimePicker1.Value, comboBox1.SelectedItem.ToString(), checkBox1.Checked);

            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) || comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Faltan Datos");
                }
                else
                {
                    Form1.tareas[listBox.SelectedIndex] = newTarea;
                    Close();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("El indice es" + listBox.SelectedIndex);

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
