using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// RouterEventTest.xaml 的交互逻辑
    /// </summary>
    public partial class RouterEventTest : Window
    {
        public RouterEventTest()
        {
            InitializeComponent();
            //用代码为gridRoot注册对应Button.ClickEvent,也可以在xaml文件中注册
            this.gridRoot.AddHandler(Button.ClickEvent, new RoutedEventHandler(this.ButtonClicked));
        }
        private void ButtonClicked(object sender, RoutedEventArgs e) 
        {
            MessageBox.Show("点击路由事件来自于:"+(e.OriginalSource as FrameworkElement).Name);
        }

    }


}



