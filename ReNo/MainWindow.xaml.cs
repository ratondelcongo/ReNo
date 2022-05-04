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

namespace ReNo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        internal void FillbtnSubCat(string text)
        {
            var myRowDefinition = new RowDefinition();
            var textBox = new TextBox();

            textBox.Text = text;
            textBox.IsReadOnly = true;
            textBox.Margin = new Thickness(0,0,0,5);

            Grid.SetRow(textBox, count);

            myRowDefinition.Height = new GridLength(70);

            if (count < 5)
            {
                notes.RowDefinitions.Add(myRowDefinition);
                notes.Children.Add(textBox);
            }
            else
            {
                notes2.RowDefinitions.Add(myRowDefinition);
                notes2.Children.Add(textBox);
            }

            count++;
        }


        void button_Click(object sender, RoutedEventArgs e)
        {
            if (newNote.Text.Length == 0)
            {
                newNote.Focus();
                return;
            }
            var newNoteText = newNote.Text;
            FillbtnSubCat(newNoteText);

            newNote.Text = "";
            newNote.Focus();
        }

        private void full_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }
    }
}
