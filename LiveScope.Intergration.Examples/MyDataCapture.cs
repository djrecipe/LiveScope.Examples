namespace LiveScope.Intergration.Examples
{
    /// <summary>
    /// 
    /// </summary>
    public class MyDataCapture : IDataCapture
    {
        public void SetOnDataAvailable(SamplesDelegate callback)
        {
            throw new NotImplementedException();
        }

        public void StartCapture()
        {
            throw new NotImplementedException();
        }

        public void StopCapture()
        {
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
