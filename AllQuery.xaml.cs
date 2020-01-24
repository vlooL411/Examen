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

namespace Examen
{
    /// <summary>
    /// Interaction logic for AllQuery.xaml
    /// </summary>
    public partial class AllQuery : Page
    {
        public AllQuery()
        {
            InitializeComponent();
            dg.ItemsSource = null;
            dg.ItemsSource = QueryBD.obshaga.livings.ToList();
        }

        void Give_Click(object o, RoutedEventArgs e)
        {
            new GiveQuery().Show();
            QueryBD.show.Close();
        }
    }
}
