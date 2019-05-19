using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public struct Tovar
    {
        public PictureBox picturebox;
        public Label label_name;
        /// <summary>
        /// Цена товара
        /// </summary>
        public Label label_cost;
        /// <summary>
        /// Доставка
        /// </summary>
        public Label label_club;
        public Label label_maker;
        public Button kupitButton;
        public int nomer;
        public string category;


        public Tovar(String name, String cost, String club, String maker, Point pt, String adressKartinki, string categiry)
        {
            int pbx = pt.X+120; 
            int pby = pt.Y;
            int labsizex = 50;
            int labsizey = 30;
            category = categiry;
            nomer = Vars.NOMER_TOVARA;
            Vars.NOMER_TOVARA = Vars.NOMER_TOVARA + 1;

            if (Vars.NOMER_TOVARA % 2 == 1)
            {
                Vars.COORDINATA_TOVARA_Y = Vars.COORDINATA_TOVARA_Y - Vars.VYSOTA_TOVARA;
                pbx = pbx + 250;
            }

            else if (Vars.NOMER_TOVARA % 2 == 0)
            {
                //Vars.COORDINATA_TOVARA_Y = Vars.COORDINATA_TOVARA_Y - Vars.VYSOTA_TOVARA;
            }

            #region Picterbox
            picturebox = new PictureBox();
            picturebox.Location = new Point(pbx, pby);
            picturebox.Size = new Size(100, 100);
            picturebox.BackColor = new Color();
            if (adressKartinki != "")
            {
                picturebox.BackgroundImage = Image.FromFile(adressKartinki);
            }

            #endregion

            #region Button
            kupitButton = new Button();
            kupitButton.Text = "Купить";
            kupitButton.Location = new Point(pbx, pby + 173);
            kupitButton.Size = new Size(100, 50);
            kupitButton.Click += new EventHandler(TorgPlatForm.KupitTovar);
            picturebox.BackColor = Color.White;
            #endregion

            #region Label_name
            label_name = new Label();
            label_name.Text = name;
            label_name.Size = new Size(labsizex, labsizey);
            label_name.Location = new Point(pbx, pby + 113);
            label_name.BackColor = Color.White;
            #endregion

            #region Label_cost
            label_cost = new Label();
            label_cost.Text = cost.ToString();
            label_cost.Size = new Size(labsizex, labsizey);
            label_cost.Location = new Point(pbx + 50, pby + 113);
            label_cost.BackColor = Color.White;
            #endregion

            #region Label_club
            label_club = new Label();
            label_club.Text = club;
            label_club.Size = new Size(labsizex, labsizey);
            label_club.Location = new Point(pbx, pby + 143);
            label_club.BackColor = Color.White;
            #endregion

            #region Label_maker
            label_maker = new Label();
            label_maker.Text = maker;
            label_maker.Size = new Size(labsizex, labsizey);
            label_maker.Location = new Point(pbx + 50, pby + 143);
            label_maker.BackColor = Color.White;
            #endregion
        }

    }

    public partial class TorgPlatForm : Form
    {
        public static List<Tovar> vseChtoMozhnoKupit = new List<Tovar>();
        public static List<Tovar> kupleno = new List<Tovar>();
        public static int rub = 300;

        int xtovara = 120;
        int ytovara = 109;
        public static int nomer_picterBox;


        public TorgPlatForm(String adress, string login)
        {
            InitializeComponent();
            login_label.Text = login;
            ava_picturebox.BackgroundImage = Image.FromFile(Vars.avaway);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Vars.COORDINATA_TOVARA_X = -100;
            Vars.COORDINATA_TOVARA_Y = 0;
            tovaryPanel.Controls.Clear();
            vseChtoMozhnoKupit.Clear();
            StreamReader sr = new StreamReader("Товары.csv", Encoding.UTF8);

            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                String str = sr.ReadLine();
                string[] words = str.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                if (words.Length > 3)
                {
                    String picAdress = "";
                    if (words.Length > 4)
                    {
                        picAdress = words[4];
                    }

                    Tovar tov1 = new Tovar(words[0], words[1], words[2], words[3], new Point(Vars.COORDINATA_TOVARA_X, Vars.COORDINATA_TOVARA_Y), picAdress, "Одежда");
                    vseChtoMozhnoKupit.Add(tov1);
                    Vars.COORDINATA_TOVARA_Y = Vars.COORDINATA_TOVARA_Y + Vars.VYSOTA_TOVARA;
                }
            }
           
            int nomer = 0;
            foreach (Tovar tov in vseChtoMozhnoKupit)
            {
                tovaryPanel.Controls.Add(tov.kupitButton);
                tovaryPanel.Controls.Add(tov.picturebox);
                tovaryPanel.Controls.Add(tov.label_club);
                tovaryPanel.Controls.Add(tov.label_cost);
                tovaryPanel.Controls.Add(tov.label_name);
                tovaryPanel.Controls.Add(tov.label_maker);
                nomer++;
            }


            //ToolTip toolTip1 = new ToolTip();
            //toolTip1.ShowAlways = true;
            //richTextBox1.SetToolTip(toolTip1, "Корзина");

            balance_label.Text = "Ваш баланс:" + rub.ToString();
        }

        void f1()
        {
            //при деланиии корзины отступ 111px 

            /*if (nomer_picterBox % 2 == 0)
            {
                xtovara = xtovara * 2 + 20;
            }*/

            if (nomer_picterBox % 2 != 0)    /*else*/
            {
                ytovara = ytovara * 2 + 20;
            }

            //button_Click()

        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && costTextBox.Text != "" && nameTBox.Text != "")
            {
                //Строка в число
                //int price = Convert.ToInt32(costTextBox.Text);
                rub = rub + 1;
            }

            balacne.Text = "Ваш баланс:" + rub.ToString();
            //nameTextBox.Clear();
        }*/

        private void TorgPlatForm_Resize(object sender, EventArgs e)
        {
            //nameTBox.Text = "УУУУ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка не работает, повторите попытку позже.");       
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }


        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            /*


            comboBox1.Items.Clear();
            foreach (String slov in Slova)
            {
                if (slov.StartsWith(comboBox1.Text))
                {
                    comboBox1.Items.Add(slov);
                }
            }

            if (comboBox1.Items.Count == 1)
            {
                //comboBox1.SelectedIndex = 0;
            }*/
        }

        private void profileb_Click(object sender, EventArgs e)
        {
            //primer.Visible = false;
            profile pro = new profile();
            pro.ShowDialog();

            tovaryPanel.Controls.Clear();
            foreach (Tovar tov in vseChtoMozhnoKupit)
            {
                tovaryPanel.Controls.Add(tov.kupitButton);
                tovaryPanel.Controls.Add(tov.picturebox);
                tovaryPanel.Controls.Add(tov.label_club);
                tovaryPanel.Controls.Add(tov.label_cost);
                tovaryPanel.Controls.Add(tov.label_name);
                tovaryPanel.Controls.Add(tov.label_maker);
            }
        }

        /// <summary>
        /// Покупка товара
        /// </summary>
        public static void KupitTovar(object sender, EventArgs e)
        {
            foreach (Tovar t in vseChtoMozhnoKupit)
            {
                if (sender.Equals(t.kupitButton))
                {
                    try
                    {
                        int price = Convert.ToInt32(t.label_cost.Text);

                        if (rub >= price)
                        {
                            kupleno.Add(t);
                            rub = rub - price; 
                        }
                        else
                        {
                            MessageBox.Show("Недостаточно денег. Вы нищеброд.");
                        }
                    }
                    catch (Exception) { }

                }
            }
        }

        /// <summary>
        /// Обновление цены
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            balance_label.Text = "Ваш баланс:" + rub.ToString();
        }

        private void tovaryPanel_Paint(object sender, PaintEventArgs e)
        {
            tovaryPanel.AutoScroll = false;
        }


        #region Клик на категорию
        private void electro_Button_Click(object sender, EventArgs e)
        {

            foreach (Tovar t in vseChtoMozhnoKupit)
            {
                if (t.category.Contains("Электроника"))
                {
                    MessageBox.Show(t.label_name.Text + " " + t.label_cost.Text);
                }
            }
        }



        private void clothes_button_Click(object sender, EventArgs e)
        {
            foreach (Tovar t in vseChtoMozhnoKupit)
            {
                if (t.category.Contains("Одежда"))
                {
                    MessageBox.Show(t.label_name.Text + " " + t.label_cost.Text);
                }
            }
        }

        private void toys_button_Click(object sender, EventArgs e)
        {
            foreach (Tovar t in vseChtoMozhnoKupit)
            {
                if (t.category.Contains("Игрушка"))
                {
                    MessageBox.Show(t.label_name.Text + " " + t.label_cost.Text);
                }
            }
        }

        private void furniture_button_Click(object sender, EventArgs e)
        {
            foreach (Tovar t in vseChtoMozhnoKupit)
            {
                if (t.category.Contains("Мебель"))
                {
                    MessageBox.Show(t.label_name.Text + " " + t.label_cost.Text);
                }
            }
        }
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
