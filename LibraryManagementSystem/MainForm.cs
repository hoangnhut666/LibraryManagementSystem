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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SetupComponent();
            timer1.Start();
        }


        private void SetupComponent()
        {
            //Set up Form
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuItemAuthorManagement_Click(object sender, EventArgs e)
        {
            var authorManagementForm = new AuthorManagementForm();
            EmbedFormIntoPanel(authorManagementForm);
        }

        private void menuItemBookManagement_Click(object sender, EventArgs e)
        {
            var bookManagementForm = new BookManagementForm();
            EmbedFormIntoPanel(bookManagementForm);
        }

        //Embed another form into the panel of main screen
        private void EmbedFormIntoPanel(Form form)
        {
            // Dispose the old form if present
            if (panelMainContainer.Controls.Count > 0)
            {
                var oldForm = panelMainContainer.Controls[0] as Form;
                oldForm?.Dispose();
            }

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelMainContainer.Controls.Clear();
            panelMainContainer.Controls.Add(form);
            form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
