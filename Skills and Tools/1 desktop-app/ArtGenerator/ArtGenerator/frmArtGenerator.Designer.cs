namespace ArtGenerator
{
    partial class frmArtGenerator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblMain = new TableLayoutPanel();
            lblSettings = new Label();
            lblShapes = new Label();
            tblShapes = new TableLayoutPanel();
            optNumOfShapes = new RadioButton();
            optNumOfMilSec = new RadioButton();
            optNumOfSec = new RadioButton();
            txtNumOfMillisec = new TextBox();
            txtNumOfSec = new TextBox();
            txtNumOfShapes = new TextBox();
            lblColor = new Label();
            tblColor = new TableLayoutPanel();
            lblRed = new Label();
            lblGreen = new Label();
            lblBlue = new Label();
            lblRedMin = new Label();
            lblMinGreen = new Label();
            lblMinBlue = new Label();
            lblMaxRed = new Label();
            lblMaxGreen = new Label();
            lblMaxBlue = new Label();
            txtRedMin = new TextBox();
            txtGreenMin = new TextBox();
            txtBlueMin = new TextBox();
            txtRedMax = new TextBox();
            txtGreenMax = new TextBox();
            txtBlueMax = new TextBox();
            lblSize = new Label();
            tblSize = new TableLayoutPanel();
            lblHeight = new Label();
            lblWidth = new Label();
            lblHeightMin = new Label();
            lblWidthMin = new Label();
            lblHeightMax = new Label();
            lblWidthMax = new Label();
            txtHeightMin = new TextBox();
            txtWidthMin = new TextBox();
            txtHeightMax = new TextBox();
            txtWidthMax = new TextBox();
            tblButtons = new TableLayoutPanel();
            btnStart = new Button();
            btnClear = new Button();
            btnRefresh = new Button();
            pnlDisplay = new Panel();
            fileSystemWatcher1 = new FileSystemWatcher();
            tblMain.SuspendLayout();
            tblShapes.SuspendLayout();
            tblColor.SuspendLayout();
            tblSize.SuspendLayout();
            tblButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblMain.Controls.Add(lblSettings, 0, 0);
            tblMain.Controls.Add(lblShapes, 0, 1);
            tblMain.Controls.Add(tblShapes, 0, 2);
            tblMain.Controls.Add(lblColor, 0, 6);
            tblMain.Controls.Add(tblColor, 0, 7);
            tblMain.Controls.Add(lblSize, 0, 11);
            tblMain.Controls.Add(tblSize, 0, 12);
            tblMain.Controls.Add(tblButtons, 0, 14);
            tblMain.Controls.Add(pnlDisplay, 2, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 16;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.077348F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.353591F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 6.25F));
            tblMain.Size = new Size(1024, 724);
            tblMain.TabIndex = 0;
            // 
            // lblSettings
            // 
            lblSettings.AutoSize = true;
            tblMain.SetColumnSpan(lblSettings, 2);
            lblSettings.Dock = DockStyle.Fill;
            lblSettings.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSettings.Location = new Point(3, 0);
            lblSettings.Name = "lblSettings";
            lblSettings.Size = new Size(402, 45);
            lblSettings.TabIndex = 0;
            lblSettings.Text = "Art Generator Settings";
            lblSettings.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblShapes
            // 
            lblShapes.AutoSize = true;
            lblShapes.Dock = DockStyle.Fill;
            lblShapes.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblShapes.Location = new Point(3, 45);
            lblShapes.Name = "lblShapes";
            lblShapes.Size = new Size(198, 45);
            lblShapes.TabIndex = 1;
            lblShapes.Text = "Shapes";
            lblShapes.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tblShapes
            // 
            tblShapes.ColumnCount = 2;
            tblMain.SetColumnSpan(tblShapes, 2);
            tblShapes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tblShapes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblShapes.Controls.Add(optNumOfShapes, 0, 0);
            tblShapes.Controls.Add(optNumOfMilSec, 0, 1);
            tblShapes.Controls.Add(optNumOfSec, 0, 2);
            tblShapes.Controls.Add(txtNumOfMillisec, 1, 1);
            tblShapes.Controls.Add(txtNumOfSec, 1, 2);
            tblShapes.Controls.Add(txtNumOfShapes, 1, 0);
            tblShapes.Dock = DockStyle.Fill;
            tblShapes.Location = new Point(3, 93);
            tblShapes.Name = "tblShapes";
            tblShapes.RowCount = 3;
            tblMain.SetRowSpan(tblShapes, 3);
            tblShapes.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblShapes.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblShapes.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblShapes.Size = new Size(402, 129);
            tblShapes.TabIndex = 2;
            // 
            // optNumOfShapes
            // 
            optNumOfShapes.AutoSize = true;
            optNumOfShapes.Checked = true;
            optNumOfShapes.Dock = DockStyle.Fill;
            optNumOfShapes.Location = new Point(3, 3);
            optNumOfShapes.Name = "optNumOfShapes";
            optNumOfShapes.Size = new Size(275, 37);
            optNumOfShapes.TabIndex = 0;
            optNumOfShapes.TabStop = true;
            optNumOfShapes.Text = "Specific Number of Shapes";
            optNumOfShapes.UseVisualStyleBackColor = true;
            // 
            // optNumOfMilSec
            // 
            optNumOfMilSec.AutoSize = true;
            optNumOfMilSec.Dock = DockStyle.Fill;
            optNumOfMilSec.Location = new Point(3, 46);
            optNumOfMilSec.Name = "optNumOfMilSec";
            optNumOfMilSec.Size = new Size(275, 37);
            optNumOfMilSec.TabIndex = 2;
            optNumOfMilSec.Text = "Add Shape Every x Milliseconds";
            optNumOfMilSec.UseVisualStyleBackColor = true;
            // 
            // optNumOfSec
            // 
            optNumOfSec.AutoSize = true;
            optNumOfSec.Dock = DockStyle.Fill;
            optNumOfSec.Location = new Point(3, 89);
            optNumOfSec.Name = "optNumOfSec";
            optNumOfSec.Size = new Size(275, 37);
            optNumOfSec.TabIndex = 4;
            optNumOfSec.Text = "Add Shape for x Seconds";
            optNumOfSec.UseVisualStyleBackColor = true;
            // 
            // txtNumOfMillisec
            // 
            txtNumOfMillisec.BorderStyle = BorderStyle.FixedSingle;
            txtNumOfMillisec.Dock = DockStyle.Fill;
            txtNumOfMillisec.Enabled = false;
            txtNumOfMillisec.Location = new Point(284, 46);
            txtNumOfMillisec.Multiline = true;
            txtNumOfMillisec.Name = "txtNumOfMillisec";
            txtNumOfMillisec.PlaceholderText = "# milliseconds";
            txtNumOfMillisec.Size = new Size(115, 37);
            txtNumOfMillisec.TabIndex = 3;
            // 
            // txtNumOfSec
            // 
            txtNumOfSec.BorderStyle = BorderStyle.FixedSingle;
            txtNumOfSec.Dock = DockStyle.Fill;
            txtNumOfSec.Enabled = false;
            txtNumOfSec.Location = new Point(284, 89);
            txtNumOfSec.Multiline = true;
            txtNumOfSec.Name = "txtNumOfSec";
            txtNumOfSec.PlaceholderText = "# of seconds";
            txtNumOfSec.Size = new Size(115, 37);
            txtNumOfSec.TabIndex = 5;
            // 
            // txtNumOfShapes
            // 
            txtNumOfShapes.BorderStyle = BorderStyle.FixedSingle;
            txtNumOfShapes.Dock = DockStyle.Fill;
            txtNumOfShapes.Enabled = false;
            txtNumOfShapes.Location = new Point(284, 3);
            txtNumOfShapes.Multiline = true;
            txtNumOfShapes.Name = "txtNumOfShapes";
            txtNumOfShapes.PlaceholderText = "# of shapes";
            txtNumOfShapes.Size = new Size(115, 37);
            txtNumOfShapes.TabIndex = 1;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Dock = DockStyle.Fill;
            lblColor.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblColor.Location = new Point(3, 269);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(198, 46);
            lblColor.TabIndex = 2;
            lblColor.Text = "Color Range (RGB)";
            lblColor.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tblColor
            // 
            tblColor.ColumnCount = 5;
            tblMain.SetColumnSpan(tblColor, 2);
            tblColor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblColor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tblColor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblColor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tblColor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblColor.Controls.Add(lblRed, 0, 0);
            tblColor.Controls.Add(lblGreen, 0, 1);
            tblColor.Controls.Add(lblBlue, 0, 2);
            tblColor.Controls.Add(lblRedMin, 1, 0);
            tblColor.Controls.Add(lblMinGreen, 1, 1);
            tblColor.Controls.Add(lblMinBlue, 1, 2);
            tblColor.Controls.Add(lblMaxRed, 3, 0);
            tblColor.Controls.Add(lblMaxGreen, 3, 1);
            tblColor.Controls.Add(lblMaxBlue, 3, 2);
            tblColor.Controls.Add(txtRedMin, 2, 0);
            tblColor.Controls.Add(txtGreenMin, 2, 1);
            tblColor.Controls.Add(txtBlueMin, 2, 2);
            tblColor.Controls.Add(txtRedMax, 4, 0);
            tblColor.Controls.Add(txtGreenMax, 4, 1);
            tblColor.Controls.Add(txtBlueMax, 4, 2);
            tblColor.Dock = DockStyle.Fill;
            tblColor.Location = new Point(3, 318);
            tblColor.Name = "tblColor";
            tblColor.RowCount = 3;
            tblMain.SetRowSpan(tblColor, 3);
            tblColor.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblColor.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblColor.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblColor.Size = new Size(402, 129);
            tblColor.TabIndex = 4;
            // 
            // lblRed
            // 
            lblRed.AutoSize = true;
            lblRed.Dock = DockStyle.Fill;
            lblRed.Location = new Point(3, 0);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(74, 43);
            lblRed.TabIndex = 0;
            lblRed.Text = "Red:";
            lblRed.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGreen
            // 
            lblGreen.AutoSize = true;
            lblGreen.Dock = DockStyle.Fill;
            lblGreen.Location = new Point(3, 43);
            lblGreen.Name = "lblGreen";
            lblGreen.Size = new Size(74, 43);
            lblGreen.TabIndex = 5;
            lblGreen.Text = "Green:";
            lblGreen.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBlue
            // 
            lblBlue.AutoSize = true;
            lblBlue.Dock = DockStyle.Fill;
            lblBlue.Location = new Point(3, 86);
            lblBlue.Name = "lblBlue";
            lblBlue.Size = new Size(74, 43);
            lblBlue.TabIndex = 10;
            lblBlue.Text = "Blue:";
            lblBlue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRedMin
            // 
            lblRedMin.AutoSize = true;
            lblRedMin.Dock = DockStyle.Fill;
            lblRedMin.Location = new Point(83, 0);
            lblRedMin.Name = "lblRedMin";
            lblRedMin.Size = new Size(54, 43);
            lblRedMin.TabIndex = 1;
            lblRedMin.Text = "Min";
            lblRedMin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMinGreen
            // 
            lblMinGreen.AutoSize = true;
            lblMinGreen.Dock = DockStyle.Fill;
            lblMinGreen.Location = new Point(83, 43);
            lblMinGreen.Name = "lblMinGreen";
            lblMinGreen.Size = new Size(54, 43);
            lblMinGreen.TabIndex = 6;
            lblMinGreen.Text = "Min";
            lblMinGreen.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMinBlue
            // 
            lblMinBlue.AutoSize = true;
            lblMinBlue.Dock = DockStyle.Fill;
            lblMinBlue.Location = new Point(83, 86);
            lblMinBlue.Name = "lblMinBlue";
            lblMinBlue.Size = new Size(54, 43);
            lblMinBlue.TabIndex = 11;
            lblMinBlue.Text = "Min";
            lblMinBlue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMaxRed
            // 
            lblMaxRed.AutoSize = true;
            lblMaxRed.Dock = DockStyle.Fill;
            lblMaxRed.Location = new Point(243, 0);
            lblMaxRed.Name = "lblMaxRed";
            lblMaxRed.Size = new Size(54, 43);
            lblMaxRed.TabIndex = 3;
            lblMaxRed.Text = "Max";
            lblMaxRed.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMaxGreen
            // 
            lblMaxGreen.AutoSize = true;
            lblMaxGreen.Dock = DockStyle.Fill;
            lblMaxGreen.Location = new Point(243, 43);
            lblMaxGreen.Name = "lblMaxGreen";
            lblMaxGreen.Size = new Size(54, 43);
            lblMaxGreen.TabIndex = 8;
            lblMaxGreen.Text = "Max";
            lblMaxGreen.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMaxBlue
            // 
            lblMaxBlue.AutoSize = true;
            lblMaxBlue.Dock = DockStyle.Fill;
            lblMaxBlue.Location = new Point(243, 86);
            lblMaxBlue.Name = "lblMaxBlue";
            lblMaxBlue.Size = new Size(54, 43);
            lblMaxBlue.TabIndex = 13;
            lblMaxBlue.Text = "Max";
            lblMaxBlue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtRedMin
            // 
            txtRedMin.BorderStyle = BorderStyle.FixedSingle;
            txtRedMin.Dock = DockStyle.Fill;
            txtRedMin.Location = new Point(143, 3);
            txtRedMin.Multiline = true;
            txtRedMin.Name = "txtRedMin";
            txtRedMin.Size = new Size(94, 37);
            txtRedMin.TabIndex = 2;
            // 
            // txtGreenMin
            // 
            txtGreenMin.BorderStyle = BorderStyle.FixedSingle;
            txtGreenMin.Dock = DockStyle.Fill;
            txtGreenMin.Location = new Point(143, 46);
            txtGreenMin.Multiline = true;
            txtGreenMin.Name = "txtGreenMin";
            txtGreenMin.Size = new Size(94, 37);
            txtGreenMin.TabIndex = 7;
            // 
            // txtBlueMin
            // 
            txtBlueMin.BorderStyle = BorderStyle.FixedSingle;
            txtBlueMin.Dock = DockStyle.Fill;
            txtBlueMin.Location = new Point(143, 89);
            txtBlueMin.Multiline = true;
            txtBlueMin.Name = "txtBlueMin";
            txtBlueMin.Size = new Size(94, 37);
            txtBlueMin.TabIndex = 12;
            // 
            // txtRedMax
            // 
            txtRedMax.BorderStyle = BorderStyle.FixedSingle;
            txtRedMax.Dock = DockStyle.Fill;
            txtRedMax.Location = new Point(303, 3);
            txtRedMax.Multiline = true;
            txtRedMax.Name = "txtRedMax";
            txtRedMax.Size = new Size(96, 37);
            txtRedMax.TabIndex = 4;
            // 
            // txtGreenMax
            // 
            txtGreenMax.BorderStyle = BorderStyle.FixedSingle;
            txtGreenMax.Dock = DockStyle.Fill;
            txtGreenMax.Location = new Point(303, 46);
            txtGreenMax.Multiline = true;
            txtGreenMax.Name = "txtGreenMax";
            txtGreenMax.Size = new Size(96, 37);
            txtGreenMax.TabIndex = 9;
            // 
            // txtBlueMax
            // 
            txtBlueMax.BorderStyle = BorderStyle.FixedSingle;
            txtBlueMax.Dock = DockStyle.Fill;
            txtBlueMax.Location = new Point(303, 89);
            txtBlueMax.Multiline = true;
            txtBlueMax.Name = "txtBlueMax";
            txtBlueMax.Size = new Size(96, 37);
            txtBlueMax.TabIndex = 14;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Dock = DockStyle.Fill;
            lblSize.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSize.Location = new Point(3, 495);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(198, 45);
            lblSize.TabIndex = 3;
            lblSize.Text = "Size";
            lblSize.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tblSize
            // 
            tblSize.ColumnCount = 5;
            tblMain.SetColumnSpan(tblSize, 2);
            tblSize.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblSize.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tblSize.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblSize.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tblSize.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblSize.Controls.Add(lblHeight, 0, 0);
            tblSize.Controls.Add(lblWidth, 0, 1);
            tblSize.Controls.Add(lblHeightMin, 1, 0);
            tblSize.Controls.Add(lblWidthMin, 1, 1);
            tblSize.Controls.Add(lblHeightMax, 3, 0);
            tblSize.Controls.Add(lblWidthMax, 3, 1);
            tblSize.Controls.Add(txtHeightMin, 2, 0);
            tblSize.Controls.Add(txtWidthMin, 2, 1);
            tblSize.Controls.Add(txtHeightMax, 4, 0);
            tblSize.Controls.Add(txtWidthMax, 4, 1);
            tblSize.Dock = DockStyle.Fill;
            tblSize.Location = new Point(3, 543);
            tblSize.Name = "tblSize";
            tblSize.RowCount = 2;
            tblMain.SetRowSpan(tblSize, 2);
            tblSize.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblSize.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblSize.Size = new Size(402, 84);
            tblSize.TabIndex = 6;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Dock = DockStyle.Fill;
            lblHeight.Location = new Point(3, 0);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(74, 42);
            lblHeight.TabIndex = 0;
            lblHeight.Text = "Height:";
            lblHeight.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Dock = DockStyle.Fill;
            lblWidth.Location = new Point(3, 42);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(74, 42);
            lblWidth.TabIndex = 5;
            lblWidth.Text = "Width:";
            lblWidth.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHeightMin
            // 
            lblHeightMin.AutoSize = true;
            lblHeightMin.Dock = DockStyle.Fill;
            lblHeightMin.Location = new Point(83, 0);
            lblHeightMin.Name = "lblHeightMin";
            lblHeightMin.Size = new Size(54, 42);
            lblHeightMin.TabIndex = 1;
            lblHeightMin.Text = "Min";
            lblHeightMin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblWidthMin
            // 
            lblWidthMin.AutoSize = true;
            lblWidthMin.Dock = DockStyle.Fill;
            lblWidthMin.Location = new Point(83, 42);
            lblWidthMin.Name = "lblWidthMin";
            lblWidthMin.Size = new Size(54, 42);
            lblWidthMin.TabIndex = 6;
            lblWidthMin.Text = "Min";
            lblWidthMin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHeightMax
            // 
            lblHeightMax.AutoSize = true;
            lblHeightMax.Dock = DockStyle.Fill;
            lblHeightMax.Location = new Point(243, 0);
            lblHeightMax.Name = "lblHeightMax";
            lblHeightMax.Size = new Size(54, 42);
            lblHeightMax.TabIndex = 3;
            lblHeightMax.Text = "Max";
            lblHeightMax.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblWidthMax
            // 
            lblWidthMax.AutoSize = true;
            lblWidthMax.Dock = DockStyle.Fill;
            lblWidthMax.Location = new Point(243, 42);
            lblWidthMax.Name = "lblWidthMax";
            lblWidthMax.Size = new Size(54, 42);
            lblWidthMax.TabIndex = 8;
            lblWidthMax.Text = "Max";
            lblWidthMax.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtHeightMin
            // 
            txtHeightMin.BorderStyle = BorderStyle.FixedSingle;
            txtHeightMin.Dock = DockStyle.Fill;
            txtHeightMin.Location = new Point(143, 3);
            txtHeightMin.Multiline = true;
            txtHeightMin.Name = "txtHeightMin";
            txtHeightMin.Size = new Size(94, 36);
            txtHeightMin.TabIndex = 2;
            // 
            // txtWidthMin
            // 
            txtWidthMin.BorderStyle = BorderStyle.FixedSingle;
            txtWidthMin.Dock = DockStyle.Fill;
            txtWidthMin.Location = new Point(143, 45);
            txtWidthMin.Multiline = true;
            txtWidthMin.Name = "txtWidthMin";
            txtWidthMin.Size = new Size(94, 36);
            txtWidthMin.TabIndex = 7;
            // 
            // txtHeightMax
            // 
            txtHeightMax.BorderStyle = BorderStyle.FixedSingle;
            txtHeightMax.Dock = DockStyle.Fill;
            txtHeightMax.Location = new Point(303, 3);
            txtHeightMax.Multiline = true;
            txtHeightMax.Name = "txtHeightMax";
            txtHeightMax.Size = new Size(96, 36);
            txtHeightMax.TabIndex = 4;
            // 
            // txtWidthMax
            // 
            txtWidthMax.BorderStyle = BorderStyle.FixedSingle;
            txtWidthMax.Dock = DockStyle.Fill;
            txtWidthMax.Location = new Point(303, 45);
            txtWidthMax.Multiline = true;
            txtWidthMax.Name = "txtWidthMax";
            txtWidthMax.Size = new Size(96, 36);
            txtWidthMax.TabIndex = 9;
            // 
            // tblButtons
            // 
            tblButtons.ColumnCount = 3;
            tblMain.SetColumnSpan(tblButtons, 2);
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblButtons.Controls.Add(btnStart, 0, 1);
            tblButtons.Controls.Add(btnClear, 1, 1);
            tblButtons.Controls.Add(btnRefresh, 2, 1);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 633);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 2;
            tblMain.SetRowSpan(tblButtons, 2);
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tblButtons.Size = new Size(402, 88);
            tblButtons.TabIndex = 7;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.DarkSeaGreen;
            btnStart.Dock = DockStyle.Fill;
            btnStart.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.ForeColor = Color.Black;
            btnStart.Location = new Point(3, 25);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(127, 60);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Enabled = false;
            btnClear.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(136, 25);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(128, 60);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear Shapes";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.GradientActiveCaption;
            btnRefresh.Dock = DockStyle.Fill;
            btnRefresh.Enabled = false;
            btnRefresh.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(270, 25);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(129, 60);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh Color";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // pnlDisplay
            // 
            pnlDisplay.BackColor = SystemColors.MenuText;
            tblMain.SetColumnSpan(pnlDisplay, 2);
            pnlDisplay.Dock = DockStyle.Fill;
            pnlDisplay.Location = new Point(411, 3);
            pnlDisplay.Name = "pnlDisplay";
            tblMain.SetRowSpan(pnlDisplay, 16);
            pnlDisplay.Size = new Size(610, 718);
            pnlDisplay.TabIndex = 5;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // frmArtGenerator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 724);
            Controls.Add(tblMain);
            Name = "frmArtGenerator";
            Text = "Art Generator";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblShapes.ResumeLayout(false);
            tblShapes.PerformLayout();
            tblColor.ResumeLayout(false);
            tblColor.PerformLayout();
            tblSize.ResumeLayout(false);
            tblSize.PerformLayout();
            tblButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblSettings;
        private Label lblShapes;
        private TableLayoutPanel tblShapes;
        private RadioButton optNumOfShapes;
        private RadioButton optNumOfMilSec;
        private RadioButton optNumOfSec;
        private TextBox txtNumOfMillisec;
        private TextBox txtNumOfSec;
        private TextBox txtNumOfShapes;
        private Label lblColor;
        private TableLayoutPanel tblColor;
        private Label lblRed;
        private Label lblGreen;
        private Label lblBlue;
        private Label lblRedMin;
        private Label lblMinGreen;
        private Label lblMinBlue;
        private Label lblMaxRed;
        private Label lblMaxGreen;
        private Label lblMaxBlue;
        private TextBox txtRedMin;
        private TextBox txtGreenMin;
        private TextBox txtBlueMin;
        private TextBox txtRedMax;
        private TextBox txtGreenMax;
        private TextBox txtBlueMax;
        private Label lblSize;
        private TableLayoutPanel tblSize;
        private Label lblHeight;
        private Label lblWidth;
        private Label lblHeightMin;
        private Label lblWidthMin;
        private Label lblHeightMax;
        private Label lblWidthMax;
        private TextBox txtHeightMin;
        private TextBox txtWidthMin;
        private TextBox txtHeightMax;
        private TextBox txtWidthMax;
        private TableLayoutPanel tblButtons;
        private Button btnStart;
        private Button btnClear;
        private Button btnRefresh;
        private FileSystemWatcher fileSystemWatcher1;
        private Panel pnlDisplay;
    }
}