using System;
using System.Text;

namespace LastWhitespaceRemoval
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnOpenDialog_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    this.tbPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string[] patterns = this.tbExtensions.Text.Split(",");
            List<string> files = new List<string>();
            foreach (string pattern in patterns)
            {
                files.AddRange(Directory.GetFiles(this.tbPath.Text, pattern.Trim()));
            }
            files = files.Distinct().ToList();
            this.pbFiles.Maximum = files?.Count ?? 0;
            foreach (string file in files ?? new List<string>())
            {
                if (this.pbFiles.Value < this.pbFiles.Maximum)
                    this.pbFiles.Value++;
                string[] fileLines = File.ReadAllLines(file, new UTF8Encoding(true));
                if (fileLines != null)
                {
                    for (int i = 0; i < fileLines.Length; i++)
                    {
                        fileLines[i] = fileLines[i].TrimEnd();
                    }
                    if (fileLines.Length > 1)
                    {
                        fileLines[^1] = fileLines[^1].TrimEnd(new char[] { '\r', '\n' });

                        //File.WriteAllLines(file, fileLines, Encoding.UTF8);

                        using (StreamWriter writer = new StreamWriter(file, false, new UTF8Encoding(true)))
                        {
                            for (int i = 0; i < fileLines.Length; i++)
                            {
                                if (i != fileLines.Length - 1)
                                {
                                    writer.WriteLine(fileLines[i]); // Для остальных строк используем WriteLine
                                }
                                else
                                {
                                    writer.Write(fileLines[i]); // Для последней строки используем Write
                                }
                            }
                        }
                    }
                }
            }
            this.pbFiles.Value = 0;
        }
    }
}