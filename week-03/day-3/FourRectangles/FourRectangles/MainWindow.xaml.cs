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


namespace FourRectangles
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
            Random parameter = new Random();
            FourRects(foxDraw, parameter);
        }
        public static void FourRects(FoxDraw foxDraw, Random parameter)
        {
            for (int i = 0; i < 4; i++)
            {
                int x = parameter.Next(1, 255);
                int y = parameter.Next(1, 250);
                int length = parameter.Next(20, 200);
                int height = parameter.Next(20, 200);
                byte RGB1 = Convert.ToByte(parameter.Next(1, 255));
                byte RGB2 = Convert.ToByte(parameter.Next(1, 255));
                byte RGB3 = Convert.ToByte(parameter.Next(1, 255));


                foxDraw.FillColor(Color.FromRgb(RGB1, RGB2, RGB3));
                foxDraw.DrawRectangle(x, y, length, height);

            }

        
        }
    }
}
