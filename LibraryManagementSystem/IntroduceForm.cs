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
    public partial class IntroduceForm : Form
    {
        public IntroduceForm()
        {
            InitializeComponent();
            SetupComponent();
        }


		private void SetupComponent()
		{
			StartPosition = FormStartPosition.CenterScreen;
			pictureBoxLogoImage.SizeMode = PictureBoxSizeMode.Zoom;
		}

	}
}
