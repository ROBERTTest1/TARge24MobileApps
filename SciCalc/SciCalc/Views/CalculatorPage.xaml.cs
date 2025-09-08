using SciCalc.ViewModels;

namespace SciCalc.Views;

public partial class CalculatorPage : ContentView
{
	public CalculatorPage()
	{
		InitializeComponent();

		this.BindingContext = new CalculatorPageViewModel();
	}
}