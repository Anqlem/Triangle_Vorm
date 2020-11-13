using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_Triangle
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            Triangle triangle = new Triangle(a, b, c);
            listView1.Items.Add("Сторона a");
            listView1.Items.Add("Сторона b");
            listView1.Items.Add("Сторона c");
            listView1.Items.Add("Биссектриса угла C");
            listView1.Items.Add("Теорема Пифагора");
            listView1.Items.Add("Радиус");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Существует?");
            listView1.Items.Add("Тип треугольника");
            listView1.Items[0].SubItems.Add(triangle.outputA());
            listView1.Items[1].SubItems.Add(triangle.outputB());
            listView1.Items[2].SubItems.Add(triangle.outputC());
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Bisector()));
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.CSide()));
            listView1.Items[5].SubItems.Add(Convert.ToString(triangle.Radius()));
            listView1.Items[6].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            listView1.Items[7].SubItems.Add(Convert.ToString(triangle.Surface()));
            if (triangle.ExistTriangle) { listView1.Items[8].SubItems.Add("Существует"); }
            else listView1.Items[8].SubItems.Add("Не существует");
            if (a == b && b == c && c == b) { listView1.Items[9].SubItems.Add("Равносторонний"); }
            else if (b == c) { listView1.Items[9].SubItems.Add("Равнобедренный"); }
            else { listView1.Items[9].SubItems.Add("Разносторонний"); }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.Visible = true;
            else
                pictureBox1.Visible = false;
        }
    }
}
