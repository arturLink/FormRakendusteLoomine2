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
        NumericUpDown[] vastused = new NumericUpDown[4];
        Timer timer = new Timer { Interval = 1000 };

        Timer kiirustTimer = new Timer { Interval = 10000 };

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
            this.ClientSize = new System.Drawing.Size(700, 400);
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
                Location = new System.Drawing.Point(100,0),
                Size = new System.Drawing.Size(200,30),
            };
            this.Controls.Add(timeleftlbl);

            tableLayoutPanel = new TableLayoutPanel()
            {
                AutoSize = true,
                ColumnCount = 5,
                RowCount = 4,
                Location = new System.Drawing.Point(0,60),
                BackColor = System.Drawing.Color.White,
            };
            this.Controls.Add(tableLayoutPanel);

            l_nimed = new string[5, 4];
            timer.Enabled = true;
            //this.DoubleClick += MatQuiz_DoubleClick;
            timer.Tick += Timer_Tick;
            //kiirustTimer.Enabled = true;
            kiirustTimer.Tick += KiirustTimer_Tick;
            for (int i = 0; i < 4; i++)
            {
                tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25));
                for (int j = 0; j < 5; j++)
                {
                    tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20));
                    var l_nimi = "L" + j.ToString() + i.ToString();
                    l_nimed[j, i] = l_nimi;
                    if (j == 1) { text = tehed[i]; }
                    else if (j == 3) { text = "="; }
                    else if (j == 4) { text = "vastus"; }
                    else if (j == 0)
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
                    if (j == 4)
                    {
                        vastused[i] = new NumericUpDown
                        {
                            Name = tehed[i],
                            DecimalPlaces = 5,
                            Minimum = -20,
                        };
                        tableLayoutPanel.Controls.Add(vastused[i], j, i);
                    }
                    else
                    {
                        Label l = new Label { Text = text };
                        tableLayoutPanel.Controls.Add(l, j, i);
                    }

                }
            }
            this.Controls.Add(tableLayoutPanel);
            this.Controls.Add(timelbl);
        }

        private void KiirustTimer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("kiiremini lolligas !!!!");
        }

        private void MatQuiz_DoubleClick(object sender, EventArgs e)
        {
            timer.Start();
            timelbl.Text = timer.ToString();
            //tableLayoutPanel.Controls.Add(timelbl);
        }

        int tik = 0;
        //private void Matem_DoubleClick(object sender, EventArgs e)
        //{
        //    timer.Start();
        //    timelbl.Text = timer.ToString();
        //    tableLayoutPanel.Controls.Add(timelbl);
        //}
        private bool Kontroll()
        {
            if (num1[0] + num2[0] == vastused[0].Value &&
                num1[1] - num2[1] == vastused[1].Value &&
                num1[2] / num2[2] == vastused[2].Value &&
                num1[3] * num2[3] == vastused[3].Value)
            {
                return true;
            }
            else return false;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            tik++;
            timelbl.Text = tik.ToString();
            if (Kontroll())
            {
                timer.Stop();
                MessageBox.Show("Sinu vastused on õiged", "Palju õnne!");
            }
        }
    }
}
