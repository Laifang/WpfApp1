using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1
{
    /// <summary>
    /// IconTextButton示例，把Icon的SVG数据 设置为可灵活配置的形式，需要用到依赖属性DependencyProperty
    /// </summary>
    public class IconTextButton : Button
    {


        
        public IconTextButton()
        {
        }

        /// <summary>
        /// 图标数据
        /// </summary>
        public Geometry IconData
        {
            get { return (Geometry)GetValue(IconDataProperty); }
            set { SetValue(IconDataProperty, value); }
        }
        /// <summary>
        /// <see cref="IconData"/> 这个用法需要学习一下是干什么的
        /// </summary>
        public static readonly DependencyProperty IconDataProperty =
            DependencyProperty.Register(nameof(IconData), typeof(Geometry), typeof(IconTextButton));
    }
}