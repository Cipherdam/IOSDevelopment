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

    readonly Button? plantButton = null;
    private readonly VerticalStackLayout vsLayout, vsLayoutRight, vsLayoutLeft;
    // CLEAN:ONBUILD
    // NOT using this right now but saving it for later, 
    // HorizontalStackLayout hsLayout;
    public PlantEntry() {

        this.BackgroundColor = Color.FromArgb("512bdf");

        var pageGrid = new Grid {
            Margin = new Thickness(15),
            Padding = new Thickness(30),
            ColumnDefinitions = {
                new ColumnDefinition(GridLength.Star),
                new ColumnDefinition(GridLength.Star)
            },
            RowDefinitions = { 
                new RowDefinition(GridLength.Auto), //Row 0
                new RowDefinition(GridLength.Auto),
                new RowDefinition(GridLength.Auto),
                new RowDefinition(GridLength.Auto),
                new RowDefinition(GridLength.Auto),
                new RowDefinition(GridLength.Auto),
                new RowDefinition(GridLength.Auto), //Row 6
            }
        };

        var pageHeader = new Label {
            Text = "Plant Information",
            FontSize = 30,
            TextColor = Colors.DarkGreen,
            HorizontalOptions = LayoutOptions.Center
        };



        vsLayoutLeft = new VerticalStackLayout {

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
                new Label{Text = "Suggested Area Temperature", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Entry{Text = "0", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Label{Text = "Suggested Plant Temperature", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Entry{Text = "0", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Label{Text = "Stage", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Entry{Text = "Seedling", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Label{Text = "Preferred Soil", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Entry{Text = "Well Drained Loamy soil in rich organic matter", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Label{Text = "Lighting Conditions", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Entry{Text = "Partial Sun", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },

            }
        };
        vsLayoutRight = new VerticalStackLayout {

            Margin = new Thickness(15, 15, 15, 15),
            Padding = new Thickness(30, 30, 30, 30),
            Children = {
                new Label { Text = "Plant Zone", FontSize = 30, TextColor = Color.FromRgb(255, 255, 100) },
                new Label{Text = "Planing Season", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Entry{Text = "Spring", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Entry (),
                new Label { Text = "Height", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Entry (),
                new Label { Text = "Plant Family", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Label(),// Need to figure out what page breaks or line separaters are
                new Label(), //Same here
                new Label(), // and here
                new Label{Text = "Flower", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Entry{Text = "0", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Label{Text = "Origin", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Entry{Text = "0", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Label{Text = "Toxicity", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Entry{Text = "Animals and People", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Label{Text = "Lighting Conditions", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Entry{Text = "Partial Sun", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Label{Text = "Toxicity", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Entry{Text = "Animals and People", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Label{Text = "Notes", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },
                new Entry{Text = "", FontSize = 30, TextColor = Color.FromRgb(255, 255, 255) },

            }
        };

        // CLEAN:ONBUILD
        // NOT using this right now but saving it for later, 
        // 
        //hsLayout = new HorizontalStackLayout {
        //    Margin = new Thickness(15, 15, 15, 15),
        //    Padding = new Thickness(30, 30, 30, 30),
        //    Children = {
        //        new Label  { Text = "Plant Information", FontSize = 30, TextColor = Color.FromRgb(255, 255, 100) },
        //        new Label  { Text = "PlaceHolder", FontSize = 30, TextColor = Color.FromRgb(255, 255, 100) },

        //    }
        //};

        try {
            pageGrid.Add(pageHeader, 0, 0);
            pageGrid.SetColumnSpan(pageHeader, 2);

            //Adding Layouts to Grid
            pageGrid.Add(vsLayoutLeft, 0, 1);
            pageGrid.Add(vsLayoutRight, 1, 1);

            plantButton = new Button { Text = "Save Entry", BackgroundColor = Color.FromRgb(0, 148, 255) };
            var pressedCount = 0;
            plantButton.Clicked += (sender, e) => {
                pressedCount++;
                Debug.WriteLine("Clicked");
                Console.WriteLine("Clicked");
            };
            //Saving Button
            pageGrid.Add(plantButton, 0, 2);
            pageGrid.SetColumnSpan(plantButton, 2);
            //TODO: Add Save functionality
            pageGrid.RowDefinitions.Add(new RowDefinition(GridLength.Auto));

            Content = new ScrollView { Content = pageGrid };
        }
        catch(Exception ex) {
            Console.WriteLine(ex.Message);
        }



    }
}