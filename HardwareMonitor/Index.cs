namespace HardwareMonitor
{
    internal class Index
    {
        public double CurrentIndex { get; set; } = 0;
        public string CurrentInfo { get; private set; } = string.Empty;
        public double MaxIndex { get; private set; } = 0;
        public string MaxInfo { get; private set; } = string.Empty;

        protected Index()
        {

        }

        public void Update()
        {
            CurrentIndex /= 100;

            UpdateMaxIndexValue();
            RefreshInfo();
        }

        private void UpdateMaxIndexValue()
        {
            if (CurrentIndex > MaxIndex)
                MaxIndex = CurrentIndex;
        }

        private void RefreshInfo()
        {
            CurrentInfo = string.Format("Current: {0:0.00%}", CurrentIndex);
            MaxInfo = string.Format("Max: {0:0.00%}", MaxIndex);
        }
    }
}
