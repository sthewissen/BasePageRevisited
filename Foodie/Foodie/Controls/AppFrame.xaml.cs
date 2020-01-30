using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Foodie.Controls
{
    public partial class AppFrame : Grid
    {
        public static readonly BindableProperty ContentProperty = BindableProperty.Create(nameof(Content), typeof(View), typeof(AppFrame));

        public View Content
        {
            get { return (View)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        public AppFrame()
        {
            InitializeComponent();
        }
    }
}
