using Avalonia.Controls;
using Avalonia.Interactivity;
using LiveScope.Net;
using LiveScope.Net.DataCapture;
using LiveScope.Net.DataCapture.DataSinks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LiveScope.Avalonia.Examples.Views
{
    public partial class MainView : UserControl
    {
        private readonly Dictionary<uint, bool> autoscale = new();
        private IHardwareDataCapture hardwareDataCapture = null;
        private FileDataSink sink = null;
        public MainView()
        {
            InitializeComponent();
        }

        private void BtnStartRecording_OnClick(object sender, RoutedEventArgs e)
        {
            /* AppendFrameSync Example
             ...every 10ms, the screen data buffer is appended to,
                and the screen data buffer is dumped every time the display is refreshed (50ms)
             ...previous frame data is appended to current frame, resulting in a pseudo-scrolling frame
             ...eventually displays {buffer_size} number of samples
             */
            var capture = AudioDataCaptureFactory.Create(44100, 2.0, SweepMode: SweepModes.Single);
            //this.sink = new FileDataSink(capture, this.chartMainA.ViewArea, "test.livescope");
            this.chartMainA.AddSeries(capture);
            this.chartMainA.TimeLength = 2;
            this.chartMainA.YMin = 0;
            this.chartMainA.YMax = 255;
        }

        private void btnGenerate_OnClick(object? sender, RoutedEventArgs e)
        {
            var capture = new GenerativeDataCapture(1.0, 0.0, 1000.0,
                .0001, 5.0);
            //this.sink = new FileDataSink(capture, this.chartMainA.ViewArea, "test.livescope");
            this.chartMainA.AddSeries(capture);
            this.chartMainA.TimeLength = 2;
            this.chartMainA.YMin = 0;
            this.chartMainA.YMax = 1000;
        }

        private void BtnAutoscale_OnClick(object? sender, RoutedEventArgs e)
        {
            if (this.autoscale.ContainsKey(this.chartMainA.ActiveSeriesId)
                && this.autoscale[this.chartMainA.ActiveSeriesId])
            {
                this.chartMainA.EnableAutoscale(chartMainA.ActiveSeriesId, false);
                this.autoscale[this.chartMainA.ActiveSeriesId] = false;
            }
            else
            {
                this.chartMainA.EnableAutoscale(chartMainA.ActiveSeriesId, true);
                this.autoscale[this.chartMainA.ActiveSeriesId] = true;
            }
        }
        private void BtnPause_OnClick(object? sender, RoutedEventArgs e)
        {
            this.chartMainA.PauseSeries();
        }
        private void BtnResume_OnClick(object? sender, RoutedEventArgs e)
        {
            this.chartMainA.ResumeSeries();
        }
        private void BtnRemove_OnClick(object? sender, RoutedEventArgs e)
        {
            this.chartMainA.RemoveSeries();
        }
    }
}