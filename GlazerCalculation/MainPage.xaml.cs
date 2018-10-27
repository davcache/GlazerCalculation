using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GlazerCalculation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            ApplicationView.PreferredLaunchViewSize = new Size(800, 1200);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
        }

        private void sldQuantity_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            var sldrQuantity = sender as Slider;

            var quantity = sldrQuantity.Value;
            txbUpdateQuantity.Text = quantity.ToString();
        }
        private void btnCaluclate_Click(object sender, RoutedEventArgs e)
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            widthString = txtWidth.Text;
            width = double.Parse(widthString);
            heightString = txtHeight.Text;
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            txtWoodLength.Text = woodLength.ToString() + " feet";
            txtGlass.Text = glassArea.ToString() + " square metres";
        }

        //class GlazerCalc
        //{
        //    double width, height, woodLength, glassArea;
        //    string widthString, heightString;
        //    Console.Write("Enter Width: ");
        //    widthString = Console.ReadLine();
        //    width = double.Parse(widthString);
        //    Console.Write("Enter Height: ");
        //    heightString = Console.ReadLine();
        //    height = double.Parse(heightString);
        //    woodLength = 2 * (width + height) * 3.25;
        //    glassArea = 2 * (width * height);
        //    Console.WriteLine("The length of the wood is " +
        //    woodLength + " feet");
        //    Console.WriteLine("The area of the glass is " +
        //    glassArea + " square metres");
        //}
    }
}
