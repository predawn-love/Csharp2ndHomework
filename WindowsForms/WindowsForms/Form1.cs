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
            MessageBox.Show("Hello World!");
        }
        public void Init()
        {
            Hello.Click += new EventHandler(World);
        }
    }
}
