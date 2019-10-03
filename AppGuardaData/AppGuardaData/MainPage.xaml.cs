using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppGuardaData
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();
            
        }

        private void CarregarInformacoes ()
        {

            string sql = "SELECT * FROM Informacoes";
            var Lista = ((App)Application.Current).conexao.Query<Model>(sql);

        }
    }
}
