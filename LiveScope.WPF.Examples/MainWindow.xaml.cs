using LiveScope.Net;
using LiveScope.Net.Core;
using LiveScope.Net.DataCapture.DataSinks;
using LiveScope.Windows;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
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
        private FileDataSink? sink = null;
        internal MainWindowModel Model { get; set; }
        public MainWindow()
        {
            this.Model = new MainWindowModel();
            InitializeComponent();
            this.DataContext = this.Model;
            this.Model.Chart = this.chartMainA;
        }
        private void btnAutoscale_Click(object sender, RoutedEventArgs e)
        {
            this.chartMainA.EnableAutoscale();
        }
        private void btnLockCursor_Click(object sender, RoutedEventArgs e)
        {
            this.chartMainA.EnableCursorLock = !this.chartMainA.EnableCursorLock;
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
            IDataCapture capture = null;
            var path = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                "LiveScopeDemo.scope");
            sink = new FileDataSink(this.chartMainA.ViewArea, path);
            switch (this.listInstruments.SelectedIndex)
            {
                case 0:
                    /*
                     * Capture Windows audio data from the default audio device
                     * ...using a very short window of 10ms
                     */
                    capture = new WindowsAudioDataCapture(44100, 0.01);
                    this.chartMainA.AddSeries(capture);
                    this.chartMainA.TimeLength = 0.02;
                    this.chartMainA.YMin = 0;
                    this.chartMainA.YMax = 255;
                    break;
                case 1:
                    /*
                     * Capture Windows audio data from the default audio device
                     * ...using a long window of 10s
                     */
                    capture = new WindowsAudioDataCapture(44100, 5.0, 10);
                    this.chartMainA.AddSeries(capture);
                    this.chartMainA.TimeLength = 1;
                    this.chartMainA.YMin = 0;
                    this.chartMainA.YMax = 255;
                    break;
                case 2:
                    /*
                     * Generate signals using in-memory signal generator
                     * ...and capture it all in-memory
                     */
                    capture = new GenerativeDataCapture(
                        1.25, -1.0, 2.0, 1.0 / 44100.0, 5.5);
                    this.chartMainA.AddSeries(capture);
                    this.chartMainA.TimeLength = 2;
                    this.chartMainA.YMin = -1;
                    this.chartMainA.YMax = 2;
                    break;
                case 3:
                    /*
                     * Load a .csv file and pseudo-capture it
                     */
                    OpenFileDialog dialog = new OpenFileDialog();
                    dialog.Filter = "csv|*.csv";
                    var result = dialog.ShowDialog(this);
                    if (result.HasValue && result.Value)
                    {
                        capture = new CsvDataCapture(dialog.FileName,
                            0.01, 5.0);
                        this.chartMainA.AddSeries(capture);
                        this.chartMainA.TimeLength = 2;
                        this.chartMainA.YMin = -2;
                        this.chartMainA.YMax = 2;
                    }
                    break;
                case 4:
                    /*
                     * Load and playback a previously captured LiveScope file
                     */
                    OpenFileDialog dialog2 = new OpenFileDialog();
                    dialog2.Filter = "LiveScope|*.scope";
                    var result2 = dialog2.ShowDialog(this);
                    if (result2.HasValue && result2.Value)
                    {
                        var ls_cap = new LiveScopeFileDataCapture(dialog2.FileName,
                            5.0);
                        this.chartMainA.AddSeries(ls_cap);
                        this.chartMainA.TimeLength = Math.Abs(ls_cap.ViewArea.XMax - ls_cap.ViewArea.XMin);
                        this.chartMainA.YMin = ls_cap.ViewArea.YMin;
                        this.chartMainA.YMax = ls_cap.ViewArea.YMax;
                    }
                    break;
            }

            /*
             * Stream to disk using `FileDataSink`
             */
            if (capture is not null && Model.IsFileStreamingEnabled)
            {
                sink.DataCapture = capture;
                sink.ViewArea = this.chartMainA.ViewArea;
            }

        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
        }

        private void BtnSaveData_OnClick(object sender, RoutedEventArgs e)
        {
            this.chartMainA.SaveSeriesDataAs("foo.scope");
        }
    }
}
