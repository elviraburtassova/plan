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
	public partial class Wednesday : ContentPage
	{
		public Wednesday()
		{
			string[] tasks = new string[] { "Встаём?", "Используем ВЕРНУЮ косметичку","Завтракаем в ЛЮКС номере отеля", "Соборимаем вещи", "Приезжаем в аэропорт", "Прилетаем в Рио-де-Жанейро", "Случайно подселяемся в дом Эрика", "ТУСУЕМСЯ с Наташей и Эриком на параде", "Случайно принимаем участие в параде", "Ужинаем с участниками парада", "Возвращаемся к Эрику домой", "Чиллим под пивас, И КВАС feat. Whiskey- НО ТОЛЬКО с Наташей (пока Эрик спит в бассейне)", "Ложимся спать (а Эрик спит в джакузи)" };
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
					time = "13:05";
				}

				else if (e.SelectedItemIndex == 1)//используем косметичку
				{
					time = "13:12";
				}

				else if (e.SelectedItemIndex == 2)//завтракаем как аристократы
				{
					time = "13:45";
				}

				else if (e.SelectedItemIndex == 3)//собираемся
				{
					time = "14:25";
				}

				else if (e.SelectedItemIndex == 4)//приезжаем в аэропорт
				{
					time = "14:55";
				}

				else if (e.SelectedItemIndex == 5)// прилетаем в Рио-де-Жанейро
				{
					time = "18:05";
				}

				else if (e.SelectedItemIndex == 6)//подселяемся к Эрику
				{
					time = "18:25";
				}

				else if (e.SelectedItemIndex == 7)//тусуемся на параде
				{
					time = "19:00";
				}

				else if (e.SelectedItemIndex == 8)//принимаем участие в параде
				{
					time = "19:13";
				}

				else if (e.SelectedItemIndex == 9)//ужинаем с участниками парада
				{
					time = "20:54";
				}

				else if (e.SelectedItemIndex == 10)//возвращаемся к Эрику
				{
					time = "01:00 - просто слишком долго тусовались на параде";
				}

				else if (e.SelectedItemIndex == 11)//чиллим ТОЛЬКО с Наташей
				{
					time = "01:25";
				}

				else if (e.SelectedItemIndex == 12)//спать?
				{
					time = "А мы точно легли????????";
				}


				await DisplayAlert(time, text, "Да");
			}
		}
	}
}