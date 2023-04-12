using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Graphics;

namespace MauiApp1
{
    public partial class CustomViewContainer : ContentView
    {
        public CustomViewContainer()
        {
            InitializeComponent();
        }

        private void ContentView_Loaded(object sender, EventArgs e)
        {
            ContentContainer.Content = new NativeControl();
        }
    }
}