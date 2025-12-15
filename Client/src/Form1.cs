using System;
using System.Windows.Forms;

namespace Charakter_sheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Horde holder";
            this.Size = new System.Drawing.Size(400, 300);
            Label label = new Label();
            label.Text = "Witaj w aplikacji Horde holder!";
            label.Location = new System.Drawing.Point(10, 10);
            this.Controls.Add(label);
        }
    }
}