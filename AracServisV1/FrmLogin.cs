using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AracServisV1.DataAccess;
using AracServisV1.Entity;

namespace AracServisV1
{
    public partial class FrmLogin : Form
    {
        LoginDAL loginDAL = new LoginDAL();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullanici kullanici=loginDAL.KullaniciGetir(txtUser.Text, txtPass.Text);

            if(kullanici != null)
            {
                Form1 frmMain = new Form1();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parola hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
