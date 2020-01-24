using System.Windows;

namespace Examen
{
    public partial class ShowBD : Window
    {
        public ShowBD()
        {
            InitializeComponent();
            AllQuery.Navigate(new AllQuery());
            Комнаты.Navigate(new komnats());
            Корпусы.Navigate(new kor());
        }
    }
}