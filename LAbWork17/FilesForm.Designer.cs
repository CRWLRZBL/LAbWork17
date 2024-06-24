namespace LAbWork17
{
    partial class FilesForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FilesDataGridView = new System.Windows.Forms.DataGridView();
            this.userInputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Task1Button = new System.Windows.Forms.Button();
            this.Task2Button = new System.Windows.Forms.Button();
            this.Task3Button = new System.Windows.Forms.Button();
            this.Task4Button = new System.Windows.Forms.Button();
            this.foundTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Task5Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FilesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FilesDataGridView
            // 
            this.FilesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.FilesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilesDataGridView.Location = new System.Drawing.Point(38, 73);
            this.FilesDataGridView.Name = "FilesDataGridView";
            this.FilesDataGridView.Size = new System.Drawing.Size(1061, 449);
            this.FilesDataGridView.TabIndex = 0;
            // 
            // userInputTextBox
            // 
            this.userInputTextBox.Location = new System.Drawing.Point(209, 16);
            this.userInputTextBox.Name = "userInputTextBox";
            this.userInputTextBox.Size = new System.Drawing.Size(271, 20);
            this.userInputTextBox.TabIndex = 1;
            this.userInputTextBox.Text = "V:\\ispp21";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Укажите полный путь к папке";
            // 
            // Task1Button
            // 
            this.Task1Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Task1Button.Location = new System.Drawing.Point(38, 537);
            this.Task1Button.Name = "Task1Button";
            this.Task1Button.Size = new System.Drawing.Size(75, 23);
            this.Task1Button.TabIndex = 4;
            this.Task1Button.Text = "Task1";
            this.Task1Button.UseVisualStyleBackColor = false;
            this.Task1Button.Click += new System.EventHandler(this.Task1Button_Click);
            // 
            // Task2Button
            // 
            this.Task2Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Task2Button.Location = new System.Drawing.Point(119, 537);
            this.Task2Button.Name = "Task2Button";
            this.Task2Button.Size = new System.Drawing.Size(75, 23);
            this.Task2Button.TabIndex = 5;
            this.Task2Button.Text = "Task2";
            this.Task2Button.UseVisualStyleBackColor = false;
            this.Task2Button.Click += new System.EventHandler(this.Task2Button_Click);
            // 
            // Task3Button
            // 
            this.Task3Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Task3Button.Location = new System.Drawing.Point(200, 537);
            this.Task3Button.Name = "Task3Button";
            this.Task3Button.Size = new System.Drawing.Size(75, 23);
            this.Task3Button.TabIndex = 6;
            this.Task3Button.Text = "Task3";
            this.Task3Button.UseVisualStyleBackColor = false;
            this.Task3Button.Click += new System.EventHandler(this.Task3Button_Click);
            // 
            // Task4Button
            // 
            this.Task4Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Task4Button.Location = new System.Drawing.Point(281, 537);
            this.Task4Button.Name = "Task4Button";
            this.Task4Button.Size = new System.Drawing.Size(75, 23);
            this.Task4Button.TabIndex = 7;
            this.Task4Button.Text = "Task4";
            this.Task4Button.UseVisualStyleBackColor = false;
            this.Task4Button.Click += new System.EventHandler(this.Task4Button_Click);
            // 
            // foundTextBox
            // 
            this.foundTextBox.Location = new System.Drawing.Point(209, 47);
            this.foundTextBox.Name = "foundTextBox";
            this.foundTextBox.Size = new System.Drawing.Size(271, 20);
            this.foundTextBox.TabIndex = 8;
            this.foundTextBox.Text = "apphost.exe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Укажите имя файла";
            // 
            // Task5Button
            // 
            this.Task5Button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Task5Button.Location = new System.Drawing.Point(362, 537);
            this.Task5Button.Name = "Task5Button";
            this.Task5Button.Size = new System.Drawing.Size(75, 23);
            this.Task5Button.TabIndex = 10;
            this.Task5Button.Text = "Task5";
            this.Task5Button.UseVisualStyleBackColor = false;
            this.Task5Button.Click += new System.EventHandler(this.Task5Button_Click);
            // 
            // FilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1149, 572);
            this.Controls.Add(this.Task5Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.foundTextBox);
            this.Controls.Add(this.Task4Button);
            this.Controls.Add(this.Task3Button);
            this.Controls.Add(this.Task2Button);
            this.Controls.Add(this.Task1Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userInputTextBox);
            this.Controls.Add(this.FilesDataGridView);
            this.Name = "FilesForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FilesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FilesDataGridView;
        private System.Windows.Forms.TextBox userInputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Task1Button;
        private System.Windows.Forms.Button Task2Button;
        private System.Windows.Forms.Button Task3Button;
        private System.Windows.Forms.Button Task4Button;
        private System.Windows.Forms.TextBox foundTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Task5Button;
    }
}

