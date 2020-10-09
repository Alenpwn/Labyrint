using System;
using System.Drawing;
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
using System.Runtime.InteropServices;
using System.Windows.Resources;

namespace Labirint
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int X, int Y);
       

        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            //StreamResourceInfo sri = Application.GetResourceStream(
            //new Uri("images/Smorc.cur", UriKind.Relative));
            //Cursor customCursor = new Cursor(sri.Stream);
            //this.Cursor = customCursor;
            this.Cursor = Cursors.Wait;
        }




        private void Label_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            SetCursorPos(1221, 725);

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SetCursorPos(1221, 725);

        }

        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            SetCursorPos(1221, 725);
        }

        private void Window_MouseEnter(object sender, MouseEventArgs e)
        {
            SetCursorPos(1221, 725);
        }

        private void LabelFinish_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы прошли первый уровень.");
        }
    }
}
