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
	public partial class Thursday : ContentPage
	{
		public Thursday()
		{
			string[] tasks = new string[] { "Рота подъём!", "Умываемся", "Грабим Эрика на еду (пока он спит в джакузи)", "Собираем свои вещи и крадём Эрика", "Приезжаем в аэропорт", "Прилетаем в Гонконг", "Подселяемся к папику - Артёму", "Устраиваем тусу!!!", "Закупаемся", "Готовимся к тусе", "ТУСИМ (ТЫЦ-ДРЫЦ)", "Заканчиваем тусу","Артём нанимает уборщиц","Чиллим под пивас, И КВАС feat. Whiskey- НО ТОЛЬКО с Наташей (пока Эрик и Артём спят в бассейне)", "Ложимся спать (а Эрик и Артём спят в джакузи)" };
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
				if (e.SelectedItemIndex == 0)//подъём
				{
					time = "9:05";
				}

				else if (e.SelectedItemIndex == 1)//умываемся
				{
					time = "9:10";
				}

				else if (e.SelectedItemIndex == 2)//грабим Эрика на еду
				{
					time = "9:42";
				}

				else if (e.SelectedItemIndex == 3)//собираемся и крадём Эрика
				{
					time = "10:55";
				}

				else if (e.SelectedItemIndex == 4)//приезжаем в аэропорт
				{
					time = "11:25";
				}

				else if (e.SelectedItemIndex == 5)// прилетаем в Гонконг
				{
					time = "14:05";
				}

				else if (e.SelectedItemIndex == 6)//подселяемся к Артёму
				{
					time = "14:50";
				}

				else if (e.SelectedItemIndex == 7)//устраиваем тусу
				{
					time = "15:33";
				}

				else if (e.SelectedItemIndex == 8)//закупаемся
				{
					time = "15:44";
				}

				else if (e.SelectedItemIndex == 9)//готовимся к тусе
				{
					time = "16:15";
				}

				else if (e.SelectedItemIndex == 10)//тусим
				{
					time = "18:00";
				}

				else if (e.SelectedItemIndex == 11)//заканчиваем тусу
				{
					time = "05:25";
				}

				else if (e.SelectedItemIndex == 12)//Артём нанимает уборщиц
				{
					time = "06:30";
				}

				else if (e.SelectedItemIndex == 13)//чиллим ТОЛЬКО с Наташей
				{
					time = "07:25";
				}

				else if (e.SelectedItemIndex == 14)//спать?
				{
					time = "А мы точно легли????????";
				}

				await DisplayAlert(time, text, "Да");
			}
		}
	}
	}
