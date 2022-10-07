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
        List<string> icons = new List<string>()
    {
        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"
    };

        public Timer timer = new Timer { Interval = 750 };

        Label firstClicked = null;
        Label secondClicked = null;

        Label lbl1;
        TableLayoutPanel tableLayoutPanel1;
        public PiltideLeidmise()
        {
            this.Size = new System.Drawing.Size(550,550);
            this.Text = "Piltide Leidmise Mäng";
            this.MaximizeBox = false;

            

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

            List<Label> lblList = new List<Label>();
            int veerg = 0;
            int riida = 0;

            for (int i = 0; i <= 15; i++)
            {
                var lbl1 = new Label()
                {
                    BackColor = System.Drawing.Color.CornflowerBlue,
                    AutoSize = false,
                    Dock = System.Windows.Forms.DockStyle.Fill,
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
                    Text = "c",
                };
                //zakon4i tsikl
                lblList.Add(lbl1);
                for (int r = 0; r < 3; riida++)
                {
                    
                }
                
                lbl1.ForeColor = lbl1.BackColor;
                lbl1.Click += Lbl1_Click;
            }

            ////1 veerg
            //lbl1 = new Label()
            //{
            //    BackColor= System.Drawing.Color.CornflowerBlue,
            //    AutoSize=false,
            //    Dock=System.Windows.Forms.DockStyle.Fill,
            //    TextAlign=System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl1, 0, 0);
            //lbl1.ForeColor = lbl1.BackColor;
            //lbl1.Click += Lbl1_Click;
            //lbl1 = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl1, 0, 1);
            //lbl1.ForeColor = lbl1.BackColor;
            //lbl1.Click += Lbl1_Click;
            //lbl1 = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl1, 0, 2);
            //lbl1.ForeColor = lbl1.BackColor;
            //lbl1.Click += Lbl1_Click;
            //lbl1 = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl1, 0, 3);
            //lbl1.ForeColor = lbl1.BackColor;
            //lbl1.Click += Lbl1_Click;
            ////2 veerg
            //lbl1 = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl1, 1, 0);
            //lbl1.ForeColor = lbl1.BackColor;
            //lbl1.Click += Lbl1_Click;
            //lbl1 = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl1, 1, 1);
            //lbl1.ForeColor = lbl1.BackColor;
            //lbl1.Click += Lbl1_Click;
            //lbl1 = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl1, 1, 2);
            //lbl1.ForeColor = lbl1.BackColor;
            //lbl1.Click += Lbl1_Click;
            //lbl1 = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl1, 1, 3);
            //lbl1.ForeColor = lbl1.BackColor;
            //lbl1.Click += Lbl1_Click;
            ////3 veerg
            //lbl1 = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl1, 2, 0);
            //lbl1.ForeColor = lbl1.BackColor;
            //lbl1.Click += Lbl1_Click;
            //lbl1 = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl1, 2, 1);
            //lbl1.ForeColor = lbl1.BackColor;
            //lbl1.Click += Lbl1_Click;
            //lbl1 = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl1, 2, 2);
            //lbl1.ForeColor = lbl1.BackColor;
            //lbl1.Click += Lbl1_Click;
            //lbl1 = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl1, 2, 3);
            //lbl1.ForeColor = lbl1.BackColor;
            //lbl1.Click += Lbl1_Click;
            ////4 veerg
            //lbl1 = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl1, 3, 0);
            //lbl1.ForeColor = lbl1.BackColor;
            //lbl1.Click += Lbl1_Click;
            //lbl1 = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl1, 3, 1);
            //lbl1.ForeColor = lbl1.BackColor;
            //lbl1.Click += Lbl1_Click;
            //lbl1 = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl1, 3, 2);
            //lbl1.ForeColor = lbl1.BackColor;
            //lbl1.Click += Lbl1_Click;
            //lbl1 = new Label()
            //{
            //    BackColor = System.Drawing.Color.CornflowerBlue,
            //    AutoSize = false,
            //    Dock = System.Windows.Forms.DockStyle.Fill,
            //    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
            //    Font = new System.Drawing.Font("Webdings", 48, System.Drawing.FontStyle.Bold),
            //    Text = "c",
            //};
            //tableLayoutPanel1.Controls.Add(lbl1, 3, 3);
            //lbl1.ForeColor = lbl1.BackColor;
            //lbl1.Click += Lbl1_Click;

            timer.Tick += Timer_Tick;
        AssignIconsToSquares();
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

        public void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    icons.RemoveAt(randomNumber);
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
