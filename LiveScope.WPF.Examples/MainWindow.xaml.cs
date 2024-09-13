using LiveScope.Net;
using LiveScope.Net.Core;
using LiveScope.Windows;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace LiveScope.WPF.Examples
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal MainWindowModel Model { get; set; }
        public MainWindow()
        {
            this.Model = new MainWindowModel();
            InitializeComponent();
            this.DataContext = this.Model;
        }
        private void btnAutoscale_Click(object sender, RoutedEventArgs e)
        {
            this.chartMainA.EnableAutoscale();
        }
        private void btnPause_Click(object sender, RoutedEventArgs e)
        {
            this.chartMainA.PauseSeries();
        }
        private void btnResume_Click(object sender, RoutedEventArgs e)
        {
            this.chartMainA.ResumeSeries();
        }
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            this.chartMainA.RemoveSeries();
        }
        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            switch (this.listInstruments.SelectedIndex)
            {
                case 0:
                    this.chartMainA.AddSeries(new WindowsAudioDataCapture(44100, 0.01));
                    this.chartMainA.TimeLength = 0.02;
                    this.chartMainA.YMin = 0;
                    this.chartMainA.YMax = 255;
                    break;
                case 1:
                    this.chartMainA.AddSeries(new WindowsAudioDataCapture(44100, 5.0, 10));
                    this.chartMainA.TimeLength = 1;
                    this.chartMainA.YMin = 0;
                    this.chartMainA.YMax = 255;
                    break;
                case 2:
                    this.chartMainA.AddSeries(new Pico2000DataCapture(10.0, 2.0,
                        0.00001, 1.0));
                    this.chartMainA.TimeLength = 1;
                    this.chartMainA.YMin = -2;
                    this.chartMainA.YMax = 2;
                    break;
                case 3:
                    this.chartMainA.AddSeries(new GenerativeDataCapture(
                    1.0, -1.0, 1.0, 0.0001, 5));
                    this.chartMainA.TimeLength = 2;
                    this.chartMainA.YMin = -1;
                    this.chartMainA.YMax = 1;
                    break;
                case 4:
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "csv|*.csv";
                    var result = dialog.ShowDialog(this);
                    if (result.HasValue && result.Value)
                    {
                        this.chartMainA.AddSeries(new CsvDataCapture(dialog.FileName, 0.01, 5.0));
                        this.chartMainA.TimeLength = 2;
                        this.chartMainA.YMin = -2;
                        this.chartMainA.YMax = 2;
                    }
                    break;
            }
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
        }
    }
}
