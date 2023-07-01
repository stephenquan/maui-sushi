using maui_sushi_app.Pages;
using System.ComponentModel;

namespace maui_sushi_app;

public partial class MainPage : ContentPage
{
	MainViewModel viewModel;

	public MainPage()
	{
		InitializeComponent();

		viewModel = (MainViewModel) BindingContext;
		viewModel.PropertyChanged += ViewModel_PropertyChanged;
	}

    private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
		switch (e.PropertyName)
		{
			case nameof(viewModel.SelectedProduct):
				ProductListView.ScrollTo(viewModel.SelectedProduct, ScrollToPosition.MakeVisible, false);
				break;
		}

	}
}
