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
using System.Xml;
using Contacto;

namespace Agenda
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Cargar();


        }

        static void Cargar()
        {
            List<string> Lista = new List<string>();

            using (XmlReader Reader = XmlReader.Create("Contactos.xml"))
            {
                while (Reader.Read())
                {
                    if (Reader.IsStartElement())
                    {
                        if (Reader.Name == "article")
                        {
                            string LNombre = Reader["name"];
                            if (LNombre != null)
                            {
                                Lista.Add(LNombre);
                            }


                        }
                    }

                }
            }

        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            using (XmlReader reader = XmlReader.Create("file.xml"))
            {
                while (reader.Read())
                {

                    if (reader.IsStartElement())
                    {
                        if (reader.Name == listBox1.SelectedItem.ToString())
                        {
                            if (reader["Type"] == "empresa")
                            {
                                Contacto.Empresa Select = new Empresa(reader["name"], reader["telefono"], reader["direccion"], reader["ruc"]);


                                T1.Visibility = Visibility.Visible;
                                T2.Visibility = Visibility.Visible;
                                T3.Visibility = Visibility.Visible;
                                T4.Visibility = Visibility.Visible;





                                T1.Text = Select._nombre;
                                T2.Text = Select._telefono;
                                T3.Text = Select._direccion;
                                Id.Content = "RUC";
                                T4.Text = Select._ruc;

                            }
                            else
                            {
                                Contacto.Persona Select = new Persona(reader["name"], reader["telefono"], reader["direccion"], reader["dni"]);
                                T1.Visibility = Visibility.Visible;
                                T2.Visibility = Visibility.Visible;
                                T3.Visibility = Visibility.Visible;
                                T4.Visibility = Visibility.Visible;


                                T1.Text = Select._nombre;
                                T2.Text = Select._telefono;
                                T3.Text = Select._direccion;
                                Id.Content = "DNI";
                                T4.Text = Select._dni;
                            }
                        }

                    }
                }

            }

        }
    }
}
        
           
           
