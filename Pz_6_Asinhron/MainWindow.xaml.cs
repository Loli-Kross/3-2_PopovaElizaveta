﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Pz_6_Asinhron
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var task = longalg(14, Status);
            await task;
        }
        public async Task longalg(double a, ProgressBar p)
        {
            double b = 1;
            p.Maximum = a;
            for (int i = 0; i < a; i++)
            {
                b *= a;
                p.Value += 1;
                await Task.Delay(TimeSpan.FromSeconds(0.5));

            }
            
        }

    }

}
