using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_UI
{
    public partial class SupportForm : Form
    {
        public SupportForm()
        {
            InitializeComponent();
			SetupComponent();
        }


		private void SetupComponent()
		{
			//Set up Form
			StartPosition = FormStartPosition.CenterScreen;

			//Set up PictureBox
			pictureBoxLogoImage.SizeMode = PictureBoxSizeMode.Zoom;
		}

	}
}
