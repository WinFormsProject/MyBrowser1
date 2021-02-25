using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyBrowser1
{
    public partial class SitesEditor : Form
    {
        public string SiteName { get; set; }
        public string URL { get; set; }
        public string ButtonName { get; set; }
        public Database1Entities Database1 { get; set; }
        public SitesEditor(ComboBox combo)
        {
            InitializeComponent();
            categSelector.DataSource = (List<Categories>)combo.DataSource;
            categSelector.DisplayMember = "Name";
            categSelector.ValueMember = "Id";
            categSelector.SelectedIndex = 0;
        }

        private bool IsUrlValid(string url)
        {
            return Regex.IsMatch(url, @"(http|https)://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?");
        }
        private void action_Click(object sender, EventArgs e)
        {
            if(siteName.Text == "" || urlBox1.Text == "")
            {
                MessageBox.Show("Not entered name of site or Url", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SiteName = siteName.Text;
                URL = urlBox1.Text;
                if (URL.IndexOf("http") == -1)
                    URL = $"https://{URL}";
                if (IsUrlValid(URL))
                {
                    Database1 = ActionAdd(URL, SiteName, Database1);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid Url", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void SitesEditor_Load(object sender, EventArgs e)
        {
            actionButton.Text = ButtonName;
        }
        private Database1Entities ActionAdd(string address, string name, Database1Entities db)
        {

            db.Sites.Add(new Sites()
            {
                Address = address,
                Name = name,
                CategoryID = categSelector.SelectedIndex + 1,
                Categories = categSelector.SelectedItem as Categories
            });
            return db;
        }
    }
}
