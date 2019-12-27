using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace test
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog1;
        List<String> l = new List<string>();
        List<Button> lButton = new List<Button>();
        private int top1 = 0;
        private int left1 = 100;
        private int left2 = 200;
        public Form1()
        {
            InitializeComponent();
            openFileDialog1 = new OpenFileDialog();
        }


      

 
            // 
       
        public void buttonAdd()
        {
            
            Button button1 = new Button();
            Button button2 = new Button();

            button1.Left = left1;
            button1.Top = top1;
            button2.Left = left2;
            button2.Top = top1;
            button1.Text = l[l.Count -1];
            this.Controls.Add(button1);
            this.Controls.Add(button2);
            top1 += button3.Height + 2;
            button2.Size = button3.Size;
            
            Image newImage = Image.FromFile(l[l.Count - 1]);

            button2.BackgroundImage = (Image)(newImage);



        }

 

        private void but_Click(object sender, EventArgs e)
        {

            String imageLocation = "";

            //openFileDialog1.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|GIF files(*.gif)|*.gif|";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imageLocation = openFileDialog1.FileName;
                Image newImage = Image.FromFile(imageLocation);
                this.button3.BackgroundImage = (Image)(newImage);
                l.Add(imageLocation);
                buttonAdd();


            }
        }
    }

  
}
