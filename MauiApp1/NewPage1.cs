using MauiApp1.ViewModel;

namespace MauiApp1
{
    public class DetailsPage : ContentPage
    {
        public DetailsPage(DetailsViewModel vm)
        {
            Title = "DetailsPage";
            BindingContext = vm;

            var layout = new VerticalStackLayout();

            var label = new Label
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 48
            };
            label.SetBinding(Label.TextProperty, "Text");
            layout.Add(label);

            var button = new Button { Text = "Go Back" };
            button.SetBinding(Button.CommandProperty, "GoBackCommand");
            layout.Add(button);

            Content = layout;
        }
    }
}