using System.Linq;
using System.Windows.Controls;

namespace Examen
{
    public partial class kor : Page
    {
        public kor()
        {
            InitializeComponent();
            dg.ItemsSource = null;
            dg.ItemsSource = QueryBD.obshaga.korpus.ToList();
        }
    }
}