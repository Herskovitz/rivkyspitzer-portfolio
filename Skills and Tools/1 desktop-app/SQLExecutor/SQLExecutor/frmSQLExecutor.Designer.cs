namespace SQLExecutor
{
    partial class frmSQLExecutor
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
            tabMain = new TabControl();
            pnlServer = new Panel();
            optAzure = new RadioButton();
            optLocal = new RadioButton();
            pnlDatabase = new Panel();
            optRecipe = new RadioButton();
            optRecordKeeper = new RadioButton();
            lblDatabase = new Label();
            btnRun = new Button();
            tblMain = new TableLayoutPanel();
            tblQuery = new TableLayoutPanel();
            txtQuery = new TextBox();
            pnlServer.SuspendLayout();
            pnlDatabase.SuspendLayout();
            tblMain.SuspendLayout();
            tblQuery.SuspendLayout();
            SuspendLayout();
            // 
            // tabMain
            // 
            tblMain.SetColumnSpan(tabMain, 5);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(3, 398);
            tabMain.Name = "tabMain";
            tblMain.SetRowSpan(tabMain, 2);
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(948, 326);
            tabMain.TabIndex = 5;
            // 
            // pnlServer
            // 
            pnlServer.BorderStyle = BorderStyle.FixedSingle;
            tblMain.SetColumnSpan(pnlServer, 4);
            pnlServer.Controls.Add(optAzure);
            pnlServer.Controls.Add(optLocal);
            pnlServer.Dock = DockStyle.Fill;
            pnlServer.Location = new Point(193, 3);
            pnlServer.Name = "pnlServer";
            pnlServer.Size = new Size(758, 86);
            pnlServer.TabIndex = 1;
            // 
            // optAzure
            // 
            optAzure.AutoSize = true;
            optAzure.Location = new Point(194, 34);
            optAzure.Name = "optAzure";
            optAzure.Size = new Size(68, 24);
            optAzure.TabIndex = 1;
            optAzure.Text = "Azure";
            optAzure.UseVisualStyleBackColor = true;
            // 
            // optLocal
            // 
            optLocal.AutoSize = true;
            optLocal.Checked = true;
            optLocal.Location = new Point(47, 34);
            optLocal.Name = "optLocal";
            optLocal.Size = new Size(89, 24);
            optLocal.TabIndex = 0;
            optLocal.TabStop = true;
            optLocal.Text = "Local DB";
            optLocal.UseVisualStyleBackColor = true;
            // 
            // pnlDatabase
            // 
            pnlDatabase.BorderStyle = BorderStyle.FixedSingle;
            pnlDatabase.Controls.Add(optRecipe);
            pnlDatabase.Controls.Add(optRecordKeeper);
            pnlDatabase.Dock = DockStyle.Fill;
            pnlDatabase.Location = new Point(3, 95);
            pnlDatabase.Name = "pnlDatabase";
            tblMain.SetRowSpan(pnlDatabase, 2);
            pnlDatabase.Size = new Size(184, 297);
            pnlDatabase.TabIndex = 2;
            // 
            // optRecipe
            // 
            optRecipe.AutoSize = true;
            optRecipe.Location = new Point(20, 54);
            optRecipe.Name = "optRecipe";
            optRecipe.Size = new Size(75, 24);
            optRecipe.TabIndex = 1;
            optRecipe.Text = "Recipe";
            optRecipe.UseVisualStyleBackColor = true;
            // 
            // optRecordKeeper
            // 
            optRecordKeeper.AutoSize = true;
            optRecordKeeper.Checked = true;
            optRecordKeeper.Location = new Point(20, 24);
            optRecordKeeper.Name = "optRecordKeeper";
            optRecordKeeper.Size = new Size(124, 24);
            optRecordKeeper.TabIndex = 0;
            optRecordKeeper.TabStop = true;
            optRecordKeeper.Text = "RecordKeeper";
            optRecordKeeper.UseVisualStyleBackColor = true;
            // 
            // lblDatabase
            // 
            lblDatabase.BackColor = SystemColors.ControlLight;
            lblDatabase.Dock = DockStyle.Fill;
            lblDatabase.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatabase.Location = new Point(3, 0);
            lblDatabase.MinimumSize = new Size(125, 25);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(184, 92);
            lblDatabase.TabIndex = 0;
            lblDatabase.Text = "Database";
            lblDatabase.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRun
            // 
            btnRun.BackColor = SystemColors.ButtonFace;
            btnRun.Dock = DockStyle.Fill;
            btnRun.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRun.ForeColor = SystemColors.HotTrack;
            btnRun.Location = new Point(763, 335);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(188, 57);
            btnRun.TabIndex = 4;
            btnRun.Text = "Run Query";
            btnRun.UseVisualStyleBackColor = false;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 5;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblMain.Controls.Add(lblDatabase, 0, 0);
            tblMain.Controls.Add(tabMain, 0, 3);
            tblMain.Controls.Add(pnlServer, 1, 0);
            tblMain.Controls.Add(pnlDatabase, 0, 1);
            tblMain.Controls.Add(btnRun, 4, 2);
            tblMain.Controls.Add(tblQuery, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 13.0319147F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 34.0425529F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 44F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(954, 727);
            tblMain.TabIndex = 0;
            // 
            // tblQuery
            // 
            tblQuery.ColumnCount = 1;
            tblMain.SetColumnSpan(tblQuery, 4);
            tblQuery.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblQuery.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblQuery.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblQuery.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblQuery.Controls.Add(txtQuery, 0, 0);
            tblQuery.Dock = DockStyle.Fill;
            tblQuery.Location = new Point(193, 95);
            tblQuery.Name = "tblQuery";
            tblQuery.RowCount = 1;
            tblQuery.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblQuery.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblQuery.Size = new Size(758, 234);
            tblQuery.TabIndex = 3;
            // 
            // txtQuery
            // 
            txtQuery.Dock = DockStyle.Fill;
            txtQuery.Location = new Point(0, 0);
            txtQuery.Margin = new Padding(0);
            txtQuery.Multiline = true;
            txtQuery.Name = "txtQuery";
            txtQuery.PlaceholderText = "Type Query Here";
            tblQuery.SetRowSpan(txtQuery, 2);
            txtQuery.Size = new Size(758, 234);
            txtQuery.TabIndex = 0;
            // 
            // frmSQLExecutor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(954, 727);
            Controls.Add(tblMain);
            Name = "frmSQLExecutor";
            Text = "SQL Executor";
            pnlServer.ResumeLayout(false);
            pnlServer.PerformLayout();
            pnlDatabase.ResumeLayout(false);
            pnlDatabase.PerformLayout();
            tblMain.ResumeLayout(false);
            tblQuery.ResumeLayout(false);
            tblQuery.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMain;
        private Panel pnlServer;
        private Panel pnlDatabase;
        private RadioButton optAzure;
        private RadioButton optLocal;
        private RadioButton optRecipe;
        private RadioButton optRecordKeeper;
        private Label lblDatabase;
        private Button btnRun;
        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblQuery;
        private TextBox txtQuery;
    }
}