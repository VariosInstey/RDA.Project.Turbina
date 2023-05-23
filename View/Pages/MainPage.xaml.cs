using RDA.Project.Turbina.Core;
using RDA.Project.Turbina.View.Pages.Reg_Login;
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

namespace RDA.Project.Turbina.View.Pages;
/// <summary>
/// Логика взаимодействия для MainPage.xaml
/// </summary>
public partial class MainPage : Page
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void BtnGuest_Click(object sender, RoutedEventArgs e)
    {

    }

    private void Reg_Click(object sender, RoutedEventArgs e)
    {
        CoreNavigate.Connection?.Navigate(new LoginPage());
    }

    private void Register_Click(object sender, RoutedEventArgs e)
    {
        CoreNavigate.Connection?.Navigate(new RegPage());
    }
}
