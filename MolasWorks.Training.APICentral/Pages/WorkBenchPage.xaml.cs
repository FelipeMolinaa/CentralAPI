using MolasWorks.Training.APICentral.ViewModels;
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
    public partial class WorkBenchPage : ContentPage
    {
        private readonly WorkBenchViewModel _workBenchViewModel;

        public WorkBenchPage()
        {
            _workBenchViewModel = new WorkBenchViewModel();
            _workBenchViewModel._genericApiRepository = App.GenericAPIRepository;
            BindingContext = _workBenchViewModel;
            InitializeComponent();

        }
    }
}