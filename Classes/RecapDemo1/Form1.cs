using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Butonlar ile dama tahtası yapma
        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();
        }

        private void GenerateButtons()
        {
            // 8 e 8 lik bir button toplam 64 tane button arryi oluşturuyoruz.
            Button[,] buttons = new Button[8, 8];
            // yukardan sıfır
            int top = 0;
            // soldan sıfır
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    //genişlik 50
                    buttons[i, j].Width = 50;
                    // yükseklik 50
                    buttons[i, j].Height = 50;
                    // soldan boşluk
                    buttons[i, j].Left = left;
                    // yukardan boşluk
                    buttons[i, j].Top = top;
                    // soldan 50 karekter artırarak boşluk bırak 
                    left += 50;
                    // siyah beyaz buton oluşturma algoritması
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;

                    }
                    this.Controls.Add(buttons[i, j]);
                }
                // yukardan 50 karekter artırarak boşluk bırakma
                top += 50;
                //soldan sıfır karekter boşluk bırakma
                left = 0;
            }
        }
    }
}
