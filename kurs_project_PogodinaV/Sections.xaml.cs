using System;
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
    /// Логика взаимодействия для Sections.xaml
    /// </summary>
    public partial class Sections : Page
    {
        public Sections()
        {
            InitializeComponent();
        }

        private void AlgebraThemesBtn_Click(object sender, RoutedEventArgs e)
        {
            ThemesFrame.NavigationService.Navigate(new Uri("ThemesAlgebra.xaml", UriKind.Relative));
        }

        private void GeometryThemesBtn_Click(object sender, RoutedEventArgs e)
        {
            ThemesFrame.NavigationService.Navigate(new Uri("ThemesGeometry.xaml", UriKind.Relative));
        }

        private void CombinatoricsThemesBtn_Click(object sender, RoutedEventArgs e)
        {
            ThemesFrame.NavigationService.Navigate(new Uri("ThemesCombinatorics.xaml", UriKind.Relative));
        }

        private void StatisticsThemesBtn_Click(object sender, RoutedEventArgs e)
        {
            ThemesFrame.NavigationService.Navigate(new Uri("ThemesStatictics.xaml", UriKind.Relative));
        }

        private void MathAnalyzisThemesBtn_Click(object sender, RoutedEventArgs e)
        {
            ThemesFrame.NavigationService.Navigate(new Uri("ThemesAlgebra.xaml", UriKind.Relative));
        }

        private void ProbabilityTheoryThemesBtn_Click(object sender, RoutedEventArgs e)
        {
            ThemesFrame.NavigationService.Navigate(new Uri("ThemesProbabilityTheory.xaml", UriKind.Relative));
        }

    }
}
