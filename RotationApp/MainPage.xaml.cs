using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RotationApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int i =0;

        void aumentar ( object sender, EventArgs e)
        {
            i++;
            texto.Rotation = i;
        }
        void diminuir(object sender, EventArgs e)
        {
            i--;
            texto.Rotation = i;
        }
    }
}
