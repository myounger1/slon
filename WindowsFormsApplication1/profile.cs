using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class profile : Form
    {
        public static String avaimage;
        public static string tovar_n_l;
        public static String items_name;
        public static String items_cost;
        public static String items_club;
        public static String items_maker;
        public static String items_ava;

        public profile()
        {
            InitializeComponent();

            profile_chel_ava.BackgroundImage = Image.FromFile(Vars.avaway);//(Vars.avaway);        string String int
            profile_chel_avaway.Text = Vars.avaway;

            profile_chel_name.Text = Vars.LOGIN;
            profile_chel_password.Text = Vars.PASSWORD;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            profile_chel_ava.BackgroundImage = Image.FromFile(profile_chel_avaway.Text);//(Vars.avaway);  
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tovar_name_label_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void profile_Load(object sender, EventArgs e)
        {
            tovar_n_l = tovar_name_label.Text;

        }

        private void profile_chel_name_TextChanged(object sender, EventArgs e)
        {
        }

        private void sell_button_Click(object sender, EventArgs e)
        {
            String category = "";

            if (radio_b_clothes.Checked)
            {
                category = "Одежда";
            }
            else if (radio_b_electro.Checked)
            {
                category = "Электроника";
            }
            else if (radio_b_toy.Checked)
            {
                category = "Игрушка";
            }
            else if (radio_b_furniture.Checked)
            {
                category = "Мебель";
            }

            Tovar tov1 = new Tovar(tovar_name_label.Text, 
                tovar_cost_label.Text, 
                tovar_club_label.Text,
                tovar_maker_label.Text, new Point(Vars.COORDINATA_TOVARA_X, Vars.COORDINATA_TOVARA_Y), tovar_ava.Text, category);
            TorgPlatForm.vseChtoMozhnoKupit.Add(tov1);
            Vars.COORDINATA_TOVARA_Y = Vars.COORDINATA_TOVARA_Y + Vars.VYSOTA_TOVARA;
            //Vars.COORDINATA_TOVARA_X = Vars.COORDINATA_TOVARA_X + 230;

            items_name = tovar_name_label.Text;
            items_cost = tovar_cost_label.Text;
            items_club = tovar_club_label.Text;
            items_maker = tovar_maker_label.Text;
            items_ava = tovar_ava.Text;

            //File.WriteAllText("items\\item_" + items_name + ".txt", "");

            /*File.AppendAllText("items\\item_" + items_name + ".txt"., tovar_name_label.Text + Environment.NewLine);
              File.AppendAllText("items\\item_" + items_name + ".txt", tovar_cost_label.Text + Environment.NewLine);
              File.AppendAllText("items\\item_" + items_name + ".txt", tovar_club_label.Text + Environment.NewLine);
              File.AppendAllText("items\\item_" + items_name + ".txt", tovar_maker_label.Text + Environment.NewLine);*/

            //void sT(object sender, EventArgs e)
            {
                File.AppendAllText("Товары.csv", tovar_name_label.Text + ";" +
                                                tovar_cost_label.Text + ";" +
                                                tovar_club_label.Text + ";" +
                                                tovar_maker_label.Text + ";" +
                                                tovar_ava.Text + ";" +
                                                category + Environment.NewLine);
            }
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Yes)
            {
                profile_chel_avaway.Text = openFileDialog1.FileName;
                profile_chel_ava.BackgroundImage = Image.FromFile(profile_chel_avaway.Text);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tovar_ava.Text = openFileDialog1.FileName;
                pictureBox2.BackgroundImage = Image.FromFile(tovar_ava.Text);
            }

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Баланс tf = new Баланс();
            tf.ShowDialog();
        }
    }
}
