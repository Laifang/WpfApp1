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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            Student stu = new Student();
            stu.SetValue(Student.NameProperty, this.box1.Text);
            box2.Text = (string)stu.GetValue(Student.NameProperty);
        }
    }
    public class Student : DependencyObject 
    {
        public static readonly DependencyProperty NameProperty = DependencyProperty.Register("Name",typeof(string),typeof(Student));
        
    }
}
