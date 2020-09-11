﻿namespace WindowsClient.Controls
{
    partial class TraitChart
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rightBtn = new System.Windows.Forms.Button();
            this.leftBtn = new System.Windows.Forms.Button();
            this.traitTypeBox = new System.Windows.Forms.ComboBox();
            this.traitsBox = new System.Windows.Forms.CheckedListBox();
            this.chart = new Steema.TeeChart.TChart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rightBtn
            // 
            this.rightBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightBtn.BackgroundImage = global::WindowsClient.Properties.Resources.right;
            this.rightBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightBtn.Location = new System.Drawing.Point(522, 3);
            this.rightBtn.Margin = new System.Windows.Forms.Padding(0);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(24, 24);
            this.rightBtn.TabIndex = 19;
            this.rightBtn.UseVisualStyleBackColor = true;
            this.rightBtn.Visible = false;
            this.rightBtn.Click += new System.EventHandler(this.RightClicked);
            // 
            // leftBtn
            // 
            this.leftBtn.BackgroundImage = global::WindowsClient.Properties.Resources.left;
            this.leftBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftBtn.Location = new System.Drawing.Point(3, 3);
            this.leftBtn.Margin = new System.Windows.Forms.Padding(0);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(24, 24);
            this.leftBtn.TabIndex = 18;
            this.leftBtn.UseVisualStyleBackColor = true;
            this.leftBtn.Visible = false;
            this.leftBtn.Click += new System.EventHandler(this.LeftClicked);
            // 
            // traitTypeBox
            // 
            this.traitTypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.traitTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.traitTypeBox.FormattingEnabled = true;
            this.traitTypeBox.Location = new System.Drawing.Point(552, 3);
            this.traitTypeBox.Name = "traitTypeBox";
            this.traitTypeBox.Size = new System.Drawing.Size(143, 21);
            this.traitTypeBox.TabIndex = 17;
            // 
            // traitsBox
            // 
            this.traitsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.traitsBox.CheckOnClick = true;
            this.traitsBox.FormattingEnabled = true;
            this.traitsBox.Location = new System.Drawing.Point(552, 30);
            this.traitsBox.Name = "traitsBox";
            this.traitsBox.Size = new System.Drawing.Size(143, 529);
            this.traitsBox.TabIndex = 16;
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.chart.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.chart.Axes.Bottom.Labels.Brush.Solid = true;
            this.chart.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.chart.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chart.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.chart.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.chart.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.chart.Axes.Bottom.Labels.Font.Size = 9;
            this.chart.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.chart.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.chart.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.chart.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.chart.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.chart.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.chart.Axes.Bottom.Title.Brush.Solid = true;
            this.chart.Axes.Bottom.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.chart.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chart.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.chart.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.chart.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.chart.Axes.Bottom.Title.Font.Size = 11;
            this.chart.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.chart.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.chart.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.chart.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.chart.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.chart.Axes.Depth.Labels.Brush.Solid = true;
            this.chart.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.chart.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chart.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.chart.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.chart.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.chart.Axes.Depth.Labels.Font.Size = 9;
            this.chart.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.chart.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.chart.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.chart.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.chart.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.chart.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.chart.Axes.Depth.Title.Brush.Solid = true;
            this.chart.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.chart.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chart.Axes.Depth.Title.Font.Brush.Solid = true;
            this.chart.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.chart.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.chart.Axes.Depth.Title.Font.Size = 11;
            this.chart.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.chart.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.chart.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.chart.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.chart.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.chart.Axes.DepthTop.Labels.Brush.Solid = true;
            this.chart.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.chart.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chart.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.chart.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.chart.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.chart.Axes.DepthTop.Labels.Font.Size = 9;
            this.chart.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.chart.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.chart.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.chart.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.chart.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.chart.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.chart.Axes.DepthTop.Title.Brush.Solid = true;
            this.chart.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.chart.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chart.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.chart.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.chart.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.chart.Axes.DepthTop.Title.Font.Size = 11;
            this.chart.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.chart.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.chart.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.chart.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.chart.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.chart.Axes.Left.Labels.Brush.Solid = true;
            this.chart.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.chart.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chart.Axes.Left.Labels.Font.Brush.Solid = true;
            this.chart.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.chart.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.chart.Axes.Left.Labels.Font.Size = 9;
            this.chart.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.chart.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.chart.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.chart.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.Axes.Left.Ticks.Visible = true;
            // 
            // 
            // 
            this.chart.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.chart.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.chart.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.chart.Axes.Left.Title.Brush.Solid = true;
            this.chart.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.chart.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chart.Axes.Left.Title.Font.Brush.Solid = true;
            this.chart.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.chart.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.chart.Axes.Left.Title.Font.Size = 11;
            this.chart.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.chart.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.chart.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.chart.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Right.AxisPen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.chart.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.chart.Axes.Right.Labels.Brush.Solid = true;
            this.chart.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.chart.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chart.Axes.Right.Labels.Font.Brush.Solid = true;
            this.chart.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.chart.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.chart.Axes.Right.Labels.Font.Size = 9;
            this.chart.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.chart.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.chart.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.chart.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.chart.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.chart.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.chart.Axes.Right.Title.Brush.Solid = true;
            this.chart.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.chart.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chart.Axes.Right.Title.Font.Brush.Solid = true;
            this.chart.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.chart.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.chart.Axes.Right.Title.Font.Size = 11;
            this.chart.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.chart.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.chart.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.chart.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.chart.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.chart.Axes.Top.Labels.Brush.Solid = true;
            this.chart.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.chart.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chart.Axes.Top.Labels.Font.Brush.Solid = true;
            this.chart.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.chart.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.chart.Axes.Top.Labels.Font.Size = 9;
            this.chart.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.chart.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.chart.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.chart.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.chart.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.chart.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.chart.Axes.Top.Title.Brush.Solid = true;
            this.chart.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.chart.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chart.Axes.Top.Title.Font.Brush.Solid = true;
            this.chart.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.chart.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.chart.Axes.Top.Title.Font.Size = 11;
            this.chart.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.chart.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.chart.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.chart.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.chart.Cursor = System.Windows.Forms.Cursors.Arrow;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.chart.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.chart.Footer.Brush.Solid = true;
            this.chart.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.chart.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.chart.Footer.Font.Brush.Solid = true;
            this.chart.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Footer.Font.Shadow.Brush.Solid = true;
            this.chart.Footer.Font.Shadow.Brush.Visible = true;
            this.chart.Footer.Font.Size = 8;
            this.chart.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.chart.Footer.ImageBevel.Brush.Solid = true;
            this.chart.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Footer.Shadow.Brush.Solid = true;
            this.chart.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.chart.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chart.Header.Brush.Solid = true;
            this.chart.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.Header.Font.Bold = false;
            // 
            // 
            // 
            this.chart.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chart.Header.Font.Brush.Solid = true;
            this.chart.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Header.Font.Shadow.Brush.Solid = true;
            this.chart.Header.Font.Shadow.Brush.Visible = true;
            this.chart.Header.Font.Size = 12;
            this.chart.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.chart.Header.ImageBevel.Brush.Solid = true;
            this.chart.Header.ImageBevel.Brush.Visible = true;
            this.chart.Header.Lines = new string[] {
        ""};
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.chart.Header.Shadow.Brush.Solid = true;
            this.chart.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.chart.Legend.Brush.Color = System.Drawing.Color.White;
            this.chart.Legend.Brush.Solid = true;
            this.chart.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.chart.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chart.Legend.Font.Brush.Solid = true;
            this.chart.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Legend.Font.Shadow.Brush.Solid = true;
            this.chart.Legend.Font.Shadow.Brush.Visible = true;
            this.chart.Legend.Font.Size = 9;
            this.chart.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.chart.Legend.ImageBevel.Brush.Solid = true;
            this.chart.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chart.Legend.Shadow.Brush.Solid = true;
            this.chart.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Legend.Symbol.Shadow.Brush.Solid = true;
            this.chart.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.chart.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.chart.Legend.Title.Brush.Solid = true;
            this.chart.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.chart.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.chart.Legend.Title.Font.Brush.Solid = true;
            this.chart.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.chart.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.chart.Legend.Title.Font.Size = 8;
            this.chart.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.chart.Legend.Title.ImageBevel.Brush.Solid = true;
            this.chart.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Legend.Title.Shadow.Brush.Solid = true;
            this.chart.Legend.Title.Shadow.Brush.Visible = true;
            this.chart.Location = new System.Drawing.Point(3, 3);
            this.chart.Name = "chart";
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.chart.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chart.Panel.Brush.Solid = true;
            this.chart.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.chart.Panel.ImageBevel.Brush.Solid = true;
            this.chart.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.Panel.Pen.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Panel.Shadow.Brush.Solid = true;
            this.chart.Panel.Shadow.Brush.Visible = true;
            this.chart.Size = new System.Drawing.Size(543, 558);
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.chart.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.chart.SubFooter.Brush.Solid = true;
            this.chart.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.chart.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.chart.SubFooter.Font.Brush.Solid = true;
            this.chart.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.SubFooter.Font.Shadow.Brush.Solid = true;
            this.chart.SubFooter.Font.Shadow.Brush.Visible = true;
            this.chart.SubFooter.Font.Size = 8;
            this.chart.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.chart.SubFooter.ImageBevel.Brush.Solid = true;
            this.chart.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.SubFooter.Shadow.Brush.Solid = true;
            this.chart.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.chart.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chart.SubHeader.Brush.Solid = true;
            this.chart.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.chart.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.chart.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.chart.SubHeader.Font.Brush.Solid = true;
            this.chart.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.SubHeader.Font.Shadow.Brush.Solid = true;
            this.chart.SubHeader.Font.Shadow.Brush.Visible = true;
            this.chart.SubHeader.Font.Size = 12;
            this.chart.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.chart.SubHeader.ImageBevel.Brush.Solid = true;
            this.chart.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.chart.SubHeader.Shadow.Brush.Solid = true;
            this.chart.SubHeader.Shadow.Brush.Visible = true;
            this.chart.TabIndex = 15;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.chart.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.chart.Walls.Back.Brush.Solid = true;
            this.chart.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.chart.Walls.Back.ImageBevel.Brush.Solid = true;
            this.chart.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Walls.Back.Shadow.Brush.Solid = true;
            this.chart.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.chart.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.chart.Walls.Bottom.Brush.Solid = true;
            this.chart.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.chart.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.chart.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Walls.Bottom.Shadow.Brush.Solid = true;
            this.chart.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.chart.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.chart.Walls.Left.Brush.Solid = true;
            this.chart.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.chart.Walls.Left.ImageBevel.Brush.Solid = true;
            this.chart.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Walls.Left.Shadow.Brush.Solid = true;
            this.chart.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.chart.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.chart.Walls.Right.Brush.Solid = true;
            this.chart.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.chart.Walls.Right.ImageBevel.Brush.Solid = true;
            this.chart.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.chart.Walls.Right.Shadow.Brush.Solid = true;
            this.chart.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.chart.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.chart.Zoom.Brush.Solid = true;
            this.chart.Zoom.Brush.Visible = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rightBtn);
            this.panel1.Controls.Add(this.leftBtn);
            this.panel1.Controls.Add(this.chart);
            this.panel1.Controls.Add(this.traitTypeBox);
            this.panel1.Controls.Add(this.traitsBox);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 567);
            this.panel1.TabIndex = 20;
            // 
            // TraitChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "TraitChart";
            this.Size = new System.Drawing.Size(704, 573);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rightBtn;
        private System.Windows.Forms.Button leftBtn;
        private System.Windows.Forms.ComboBox traitTypeBox;
        private System.Windows.Forms.CheckedListBox traitsBox;
        private Steema.TeeChart.TChart chart;
        private System.Windows.Forms.Panel panel1;
    }
}
