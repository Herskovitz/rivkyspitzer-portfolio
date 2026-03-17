namespace TicTacToe
{
    partial class frmTicTacToe
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicTacToe));
            tblMain = new TableLayoutPanel();
            ctrlTicTacToeMG = new TicTacToeControlMG();
            ctrlTicTacToeRS = new TicTacToeControlRS();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(ctrlTicTacToeMG, 0, 0);
            tblMain.Controls.Add(ctrlTicTacToeRS, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(1097, 563);
            tblMain.TabIndex = 0;
            // 
            // ctrlTicTacToeMG
            // 
            ctrlTicTacToeMG.Dock = DockStyle.Fill;
            ctrlTicTacToeMG.Location = new Point(3, 3);
            ctrlTicTacToeMG.Name = "ctrlTicTacToeMG";
            ctrlTicTacToeMG.Size = new Size(542, 557);
            ctrlTicTacToeMG.TabIndex = 0;
            // 
            // ctrlTicTacToeRS
            // 
            ctrlTicTacToeRS.Dock = DockStyle.Fill;
            ctrlTicTacToeRS.Location = new Point(551, 3);
            ctrlTicTacToeRS.Name = "ctrlTicTacToeRS";
            ctrlTicTacToeRS.Size = new Size(543, 557);
            ctrlTicTacToeRS.TabIndex = 1;
            // 
            // frmTicTacToe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 563);
            Controls.Add(tblMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmTicTacToe";
            Text = "TicTacToe";
            tblMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TicTacToeControlMG ctrlTicTacToeMG;
        private TicTacToeControlRS ctrlTicTacToeRS;
    }
}