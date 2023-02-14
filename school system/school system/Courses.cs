using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_system
{
    public partial class Courses : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int lid;

        public Courses()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Courses courses = new Courses();
            courses.Show();
        }

        public void load_courses()
        {
            DataGrideView_Courses.AutoResizeColumns();
            DataGrideView_Courses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            try
            {
                cls_data cls = new cls_data();
                cls.select("select_course");
                DataGrideView_Courses.DataSource = cls.dt;
            }
            catch
            {
                cls_serverconnection.cn.Close();
                MessageBox.Show("خطأ في تحميل البيانات");
            }
        }
        public void load_grade()
        {

            try
            {
                cls_data cls = new cls_data();
                cls.select("select_grade");
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

            try
            {
                cls_data cls = new cls_data();
                cls.select("select_teacher");
                SelectTeacher_ComboBox.DataSource = cls.dt;
                SelectTeacher_ComboBox.DisplayMember = "name";
                SelectTeacher_ComboBox.ValueMember = "id";
            }
            catch
            {
                cls_serverconnection.cn.Close();
                MessageBox.Show("خطأ في تحميل البيانات");
            }
        }
        private void Courses_Load(object sender, EventArgs e)
        {
            load_courses();
            load_grade();
            load_teachers();
        }


        private void Course_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Course_Insert_Button.Enabled == true)
                    Course_Insert_Button.PerformClick();
                else if (Course_Update_Button.Enabled == true)
                    Course_Update_Button.PerformClick();
            }
        }
        private void Course_Insert_Button_Click(object sender, EventArgs e)
        {
            try
            {
                cls_data cls = new cls_data();
                string name = Course_Name.Text;
                int g_id = Convert.ToInt32(SelectGrade_ComboBox.SelectedValue);
                int t_id = Convert.ToInt32(SelectTeacher_ComboBox.SelectedValue);

                if (name == "")
                {
                    MessageBox.Show("ادخل البيانات صحيحة");
                }
                else
                {
                    cls.insert_course(name, g_id, t_id);
                    load_courses();
                    Course_Name.Clear();
                }
            }
            catch (Exception)
            {
                cls_serverconnection.cn.Close();
                MessageBox.Show("خطأاثناء عملية الاضافة");
            }
        }


        private void Course_Delete_Button_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(DataGrideView_Courses.CurrentRow.Cells[0].Value);


                if (MessageBox.Show("هل تريد تأكيد عملية الحذف؟", "عملية حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cls_data cls = new cls_data();
                    cls.delete_course(id);
                    load_courses();

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

        private void DataGrideView_Courses_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Course_Name.Text = DataGrideView_Courses.CurrentRow.Cells[1].Value.ToString();

                lid = Convert.ToInt32(DataGrideView_Courses.CurrentRow.Cells[0].Value);

                Course_Update_Button.Enabled = true;
                Course_Insert_Button.Enabled = false;
                Course_Delete_Button.Enabled = false;
            }
        }

        private void Course_Update_Button_Click(object sender, EventArgs e)
        {
            try
            {
                cls_data cls = new cls_data();
                string name = Course_Name.Text;

                int g_id = Convert.ToInt32(SelectGrade_ComboBox.SelectedValue);
                int t_id = Convert.ToInt32(SelectTeacher_ComboBox.SelectedValue);

                cls.update_course(name, lid, g_id, t_id);
                load_courses();

                Course_Name.Clear();

            }
            catch
            {
                cls_serverconnection.cn.Close();
                MessageBox.Show("خطأ اثناء عملية التعديل");
            }
            Course_Update_Button.Enabled = false;
            Course_Insert_Button.Enabled = true;
            Course_Delete_Button.Enabled = true;
        }

        private void Course_SearchBox_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from courses where name like '%" + Course_SearchBox.Text + "%'";

            SqlDataAdapter data = new SqlDataAdapter(sql, cls_serverconnection.cn);
            DataSet ds = new DataSet();

            cls_serverconnection.cn.Open();

            data.Fill(ds, "au");
            DataGrideView_Courses.AutoResizeColumns();
            DataGrideView_Courses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGrideView_Courses.DataSource = ds;
            DataGrideView_Courses.DataMember = "au";

            cls_serverconnection.cn.Close();
        }
    }
}