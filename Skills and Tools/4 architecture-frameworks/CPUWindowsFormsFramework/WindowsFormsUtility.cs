using System.Data;


namespace CPUWindowsFormsFramework
{
    public class WindowsFormsUtility
    {
        static string deletecolumnname = "deletecol";

        public static void SetListBinding(ComboBox lst, DataTable sourcedt, DataTable? targetdt, string tablename)
        {
            lst.DataSource = sourcedt;
            lst.ValueMember = tablename + "Id";
            lst.DisplayMember = lst.Name.Substring(3);
            if (targetdt != null)
            {
                lst.DataBindings.Add("SelectedValue", targetdt, lst.ValueMember, false, DataSourceUpdateMode.OnPropertyChanged);
            }
        }
        public static void SetControlBinding(Control ctrl, BindingSource bindsource)
        {
            string propertyname = "";
            string columnname = "";
            string controlname = ctrl.Name;
            string controltype = controlname.Substring(0, 3);
            columnname = controlname.Substring(3);

            switch (controltype)
            {
                case "txt":
                case "lbl":
                    propertyname = "Text";
                    break;
                case "dtp":
                    propertyname = "Value";
                    break;
                case "chk":
                    propertyname = "Checked";
                    break;
            }

            if (propertyname != "" && columnname != "")
            {
                ctrl.DataBindings.Add(propertyname, bindsource, columnname, true, DataSourceUpdateMode.OnPropertyChanged);
            }
        }
        public static void FormatGridForDataList(DataGridView grid, string tablename, string columnnametext = "ListOrder")
        {
            grid.AllowUserToAddRows = false;
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewColumn c in grid.Columns)
            {
                if (c.Name.Contains(columnnametext) || c.Name.Contains("ListOrder"))
                {
                    c.Visible = false;
                }
            }
            DoFormatGrid(grid, tablename);
        }
        public static void FormatGridForEdit(DataGridView grid, string tablename)
        {
            grid.EditMode = DataGridViewEditMode.EditOnEnter;
            DoFormatGrid(grid, tablename);
        }
        private static void DoFormatGrid(DataGridView grid, string tablename)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.RowHeadersWidth = 25;
            foreach (DataGridViewColumn col in grid.Columns)
            {
                if (col.Name.EndsWith("Id"))
                {
                    col.Visible = false;
                }
            }
            string pkname = tablename + "Id";
            if (grid.Columns.Contains(pkname))
            {
                grid.Columns[pkname].Visible = false;
            }
            if (grid.Columns.Contains(deletecolumnname))
            {
                int colcount = grid.Columns.Count;
                grid.Columns[deletecolumnname].DisplayIndex = colcount - 1;
            }
        }
        public static int GetIdFromGrid(DataGridView grid, int rowindex, string columnname)
        {
            int id = 0;
            if (rowindex < 0)
            {
                return rowindex;
            }
            if (rowindex < grid.Rows.Count && grid.Columns.Contains(columnname) && grid.Rows[rowindex].Cells[columnname].Value != DBNull.Value)
            {
                if (grid.Rows[rowindex].Cells[columnname].Value is int)
                {
                    id = (int)grid.Rows[rowindex].Cells[columnname].Value;
                }
            }

            return id;
        }
        public static int GetIdFromComboBox(ComboBox lst)
        {
            int value = 0;
            if (lst.SelectedValue != null && lst.SelectedValue is int)
            {
                value = (int)lst.SelectedValue;
            }
            return value;
        }
        public static void AddComboBoxToGrid(DataGridView grid, DataTable datasource, string tablename, string displaymember)
        {
            DataGridViewComboBoxColumn c = new();
            c.DataSource = datasource;
            c.DisplayMember = displaymember;
            c.ValueMember = tablename + "Id";
            c.DataPropertyName = c.ValueMember;
            c.HeaderText = tablename;
            grid.Columns.Insert(0, c);
        }
        public static void AddDeleteButtonToGrid(DataGridView grid, string deletecolname)
        {
            if (!grid.Columns.Contains(deletecolname))
            {
                grid.Columns.Add(new DataGridViewButtonColumn() { Text = "X", HeaderText = "Delete", Name = deletecolname, UseColumnTextForButtonValue = true });
            }
        }

        public static bool IsFormOpen(Type formtype, int pkvalue = 0)
        {
            bool exists = false;
            foreach (Form frm in Application.OpenForms)
            {
                int frmpkvalue = 0;
                if (frm.Tag != null && frm.Tag is int)
                {
                    frmpkvalue = (int)frm.Tag;
                }
                if (frm.GetType() == formtype && frmpkvalue == pkvalue)
                {
                    frm.Activate();
                    exists = true;
                    break;
                }
            }
            return exists;
        }
        public static void SetupNav(ToolStrip ts)
        {
            ts.Items.Clear();
            foreach (Form f in Application.OpenForms)
            {
                if (f.IsMdiContainer == false)
                {
                    ToolStripButton btn = new();
                    btn.Text = f.Text;
                    btn.Tag = f;
                    btn.Click += Btn_Click;
                    ts.Items.Add(btn);
                    ts.Items.Add(new ToolStripSeparator());
                }
            }
        }
        private static void Btn_Click(object? sender, EventArgs e)
        {
            if (sender != null && sender is ToolStripButton)
            {
                ToolStripButton btn = (ToolStripButton)sender;
                if (btn.Tag != null && btn.Tag is Form)
                {
                    ((Form)btn.Tag).Activate();
                }
            }
        }

        public static void HandleNumberOnlyTextBoxInput(object sender, KeyPressEventArgs e, bool allowdecimals = false)
        {
            // Allow control characters
            if (char.IsControl(e.KeyChar))
            {
                return; // Allow control characters like backspace
            }

            // Check if the character is a digit
            if (char.IsDigit(e.KeyChar))
            {
                return; // Allow digits
            }

            // Allow decimal point if specified
            if (allowdecimals && e.KeyChar == '.')
            {
                // Check if there's already a decimal point in the textbox
                var textBox = sender as TextBox;
                if (textBox != null && textBox.Text.Contains("."))
                {
                    e.Handled = true; // Suppress if already has a decimal point
                    MessageBox.Show("Please enter a valid decimal number.", "Invalid input");
                }
                return; // Allow decimal point
            }

            // If it reaches here, the character is invalid
            e.Handled = true; // Suppress invalid character
            MessageBox.Show("Please enter a valid number.", "Invalid input");
        
        }

        public static void ManageAvailableButtons(bool enable, List<Button> lstbtn)
        {
            foreach (Control c in lstbtn)
            {
                c.Enabled = enable;
            }
        }
    }
}
