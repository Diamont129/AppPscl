using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AppPscl
{
    //p = 1-П(1-pi)

    public partial class Form1 : Form
    {
        FileStream DB;
        FileStream Vrem;
        FileStream VremVost;
        FileStream Zena;

        double Twork;

        string zena;
        string vrem;

        double[] A = new double[3];
        double[] B = new double[3];
        double[] C = new double[3];
        double[] D = new double[3];
        double[] E = new double[3];
        double[] F = new double[3];
        double[] Tfault = new double[3];

        List<Part> parts = new List<Part>();


        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;

            // create image list and fill it 
            var imageList = new ImageList();
            imageList.Images.Add("Cog", Image.FromFile(Path.Combine((System.Reflection.Assembly.GetEntryAssembly().Location.Remove(System.Reflection.Assembly.GetEntryAssembly().Location.Length - Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location).Length, Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location).Length)), @"1200px-Cog_font_awesome.svg.png")));
            // tell your ListView to use the new image list
            listView2.LargeImageList = imageList;

        }

        public void prog()
        {
            string filePath = @"DB.txt";
            string filePath1 = @"Vrem.txt";
            string filePath2 = @"VremVost.txt";
            string filePath3 = @"Zena.txt";

            File.Delete(filePath);
            File.Delete(filePath1);
            File.Delete(filePath2);
            File.Delete(filePath3);

            DB = File.Open(filePath, FileMode.OpenOrCreate);
            Vrem = File.Open(filePath1, FileMode.OpenOrCreate);
            VremVost = File.Open(filePath2, FileMode.OpenOrCreate);
            Zena = File.Open(filePath3, FileMode.OpenOrCreate);

            DB.Position = 0;
            Vrem.Position = 0;
            VremVost.Position = 0;
            Zena.Position = 0;

            var rand = new Random();

            progressBar1.Visible = true;
            progressBar1.Value = 0;
            Console.WriteLine("-----------Новый цикл-------------");

            dataGridView1.DataSource = null;
            List<BrokenTime> AllTimes = new List<BrokenTime>();

            for (int p = 0; p < iterarionsAmmount.Value; p++)
            {
                progressBar1.Value = Convert.ToInt32(Convert.ToDouble(p / iterarionsAmmount.Value) * 100);

                double Price = 0;
                double Trem = 0;
                //-----------------------
                List<BrokenTime> TimesNew = new List<BrokenTime>();
                bool[] ammFixed = new bool[parts.Count];

                double fullTime = 0;

                foreach (Part part_num in parts)
                {
                    double repTime = 0;
                    fullTime = 0;
                    while (fullTime < Twork)
                    {
                        TimesNew.Add(new BrokenTime()
                        {
                            timeID = TimesNew.Count,
                            part = part_num,
                            time = RealBreakT(part_num.partNnO, part_num.partSKONnO, fullTime, repTime, rand, part_num.partBreakDist),
                            repairTime = RealRepT(part_num.partVV, part_num.partSKOVV, rand, part_num.partRepairDist),
                            repairCost = RealRepP(part_num.partSR, part_num.partSKOSR, rand, part_num.partPriceDist),
                            iterNum = p
                        });
                        fullTime = TimesNew.Last().time;
                        repTime = TimesNew.Last().repairTime;
                    }
                }

                //listBox1.Items.Clear();
                //foreach (BrokenTime brokenTime in TimesNew)
                //{
                //    Console.WriteLine(brokenTime.ToString());
                //    Price += brokenTime.repairCost;
                //    Trem += brokenTime.repairTime;
                //    listBox1.Items.Add(brokenTime);
                //}



                zena = ("Машины отработали заданное время, стоимость ремонта = " + Price);
                vrem = ("Время восстановления = " + Trem);

                foreach (BrokenTime time in TimesNew)
                {
                    if (time.time < Twork)
                    {
                        AllTimes.Add(time);

                        byte[] text = new UTF8Encoding(true).GetBytes(time.ToString());
                        byte[] text1 = new UTF8Encoding(true).GetBytes(time.time.ToString() + "\n");
                        byte[] text2 = new UTF8Encoding(true).GetBytes(time.repairTime.ToString() + "\n");
                        byte[] text3 = new UTF8Encoding(true).GetBytes(time.repairCost.ToString() + "\n");

                        DB.Write(text, 0, text.Length);
                        Vrem.Write(text1, 0, text1.Length);
                        VremVost.Write(text2, 0, text2.Length);
                        Zena.Write(text3, 0, text3.Length);
                    }
                }        
            }
            progressBar1.Value = 100;

            AllTimes.Sort();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = AllTimes;
            dataGridView1.Columns.RemoveAt(0);
            dataGridView1.Columns[0].HeaderText = "Деталь";
            dataGridView1.Columns[1].HeaderText = "Время поломки, часы";
            dataGridView1.Columns[2].HeaderText = "Время восстановления, часы";
            dataGridView1.Columns[3].HeaderText = "Стоимость восстановления, рубли";
            dataGridView1.AutoResizeColumns();


            double[] allTShort = new double[30 * parts.Count()];
            double oneSpace = Twork / 30;

            foreach(BrokenTime time in AllTimes)
            {
                int i = Convert.ToInt32(Math.Floor(Convert.ToDouble(time.time / Twork * 30)));
                if (i < 30)
                {
                    allTShort[i + 30 * time.part.partID] += 1;
                }

                progressBar1.Value = Convert.ToInt32((time.time / Twork) * 100);
            }


            Chart TBChart = timeBreakChart;
            TBChart.Parent = this;
            TBChart.ChartAreas.Clear();
            TBChart.Series.Clear();
            TBChart.ChartAreas.Add(new ChartArea("time visual"));
            TBChart.ChartAreas[0].AxisX.Minimum = 2;
            TBChart.ChartAreas[0].AxisY.Minimum = 0;
            TBChart.ChartAreas[0].AxisX.Title = "ln(t)";
            TBChart.ChartAreas[0].AxisY.Title = "log10(n)";
            for (int j = 0; j < parts.Count(); j++)
            {
                for (int p = 0; p < iterarionsAmmount.Value; p++)
                {
                    Series mySeriesOfPoint = new Series("Время поломки деталей " + rand.Next());
                    mySeriesOfPoint.ChartType = SeriesChartType.Line;
                    mySeriesOfPoint.ChartArea = "time visual";
                    mySeriesOfPoint.Points.AddXY(0, 0);

                    int ammFixed = 1;
                    foreach (BrokenTime brokenTime in AllTimes)
                    {
                        if (brokenTime.part == parts[j] && brokenTime.iterNum == p)
                        {
                            ammFixed++;
                            mySeriesOfPoint.Points.AddXY(Math.Log10(brokenTime.time), Math.Log(ammFixed));
                        }
                    }
                    TBChart.Series.Add(mySeriesOfPoint);
                    TBChart.Series.Last().Color = parts[j].partColor;
                    TBChart.Series.Last().MarkerStyle = MarkerStyle.Diamond;
                }
            }
            
            
            Chart RepChart = repairTime;
            RepChart.Parent = this;
            RepChart.ChartAreas.Clear();
            RepChart.Series.Clear();
            RepChart.ChartAreas.Add(new ChartArea("repTime visual"));
            RepChart.ChartAreas[0].AxisX.Minimum = 0;
            RepChart.ChartAreas[0].AxisX.Title = "t";
            RepChart.ChartAreas[0].AxisY.Title = "n";

            for (int j = 0; j < parts.Count(); j++)
            {
                for (int p = 0; p < iterarionsAmmount.Value; p++)
                {
                    Series RepPoints = new Series("Время починки деталей " + (rand.Next()).ToString());
                    RepPoints.ChartType = SeriesChartType.Line;
                    RepPoints.ChartArea = "repTime visual";
                    double amm = 0;
                    RepPoints.Points.AddXY(0, 0);

                    foreach (BrokenTime brokenTime in AllTimes)
                    {
                        if (brokenTime.part == parts[j] && brokenTime.iterNum == p)
                        {
                            amm += brokenTime.repairTime;
                            RepPoints.Points.AddXY(brokenTime.time, amm);
                        }
                    }
                    RepChart.Series.Add(RepPoints);
                    RepChart.Series.Last().Color = parts[j].partColor;
                    RepChart.Series.Last().MarkerStyle = MarkerStyle.Diamond;
                }
            }
            
            
            Chart price = priceC;
            price.Parent = this;
            price.ChartAreas.Clear();
            price.Series.Clear();
            price.ChartAreas.Add(new ChartArea("priceC visual"));
            price.ChartAreas[0].AxisX.Minimum = 0;
            price.ChartAreas[0].AxisX.Title = "t";
            price.ChartAreas[0].AxisY.Title = "руб";

            for (int p = 0; p < iterarionsAmmount.Value; p++)
            {
                Series pPoints = new Series("Цена починки машины " + (p + 1).ToString());
                pPoints.ChartType = SeriesChartType.Line;
                pPoints.ChartArea = "priceC visual";
                price.Legends.Add(pPoints.Legend);
                price.Legends.Last().Docking = Docking.Bottom;
                price.Legends.Last().MaximumAutoSize = 20;
                double amm = 0;

                pPoints.Points.AddXY(0, 0);

                foreach (BrokenTime brokenTime in AllTimes)
                {
                    if (brokenTime.iterNum == p)
                    {
                        amm += brokenTime.repairCost;
                        pPoints.Points.AddXY(brokenTime.time, amm);
                    }
                }

                price.Series.Add(pPoints);
                price.Series.Last().Color = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                price.Series.Last().MarkerStyle = MarkerStyle.Diamond;

            }
            price.ChartAreas.Last().Position.Auto = true;
            price.ChartAreas.Last().Position.Y = 1;
            price.ChartAreas.Last().Position.X = 1;
            price.ChartAreas.Last().Position.Height = 75;
            price.ChartAreas.Last().Position.Width = 90;


            Chart ProbChart = PriceChart; 
            ProbChart.Parent = this;
            ProbChart.ChartAreas.Clear();
            ProbChart.Series.Clear();
            ProbChart.Legends.Clear();
            ProbChart.ChartAreas.Add(new ChartArea("probab visual"));
            ProbChart.ChartAreas[0].AxisX.Minimum = 0;
            ProbChart.ChartAreas[0].AxisX.Maximum = Twork;
            ProbChart.ChartAreas[0].AxisY.Minimum = 0;
            ProbChart.ChartAreas[0].AxisY.Maximum = 1;
            ProbChart.ChartAreas[0].AxisX.Title = "t";
            ProbChart.ChartAreas[0].AxisY.Title = "m";

            for (int j = 0; j < parts.Count(); j++)
            {
                Series Zena = new Series("Вероятность поломки " + parts[j].partName);
                Zena.ChartType = SeriesChartType.Line;
                Zena.ChartArea = "probab visual";
                ProbChart.Legends.Add(Zena.Legend);
                ProbChart.Legends.Last().Docking = Docking.Bottom;


                for (int i = 0; i < (allTShort.Length / parts.Count()); i++)
                {
                    double x = i * oneSpace;
                    double y = (allTShort[i + 30 * j] / allTShort.Sum());
                    Zena.Points.AddXY(x, y);
                }
                ProbChart.Series.Add(Zena);
                ProbChart.Series.Last().Color = parts[j].partColor;
                ProbChart.Series.Last().MarkerStyle = MarkerStyle.Circle;
                ProbChart.Legends.Last().MaximumAutoSize = 25;
            }
            ProbChart.ChartAreas.Last().Position.Auto = true;
            ProbChart.ChartAreas.Last().Position.Y = 1;
            ProbChart.ChartAreas.Last().Position.X = 1;
            ProbChart.ChartAreas.Last().Position.Height = 75;
            ProbChart.ChartAreas.Last().Position.Width = 90;

            progressBar1.Value = 100;
            progressBar1.Visible = false;

            Vrem.Close();
            DB.Close();
            VremVost.Close();
            Zena.Close();
        }

        private double RealBreakT(double time, double Dtime, double fulltime, double reptime, Random rand, int type)
        {
            double RBT = fulltime + reptime + time + (Dtime * (Randomize(rand, type)));
            RBT = Math.Round(RBT, 2);
            return (RBT);
        }

        private double RealRepT(double repTime, double DrepTime, Random rand, int type)
        {
            double RPT = repTime + (DrepTime * (Randomize(rand, type)));
            RPT = Math.Round(RPT, 2);
            return (RPT);
        }

        private double RealRepP(double repPrice, double DrepPrice, Random rand, int type)
        {
            double RPP = repPrice + (DrepPrice * (Randomize(rand, type)));
            RPP = Math.Round(RPP, 2);
            return (RPP);
        }

        private double Randomize(Random rand, int type)
        {
            double rnd = -1;
            switch (type)
            {
                case 0:
                    double r0 = rand.Next(0, 10000);
                    rnd = (r0 / 10000) - 0.5;
                    break;
                case 1:
                    double r1 = rand.Next(1, 100);
                    rnd = -Math.Log(r1 / 100);
                    break;
                case 2:
                    double r2 = rand.NextDouble();
                    double r3 = rand.NextDouble();
                    double u1 = Math.Sin(2 * Math.PI * (r3));
                    double us = (1.0 / 2) * u1;
                    rnd = Math.Pow((-2 * Math.Log(r2)), (us));
                    break;
            }
            return rnd;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listView2.Clear();

            foreach (Part part in parts)
            {
                var item = listView2.Items.Add(part.partName);
                item.ImageKey = "Cog";
            }

            Twork = Convert.ToDouble(numericUpDown1.Value);
            prog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void Button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(comboBox1.Text);
            string text = comboBox1.Text + null;
            //DB.Write(Encoding.Unicode.GetBytes(text), 0, Encoding.Unicode.GetByteCount(text));
            var rand = new Random();

            int addplus = 0;
            foreach (Part part in parts)
            {
                if (comboBox1.Text == part.partName || comboBox1.Text + "(" + addplus + ")" == part.partName)
                {
                    addplus++;
                }
            }

            if (addplus != 0)
            {
                comboBox1.Text = comboBox1.Text + "(" + addplus + ")";
            }

            parts.Add(new Part()
            {
                partName = comboBox1.Text,
                partID = comboBox1.Items.Count - 1,

                partNnO = Convert.ToDouble(NnO.Value),
                partSKONnO = Convert.ToDouble(SKONnO.Value),
                partVV = Convert.ToDouble(VV.Value),
                partSKOVV = Convert.ToDouble(SKOVV.Value),
                partSR = Convert.ToDouble(SR.Value),
                partSKOSR = Convert.ToDouble(SKOSR.Value),
                partBreakDist = comboBox2.SelectedIndex,
                partRepairDist = comboBox3.SelectedIndex,
                partPriceDist = comboBox4.SelectedIndex,
                partColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255))
            });

            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;

            var item = listView2.Items.Add(parts.Last().partName);
            item.ImageKey = "Cog";
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                Part part = parts.Find(x => x.partID == comboBox1.SelectedIndex);
                NnO.Value = Convert.ToDecimal(part.partNnO);
                SKONnO.Value = Convert.ToDecimal(part.partSKONnO);
                VV.Value = Convert.ToDecimal(part.partVV);
                SKOVV.Value = Convert.ToDecimal(part.partSKOVV);
                SR.Value = Convert.ToDecimal(part.partSR);
                SKOSR.Value = Convert.ToDecimal(part.partSKOSR);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
        }

        private void Form1_FormClosing(Object sender, FormClosedEventArgs e)
        {
            //DB.Close();
            parts.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                var item = listView2.SelectedItems[0];
                var indx = item.Index;

                parts.RemoveAt(item.Index);
                comboBox1.Items.RemoveAt(item.Index);
                listView2.Items.RemoveAt(item.Index);

                listView2.Items.Clear();
                foreach (Part part_num in parts)
                {
                    var itemm = listView2.Items.Add(part_num.partName);
                    itemm.ImageKey = "Cog";
                    if (part_num.partID > indx)
                    {
                        part_num.partID -= 1;
                    }
                }

                if (listView2.Items.Count == 0)
                {
                    listView2.Items.Clear();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ListView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                var item = listView2.SelectedItems[0];

                Part part = parts.Find(x => x.partName == item.Text);
                List<Part> onePart = new List<Part>();
                onePart.Add(part);
                details.DataSource = onePart;
                details.Columns[0].ReadOnly = true;
                details.Columns[0].HeaderText = "Название детали";
                details.Columns[2].HeaderText = "Наработка на отказ";
                details.Columns[3].HeaderText = "СКОНнО";
                details.Columns[4].HeaderText = "Время восстановления";
                details.Columns[5].HeaderText = "СКОВВ";
                details.Columns[6].HeaderText = "Стоимость восстановления";
                details.Columns[7].HeaderText = "СКОСВ";
                details.Columns[1].Visible = false;
                details.Columns[11].Visible = false;
                details.Columns[8].ReadOnly = true;
                details.Columns[9].ReadOnly = true;
                details.Columns[10].ReadOnly = true;
                foreach (DataGridViewColumn column in details.Columns)
                {
                    if (details.Width > 0)
                    {
                        column.Width = Convert.ToInt32(details.Width / details.Columns.Count - 1);
                    }
                }

            }
        }

        private void Details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void price_Click(object sender, EventArgs e)
        {

        }
    }

    public class Part : IEquatable<Part>
    {

        public string partName { get; set; }
        public int partID { get; set; }
        public double partNnO { get; set; }
        public double partSKONnO { get; set; }
        public double partVV { get; set; }
        public double partSKOVV { get; set; }
        public double partSR { get; set; }
        public double partSKOSR { get; set; }
        public int partBreakDist { get; set; }
        public int partRepairDist { get; set; }
        public int partPriceDist { get; set; }
        public Color partColor { get; set; }

        public override string ToString()
        {
            return partName;
        }
        public bool Equals(Part other)
        {
            if (other == null) return false;
            return (this.partID.Equals(other.partID));
        }
    }

    public class BrokenTime : IEquatable<BrokenTime>, IComparable<BrokenTime>
    {
        public int timeID { get; set; }
        public Part part { get; set; }
        public double time { get; set; }
        public double repairTime { get; set; }
        public double repairCost { get; set; }
        public int iterNum { get; set; }

        public override string ToString()
        {
            return "\n   Отказала деталь: " + part.partName +
                "   Номер " + part.partID +
                "   Время отказа " + time + "ч." +
                "   Время восстановления: " + repairTime + "ч." +
                "   Стоимость восстановления: " + repairCost + "руб." +
                "   На машине: " + iterNum;
        }
        public bool Equals(BrokenTime other)
        {
            if (other == null) return false;
            return (this.timeID.Equals(other.timeID));
        }
        public int CompareTo(BrokenTime compareTime)
        {
            if (compareTime == null)
                return 1;
            else
                return this.time.CompareTo(compareTime.time);
        }
    }
}

//если удалться

//this.listView1.HideSelection = false;
//this.listView1.Location = new System.Drawing.Point(892, 212);
//this.listView1.Name = "listView1";
//this.listView1.Size = new System.Drawing.Size(328, 292);
//this.listView1.TabIndex = 49;
//this.listView1.UseCompatibleStateImageBehavior = false;

//listView1.MouseMove += new System.Windows.Forms.MouseEventHandler(listView1_MouseMove);//mousemove handler
//this.listView1.ShowItemToolTips = true;
//toolTip1.SetToolTip(listView1, "");// init the tooltip