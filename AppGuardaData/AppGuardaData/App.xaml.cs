using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLitePCL;
using PCLExt.FileStorage.Folders;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AppGuardaData
{
    public partial class App : Application
    {
        //conexao com o banco de dados
        public SQLite.SQLiteConnection conexao { get; private set; }
        public App()
        {
            //Local do banco

            var pasta = new LocalRootFolder();

            //crio o arquivo do banco
            //se ele existir, abro ele

            var arquivo = pasta.CreateFile("Banco.db", PCLExt.FileStorage.CreationCollisionOption.OpenIfExists);

            //faço a "Conexão"

            conexao = new SQLite.SQLiteConnection(arquivo.Path);

            //criar tabela, se ela não existir

            conexao.Execute("CREATE TABLE IF NOT EXISTS Informacoes (id INTEGER PRIMARY KEY AUTOINCREMENT, info TEXT)");

            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
