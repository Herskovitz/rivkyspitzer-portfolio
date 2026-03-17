using System;

namespace ArtGenerator
{
    public partial class frmArtGenerator : Form
    {
        bool start = false;
        Random rdm = new();
        System.Windows.Forms.Timer tmr = new();
        int rmin = 0;
        int rmax = 0;
        int gmin = 0;
        int gmax = 255;
        int bmin = 255;
        int bmax = 255;


        public frmArtGenerator()
        {
            InitializeComponent();
            btnStart.Click += BtnStart_Click;
            btnClear.Click += BtnClear_Click;
            btnRefresh.Click += BtnRefresh_Click;
            tmr.Tick += Tmr_Tick;
            optNumOfShapes.Click += ShapeOpt_Click;
            optNumOfMilSec.Click += ShapeOpt_Click;
            optNumOfSec.Click += ShapeOpt_Click;
        }

        private Color GenerateUserInputColor()
        {
            int.TryParse(txtRedMin.Text, out rmin);
            int.TryParse(txtRedMax.Text, out rmax);
            int.TryParse(txtGreenMin.Text, out gmin);
            int.TryParse(txtGreenMax.Text, out gmax);
            int.TryParse(txtBlueMin.Text, out bmin);
            int.TryParse(txtBlueMax.Text, out bmax);

            CorrectColorValues();
            Color c = Color.FromArgb(rdm.Next(rmin, rmax), rdm.Next(gmin, gmax), rdm.Next(bmin, bmax));
            return c;
        }

        private void CorrectColorValues()
        {
            if (rmax < rmin || rmax > 255)
            {
                rmax = 255;
            }
            if (gmax < gmin || gmax > 255)
            {
                gmax = 255;
            }
            if (bmax < bmin || bmax > 255)
            {
                bmax = 255;
            }
            if (rmin < 0)
            {
                rmin = 0;
            }
            if (gmin < 0)
            {
                gmin = 0;
            }
            if (bmin < 0)
            {
                bmin = 0;
            }
        }

        private void GenerateLabel()
        {
            int hmin = 1;
            int hmax = 1;
            int wmin = 1;
            int wmax = 1;

            int.TryParse(txtHeightMin.Text, out hmin);
            int.TryParse(txtHeightMax.Text, out hmax);
            int.TryParse(txtWidthMin.Text, out wmin);
            int.TryParse(txtWidthMax.Text, out wmax);

            int hght = rdm.Next(hmin, hmax);
            int wdth = rdm.Next(wmin, wmax);

            Label lbl = new();
            lbl.BackColor = GenerateUserInputColor();
            lbl.Size = new(wdth, hght);
            lbl.Location = new Point(rdm.Next(0, pnlDisplay.Width), rdm.Next(0, pnlDisplay.Height));
            lbl.Show();
            pnlDisplay.Controls.Add(lbl);
        }
        private void ResetShapeOptionsEnabledProperties()
        {
            if (optNumOfShapes.Checked)
            {
                txtNumOfMillisec.Clear();
                txtNumOfSec.Clear();
            }
            else if (optNumOfMilSec.Checked)
            {
                txtNumOfShapes.Clear();
                txtNumOfSec.Clear();
            }
            else if (optNumOfSec.Checked)
            {
                txtNumOfShapes.Clear();
                txtNumOfMillisec.Clear();
            }
            txtNumOfShapes.Enabled = optNumOfShapes.Checked;
            txtNumOfMillisec.Enabled = optNumOfMilSec.Checked;
            txtNumOfSec.Enabled = optNumOfSec.Checked;

        }
        private void ShapeOpt_Click(object? sender, EventArgs e)
        {
            ResetShapeOptionsEnabledProperties();
        }

        private void SetRefreshClearBtn()
        {
            btnRefresh.Enabled = pnlDisplay.Controls.Count == 0 ? false : true;
            btnClear.Enabled = pnlDisplay.Controls.Count == 0 ? false : true;
        }
        private void BtnStart_Click(object? sender, EventArgs e)
        {
            int shapenum = 1;
            int milsecnum = 1;
            int secnum = 1;

            int.TryParse(txtNumOfShapes.Text, out shapenum);
            int.TryParse(txtNumOfMillisec.Text, out milsecnum);
            int.TryParse(txtNumOfSec.Text, out secnum);


            if (optNumOfShapes.Checked)
            {
                pnlDisplay.Controls.Clear();

                for (int i = 0; i < shapenum; i++)
                {
                    GenerateLabel();
                    Application.DoEvents();
                    if (start == true)
                    {
                        StartStopProgram();
                    }
                }
                SetRefreshClearBtn();
            }
            else if (optNumOfMilSec.Checked)
            {
                tmr.Interval = milsecnum;
                tmr.Enabled = !tmr.Enabled;
                StartStopProgram();
                SetRefreshClearBtn();
            }
            else if (optNumOfSec.Checked)
            {
                StartStopProgram();
                DateTime starttime = DateTime.Now;
                while ((DateTime.Now - starttime).TotalSeconds <= secnum && start == true)
                {
                    GenerateLabel();
                    Application.DoEvents();
                }
                if (start == true)
                {
                    StartStopProgram();
                }
                SetRefreshClearBtn();
            }
        }
        private void Tmr_Tick(object? sender, EventArgs e)
        {
            GenerateLabel();
        }
        private void BtnClear_Click(object? sender, EventArgs e)
        {
            pnlDisplay.Controls.Clear();
            SetRefreshClearBtn();
        }
        private void BtnRefresh_Click(object? sender, EventArgs e)
        {
            foreach (Control c in pnlDisplay.Controls)
            {
                c.BackColor = GenerateUserInputColor();

            }
        }

        private void StartStopProgram()
        {
            if (start == false)
            {
                pnlDisplay.Controls.Clear();
            }

            if (start == true)
            {
                ResetShapeOptionsEnabledProperties();
            }

            btnStart.Text = btnStart.Text == "Start" ? "Stop" : "Start";
            btnStart.BackColor = btnStart.BackColor == Color.DarkSeaGreen ? Color.DarkRed : Color.DarkSeaGreen;
            start = start == false ? true : false;

            btnClear.Enabled = !btnClear.Enabled;
            btnRefresh.Enabled = !btnRefresh.Enabled;
            foreach (Control c in tblShapes.Controls)
            {
                c.Enabled = !c.Enabled;
            }
            foreach (Control c in tblColor.Controls)
            {
                c.Enabled = !c.Enabled;
            }
            foreach (Control c in tblSize.Controls)
            {
                c.Enabled = !c.Enabled;
            }
        }
    }
}