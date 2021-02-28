using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageScuzzer2 {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {

            //**

            ColorShiftingActive.Checked = Form1.Options.ColorShiftingActive;

            ColorShiftOverflowCap.Checked = Form1.Options.ColorShiftOverflowCap;
            ColorShiftOverflowMod.Checked = !Form1.Options.ColorShiftOverflowCap;

            ColorShiftUnderflowCap.Checked = Form1.Options.ColorShiftUnderflowCap;
            ColorShiftUnderflowLoop.Checked = Form1.Options.ColorShiftUnderflowLoop;
            ColorShiftUnderflowAbs.Checked = Form1.Options.ColorShiftUnderflowAbs;

            RChannelCheckbox.Checked = Form1.Options.RChannelActive;
            GChannelCheckbox.Checked = Form1.Options.GChannelActive;
            BChannelCheckbox.Checked = Form1.Options.BChannelActive;
            AlphaChannelCheckbox.Checked = Form1.Options.AChannelActive;
            MagnitudeValue.Value = Convert.ToDecimal(Form1.Options.Magnitude);

            //**

            PixelOffsetActive.Checked = Form1.Options.PixelOffsetActive;
            PixelOffsetChance.Value = Convert.ToDecimal(Form1.Options.PixelOffsetChance);
            VerticalPixelOffsetButton.Checked = !Form1.Options.OffsetHorizontal;
            HorizontalPixelOffsetButton.Checked = Form1.Options.OffsetHorizontal;
            PixelOffsetMagnitude.Value = Convert.ToDecimal(Form1.Options.PixelOffsetMagnitude);

            //**

            WeightOffsetActive.Checked = Form1.Options.WeightOffsetActive;
            WeightOffsetPositive.Checked = Form1.Options.WeightOffsetPositive;
            WeightOffsetNegative.Checked = !Form1.Options.WeightOffsetPositive;
            WeightOffsetMagnitude.Value = Convert.ToDecimal(Form1.Options.WeightOffsetMagnitude);

            //**

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e) {
            Console.WriteLine("Closing");
            Form1.OptionsMenuOpen = false;
        }

        //**

        private void ColorShiftingActive_CheckedChanged(object sender, EventArgs e) {
            Form1.Options.ColorShiftingActive = ColorShiftingActive.Checked;
        }

        //

        private void ColorShiftOverflowCap_CheckedChanged(object sender, EventArgs e) {
            Form1.Options.ColorShiftOverflowCap = ColorShiftOverflowCap.Checked;
        }

        //

        private void ColorShiftUnderflowRadioCheck() {
            Form1.Options.ColorShiftUnderflowCap = ColorShiftUnderflowCap.Checked;
            Form1.Options.ColorShiftUnderflowLoop = ColorShiftUnderflowLoop.Checked;
            Form1.Options.ColorShiftUnderflowAbs = ColorShiftUnderflowAbs.Checked;
            Console.WriteLine($"{Form1.Options.ColorShiftUnderflowCap}, {Form1.Options.ColorShiftUnderflowLoop}, {Form1.Options.ColorShiftUnderflowAbs}\n");
        }

        private void ColorShiftUnderflowCap_CheckedChanged(object sender, EventArgs e) {
            ColorShiftUnderflowRadioCheck();
        }

        private void ColorShiftUnderflowLoop_CheckedChanged(object sender, EventArgs e) {
            ColorShiftUnderflowRadioCheck();
        }

        private void ColorShiftUnderflowAbs_CheckedChanged(object sender, EventArgs e) {
            ColorShiftUnderflowRadioCheck();
        }

        //

        private void RChannelCheckbox_CheckedChanged(object sender, EventArgs e) {
            Form1.Options.RChannelActive = RChannelCheckbox.Checked;
        }

        private void GChannelCheckbox_CheckedChanged(object sender, EventArgs e) {
            Form1.Options.GChannelActive = GChannelCheckbox.Checked;
        }

        private void BChannelCheckbox_CheckedChanged(object sender, EventArgs e) {
            Form1.Options.BChannelActive = BChannelCheckbox.Checked;
        }

        private void AlphaChannelCheckbox_CheckedChanged(object sender, EventArgs e) {
            Form1.Options.AChannelActive = AlphaChannelCheckbox.Checked;
        }

        private void MagnitudeValue_ValueChanged(object sender, EventArgs e) {
            Form1.Options.Magnitude = Convert.ToDouble(MagnitudeValue.Value);
        }

        //**

        private void PixelOffsetActive_CheckedChanged(object sender, EventArgs e) {
            Form1.Options.PixelOffsetActive = PixelOffsetActive.Checked;
        }

        private void PixelOffsetChance_ValueChanged(object sender, EventArgs e) {
            Form1.Options.PixelOffsetChance = Convert.ToDouble(PixelOffsetChance.Value);
        }

        private void VerticalPixelOffsetButton_CheckedChanged(object sender, EventArgs e) {
            Form1.Options.OffsetHorizontal = !VerticalPixelOffsetButton.Checked;
        }

        private void PixelOffsetMagnitude_ValueChanged(object sender, EventArgs e) {
            Form1.Options.PixelOffsetMagnitude = Convert.ToDouble(PixelOffsetMagnitude.Value);
        }

        //**

        private void WeightOffsetActive_CheckedChanged(object sender, EventArgs e) {
            Form1.Options.WeightOffsetActive = WeightOffsetActive.Checked;
        }

        private void WeightOffsetPositive_CheckedChanged(object sender, EventArgs e) {
            Console.WriteLine(WeightOffsetPositive.Checked);
            Form1.Options.WeightOffsetPositive = WeightOffsetPositive.Checked;
        }

        private void WeightOffsetMagnitude_ValueChanged(object sender, EventArgs e) {
            Form1.Options.WeightOffsetMagnitude = Convert.ToDouble(WeightOffsetMagnitude.Value);
        }

        //**

    }
}
