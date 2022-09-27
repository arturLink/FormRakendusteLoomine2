using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormRakendusteLoomine2
{
    public class PiltVaatamine : Form
    {


        PictureBox pilt;
        TableLayoutPanel tableLayoutPanel1;
        public PiltVaatamine()
        {
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Text = "Pildid";

            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.Controls.Add(this.tableLayoutPanel1);

            pilt = new PictureBox()
            {
                Image = new Bitmap("snow.jpg"),
                BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D,
                Dock = System.Windows.Forms.DockStyle.Fill,
                Location = new System.Drawing.Point(2, 2),
                Size = new System.Drawing.Size(100,100),
                TabIndex = 0,
                TabStop = false
            };
            tableLayoutPanel1.Controls.Add(pilt,0,0);
            tableLayoutPanel1.SetCellPosition(pilt, new TableLayoutPanelCellPosition(0, 0));
            tableLayoutPanel1.SetColumnSpan(pilt, 2);

            
        }
    }
}
