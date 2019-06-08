using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Example
{
    public class Example1Page: ContentPage
    {
        private ListView List = new ListView();
        private List<Example1Model> Data = new List<Example1Model>();

        public Example1Page()
        {
            this.Title = "Example1";
            SetItem();
            this.Content = List;
        }

        private void SetItem()
        {
            Data.Add(new Example1Model()
            {
                Text = "Test1",
                ButtonText = "Go!",
                Comand = new Command(async ()=>
                {
                    await this.DisplayAlert("Alert!", "Test1", "OK");
                })
            });
            Data.Add(new Example1Model()
            {
                Text = "Test2",
                ButtonText = "Go!",
                Comand = new Command(async () =>
                {
                    await this.DisplayAlert("Alert!", "Test2", "OK");
                })
            });


            List.ItemsSource = Data;
            List.ItemTemplate = new DataTemplate(typeof(Example1Cell));
        }


    }


    public class Example1Model
    {
        public string Text { get; set; }
        public Command Comand { get; set; }
        public string ButtonText { get; set; }
    }

    public class Example1Cell: ViewCell
    {
        public Label Text { get; set; }
        public Button Button { get; set; }
        public StackLayout Stack { get; set; }

        public Example1Cell()
        {
            CreateItem();
            SetItem();
            this.View = Stack;
        }


        private void CreateItem()
        {
            Text = new Label();
            Stack = new StackLayout();
            Button = new Button();
        }

        private void SetItem()
        {
            Text.SetBinding(Label.TextProperty, new Binding(path: "Text", mode: BindingMode.OneWay));
            Button.SetBinding(Button.CommandProperty, new Binding(path: "Comand", mode: BindingMode.OneWay));
            Button.SetBinding(Button.TextProperty, new Binding(path: "ButtonText", mode: BindingMode.OneWay));

            Stack.Orientation = StackOrientation.Horizontal;
            Stack.Children.Add(Text);
            Stack.Children.Add(Button);

        }


    }



}
