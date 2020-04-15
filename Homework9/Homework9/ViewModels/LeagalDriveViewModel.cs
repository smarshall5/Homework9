using System;
using System.Collections.Generic;
using System.Text;


namespace Homework9.ViewModels
{
    class LeagalDriveViewModel:BaseViewModel
    {

        public LeagalDriveViewModel() {
            Title = "Are u able to drive on the road legally?";

        }
        public string AgeInput { get; set; }
        private int SavedAge { get; set; }

        public bool AgeEntered
        {
            get
            {
                if (!decimal.TryParse(AgeInput, out var r))
                    return false;

                SavedAge = int.Parse(decimal.Floor(r).ToString());
                return true;
            }
        }

        public string DriveResults
        {
            get
            {
                string result;
                if (!AgeEntered)
                    result = string.Empty;
                else if (SavedAge is 0)
                    result = string.Empty;
                else if (SavedAge < 16)
                    result = $"You cannot drive and are at risk of major fines with u drive";
                else
                    result = $"You have been able to drive for  {Math.Abs(SavedAge - 16)} years";

                return result;
            }
        }
    }
}