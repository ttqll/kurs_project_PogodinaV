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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
         
        }

        private void AccountBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Uri("UserAccount.xaml", UriKind.Relative));
            
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuGrid.Visibility = Visibility.Visible;
            MenuBtn.Visibility = Visibility.Hidden;
        }

        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {
        
            MainFrame.NavigationService.Navigate(new Uri("Settings.xaml", UriKind.Relative));
           
        }

        private void AbountProgram_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Uri("AboutProgram.xaml", UriKind.Relative));
        }

        private void memPic_Loaded(object sender, RoutedEventArgs e)
        {
            //объект, инициировавший событие, рассматриваем как изображение
            Image? memeImage = sender as Image; 

            //Создаем контекстное меню для изображения
            ContextMenu imageContextMenu = new ContextMenu();
            imageContextMenu.Items.Add("Добавить в избранное");
            memeImage.ContextMenu = imageContextMenu;
        }

        private void ThemesBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Uri("Sections.xaml", UriKind.Relative));
        }
    }
}
