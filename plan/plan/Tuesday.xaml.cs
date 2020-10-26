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
	public partial class Tuesday : ContentPage
	{
		public Tuesday()
		{
			string[] tasks = new string[] { "Встаём", "Пудрим носик", "Пьём Borjomi", "Соборимаем вещи", "Приезжаем в аэропорт", "Прилетаем в Лондон", "Скидываем вещи в отельном ЛЮКС номере", "ТУСУЕМСЯ В КЛУБЕ с Наташей", "Ужинаем в клубе на халяву", "СБЕГАЕМ из клуба","Бегаем от работников клуба (экскурсия по Лондону)", "Прячемся в нашем ЛЮКС номере","Чиллим под пивас, И КВАС feat. Whiskey", "Ложимся спать" };
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
				if (e.SelectedItemIndex == 0)//встаём
				{
					time = "10:32";
				}

				else if (e.SelectedItemIndex == 1)//пудрим носик
				{
					time = "10:37";
				}

				else if (e.SelectedItemIndex == 2)//завтракаем - Borjomi
				{
					time = "11:25";
				}

				else if (e.SelectedItemIndex == 3)//собираемся
				{
					time = "11:30";
				}

				else if (e.SelectedItemIndex == 4)//приезжаем в аэропорт
				{
					time = "12:35";
				}

				else if (e.SelectedItemIndex == 5)// прилетаем в Лондон
				{
					time = "17:15";
				}

				else if (e.SelectedItemIndex == 6)//скидываем вещи
				{
					time = "17:45";
				}

				else if (e.SelectedItemIndex == 7)//туса в клубе
				{
					time = "18:22";
				}

				else if (e.SelectedItemIndex == 8)//ужин
				{
					time = "20:35";
				}

				else if (e.SelectedItemIndex == 9)//сбегаем из клуба 
				{
					time = "00:54";
				}

				else if (e.SelectedItemIndex == 10)//сбегаем от работников - экскурсия
				{
					time = "01:00 - началась экскурсия по Лондону (в быстром темпе)";
				}

				else if (e.SelectedItemIndex == 11)//прячемся в отеле
				{
					time = "03:21 - смогли оторваться от работников только в 3 ночи.";
				}

				else if (e.SelectedItemIndex == 12)//чиллим с Наташей
				{
					time = "03:55 - традиция";
				}

				else if (e.SelectedItemIndex == 13)//спать?
				{
					time = "А мы точно легли????????";
				}


				await DisplayAlert(time, text, "Да");
			}
	   }
   }
}