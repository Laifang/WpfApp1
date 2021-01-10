using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfApp1.chapter06
{
    /// <summary>
    /// chapter_6_2_1.xaml 的交互逻辑
    /// </summary>
    public partial class chapter_6_2_1 : Window
    {
        Student stu;
        public chapter_6_2_1()
        {
            InitializeComponent();
            //准备数据源
            stu = new Student();
            //准备Binding
            var binding = new Binding
            {
                Source = stu,
                Path = new PropertyPath("Name")
            };

            //使用Binding 连接数据源与Binding目标
            BindingOperations.SetBinding(this.textBoxName, TextBox.TextProperty, binding);
            //TextBox  本身的基类FrameWorkElement 对BindingOperations.setBinding（...)方法进行了分装，以下是简化的代码
            //this.textBoxName.SetBinding(TextBox.TextProperty, new Binding() { Source = stu = new Student() });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //使用button按钮事件更改stu的Name的值，会看到textbox 的内容发生了改变，说明stu.Name与TextBox.Text 属性进行了绑定
            stu.Name += "Name";
        }
    }

    public class Student : INotifyPropertyChanged
    {
        private string name;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this,new PropertyChangedEventArgs("Name"));
                }
            }
        }
    }
}