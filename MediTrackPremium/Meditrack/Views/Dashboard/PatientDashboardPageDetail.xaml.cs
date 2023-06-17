using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Meditrack.Views.Dashboard;

public partial class PatientDashboardPageDetail : ContentPage
{
	public static string convalue;
	public PatientDashboardPageDetail(string name, string mobilenumber, string condition)
	{
		InitializeComponent();
		MyItemNameShow.Text= name;
		MyItemMobileShow.Text= mobilenumber;
		MyItemConditionShow.Text= condition;
		convalue = condition;
		

    }
    public void OnButtonClicked(object sender, EventArgs args)
    {
		if(convalue == "Allergic")
		{
            DisplayAlert("Do not Prescribe this Medicine", "She is Allergic", "Okay");
        }
        else if (convalue == "BP")
		{

            DisplayAlert("Do not Prescribe this Medicine", "She is Allergic", "Okay");
        }
		else
		{
            DisplayAlert("Medication", "Saved", "Okay");
        }
       // await label.RelRotateTo(360, 1000);
       //DisplayAlert("Do not Prescribe", "She is Allergic", "Okay");
    }
}