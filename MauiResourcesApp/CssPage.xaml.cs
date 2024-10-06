using Microsoft.Maui.Controls.StyleSheets;
using System.Reflection;

namespace MauiResourcesApp;

public partial class CssPage : ContentPage
{
	public CssPage()
	{
		InitializeComponent();

		this.Resources.Add(StyleSheet.FromResource("MyResources/styles.css", IntrospectionExtensions.GetTypeInfo(typeof(CssPage)).Assembly));
	}
}