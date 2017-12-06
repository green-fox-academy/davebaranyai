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

            Lines(foxDraw);
        }
        public static void Lines(FoxDraw foxDraw)
        {
            for (int i = 0; i < 3; i++)
            {
                foxDraw.StrokeColor(Colors.Blue);
                foxDraw.DrawLine(i * 50 + 20, i * 20 + 15, 250, 250);
            }

        }
    }
}
