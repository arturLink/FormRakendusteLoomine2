using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormRakendusteLoomine2
{
    public class PiltideLeidmise : Form
    {
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

        }
    }
}
