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

namespace ColoredBox
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
            ColoredRectangle(foxDraw);
        }
        public static void ColoredRectangle(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.GreenYellow);
            foxDraw.DrawLine(30, 30, 130, 30);

            foxDraw.StrokeColor(Colors.RoyalBlue);
            foxDraw.DrawLine(130, 30, 130, 130);

            foxDraw.StrokeColor(Colors.PeachPuff);
            foxDraw.DrawLine(30, 130, 130, 130);

            foxDraw.StrokeColor(Colors.Magenta);
            foxDraw.DrawLine(30, 30, 30, 130);
        }
    }
}
