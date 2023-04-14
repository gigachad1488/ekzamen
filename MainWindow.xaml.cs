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

namespace ekzamen
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void enter_CLick(object sender, RoutedEventArgs e)
        {
            if (TextBox_login.Text.Length > 0)
            {
                if (Password.Password.Length)
                {
                    DataTable dt_user = MainWindow.ContentTemplateSelectorProperty("Select * FROM [dbo].[Пользователи] WHERE [Логин]="'' + TextBox_Login.Text + "AND [password] = " + password.Password + "'";
                    if (dt_user.Rows.Count > 0)
                    {
                        MessageBox.Show("Пользователь авторизовался");

                    } else MessageBox.Show("Пользователь не найден");
                } else MessageBox.Show("Введите пароль");
            } else MessageBox.Show("Введите логин");
        }
    }
}
