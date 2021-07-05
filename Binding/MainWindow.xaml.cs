using Binding.Models;
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

namespace Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double MyWidth { get; set; }
        public List<Book> Books { get; set; } = new List<Book>
        {
            new Book
            {
                Id=1,
                Author="Richter",
                Genre="Fun",
                Pages=1100,
                Publisher="Baku INC",
                Title="C# Via CLR",
                ImagePath="Images/image1.jpg"
            },
            new Book
            {
                Id=1,
                Author="Exupery",
                Genre="Not So Fun",
                Pages=650,
                Publisher="Baku INC",
                Title="Little Prince",
                ImagePath="Images/image2.jpg"
            },
            new Book
            {
                Id=3,
                Author="GOF",
                Genre="Very Fun",
                Pages=700,
                Publisher="Baku INC",
                Title="Design Pattern Principles",
                ImagePath="Images/image3.png"
            }
        };
        public MainWindow()
        {
            InitializeComponent();
            // listview.ItemsSource = Books;

            Books[0].Author = "SALAM";

            DataContext = this;
            MyWidth = 30;
           
        }
    }
}
