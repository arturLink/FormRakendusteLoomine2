using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormRakendusteLoomine2
{
    public class MatQuiz : Form
    {
        Label timelbl;
        Label timeleftlbl;
        Label sumLeft, sumRight;
        NumericUpDown[] vastused = new NumericUpDown[4];

        TableLayoutPanel tableLayoutPanel;

        string[,] l_nimed;
        string[] tehed = new string[4] { "+", "-", "/", "*", };
        string text;

        int[] num1 = new int[4];
        int[] num2 = new int[4];

        Random random = new Random();
        public MatQuiz()
        {
            l_nimed = new string[5, 4];
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Text = "Matemaatiline äraarvamismäng";
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;

            timelbl = new Label()
            {
                Text = "",
                BorderStyle = BorderStyle.FixedSingle,
                Font = new System.Drawing.Font("Arial",24,System.Drawing.FontStyle.Bold),
                Size = new System.Drawing.Size(200,30),
                Location = new System.Drawing.Point(300,0),
            };
            this.Controls.Add(timelbl);

            timeleftlbl = new Label()
            {
                Text = "Time Left:",
                Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold),
                Location = new System.Drawing.Point(190,0),
                Size = new System.Drawing.Size(200,30),
            };
            this.Controls.Add(timeleftlbl);

            tableLayoutPanel = new TableLayoutPanel()
            {
                AutoSize = true,
                ColumnCount = 5,
                RowCount = 4,
                Location = new System.Drawing.Point(50,60),
                BackColor = System.Drawing.Color.White,
            };
            this.Controls.Add(tableLayoutPanel);

            l_nimed = new string[5, 4];
            for(int i= 0; i < 4; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(SizeType.Percent, 25F));
                for (int j =0; j < 5; j++)
                {
                    tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(SizeType.Percent, 20F));
                    var l_nimi="L"+j.ToString() + i.ToString();
                    l_nimed[j,i] = l_nimi;
                    if (j==1)
                    {
                        text = tehed[i];
                    }
                    else if(j==0)
                    {
                        int a = random.Next(20);
                        text = a.ToString();
                        num1[i] = a;
                    }
                    else if (j == 2)
                    {
                        int a = random.Next(10);
                        text = a.ToString();
                        num2[i] = a;
                    }
                    else if(j==3)
                    {
                        text="=";
                    }
                    else if (j==4)
                    {
                        vastused[i] = new NumericUpDown
                        {
                            Name = tehed[i],
                            DecimalPlaces = 2,
                            Minimum = -100
                        };
                        tableLayoutPanel.Controls.Add(vastused[i], j, i);
                    }
                    else
                    {
                        text = l_nimi;
                    }
                    Label l = new Label { Text=text};
                    tableLayoutPanel.Controls.Add(l,j,i);
                }
            }
            this.Controls.Add(tableLayoutPanel);
        }
    }
}
