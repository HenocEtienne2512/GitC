﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using WPFAppNew.Data;

namespace WPFAppNew {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        public BibliotecaDBContext Context;
        private void Button_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show(Context.Usuarios
                .OrderByDescending (x => x.Nome)
                .FirstOrDefault (x => x.Id > 0).Nome);

            var runList = Context.Usuarios.OrderBy(x => x.Nome).ToList<Usuario>();
            GridView1.ItemsSource = runList;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            Context = new BibliotecaDBContext();
        }
    }
}
