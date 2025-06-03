namespace LiveScope.Intergration.Examples
{
    /// <summary>
    /// 
    /// </summary>
    public class MyDataCapture : IDataCapture
    {
        public void SetOnDataAvailable(SamplesDelegate callback)
        {
            /*
             * Set the callback to be called when data is available
             */
            throw new NotImplementedException();
        }

        public void StartCapture()
        {
            /*
             * Send signals to hardware to initiate capture
             */
            throw new NotImplementedException();
        }

        public void StopCapture()
        {
            /*
             * Send signals to hardware to halt capture
             */
            throw new NotImplementedException();
        }

        public int BufferSize { get; }
        public DataSources DataSource { get; }
        public Guid ID { get; }
        public double SampleInterval { get; }
        public SampleOrderTypes SampleOrder { get; }
        public SweepModes SweepMode { get; }
    }
}
