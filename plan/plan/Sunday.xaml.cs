using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace plan
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Sunday : ContentPage
	{
		public Sunday()
		{
			string[] tasks = new string[] { "Подъём!", "Умываемся", "Завтракаем у Артёмки", "Собираем свои вещи и сбегаем от Эрика и Артёма", "Приезжаем в аэропорт", "Прилетаем в Южную Корею", "Заселяемся в отель", "Оставляем вещи в отеле", "Идём гулять с Наташей", "Обедаем в ресторане", "Продолжаем гулять", "Возвращаемся в отель", "Ужинаем в отеле", "Развлекаемся с Наташей в бассейне отеля", "Возвращаемся в наш номер", "Чиллим под пивас, И КВАС feat. Whiskey с Наташей", "Ложимся спать" };
			ListView list = new ListView();
			list.ItemsSource = tasks;
			list.ItemSelected += List_ItemSelected;
			Content = new StackLayout { Children = { list } };
		}
		string time, text;
		private async void List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem != null)
			{
				string text = e.SelectedItem.ToString();
				if (e.SelectedItemIndex == 0)//просыпаемся 
				{
					time = "12:05";
				}

				else if (e.SelectedItemIndex == 1)//умываемся
				{
					time = "12:10";
				}

				else if (e.SelectedItemIndex == 2)//завтракаем у Артёма
				{
					time = "12:32";
				}

				else if (e.SelectedItemIndex == 3)//собираемся 
				{
					time = "13:05";
				}

				else if (e.SelectedItemIndex == 4)//приезжаем в аэропорт
				{
					time = "13:35";
				}

				else if (e.SelectedItemIndex == 5)// прилетаем в Южную Корею
				{
					time = "16:35";
				}

				else if (e.SelectedItemIndex == 6)//заселяемся в отель
				{
					time = "17:00";
				}

				else if (e.SelectedItemIndex == 7)//оставляем вещи в номере
				{
					time = "17:10";
				}

				else if (e.SelectedItemIndex == 8)//идём гулять
					time = "17:15";
			}

			else if (e.SelectedItemIndex == 9)//обедаем в ресторане 
			{
				time = "17:32";
			}

			else if (e.SelectedItemIndex == 10)//снова гуляем
			{
				time = "18:20";
			}

			else if (e.SelectedItemIndex == 11)//возвращаемся в отель
			{
				time = "19:45";
			}

			else if (e.SelectedItemIndex == 12)//ужинаем в отеле
			{
				time = "20:30";
			}

			else if (e.SelectedItemIndex == 13)//развлекаемся в бассейне 
			{
				time = "21:25";
			}

			else if (e.SelectedItemIndex == 14)//возвращаемся в номер
			{
				time = "22:00";
			}

			else if (e.SelectedItemIndex == 13)//чиллим под пивас и квас
			{
				time = "22:10";
			}

			else if (e.SelectedItemIndex == 14)//спать
			{
				time = "А мы точно легли????????";
			}
			await DisplayAlert(time, text, "Да");
		}

	}
}