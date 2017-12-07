﻿using System;
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

namespace Exercise11
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
            foxDraw.BackgroundColor(Colors.LightYellow);
            int size = 300;
            DrawingSquares(foxDraw, size);           
        }
        public void DrawingSquares(FoxDraw foxDraw, int size)
        {
            foxDraw.DrawLine((size/3  result), 0+result, (size/3+result), size+result);
            foxDraw.DrawLine(2*(size/3)+result, 0+result, 2 * (size/ 3)+result, result);
            foxDraw.DrawLine(0, (result/3), result, (result/ 3));
            foxDraw.DrawLine(0, 2 * (result/ 3), result, 2 * (result/ 3));

        }
        public int result(int size)
        {
            if (size == 0)
            {
                return 1;
            }
            else
            {
                result
            }
        }
    }
}
