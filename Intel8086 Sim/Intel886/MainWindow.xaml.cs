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

namespace Intel886
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> registers = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            registers.Add("AX");
            registers.Add("BX");
            registers.Add("CX");
            registers.Add("DX");
            Source.ItemsSource = registers;
            Destination.ItemsSource = registers;

                }

        private void MOV(object sender, RoutedEventArgs e)
        {
            TextBox SelectedSource = null;
            TextBox SelectedDestination = null;
            switch(Source.SelectedItem)
            {
                case "AX":
                    SelectedSource = AX;
                    break;          
                case "BX":
                    SelectedSource = BX;
                    break;               
                case "CX":
                    SelectedSource = CX;
                    break;              
                case "DX":
                    SelectedSource = DX;
                    break;

            }
            switch(Destination.SelectedItem)
            {
                case "AX":
                    SelectedDestination = AX;
                    break;          
                case "BX":
                    SelectedDestination = BX;
                    break;               
                case "CX":
                    SelectedDestination = CX;
                    break;              
                case "DX":
                    SelectedDestination = DX;
                    break;

            }
            if(SelectedSource!=null && SelectedDestination!=null && SelectedSource!= SelectedDestination)
            {
                SelectedDestination.Text = SelectedSource.Text;
                     Console.Text += "\n Moving Complete.";
            }
            else
            {
                Console.Text += "\n Moving Incompleate. There was an Error.";
            }
        }
    }
}
