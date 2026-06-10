namespace MauiPt2L14;

public partial class StudentsPage : ContentPage
{
    public StudentsPage()
    {
        InitializeComponent();

        StudentsList.ItemsSource = new string[]
        {
            "Dias",
            "Nurik",
            "Gabit",
            "Anuar",
            "Nurbol"
        };
    }

    private async void StudentsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count == 0)
        {
            return;
        }

        string name = e.CurrentSelection[0].ToString();

        await Shell.Current.GoToAsync($"{nameof(StudentDetailPage)}?name={name}");

        StudentsList.SelectedItem = null;
    }
}