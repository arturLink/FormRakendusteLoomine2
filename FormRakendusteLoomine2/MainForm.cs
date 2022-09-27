using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormRakendusteLoomine2
{
    public partial class MainForm : Form
    {
        Button Pildid;
        Button MatMang;
        Button PiltMang;
        public MainForm()
        {
            Height = 720;
            Width = 1280;
            BackColor = Color.LightBlue;
            ForeColor = Color.Black;
            Text = "Peamine Vorm";

            Pildid = new Button();
            Pildid.Text = "Pildi vaatamise";
            Pildid.ForeColor = Color.Black;
            Pildid.BackColor = Color.White;
            Pildid.Width = 150;
            Pildid.Height = 50;
            Pildid.Location = new Point(150, 300);
            this.Controls.Add(Pildid);
            Pildid.Click += Pildid_Click;

            MatMang = new Button();
            MatMang.Text = "Matemaatiline äraarvamismäng";
            MatMang.ForeColor = Color.Black;
            MatMang.BackColor = Color.White;
            MatMang.Width = 150;
            MatMang.Height = 50;
            MatMang.Location = new Point(550, 300);
            this.Controls.Add(MatMang);

            PiltMang = new Button();
            PiltMang.Text = "Piltide leidmise mäng";
            PiltMang.ForeColor = Color.Black;
            PiltMang.BackColor = Color.White;
            PiltMang.Width = 150;
            PiltMang.Height = 50;
            PiltMang.Location = new Point(950, 300);
            this.Controls.Add(PiltMang);
        }

        private void Pildid_Click(object sender, EventArgs e)
        {
            PiltVaatamine piltVaatamine = new PiltVaatamine();
            piltVaatamine.ShowDialog();
        }
    }
}
