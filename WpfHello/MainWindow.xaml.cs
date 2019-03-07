﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfHello
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] pargs = Environment.GetCommandLineArgs();
            if (pargs.Length > 2)
            {
                MessageBox.Show($"Hello I'm {pargs[1]} {pargs[2]}.");
            }
            else if(pargs.Length == 2)
            {
                MessageBox.Show($"Hello I'm {pargs[1]} .");
            }else MessageBox.Show("Hello World!");
        }
        //void World(object sender, System.EventArgs e)
        //{
            
       // }
    }
}
