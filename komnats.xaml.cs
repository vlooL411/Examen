using System.Linq;
using System.Windows.Controls;

namespace Examen
{
    public partial class komnats : Page
    {
        public komnats()
        {
            InitializeComponent();
            dg.ItemsSource = null;
            dg.ItemsSource = QueryBD.obshaga.rooms.ToList();
        }
    }
}