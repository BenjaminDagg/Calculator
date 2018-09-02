using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

enum NumberButtons
{
    NUM_0 = 0,
    NUM_1 = 1,
    NUM_2 = 2,
    NUM_3 = 3,
    NUM_4 = 4,
    NUM_5 = 5,
    NUM_6 = 6,
    NUM_7 = 7,
    NUM_8 = 8,
    NUM_9 = 9
}

enum ButtonType
{
    CLEAR,
    DELETE,
    DIVIDE,
    MULTIPLY,
    SUBTRACT,
    ADD,
    ENTER,
    NumberButtons
};

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            renderNumBtns();
        }


        private void renderNumBtns()
        {
            //initial values
            int row = 4;
            int col = 0;
            int btn_width = 43;
            int btn_height = 77;

            //zero btn
            this.numButtons[0] = new System.Windows.Forms.Button();
            ButtonType zero = (ButtonType)(NumberButtons)0;
            this.numButtons[0].Click += new System.EventHandler((sender, e) => this.Btn_Click(sender, e, zero) );
            this.numButtons[0].Dock = System.Windows.Forms.DockStyle.Fill;
            this.numButtons[0].Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numButtons[0].Location = new System.Drawing.Point(row, col);
            this.numButtons[0].Name = "0Btn";
            this.numButtons[0].Size = new System.Drawing.Size(btn_width, btn_height);
            this.numButtons[0].TabIndex = 7;
            this.numButtons[0].Text = "0";
            this.numButtons[0].UseVisualStyleBackColor = true;
            this.TabelLayout.Controls.Add(this.numButtons[0], 1, 5);

            //render btns 1-9
            for (int i = 1; i <= 9; i++)
            {
                
                this.numButtons[i] = new System.Windows.Forms.Button();
                this.numButtons[i].Dock = System.Windows.Forms.DockStyle.Fill;
                this.numButtons[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.numButtons[i].Location = new System.Drawing.Point(row, col);
                this.numButtons[i].Name = i.ToString() + "Btn";
                this.numButtons[i].Size = new System.Drawing.Size(btn_width, btn_height);
                this.numButtons[i].TabIndex = 7;
                this.numButtons[i].Text = i.ToString(); ;
                this.numButtons[i].UseVisualStyleBackColor = true;
           
                this.TabelLayout.Controls.Add(this.numButtons[i],col,row);

                ButtonType type = (ButtonType)(NumberButtons)i;
                this.numButtons[0].Click += new System.EventHandler((sender, e) => this.Btn_Click(sender, e, type));

                //reached end of row
                //go up 1 row and reset columns
                if (i % 3 == 0)
                {
 
                    row--;
                    col = 0;
                }
                //not reached end of row so increase column
                else
                {
                    
                    col++;

                }


            }
        }


        private void Btn_Click(object sender, EventArgs e, ButtonType btn)
        {
            Debug.Print(btn.ToString());
        }
    }
}
