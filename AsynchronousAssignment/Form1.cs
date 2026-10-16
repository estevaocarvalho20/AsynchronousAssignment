
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BookWordFrequency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //estevao Previatti
        private void btnBrowseBookOne_Click(object sender, EventArgs e)
        {
            using OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "Text Files (*.txt)|*.txt";
            fileDialog.Title = "Select the First Book";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
               
                txtBookOnePath.Text = Path.GetFileName(fileDialog.FileName);
                txtBookOnePath.Tag = fileDialog.FileName;
            }
        }

        private void btnBrowseBookTwo_Click(object sender, EventArgs e)
        {
            using OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "Text Files (*.txt)|*.txt";
            fileDialog.Title = "Select the Second Book";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                
                txtBookTwoPath.Text = Path.GetFileName(fileDialog.FileName);
                txtBookTwoPath.Tag = fileDialog.FileName;
            }
        }

        // Estevao Previatti
        private async void btnSubmit_Click(Object sender, EventArgs e)
        {
            lstBookOneWords.Items.Clear();
            lstBookTwoWords.Items.Clear();
            btnSubmit.Enabled = false;

           
            string firstBookPath = txtBookOnePath.Tag as string ?? txtBookOnePath.Text;
            string secondBookPath = txtBookTwoPath.Tag as string ?? txtBookTwoPath.Text;

            if (!File.Exists(firstBookPath) || !File.Exists(secondBookPath))
            {
                MessageBox.Show("Please select two valid text files.");
                btnSubmit.Enabled = true;
                return;
            }

            var firstTask = ReadBook(firstBookPath);
            var secondTask = ReadBook(secondBookPath);

            try
            {
                await Task.WhenAll(firstTask, secondTask);

                foreach (var s in await firstTask)
                    lstBookOneWords.Items.Add(s);

                foreach (var s in await secondTask)
                    lstBookTwoWords.Items.Add(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing files: " + ex.Message);
            }
            finally
            {
                btnSubmit.Enabled = true;
            }
        }

        // Estevao Previatti
        private async Task<List<string>> ReadBook(string filename)
        {
            
            var text = await File.ReadAllTextAsync(filename);

           
            var cleaned = Regex.Replace(text.ToLowerInvariant(), "[^a-z\\s]", " ");

            var words = cleaned
                .Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            var wordDic = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            foreach (var w in words)
            {
                if (wordDic.ContainsKey(w))
                    wordDic[w]++;
                else
                    wordDic[w] = 1;
            }

            var top10 = wordDic
                .Where(kv => !string.IsNullOrWhiteSpace(kv.Key))
                .OrderByDescending(kv => kv.Value)
                .ThenBy(kv => kv.Key)
                .Take(10)
                .Select(kv => $"{kv.Key} - {kv.Value}")
                .ToList();

            return top10;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstBookOneWords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstBookTwoWords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
