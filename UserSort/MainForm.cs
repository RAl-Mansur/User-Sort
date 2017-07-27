﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserSort.Classes;

namespace UserSort
{
    public partial class MainForm : Form
    {

        private string[] selectedFiles;
        private List<User> users = new List<User>();

        public MainForm()
        {
            InitializeComponent();
        }

        // Display Open File Dialog box to allow users to select CVS, JSON and XML files
        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Files";
                ofd.Filter = "Data Files (*.csv, *.json, *.xml)| *.csv; *.json; *.xml|All Files (*.*)|*.*";
                ofd.RestoreDirectory = true;
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedFiles = ofd.FileNames;
                    btnSelect.Enabled = false;
                }
            }
        }

        // Import selected files
        private void btnImport_Click(object sender, EventArgs e)
        {
            foreach (string file in selectedFiles)
            {

                string fileExtension = Path.GetExtension(file);

                if (fileExtension == ".json")
                {
                    users.AddRange(ImportFiles.LoadJSON(file));
                } else if (fileExtension == ".xml")
                {
                    users.AddRange(ImportFiles.LoadXML(file));
                } else if (fileExtension == ".csv")
                {

                }
            }
        }

        
    }
}