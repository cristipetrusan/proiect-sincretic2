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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        ViewModel _viewModel;
        private System.Windows.Threading.DispatcherTimer _timer = new System.Windows.Threading.DispatcherTimer();
        private const int _unit = 1;
        public UserControl1()
        {
            InitializeComponent();
            _viewModel = new ViewModel();
            this.DataContext = _viewModel;
            progressBar.Value = 50;
            _timer.Interval = System.TimeSpan.FromMilliseconds(50);
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            GetProgressBarColor();
            if (_viewModel.S1) progressBar.Value += 1;
            if (_viewModel.S2) progressBar.Value += 1;
            if (_viewModel.S3) progressBar.Value += 1;
            if (_viewModel.S4) progressBar.Value += 1;
            progressBar.Value -= 2;
        }

        private void GetProgressBarColor()
        {
            if (progressBar.Value >= 0 && progressBar.Value <= 70)
            { progressBar.Foreground = new SolidColorBrush(Color.FromRgb(0, 255, 0)); return; }
            if (progressBar.Value > 70 && progressBar.Value < 90)
            { progressBar.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 255)); return; }
            if (progressBar.Value > 90)
            { progressBar.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0)); return; }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _viewModel.S1 = !_viewModel.S1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            _viewModel.S2 = !_viewModel.S2;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.S3 = !_viewModel.S3;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            _viewModel.S4 = !_viewModel.S4;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if ((_viewModel.S1 || _viewModel.S2 || _viewModel.S3 || _viewModel.S4)
                && !(_viewModel.S1 && _viewModel.S2 && _viewModel.S3 && _viewModel.S4))
            {
                _viewModel.S1 = false;
                _viewModel.S2 = false;
                _viewModel.S3 = false;
                _viewModel.S4 = false;
                return;
            }
            _viewModel.S1 = !_viewModel.S1;
            _viewModel.S2 = !_viewModel.S2;
            _viewModel.S3 = !_viewModel.S3;
            _viewModel.S4 = !_viewModel.S4;
        }
    }
}
