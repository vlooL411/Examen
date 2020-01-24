using System.Linq;
using System.Windows;

namespace Examen
{
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        void Login_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }

        void Reg_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text == "" || Password.Password == "" || TryPassword.Password == "" || Password.Password != TryPassword.Password) { Error.Content = "Error: Entry login, password, trypassword, password != trypassword"; return; }
            if (QueryBD.obshaga.Users.Where(u => u.login == Login.Text).Count() != 0) { Error.Content = "Error: такой логин существует."; return; }
            QueryBD.user = new User() { login = Login.Text, pass = Password.Password };
            QueryBD.obshaga.Users.Add(QueryBD.user);
            QueryBD.obshaga.SaveChanges();
            new MainWindow().Show();
            Close();
        }
    }
}