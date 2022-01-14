using MolasWorks.Training.APICentral.Pages.APIsList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MolasWorks.Training.APICentral.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : Shell
    {
        public MenuPage()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(InsertApiPage), typeof(InsertApiPage));
        }
    }
}