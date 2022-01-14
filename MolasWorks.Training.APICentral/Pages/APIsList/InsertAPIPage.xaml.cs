using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MolasWorks.Training.APICentral.Pages.APIsList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InsertApiPage : ContentPage
    {
        public string FormMessages { get; set; }
        public string APIName { get; set; }
        public string AuthType { get; set; }
        public string ConnectionURL { get; set; }
        public string Description { get; set; }
        public bool CORS { get; set; }
        public bool HTTPS { get; set; }
        public InsertApiPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
        }
    }
}