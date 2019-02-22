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

namespace CsLab01
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

        private DateTime _currentDate = DateTime.Now;
        private DateTime? selectedDate;
        private int _age;
        

        
       
       

        private void DatePick(object sender, SelectionChangedEventArgs e)
        {
            selectedDate = DatePicker1.SelectedDate;

            if (!AgeModel.IsValidAge(selectedDate, _currentDate))
            {
                MessageBox.Show("You entered wrong date!");
            }

            if (AgeModel.IsBirthDay(selectedDate, _currentDate))
            {
                MessageBox.Show("Happy birthday! \n SCHASTYA ZDOROVLYA!");
            }

            WHoroSignTB.Text = AgeModel.WestHoro(selectedDate);
            CHoroSignTB.Text = AgeModel.ChineseZodiak(selectedDate);
           
            _age =  (_currentDate - selectedDate).Value.Days / 365 ;
            ageTB.Text = _age.ToString();   
           
        }

     
    }
}
