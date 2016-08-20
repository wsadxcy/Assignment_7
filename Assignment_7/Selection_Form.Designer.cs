namespace Assignment_7
{
    partial class SelectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectBox = new System.Windows.Forms.ComboBox();
            this.Title = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectBox
            // 
            this.SelectBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectBox.FormattingEnabled = true;
            this.SelectBox.Items.AddRange(new object[] {
            "Cedar Rapids",
            "Company Men",
            "Death Race 2",
            "Footloose",
            "Gnomeo and Juliet",
            "I am Number Four",
            "Just Go With It",
            "No Strings Attached",
            "Real Steel",
            "Sanctum",
            "Seasons of the Witch",
            "The Dilemma",
            "The Eagle",
            "The Green Hornet",
            "The Mechanic",
            "The Other Woman",
            "The Rite",
            "The Roommate",
            "The Way Back",
            "Waiting for Forever"});
            this.SelectBox.Location = new System.Drawing.Point(12, 36);
            this.SelectBox.Name = "SelectBox";
            this.SelectBox.Size = new System.Drawing.Size(143, 28);
            this.SelectBox.Sorted = true;
            this.SelectBox.TabIndex = 0;
            this.SelectBox.Text = "Your Selection";
            this.SelectBox.SelectedIndexChanged += new System.EventHandler(this.SelectBox_SelectedIndexChanged);
            this.SelectBox.SelectedValueChanged += new System.EventHandler(this.SelectBox_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(6, 23);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(35, 12);
            this.Title.TabIndex = 1;
            this.Title.Text = "Title";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Enabled = false;
            this.TitleTextBox.Location = new System.Drawing.Point(6, 38);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.ReadOnly = true;
            this.TitleTextBox.Size = new System.Drawing.Size(100, 21);
            this.TitleTextBox.TabIndex = 2;
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(4, 64);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(53, 12);
            this.Category.TabIndex = 3;
            this.Category.Text = "Category";
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Location = new System.Drawing.Point(6, 103);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(29, 12);
            this.Cost.TabIndex = 4;
            this.Cost.Text = "Cost";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Enabled = false;
            this.CategoryTextBox.Location = new System.Drawing.Point(6, 79);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.ReadOnly = true;
            this.CategoryTextBox.Size = new System.Drawing.Size(100, 21);
            this.CategoryTextBox.TabIndex = 5;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Enabled = false;
            this.CostTextBox.Location = new System.Drawing.Point(6, 118);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(100, 21);
            this.CostTextBox.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 202);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Title);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.TitleTextBox);
            this.groupBox1.Controls.Add(this.CostTextBox);
            this.groupBox1.Controls.Add(this.Category);
            this.groupBox1.Controls.Add(this.Cost);
            this.groupBox1.Controls.Add(this.CategoryTextBox);
            this.groupBox1.Location = new System.Drawing.Point(173, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 411);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Selection";
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(341, 462);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 9;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(458, 500);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SelectBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selection Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NextButton;
        public System.Windows.Forms.TextBox TitleTextBox;
        public System.Windows.Forms.TextBox CategoryTextBox;
        public System.Windows.Forms.TextBox CostTextBox;
    }
}

