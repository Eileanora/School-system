using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_system
{
    public partial class login_form : DevExpress.XtraEditors.XtraForm
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            cls_data cls = new cls_data();

            try
            {
                string password = cls.verify_user(Username_TextBox.Text);
                if (password == Password_TextBox.Text)
                {
                    Main main = new Main();
                    this.Hide();
                    main.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("كلمة المرور غير صحيحة");
                }
            }
            catch(Exception ex) 
            {
                cls_serverconnection.cn.Close();
                MessageBox.Show("لم يتم العثور على المستخدم");
            }
            //Main main= new Main();
            //this.Hide();
            //main.ShowDialog();
            //this.Close();
            

        }
    }
}