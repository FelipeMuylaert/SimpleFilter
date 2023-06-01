namespace CODIGOS
{
    using System;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;
    using System.Drawing;

    public partial class Form1 : Form
    {
        private double low_pass;
        private double high_pass;
        private TextBox textBoxLow;
        private TextBox textBoxHigh;
        private Label labelLow;
        private Label labelHigh;
        private Button button;
        private Chart chart;
        private Series series;

        public Form1()
        {
            InitializeComponent();

            labelLow = new Label();
            labelLow.Text = "Low pass filter cutoff Hz";
            labelLow.Location = new System.Drawing.Point(20, 10);

            textBoxLow = new TextBox();
            textBoxLow.Location = new System.Drawing.Point(20, 40);
            textBoxLow.Size = new System.Drawing.Size(100, 20);

            labelHigh = new Label();
            labelHigh.Text = "High pass filter cutoff Hz";
            labelHigh.Location = new System.Drawing.Point(20, 70);

            textBoxHigh = new TextBox();
            textBoxHigh.Location = new System.Drawing.Point(20, 100);
            textBoxHigh.Size = new System.Drawing.Size(100, 20);

            button = new Button();
            button.Text = "Carregar valores";
            button.Location = new System.Drawing.Point(20, 130);
            button.Click += Button_Click;

            chart = new Chart();
            chart.Dock = DockStyle.Fill;
            Panel chartPanel = new Panel();
            chartPanel.Location = new Point(130, 10);
            chartPanel.Size = new Size(600, 400);
            chartPanel.Controls.Add(chart);
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            Series series = new Series();
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 3;
            series.Color = Color.Black;

            series.Points.Add(new DataPoint(0, 0));
            series.Points.Add(new DataPoint(1, 0));
            series.Points.Add(new DataPoint(2, -4.7469604e-7));
            series.Points.Add(new DataPoint(3,-1.306379e-6));
            series.Points.Add(new DataPoint(4,5.5409564e-6));
            series.Points.Add(new DataPoint(5,3.520742e-5));
            series.Points.Add(new DataPoint(6,5.2020758e-5));
            series.Points.Add(new DataPoint(7,6.0402552e-5));
            series.Points.Add(new DataPoint(8,-4.3129519e-5));
            series.Points.Add(new DataPoint(9,-0.0001125016));
            series.Points.Add(new DataPoint(10,-0.00018260432));
            series.Points.Add(new DataPoint(11,-0.00015841764));
            series.Points.Add(new DataPoint(12,-0.00011617896));
            series.Points.Add(new DataPoint(13,-0.00013290522));
            series.Points.Add(new DataPoint(14,-0.00037435323));
            series.Points.Add(new DataPoint(15,-0.00068153447));
            series.Points.Add(new DataPoint(16,-0.00031832643));
            series.Points.Add(new DataPoint(17,0.00046329558));
            series.Points.Add(new DataPoint(18,-0.00037943243));
            series.Points.Add(new DataPoint(19,-0.00378769));
            series.Points.Add(new DataPoint(20,-0.00547472));
            series.Points.Add(new DataPoint(21,0.00042749097));
            series.Points.Add(new DataPoint(22,0.01129542));
            series.Points.Add(new DataPoint(23,0.01534481));
            series.Points.Add(new DataPoint(24,0.00580368));
            series.Points.Add(new DataPoint(25,-0.00856397));
            series.Points.Add(new DataPoint(26,-0.01388226));
            series.Points.Add(new DataPoint(27,-0.00761286));
            series.Points.Add(new DataPoint(28,0.00137434));
            series.Points.Add(new DataPoint(29,0.00595682));
            series.Points.Add(new DataPoint(30,0.00596679));
            series.Points.Add(new DataPoint(31,0.0031812));
            series.Points.Add(new DataPoint(32,-0.00125056));
            series.Points.Add(new DataPoint(33,-0.00466955));
            series.Points.Add(new DataPoint(34,-0.00398068));
            series.Points.Add(new DataPoint(35,-6.5110777e-5));
            series.Points.Add(new DataPoint(36,0.00263525));
            series.Points.Add(new DataPoint(37,0.00135817));
            series.Points.Add(new DataPoint(38,-0.00222557));
            series.Points.Add(new DataPoint(39,-0.00419043));
            series.Points.Add(new DataPoint(40,-0.00252298));
            series.Points.Add(new DataPoint(41,0.00150468));
            series.Points.Add(new DataPoint(42,0.00427969));
            series.Points.Add(new DataPoint(43,0.00348717));
            series.Points.Add(new DataPoint(44,0.00047537009));
            series.Points.Add(new DataPoint(45,-0.00111418));
            series.Points.Add(new DataPoint(46,-0.00012526485));
            series.Points.Add(new DataPoint(47,0.00067645544));
            series.Points.Add(new DataPoint(48,-0.00110193));
            series.Points.Add(new DataPoint(49,-0.00380943));
            series.Points.Add(new DataPoint(50,-0.00426841));
            series.Points.Add(new DataPoint(51,-0.00202688));
            series.Points.Add(new DataPoint(52,0.0010157));
            series.Points.Add(new DataPoint(53,0.00342666));
            series.Points.Add(new DataPoint(54,0.00453182));
            series.Points.Add(new DataPoint(55,0.00341483));
            series.Points.Add(new DataPoint(56,-9.0311965e-5));
            series.Points.Add(new DataPoint(57,-0.00399398));
            series.Points.Add(new DataPoint(58,-0.00504003));
            series.Points.Add(new DataPoint(59,-0.00176624));
            series.Points.Add(new DataPoint(60,0.00331933));
            series.Points.Add(new DataPoint(61,0.00576494));
            series.Points.Add(new DataPoint(62,0.00382156));
            series.Points.Add(new DataPoint(63,0.0001423753));
            series.Points.Add(new DataPoint(64,-0.00211393));
            series.Points.Add(new DataPoint(65,-0.00250719));
            series.Points.Add(new DataPoint(66,-0.00185713));
            series.Points.Add(new DataPoint(67,-0.00013720396));
            series.Points.Add(new DataPoint(68,0.00231429));
            series.Points.Add(new DataPoint(69,0.00343645));
            series.Points.Add(new DataPoint(70,0.00150276));
            series.Points.Add(new DataPoint(71,-0.00219182));
            series.Points.Add(new DataPoint(72,-0.00395536));
            series.Points.Add(new DataPoint(73,-0.00174808));
            series.Points.Add(new DataPoint(74,0.00208693));
            series.Points.Add(new DataPoint(75,0.00311306));
            series.Points.Add(new DataPoint(76,4.1200336e-5));
            series.Points.Add(new DataPoint(77,-0.00379334));
            series.Points.Add(new DataPoint(78,-0.00467363));
            series.Points.Add(new DataPoint(79,-0.00218674));
            series.Points.Add(new DataPoint(80,0.00148802));
            series.Points.Add(new DataPoint(81,0.00418122));
            series.Points.Add(new DataPoint(82,0.00460599));
            series.Points.Add(new DataPoint(83,0.00209465));
            series.Points.Add(new DataPoint(84,-0.00219807));
            series.Points.Add(new DataPoint(85,-0.00469068));
            series.Points.Add(new DataPoint(86,-0.00215968));
            series.Points.Add(new DataPoint(87,0.00351081));
            series.Points.Add(new DataPoint(88,0.00612001));
            series.Points.Add(new DataPoint(89,0.00310432));
            series.Points.Add(new DataPoint(90,-0.00089744007));
            series.Points.Add(new DataPoint(91,-0.00096810103));
            series.Points.Add(new DataPoint(92,0.00038296447));
            series.Points.Add(new DataPoint(93,-0.00236524));
            series.Points.Add(new DataPoint(94,-0.0079986));
            series.Points.Add(new DataPoint(95,-0.00873421));
            series.Points.Add(new DataPoint(96,-0.00056528149));
            series.Points.Add(new DataPoint(97,0.01055785));
            series.Points.Add(new DataPoint(98,0.01466104));
            series.Points.Add(new DataPoint(99,0.00731156));
            series.Points.Add(new DataPoint(100,-0.00676257));
            series.Points.Add(new DataPoint(101,-0.01739577));
            series.Points.Add(new DataPoint(102,-0.01596056));
            series.Points.Add(new DataPoint(103,-0.00286475));
            series.Points.Add(new DataPoint(104,0.01101428));
            series.Points.Add(new DataPoint(105,0.01418228));
            series.Points.Add(new DataPoint(106,0.00656275));
            series.Points.Add(new DataPoint(107,-0.00172098));
            series.Points.Add(new DataPoint(108,-0.00346449));
            series.Points.Add(new DataPoint(109,-0.00097349909));
            series.Points.Add(new DataPoint(110,0.00043476542));
            series.Points.Add(new DataPoint(111,-0.00024356153));
            series.Points.Add(new DataPoint(112,-0.00087278237));
            series.Points.Add(new DataPoint(113,-0.00062934903));
            series.Points.Add(new DataPoint(114,-0.00022400485));
            series.Points.Add(new DataPoint(115,-0.00018248211));
            series.Points.Add(new DataPoint(116,-0.00022873518));
            series.Points.Add(new DataPoint(117,-0.00019961091));
            series.Points.Add(new DataPoint(118,-0.00019236178));
            series.Points.Add(new DataPoint(119,-0.00014879073));
            series.Points.Add(new DataPoint(120,-9.5523988e-5));
            series.Points.Add(new DataPoint(121,-1.2213283e-5));
            series.Points.Add(new DataPoint(122,1.0215717e-5));

            Series series_smoothed = new Series();
            series_smoothed.ChartType = SeriesChartType.Line;
            series_smoothed.BorderWidth = 2;
            series_smoothed.Color = Color.Blue;

            low_pass = 0.005;
            high_pass = -0.005;

            for (int i = 0; i < series.Points.Count; i++)
            {
                double testValue = series.Points[i].YValues[0];

                if (testValue < low_pass && testValue > high_pass)
                {
                    series_smoothed.Points.Add(new DataPoint(i, testValue));
                }
                else if (testValue < high_pass)
                {
                    series_smoothed.Points.Add(new DataPoint(i, high_pass));
                }
                else
                {
                    series_smoothed.Points.Add(new DataPoint(i, low_pass));
                }
            }

            chart.Series.Add(series);
            chart.Series.Add(series_smoothed);

            this.Controls.Add(labelLow);
            this.Controls.Add(textBoxLow);
            this.Controls.Add(labelHigh);
            this.Controls.Add(textBoxHigh);
            this.Controls.Add(button);
            this.Controls.Add(chartPanel);

            this.Text = "Basic Filtering Example";
        }

private void Button_Click(object? sender, EventArgs e)
{
    double low_pass = Convert.ToDouble(textBoxLow.Text);
    double high_pass = Convert.ToDouble(textBoxHigh.Text);

    if (chart.Series.Count > 0)
    {
        Series series = chart.Series[0];
        Series series_smoothed = new Series();
        series_smoothed.ChartType = SeriesChartType.Line;
        series_smoothed.BorderWidth = 2;
        series_smoothed.Color = Color.Blue;
        if (chart.Series.Count > 1)
            chart.Series.RemoveAt(1);
        for (int i = 0; i < series.Points.Count; i++)
        {
            double testValue = series.Points[i].YValues[0];

            if (testValue < low_pass && testValue > high_pass)
            {
                series_smoothed.Points.Add(new DataPoint(i, testValue));
            }
            else if (testValue < high_pass)
            {
                series_smoothed.Points.Add(new DataPoint(i, high_pass));
            }
            else
            {
                series_smoothed.Points.Add(new DataPoint(i, low_pass));
            }
        }
        chart.Series.Add(series_smoothed);
        chart.Refresh();
    }
}

    }
}