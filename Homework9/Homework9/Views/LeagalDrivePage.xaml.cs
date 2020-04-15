using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework9.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Homework9.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LeagalDrivePage : ContentPage
    {
        public LeagalDrivePage()
        {
            InitializeComponent();
        }
      private void CompleteSubmission(object sender, EventArgs e)
        {
            var csm = (LeagalDriveViewModel) BindingContext;
            if (csm.AgeEntered) {
                DriveLabel.Text = csm.DriveResults;
            }

            DriveLabel.IsVisible = csm.AgeEntered;
        }
    }
}