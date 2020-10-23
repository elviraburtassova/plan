using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace plan
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			StackLayout st = new StackLayout();
			Button mon_btn = new Button { Text = "Monday" };
			Button tue_btn = new Button { Text = "Tuesday" };
			Button wed_btn = new Button { Text = "Wednesday" };
			Button thu_btn = new Button { Text = "Thursday" };
			Button fri_btn = new Button { Text = "Friday" };
			Button sat_btn = new Button { Text = "Saturday" };
			Button sun_btn = new Button { Text = "Sunday" };

			st.Children.Add(mon_btn);
			st.Children.Add(tue_btn);
			st.Children.Add(wed_btn);
			st.Children.Add(thu_btn);
			st.Children.Add(fri_btn);
			st.Children.Add(sat_btn);
			st.Children.Add(sun_btn);

			mon_btn.Clicked += new EventHandler(Buttons_clicked);
			tue_btn.Clicked += new EventHandler(Buttons_clicked);
			wed_btn.Clicked += new EventHandler(Buttons_clicked);
			thu_btn.Clicked += new EventHandler(Buttons_clicked);
			fri_btn.Clicked += new EventHandler(Buttons_clicked);
			sat_btn.Clicked += new EventHandler(Buttons_clicked);
			sun_btn.Clicked += new EventHandler(Buttons_clicked);

			Content = st;
		}

		private async void Buttons_clicked(object sender, EventArgs e)
		{
			var btn = (Button)sender;
			switch (btn.Text)//Проверяем текст на кнопке.
			{
				case "Monday":
					await Navigation.PopAsync();//Закрываем страницу на которой находились.
					await Navigation.PushAsync(new Monday());//Открываем нужную страницу.
					break;

				case "Tuesday":
					await Navigation.PopAsync();//Закрываем страницу на которой находились.
					await Navigation.PushAsync(new Tuesday());//Открываем нужную страницу.
					break;

				case "Wednesday":
					await Navigation.PopAsync();//Закрываем страницу на которой находились.
					await Navigation.PushAsync(new Wednesday());//Открываем нужную страницу.
					break;

				case "Thursday":
					await Navigation.PopAsync();//Закрываем страницу на которой находились.
					await Navigation.PushAsync(new Thursday());//Открываем нужную страницу.
					break;

				case "Friday":
					await Navigation.PopAsync();//Закрываем страницу на которой находились.
					await Navigation.PushAsync(new Friday());//Открываем нужную страницу.
					break;

				case "Saturday":
					await Navigation.PopAsync();//Закрываем страницу на которой находились.
					await Navigation.PushAsync(new Saturday());//Открываем нужную страницу.
					break;

				case "Sunday":
					await Navigation.PopAsync();//Закрываем страницу на которой находились.
					await Navigation.PushAsync(new Sunday());//Открываем нужную страницу.
					break;
			}
		}
	}
}
