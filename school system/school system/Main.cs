using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace school_system
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        int lid;
        public void load_students()
        {
            DataGrideView_Students.AutoResizeColumns();
            DataGrideView_Students.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                cls_data cls = new cls_data();
                cls.select("select_student");
                DataGrideView_Students.DataSource = cls.dt;
            }
            catch
            {
                cls_serverconnection.cn.Close();
                MessageBox.Show("خطأ في تحميل البيانات");
            }
        }

        public void load_grade()
        {
            DataGrideView_Grade.AutoResizeColumns();
            DataGrideView_Grade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                cls_data cls = new cls_data();
                cls.select("select_grade");
                DataGrideView_Grade.DataSource = cls.dt;

                SelectGrade_ComboBox.DataSource = cls.dt;
                SelectGrade_ComboBox.DisplayMember = "grade";
                SelectGrade_ComboBox.ValueMember = "id";
            }
            catch
            {
                cls_serverconnection.cn.Close();
                MessageBox.Show("خطأ في تحميل البيانات");
            }
        }

        public void load_teachers()
        {
            DataGrideView_Teachers.AutoResizeColumns();
            DataGrideView_Teachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                cls_data cls = new cls_data();
                cls.select("select_teacher");
                DataGrideView_Teachers.DataSource = cls.dt;
            }
            catch
            {
                cls_serverconnection.cn.Close();
                MessageBox.Show("خطأ في تحميل البيانات");
            }
        }

        //public void load_courses()
        //{
        //    DataGrideView_Courses.AutoResizeColumns();
        //    DataGrideView_Courses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        //    try
        //    {
        //        cls_data cls = new cls_data();
        //        cls.select("select_course");
        //        DataGrideView_Courses.DataSource = cls.dt;
        //    }
        //    catch
        //    {
        //        cls_serverconnection.cn.Close();
        //        MessageBox.Show("خطأ في تحميل البيانات");
        //    }
        //}

        public Main()
        {
            InitializeComponent();
            load_students();
            load_grade();
            load_teachers();
        }

        private void Student_Ph_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Student_Insert_Button.Enabled == true)
                    Student_Insert_Button.PerformClick();
                else if (Student_Update_Button.Enabled == true)
                    Student_Update_Button.PerformClick();
            }
        }
        private void Student_Insert_Button_Click(object sender, EventArgs e)
        {
            try
            {
                cls_data cls = new cls_data();
                string name = Student_Name.Text;
                String ph = Student_Ph.Text;
                int g_id = Convert.ToInt32(SelectGrade_ComboBox.SelectedValue);

                if (name == "" || ph == "")
                {
                    MessageBox.Show("ادخل البيانات صحيحة");
                }
                else
                {
                    cls.insert_students(name, ph, g_id);
                    load_students();
                    Student_Name.Clear();
                    Student_Ph.Clear();
                    DataGrideView_Grade.CurrentRow.Selected = false;
                }

            }
            catch (Exception)
            {
                cls_serverconnection.cn.Close();
                MessageBox.Show("خطأاثناء عملية الاضافة");
            }
        }


        private void DataGrideView_Students_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Student_Name.Text = DataGrideView_Students.CurrentRow.Cells[1].Value.ToString();
                Student_Ph.Text = DataGrideView_Students.CurrentRow.Cells[2].Value.ToString();
                lid = Convert.ToInt32(DataGrideView_Students.CurrentRow.Cells[0].Value);
                Student_Update_Button.Enabled = true;
                Student_Insert_Button.Enabled = false;
                Student_Delete_Button.Enabled = false;
            }
        }

        private void Student_Update_Button_Click(object sender, EventArgs e)
        {
            try
            {
                cls_data cls = new cls_data();
                string name = Student_Name.Text;
                string ph = Student_Ph.Text;
                int g_id = Convert.ToInt32(SelectGrade_ComboBox.SelectedValue);
                cls.update_students(name, ph, lid, g_id);
                load_students();

                Student_Name.Clear();
                Student_Ph.Clear();
                DataGrideView_Grade.CurrentRow.Selected = false;
                DataGrideView_Students.CurrentRow.Selected = false;
            }
            catch
            {
                cls_serverconnection.cn.Close();
                MessageBox.Show("خطأ اثناء عملية التعديل");
            }
            Student_Update_Button.Enabled = false;
            Student_Insert_Button.Enabled = true;
            Student_Delete_Button.Enabled = true;

        }

        private void Student_Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(DataGrideView_Students.CurrentRow.Cells[0].Value);


                if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟", "عملية حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls_data cls = new cls_data();
                    cls.delete_students(id);
                    load_students();

                }
                else
                {
                    MessageBox.Show("تم الغاء عملية الحذف", "عملية حذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception)
            {

                cls_serverconnection.cn.Close();
                MessageBox.Show("خطاء اثناء عملية الحذف");
            }
        }

        private void Student_SearchBox_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from students where name like '%" + Student_SearchBox.Text + "%'";
            SqlDataAdapter data = new SqlDataAdapter(sql, cls_serverconnection.cn);
            DataSet ds = new DataSet();

            cls_serverconnection.cn.Open();

            data.Fill(ds, "au");
            DataGrideView_Students.AutoResizeColumns();
            DataGrideView_Students.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGrideView_Students.DataSource = ds;
            DataGrideView_Students.DataMember = "au";

            cls_serverconnection.cn.Close();
        }


        private void Grade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Grade_Insert_Button.Enabled == true)
                    Grade_Insert_Button.PerformClick();
                else if (Grade_Update_Button.Enabled == true)
                    Grade_Update_Button.PerformClick();
            }
        }
        private void Grade_Insert_Button_Click(object sender, EventArgs e)
        {
            try
            {
                cls_data cls = new cls_data();
                string grade = this.Grade.Text;
                if (grade == "")
                {
                    MessageBox.Show("ادخل البيانات صحيحة");
                }
                else
                {
                    cls.insert_grade(grade);
                    load_grade();
                    Grade.Clear();
                }
            }
            catch
            {
                cls_serverconnection.cn.Close();
                MessageBox.Show("خطأاثناء عملية الاضافة");
            }
        }

        private void DataGrideView_Grade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Grade.Text = DataGrideView_Grade.CurrentRow.Cells[1].Value.ToString();
                lid = Convert.ToInt32(DataGrideView_Grade.CurrentRow.Cells[0].Value);
                Grade_Update_Button.Enabled = true;
                Grade_Delete_Button.Enabled = false;
                Grade_Insert_Button.Enabled = false;
            }
        }


        private void Grade_Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(DataGrideView_Grade.CurrentRow.Cells[0].Value);


                if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟", "عملية حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls_data cls = new cls_data();
                    cls.delete_grade(id);
                    load_grade();

                }
                else
                {
                    MessageBox.Show("تم الغاء عملية الحذف", "عملية حذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception)
            {

                cls_serverconnection.cn.Close();
                MessageBox.Show("خطاء اثناء عملية الحذف");
            }
        }

        private void Grade_Update_Button_Click(object sender, EventArgs e)
        {
            try
            {
                cls_data cls = new cls_data();
                string grade = this.Grade.Text;
                cls.update_grade(grade, lid);
                load_grade();
                Grade.Clear();
                DataGrideView_Grade.CurrentRow.Selected = false;
            }
            catch
            {
                cls_serverconnection.cn.Close();
                MessageBox.Show("خطأ اثناء عملية التعديل");
            }
            Grade_Update_Button.Enabled = false;
            Grade_Delete_Button.Enabled = true;
            Grade_Insert_Button.Enabled = true;
        }


        private void Grade_SearchBox_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from grade where grade like '%" + Grade_SearchBox.Text + "%'";

            SqlDataAdapter data = new SqlDataAdapter(sql, cls_serverconnection.cn);
            DataSet ds = new DataSet();
            cls_serverconnection.cn.Open();

            data.Fill(ds, "au");
            DataGrideView_Grade.AutoResizeColumns();
            DataGrideView_Grade.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGrideView_Grade.DataSource = ds;
            DataGrideView_Grade.DataMember = "au";

            cls_serverconnection.cn.Close();
        }

        private void Teacher_Ph_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Teacher_Insert_Button.Enabled == true)
                    Teacher_Insert_Button.PerformClick();
                else if (Teacher_Update_Button.Enabled == true)
                    Teacher_Update_Button.PerformClick();
            }
        }
        private void Teacher_Insert_Button_Click(object sender, EventArgs e)
        {
            try
            {
                cls_data cls = new cls_data();
                string name = Teacher_Name.Text;
                String ph = Teacher_Ph.Text;

                if (name == "" || ph == "")
                {
                    MessageBox.Show("ادخل البيانات صحيحة");
                }
                else
                {
                    cls.insert_teacher(name, ph);
                    load_teachers();
                    Teacher_Name.Clear();
                    Teacher_Ph.Clear();
                }
            }
            catch (Exception)
            {
                //cls_serverconnection.cn.Close();
                //MessageBox.Show("خطأاثناء عملية الاضافة");
                throw;
            }
        }


        private void Teacher_Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(DataGrideView_Teachers.CurrentRow.Cells[0].Value);


                if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟", "عملية حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls_data cls = new cls_data();
                    cls.delete_teacher(id);
                    load_teachers();

                }
                else
                {
                    MessageBox.Show("تم الغاء عملية الحذف", "عملية حذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception)
            {

                cls_serverconnection.cn.Close();
                MessageBox.Show("خطاء اثناء عملية الحذف");
            }
        }


        private void DataGrideView_Teachers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Teacher_Name.Text = DataGrideView_Teachers.CurrentRow.Cells[1].Value.ToString();
                Teacher_Ph.Text = DataGrideView_Teachers.CurrentRow.Cells[2].Value.ToString();
                lid = Convert.ToInt32(DataGrideView_Teachers.CurrentRow.Cells[0].Value);
                Teacher_Update_Button.Enabled = true;
                Teacher_Insert_Button.Enabled = false;
                Teacher_Delete_Button.Enabled = false;
            }
        }

        private void Teacher_Update_Button_Click(object sender, EventArgs e)
        {
            try
            {
                cls_data cls = new cls_data();
                string name = Teacher_Name.Text;
                string ph = Teacher_Ph.Text;
                cls.update_teacher(name, ph, lid);
                load_teachers();
                Teacher_Name.Clear();
                Teacher_Ph.Clear();
                DataGrideView_Teachers.CurrentRow.Selected = false;
            }
            catch (Exception)
            {
                cls_serverconnection.cn.Close();
                MessageBox.Show("خطأ اثناء عملية التعديل");
                //throw;
            }
            Teacher_Update_Button.Enabled = false;
            Teacher_Insert_Button.Enabled = true;
            Teacher_Delete_Button.Enabled = true;
        }

        private void Teacher_SearchBox_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from teachers where name like '%" + Teacher_SearchBox.Text + "%'";
            SqlDataAdapter data = new SqlDataAdapter(sql, cls_serverconnection.cn);
            DataSet ds = new DataSet();

            cls_serverconnection.cn.Open();

            data.Fill(ds, "au");
            DataGrideView_Teachers.AutoResizeColumns();
            DataGrideView_Teachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGrideView_Teachers.DataSource = ds;
            DataGrideView_Teachers.DataMember = "au";

            cls_serverconnection.cn.Close();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Courses courses = new Courses();
            courses.Show();
        }

        private void DataGrideView_Students_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DataGrideView_Students.CurrentRow.Cells[0].Value);
            Courses courses = new Courses();
            courses.Show();

            courses.DataGrideView_CoursesView.AutoResizeColumns();
            courses.DataGrideView_CoursesView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                cls_data cls = new cls_data();
                cls.select_ViewStudents("select_Viewcourses", id);
                courses.DataGrideView_CoursesView.DataSource = cls.dt;

                string StudentName = Convert.ToString(DataGrideView_Students.CurrentRow.Cells[1].Value);
                string StudentPh = Convert.ToString(DataGrideView_Students.CurrentRow.Cells[2].Value);

                string StudentGrade = Convert.ToString(DataGrideView_Students.CurrentRow.Cells[3].Value);

                courses.StudentName_TextBox.Text = StudentName;
                courses.StudentGrade_TextBox.Text = StudentGrade;
                courses.StudentPh_TextBox.Text = StudentPh;

                courses.DataGrideView_CoursesView.Columns.RemoveAt(0);
            }
            catch
            {
                cls_serverconnection.cn.Close();
                MessageBox.Show("خطأ في تحميل البيانات");
            }
        }

        private void Logout_Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            login_form login = new login_form();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Open_Courses(object sender, EventArgs e)
        {
            Courses courses = new Courses();
            courses.Show();
        }

        //private void Log_out(object sender, EventArgs e)
        //{
        //    login_form login = new login_form();
        //    this.Hide();
        //    login.ShowDialog();
        //    this.Close();
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            login_form login = new login_form();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Courses courses = new Courses();
            courses.Show();
        }
    }
}