namespace Learning_Courses_2
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
            this.tabs_component = new System.Windows.Forms.TabControl();
            this.tab_start = new System.Windows.Forms.TabPage();
            this.tab_courses = new System.Windows.Forms.TabPage();
            this.clearCourseFormBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.courseIdTxtBox = new System.Windows.Forms.TextBox();
            this.courseDescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.deleteCourseBtn = new System.Windows.Forms.Button();
            this.EditCourseBtn = new System.Windows.Forms.Button();
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.coursesTab_courseDataGrid = new System.Windows.Forms.DataGridView();
            this.courseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursedescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursecatagorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.p1g8DataSet = new Learning_Courses_2.p1g8DataSet();
            this.courseTypeTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CourseCategorieTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.courseNameTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_companies = new System.Windows.Forms.TabPage();
            this.companiesTab_companyDataGrid = new System.Windows.Forms.DataGridView();
            this.companyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.industryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.company_ClearBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();

            this.companyIdTxtBox = new System.Windows.Forms.TextBox();
            this.companyIndustryTxtBox = new System.Windows.Forms.TextBox();
            this.companyNameTxtBox = new System.Windows.Forms.TextBox();



            this.company_DeleteBtn = new System.Windows.Forms.Button();
            this.company_EditBtn = new System.Windows.Forms.Button();
            this.company_addBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new Learning_Courses_2.p1g8DataSetTableAdapters.CourseTableAdapter();
            this.tableAdapterManager = new Learning_Courses_2.p1g8DataSetTableAdapters.TableAdapterManager();
            this.p1g8DataSet1 = new Learning_Courses_2.p1g8DataSet();
            this.p1g8DataSet2 = new Learning_Courses_2.p1g8DataSet();
            this.companyTableAdapter = new Learning_Courses_2.p1g8DataSetTableAdapters.CompanyTableAdapter();
            this.tabs_component.SuspendLayout();
            this.tab_courses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesTab_courseDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1g8DataSet)).BeginInit();
            this.tab_companies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companiesTab_companyDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1g8DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1g8DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs_component
            // 
            this.tabs_component.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs_component.Controls.Add(this.tab_start);
            this.tabs_component.Controls.Add(this.tab_courses);
            this.tabs_component.Controls.Add(this.tab_companies);
            this.tabs_component.Location = new System.Drawing.Point(12, 12);
            this.tabs_component.Name = "tabs_component";
            this.tabs_component.SelectedIndex = 0;
            this.tabs_component.Size = new System.Drawing.Size(1536, 802);
            this.tabs_component.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabs_component.TabIndex = 2;
            this.tabs_component.Selected += new System.Windows.Forms.TabControlEventHandler(this.Tabs_SelectedIndexChanged);
            // 
            // tab_start
            // 
            this.tab_start.Location = new System.Drawing.Point(4, 29);
            this.tab_start.Name = "tab_start";
            this.tab_start.Padding = new System.Windows.Forms.Padding(3);
            this.tab_start.Size = new System.Drawing.Size(1528, 769);
            this.tab_start.TabIndex = 0;
            this.tab_start.Text = "Start";
            this.tab_start.UseVisualStyleBackColor = true;
            // 
            // tab_courses
            // 
            this.tab_courses.Controls.Add(this.clearCourseFormBtn);
            this.tab_courses.Controls.Add(this.label5);
            this.tab_courses.Controls.Add(this.courseIdTxtBox);
            this.tab_courses.Controls.Add(this.courseDescriptionTxtBox);
            this.tab_courses.Controls.Add(this.deleteCourseBtn);
            this.tab_courses.Controls.Add(this.EditCourseBtn);
            this.tab_courses.Controls.Add(this.addCourseBtn);
            this.tab_courses.Controls.Add(this.coursesTab_courseDataGrid);
            this.tab_courses.Controls.Add(this.courseTypeTxtBox);
            this.tab_courses.Controls.Add(this.label4);
            this.tab_courses.Controls.Add(this.CourseCategorieTxtBox);
            this.tab_courses.Controls.Add(this.label1);
            this.tab_courses.Controls.Add(this.label3);
            this.tab_courses.Controls.Add(this.courseNameTxtBox);
            this.tab_courses.Controls.Add(this.label2);
            this.tab_courses.Location = new System.Drawing.Point(4, 29);
            this.tab_courses.Name = "tab_courses";
            this.tab_courses.Padding = new System.Windows.Forms.Padding(3);
            this.tab_courses.Size = new System.Drawing.Size(1528, 769);
            this.tab_courses.TabIndex = 1;
            this.tab_courses.Text = "Courses";
            this.tab_courses.UseVisualStyleBackColor = true;
            // 
            // clearCourseFormBtn
            // 
            this.clearCourseFormBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.clearCourseFormBtn.Location = new System.Drawing.Point(415, 539);
            this.clearCourseFormBtn.Name = "clearCourseFormBtn";
            this.clearCourseFormBtn.Size = new System.Drawing.Size(100, 65);
            this.clearCourseFormBtn.TabIndex = 18;
            this.clearCourseFormBtn.Text = "Clear";
            this.clearCourseFormBtn.UseVisualStyleBackColor = false;
            this.clearCourseFormBtn.Click += new System.EventHandler(this.onClearCourseBtn);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Id";
            // 
            // courseIdTxtBox
            // 
            this.courseIdTxtBox.Location = new System.Drawing.Point(41, 63);
            this.courseIdTxtBox.Name = "courseIdTxtBox";
            this.courseIdTxtBox.ReadOnly = true;
            this.courseIdTxtBox.Size = new System.Drawing.Size(474, 26);
            this.courseIdTxtBox.TabIndex = 17;
            // 
            // courseDescriptionTxtBox
            // 
            this.courseDescriptionTxtBox.Location = new System.Drawing.Point(41, 241);
            this.courseDescriptionTxtBox.Multiline = true;
            this.courseDescriptionTxtBox.Name = "courseDescriptionTxtBox";
            this.courseDescriptionTxtBox.Size = new System.Drawing.Size(474, 124);
            this.courseDescriptionTxtBox.TabIndex = 15;
            // 
            // deleteCourseBtn
            // 
            this.deleteCourseBtn.BackColor = System.Drawing.Color.Red;
            this.deleteCourseBtn.Location = new System.Drawing.Point(290, 539);
            this.deleteCourseBtn.Name = "deleteCourseBtn";
            this.deleteCourseBtn.Size = new System.Drawing.Size(100, 65);
            this.deleteCourseBtn.TabIndex = 13;
            this.deleteCourseBtn.Text = "Delete";
            this.deleteCourseBtn.UseVisualStyleBackColor = false;
            this.deleteCourseBtn.Click += new System.EventHandler(this.onDeleteCourseBtn);
            // 
            // EditCourseBtn
            // 
            this.EditCourseBtn.BackColor = System.Drawing.Color.Yellow;
            this.EditCourseBtn.Location = new System.Drawing.Point(156, 539);
            this.EditCourseBtn.Name = "EditCourseBtn";
            this.EditCourseBtn.Size = new System.Drawing.Size(100, 65);
            this.EditCourseBtn.TabIndex = 12;
            this.EditCourseBtn.Text = "Edit";
            this.EditCourseBtn.UseVisualStyleBackColor = false;
            this.EditCourseBtn.Click += new System.EventHandler(this.onEditCourseBtn);
            // 
            // addCourseBtn
            // 
            this.addCourseBtn.BackColor = System.Drawing.Color.Lime;
            this.addCourseBtn.Location = new System.Drawing.Point(41, 539);
            this.addCourseBtn.Name = "addCourseBtn";
            this.addCourseBtn.Size = new System.Drawing.Size(100, 65);
            this.addCourseBtn.TabIndex = 11;
            this.addCourseBtn.Text = "Add";
            this.addCourseBtn.UseVisualStyleBackColor = false;
            this.addCourseBtn.Click += new System.EventHandler(this.onAddCourseBtn);
            // 
            // coursesTab_courseDataGrid
            // 
            this.coursesTab_courseDataGrid.AllowUserToAddRows = false;
            this.coursesTab_courseDataGrid.AllowUserToDeleteRows = false;
            this.coursesTab_courseDataGrid.AutoGenerateColumns = false;
            this.coursesTab_courseDataGrid.ColumnHeadersHeight = 34;
            this.coursesTab_courseDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseidDataGridViewTextBoxColumn,
            this.coursenameDataGridViewTextBoxColumn,
            this.coursedescriptionDataGridViewTextBoxColumn,
            this.coursecatagorieDataGridViewTextBoxColumn,
            this.coursetypeDataGridViewTextBoxColumn});
            this.coursesTab_courseDataGrid.DataSource = this.courseBindingSource2;
            this.coursesTab_courseDataGrid.Location = new System.Drawing.Point(686, 22);
            this.coursesTab_courseDataGrid.Name = "coursesTab_courseDataGrid";
            this.coursesTab_courseDataGrid.ReadOnly = true;
            this.coursesTab_courseDataGrid.RowHeadersWidth = 62;
            this.coursesTab_courseDataGrid.RowTemplate.Height = 28;
            this.coursesTab_courseDataGrid.Size = new System.Drawing.Size(816, 579);
            this.coursesTab_courseDataGrid.TabIndex = 2;
            this.coursesTab_courseDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.coursesTab_courseDataGrid_CellContentClick);
            // 
            // courseidDataGridViewTextBoxColumn
            // 
            this.courseidDataGridViewTextBoxColumn.DataPropertyName = "course_id";
            this.courseidDataGridViewTextBoxColumn.HeaderText = "course_id";
            this.courseidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.courseidDataGridViewTextBoxColumn.Name = "courseidDataGridViewTextBoxColumn";
            this.courseidDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseidDataGridViewTextBoxColumn.Width = 150;
            // 
            // coursenameDataGridViewTextBoxColumn
            // 
            this.coursenameDataGridViewTextBoxColumn.DataPropertyName = "course_name";
            this.coursenameDataGridViewTextBoxColumn.HeaderText = "course_name";
            this.coursenameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.coursenameDataGridViewTextBoxColumn.Name = "coursenameDataGridViewTextBoxColumn";
            this.coursenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.coursenameDataGridViewTextBoxColumn.Width = 150;
            // 
            // coursedescriptionDataGridViewTextBoxColumn
            // 
            this.coursedescriptionDataGridViewTextBoxColumn.DataPropertyName = "course_description";
            this.coursedescriptionDataGridViewTextBoxColumn.HeaderText = "course_description";
            this.coursedescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.coursedescriptionDataGridViewTextBoxColumn.Name = "coursedescriptionDataGridViewTextBoxColumn";
            this.coursedescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.coursedescriptionDataGridViewTextBoxColumn.Width = 150;
            // 
            // coursecatagorieDataGridViewTextBoxColumn
            // 
            this.coursecatagorieDataGridViewTextBoxColumn.DataPropertyName = "course_catagorie";
            this.coursecatagorieDataGridViewTextBoxColumn.HeaderText = "course_catagorie";
            this.coursecatagorieDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.coursecatagorieDataGridViewTextBoxColumn.Name = "coursecatagorieDataGridViewTextBoxColumn";
            this.coursecatagorieDataGridViewTextBoxColumn.ReadOnly = true;
            this.coursecatagorieDataGridViewTextBoxColumn.Width = 150;
            // 
            // coursetypeDataGridViewTextBoxColumn
            // 
            this.coursetypeDataGridViewTextBoxColumn.DataPropertyName = "course_type";
            this.coursetypeDataGridViewTextBoxColumn.HeaderText = "course_type";
            this.coursetypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.coursetypeDataGridViewTextBoxColumn.Name = "coursetypeDataGridViewTextBoxColumn";
            this.coursetypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.coursetypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // courseBindingSource2
            // 
            this.courseBindingSource2.DataMember = "Course";
            this.courseBindingSource2.DataSource = this.p1g8DataSet;
            // 
            // p1g8DataSet
            // 
            this.p1g8DataSet.DataSetName = "p1g8DataSet";
            this.p1g8DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTypeTxtBox
            // 
            this.courseTypeTxtBox.Location = new System.Drawing.Point(41, 493);
            this.courseTypeTxtBox.Name = "courseTypeTxtBox";
            this.courseTypeTxtBox.Size = new System.Drawing.Size(474, 26);
            this.courseTypeTxtBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Type";
            // 
            // CourseCategorieTxtBox
            // 
            this.CourseCategorieTxtBox.Location = new System.Drawing.Point(41, 412);
            this.CourseCategorieTxtBox.Name = "CourseCategorieTxtBox";
            this.CourseCategorieTxtBox.Size = new System.Drawing.Size(474, 26);
            this.CourseCategorieTxtBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "categorie";
            // 
            // courseNameTxtBox
            // 
            this.courseNameTxtBox.Location = new System.Drawing.Point(41, 151);
            this.courseNameTxtBox.Name = "courseNameTxtBox";
            this.courseNameTxtBox.Size = new System.Drawing.Size(474, 26);
            this.courseNameTxtBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // tab_companies
            // 
            this.tab_companies.Controls.Add(this.companiesTab_companyDataGrid);
            this.tab_companies.Controls.Add(this.company_ClearBtn);
            this.tab_companies.Controls.Add(this.label6);
            this.tab_companies.Controls.Add(this.companyIdTxtBox);
            this.tab_companies.Controls.Add(this.company_DeleteBtn);
            this.tab_companies.Controls.Add(this.company_EditBtn);
            this.tab_companies.Controls.Add(this.company_addBtn);
            this.tab_companies.Controls.Add(this.companyIndustryTxtBox);
            this.tab_companies.Controls.Add(this.label8);
            this.tab_companies.Controls.Add(this.label9);
            this.tab_companies.Controls.Add(this.companyNameTxtBox);
            this.tab_companies.Location = new System.Drawing.Point(4, 29);
            this.tab_companies.Name = "tab_companies";
            this.tab_companies.Padding = new System.Windows.Forms.Padding(3);
            this.tab_companies.Size = new System.Drawing.Size(1528, 769);
            this.tab_companies.TabIndex = 2;
            this.tab_companies.Text = "Companies";
            this.tab_companies.UseVisualStyleBackColor = true;
            // 
            // companiesTab_companyDataGrid
            // 
            this.companiesTab_companyDataGrid.AllowUserToAddRows = false;
            this.companiesTab_companyDataGrid.AllowUserToDeleteRows = false;
            this.companiesTab_companyDataGrid.AutoGenerateColumns = false;
            this.companiesTab_companyDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companiesTab_companyDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyidDataGridViewTextBoxColumn,
            this.companynameDataGridViewTextBoxColumn,
            this.industryDataGridViewTextBoxColumn});
            this.companiesTab_companyDataGrid.DataSource = this.companyBindingSource;
            this.companiesTab_companyDataGrid.Location = new System.Drawing.Point(900, 94);
            this.companiesTab_companyDataGrid.Name = "companiesTab_companyDataGrid";
            this.companiesTab_companyDataGrid.ReadOnly = true;
            this.companiesTab_companyDataGrid.RowHeadersWidth = 62;
            this.companiesTab_companyDataGrid.RowTemplate.Height = 28;
            this.companiesTab_companyDataGrid.Size = new System.Drawing.Size(519, 523);
            this.companiesTab_companyDataGrid.TabIndex = 33;
            this.companiesTab_companyDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.companiesTab_companyDataGrid_CellContentClick);
            // 
            // companyidDataGridViewTextBoxColumn
            // 
            this.companyidDataGridViewTextBoxColumn.DataPropertyName = "company_id";
            this.companyidDataGridViewTextBoxColumn.HeaderText = "company_id";
            this.companyidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.companyidDataGridViewTextBoxColumn.Name = "companyidDataGridViewTextBoxColumn";
            this.companyidDataGridViewTextBoxColumn.ReadOnly = true;
            this.companyidDataGridViewTextBoxColumn.Width = 150;
            // 
            // companynameDataGridViewTextBoxColumn
            // 
            this.companynameDataGridViewTextBoxColumn.DataPropertyName = "company_name";
            this.companynameDataGridViewTextBoxColumn.HeaderText = "company_name";
            this.companynameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.companynameDataGridViewTextBoxColumn.Name = "companynameDataGridViewTextBoxColumn";
            this.companynameDataGridViewTextBoxColumn.ReadOnly = true;
            this.companynameDataGridViewTextBoxColumn.Width = 150;
            // 
            // industryDataGridViewTextBoxColumn
            // 
            this.industryDataGridViewTextBoxColumn.DataPropertyName = "industry";
            this.industryDataGridViewTextBoxColumn.HeaderText = "industry";
            this.industryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.industryDataGridViewTextBoxColumn.Name = "industryDataGridViewTextBoxColumn";
            this.industryDataGridViewTextBoxColumn.ReadOnly = true;
            this.industryDataGridViewTextBoxColumn.Width = 150;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.p1g8DataSet;
            // 
            // company_ClearBtn
            // 
            this.company_ClearBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.company_ClearBtn.Location = new System.Drawing.Point(440, 552);
            this.company_ClearBtn.Name = "company_ClearBtn";
            this.company_ClearBtn.Size = new System.Drawing.Size(100, 65);
            this.company_ClearBtn.TabIndex = 32;
            this.company_ClearBtn.Text = "Clear";
            this.company_ClearBtn.UseVisualStyleBackColor = false;
            this.company_ClearBtn.Click += new System.EventHandler(this.company_ClearBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Id";
            // 
            // companyIdTxtBox
            // 
            this.companyIdTxtBox.Location = new System.Drawing.Point(64, 94);
            this.companyIdTxtBox.Name = "companyIdTxtBox";
            this.companyIdTxtBox.ReadOnly = true;
            this.companyIdTxtBox.Size = new System.Drawing.Size(474, 26);
            this.companyIdTxtBox.TabIndex = 31;
            // 
            // company_DeleteBtn
            // 
            this.company_DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.company_DeleteBtn.Location = new System.Drawing.Point(315, 552);
            this.company_DeleteBtn.Name = "company_DeleteBtn";
            this.company_DeleteBtn.Size = new System.Drawing.Size(100, 65);
            this.company_DeleteBtn.TabIndex = 28;
            this.company_DeleteBtn.Text = "Delete";
            this.company_DeleteBtn.UseVisualStyleBackColor = false;
            this.company_DeleteBtn.Click += new System.EventHandler(this.company_DeleteBtn_Click);
            // 
            // company_EditBtn
            // 
            this.company_EditBtn.BackColor = System.Drawing.Color.Yellow;
            this.company_EditBtn.Location = new System.Drawing.Point(181, 552);
            this.company_EditBtn.Name = "company_EditBtn";
            this.company_EditBtn.Size = new System.Drawing.Size(100, 65);
            this.company_EditBtn.TabIndex = 27;
            this.company_EditBtn.Text = "Edit";
            this.company_EditBtn.UseVisualStyleBackColor = false;
            this.company_EditBtn.Click += new System.EventHandler(this.company_EditBtn_Click);
            // 
            // company_addBtn
            // 
            this.company_addBtn.BackColor = System.Drawing.Color.Lime;
            this.company_addBtn.Location = new System.Drawing.Point(66, 552);
            this.company_addBtn.Name = "company_addBtn";
            this.company_addBtn.Size = new System.Drawing.Size(100, 65);
            this.company_addBtn.TabIndex = 26;
            this.company_addBtn.Text = "Add";
            this.company_addBtn.UseVisualStyleBackColor = false;
            this.company_addBtn.Click += new System.EventHandler(this.company_addBtn_Click);
            // 
            // companyIndustryTxtBox
            // 
            this.companyIndustryTxtBox.Location = new System.Drawing.Point(64, 272);
            this.companyIndustryTxtBox.Name = "companyIndustryTxtBox";
            this.companyIndustryTxtBox.Size = new System.Drawing.Size(474, 26);
            this.companyIndustryTxtBox.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Industry";
            // 
            // companyNameTxtBox
            // 
            this.companyNameTxtBox.Location = new System.Drawing.Point(64, 182);
            this.companyNameTxtBox.Name = "companyNameTxtBox";
            this.companyNameTxtBox.Size = new System.Drawing.Size(474, 26);
            this.companyNameTxtBox.TabIndex = 20;
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataMember = "Course";
            this.courseBindingSource1.DataSource = this.p1g8DataSet;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.p1g8DataSet;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.CountriesTableAdapter = null;
            this.tableAdapterManager.Course_InstanceTableAdapter = null;
            this.tableAdapterManager.CourseTableAdapter = this.courseTableAdapter;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.TutorTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Learning_Courses_2.p1g8DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // p1g8DataSet1
            // 
            this.p1g8DataSet1.DataSetName = "p1g8DataSet";
            this.p1g8DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p1g8DataSet2
            // 
            this.p1g8DataSet2.DataSetName = "p1g8DataSet";
            this.p1g8DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 834);
            this.Controls.Add(this.tabs_component);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.tab_coures_FormLoad);
            this.tabs_component.ResumeLayout(false);
            this.tab_courses.ResumeLayout(false);
            this.tab_courses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesTab_courseDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1g8DataSet)).EndInit();
            this.tab_companies.ResumeLayout(false);
            this.tab_companies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companiesTab_companyDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1g8DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1g8DataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabs_component;
        private System.Windows.Forms.TabPage tab_start;
        private System.Windows.Forms.TabPage tab_courses;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addCourseBtn;
        private System.Windows.Forms.Label label4;
        private p1g8DataSet p1g8DataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private p1g8DataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private p1g8DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private p1g8DataSet p1g8DataSet1;
        private System.Windows.Forms.DataGridView coursesTab_courseDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursedescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursecatagorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource courseBindingSource2;
        private p1g8DataSet p1g8DataSet2;
        private System.Windows.Forms.Button EditCourseBtn;
        private System.Windows.Forms.Button deleteCourseBtn;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.TextBox courseDescriptionTxtBox;
        private System.Windows.Forms.TextBox courseTypeTxtBox;
        private System.Windows.Forms.TextBox courseNameTxtBox;
        private System.Windows.Forms.TextBox CourseCategorieTxtBox;
        private System.Windows.Forms.TextBox courseIdTxtBox;
        private System.Windows.Forms.Button clearCourseFormBtn;
        private System.Windows.Forms.TabPage tab_companies;
        private System.Windows.Forms.Button company_ClearBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox companyIdTxtBox;
        private System.Windows.Forms.Button company_DeleteBtn;
        private System.Windows.Forms.Button company_EditBtn;
        private System.Windows.Forms.Button company_addBtn;
        private System.Windows.Forms.TextBox companyIndustryTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox companyNameTxtBox;
        private System.Windows.Forms.DataGridView companiesTab_companyDataGrid;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private p1g8DataSetTableAdapters.CompanyTableAdapter companyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn industryDataGridViewTextBoxColumn;
    }
}

