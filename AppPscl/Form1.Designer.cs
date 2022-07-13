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
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.NnO = new System.Windows.Forms.NumericUpDown();
            this.SKONnO = new System.Windows.Forms.NumericUpDown();
            this.VV = new System.Windows.Forms.NumericUpDown();
            this.SKOVV = new System.Windows.Forms.NumericUpDown();
            this.SR = new System.Windows.Forms.NumericUpDown();
            this.SKOSR = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SpisokChastey = new System.Windows.Forms.Label();
            this.DobavitChast = new System.Windows.Forms.Label();
            this.VremyaPolomok = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PriceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timeBreakChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listView2 = new System.Windows.Forms.ListView();
            this.details = new System.Windows.Forms.DataGridView();
            this.iterarionsAmmount = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.repairTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.priceC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NnO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SKONnO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SKOVV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SKOSR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBreakChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterarionsAmmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceC)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сгенерировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(951, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вероятность отказа детали";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(577, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Частота отказа деталей";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(166, 484);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 484);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Интервал работы, ч";
            // 
            // NnO
            // 
            this.NnO.Location = new System.Drawing.Point(28, 127);
            this.NnO.Margin = new System.Windows.Forms.Padding(2);
            this.NnO.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NnO.Name = "NnO";
            this.NnO.Size = new System.Drawing.Size(90, 20);
            this.NnO.TabIndex = 5;
            this.NnO.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // SKONnO
            // 
            this.SKONnO.Location = new System.Drawing.Point(200, 127);
            this.SKONnO.Margin = new System.Windows.Forms.Padding(2);
            this.SKONnO.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SKONnO.Name = "SKONnO";
            this.SKONnO.Size = new System.Drawing.Size(90, 20);
            this.SKONnO.TabIndex = 8;
            this.SKONnO.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // VV
            // 
            this.VV.DecimalPlaces = 2;
            this.VV.Location = new System.Drawing.Point(28, 202);
            this.VV.Margin = new System.Windows.Forms.Padding(2);
            this.VV.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.VV.Name = "VV";
            this.VV.Size = new System.Drawing.Size(90, 20);
            this.VV.TabIndex = 13;
            this.VV.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // SKOVV
            // 
            this.SKOVV.DecimalPlaces = 2;
            this.SKOVV.Location = new System.Drawing.Point(200, 202);
            this.SKOVV.Margin = new System.Windows.Forms.Padding(2);
            this.SKOVV.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SKOVV.Name = "SKOVV";
            this.SKOVV.Size = new System.Drawing.Size(90, 20);
            this.SKOVV.TabIndex = 16;
            this.SKOVV.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // SR
            // 
            this.SR.Location = new System.Drawing.Point(28, 290);
            this.SR.Margin = new System.Windows.Forms.Padding(2);
            this.SR.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SR.Name = "SR";
            this.SR.Size = new System.Drawing.Size(90, 20);
            this.SR.TabIndex = 19;
            this.SR.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // SKOSR
            // 
            this.SKOSR.Location = new System.Drawing.Point(200, 290);
            this.SKOSR.Margin = new System.Windows.Forms.Padding(2);
            this.SKOSR.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SKOSR.Name = "SKOSR";
            this.SKOSR.Size = new System.Drawing.Size(90, 20);
            this.SKOSR.TabIndex = 22;
            this.SKOSR.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Наработка на отказ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "СКО наработки на отказ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 170);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Время восстановления, ч";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 170);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "СКО времени восстановления";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 258);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Стоимость ремонта, руб";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 258);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "СКО стоимости ремонта, руб";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(-469, -93);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 30;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.Location = new System.Drawing.Point(137, 58);
            this.comboBox1.MaxLength = 10;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 21);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(80, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 21);
            this.button3.TabIndex = 34;
            this.button3.Text = "Добавить деталь";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(0, 704);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 35);
            this.button2.TabIndex = 35;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(359, 95);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Закон распределения";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Равномерный",
            "Экспоненциальный",
            "Нормальное"});
            this.comboBox2.Location = new System.Drawing.Point(362, 127);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(101, 21);
            this.comboBox2.TabIndex = 37;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1369, 111);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 48);
            this.button4.TabIndex = 38;
            this.button4.Text = "Удалить выбранную часть";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SpisokChastey
            // 
            this.SpisokChastey.AutoSize = true;
            this.SpisokChastey.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpisokChastey.Location = new System.Drawing.Point(1532, 43);
            this.SpisokChastey.Name = "SpisokChastey";
            this.SpisokChastey.Size = new System.Drawing.Size(241, 32);
            this.SpisokChastey.TabIndex = 42;
            this.SpisokChastey.Text = "Список деталей";
            // 
            // DobavitChast
            // 
            this.DobavitChast.AutoSize = true;
            this.DobavitChast.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DobavitChast.Location = new System.Drawing.Point(35, 9);
            this.DobavitChast.Name = "DobavitChast";
            this.DobavitChast.Size = new System.Drawing.Size(238, 32);
            this.DobavitChast.TabIndex = 43;
            this.DobavitChast.Text = "Добавить часть";
            // 
            // VremyaPolomok
            // 
            this.VremyaPolomok.AutoSize = true;
            this.VremyaPolomok.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.29F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VremyaPolomok.Location = new System.Drawing.Point(1532, 356);
            this.VremyaPolomok.Name = "VremyaPolomok";
            this.VremyaPolomok.Size = new System.Drawing.Size(246, 32);
            this.VremyaPolomok.TabIndex = 44;
            this.VremyaPolomok.Text = "Список поломок";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 62);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Название детали";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1465, 400);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(372, 339);
            this.dataGridView1.TabIndex = 46;
            // 
            // PriceChart
            // 
            chartArea5.Name = "ChartArea1";
            this.PriceChart.ChartAreas.Add(chartArea5);
            this.PriceChart.Location = new System.Drawing.Point(967, 58);
            this.PriceChart.Name = "PriceChart";
            this.PriceChart.Size = new System.Drawing.Size(377, 288);
            this.PriceChart.TabIndex = 47;
            this.PriceChart.Text = "chart1";
            // 
            // timeBreakChart
            // 
            chartArea6.Name = "ChartArea1";
            this.timeBreakChart.ChartAreas.Add(chartArea6);
            this.timeBreakChart.Location = new System.Drawing.Point(537, 58);
            this.timeBreakChart.Name = "timeBreakChart";
            this.timeBreakChart.Size = new System.Drawing.Size(398, 288);
            this.timeBreakChart.TabIndex = 48;
            this.timeBreakChart.Text = "chart2";
            // 
            // listView2
            // 
            this.listView2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView2.BackgroundImage")));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(1463, 95);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.ShowItemToolTips = true;
            this.listView2.Size = new System.Drawing.Size(374, 181);
            this.listView2.TabIndex = 0;
            this.listView2.TileSize = new System.Drawing.Size(100, 100);
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.ListView2_SelectedIndexChanged);
            // 
            // details
            // 
            this.details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.details.Location = new System.Drawing.Point(1463, 283);
            this.details.Name = "details";
            this.details.RowHeadersWidth = 4;
            this.details.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.details.Size = new System.Drawing.Size(374, 70);
            this.details.TabIndex = 49;
            this.details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Details_CellContentClick);
            // 
            // iterarionsAmmount
            // 
            this.iterarionsAmmount.Location = new System.Drawing.Point(166, 517);
            this.iterarionsAmmount.Margin = new System.Windows.Forms.Padding(2);
            this.iterarionsAmmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.iterarionsAmmount.Name = "iterarionsAmmount";
            this.iterarionsAmmount.Size = new System.Drawing.Size(90, 20);
            this.iterarionsAmmount.TabIndex = 50;
            this.iterarionsAmmount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(58, 613);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(168, 20);
            this.progressBar1.TabIndex = 51;
            this.progressBar1.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 519);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "Количество машин";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Равномерный",
            "Экспоненциальный",
            "Нормальное"});
            this.comboBox3.Location = new System.Drawing.Point(362, 201);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(101, 21);
            this.comboBox3.TabIndex = 54;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(359, 169);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "Закон распределения";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Равномерный",
            "Экспоненциальный",
            "Нормальное"});
            this.comboBox4.Location = new System.Drawing.Point(362, 289);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(101, 21);
            this.comboBox4.TabIndex = 56;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(359, 257);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "Закон распределения";
            // 
            // repairTime
            // 
            chartArea7.Name = "ChartArea1";
            this.repairTime.ChartAreas.Add(chartArea7);
            this.repairTime.Location = new System.Drawing.Point(537, 410);
            this.repairTime.Name = "repairTime";
            this.repairTime.Size = new System.Drawing.Size(398, 288);
            this.repairTime.TabIndex = 58;
            this.repairTime.Text = "chart2";
            // 
            // priceC
            // 
            chartArea8.Name = "ChartArea1";
            this.priceC.ChartAreas.Add(chartArea8);
            this.priceC.Location = new System.Drawing.Point(967, 410);
            this.priceC.Name = "priceC";
            this.priceC.Size = new System.Drawing.Size(377, 288);
            this.priceC.TabIndex = 57;
            this.priceC.Text = "chart1";
            this.priceC.Click += new System.EventHandler(this.price_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(511, 366);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 31);
            this.label15.TabIndex = 59;
            this.label15.Text = "  ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(961, 366);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(376, 31);
            this.label16.TabIndex = 60;
            this.label16.Text = "Стоимость починки машин";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(511, 366);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(444, 31);
            this.label17.TabIndex = 61;
            this.label17.Text = "Время восстановления деталей";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1839, 738);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.repairTime);
            this.Controls.Add(this.priceC);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.iterarionsAmmount);
            this.Controls.Add(this.details);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.timeBreakChart);
            this.Controls.Add(this.PriceChart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.VremyaPolomok);
            this.Controls.Add(this.DobavitChast);
            this.Controls.Add(this.SpisokChastey);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SKOSR);
            this.Controls.Add(this.SR);
            this.Controls.Add(this.SKOVV);
            this.Controls.Add(this.VV);
            this.Controls.Add(this.SKONnO);
            this.Controls.Add(this.NnO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NnO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SKONnO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SKOVV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SKOSR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeBreakChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterarionsAmmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repairTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NnO;
        private System.Windows.Forms.NumericUpDown SKONnO;
        private System.Windows.Forms.NumericUpDown VV;
        private System.Windows.Forms.NumericUpDown SKOVV;
        private System.Windows.Forms.NumericUpDown SR;
        private System.Windows.Forms.NumericUpDown SKOSR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label SpisokChastey;
        private System.Windows.Forms.Label DobavitChast;
        private System.Windows.Forms.Label VremyaPolomok;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart PriceChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart timeBreakChart;
        private ListView listView2;
        private DataGridView details;
        private NumericUpDown iterarionsAmmount;
        private ProgressBar progressBar1;
        private Label label12;
        private ComboBox comboBox3;
        private Label label13;
        private ComboBox comboBox4;
        private Label label14;
        private Chart repairTime;
        private Chart priceC;
        private Label label15;
        private Label label16;
        private Label label17;
    }
}

