using System.Windows;

namespace WpfApp1
{
    public class WithDescIconTextButton : IconTextButton
    {


        public string Description
        {
            get { return (string)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }
        /// <summary>
        /// <see cref="Description"/>
        /// </summary>
        // Using a DependencyProperty as the backing store for Description.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register(nameof(Description), typeof(string), typeof(WithDescIconTextButton));


    }
}