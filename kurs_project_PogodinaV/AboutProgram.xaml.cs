using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Xml;

namespace kurs_project_PogodinaV
{
    /// <summary>
    /// Логика взаимодействия для AboutProgram.xaml
    /// </summary>
    public partial class AboutProgram : Page
    {
        public AboutProgram()
        {
            InitializeComponent();
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuGrid.Visibility = Visibility.Visible;
            MenuBtn.Visibility = Visibility.Hidden;
        }
        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AbountProgram_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void AccountBtn_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void DocsBtn_Click(object sender, RoutedEventArgs e)
        {
            //Определяем файл, который откроется при нажатии на кнопку
            ProcessStartInfo startInfo = new ProcessStartInfo("C:/repos/kurs_project_PogodinaV/kurs_project_PogodinaV/Resources/Help/PZ_Kurs.htm") 
            {
                //использование оболочки ОС для выполнения процесса
                UseShellExecute = true 
            };

            //открытие файла в окне браузера
            Process.Start(startInfo); 
            
        }
    }
}
