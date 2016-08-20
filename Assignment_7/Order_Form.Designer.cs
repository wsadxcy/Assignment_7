namespace Assignment_7
{
    partial class Order_Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cancel = new System.Windows.Forms.Button();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Stream = new System.Windows.Forms.Button();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MovieSelected = new System.Windows.Forms.GroupBox();
            this.YourOrder = new System.Windows.Forms.GroupBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.SaleTaxTextBox = new System.Windows.Forms.TextBox();
            this.GrandTotalTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DVDTextBox = new System.Windows.Forms.TextBox();
            this.OrderDVD = new System.Windows.Forms.CheckBox();
            this.Back = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.MovieSelected.SuspendLayout();
            this.YourOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(692, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem,
            this.streamToolStripMenuItem,
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(50, 400);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Stream
            // 
            this.Stream.Location = new System.Drawing.Point(367, 400);
            this.Stream.Name = "Stream";
            this.Stream.Size = new System.Drawing.Size(75, 23);
            this.Stream.TabIndex = 2;
            this.Stream.Text = "Stream";
            this.Stream.UseVisualStyleBackColor = true;
            this.Stream.Click += new System.EventHandler(this.Stream_Click);
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.streamToolStripMenuItem.Text = "Stream";
            this.streamToolStripMenuItem.Click += new System.EventHandler(this.Stream_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // MovieSelected
            // 
            this.MovieSelected.Controls.Add(this.label2);
            this.MovieSelected.Controls.Add(this.label1);
            this.MovieSelected.Controls.Add(this.pictureBox1);
            this.MovieSelected.Controls.Add(this.CategoryTextBox);
            this.MovieSelected.Controls.Add(this.TitleTextBox);
            this.MovieSelected.Location = new System.Drawing.Point(35, 50);
            this.MovieSelected.Name = "MovieSelected";
            this.MovieSelected.Size = new System.Drawing.Size(173, 337);
            this.MovieSelected.TabIndex = 3;
            this.MovieSelected.TabStop = false;
            this.MovieSelected.Text = "Movie Selected";
            // 
            // YourOrder
            // 
            this.YourOrder.Controls.Add(this.OrderDVD);
            this.YourOrder.Controls.Add(this.DVDTextBox);
            this.YourOrder.Controls.Add(this.label7);
            this.YourOrder.Controls.Add(this.GrandTotalTextBox);
            this.YourOrder.Controls.Add(this.SaleTaxTextBox);
            this.YourOrder.Controls.Add(this.SubTotalTextBox);
            this.YourOrder.Controls.Add(this.label6);
            this.YourOrder.Controls.Add(this.label5);
            this.YourOrder.Controls.Add(this.label4);
            this.YourOrder.Controls.Add(this.CostTextBox);
            this.YourOrder.Controls.Add(this.label3);
            this.YourOrder.Location = new System.Drawing.Point(288, 50);
            this.YourOrder.Name = "YourOrder";
            this.YourOrder.Size = new System.Drawing.Size(337, 263);
            this.YourOrder.TabIndex = 4;
            this.YourOrder.TabStop = false;
            this.YourOrder.Text = "Your Order";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(15, 37);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(100, 21);
            this.TitleTextBox.TabIndex = 0;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(15, 80);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(100, 21);
            this.CategoryTextBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 171);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cost";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(79, 16);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(100, 21);
            this.CostTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "SubTotal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sale Tax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "Grand Total";
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(79, 95);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.Size = new System.Drawing.Size(100, 21);
            this.SubTotalTextBox.TabIndex = 5;
            // 
            // SaleTaxTextBox
            // 
            this.SaleTaxTextBox.Location = new System.Drawing.Point(79, 139);
            this.SaleTaxTextBox.Name = "SaleTaxTextBox";
            this.SaleTaxTextBox.Size = new System.Drawing.Size(100, 21);
            this.SaleTaxTextBox.TabIndex = 6;
            // 
            // GrandTotalTextBox
            // 
            this.GrandTotalTextBox.Location = new System.Drawing.Point(79, 188);
            this.GrandTotalTextBox.Name = "GrandTotalTextBox";
            this.GrandTotalTextBox.Size = new System.Drawing.Size(100, 21);
            this.GrandTotalTextBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "DVD";
            this.label7.Visible = false;
            // 
            // DVDTextBox
            // 
            this.DVDTextBox.Location = new System.Drawing.Point(79, 62);
            this.DVDTextBox.Name = "DVDTextBox";
            this.DVDTextBox.Size = new System.Drawing.Size(100, 21);
            this.DVDTextBox.TabIndex = 9;
            this.DVDTextBox.Text = "10.00";
            this.DVDTextBox.Visible = false;
            // 
            // OrderDVD
            // 
            this.OrderDVD.AutoSize = true;
            this.OrderDVD.Location = new System.Drawing.Point(11, 241);
            this.OrderDVD.Name = "OrderDVD";
            this.OrderDVD.Size = new System.Drawing.Size(246, 16);
            this.OrderDVD.TabIndex = 10;
            this.OrderDVD.Text = "Order The DVD, Adds $10 To Your Order";
            this.OrderDVD.UseVisualStyleBackColor = true;
            this.OrderDVD.CheckedChanged += new System.EventHandler(this.OrderDVD_CheckedChanged);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(548, 400);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 5;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 448);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.YourOrder);
            this.Controls.Add(this.MovieSelected);
            this.Controls.Add(this.Stream);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Order_Form";
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.Order_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MovieSelected.ResumeLayout(false);
            this.MovieSelected.PerformLayout();
            this.YourOrder.ResumeLayout(false);
            this.YourOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button Stream;
        private System.Windows.Forms.ToolStripMenuItem streamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.GroupBox MovieSelected;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox YourOrder;
        public System.Windows.Forms.TextBox CategoryTextBox;
        public System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox OrderDVD;
        private System.Windows.Forms.TextBox DVDTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox GrandTotalTextBox;
        private System.Windows.Forms.TextBox SaleTaxTextBox;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Back;
    }
}