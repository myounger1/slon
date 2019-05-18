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
    public partial class VhodForm : Form
    {

        public String pcn = "";

        public VhodForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Заполни поля");
            }

            else
            {
                var dir = new DirectoryInfo(Application.StartupPath); // папка с exe 

                foreach (FileInfo file in dir.GetFiles())
                {
                    //здесь Вадим                   а тут C:\Users\Documents\...Вадим.txt
                    String fileName = Path.GetFileNameWithoutExtension(file.FullName);
                    if (textBox1.Text == fileName)
                    {
                        //MessageBox.Show("Есть такой пользователь");

                        StreamReader sr = new StreamReader(file.FullName, System.Text.Encoding.UTF8);

                        Vars.LOGIN = sr.ReadLine().Replace("login ", "");
                        Vars.PASSWORD = sr.ReadLine();
                        string ava = sr.ReadLine();
                        Vars.avaway = ava.Replace("ava ", "");

                        sr.Close();
                        if (Vars.PASSWORD == "password " + textBox2.Text)
                        {
                            Visible = false;
                            TorgPlatForm tf = new TorgPlatForm(textBox1.Text, Vars.LOGIN);
                            tf.ShowDialog();
                            Visible = true;
                        }

                    }

                }

            }
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            Регистрация regForm = new Регистрация();
            regForm.ShowDialog();
            
            //textBox1.Text = Vars.LOGIN;
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
