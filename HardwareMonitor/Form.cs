using System;

namespace HardwareMonitor
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly CPU _cpu = new CPU();
        private readonly RAM _ram = new RAM();
        private readonly HDD _hdd = new HDD();

        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _cpu.CurrentIndex = pCPU.NextValue();
            _ram.CurrentIndex = pRAM.NextValue();
            _hdd.CurrentIndex = pHDD.NextValue();

            chart.Series["CPU"].Points.AddY(_cpu.CurrentIndex);
            chart.Series["RAM"].Points.AddY(_ram.CurrentIndex);
            chart.Series["HDD"].Points.AddY(_hdd.CurrentIndex);

            progressBarCPU.Value = (int)_cpu.CurrentIndex;
            progressBarRAM.Value = (int)_ram.CurrentIndex;
            progressBarHDD.Value = (int)_hdd.CurrentIndex;

            UpdateChartInformation();
        }

        private void UpdateChartInformation()
        {
            _cpu.Update();
            _ram.Update();
            _hdd.Update();

            labelCpuShow.Text = _cpu.CurrentInfo;
            labelCpuShowMax.Text = _cpu.MaxInfo;

            labelRamShow.Text = _ram.CurrentInfo;
            labelRamShowMax.Text = _ram.MaxInfo;

            labelHddShow.Text = _hdd.CurrentInfo;
            labelHddShowMax.Text = _hdd.MaxInfo;
        }
    }
}
