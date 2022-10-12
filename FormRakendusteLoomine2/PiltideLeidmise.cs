using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormRakendusteLoomine2
{
    public class PiltideLeidmise : Form
    {
        Random random = new Random();
        List<string> iconsLihtne = new List<string>()
    {
        "!", "!", "N", "N"
    };
        List<string> iconsKeskmine = new List<string>()
    {
        "!", "!", "N", "N", ",", ",", "k", "k"
    };
        List<string> iconsRaske = new List<string>()
    {
        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"
    };

        public Timer timer = new Timer { Interval = 750 };

        Label firstClicked = null;
        Label secondClicked = null;

        Button lihtne, keskmine, raske;

        Label lbl1;
        TableLayoutPanel tableLayoutPanel1;
        public PiltideLeidmise()
        {
            this.Size = new System.Drawing.Size(550,650);
            this.Text = "Piltide Leidmise Mäng";
            this.MaximizeBox = false;

            lihtne = new Button()
            {
                Text = "Lihtne",
                ForeColor = Color.Black,
                BackColor = Color.White,
                Width = 100,
                Height = 25,
                Location = new Point(100, 550)
            };
            this.Controls.Add(lihtne);
            lihtne.Click += Raskusi_Click;
            keskmine = new Button()
            {
                Text = "Keskmine",
                ForeColor = Color.Black,
                BackColor = Color.White,
                Width = 100,
                Height = 25,
                Location = new Point(200, 550)
            };
            this.Controls.Add(keskmine);
            keskmine.Click += Raskusi_Click;
            raske = new Button()
            {
                Text = "Raske",
                ForeColor = Color.Black,
                BackColor = Color.White,
                Width = 100,
                Height = 25,
                Location = new Point(300, 550)
            };
            this.Controls.Add(raske);
            raske.Click += Raskusi_Click;

            tableLayoutPanel1 = new TableLayoutPanel()
            {
                ColumnCount = 4,
                Location = new System.Drawing.Point(3, 4),
                Name = "tableLayoutPanel1",
                RowCount = 4,
                Size = new System.Drawing.Size(527, 506),
                TabIndex = 0,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset,
                BackColor = System.Drawing.Color.CornflowerBlue,
            };
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));

            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));

            this.Controls.Add(this.tableLayoutPanel1);


            //int rida = 0;
            //int veerg = 0;
            //for (int i = 0; i <= 15; i++)
            //{
            //    lbl1 = new Label()
            //    {
            //        BackColor = System.Drawing.Color.CornflowerBlue,
            //        AutoSize = false,
            //        Dock = System.Windows.Forms.DockStyle.Fill,
            //        TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //        Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //        Text = "c",
            //    };
            //    tableLayoutPanel1.Controls.Add(lbl1, rida, veerg);
            //    rida++;
            //    lbl1.ForeColor = lbl1.BackColor;
            //    lbl1.Click += Lbl1_Click;
            //}
            //veerg++;
            //rida = 0;

            //timer.Tick += Timer_Tick;
            //AssignIconsToSquares();
        }

        private void Raskusi_Click(object sender, EventArgs e)
        {
            Button nupp_sender = (Button)sender;
            if (nupp_sender.Text == "Lihtne")
            {
                tableLayoutPanel1.RowCount = 2;
                tableLayoutPanel1.ColumnCount = 2;
                int rida = 0;
                int veerg = 0;
                keskmine.Hide();
                raske.Hide();
                lihtne.Enabled = false;
                for (int i = 0; i <= 3; i++)
                {
                    lbl1 = new Label()
                    {
                        BackColor = System.Drawing.Color.CornflowerBlue,
                        AutoSize = false,
                        Dock = System.Windows.Forms.DockStyle.Fill,
                        TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                        Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
                        Text = "c",
                    };
                    tableLayoutPanel1.Controls.Add(lbl1, rida, veerg);
                    rida++;
                    lbl1.ForeColor = lbl1.BackColor;
                    lbl1.Click += Lbl1_Click;
                }
                veerg++;
                rida = 0;

                timer.Tick += Timer_Tick;
                AssignIconsToSquaresLihtne();
            }
            else if(nupp_sender.Text == "Keskmine")
            {
                tableLayoutPanel1.RowCount = 4;
                tableLayoutPanel1.ColumnCount = 2;
                int rida = 0;
                int veerg = 0;
                lihtne.Hide();
                raske.Hide();
                keskmine.Enabled = false;
                for (int i = 0; i <= 7; i++)
                {
                    lbl1 = new Label()
                    {
                        BackColor = System.Drawing.Color.CornflowerBlue,
                        AutoSize = false,
                        Dock = System.Windows.Forms.DockStyle.Fill,
                        TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                        Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
                        Text = "c",
                    };
                    tableLayoutPanel1.Controls.Add(lbl1, rida, veerg);
                    rida++;
                    lbl1.ForeColor = lbl1.BackColor;
                    lbl1.Click += Lbl1_Click;
                }
                veerg++;
                rida = 0;

                timer.Tick += Timer_Tick;
                AssignIconsToSquaresKeskmine();
            }
            else if(nupp_sender.Text == "Raske")
            {
                tableLayoutPanel1.RowCount = 4;
                tableLayoutPanel1.ColumnCount = 4;
                int rida = 0;
                int veerg = 0;
                lihtne.Hide();
                keskmine.Hide();
                raske.Enabled = false;
                for (int i = 0; i <= 15; i++)
                {
                    lbl1 = new Label()
                    {
                        BackColor = System.Drawing.Color.CornflowerBlue,
                        AutoSize = false,
                        Dock = System.Windows.Forms.DockStyle.Fill,
                        TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                        Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
                        Text = "c",
                    };
                    tableLayoutPanel1.Controls.Add(lbl1, rida, veerg);
                    rida++;
                    lbl1.ForeColor = lbl1.BackColor;
                    lbl1.Click += Lbl1_Click;
                }
                veerg++;
                rida = 0;

                timer.Tick += Timer_Tick;
                AssignIconsToSquaresRaske();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void Lbl1_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }
                
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                CheckForWinner();

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                timer.Start();
            }
        }
        public void AssignIconsToSquaresLihtne()
        {

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(iconsLihtne.Count);
                    iconLabel.Text = iconsLihtne[randomNumber];
                    iconsLihtne.RemoveAt(randomNumber);
                }
            }
        }
        public void AssignIconsToSquaresKeskmine()
        {

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(iconsKeskmine.Count);
                    iconLabel.Text = iconsKeskmine[randomNumber];
                    iconsKeskmine.RemoveAt(randomNumber);
                }
            }
        }
        public void AssignIconsToSquaresRaske()
        {

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(iconsRaske.Count);
                    iconLabel.Text = iconsRaske[randomNumber];
                    iconsRaske.RemoveAt(randomNumber);
                }
            }
        }
        public void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            MessageBox.Show("You matched all the icons!", "Congratulations");
            Close();
        }
    }
}
