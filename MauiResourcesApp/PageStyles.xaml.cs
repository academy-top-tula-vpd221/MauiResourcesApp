using Microsoft.Maui.Controls;

namespace MauiResourcesApp;

public partial class PageStyles : ContentPage
{
    public PageStyles()
    {
        InitializeComponent();

        Style labelStyle = new(typeof(Label))
        {
            Setters =
            {
                new Setter
                {
                    Property = Label.TextColorProperty,
                    Value = Color.FromArgb("#ff000033")
                },
                new Setter
                {
                    Property = Label.BackgroundColorProperty,
                    Value = Color.FromArgb("#ffddddff")
                },
                new Setter
                {
                    Property = Label.PaddingProperty,
                    Value = 20
                },
                new Setter
                {
                    Property = Label.MarginProperty,
                    Value = 30
                },
            }
        };
        this.Resources.Add(labelStyle);
    }
}