using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Foodie.Controls
{
    //[ContentProperty(nameof(Content))]
    public partial class AppFrame : Grid
    {
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(AppFrame), default(string));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

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
