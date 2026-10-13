using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

using Microsoft.Deployment.Compression.Cab;
using Microsoft.Deployment.Compression;

namespace WSPRepackage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var values = Enum.GetValues(typeof(CompressionLevel)).Cast<CompressionLevel>().ToList();
            cbCompressionLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCompressionLevel.DataSource = values;

            if (values.Contains(CompressionLevel.Max))
                cbCompressionLevel.SelectedItem = CompressionLevel.Normal;
        } 

        private void btn_src_Click(object sender, EventArgs e)
        {
            
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbSourceDirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_dir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbOutputDirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_repackage_Click(object sender, EventArgs e)
        {
            try
            {
                var compression = CompressionLevel.Normal;
                if (cbCompressionLevel.SelectedItem is CompressionLevel selected)
                    compression = selected;

                var outputFile = Path.Combine(tbOutputDirectory.Text, tbWSPFilename.Text + ".wsp");
                var cab = new CabInfo(outputFile);
                cab.Pack(tbSourceDirectory.Text, true, compression, null);

                MessageBox.Show("WSP created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://handsonsharepoint.net/");
        }
       
    }   
}