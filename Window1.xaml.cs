using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfApp1
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        Student stu;
        public Window1()
        {
            InitializeComponent();
            stu = new Student();
            //未实现 BindingExpressionBase SetBinding（）方法之前 只能用这种不太直观的方法设置绑定
            //BindingOperations.SetBinding(stu, Student.NameProperty, new Binding("Text") { Source = box1 });
            stu.SetBinding(Student.NameProperty, new Binding("Text") { Source = box1 });
      
            box2.SetBinding(TextBox.TextProperty, new Binding("Name") { Source = stu });
            
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(stu.GetValue(Student.NameProperty).ToString());
        }
    }
    public class Student : DependencyObject
    {

        public static readonly DependencyProperty NameProperty = DependencyProperty.Register("Name", typeof(string), typeof(Student));
       // 当Student类 使用了依赖属性和clr属性包装器，就可以实现绑定
        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }
        //实现这个方法可以使得Student类 直接调用SetBinding方法,这个方法本身可以看见，也是对BidingOperations.SetBinding()的一个薄封装
        public BindingExpressionBase SetBinding(DependencyProperty dp, BindingBase binding)
        {
            return BindingOperations.SetBinding(this, dp, binding);
        }
    }
}
