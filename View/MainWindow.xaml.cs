using RDA.Project.Turbina.Core;
using RDA.Project.Turbina.View.Pages;
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

namespace RDA.Project.Turbina;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        CoreNavigate.Connection = MainFrame;
        MainFrame.Navigate(new MainPage());
    }

    private void Border_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ClickCount == 2 && this.WindowState == WindowState.Normal) 
        {
            this.WindowState = WindowState.Maximized;
        }
        else if (e.ClickCount == 2 && this.WindowState == WindowState.Maximized)
        {
            this.WindowState = WindowState.Normal;
        }
    }

    private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if(e.ChangedButton == MouseButton.Left)
        {
            DragMove();
        }
    }
}
