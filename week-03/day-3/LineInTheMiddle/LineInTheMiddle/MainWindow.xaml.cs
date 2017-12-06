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
using GreenFox;

namespace LineInTheMiddle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            MiddleLines(foxDraw);
        }
        public static void MiddleLines(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(0, 175, 525, 175);
            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(262.5, 0, 262.5, 350);


        }
    }
}
