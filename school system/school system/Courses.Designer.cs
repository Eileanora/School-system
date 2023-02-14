namespace school_system
{
    partial class Courses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Courses));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StudentGrade_TextBox = new System.Windows.Forms.TextBox();
            this.StudentPh_TextBox = new System.Windows.Forms.TextBox();
            this.StudentPh_label = new System.Windows.Forms.Label();
            this.StudentGrade_label = new System.Windows.Forms.Label();
            this.StudentName_TextBox = new System.Windows.Forms.TextBox();
            this.StudentName_label = new System.Windows.Forms.Label();
            this.DataGrideView_CoursesView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectTeacher_ComboBox = new System.Windows.Forms.ComboBox();
            this.SelectGrade_ComboBox = new System.Windows.Forms.ComboBox();
            this.Teacher_Label = new System.Windows.Forms.Label();
            this.Grade_Label = new System.Windows.Forms.Label();
            this.Course_Delete_Button = new DevExpress.XtraEditors.SimpleButton();
            this.Course_Update_Button = new DevExpress.XtraEditors.SimpleButton();
            this.Course_Insert_Button = new DevExpress.XtraEditors.SimpleButton();
            this.Course_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Course_SearchBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DataGrideView_Courses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrideView_CoursesView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrideView_Courses)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(73, 67, 73, 67);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(7);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 801;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1191, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "الكورسات";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 679);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(7);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1191, 30);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox2);
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 193);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1191, 486);
            this.panelControl1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.StudentGrade_TextBox);
            this.groupBox2.Controls.Add(this.StudentPh_TextBox);
            this.groupBox2.Controls.Add(this.StudentPh_label);
            this.groupBox2.Controls.Add(this.StudentGrade_label);
            this.groupBox2.Controls.Add(this.StudentName_TextBox);
            this.groupBox2.Controls.Add(this.StudentName_label);
            this.groupBox2.Controls.Add(this.DataGrideView_CoursesView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Font = new System.Drawing.Font("GE SS Two Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox2.Location = new System.Drawing.Point(12, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 482);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "كورسات الطالب";
            // 
            // StudentGrade_TextBox
            // 
            this.StudentGrade_TextBox.Location = new System.Drawing.Point(269, 92);
            this.StudentGrade_TextBox.Name = "StudentGrade_TextBox";
            this.StudentGrade_TextBox.Size = new System.Drawing.Size(222, 38);
            this.StudentGrade_TextBox.TabIndex = 8;
            // 
            // StudentPh_TextBox
            // 
            this.StudentPh_TextBox.Location = new System.Drawing.Point(269, 149);
            this.StudentPh_TextBox.Name = "StudentPh_TextBox";
            this.StudentPh_TextBox.Size = new System.Drawing.Size(222, 38);
            this.StudentPh_TextBox.TabIndex = 7;
            // 
            // StudentPh_label
            // 
            this.StudentPh_label.AutoSize = true;
            this.StudentPh_label.Location = new System.Drawing.Point(539, 149);
            this.StudentPh_label.Name = "StudentPh_label";
            this.StudentPh_label.Size = new System.Drawing.Size(134, 31);
            this.StudentPh_label.TabIndex = 6;
            this.StudentPh_label.Text = "رقم الهاتف";
            // 
            // StudentGrade_label
            // 
            this.StudentGrade_label.AutoSize = true;
            this.StudentGrade_label.Location = new System.Drawing.Point(572, 99);
            this.StudentGrade_label.Name = "StudentGrade_label";
            this.StudentGrade_label.Size = new System.Drawing.Size(81, 31);
            this.StudentGrade_label.TabIndex = 5;
            this.StudentGrade_label.Text = "الفرقة";
            // 
            // StudentName_TextBox
            // 
            this.StudentName_TextBox.Location = new System.Drawing.Point(269, 37);
            this.StudentName_TextBox.Name = "StudentName_TextBox";
            this.StudentName_TextBox.Size = new System.Drawing.Size(222, 38);
            this.StudentName_TextBox.TabIndex = 4;
            // 
            // StudentName_label
            // 
            this.StudentName_label.AutoSize = true;
            this.StudentName_label.Location = new System.Drawing.Point(532, 44);
            this.StudentName_label.Name = "StudentName_label";
            this.StudentName_label.Size = new System.Drawing.Size(141, 31);
            this.StudentName_label.TabIndex = 3;
            this.StudentName_label.Text = "اسم الطالب";
            // 
            // DataGrideView_CoursesView
            // 
            this.DataGrideView_CoursesView.AllowUserToAddRows = false;
            this.DataGrideView_CoursesView.AllowUserToDeleteRows = false;
            this.DataGrideView_CoursesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrideView_CoursesView.Location = new System.Drawing.Point(6, 213);
            this.DataGrideView_CoursesView.Name = "DataGrideView_CoursesView";
            this.DataGrideView_CoursesView.ReadOnly = true;
            this.DataGrideView_CoursesView.RowHeadersWidth = 51;
            this.DataGrideView_CoursesView.RowTemplate.Height = 24;
            this.DataGrideView_CoursesView.Size = new System.Drawing.Size(681, 237);
            this.DataGrideView_CoursesView.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectTeacher_ComboBox);
            this.groupBox1.Controls.Add(this.SelectGrade_ComboBox);
            this.groupBox1.Controls.Add(this.Teacher_Label);
            this.groupBox1.Controls.Add(this.Grade_Label);
            this.groupBox1.Controls.Add(this.Course_Delete_Button);
            this.groupBox1.Controls.Add(this.Course_Update_Button);
            this.groupBox1.Controls.Add(this.Course_Insert_Button);
            this.groupBox1.Controls.Add(this.Course_Name);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Course_SearchBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.DataGrideView_Courses);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("GE SS Two Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(714, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 482);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الكورسات";
            // 
            // SelectTeacher_ComboBox
            // 
            this.SelectTeacher_ComboBox.FormattingEnabled = true;
            this.SelectTeacher_ComboBox.Location = new System.Drawing.Point(73, 381);
            this.SelectTeacher_ComboBox.Name = "SelectTeacher_ComboBox";
            this.SelectTeacher_ComboBox.Size = new System.Drawing.Size(199, 39);
            this.SelectTeacher_ComboBox.TabIndex = 15;
            // 
            // SelectGrade_ComboBox
            // 
            this.SelectGrade_ComboBox.FormattingEnabled = true;
            this.SelectGrade_ComboBox.Location = new System.Drawing.Point(73, 336);
            this.SelectGrade_ComboBox.Name = "SelectGrade_ComboBox";
            this.SelectGrade_ComboBox.Size = new System.Drawing.Size(199, 39);
            this.SelectGrade_ComboBox.TabIndex = 14;
            // 
            // Teacher_Label
            // 
            this.Teacher_Label.AutoSize = true;
            this.Teacher_Label.Location = new System.Drawing.Point(351, 381);
            this.Teacher_Label.Name = "Teacher_Label";
            this.Teacher_Label.Size = new System.Drawing.Size(93, 31);
            this.Teacher_Label.TabIndex = 13;
            this.Teacher_Label.Text = "المعلم";
            // 
            // Grade_Label
            // 
            this.Grade_Label.AutoSize = true;
            this.Grade_Label.Location = new System.Drawing.Point(351, 336);
            this.Grade_Label.Name = "Grade_Label";
            this.Grade_Label.Size = new System.Drawing.Size(81, 31);
            this.Grade_Label.TabIndex = 12;
            this.Grade_Label.Text = "الفرقة";
            // 
            // Course_Delete_Button
            // 
            this.Course_Delete_Button.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Course_Delete_Button.ImageOptions.Image")));
            this.Course_Delete_Button.Location = new System.Drawing.Point(38, 434);
            this.Course_Delete_Button.Name = "Course_Delete_Button";
            this.Course_Delete_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Course_Delete_Button.Size = new System.Drawing.Size(94, 29);
            this.Course_Delete_Button.TabIndex = 11;
            this.Course_Delete_Button.Text = "حذف";
            this.Course_Delete_Button.Click += new System.EventHandler(this.Course_Delete_Button_Click);
            // 
            // Course_Update_Button
            // 
            this.Course_Update_Button.Enabled = false;
            this.Course_Update_Button.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Course_Update_Button.ImageOptions.Image")));
            this.Course_Update_Button.Location = new System.Drawing.Point(195, 434);
            this.Course_Update_Button.Name = "Course_Update_Button";
            this.Course_Update_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Course_Update_Button.Size = new System.Drawing.Size(94, 29);
            this.Course_Update_Button.TabIndex = 10;
            this.Course_Update_Button.Text = "تعديل";
            this.Course_Update_Button.Click += new System.EventHandler(this.Course_Update_Button_Click);
            // 
            // Course_Insert_Button
            // 
            this.Course_Insert_Button.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Course_Insert_Button.ImageOptions.Image")));
            this.Course_Insert_Button.Location = new System.Drawing.Point(351, 434);
            this.Course_Insert_Button.Name = "Course_Insert_Button";
            this.Course_Insert_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Course_Insert_Button.Size = new System.Drawing.Size(94, 29);
            this.Course_Insert_Button.TabIndex = 9;
            this.Course_Insert_Button.Text = "اضافة";
            this.Course_Insert_Button.Click += new System.EventHandler(this.Course_Insert_Button_Click);
            // 
            // Course_Name
            // 
            this.Course_Name.Location = new System.Drawing.Point(73, 290);
            this.Course_Name.Name = "Course_Name";
            this.Course_Name.Size = new System.Drawing.Size(199, 38);
            this.Course_Name.TabIndex = 8;
            this.Course_Name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Course_Name_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 31);
            this.label7.TabIndex = 5;
            this.label7.Text = "الاسم";
            // 
            // Course_SearchBox
            // 
            this.Course_SearchBox.Location = new System.Drawing.Point(73, 37);
            this.Course_SearchBox.Name = "Course_SearchBox";
            this.Course_SearchBox.Size = new System.Drawing.Size(199, 38);
            this.Course_SearchBox.TabIndex = 4;
            this.Course_SearchBox.TextChanged += new System.EventHandler(this.Course_SearchBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 31);
            this.label8.TabIndex = 3;
            this.label8.Text = "البحث عن كورس";
            // 
            // DataGrideView_Courses
            // 
            this.DataGrideView_Courses.AllowUserToAddRows = false;
            this.DataGrideView_Courses.AllowUserToDeleteRows = false;
            this.DataGrideView_Courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrideView_Courses.Location = new System.Drawing.Point(20, 101);
            this.DataGrideView_Courses.Name = "DataGrideView_Courses";
            this.DataGrideView_Courses.ReadOnly = true;
            this.DataGrideView_Courses.RowHeadersWidth = 51;
            this.DataGrideView_Courses.RowTemplate.Height = 24;
            this.DataGrideView_Courses.Size = new System.Drawing.Size(439, 174);
            this.DataGrideView_Courses.TabIndex = 2;
            this.DataGrideView_Courses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGrideView_Courses_KeyDown);
            // 
            // Courses
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 709);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("GE SS Two Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Courses";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.Courses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrideView_CoursesView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrideView_Courses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton Course_Delete_Button;
        private DevExpress.XtraEditors.SimpleButton Course_Update_Button;
        private DevExpress.XtraEditors.SimpleButton Course_Insert_Button;
        private System.Windows.Forms.TextBox Course_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Course_SearchBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DataGrideView_Courses;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.ComboBox SelectTeacher_ComboBox;
        private System.Windows.Forms.ComboBox SelectGrade_ComboBox;
        private System.Windows.Forms.Label Teacher_Label;
        private System.Windows.Forms.Label Grade_Label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label StudentPh_label;
        private System.Windows.Forms.Label StudentGrade_label;
        private System.Windows.Forms.Label StudentName_label;
        public System.Windows.Forms.TextBox StudentGrade_TextBox;
        public System.Windows.Forms.TextBox StudentPh_TextBox;
        public System.Windows.Forms.TextBox StudentName_TextBox;
        public System.Windows.Forms.DataGridView DataGrideView_CoursesView;
    }
}