using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AppDBP1.NewFolder;
using System.Security.Principal;

namespace AppDBP1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void btn_guardar_Clicked(object sender, EventArgs e)
        {/*
            string urlImagen = "https://st.depositphotos.com/1018174/1432/i/950/depositphotos_14326627-stock-photo-small-boy-playing.jpg";

            // Crear la imagen y asignar la ruta
            Image imagen = new Image { Source = ImageSource.FromUri(new Uri(urlImagen)) };

            */

            string principal = x_principal.Text;
            string nombre = x_nombre.Text; // Obtener el valor 
            string correo = x_correo.Text;
            string telefono = x_telefono.Text;
            string ciudad = x_ciudad.Text;
            string idioma1 = x_idioma1.Text;
            string idioma2 = x_idioma2.Text;
            string aptitud1 = x_aptitudes1.Text;
            string aptitud2 = x_aptitudes2.Text;
            string aptitud3 = x_aptitudes3.Text;
            string aptitud4 = x_aptitudes4.Text;
            string habilidad1 = x_habilidades1.Text;
            string habilidad2 = x_habilidades2.Text;
            string habilidad3 = x_habilidades3.Text;
            string habilidad4 = x_habilidades4.Text;
            string interes1 = x_interes1.Text;
            string interes2 = x_interes2.Text;
            string interes3 = x_interes3.Text;
            string perfil = x_perfil.Text;
            string experienciaLaboral1 = x_exlaboral1.Text;
            string experienciaLaboral2 = x_exlaboral2.Text;
            string experienciaLaboral3 = x_exlaboral3.Text;
            string experienciaLaboral4 = x_exlaboral4.Text;
            string formacion1 = x_formacion1.Text;
            string formacion2 = x_formacion2.Text;
            string formacion3 = x_formacion3.Text;

            curriculum = new Curriculum
            {
                Nombre = nombre,
                Correo = correo,
                Telefono = telefono,
                Ciudad = ciudad,
                Idioma1 = idioma1,
                Idioma2 = idioma2,
                Aptitud1 = aptitud1,
                Aptitud2 = aptitud2,
                Aptitud3 = aptitud3,
                Aptitud4 = aptitud4,
                Habilidad1 = habilidad1,
                Habilidad2 = habilidad2,
                Habilidad3 = habilidad3,
                Habilidad4 = habilidad4,
                Interes1 = interes1,
                Interes2 = interes2,
                Interes3 = interes3,
                Perfil = perfil,
                ExperienciaLaboral1 = experienciaLaboral1,
                ExperienciaLaboral2 = experienciaLaboral2,
                ExperienciaLaboral3 = experienciaLaboral3,
                ExperienciaLaboral4 = experienciaLaboral4,
                Formacion1 = formacion1,
                Formacion2 = formacion2,
                Formacion3 = formacion3
                // Asigna los demás valores a las propiedades del currículum
            };
            string textoCurriculum = curriculum.GenerarCurriculum();
            lbl_curriculum.Text = textoCurriculum;

            x_principal.IsVisible = false;
            x_nombre.IsVisible = false;
            x_correo.IsVisible = false;
            x_telefono.IsVisible = false;
            x_ciudad.IsVisible = false;
            x_idioma1.IsVisible = false;
            x_idioma2.IsVisible = false;
            x_aptitudes1.IsVisible = false;
            x_aptitudes2.IsVisible = false;
            x_aptitudes3.IsVisible = false;
            x_aptitudes4.IsVisible = false;
            x_habilidades1.IsVisible = false;
            x_habilidades2.IsVisible = false;
            x_habilidades3.IsVisible = false;
            x_habilidades4.IsVisible = false;
            x_interes1.IsVisible = false;
            x_interes2.IsVisible = false;
            x_interes3.IsVisible = false;
            x_perfil.IsVisible = false;
            x_exlaboral1.IsVisible = false;
            x_exlaboral2.IsVisible = false;
            x_exlaboral3.IsVisible = false;
            x_exlaboral4.IsVisible = false;
            x_formacion1.IsVisible = false;
            x_formacion2.IsVisible = false;
            x_formacion3.IsVisible = false;
            btn_guardar.IsVisible = false;

        }
        private Curriculum curriculum;
    }
}
