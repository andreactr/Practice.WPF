using EjercicioWPF.Data_Access;
using EjercicioWPF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SqlClient;
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

namespace EjercicioWPF
{
    /// <summary>
    /// Lógica de interacción para MenuLista.xaml
    /// </summary>
    public partial class MenuLista : Page


    {

        PersonViewModel pvm = new PersonViewModel();
        Data data = new Data();
        bool flag = false;
        public MenuLista()
        {
            InitializeComponent();
            LoadData();
            //Refresh();
        }

        SqlConnection con = new SqlConnection(@"Data Source=Localhost;Initial Catalog=Person;Integrated Security=True");


        //private void Refresh() 
        //{
        //    List<PersonViewModel> lst = new List<PersonViewModel>();
        //        using (Model.PersonEntities db= new Model.PersonEntities()) { 
        //        lst = (from d in db.Personas
        //        select new PersonViewModel 
        //        { 
        //            Id= d.Id,
        //            Nombre=d.Nombre,
        //            Edad=d.Edad,
        //            Email = d.Email
        //            }).ToList();
        //        }
        //        DG.ItemsSource= lst;
        //}
        //INSERT
        //private void Button_Agregar(object sender, RoutedEventArgs e)
        //{
        //    MainWindow.StaticMainFrame.Content = new Formulario();
        //}
        ////DELETE
        //private void Button_Eliminar(object sender, RoutedEventArgs e)
        //{
        //    int Id = (int)((Button)sender).CommandParameter;
        //    using (Model.PersonEntities db = new Model.PersonEntities())
        //    {
        //        var oPerson = db.Personas.Find(Id);

        //        db.Personas.Remove(oPerson);
        //        db.SaveChanges();
        //    }
        //    Refresh();
        //}
        //UPDATE
        //private void Button_Editar(object sender, RoutedEventArgs e)
        //{
        //    int Id = (int)((Button)sender).CommandParameter;

        //    Formulario pFormulario = new Formulario(Id);
        //    MainWindow.StaticMainFrame.Content = pFormulario;
        //}

        public void clearData()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtEmail.Clear();
        }

        public void LoadData()
        {
            //SqlCommand cmd = new SqlCommand("select * from Personas", con);
            //DataTable dt = new DataTable();
            //con.Open();
            //SqlDataReader sdr = cmd.ExecuteReader();
            //dt.Load(sdr);
            //con.Close();
            //DG.ItemsSource = dt.DefaultView;
            
            DG.DataContext = data.GetPersonas();
            
        }

        public bool isValid() {
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Name is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);               
                txtNombre.Focus();
                return false;
            }
           
            int Edad;
            if (!int.TryParse(txtEdad.Text, out Edad) || txtEdad.Text == "" || txtEdad.Text == "0")
            {
                MessageBox.Show("Age is required in number format", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                //txtEdad.Clear();
                txtEdad.Focus();
                return false;
            }
            

            if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Email is required", "Failed", MessageBoxButton.OK, MessageBoxImage.Error);             
                txtEmail.Focus();
                return false;
            }
            
            return true;
        }
    
        private void btnVaciar_Click(object sender, RoutedEventArgs e)
        {
          clearData();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if(flag == false) { 
                if(isValid()) { 
                data.CreatePersona(txtNombre.Text,int.Parse(txtEdad.Text),txtEmail.Text);
                    LoadData();
                    clearData();
                }
                
            }
            else if( flag == true)
            {
                if (DG.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < DG.SelectedItems.Count; i++)
                    {
                        System.Data.DataRowView selectedFile = (System.Data.DataRowView)DG.SelectedItems[i];
                        string strId = Convert.ToString(selectedFile.Row.ItemArray[0]);
                        if (isValid())
                        {
                            data.UpdatePersonas(int.Parse(strId), txtNombre.Text, int.Parse(txtEdad.Text), txtEmail.Text);
                            LoadData();
                            clearData();
                        }
                    }
                }
            flag = false;
                
            }
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
                if (DG.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < DG.SelectedItems.Count; i++)
                    {
                        System.Data.DataRowView selectedFile = (System.Data.DataRowView)DG.SelectedItems[i];
                        string strId = Convert.ToString(selectedFile.Row.ItemArray[0]);
                        if (MessageBox.Show("¿Estás seguro de eliminar este elemento?",
                        "Delete item",
                        MessageBoxButton.YesNo,
                        MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            data.DeletePersonas(strId);
                        }
                    }
                }
                LoadData();
        }

        private void DG_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (DG.SelectedItems.Count > 0)
            {
                for (int i = 0; i < DG.SelectedItems.Count; i++)
                {
                    System.Data.DataRowView selectedFile = (System.Data.DataRowView)DG.SelectedItems[i];
                    string strnombre = Convert.ToString(selectedFile.Row.ItemArray[1]);
                    string stredad = Convert.ToString(selectedFile.Row.ItemArray[2]);
                    string stremail = Convert.ToString(selectedFile.Row.ItemArray[3]);
                    txtNombre.Text = strnombre;
                    txtEdad.Text = stredad;
                    txtEmail.Text = stremail;
                }
            }        
            flag = true;
        }
    }    
          
}
