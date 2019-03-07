using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void World(object sender, System.EventArgs e)
        {
            string[] pargs = Environment.GetCommandLineArgs();
            if (pargs.Length > 2)
            {
                MessageBox.Show($"Hello I'm {pargs[1]} {pargs[2]}");
            } else if (pargs.Length == 2)
            {
                MessageBox.Show($"{pargs[1]} loves the World.");
            }else MessageBox.Show($"Hello World!");
        }
        public void Init()
        {
            Hello.Click += new EventHandler(World);
        }
    }
}
