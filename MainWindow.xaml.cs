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

namespace ClassWork21
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Phone> phonesList = new List<Phone>
            {
                new Phone {Title="iPhone 6S", Company="Apple", Price=54990 },
                new Phone {Title="Lumia 950", Company="Microsoft", Price=39990 },
                new Phone {Title="Nexus 5X", Company="Google", Price=29990 }
            };
        public MainWindow()
        {
            InitializeComponent();            
            phonesGrid.ItemsSource = phonesList;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Phone addPhone = new Phone { Title = "Honor 10 Lite", Company = "Huawei", Price = 15990 };
            phonesList.Add(addPhone);
            phonesGrid.ItemsSource = null;
            phonesGrid.ItemsSource = phonesList;
        }
    //Описать класс "Телефонный звонок"
    //-номер телефона
    //-дата разговора
    //-продолжительность

    //Создать список объектов класса

    //Вывести в таблицу

    //Добавить данные


    }


}
