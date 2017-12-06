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

namespace CenterBoxFunction
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
            Random randomizer = new Random();
            ThreeSquares(foxDraw, randomizer);
            
        }
        public static void ThreeSquares(FoxDraw foxDraw, Random randomizer)
        {
            for (int i = 0; i < 3; i++)
            {
                int size = randomizer.Next(20, 300);
                byte r = Convert.ToByte(randomizer.Next(1, 255));
                byte g = Convert.ToByte(randomizer.Next(1, 255));
                byte b = Convert.ToByte(randomizer.Next(1, 255));

                
                foxDraw.DrawRectangle(250-size/2, 250-size/2 ,size, size);
                foxDraw.FillColor(Color.FromArgb(93, r, g, b));
            }
        } 
    }
}
