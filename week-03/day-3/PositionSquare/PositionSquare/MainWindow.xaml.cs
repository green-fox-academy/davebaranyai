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

namespace PositionSquare
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
            Squares(foxDraw, randomizer);
        }
        public static void Squares(FoxDraw foxDraw, Random randomizer)
        {
            for (int i = 0; i < 3; i++)
            {
                int x = randomizer.Next(1, 200);
                int y = randomizer.Next(1, 200);
                foxDraw.DrawRectangle(x, y, 50, 50);
            }
        }
    }    
}
