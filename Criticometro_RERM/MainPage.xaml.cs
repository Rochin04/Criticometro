using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Criticometro_RERM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string nombre = Nombre.Text;
            string genero;
            string caracteristica1 = "";
            string caracteristica2 = "";
            string caracteristica3 = "";
            string caracteristica4 = "";
            string caracteristica5 = "";
            string caracteristica6 = "";
            int cont = 0;
            if (RBH.IsChecked==true && RBM.IsChecked==false)
            {
                genero = "Hombre";
            }
            else
            {
                genero = "Mujer"; 
            }
            string critica = nombre + " es ";
            if(genero == "Hombre")
            {
                if (Alto.IsChecked == true)
                {
                    cont++;
                    caracteristica1 = "Alto";
                    critica += caracteristica1 +" ";
                    //if (cont==1)
                    //{
                    //critica += caracteristica1 + ".";
                    //}
                    //else if(cont==2)
                    //{
                    //    critica += caracteristica1 +" y ";
                    //}
                    //else if(cont>2)
                    //{
                    //    critica += caracteristica1 + ", ";
                    //}
                }
                 if (Feo.IsChecked == true)
                {
                    cont++;
                    caracteristica2 = "Feo";
                    critica += caracteristica2 + " ";
                    //if (cont == 1)
                    //{
                    //    critica += caracteristica2 + ".";
                    //}
                    //else if (cont == 2)
                    //{
                    //    critica += caracteristica2 + " y ";
                    //}
                    //else if (cont > 2)
                    //{
                    //    critica += caracteristica2 + ", ";
                    //}
                }
                 if (Listo.IsChecked == true)
                {
                    cont++;
                    caracteristica3 = "Listo";
                    critica += caracteristica3 + " ";
                    //if (cont == 1)
                    //{
                    //    critica += caracteristica3 + ".";
                    //}
                    //else if (cont == 2)
                    //{
                    //    critica += caracteristica3 + " y ";
                    //}
                    //else if (cont > 2)
                    //{
                    //    critica += caracteristica3 + ", ";
                    //}
                }
                 if (Extrabagante.IsChecked == true)
                {
                    cont++;
                    caracteristica4 = "Extrabagante";
                    critica += caracteristica4 + " ";
                    //if (cont == 1)
                    //{
                    //    critica += caracteristica4 + ".";
                    //}
                    //else if (cont == 2)
                    //{
                    //    critica += caracteristica4 + " y ";
                    //}
                    //else if (cont > 2)
                    //{
                    //    critica += caracteristica4 + ", ";
                    //}
                }
                 if (Raro.IsChecked == true)
                {
                    cont++;
                    caracteristica5 = "Raro";
                    critica += caracteristica5 + " ";
                    //if (cont == 1)
                    //{
                    //    critica += caracteristica5 + ".";
                    //}
                    //else if (cont == 2)
                    //{
                    //    critica += caracteristica5 + " y ";
                    //}
                    //else if (cont > 2)
                    //{
                    //    critica += caracteristica5 + ", ";
                    //}
                }
                 if (Grande.IsChecked == true)
                {
                    cont++;
                    caracteristica6 = "Grande";
                    critica += caracteristica6 + " ";
                    //if (cont == 1)
                    //{
                    //    critica += caracteristica6 + ".";
                    //}
                    //else if (cont == 2)
                    //{
                    //    critica += caracteristica6 + " y ";
                    //}
                    //else if (cont > 2)
                    //{
                    //    critica += caracteristica6 + ", ";
                    //}
                }
            }
            else if(genero == "Mujer")
            {
                if (Alto.IsChecked == true)
                {
                    cont++;
                    caracteristica1 = "Alta";
                    critica += caracteristica1 + " ";
                }
                else if (Feo.IsChecked == true)
                {
                    cont++;
                    caracteristica2 = "Fea";
                    critica += caracteristica2 + " ";
                }
                else if (Listo.IsChecked == true)
                {
                    cont++;
                    caracteristica3 = "Lista";
                    critica += caracteristica3 + " ";
                }
                else if (Extrabagante.IsChecked == true)
                {
                    cont++;
                    caracteristica4 = "Extrabagante";
                    critica += caracteristica4 + " ";
                }
                else if (Raro.IsChecked == true)
                {
                    cont++;
                    caracteristica5 = "Rara";
                    critica += caracteristica5 + " ";
                }
                else if (Grande.IsChecked == true)
                {
                    cont++;
                    caracteristica6 = "Grande";
                    critica += caracteristica6 + " ";
                }
            }
            Mensaje.Text= critica;
        }
    }
}
