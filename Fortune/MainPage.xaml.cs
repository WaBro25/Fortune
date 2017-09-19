using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409
// test for initial commit
namespace Fortune
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            //create a random variable. eg math.random and choose the different outputs
            Random rndm = new Random();
            int number = rndm.Next(1, 14);
            if (number == 1)
            {
                this.displayText.Text = "Ask Again";
            }
            if (number == 2)
            {
                this.displayText.Text = "Dont Count On It";
            }
            if (number == 3)
            {
                this.displayText.Text = "Go With Your Gut";
            }
            if (number == 4)
            {
                this.displayText.Text = "Its Your Future";
            }
            if (number == 5)
            {
                this.displayText.Text = "Certainly";
            }
            if (number == 6)
            {
                this.displayText.Text = "Positive";
            }
            if (number == 7)
            {
                this.displayText.Text = "Answers Point to No";
            }
            if (number == 8)
            {
                this.displayText.Text = "Answers Point to Yes";
            }
            if (number == 9)
            {
                this.displayText.Text = "yeah Nah";
            }
            if (number == 10)
            {
                this.displayText.Text = "Nah yeh";
            }
            if (number == 11)
            {
                this.displayText.Text = "Live Life To the Fullest";
            }
            if (number == 12)
            {
                this.displayText.Text = "Always Try To Be Better";
            }
            if (number == 13)
            {
                this.displayText.Text = "What Would Your Mum Say?";
            }
        }
    }
}

