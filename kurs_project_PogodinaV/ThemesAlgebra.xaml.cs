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

namespace kurs_project_PogodinaV
{
    /// <summary>
    /// Логика взаимодействия для ThemesAlgebra.xaml
    /// </summary>
    public partial class ThemesAlgebra : Page
    {
        public ThemesAlgebra()
        {
            InitializeComponent();
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            FrameFr.NavigationService.Navigate(new Uri("Sections.xaml"), UriKind.Relative);
        }
    }
}