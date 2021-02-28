namespace ImageScuzzer2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ActiveColorChannelsLabel = new System.Windows.Forms.Label();
            this.RChannelCheckbox = new System.Windows.Forms.CheckBox();
            this.GChannelCheckbox = new System.Windows.Forms.CheckBox();
            this.BChannelCheckbox = new System.Windows.Forms.CheckBox();
            this.MagnitudeLabel = new System.Windows.Forms.Label();
            this.MagnitudeValue = new System.Windows.Forms.NumericUpDown();
            this.OffsetChanceLabel = new System.Windows.Forms.Label();
            this.PixelOffsetChance = new System.Windows.Forms.NumericUpDown();
            this.AlphaChannelCheckbox = new System.Windows.Forms.CheckBox();
            this.PixelOffsetDirLabel = new System.Windows.Forms.Label();
            this.VerticalPixelOffsetButton = new System.Windows.Forms.RadioButton();
            this.HorizontalPixelOffsetButton = new System.Windows.Forms.RadioButton();
            this.PixelOffsetMagnitudeLabel = new System.Windows.Forms.Label();
            this.PixelOffsetMagnitude = new System.Windows.Forms.NumericUpDown();
            this.Divider1 = new System.Windows.Forms.Label();
            this.Divider0 = new System.Windows.Forms.Label();
            this.Divider2 = new System.Windows.Forms.Label();
            this.WeightOffsetActiveLabel = new System.Windows.Forms.Label();
            this.WeightOffsetActive = new System.Windows.Forms.CheckBox();
            this.WeightOffsetDirectionLabel = new System.Windows.Forms.Label();
            this.WeightOffsetPositive = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WeightOffsetNegative = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.WeightOffsetMagnitude = new System.Windows.Forms.NumericUpDown();
            this.WeightOffsetMagLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorShiftingActive = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ColorShiftOverflowCap = new System.Windows.Forms.RadioButton();
            this.ColorShiftOverflowMod = new System.Windows.Forms.RadioButton();
            this.PixelOffsetActive = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ColorShiftUnderflowAbs = new System.Windows.Forms.RadioButton();
            this.ColorShiftUnderflowLoop = new System.Windows.Forms.RadioButton();
            this.ColorShiftUnderflowCap = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.MagnitudeValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelOffsetChance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelOffsetMagnitude)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeightOffsetMagnitude)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActiveColorChannelsLabel
            // 
            this.ActiveColorChannelsLabel.AutoSize = true;
            this.ActiveColorChannelsLabel.Location = new System.Drawing.Point(12, 45);
            this.ActiveColorChannelsLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ActiveColorChannelsLabel.Name = "ActiveColorChannelsLabel";
            this.ActiveColorChannelsLabel.Size = new System.Drawing.Size(114, 13);
            this.ActiveColorChannelsLabel.TabIndex = 0;
            this.ActiveColorChannelsLabel.Text = "Active Color Channels:";
            // 
            // RChannelCheckbox
            // 
            this.RChannelCheckbox.Location = new System.Drawing.Point(134, 43);
            this.RChannelCheckbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.RChannelCheckbox.Name = "RChannelCheckbox";
            this.RChannelCheckbox.Size = new System.Drawing.Size(34, 17);
            this.RChannelCheckbox.TabIndex = 0;
            this.RChannelCheckbox.Text = "R";
            this.RChannelCheckbox.UseVisualStyleBackColor = true;
            this.RChannelCheckbox.CheckedChanged += new System.EventHandler(this.RChannelCheckbox_CheckedChanged);
            // 
            // GChannelCheckbox
            // 
            this.GChannelCheckbox.AutoSize = true;
            this.GChannelCheckbox.Location = new System.Drawing.Point(176, 43);
            this.GChannelCheckbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.GChannelCheckbox.Name = "GChannelCheckbox";
            this.GChannelCheckbox.Size = new System.Drawing.Size(34, 17);
            this.GChannelCheckbox.TabIndex = 1;
            this.GChannelCheckbox.Text = "G";
            this.GChannelCheckbox.UseVisualStyleBackColor = true;
            this.GChannelCheckbox.CheckedChanged += new System.EventHandler(this.GChannelCheckbox_CheckedChanged);
            // 
            // BChannelCheckbox
            // 
            this.BChannelCheckbox.AutoSize = true;
            this.BChannelCheckbox.Location = new System.Drawing.Point(218, 43);
            this.BChannelCheckbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BChannelCheckbox.Name = "BChannelCheckbox";
            this.BChannelCheckbox.Size = new System.Drawing.Size(33, 17);
            this.BChannelCheckbox.TabIndex = 2;
            this.BChannelCheckbox.Text = "B";
            this.BChannelCheckbox.UseVisualStyleBackColor = true;
            this.BChannelCheckbox.CheckedChanged += new System.EventHandler(this.BChannelCheckbox_CheckedChanged);
            // 
            // MagnitudeLabel
            // 
            this.MagnitudeLabel.AutoSize = true;
            this.MagnitudeLabel.Location = new System.Drawing.Point(12, 68);
            this.MagnitudeLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MagnitudeLabel.Name = "MagnitudeLabel";
            this.MagnitudeLabel.Size = new System.Drawing.Size(134, 13);
            this.MagnitudeLabel.TabIndex = 0;
            this.MagnitudeLabel.Text = "Color Alteration Magnitude:";
            // 
            // MagnitudeValue
            // 
            this.MagnitudeValue.DecimalPlaces = 8;
            this.MagnitudeValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.MagnitudeValue.Location = new System.Drawing.Point(176, 66);
            this.MagnitudeValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MagnitudeValue.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MagnitudeValue.Name = "MagnitudeValue";
            this.MagnitudeValue.Size = new System.Drawing.Size(113, 20);
            this.MagnitudeValue.TabIndex = 3;
            this.MagnitudeValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MagnitudeValue.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.MagnitudeValue.ValueChanged += new System.EventHandler(this.MagnitudeValue_ValueChanged);
            // 
            // OffsetChanceLabel
            // 
            this.OffsetChanceLabel.AutoSize = true;
            this.OffsetChanceLabel.Location = new System.Drawing.Point(9, 170);
            this.OffsetChanceLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.OffsetChanceLabel.Name = "OffsetChanceLabel";
            this.OffsetChanceLabel.Size = new System.Drawing.Size(103, 13);
            this.OffsetChanceLabel.TabIndex = 4;
            this.OffsetChanceLabel.Text = "Pixel Offset Chance:";
            // 
            // PixelOffsetChance
            // 
            this.PixelOffsetChance.DecimalPlaces = 2;
            this.PixelOffsetChance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PixelOffsetChance.Location = new System.Drawing.Point(176, 168);
            this.PixelOffsetChance.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PixelOffsetChance.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PixelOffsetChance.Name = "PixelOffsetChance";
            this.PixelOffsetChance.Size = new System.Drawing.Size(113, 20);
            this.PixelOffsetChance.TabIndex = 5;
            this.PixelOffsetChance.Tag = "";
            this.PixelOffsetChance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PixelOffsetChance.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PixelOffsetChance.ValueChanged += new System.EventHandler(this.PixelOffsetChance_ValueChanged);
            // 
            // AlphaChannelCheckbox
            // 
            this.AlphaChannelCheckbox.AutoSize = true;
            this.AlphaChannelCheckbox.Location = new System.Drawing.Point(259, 43);
            this.AlphaChannelCheckbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AlphaChannelCheckbox.Name = "AlphaChannelCheckbox";
            this.AlphaChannelCheckbox.Size = new System.Drawing.Size(33, 17);
            this.AlphaChannelCheckbox.TabIndex = 6;
            this.AlphaChannelCheckbox.Text = "A";
            this.AlphaChannelCheckbox.UseVisualStyleBackColor = true;
            this.AlphaChannelCheckbox.CheckedChanged += new System.EventHandler(this.AlphaChannelCheckbox_CheckedChanged);
            // 
            // PixelOffsetDirLabel
            // 
            this.PixelOffsetDirLabel.AutoSize = true;
            this.PixelOffsetDirLabel.Location = new System.Drawing.Point(9, 193);
            this.PixelOffsetDirLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PixelOffsetDirLabel.Name = "PixelOffsetDirLabel";
            this.PixelOffsetDirLabel.Size = new System.Drawing.Size(83, 13);
            this.PixelOffsetDirLabel.TabIndex = 7;
            this.PixelOffsetDirLabel.Text = "Offset Direction:";
            // 
            // VerticalPixelOffsetButton
            // 
            this.VerticalPixelOffsetButton.AutoSize = true;
            this.VerticalPixelOffsetButton.Location = new System.Drawing.Point(0, 0);
            this.VerticalPixelOffsetButton.Name = "VerticalPixelOffsetButton";
            this.VerticalPixelOffsetButton.Size = new System.Drawing.Size(60, 17);
            this.VerticalPixelOffsetButton.TabIndex = 8;
            this.VerticalPixelOffsetButton.TabStop = true;
            this.VerticalPixelOffsetButton.Text = "Vertical";
            this.VerticalPixelOffsetButton.UseVisualStyleBackColor = true;
            this.VerticalPixelOffsetButton.CheckedChanged += new System.EventHandler(this.VerticalPixelOffsetButton_CheckedChanged);
            // 
            // HorizontalPixelOffsetButton
            // 
            this.HorizontalPixelOffsetButton.AutoSize = true;
            this.HorizontalPixelOffsetButton.Location = new System.Drawing.Point(66, 0);
            this.HorizontalPixelOffsetButton.Name = "HorizontalPixelOffsetButton";
            this.HorizontalPixelOffsetButton.Size = new System.Drawing.Size(72, 17);
            this.HorizontalPixelOffsetButton.TabIndex = 9;
            this.HorizontalPixelOffsetButton.TabStop = true;
            this.HorizontalPixelOffsetButton.Text = "Horizontal";
            this.HorizontalPixelOffsetButton.UseVisualStyleBackColor = true;
            // 
            // PixelOffsetMagnitudeLabel
            // 
            this.PixelOffsetMagnitudeLabel.AutoSize = true;
            this.PixelOffsetMagnitudeLabel.Location = new System.Drawing.Point(9, 216);
            this.PixelOffsetMagnitudeLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PixelOffsetMagnitudeLabel.Name = "PixelOffsetMagnitudeLabel";
            this.PixelOffsetMagnitudeLabel.Size = new System.Drawing.Size(91, 13);
            this.PixelOffsetMagnitudeLabel.TabIndex = 10;
            this.PixelOffsetMagnitudeLabel.Text = "Offset Magnitude:";
            // 
            // PixelOffsetMagnitude
            // 
            this.PixelOffsetMagnitude.DecimalPlaces = 2;
            this.PixelOffsetMagnitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PixelOffsetMagnitude.Location = new System.Drawing.Point(176, 214);
            this.PixelOffsetMagnitude.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PixelOffsetMagnitude.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PixelOffsetMagnitude.Name = "PixelOffsetMagnitude";
            this.PixelOffsetMagnitude.Size = new System.Drawing.Size(113, 20);
            this.PixelOffsetMagnitude.TabIndex = 11;
            this.PixelOffsetMagnitude.Tag = "";
            this.PixelOffsetMagnitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PixelOffsetMagnitude.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.PixelOffsetMagnitude.ValueChanged += new System.EventHandler(this.PixelOffsetMagnitude_ValueChanged);
            // 
            // Divider1
            // 
            this.Divider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Divider1.Location = new System.Drawing.Point(12, 137);
            this.Divider1.Margin = new System.Windows.Forms.Padding(3);
            this.Divider1.Name = "Divider1";
            this.Divider1.Size = new System.Drawing.Size(280, 2);
            this.Divider1.TabIndex = 12;
            // 
            // Divider0
            // 
            this.Divider0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Divider0.Location = new System.Drawing.Point(12, 12);
            this.Divider0.Margin = new System.Windows.Forms.Padding(3);
            this.Divider0.Name = "Divider0";
            this.Divider0.Size = new System.Drawing.Size(280, 2);
            this.Divider0.TabIndex = 13;
            // 
            // Divider2
            // 
            this.Divider2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Divider2.Location = new System.Drawing.Point(9, 242);
            this.Divider2.Margin = new System.Windows.Forms.Padding(3);
            this.Divider2.Name = "Divider2";
            this.Divider2.Size = new System.Drawing.Size(280, 2);
            this.Divider2.TabIndex = 14;
            // 
            // WeightOffsetActiveLabel
            // 
            this.WeightOffsetActiveLabel.AutoSize = true;
            this.WeightOffsetActiveLabel.Location = new System.Drawing.Point(78, 252);
            this.WeightOffsetActiveLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.WeightOffsetActiveLabel.Name = "WeightOffsetActiveLabel";
            this.WeightOffsetActiveLabel.Size = new System.Drawing.Size(122, 13);
            this.WeightOffsetActiveLabel.TabIndex = 15;
            this.WeightOffsetActiveLabel.Text = "Enable Offset Weighing:";
            // 
            // WeightOffsetActive
            // 
            this.WeightOffsetActive.AutoSize = true;
            this.WeightOffsetActive.Location = new System.Drawing.Point(206, 251);
            this.WeightOffsetActive.Name = "WeightOffsetActive";
            this.WeightOffsetActive.Size = new System.Drawing.Size(15, 14);
            this.WeightOffsetActive.TabIndex = 16;
            this.WeightOffsetActive.UseVisualStyleBackColor = true;
            this.WeightOffsetActive.CheckedChanged += new System.EventHandler(this.WeightOffsetActive_CheckedChanged);
            // 
            // WeightOffsetDirectionLabel
            // 
            this.WeightOffsetDirectionLabel.AutoSize = true;
            this.WeightOffsetDirectionLabel.Location = new System.Drawing.Point(9, 275);
            this.WeightOffsetDirectionLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.WeightOffsetDirectionLabel.Name = "WeightOffsetDirectionLabel";
            this.WeightOffsetDirectionLabel.Size = new System.Drawing.Size(120, 13);
            this.WeightOffsetDirectionLabel.TabIndex = 17;
            this.WeightOffsetDirectionLabel.Text = "Weight Offset Direction:";
            // 
            // WeightOffsetPositive
            // 
            this.WeightOffsetPositive.AutoSize = true;
            this.WeightOffsetPositive.Location = new System.Drawing.Point(0, 0);
            this.WeightOffsetPositive.Name = "WeightOffsetPositive";
            this.WeightOffsetPositive.Size = new System.Drawing.Size(62, 17);
            this.WeightOffsetPositive.TabIndex = 18;
            this.WeightOffsetPositive.TabStop = true;
            this.WeightOffsetPositive.Text = "Positive";
            this.WeightOffsetPositive.UseVisualStyleBackColor = true;
            this.WeightOffsetPositive.CheckedChanged += new System.EventHandler(this.WeightOffsetPositive_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VerticalPixelOffsetButton);
            this.panel1.Controls.Add(this.HorizontalPixelOffsetButton);
            this.panel1.Location = new System.Drawing.Point(151, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 17);
            this.panel1.TabIndex = 19;
            // 
            // WeightOffsetNegative
            // 
            this.WeightOffsetNegative.AutoSize = true;
            this.WeightOffsetNegative.Location = new System.Drawing.Point(68, 0);
            this.WeightOffsetNegative.Name = "WeightOffsetNegative";
            this.WeightOffsetNegative.Size = new System.Drawing.Size(68, 17);
            this.WeightOffsetNegative.TabIndex = 21;
            this.WeightOffsetNegative.TabStop = true;
            this.WeightOffsetNegative.Text = "Negative";
            this.WeightOffsetNegative.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.WeightOffsetNegative);
            this.panel2.Controls.Add(this.WeightOffsetPositive);
            this.panel2.Location = new System.Drawing.Point(151, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 17);
            this.panel2.TabIndex = 20;
            // 
            // WeightOffsetMagnitude
            // 
            this.WeightOffsetMagnitude.DecimalPlaces = 2;
            this.WeightOffsetMagnitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.WeightOffsetMagnitude.Location = new System.Drawing.Point(176, 294);
            this.WeightOffsetMagnitude.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.WeightOffsetMagnitude.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.WeightOffsetMagnitude.Name = "WeightOffsetMagnitude";
            this.WeightOffsetMagnitude.Size = new System.Drawing.Size(113, 20);
            this.WeightOffsetMagnitude.TabIndex = 21;
            this.WeightOffsetMagnitude.Tag = "";
            this.WeightOffsetMagnitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WeightOffsetMagnitude.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.WeightOffsetMagnitude.ValueChanged += new System.EventHandler(this.WeightOffsetMagnitude_ValueChanged);
            // 
            // WeightOffsetMagLabel
            // 
            this.WeightOffsetMagLabel.AutoSize = true;
            this.WeightOffsetMagLabel.Location = new System.Drawing.Point(9, 298);
            this.WeightOffsetMagLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.WeightOffsetMagLabel.Name = "WeightOffsetMagLabel";
            this.WeightOffsetMagLabel.Size = new System.Drawing.Size(128, 13);
            this.WeightOffsetMagLabel.TabIndex = 22;
            this.WeightOffsetMagLabel.Text = "Weight Offset Magnitude:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "On Overflow:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "On Underflow:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Enable Color Shifting:";
            // 
            // ColorShiftingActive
            // 
            this.ColorShiftingActive.AutoSize = true;
            this.ColorShiftingActive.Location = new System.Drawing.Point(202, 21);
            this.ColorShiftingActive.Name = "ColorShiftingActive";
            this.ColorShiftingActive.Size = new System.Drawing.Size(15, 14);
            this.ColorShiftingActive.TabIndex = 31;
            this.ColorShiftingActive.UseVisualStyleBackColor = true;
            this.ColorShiftingActive.CheckedChanged += new System.EventHandler(this.ColorShiftingActive_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ColorShiftOverflowCap);
            this.panel3.Controls.Add(this.ColorShiftOverflowMod);
            this.panel3.Location = new System.Drawing.Point(142, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 17);
            this.panel3.TabIndex = 20;
            // 
            // ColorShiftOverflowCap
            // 
            this.ColorShiftOverflowCap.AutoSize = true;
            this.ColorShiftOverflowCap.Location = new System.Drawing.Point(11, 0);
            this.ColorShiftOverflowCap.Name = "ColorShiftOverflowCap";
            this.ColorShiftOverflowCap.Size = new System.Drawing.Size(44, 17);
            this.ColorShiftOverflowCap.TabIndex = 8;
            this.ColorShiftOverflowCap.TabStop = true;
            this.ColorShiftOverflowCap.Text = "Cap";
            this.ColorShiftOverflowCap.UseVisualStyleBackColor = true;
            this.ColorShiftOverflowCap.CheckedChanged += new System.EventHandler(this.ColorShiftOverflowCap_CheckedChanged);
            // 
            // ColorShiftOverflowMod
            // 
            this.ColorShiftOverflowMod.AutoSize = true;
            this.ColorShiftOverflowMod.Location = new System.Drawing.Point(61, 0);
            this.ColorShiftOverflowMod.Name = "ColorShiftOverflowMod";
            this.ColorShiftOverflowMod.Size = new System.Drawing.Size(89, 17);
            this.ColorShiftOverflowMod.TabIndex = 9;
            this.ColorShiftOverflowMod.TabStop = true;
            this.ColorShiftOverflowMod.Text = "Loop/Modulo";
            this.ColorShiftOverflowMod.UseVisualStyleBackColor = true;
            // 
            // PixelOffsetActive
            // 
            this.PixelOffsetActive.AutoSize = true;
            this.PixelOffsetActive.Location = new System.Drawing.Point(206, 146);
            this.PixelOffsetActive.Name = "PixelOffsetActive";
            this.PixelOffsetActive.Size = new System.Drawing.Size(15, 14);
            this.PixelOffsetActive.TabIndex = 32;
            this.PixelOffsetActive.UseVisualStyleBackColor = true;
            this.PixelOffsetActive.CheckedChanged += new System.EventHandler(this.PixelOffsetActive_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Enable Pixel Offsetting:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ColorShiftUnderflowAbs);
            this.panel4.Controls.Add(this.ColorShiftUnderflowLoop);
            this.panel4.Controls.Add(this.ColorShiftUnderflowCap);
            this.panel4.Location = new System.Drawing.Point(93, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 17);
            this.panel4.TabIndex = 34;
            // 
            // ColorShiftUnderflowAbs
            // 
            this.ColorShiftUnderflowAbs.AutoSize = true;
            this.ColorShiftUnderflowAbs.Location = new System.Drawing.Point(138, 0);
            this.ColorShiftUnderflowAbs.Name = "ColorShiftUnderflowAbs";
            this.ColorShiftUnderflowAbs.Size = new System.Drawing.Size(61, 17);
            this.ColorShiftUnderflowAbs.TabIndex = 2;
            this.ColorShiftUnderflowAbs.TabStop = true;
            this.ColorShiftUnderflowAbs.Text = "Abs Val";
            this.ColorShiftUnderflowAbs.UseVisualStyleBackColor = true;
            this.ColorShiftUnderflowAbs.CheckedChanged += new System.EventHandler(this.ColorShiftUnderflowAbs_CheckedChanged);
            // 
            // ColorShiftUnderflowLoop
            // 
            this.ColorShiftUnderflowLoop.AutoSize = true;
            this.ColorShiftUnderflowLoop.Location = new System.Drawing.Point(83, 0);
            this.ColorShiftUnderflowLoop.Name = "ColorShiftUnderflowLoop";
            this.ColorShiftUnderflowLoop.Size = new System.Drawing.Size(49, 17);
            this.ColorShiftUnderflowLoop.TabIndex = 1;
            this.ColorShiftUnderflowLoop.TabStop = true;
            this.ColorShiftUnderflowLoop.Text = "Loop";
            this.ColorShiftUnderflowLoop.UseVisualStyleBackColor = true;
            this.ColorShiftUnderflowLoop.CheckedChanged += new System.EventHandler(this.ColorShiftUnderflowLoop_CheckedChanged);
            // 
            // ColorShiftUnderflowCap
            // 
            this.ColorShiftUnderflowCap.AutoSize = true;
            this.ColorShiftUnderflowCap.Location = new System.Drawing.Point(33, 0);
            this.ColorShiftUnderflowCap.Name = "ColorShiftUnderflowCap";
            this.ColorShiftUnderflowCap.Size = new System.Drawing.Size(44, 17);
            this.ColorShiftUnderflowCap.TabIndex = 0;
            this.ColorShiftUnderflowCap.TabStop = true;
            this.ColorShiftUnderflowCap.Text = "Cap";
            this.ColorShiftUnderflowCap.UseVisualStyleBackColor = true;
            this.ColorShiftUnderflowCap.CheckedChanged += new System.EventHandler(this.ColorShiftUnderflowCap_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 403);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PixelOffsetActive);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ColorShiftingActive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WeightOffsetMagLabel);
            this.Controls.Add(this.WeightOffsetMagnitude);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WeightOffsetDirectionLabel);
            this.Controls.Add(this.WeightOffsetActive);
            this.Controls.Add(this.WeightOffsetActiveLabel);
            this.Controls.Add(this.Divider2);
            this.Controls.Add(this.Divider0);
            this.Controls.Add(this.Divider1);
            this.Controls.Add(this.PixelOffsetMagnitude);
            this.Controls.Add(this.PixelOffsetMagnitudeLabel);
            this.Controls.Add(this.PixelOffsetDirLabel);
            this.Controls.Add(this.AlphaChannelCheckbox);
            this.Controls.Add(this.PixelOffsetChance);
            this.Controls.Add(this.OffsetChanceLabel);
            this.Controls.Add(this.MagnitudeValue);
            this.Controls.Add(this.MagnitudeLabel);
            this.Controls.Add(this.BChannelCheckbox);
            this.Controls.Add(this.GChannelCheckbox);
            this.Controls.Add(this.RChannelCheckbox);
            this.Controls.Add(this.ActiveColorChannelsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MagnitudeValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelOffsetChance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PixelOffsetMagnitude)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WeightOffsetMagnitude)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ActiveColorChannelsLabel;
        private System.Windows.Forms.CheckBox RChannelCheckbox;
        private System.Windows.Forms.CheckBox GChannelCheckbox;
        private System.Windows.Forms.CheckBox BChannelCheckbox;
        private System.Windows.Forms.Label MagnitudeLabel;
        private System.Windows.Forms.NumericUpDown MagnitudeValue;
        private System.Windows.Forms.Label OffsetChanceLabel;
        private System.Windows.Forms.NumericUpDown PixelOffsetChance;
        private System.Windows.Forms.CheckBox AlphaChannelCheckbox;
        private System.Windows.Forms.Label PixelOffsetDirLabel;
        private System.Windows.Forms.RadioButton VerticalPixelOffsetButton;
        private System.Windows.Forms.RadioButton HorizontalPixelOffsetButton;
        private System.Windows.Forms.Label PixelOffsetMagnitudeLabel;
        private System.Windows.Forms.NumericUpDown PixelOffsetMagnitude;
        private System.Windows.Forms.Label Divider1;
        private System.Windows.Forms.Label Divider0;
        private System.Windows.Forms.Label Divider2;
        private System.Windows.Forms.Label WeightOffsetActiveLabel;
        private System.Windows.Forms.CheckBox WeightOffsetActive;
        private System.Windows.Forms.Label WeightOffsetDirectionLabel;
        private System.Windows.Forms.RadioButton WeightOffsetPositive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton WeightOffsetNegative;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown WeightOffsetMagnitude;
        private System.Windows.Forms.Label WeightOffsetMagLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ColorShiftingActive;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton ColorShiftOverflowCap;
        private System.Windows.Forms.RadioButton ColorShiftOverflowMod;
        private System.Windows.Forms.CheckBox PixelOffsetActive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton ColorShiftUnderflowAbs;
        private System.Windows.Forms.RadioButton ColorShiftUnderflowLoop;
        private System.Windows.Forms.RadioButton ColorShiftUnderflowCap;
    }
}