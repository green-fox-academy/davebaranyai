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


namespace RainbowBoxFunction
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
            RainbowBox(foxDraw, randomizer);
        }
        public static void RainbowBox(FoxDraw foxDraw, Random randomizer)
        {
            for (int i = 0; i < 10; i++)
            {
                int size = i * 50 + 50;
                byte r = Convert.ToByte(randomizer.Next(1, 255));
                byte g = Convert.ToByte(randomizer.Next(1, 255));
                byte b = Convert.ToByte(randomizer.Next(1, 255));


                foxDraw.DrawRectangle(250 - size / 2, 250 - size / 2, size, size);
                foxDraw.FillColor(Color.FromArgb(100, r, g, b));
            }
        }
    }
}
