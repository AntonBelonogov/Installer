using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer
{
    public partial class Form2 : Form
    {
        public string path;

        public Form2()
        {
            InitializeComponent();
        }

        private void BackButton(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void BrowseClick(object sender, EventArgs e)
        {
            FolderBrowserDialog browse = new FolderBrowserDialog();
            browse.ShowDialog();
            textBox1.Text = browse.SelectedPath;
            path = textBox1.Text;
        }

        private void nextBrowseButton(object sender, MouseEventArgs e)
        {
            Form3 form3 = new Form3(path);
            if (textBox1.Text == "")
            {
                MessageBox.Show("Укажите путь");
            }
            else
            {
                this.Hide();
                form3.Show();
            }
        }
    }
}
