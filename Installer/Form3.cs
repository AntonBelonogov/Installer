using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Installer
{
    public partial class Form3 : Form
    {
        string sourceDir = System.IO.Path.GetFullPath(@"..\..\");

        public Form3(string p)
        {
            InitializeComponent();
            FileInfo fInfo = new FileInfo(Path.Combine(p, "File.txt"));
            try
            {     
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 5;
                progressBar1.Step = 1;

                for (int i = 0; i <= 4; i++)
                {
                    progressBar1.PerformStep();
                    if (!fInfo.Exists)
                    {
                        File.Copy(Path.Combine(sourceDir, "File.txt"), Path.Combine(p, "File.txt"), true);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if (fInfo.Exists)
            {
                closeButton.Enabled = true;
            }
        }
    }
}
