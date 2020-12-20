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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {   
        Student stu;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            //在student类实现了依赖属性和clr包装器的基础上 可以轻易地完成双向绑定
            Student stu= new Student();
            stu.Name=this.box1.Text;
            this.box2.Text=stu.Name;
            MessageBox.Show("现在stu.Name属性的值为："+(string)stu.Name);
        }
    }
    public class Student : DependencyObject 
    {
         
        public static readonly DependencyProperty NameProperty = DependencyProperty.Register("Name",typeof(string),typeof(Student));
        //当Student类 使用了依赖属性和clr属性包装器，就可以实现绑定 
        public string Name{
            get{return (string)GetValue(NameProperty);}
            set{SetValue(NameProperty,value);}
        }       
    }    
}   