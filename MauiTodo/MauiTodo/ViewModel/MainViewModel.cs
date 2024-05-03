﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiTodo.ViewModel
{
	public partial class MainViewModel : ObservableObject
	{
		public MainViewModel()
		{
			items = new();
		}

		[ObservableProperty]
		ObservableCollection<string> items;

		[ObservableProperty]
		public string text;

		[RelayCommand]
		void Add()
		{
			if (string.IsNullOrWhiteSpace(Text))
			{
				return;
			}

			Items.Add(Text);
			Text = string.Empty;
		}

		[RelayCommand]
		void Delete(string text)
		{
			if (Items.Contains(text))
			{
				Items.Remove(text);
			}
		}

		[RelayCommand]
		async Task Tap(string text)
		{
			await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={text}");
		}
	}
}
