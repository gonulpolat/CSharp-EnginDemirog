using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamaTahtasi
{
    public partial class Form1 : Form  // inheritance
    {
        public Form1() // constructor
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CreateButton();


            GenerateButton();

        }

        private void GenerateButton()
        {
            int top = 0;
            int left = 0;
            Button[,] buttons = new Button[8, 8];

            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                left = 0;
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Top = top;
                    buttons[i, j].Left = left;

                    if ((i + j) % 2 == 0) { buttons[i, j].BackColor = Color.White; }
                    else { buttons[i, j].BackColor = Color.Black; }

                    this.Controls.Add(buttons[i, j]);

                    left += 50;
                }
                top += 50;
            }
        }

        private void CreateButton()
        {
            Button button = new Button();     // Button sınıfından nesne oluşturuldu
            button.Width = 50;
            button.Height = 50;
            button.Text = "Click!";
            this.Controls.Add(button);
        }
    }
}
