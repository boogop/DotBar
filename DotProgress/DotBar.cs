using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotProgress
{
    public partial class DotBar: UserControl
    {
        private Color _bgColor;

        public Color theBGColor
        {
            get { return _bgColor; }
            set
            {
                _bgColor = value;
                this.BackColor = _bgColor;
                this.Update();
            }
        }


        int count = 0;

        public DotBar()
        {
            InitializeComponent();
        }


        public void reset()
        {
            count = -1;
            foreach (Control ctrControl in this.Controls)
            {
                if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.PictureBox)))
                    ((System.Windows.Forms.PictureBox)ctrControl).Image = Properties.Resource1.of;
            }
        }

        public void increment()
        {
            switch (count)
            {
                case 0:
                    pictureBox1.Image = Properties.Resource1.on;
                    break;
                case 1:
                    pictureBox2.Image = Properties.Resource1.on;
                    break;
                case 2:
                    pictureBox3.Image = Properties.Resource1.on;
                    break;
                case 3:
                    pictureBox4.Image = Properties.Resource1.on;
                    break;
                case 4:
                    pictureBox5.Image = Properties.Resource1.on;
                    break;
                case 5:
                    pictureBox6.Image = Properties.Resource1.on;
                    break;
                case 6:
                    pictureBox7.Image = Properties.Resource1.on;
                    break;
                case 7:
                    pictureBox8.Image = Properties.Resource1.on;
                    break;
                case 8:
                    pictureBox9.Image = Properties.Resource1.on;
                    break;
                case 9:
                    pictureBox10.Image = Properties.Resource1.on;
                    break;
                default:
                    reset();
                    break;
            }

            count++;
        }
    }
}
