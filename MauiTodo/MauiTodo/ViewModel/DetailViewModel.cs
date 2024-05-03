using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiTodo.ViewModel
{
	[QueryProperty("Text", "Text")]
	public partial class DetailViewModel : ObservableObject
	{
		[ObservableProperty]
		string text;
	}
}
