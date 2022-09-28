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
        public MatQuiz()
        {
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

            };
            this.Controls.Add(timelbl);

            timeleftlbl = new Label()
            {
                Text = "Time Left",
            };

        }
    }
}
