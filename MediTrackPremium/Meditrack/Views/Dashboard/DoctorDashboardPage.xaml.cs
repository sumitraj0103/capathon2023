using Microsoft.Maui.ApplicationModel.DataTransfer;

namespace Meditrack.Views.Dashboard;

public partial class DoctorDashboardPage : ContentPage
{
	public DoctorDashboardPage()
	{
		InitializeComponent();
		List<Patient> patients = new List<Patient>()
		{
			new Patient { Name="Gladys CG",MobileNumber="+31923999399",Condition="Allergic" },
            new Patient { Name="Shin Minkyung", MobileNumber="+31923999399",Condition="Normal" },
            new Patient { Name="Suryanshu Goswami", MobileNumber="+31923999399",Condition="Normal" },
            new Patient { Name="Ibrahim Dauda", MobileNumber="+31923999399",Condition="Allergic" },
            new Patient { Name="Yannis Loutas", MobileNumber="+31923999399",Condition="Normal" },
            new Patient { Name="Shyam Kishore Naidu", MobileNumber="+31923999399",Condition="Normal" },
            new Patient { Name="LetsDevOps", MobileNumber="+31923999399",Condition="BP" }


        };
		
		listpatients.ItemsSource = patients;
	}
	public class Patient
	{

		public string Name { get;set; } 
		public string MobileNumber { get;set; }

        public string Condition { get; set; }
    }

    private async void listpatients_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        //logic
        if (listpatients.SelectedItem != null)
        {
            Patient item = e.SelectedItem as Patient;

            if (item.Condition == "Allergic") {

                await Navigation.PushAsync(new PatientDashboardPageDetail(item.Name, item.MobileNumber,item.Condition));
                //DisplayAlert("This Patient is Allergic", "Make Sure to check the full Medical History", "Okay");
                //listpatients.SelectedItem = null;
            }
            else if (item.Condition == "Normal")
            {
                await Navigation.PushAsync(new PatientDashboardPageDetail(item.Name, item.MobileNumber, item.Condition));
            }
            else if (item.Condition == "BP")
            {

                await Navigation.PushAsync(new PatientDashboardPageDetail(item.Name, item.MobileNumber, item.Condition));
            }


        }


    }

    private void listpatients_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        listpatients.SelectedItem = null;
    }
}