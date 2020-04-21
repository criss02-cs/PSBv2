using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomListBox
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            listBox1.Visible = false;
            this.BackColor = Color.Transparent;
            label1.Text = Title;
            
        }

        private string title;

        public ListBox ListBox1
        {
            get => listBox1;
            set => listBox1 = value;
        }

        public string Title
        {
            get => title;
            set => title = value;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            listBox1.Visible = !listBox1.Visible;
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if(e.State == DrawItemState.Selected)
                e.Graphics.FillRectangle(Brushes.MediumSpringGreen, e.Bounds);
            using (SolidBrush b = new SolidBrush(e.ForeColor))
            {
                e.Graphics.DrawString(listBox1.GetItemText(listBox1.Items), e.Font, b, e.Bounds);
            }
            e.DrawFocusRectangle();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = !listBox1.Visible;
        }
    }
}
