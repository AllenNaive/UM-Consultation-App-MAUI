namespace UM_Consultation_App_MAUI.Views.StudentView;

public partial class StudentBottomNav : ContentView
{
	public StudentBottomNav()
	{
		InitializeComponent();
	}

	private async void OnHomeTapped(object sender, EventArgs e)
	{
        //debug purposes rani
        try
        {
            if (Shell.Current == null)
            {
                Console.WriteLine("Shell is NULL! Navigation might fail.");
                return;
            }

            await Shell.Current.GoToAsync("//HomePage");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Navigation Error: {ex.Message}");
        }
    }

    private async void OnRequestTapped(object sender, EventArgs e)
	{
        //debug purposes rani
        try
        {
            if (Shell.Current == null)
            {
                Console.WriteLine("Shell is NULL! Navigation might fail.");
                return;
            }

            await Shell.Current.GoToAsync("//RequestPage");
        }
		catch (Exception ex)
		{
			Console.WriteLine($"Navigation Error: {ex.Message}");
        }
    }

	private async void OnResponseTapped(object sender, EventArgs e)
	{
        //debug purposes rani
		try
		{
            if (Shell.Current == null)
            {
                Console.WriteLine("Shell is NULL! Navigation might fail.");
                return;
            }

            await Shell.Current.GoToAsync("//ResponsePage");
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Navigation Error: {ex.Message}");
		}
	}

	private async void OnMenuTapped(object sender, EventArgs e)
	{
        //debug purposes rani
        try
        {
            if (Shell.Current == null)
            {
                Console.WriteLine("Shell is NULL! Navigation might fail.");
                return;
            }

            await Shell.Current.GoToAsync("//MenuPage");
		}
		catch (Exception ex)
		{
			Console.WriteLine($"Navigation Error: {ex.Message}");
		}
	}
}