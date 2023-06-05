using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        Random random = new Random();
        public static Form2 Instance;
        public Label lb;
        public Form2()
        {
            InitializeComponent();
            Instance = this;
            lb = label2;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        Game g = new Game();



        private void timer1_Tick(object sender, EventArgs e)
        {

            label6.Text =g.score.ToString();    
           
            g.time--;
            label5.Text = g.time.ToString();
            button1.Enabled = false;
            groupBox1.Enabled = false;



            if (g.time == 0)
            {
                pb3.Visible = false;
                textBox1.Text = $"Game over your score is {g.score}";
                textBox1.Visible = true;
                timer1.Stop();
                button1.Enabled = true;
                groupBox1.Enabled = true;
                pb1.Visible = false;
                pb2.Visible= false;  
                pb4.Visible= false;
                pb5.Visible = false;  
                pb6.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checker();
           
        }
        void game()
        {

            timer1.Start();
            if (textBox1.Text.Length > 0) { reset(); }
           
            lvl1();
            lvl2();
            lvl3();
            lvl4();
            lvl5();
            lvl6();
        }
        void checker() {
            if (radioButton1.Checked)
            {
                game();
                g.easy();
               

            }
            else if (radioButton2.Checked) {
                game();
                g.medium();
                
            }
            else if (radioButton3.Checked) {
                game();
                g.hard();
            
            }
            else MessageBox.Show("please choose difficulty level");
        }

        void reset() {
            g.score = 0;
            pb1.Visible = true;
            pb2.Visible = false;
            pb3.Visible=false;
            pb4.Visible = false;
            pb5.Visible = false;
            pb6.Visible = false;
            textBox1.Visible=false;
            this.ClientSize = new System.Drawing.Size(700, 600);
            groupBox3.Size = new System.Drawing.Size(400, 500);

        }
        void difficulty() {
            if (g.score != 0)
            {

                if (radioButton1.Checked)
                {
                    if (g.score % 10 == 0) g.time += 7;

                }
                else if (radioButton2.Checked)
                {

                    if (g.score % 10 == 0) g.time += 5;
                }

                else

                {                 
                    if (g.score % 10 == 0) g.time += 3;
                }
            }
            
        }
        public void lvl1() {

            if ( g.time > 0)
            {
                label6.Text= g.score.ToString(); 
                int x = random.Next(10, groupBox3.Width - pb1.Width);
                int y = random.Next(10, groupBox3.Height - pb1.Height);
                pb1.Location = new Point(x, y);
                difficulty();
                if (g.score >= 10)
                {
                   
                   
                    pb1.Visible = false;
                    pb2.Visible = true;
                    this.ClientSize = new System.Drawing.Size(850, 700);
                    groupBox3.Size = new System.Drawing.Size(650, 600);
                }
            }
        }
        public void lvl2() {
            if ( g.time > 0)
            {
              
                difficulty();


                int x = random.Next(10, groupBox3.Width - pb2.Width);
                int y = random.Next(10, groupBox3.Height - pb2.Height);

                pb2.Location = new Point(x, y);
                if (g.score >= 20)
                {

                    pb2.Visible = false;
                    pb3.Visible = true;
                    this.ClientSize = new System.Drawing.Size(950, 750);
                    groupBox3.Size = new System.Drawing.Size(650, 650);
                }
            }
           
        }

     


        public void lvl3() {
           
           
            if ( g.time > 0)
            {

                difficulty();
                int x = random.Next(10, groupBox3.Width - pb3.Width);
                int y = random.Next(10, groupBox3.Height - pb3.Height);
                pb3.Location = new Point(x, y);
                if (g.score >= 30) {
                    pb3.Visible = false;
                    pb4.Visible = true;
                    this.ClientSize = new System.Drawing.Size(1050, 800);
                    groupBox3.Size = new System.Drawing.Size(750, 700);
                }
               
            }

        }
        void lvl4() {
            if ( g.time > 0) {
                difficulty();
                int x = random.Next(10, groupBox3.Width - pb4.Width);
                int y = random.Next(10, groupBox3.Height - pb4.Height);
                pb4.Location = new Point(x, y);
                if (g.score >= 40)
                {
                    pb4.Visible = false;
                    pb5.Visible = true;
                    this.ClientSize = new System.Drawing.Size(1150, 850);
                    groupBox3.Size = new System.Drawing.Size(850, 750);
                }

            }
          

        }
        void lvl5() {
            if ( g.time > 0) { 
                difficulty();
                int x = random.Next(10, groupBox3.Width - pb5.Width);
                int y = random.Next(10, groupBox3.Height - pb5.Height);
                pb5.Location = new Point(x, y);
                if (g.score >= 50)
                {
                    pb5.Visible = false;
                    pb6.Visible = true;
                    this.ClientSize = new System.Drawing.Size(1250, 900);
                    groupBox3.Size = new System.Drawing.Size(950, 800);
                }

            }
        }

        void lvl6()
        {
            if (g.time > 0)
            {
                difficulty();
                int x = random.Next(10, groupBox3.Width - pb6.Width);
                int y = random.Next(10, groupBox3.Height - pb6.Height);
                pb6.Location = new Point(x, y);                
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lvl1();
            g.score++;

        }

        private void pb2_Click(object sender, EventArgs e)
        {
            lvl2();
            g.score++;
        }
      

        private void pb3_Click(object sender, EventArgs e)
        {
            lvl3();
            g.score++;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            lvl5();
            g.score++;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lvl4();
            g.score++;
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            lvl6();
            g.score++;
        }
    }
}
