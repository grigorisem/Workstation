using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace workstation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Soldier
        {

            public Soldier(string full_name, int age, int experience, string position)
            {
                Full_Name = full_name;
                Age = age;
                Experience = experience;
                Position = position;
            }

            public String Full_Name, Position;
            public int Age;
            public int Experience;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList list1 = new ArrayList(); // список гостиниц
            Soldier dt1 = new Soldier("Ермольева", 28, 10, "Академик");
            list1.Add(dt1);
            if (list1 == null) { return; }
            foreach (Soldier soldier in list1)
            {
                // строка для записи в элемент ListBox hotellist
                String full_name = soldier.Full_Name.Trim();
                String age = soldier.Age.ToString();
                String experience = soldier.Experience.ToString();
                String position = soldier.Position.Trim();
                String str = full_name + "," + age + "," + experience + "," + position;
                comboBox1.Items.Add(str);
            }
        }

        public String Full_Name
        {
            get { return (textBox1.Text); }
            set { textBox1.Text = value; }
        }
        public int Age
        {
            get { return Convert.ToInt32(textBox2.Text); }
            set { textBox2.Text = value.ToString(); }
        }
        public int Experience
        {
            get { return Convert.ToInt32(textBox3.Text); }
            set { textBox3.Text = value.ToString(); }
        }
        public String Position
        {
            get { return (textBox4.Text); }
            set { textBox4.Text = value; }
        }
        public bool flag = false;
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Full_Name != "" && Age.ToString() != "" && Experience.ToString() != "" && Position != "")
            {
                if (MessageBox.Show("Добавить сотрудника?", "Изменение данных...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No) return;
                flag = true;
            }
            else
            {
                MessageBox.Show("Данные не введены!", "Администрация", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            comboBox1.Items.Add(Full_Name + "," + Age + "," + Experience + "," + Position);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(comboBox1.SelectedItem);
            comboBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите закрыть программу?", "Предупреждение",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
            System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

