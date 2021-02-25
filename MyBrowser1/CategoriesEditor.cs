using System;
using System.Windows.Forms;

namespace MyBrowser1
{
    public partial class CategoriesEditor : Form
    {
        public string CategoryName { get; set; }
        public string ButtonName { get; set; }
        public CategoriesEditor()
        {
            InitializeComponent();
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            if (categoryName.Text == "")
            {
                MessageBox.Show("Not entered name of category", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CategoryName = categoryName.Text;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void CategoriesEditor_Load(object sender, EventArgs e)
        {
            actionButton.Text = ButtonName;
        }
    }
}
