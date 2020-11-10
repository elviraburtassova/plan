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
	public partial class Saturday : ContentPage
	{
		public Saturday()
		{
			string[] tasks = new string[] { "Просыпаемся", "Умываемся", "Завтракаем в номере отеля", "Собираем свои вещи и выезжаем из отеля", "Приезжаем в аэропорт", "Прилетаем в Африку", "Заселяемся в трущобах", "Оставляем вещи...где-то", "Идём гулять с Наташей и африканцами", "Обедаем бананами и другими фруктами", "Катаемся на слонах", "Возвращаемся в наши трущобы", "Ужинаем?", "Танцуем с Наташей и с африканцами ", "Чиллим под кокосы, И бананы feat. ананасы с Наташей", "Ложимся спать" };
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

				else if (e.SelectedItemIndex == 2)//завтракаем в номере отеля
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

				else if (e.SelectedItemIndex == 5)// прилетаем в Африку
				{
					time = "16:35";
				}

				else if (e.SelectedItemIndex == 6)//заселяемся в трущобах
				{
					time = "17:00";
				}

				else if (e.SelectedItemIndex == 7)//оставляем вещи где-то...
				{
					time = "17:10";
				}

				else if (e.SelectedItemIndex == 8)//идём гулять с африканцами
					time = "17:15";
			}

			else if (e.SelectedItemIndex == 9)//обедаем бананами 
			{
				time = "17:32";
			}

			else if (e.SelectedItemIndex == 10)//катаемся на слонах
			{
				time = "18:20";
			}

			else if (e.SelectedItemIndex == 11)//возвращаемся в трущобы
			{
				time = "19:45";
			}

			else if (e.SelectedItemIndex == 12)//ужинаем чем-то?
			{
				time = "20:30";
			}

			else if (e.SelectedItemIndex == 13)//танцуем с африканцами
			{
				time = "21:25";
			}

			else if (e.SelectedItemIndex == 14)//чиллим под пивас и квас
			{
				time = "22:10";
			}

			else if (e.SelectedItemIndex == 15)//спать
			{
				time = "А мы точно легли????????";
			}
			await DisplayAlert(time, text, "Да");
		}
	}
}