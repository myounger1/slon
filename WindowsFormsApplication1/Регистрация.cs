using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Регистрация : Form
    {
        public static String name;
        public Регистрация()
        {
            InitializeComponent();
        }

        private void Регистрация_Load(object sender, EventArgs e)
        {

        }

        private void av_b_Click(object sender, EventArgs e)
        {
            ava.Load(av_way.Text);
            //ava.BackgroundImage = new Bitmap(av_way.Text);
        }

        private void save_b_Click(object sender, EventArgs e)
        {
            name = login.Text;

            File.WriteAllText(name + ".txt", "");
            File.AppendAllText(name + ".txt", "login " + login.Text + Environment.NewLine);
            File.AppendAllText(name + ".txt", "password " + password.Text + Environment.NewLine);
            File.AppendAllText(name + ".txt", "ava " + av_way.Text + Environment.NewLine);
            File.AppendAllText(name + ".txt", "0");


            Vars.LOGIN = login.Text;
            Vars.PASSWORD = password.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                av_way.Text = openFileDialog1.FileName;
                ava.BackgroundImage = Image.FromFile(av_way.Text);
            }
        }
    }
}
