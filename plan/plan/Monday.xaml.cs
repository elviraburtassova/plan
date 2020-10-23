using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace plan
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Monday : ContentPage
	{
		public Monday()
		{
			string[] tasks = new string[] { "Просыпаемся", "Делаем зарядку", "Завтракаем: КАШКА манная, ЧАЁК, орешки", "Соборимаемся", "Приезжаем в аэропорт", "Прилетаем в Париж", "ДОООООооооООООооооОООооООоОЛГО ГУЛЯЕМ с Наташей", "Обедаем с Наташей: ОБЕД ЧЕМПИОНОВ", "Едем к Наташе", "Чиллим под пивас, И КВАС feat. Whiskey", "Ложимся спать" };
			ListView list = new ListView();
			list.ItemsSource = tasks;
			list.ItemSelected += List_ItemSelected;
			Content = new StackLayout { Children = { list } };

		}
		string time;
		private async void List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem != null)
			{
				string text = e.SelectedItem.ToString();
				if (e.SelectedItemIndex == 0)//просыпаемся
				{
					time = "6:30";
				}

				else if (e.SelectedItemIndex == 1)//зарядка
				{
					time = "6:45";
				}

				else if (e.SelectedItemIndex == 2)//завтракаем
				{
					time = "7:05";
				}

				else if (e.SelectedItemIndex==3)//собираемся
				{
					time = "7:35";
				}

				else if (e.SelectedItemIndex==4)//приезжаем в аэропорт
				{
					time = "8:05";
				}

				else if (e.SelectedItemIndex==5)// прилетаем в Париж
				{
					time = "13:00";
				}

				else if (e.SelectedItemIndex==6)//гуляем с Наташей
				{
					time = "13:25";
				}

				else if (e.SelectedItemIndex==7)//обедаем с Наташей
				{
					time = "16:00";
				}

				else if (e.SelectedItemIndex==8)//едем к Наташе
				{
					time = "18:45 - по пути нас занесло в Хез";
				}

				else if (e.SelectedItemIndex==9)//отдыхаем с Наташей
				{
					time = "20:55";
				}

				else if (e.SelectedItemIndex==10)//СПАТЬ
				{
					time = "А мы точно легли????????";
				}

				await DisplayAlert(time, text, "Да");
			}

		}
	}
}
