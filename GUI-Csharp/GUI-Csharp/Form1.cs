using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Csharp
{
    
    public partial class Form1 : Form
    {
        Button B = new Button();
        TextBox T = new TextBox();
        RadioButton R = new RadioButton();
        private void Test(object sender, EventArgs e)
        {
            MessageBox.Show ("   Welocm");
        }

        public Form1()
        {
            InitializeComponent();
            //---------------------------
            Controls.Add(B);
            B.Name = "Frist";
            B.Text = "OK";
            B.Location = new Point(188, 280);
            B.Size = new Size(85,45);
            B.MouseClick += Test;
            //----------------------------
            Controls.Add(T);
            T.Name = "text";
            T.Location = new Point(176, 220);
            T.Size = new Size(100, 100);
            //----------------------------
            Controls.Add(R);
            R.Location = new Point(150, 120);
            R.Text = "Hello";
        }
    }
}
