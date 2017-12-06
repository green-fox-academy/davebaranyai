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

namespace GoToCenter
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
            double x1 = 23;
            double x2 = 195;
            double x3 = 450;
            double y1 = 45;
            double y2 = 180;
            double y3 = 310;

            Lines(foxDraw, x1, x2, x3, y1, y2, y3);



        }
        public static void Lines(FoxDraw foxDraw, double x1, double x2, double x3, double y1, double y2, double y3)
        {
            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(x1, y1, 250, 250);
            foxDraw.DrawLine(x2, y2, 250, 250);
            foxDraw.DrawLine(x3, y3, 250, 250);
        }

    }
}
