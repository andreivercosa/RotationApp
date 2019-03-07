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
       


        void estavel()
        {
            if (i == 0)
            {

                texto.Text = "Estavel";

            }
        }
        void aumentar(object sender, EventArgs e)
        {
            i++;
            texto.Rotation = i;
            texto.Text = "Horario";
            estavel();
        }
        void diminuir(object sender, EventArgs e)
        {
            i--;
            texto.Rotation = i;
            texto.Text = "Anti-horario";
            estavel();
        }


        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            texto.Rotation = bola.Value;
            valor.Text = Math.Ceiling(bola.Value).ToString();
        }
    }
}
