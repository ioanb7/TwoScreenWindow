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
            fullScreenWindow.WindowState = WindowState.Maximized;
            fullScreenWindow.WindowStyle = WindowStyle.None;
            fullScreenWindow.Topmost = true;

            fullScreenWindow.Show();





            //second display
            fullScreenWindow = new OnTopWindow();
            fullScreenWindow.WindowState = WindowState.Normal;

            fullScreenWindow.WindowStartupLocation = WindowStartupLocation.Manual;

            Debug.Assert(System.Windows.Forms.SystemInformation.MonitorCount > 1);

            System.Drawing.Rectangle workingArea2 = System.Windows.Forms.Screen.AllScreens[1].WorkingArea;
            fullScreenWindow.Left = workingArea2.Left;
            fullScreenWindow.Top = workingArea2.Top;
            fullScreenWindow.Width = workingArea2.Width;
            fullScreenWindow.Height = workingArea2.Height;
            fullScreenWindow.WindowState = WindowState.Maximized;
            fullScreenWindow.WindowStyle = WindowStyle.None;
            fullScreenWindow.Topmost = true;

            fullScreenWindow.Show();




        }
    }
}
