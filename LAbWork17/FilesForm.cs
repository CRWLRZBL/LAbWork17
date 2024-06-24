using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LAbWork17
{
    public partial class FilesForm : Form
    {
        FileInfo[] GetFiles(string directoryName)
        {
            DirectoryInfo directory = new DirectoryInfo(directoryName);
            return directory.GetFiles("*", SearchOption.AllDirectories);
        }


        public FilesForm()
        {
            InitializeComponent();
        }

        private void Task1Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(userInputTextBox.Text);

            var results = files
                .Select(f => new { f.Name, f.DirectoryName, f.CreationTime, f.Length })
                .OrderBy(f => f.Name)
                .ThenByDescending(f => f.CreationTime);

            FilesDataGridView.DataSource = results.ToList();
        }

        private void Task2Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(userInputTextBox.Text);

            var results = files.Select(f => new { f.Extension }).Distinct();

            FilesDataGridView.DataSource = results.ToList();
        }

        private void Task3Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(userInputTextBox.Text);

            var results = files
                .GroupBy(f => f.Extension)
                .Select(group => new
                {
                    Extension = group.Key,
                    Count = group.Count()
                });

            FilesDataGridView.DataSource = results.ToList();
        }

        private void Task4Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(userInputTextBox.Text);

            var results = files
                .Select(f => new { f.Name })
                .Where(file => file.Name == foundTextBox.Text);

            FilesDataGridView.DataSource = results.ToList();
        }

        private void Task5Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(userInputTextBox.Text);

            var results = files.Select(file => new { file.Name, file.DirectoryName, file.CreationTime, file.Length })
                .Where(file => file.CreationTime.Day == DateTime.Today.Day)
                .Take(5);

            FilesDataGridView.DataSource = results.ToList();
        }
    }
}
