using System;
using System.Drawing;
using System.Windows.Forms;


namespace TreeVirus
{
    public partial class wrektForm : Form
    {

        private Random rand = new Random();

        public wrektForm(int imageNum)
        {
            InitializeComponent();

            // Big ass switch statement to select what image to open form with
            // I  hope image names are fairly self explanatory
            switch (imageNum)
                {
                    case 0:
                        imgDisplay.Image = TreeVirus.Properties.Resources.Nerd;
                        break;
                    case 1:
                        imgDisplay.Image = TreeVirus.Properties.Resources.Angry;
                        break;
                    case 2:
                        imgDisplay.Image = TreeVirus.Properties.Resources.TrollFace;
                        break;
                    case 3:
                        imgDisplay.Image = TreeVirus.Properties.Resources.Doge;
                        break;
                    case 4:
                        imgDisplay.Image = TreeVirus.Properties.Resources.Baby;
                        break;
                    case 5:
                        imgDisplay.Image = TreeVirus.Properties.Resources.Dry;
                        break;
                    case 6:
                        imgDisplay.Image = TreeVirus.Properties.Resources.Mordo;
                        break;
                    case 7:
                        imgDisplay.Image = TreeVirus.Properties.Resources.Oh_dear;
                        break;
                    case 8:
                        imgDisplay.Image = TreeVirus.Properties.Resources.Seal;
                        break;
                    case 9:
                        imgDisplay.Image = TreeVirus.Properties.Resources.Wierd_face;
                        break;
                    case 10:
                        imgDisplay.Image = TreeVirus.Properties.Resources.Wierdo;
                        break;
                }

        }

        /* This function moves the window to a new location relative to current location
           It also sets the window to be the top most window, this creates an effect
           of the windows constantly popping up.*/
        private void timerBlowUp_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X + rand.Next(-150, 150), this.Location.Y + rand.Next(-150, 150));
            this.TopMost = true;
        }
    }
}
