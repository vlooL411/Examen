using System.Windows;

namespace Examen
{
    public partial class GiveQuery : Window
    {
        public GiveQuery()
        {
            InitializeComponent();
        }

        void Send_Click(object o, RoutedEventArgs e)
        {
            if (fam.Text == "" || nam.Text == "" || otc.Text == "")
            {
                Error.Content = "Error: введите ФИО";
                return;
            }
            if (dz.SelectedDate == null || dv.SelectedDate == null)
            {
                Error.Content = "Error: введите даты";
                return;
            }
            QueryBD.obshaga.livings.Add(new living()
            {
                familia = fam.Text,
                name = nam.Text,
                otchestvo = otc.Text,
                sotrudnik_student = !sot.IsChecked.Value ? "Студент" : "Сотрудник",
                data_vyuezda = dv.SelectedDate.Value.ToString(),
                data_zaselenia = dz.SelectedDate.Value.ToString()
            });
            QueryBD.obshaga.SaveChanges();
            (QueryBD.show = new ShowBD()).Show();
            Close();
        }
        void Close_click(object o, RoutedEventArgs e)
        {
            (QueryBD.show = new ShowBD()).Show();
            Close();
        }
    }
}