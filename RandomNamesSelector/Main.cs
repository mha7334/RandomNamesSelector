using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNamesSelector
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            LoadAllMembers();
        }

        private void LoadAllMembers()
        {
            
            List<string> membersList = new List<string>();
            string[] lines = System.IO.File.ReadAllLines(@"members.txt");

            foreach (string line in lines)
            {
                membersList.Add(line);
            }


            //membersList.Add("Muhammad Nadeem");
            //membersList.Add("Sajid Butt");
            //membersList.Add("Sajid Tamboli");
            //membersList.Add("Nauman Iftikhar");
            //membersList.Add("Adnan Mehmood");
            //membersList.Add("Zia Ur Rehman");
            //membersList.Add("Muhammad Arshad");
            //membersList.Add("Jawad");
            //membersList.Add("Sibtan");
            //membersList.Add("Haresh");
            //membersList.Add("Ahmad Sabri");
            //membersList.Add("Yasin");
            //membersList.Add("Mudassar");
            //membersList.Add("Wasim");

            foreach (var member in membersList)
            {
                lstNames.Items.Add(member);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtName.Text))
                lstNames.Items.Add(txtName.Text);
        }

        private void btnResetNames_Click(object sender, EventArgs e)
        {
            lstNames.Items.Clear();
        }


        private void Remove(object sender, EventArgs e)
        {
            var selectedIndeces = lstNames.SelectedIndices;
            foreach (var ind in selectedIndeces)
            {
                lstNames.Items.RemoveAt((int)ind);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
             
            var success = int.TryParse(txtHowmany.Text, out int res);

            if(!success)
            {
                MessageBox.Show(@"Should be an integer");
                return;
            }

            lstResult.Items.Clear();
            List<string> list = new List<string>();

            foreach (var item in lstNames.Items)
            {
                list.Add(item.ToString());
            }
                
            var result = list.OrderBy(s => Guid.NewGuid());

           
            foreach (var listItem in result.Take(int.Parse(txtHowmany.Text)))
            {
                
                    lstResult.Items.Add(listItem);
                
                
            }
           
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            lstNames.Items.Clear();
            LoadAllMembers();
        }

        private void btnResetResult_Click_1(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
        }
    }
}
