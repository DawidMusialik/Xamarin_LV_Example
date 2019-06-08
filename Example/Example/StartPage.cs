using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Example
{
    public class StartPage: ContentPage
    {
        public Label Example1_Label = new Label();
        public Button Example1_Button = new Button();

        public Label Example2_Label = new Label();
        public Button Example2_Button = new Button();


        private StackLayout _stack = new StackLayout();


        public StartPage()
        {
            this.Title = "Start page";
            SetItem();
            this.Content = _stack;
        }


        private void SetItem()
        {
            Example1_Label.Text = "Przykład 1";
            Example1_Button.Text = "GO!";
            Example1_Button.Command = new Command(() =>
            {
                App.Current.MainPage.Navigation.PushAsync(new Example1Page());
            });

            Example2_Label.Text = "Przykład 2";
            Example2_Button.Text = "GO!";
            Example2_Button.Command = new Command(() =>
            {
                this.DisplayAlert("Alert", "Może nie będzie Wam potrzebny :)", "OK");
            });

            _stack.Children.Add(new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    Example1_Label,
                    Example1_Button
                }
            });

            _stack.Children.Add(new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    Example2_Label,
                    Example2_Button
                }
            });
        }



    }
}
