
namespace lab2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.title = new System.Windows.Forms.Panel();
            this.AddingItemsLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.EnterValue = new System.Windows.Forms.TextBox();
            this.EnterValueLabel = new System.Windows.Forms.Label();
            this.OutputValue = new System.Windows.Forms.ListBox();
            this.OutputValueLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EnterIndex = new System.Windows.Forms.TextBox();
            this.EnterIndexLabel = new System.Windows.Forms.Label();
            this.OutputIndex = new System.Windows.Forms.TextBox();
            this.OutputIndexLabel = new System.Windows.Forms.Label();
            this.SearchCountButton = new System.Windows.Forms.Button();
            this.SearchCountLabel = new System.Windows.Forms.Label();
            this.OutputCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(197)))), ((int)(((byte)(188)))));
            this.title.Controls.Add(this.AddingItemsLabel);
            this.title.Controls.Add(this.closeButton);
            this.title.Location = new System.Drawing.Point(-2, -6);
            this.title.Margin = new System.Windows.Forms.Padding(2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(630, 67);
            this.title.TabIndex = 0;
            // 
            // AddingItemsLabel
            // 
            this.AddingItemsLabel.AutoSize = true;
            this.AddingItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddingItemsLabel.Location = new System.Drawing.Point(222, 15);
            this.AddingItemsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddingItemsLabel.Name = "AddingItemsLabel";
            this.AddingItemsLabel.Size = new System.Drawing.Size(200, 36);
            this.AddingItemsLabel.TabIndex = 2;
            this.AddingItemsLabel.Text = "Adding items";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Red;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(588, 2);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(40, 21);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // EnterValue
            // 
            this.EnterValue.Location = new System.Drawing.Point(67, 135);
            this.EnterValue.Margin = new System.Windows.Forms.Padding(2);
            this.EnterValue.Multiline = true;
            this.EnterValue.Name = "EnterValue";
            this.EnterValue.Size = new System.Drawing.Size(141, 81);
            this.EnterValue.TabIndex = 1;
            this.EnterValue.TextChanged += new System.EventHandler(this.EnterValue_TextChanged);
            // 
            // EnterValueLabel
            // 
            this.EnterValueLabel.AutoSize = true;
            this.EnterValueLabel.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterValueLabel.Location = new System.Drawing.Point(82, 98);
            this.EnterValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnterValueLabel.Name = "EnterValueLabel";
            this.EnterValueLabel.Size = new System.Drawing.Size(126, 33);
            this.EnterValueLabel.TabIndex = 2;
            this.EnterValueLabel.Text = "Enter value";
            // 
            // OutputValue
            // 
            this.OutputValue.FormattingEnabled = true;
            this.OutputValue.Location = new System.Drawing.Point(412, 134);
            this.OutputValue.Margin = new System.Windows.Forms.Padding(2);
            this.OutputValue.Name = "OutputValue";
            this.OutputValue.Size = new System.Drawing.Size(140, 82);
            this.OutputValue.TabIndex = 3;
            this.OutputValue.SelectedIndexChanged += new System.EventHandler(this.OutputValue_SelectedIndexChanged);
            // 
            // OutputValueLabel
            // 
            this.OutputValueLabel.AutoSize = true;
            this.OutputValueLabel.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputValueLabel.Location = new System.Drawing.Point(416, 97);
            this.OutputValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OutputValueLabel.Name = "OutputValueLabel";
            this.OutputValueLabel.Size = new System.Drawing.Size(144, 33);
            this.OutputValueLabel.TabIndex = 4;
            this.OutputValueLabel.Text = "Output Value";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(277, 135);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // EnterIndex
            // 
            this.EnterIndex.Location = new System.Drawing.Point(98, 273);
            this.EnterIndex.Margin = new System.Windows.Forms.Padding(2);
            this.EnterIndex.Multiline = true;
            this.EnterIndex.Name = "EnterIndex";
            this.EnterIndex.Size = new System.Drawing.Size(76, 67);
            this.EnterIndex.TabIndex = 6;
            this.EnterIndex.TextChanged += new System.EventHandler(this.EnterIndex_TextChanged);
            // 
            // EnterIndexLabel
            // 
            this.EnterIndexLabel.AutoSize = true;
            this.EnterIndexLabel.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterIndexLabel.Location = new System.Drawing.Point(94, 246);
            this.EnterIndexLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnterIndexLabel.Name = "EnterIndexLabel";
            this.EnterIndexLabel.Size = new System.Drawing.Size(109, 24);
            this.EnterIndexLabel.TabIndex = 7;
            this.EnterIndexLabel.Text = "Enter index 1";
            // 
            // OutputIndex
            // 
            this.OutputIndex.Location = new System.Drawing.Point(440, 273);
            this.OutputIndex.Margin = new System.Windows.Forms.Padding(2);
            this.OutputIndex.Multiline = true;
            this.OutputIndex.Name = "OutputIndex";
            this.OutputIndex.Size = new System.Drawing.Size(76, 67);
            this.OutputIndex.TabIndex = 8;
            // 
            // OutputIndexLabel
            // 
            this.OutputIndexLabel.AutoSize = true;
            this.OutputIndexLabel.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputIndexLabel.Location = new System.Drawing.Point(430, 246);
            this.OutputIndexLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OutputIndexLabel.Name = "OutputIndexLabel";
            this.OutputIndexLabel.Size = new System.Drawing.Size(105, 24);
            this.OutputIndexLabel.TabIndex = 9;
            this.OutputIndexLabel.Text = "Output index";
            // 
            // SearchCountButton
            // 
            this.SearchCountButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchCountButton.BackgroundImage")));
            this.SearchCountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchCountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchCountButton.Location = new System.Drawing.Point(277, 396);
            this.SearchCountButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchCountButton.Name = "SearchCountButton";
            this.SearchCountButton.Size = new System.Drawing.Size(69, 65);
            this.SearchCountButton.TabIndex = 13;
            this.SearchCountButton.Text = "\r\n";
            this.SearchCountButton.UseVisualStyleBackColor = true;
            this.SearchCountButton.Click += new System.EventHandler(this.SearchCountButton_Click);
            // 
            // SearchCountLabel
            // 
            this.SearchCountLabel.AutoSize = true;
            this.SearchCountLabel.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchCountLabel.Location = new System.Drawing.Point(264, 370);
            this.SearchCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchCountLabel.Name = "SearchCountLabel";
            this.SearchCountLabel.Size = new System.Drawing.Size(103, 24);
            this.SearchCountLabel.TabIndex = 14;
            this.SearchCountLabel.Text = "Search count";
            // 
            // OutputCount
            // 
            this.OutputCount.Location = new System.Drawing.Point(440, 395);
            this.OutputCount.Margin = new System.Windows.Forms.Padding(2);
            this.OutputCount.Multiline = true;
            this.OutputCount.Name = "OutputCount";
            this.OutputCount.Size = new System.Drawing.Size(76, 67);
            this.OutputCount.TabIndex = 15;
            this.OutputCount.TextChanged += new System.EventHandler(this.OutputCount_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(430, 368);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Output count";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(277, 260);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(206)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(622, 479);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputCount);
            this.Controls.Add(this.SearchCountLabel);
            this.Controls.Add(this.SearchCountButton);
            this.Controls.Add(this.OutputIndexLabel);
            this.Controls.Add(this.OutputIndex);
            this.Controls.Add(this.EnterIndexLabel);
            this.Controls.Add(this.EnterIndex);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OutputValueLabel);
            this.Controls.Add(this.OutputValue);
            this.Controls.Add(this.EnterValueLabel);
            this.Controls.Add(this.EnterValue);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label AddingItemsLabel;
        private System.Windows.Forms.TextBox EnterValue;
        private System.Windows.Forms.Label EnterValueLabel;
        private System.Windows.Forms.ListBox OutputValue;
        private System.Windows.Forms.Label OutputValueLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox EnterIndex;
        private System.Windows.Forms.Label EnterIndexLabel;
        private System.Windows.Forms.TextBox OutputIndex;
        private System.Windows.Forms.Label OutputIndexLabel;
        private System.Windows.Forms.Button SearchCountButton;
        private System.Windows.Forms.Label SearchCountLabel;
        private System.Windows.Forms.TextBox OutputCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

