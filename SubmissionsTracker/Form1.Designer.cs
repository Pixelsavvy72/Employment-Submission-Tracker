namespace SubmissionsTracker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.submissionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.submissionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.submissionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.SubmissionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBoxNewSubmission = new System.Windows.Forms.GroupBox();
            this.TextBoxNotes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxCompanyWeb = new System.Windows.Forms.TextBox();
            this.TextBoxListingWeb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxJobBoardId = new System.Windows.Forms.TextBox();
            this.TextBoxJobBoard = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxContactPerson = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonAddSubmission = new System.Windows.Forms.Button();
            this.TextBoxSubmittedThru = new System.Windows.Forms.TextBox();
            this.TextBoxLocation = new System.Windows.Forms.TextBox();
            this.TextBoxPosition = new System.Windows.Forms.TextBox();
            this.TextBoxCompany = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.submissionBindingNavigator)).BeginInit();
            this.submissionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.submissionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubmissionDataGridView)).BeginInit();
            this.GroupBoxNewSubmission.SuspendLayout();
            this.SuspendLayout();
            // 
            // submissionBindingNavigator
            // 
            this.submissionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.submissionBindingNavigator.BindingSource = this.submissionBindingSource;
            this.submissionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.submissionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.submissionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.submissionBindingNavigatorSaveItem});
            this.submissionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.submissionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.submissionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.submissionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.submissionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.submissionBindingNavigator.Name = "submissionBindingNavigator";
            this.submissionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.submissionBindingNavigator.Size = new System.Drawing.Size(2112, 25);
            this.submissionBindingNavigator.TabIndex = 0;
            this.submissionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // submissionBindingSource
            // 
            this.submissionBindingSource.DataSource = typeof(SubmissionsTracker.Submission);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // submissionBindingNavigatorSaveItem
            // 
            this.submissionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.submissionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("submissionBindingNavigatorSaveItem.Image")));
            this.submissionBindingNavigatorSaveItem.Name = "submissionBindingNavigatorSaveItem";
            this.submissionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.submissionBindingNavigatorSaveItem.Text = "Save Data";
            this.submissionBindingNavigatorSaveItem.Click += new System.EventHandler(this.submissionBindingNavigatorSaveItem_Click);
            // 
            // SubmissionDataGridView
            // 
            this.SubmissionDataGridView.AutoGenerateColumns = false;
            this.SubmissionDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.SubmissionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubmissionDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SubmissionDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.SubmissionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubmissionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.SubmissionDataGridView.DataSource = this.submissionBindingSource;
            this.SubmissionDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SubmissionDataGridView.Location = new System.Drawing.Point(20, 278);
            this.SubmissionDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.SubmissionDataGridView.Name = "SubmissionDataGridView";
            this.SubmissionDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.SubmissionDataGridView.Size = new System.Drawing.Size(1280, 950);
            this.SubmissionDataGridView.TabIndex = 200;
            this.SubmissionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubmissionDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateSubmitted";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date Submitted";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Reply";
            this.dataGridViewTextBoxColumn3.HeaderText = "Reply";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Company";
            this.dataGridViewTextBoxColumn4.HeaderText = "Company";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn5.HeaderText = "Position";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ContactPerson";
            this.dataGridViewTextBoxColumn6.HeaderText = "Contact Person";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Location";
            this.dataGridViewTextBoxColumn7.HeaderText = "Location";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "JobBoard";
            this.dataGridViewTextBoxColumn8.HeaderText = "Job Board";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "JobBoardId";
            this.dataGridViewTextBoxColumn9.HeaderText = "Job Board Id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SubmittedThrough";
            this.dataGridViewTextBoxColumn10.HeaderText = "Submitted Through";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ListingWebAddress";
            this.dataGridViewTextBoxColumn11.HeaderText = "Listing Web Address";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CompanyWebAddress";
            this.dataGridViewTextBoxColumn12.HeaderText = "Company Web Address";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn13.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // GroupBoxNewSubmission
            // 
            this.GroupBoxNewSubmission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(94)))), ((int)(((byte)(145)))));
            this.GroupBoxNewSubmission.Controls.Add(this.TextBoxNotes);
            this.GroupBoxNewSubmission.Controls.Add(this.label9);
            this.GroupBoxNewSubmission.Controls.Add(this.TextBoxCompanyWeb);
            this.GroupBoxNewSubmission.Controls.Add(this.TextBoxListingWeb);
            this.GroupBoxNewSubmission.Controls.Add(this.label8);
            this.GroupBoxNewSubmission.Controls.Add(this.label7);
            this.GroupBoxNewSubmission.Controls.Add(this.label6);
            this.GroupBoxNewSubmission.Controls.Add(this.TextBoxJobBoardId);
            this.GroupBoxNewSubmission.Controls.Add(this.TextBoxJobBoard);
            this.GroupBoxNewSubmission.Controls.Add(this.label5);
            this.GroupBoxNewSubmission.Controls.Add(this.label4);
            this.GroupBoxNewSubmission.Controls.Add(this.LocationLabel);
            this.GroupBoxNewSubmission.Controls.Add(this.label3);
            this.GroupBoxNewSubmission.Controls.Add(this.label2);
            this.GroupBoxNewSubmission.Controls.Add(this.TextBoxContactPerson);
            this.GroupBoxNewSubmission.Controls.Add(this.label1);
            this.GroupBoxNewSubmission.Controls.Add(this.ButtonAddSubmission);
            this.GroupBoxNewSubmission.Controls.Add(this.TextBoxSubmittedThru);
            this.GroupBoxNewSubmission.Controls.Add(this.TextBoxLocation);
            this.GroupBoxNewSubmission.Controls.Add(this.TextBoxPosition);
            this.GroupBoxNewSubmission.Controls.Add(this.TextBoxCompany);
            this.GroupBoxNewSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBoxNewSubmission.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxNewSubmission.ForeColor = System.Drawing.Color.Gainsboro;
            this.GroupBoxNewSubmission.Location = new System.Drawing.Point(19, 60);
            this.GroupBoxNewSubmission.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBoxNewSubmission.Name = "GroupBoxNewSubmission";
            this.GroupBoxNewSubmission.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBoxNewSubmission.Size = new System.Drawing.Size(1280, 202);
            this.GroupBoxNewSubmission.TabIndex = 2;
            this.GroupBoxNewSubmission.TabStop = false;
            this.GroupBoxNewSubmission.Text = "Add New Submission";
            // 
            // TextBoxNotes
            // 
            this.TextBoxNotes.Location = new System.Drawing.Point(896, 140);
            this.TextBoxNotes.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxNotes.Name = "TextBoxNotes";
            this.TextBoxNotes.Size = new System.Drawing.Size(363, 32);
            this.TextBoxNotes.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(894, 119);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Notes";
            // 
            // TextBoxCompanyWeb
            // 
            this.TextBoxCompanyWeb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBoxCompanyWeb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextBoxCompanyWeb.Location = new System.Drawing.Point(467, 140);
            this.TextBoxCompanyWeb.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxCompanyWeb.Name = "TextBoxCompanyWeb";
            this.TextBoxCompanyWeb.Size = new System.Drawing.Size(420, 32);
            this.TextBoxCompanyWeb.TabIndex = 8;
            // 
            // TextBoxListingWeb
            // 
            this.TextBoxListingWeb.Location = new System.Drawing.Point(162, 140);
            this.TextBoxListingWeb.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxListingWeb.Name = "TextBoxListingWeb";
            this.TextBoxListingWeb.Size = new System.Drawing.Size(296, 32);
            this.TextBoxListingWeb.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(463, 119);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Company Web Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(159, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Listing Web Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(20, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 36);
            this.label6.TabIndex = 14;
            this.label6.Text = "Submitted\r\nThrough";
            // 
            // TextBoxJobBoardId
            // 
            this.TextBoxJobBoardId.Location = new System.Drawing.Point(1039, 71);
            this.TextBoxJobBoardId.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxJobBoardId.Name = "TextBoxJobBoardId";
            this.TextBoxJobBoardId.Size = new System.Drawing.Size(132, 32);
            this.TextBoxJobBoardId.TabIndex = 5;
            // 
            // TextBoxJobBoard
            // 
            this.TextBoxJobBoard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBoxJobBoard.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextBoxJobBoard.Location = new System.Drawing.Point(896, 71);
            this.TextBoxJobBoard.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxJobBoard.Name = "TextBoxJobBoard";
            this.TextBoxJobBoard.Size = new System.Drawing.Size(132, 32);
            this.TextBoxJobBoard.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(1035, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Job Board Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(892, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Job Board";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.LocationLabel.Location = new System.Drawing.Point(688, 49);
            this.LocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(63, 18);
            this.LocationLabel.TabIndex = 9;
            this.LocationLabel.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(466, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contact Person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(242, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Position";
            // 
            // TextBoxContactPerson
            // 
            this.TextBoxContactPerson.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBoxContactPerson.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextBoxContactPerson.Location = new System.Drawing.Point(467, 71);
            this.TextBoxContactPerson.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxContactPerson.Name = "TextBoxContactPerson";
            this.TextBoxContactPerson.Size = new System.Drawing.Size(213, 32);
            this.TextBoxContactPerson.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(19, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Company";
            // 
            // ButtonAddSubmission
            // 
            this.ButtonAddSubmission.BackColor = System.Drawing.Color.OliveDrab;
            this.ButtonAddSubmission.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(167)))), ((int)(((byte)(178)))));
            this.ButtonAddSubmission.FlatAppearance.BorderSize = 2;
            this.ButtonAddSubmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddSubmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ButtonAddSubmission.Location = new System.Drawing.Point(1179, 71);
            this.ButtonAddSubmission.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAddSubmission.Name = "ButtonAddSubmission";
            this.ButtonAddSubmission.Size = new System.Drawing.Size(80, 49);
            this.ButtonAddSubmission.TabIndex = 10;
            this.ButtonAddSubmission.Text = "Add";
            this.ButtonAddSubmission.UseVisualStyleBackColor = false;
            this.ButtonAddSubmission.Click += new System.EventHandler(this.ButtonAddSubmission_Click);
            // 
            // TextBoxSubmittedThru
            // 
            this.TextBoxSubmittedThru.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBoxSubmittedThru.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextBoxSubmittedThru.Location = new System.Drawing.Point(22, 140);
            this.TextBoxSubmittedThru.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxSubmittedThru.Name = "TextBoxSubmittedThru";
            this.TextBoxSubmittedThru.Size = new System.Drawing.Size(132, 32);
            this.TextBoxSubmittedThru.TabIndex = 6;
            // 
            // TextBoxLocation
            // 
            this.TextBoxLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBoxLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextBoxLocation.Location = new System.Drawing.Point(690, 71);
            this.TextBoxLocation.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxLocation.Name = "TextBoxLocation";
            this.TextBoxLocation.Size = new System.Drawing.Size(197, 32);
            this.TextBoxLocation.TabIndex = 3;
            // 
            // TextBoxPosition
            // 
            this.TextBoxPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBoxPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextBoxPosition.Location = new System.Drawing.Point(244, 71);
            this.TextBoxPosition.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPosition.Name = "TextBoxPosition";
            this.TextBoxPosition.Size = new System.Drawing.Size(213, 32);
            this.TextBoxPosition.TabIndex = 1;
            // 
            // TextBoxCompany
            // 
            this.TextBoxCompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TextBoxCompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextBoxCompany.Location = new System.Drawing.Point(22, 71);
            this.TextBoxCompany.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxCompany.Name = "TextBoxCompany";
            this.TextBoxCompany.Size = new System.Drawing.Size(213, 32);
            this.TextBoxCompany.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(2112, 762);
            this.Controls.Add(this.GroupBoxNewSubmission);
            this.Controls.Add(this.SubmissionDataGridView);
            this.Controls.Add(this.submissionBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Employment Submission Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.submissionBindingNavigator)).EndInit();
            this.submissionBindingNavigator.ResumeLayout(false);
            this.submissionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.submissionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubmissionDataGridView)).EndInit();
            this.GroupBoxNewSubmission.ResumeLayout(false);
            this.GroupBoxNewSubmission.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource submissionBindingSource;
        private System.Windows.Forms.BindingNavigator submissionBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton submissionBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView SubmissionDataGridView;
        private System.Windows.Forms.GroupBox GroupBoxNewSubmission;
        private System.Windows.Forms.TextBox TextBoxCompany;
        private System.Windows.Forms.Button ButtonAddSubmission;
        private System.Windows.Forms.TextBox TextBoxSubmittedThru;
        private System.Windows.Forms.TextBox TextBoxLocation;
        private System.Windows.Forms.TextBox TextBoxPosition;
        private System.Windows.Forms.TextBox TextBoxNotes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBoxCompanyWeb;
        private System.Windows.Forms.TextBox TextBoxListingWeb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxJobBoardId;
        private System.Windows.Forms.TextBox TextBoxJobBoard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxContactPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}

