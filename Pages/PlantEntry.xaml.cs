namespace HelloWorldApp.Pages;
using Microsoft.Maui.Graphics.Text;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

/*
Plant entry
H1 - title
H2



*/
public partial class PlantEntry : ContentPage {
    
    Button addPlantButton;
    VerticalStackLayout layout;
    public PlantEntry() {

        this.BackgroundColor = Color.FromArgb("512bdf");

        layout = new VerticalStackLayout {

            Margin = new Thickness(15, 15, 15, 15),
            Padding = new Thickness(30, 30, 30, 30),
            Children = {
                new Label { Text = "Name of Plant", FontSize = 30, TextColor = Color.FromRgb(255, 255, 100) },
                new Entry (),
                new Label { Text = "Description", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Entry (),
                new Label { Text = "[Placehold for adding an image]", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Label(),// Need to figure out what page breaks or line separaters are
                new Label(), //Same here
                new Label(), // and here
                new Label{Text = "Add Area Temperature", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Entry{Text = "0", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Label{Text = "Add Plant Temperature", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Entry{Text = "0", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Label{Text = "Add Humidity", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Entry{Text = "0", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },

            }
        };
        addPlantButton = new Button { Text = "Save Entry", BackgroundColor = Color.FromRgb(0, 148, 255) };
		layout.Children.Add(addPlantButton);
        Content = layout;

        addPlantButton.Clicked += (sender, e) => {
            Debug.WriteLine("Clicked");
        };

        
    }
}