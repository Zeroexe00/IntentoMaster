using System;

using Xamarin.Forms;

namespace Tried1
{
    public class Master : ContentPage
    {
        public Master()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

