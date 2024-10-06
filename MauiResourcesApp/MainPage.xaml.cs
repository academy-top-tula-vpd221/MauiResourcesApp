namespace MauiResourcesApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            Color textColor = Color.FromArgb("#ffffdddd");
            Color backColor = Color.FromArgb("#ff330000");
            int padding = 20;
            int margin = 30;

            ResourceDictionary colorsResources = new();
            colorsResources.Add("textColor", textColor);
            colorsResources.Add("backColor", backColor);
            colorsResources.Add("padding", padding);
            colorsResources.Add("margin", margin);

            this.Resources = colorsResources;


            //btnMoscow.TextColor = Resources["textColor"] as Color;
            //btnMoscow.BackgroundColor = Resources["backColor"] as Color;

            btnMoscow.Margin = (int)Resources["margin"];
            btnMoscow.Padding = (int)Resources["padding"];

            btnMoscow.SetDynamicResource(Button.TextColorProperty, "textColor");
            btnMoscow.SetDynamicResource(Button.BackgroundColorProperty, "backColor");
        }

        private void btnPeterbug_Clicked(object sender, EventArgs e)
        {
            btnPeterbug.TextColor = Resources["textColor"] as Color;
            btnPeterbug.BackgroundColor = Resources["backColor"] as Color;

            btnPeterbug.Margin = (int)Resources["margin"];
            btnPeterbug.Padding = (int)Resources["padding"];

            Resources["textColor"] = Color.FromArgb("#ffddddff");
            Resources["backColor"] = Color.FromArgb("#ff000033");
        }
    }

}
