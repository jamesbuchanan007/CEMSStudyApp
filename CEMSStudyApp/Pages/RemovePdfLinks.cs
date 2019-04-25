using System;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text.pdf;

namespace CEMSStudyApp.Pages
{
    public partial class RemovePdfLinks : Form
    {
        public RemovePdfLinks()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Exit Hyperlink Removal Process?", "CEMS Study App", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Hide();
            }
        }

        private void buttonInputPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxInput.Text = fbd.SelectedPath;
            }
        }

        private void buttonOutputPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxOutput.Text = fbd.SelectedPath;
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var doubleCheck = MessageBox.Show("Are You Sure?", "CEMS Study App", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (doubleCheck != DialogResult.Yes) return;

            //GET FILE NAMES FROM SELECTED FOLDER
            try
            {
                DirectoryInfo d = new DirectoryInfo(textBoxInput.Text);
                FileInfo[] files = d.GetFiles("*.pdf");
                string str = "";

                foreach (FileInfo file in files)
                {
                    var inputPath = textBoxInput.Text + @"\" + file.Name;
                    var outputPath = textBoxOutput.Text + @"\ " + file.Name;

                    RemoveAnnotations(inputPath, outputPath);
                }

                MessageBox.Show("Completed", "CEMS Study App", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Could not complete... " + exception.ToString());
                throw;
            }
            
        }

        private void RemoveAnnotations(string inputPath, string outputPath)
        {
            PdfReader pdfReader = new PdfReader(inputPath);
            PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(outputPath, FileMode.Create));

            pdfReader.RemoveAnnotations();
            pdfStamper.Close();
        }
    }
}
