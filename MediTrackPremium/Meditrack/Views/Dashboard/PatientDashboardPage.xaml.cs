namespace Meditrack.Views.Dashboard;

public partial class PatientDashboardPage : ContentPage
{
	public PatientDashboardPage()
	{
		InitializeComponent();

        List<Medicine> medicines = new List<Medicine>()
        {
            new Medicine { Name="Paracetamol",Symptom="Fever",Condition="Allergic" },
            new Medicine { Name="Brufen", Symptom="Pain",Condition="Normal" },
            new Medicine { Name="Loratadine", Symptom="Flu",Condition="Normal" },
            new Medicine { Name="Ciprofloxacin", Symptom="Malaria",Condition="Normal" }



        };
        listmedication.ItemsSource = medicines;
    }
    public class Medicine
    {

        public string Name { get; set; }
        public string Symptom { get; set; }

        public string Condition { get; set; }
    }

    private void listmedication_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {

        DisplayAlert("Do you have Side effect?", "Mark it Allergic?", "No Yes");
  
    }

    private void listmedication_ItemTapped(object sender, ItemTappedEventArgs e)
    {

        listmedication.SelectedItem = null;

    }
}