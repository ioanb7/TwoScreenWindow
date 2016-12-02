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

namespace TwoScreenWindow
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

       

        private void button_Click(object sender, RoutedEventArgs e)
        {
            OnTopWindow fullScreenWindow;


            //first display
            fullScreenWindow = new OnTopWindow();
            fullScreenWindow.WindowState = WindowState.Normal;

            fullScreenWindow.WindowStartupLocation = WindowStartupLocation.Manual;

            Debug.Assert(System.Windows.Forms.SystemInformation.MonitorCount > 1);

            System.Drawing.Rectangle workingArea = System.Windows.Forms.Screen.AllScreens[0].WorkingArea;
            fullScreenWindow.Left = workingArea.Left;
            fullScreenWindow.Top = workingArea.Top;
            fullScreenWindow.Width = workingArea.Width;
            fullScreenWindow.Height = workingArea.Height;
            fullScreenWindow.WindowState = WindowState.Normal;
            fullScreenWindow.WindowStyle = WindowStyle.None;
            fullScreenWindow.Topmost = true;

            fullScreenWindow.Show();





            //second display
           var  fullScreenWindowTwo = new OnTopWindow();
            fullScreenWindow.WindowState = WindowState.Normal;

            fullScreenWindowTwo.WindowStartupLocation = WindowStartupLocation.Manual;

            Debug.Assert(System.Windows.Forms.SystemInformation.MonitorCount > 1);

            System.Drawing.Rectangle workingArea2 = System.Windows.Forms.Screen.AllScreens[1].WorkingArea;
            fullScreenWindowTwo.Left = workingArea2.Left;
            fullScreenWindowTwo.Top = workingArea2.Top;
            fullScreenWindowTwo.Width = workingArea2.Width;
            fullScreenWindowTwo.Height = workingArea2.Height;
            fullScreenWindowTwo.WindowState = WindowState.Normal;
            fullScreenWindowTwo.WindowStyle = WindowStyle.None;
            fullScreenWindowTwo.Topmost = true;

            fullScreenWindowTwo.Show();


            fullScreenWindow.WindowState = WindowState.Maximized;
            fullScreenWindowTwo.WindowState = WindowState.Maximized;

        }
    }
}
