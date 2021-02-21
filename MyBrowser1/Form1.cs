using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBrowser1
{
    public partial class Form1 : Form
    {
        Database1Entities db = new Database1Entities();
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadCategories()
        {
            var categoriesList = db.Categories.ToList();
            comboBox1.DataSource = categoriesList;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedIndex = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.bing.com");
            LoadCategories();
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            urlBox.Text = webBrowser1.Url.ToString();
        }

        private void urlBox_Click(object sender, EventArgs e)
        {
            urlBox.SelectAll();
        }
        private void GoToSite()
        {
            string address = urlBox.Text;
            if(address=="")
            {
                MessageBox.Show("Not entered address of page", "Warning", 
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if(address.IndexOf(".") == -1)
                {
                    address = $"https://www.google.com/search?q={address}";
                }
                else if(address.IndexOf("http") == -1)
                {
                    address = $"https://{address}";
                }
                webBrowser1.Navigate(address);
            }
        }

        private void goPage_Click(object sender, EventArgs e)
        {
            GoToSite();
        }

        private void urlBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                GoToSite();
        }

        private void prevPage_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }

        private void nextPage_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }

        private void homePage_Click(object sender, EventArgs e)
        {
            //webBrowser1.GoHome();
            webBrowser1.Navigate("https://www.bing.com");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k = comboBox1.SelectedIndex;
            if(k != -1)
            {
                var siteslist = (comboBox1.SelectedItem as Categories).Sites.ToList();
                listBox1.DataSource = siteslist;
                listBox1.DisplayMember = "Name";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int k = listBox1.SelectedIndex;
            if (k != -1)
            {
                string url = (listBox1.SelectedItem as Sites).Address;
                webBrowser1.Navigate(url);
            }
        }

        private void addCategory_Click(object sender, EventArgs e)
        {
            CategoriesEditor editor = new CategoriesEditor();
            editor.ButtonName = "ADD CATEGORY";
            if(editor.ShowDialog() == DialogResult.OK)
            {
                db.Categories.Add(new Categories() { Name = editor.CategoryName });
                db.SaveChanges();
                MessageBox.Show("Category succesfully added", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategories();
            }
        }

        private void delCategory_Click(object sender, EventArgs e)
        {
            
            CategoriesEditor editor = new CategoriesEditor();
            var category = db.Categories.Where(c => c.Name == editor.CategoryName).FirstOrDefault();
            if(category != null)
            {
                db.Categories.Remove(category);
                db.SaveChanges();
            }
            editor.ButtonName = "ADD CATEGORY";
            if (editor.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
