using System;
using System.Drawing;
using System.Windows.Forms;


namespace TreeVirus
{
    public partial class Form1 : Form
    {

        private static Random rand = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        // Starts all the timers for various functions.
        // This is a new function to stop code repeating.
        private void startPrank()
        {
            tmrCheckMouse.Start();
            tmrSuperUnsafeOpenWindow.Start();
            tmrOpenWindow.Start();
            tmrBSOD.Start();
            tmrCrashOpenWindow.Start();
            timerUnsafeOpenWindow.Start();
        }

        // Opens a new meme window
        // Also a new function written to stop code repetition
        private void openNewPrankWindow()
        {
            wrektForm w = new wrektForm(rand.Next(10));
            w.Show();
            w.Location = new Point(this.Location.X + rand.Next(-400, 400), this.Location.Y + rand.Next(-400, 400));
        }

        /* When user moves cursor into the No button start everything
           Also starts all the times for various functions of the program.
        */
        private void btnRemove_MouseEnter(object sender, EventArgs e)
        {
            startPrank();
        }


        private void btnRemove_GotFocus(object sender, EventArgs e)
        {
            startPrank();
        }

        private void btnRemove_MouseHover(object sender, EventArgs e)
        {
            startPrank();
        }

        private void btnYes_MouseEnter(object sender, EventArgs e)
        {
            startPrank();
        }

        private void btnRemove_MouseLeave(object sender, EventArgs e)
        {
            tmrCheckMouse.Stop();
        }

        private void btnYes_MouseLeave(object sender, EventArgs e)
        {
            tmrCheckMouse.Stop();
        }

        // This function stops this form from being closed
        // Likely copy pasta'd from somewhere on stack overflow.
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;

                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_NOCLOSE;
                return cp;
            }
        }

        // This code moves the window around, not sure why the timer is called check mouse.
        private void tmrCheckMouse_Tick(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X + rand.Next(-80, 80), this.Location.Y + rand.Next(-80, 80));
        }

        // Brings this main window back to front.
        private void tmrBringToFront_Tick(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
        
        // Opens a new window
        private void tmrOpenWindow_Tick(object sender, EventArgs e)
        {
            openNewPrankWindow();
        }

        /* I believe the rest of these were supposed to be different functions that I never
         * implemented so they just have placeholder code to open new windows.
        */
        private void timerUnsafeOpenWindow_Tick(object sender, EventArgs e)
        {
            openNewPrankWindow();
        }

        private void tmrSuperUnsafeOpenWindow_Tick(object sender, EventArgs e)
        {
            openNewPrankWindow();
        }

        private void tmrCrashOpenWindow_Tick(object sender, EventArgs e)
        {
            openNewPrankWindow();
        }

        private void tmrBSOD_Tick(object sender, EventArgs e)
        {
            openNewPrankWindow();
        }
    }
}
