using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Lab02
{
    public partial class MainWindow : Window
    {
        private List<Profesor> profesores = new List<Profesor>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Puedes seguir usando este método si quieres listar profesores predefinidos
            profesores = new List<Profesor>
            {
                new Profesor { Apellidos = "Gomez", Nombres = "Jaime" },
                new Profesor { Apellidos = "Hugo", Nombres = "Torrico" },
                new Profesor { Apellidos = "Valeria", Nombres = "Gomez" }
            };

            dgProfesores.ItemsSource = null;
            dgProfesores.ItemsSource = profesores;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<Curso> cursos = new List<Curso>
            {
                new Curso { Nombre = "Programacion", Nota = "25", Codigo = "543543" }
            };

            dgCursos.ItemsSource = cursos;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {


            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();

            if (!string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(apellido))
            {
                profesores.Add(new Profesor { Nombres = nombre, Apellidos = apellido });

                dgProfesores.ItemsSource = null;
                dgProfesores.ItemsSource = profesores;

                txtNombre.Text = "";
                txtApellido.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese nombre y apellido.");
            }
        }
    }
}
