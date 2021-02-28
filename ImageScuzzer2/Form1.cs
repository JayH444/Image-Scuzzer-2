using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageScuzzer2 {
    public partial class Form1 : Form {

        public Image OriginalImageData { get; set; }  // Original image data, unmodified.
        public Bitmap PreviousImageData { get; set; }
        static public bool OptionsMenuOpen = false;

        public class OptionsClass {  // Class for the options menu.

            //**

            public bool ColorShiftingActive = false;

            // Variables for controlling what to do when the color overflows (value > 255):
            public bool ColorShiftOverflowCap = false;

            // Variables for controlling what to do when the color underflows (value < 0):
            public bool ColorShiftUnderflowCap = true;
            public bool ColorShiftUnderflowLoop = false;
            public bool ColorShiftUnderflowAbs = false;

            // Determines whether the given color channel can have its value altered:
            public bool RChannelActive { get; set; }
            public bool GChannelActive { get; set; }
            public bool BChannelActive { get; set; }
            public bool AChannelActive { get; set; }

            // The magnitude of potential color shifting:
            public double Magnitude = 0.25;  // 1 = 255

            //**

            public bool PixelOffsetActive = true;
            // Probability of the current row/col having its pixels shifted by a random offset value:
            public double PixelOffsetChance = 0.25;  // 1 = 100%
            public bool OffsetHorizontal = true;
            // Magnitude of that offset value:
            public double PixelOffsetMagnitude = 0.25;  // 1 = entire width of the image

            //**

            public bool WeightOffsetActive = false;
            public bool WeightOffsetPositive = true;
            public double WeightOffsetMagnitude = 1.0;

            //**

        }

        static public OptionsClass Options = new OptionsClass();

        public Form1() {
            InitializeComponent();
        }

        public void ResizeFormForNewImage(PictureBox thePB) {
            // Exactly what it says on the tin. When an image/new image is loaded,
            // this resizes the form and moves the control panel accordingly.
            int newWidth = thePB.Size.Width;
            int newHeight = thePB.Size.Height;
            Console.WriteLine(thePB.Size.Width);
            if (thePB.Image.Size.Width < 280) {
                newWidth = 280;
            }
            if (thePB.Image.Size.Height < 280) {
                newHeight = 280;
                this.Size = new Size(newWidth + 40, newHeight + 162);
                thePB.Location = new Point(
                    this.ClientSize.Width / 2 - thePB.Size.Width / 2,
                    (288 - thePB.Image.Size.Height) / 2 + 30
                );
            }
            else {
                this.Size = new Size(newWidth + 40, newHeight + 162);
                thePB.Location = new Point(12, 30);
            }

            SelectionPanel.Location = new Point(
                this.ClientSize.Width / 2 - SelectionPanel.Size.Width / 2,
                this.ClientSize.Height - 34 - SelectionPanel.Height
            );
            SelectionPanel.Anchor = AnchorStyles.None;
        }

        public void GlitchImage(Image i) {
            using (Bitmap ImagePixelData = new Bitmap(i)) {

                toolStripProgressBar1.Value = 0;

                int mag = Convert.ToInt32(Options.Magnitude * 255);
                double OffsetMag = Options.PixelOffsetMagnitude;

                // This controls what color channels are altered, if color shifting is active.
                bool[] ActiveChannels = {
                    Options.RChannelActive,
                    Options.GChannelActive,
                    Options.BChannelActive
                };

                Random rng = new Random();

                int offsetChance = Convert.ToInt32(Options.PixelOffsetChance * 100);

                int yMax = (Options.OffsetHorizontal) ? ImagePixelData.Height : ImagePixelData.Width;
                int xMax = (Options.OffsetHorizontal) ? ImagePixelData.Width : ImagePixelData.Height;

                // Iterating over the pixels and altering them...
                for (int y = 0; y < (yMax); y++) {

                    if (y > 0 && y % (yMax / 11) == 0) {
                        toolStripProgressBar1.PerformStep();
                        //Console.WriteLine(toolStripProgressBar1.Value);
                    }

                    // Controls pixel offsetting:
                    int offset;
                    if (rng.Next(1, 101) <= offsetChance && Options.PixelOffsetActive) {
                        offset = rng.Next(0, Convert.ToInt32(OffsetMag * ImagePixelData.Width));
                        offset = (rng.Next(0, 2) == 0) ? offset : -offset;
                    }
                    else {
                        offset = 0;
                    }
                    int offsetCopy = offset;

                    int startOffsetAt = 0;
                    int stopOffsetAt = xMax;

                    // Controls pixel offset weighing:
                    if (Options.WeightOffsetActive && Options.PixelOffsetActive) {
                        int sequenceSum = xMax * (0 + xMax - 1) / 2;
                        int pick = rng.Next(1, sequenceSum + 1);
                        if (Options.WeightOffsetPositive) {
                            for (int n = 1; n < xMax; n++) {
                                pick -= n;
                                if (pick <= 0) {
                                    int distFromMax = Convert.ToInt32((xMax - 1 - n) * Options.WeightOffsetMagnitude);
                                    distFromMax = Math.Min(xMax - 1, distFromMax);
                                    n = xMax - distFromMax;
                                    startOffsetAt = n;
                                    break;
                                }
                            }
                        }
                        else {
                            for (int n = 1; n < xMax; n++) {
                                pick -= n;
                                if (pick <= 0) {
                                    stopOffsetAt = Convert.ToInt32((xMax - 1 - n) * Options.WeightOffsetMagnitude);
                                    stopOffsetAt = Math.Min(xMax - 1, stopOffsetAt);
                                    break;
                                }
                            }
                        }
                    }



                    for (int x = 0; x < xMax; x++) {

                        Color curr;

                        if (x < startOffsetAt || x > stopOffsetAt) {
                            offset = 0;
                        }
                        else {
                            offset = offsetCopy;
                        }

                        // Chooses a random pixel for the pixel offsetting:
                        int newX = (x + offset);
                        if (Options.OffsetHorizontal) {
                            if (newX >= ImagePixelData.Width) {
                                newX %= ImagePixelData.Width;
                            }
                            else if (newX < 0) {
                                newX += ImagePixelData.Width;
                            }
                            curr = PreviousImageData.GetPixel(newX, y);
                        }
                        else {
                            if (newX >= ImagePixelData.Height) {
                                newX %= ImagePixelData.Height;
                            }
                            else if (newX < 0) {
                                newX += ImagePixelData.Height;
                            }
                            curr = PreviousImageData.GetPixel(y, newX);
                        }

                        int newTransparency = curr.A;
                        int[] newColors = { 0, 0, 0 };
                        int[] cC = { curr.R, curr.G, curr.B };  // Current colors.
                        if (Form1.Options.ColorShiftingActive) {
                            for (int j = 0; j < 3; j++) {

                                // The OG vanilla color shifting options is:
                                // 1. Add to the channel's value.
                                // 2. If the value is greater than 255, Get the modulus of it and 256.
                                // (i.e. loop it around)

                                int newNum = rng.Next(-mag, mag) + cC[j];
                                if (Options.ColorShiftOverflowCap) {
                                    if (newNum > 255) newNum = 255;
                                }
                                else {
                                    newNum %= 256;
                                }

                                if (newNum < 0) {
                                    if (Options.ColorShiftUnderflowCap) {
                                        newNum = 0;
                                    }
                                    else if (Options.ColorShiftUnderflowLoop) {
                                        newNum += 255;
                                    }
                                    else if (Options.ColorShiftUnderflowAbs) {
                                        newNum = Math.Abs(newNum);
                                    }
                                }

                                newColors[j] = (ActiveChannels[j]) ? newNum : cC[j];
                            }

                            if (Options.AChannelActive) {
                                newTransparency = (rng.Next(-mag, mag) + curr.A);
                                if (newTransparency > 255) {
                                    newTransparency = 255;
                                }
                                else if (newTransparency < 0) {
                                    newTransparency = 0;
                                }
                            }
                        }
                        else {
                            newColors = cC;
                        }

                    Color newPixel = Color.FromArgb(newTransparency, newColors[0], newColors[1], newColors[2]);
                        if (Options.OffsetHorizontal) {
                            ImagePixelData.SetPixel(x, y, newPixel);
                        }
                        else {
                            ImagePixelData.SetPixel(y, x, newPixel);
                        }
                    }
                }

                AppPictureBox.Image = (Image)ImagePixelData.Clone();
                PreviousImageData = (Bitmap)ImagePixelData.Clone();

            }
        }

        private void LoadImageToolStripMenuItem_Click(object sender, EventArgs e) {
            using (OpenFileDialog ofd1 = new OpenFileDialog()) {

                ofd1.Title = "Select A Picture";
                ofd1.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg";

                if (ofd1.ShowDialog() == DialogResult.OK) {

                    AppPictureBox.Image = Image.FromFile(ofd1.FileName);
                    AppPictureBox.Size = AppPictureBox.Image.Size;
                    OriginalImageData = AppPictureBox.Image;
                    PreviousImageData = (Bitmap)OriginalImageData;

                    ResizeFormForNewImage(AppPictureBox);

                    foreach (Button i in new Button[] {GlitchButton, SaveButton, ResetButton}) {
                        i.Enabled = true;
                    }

                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e) {
            AppPictureBox.Image = (Image)OriginalImageData.Clone();
            PreviousImageData = (Bitmap)OriginalImageData.Clone();
        }

        private void OptionsButton_Click(object sender, EventArgs e) {
            if (!OptionsMenuOpen) {
                Form2 OptionsMenu = new Form2();
                OptionsMenu.Show();
                OptionsMenuOpen = true;
            }
            else {
                Console.WriteLine("Options menu is already open!");
            }
            //this.Close();
        }

        private void GlitchButton_Click(object sender, EventArgs e) {
            GlitchImage(AppPictureBox.Image);
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            Directory.CreateDirectory("output");
            AppPictureBox.Image.Save("output/glitched.png");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            string MessageBoxText = "Image Scuzzer 2 - 0.1 Alpha\n\nCopyright © 2019\nLicensed under the MIT license\nCreated by Hxdce";
            MessageBox.Show(MessageBoxText, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
