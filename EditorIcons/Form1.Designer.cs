namespace EditorIcons
{
    partial class Form1
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
            this.comboBoxIconList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIconName = new System.Windows.Forms.TextBox();
            this.numericUpDownIconSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PictureBoxIconEditor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIconSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIconEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxIconList
            // 
            this.comboBoxIconList.DisplayMember = "Name";
            this.comboBoxIconList.FormattingEnabled = true;
            this.comboBoxIconList.Location = new System.Drawing.Point(103, 19);
            this.comboBoxIconList.Name = "comboBoxIconList";
            this.comboBoxIconList.Size = new System.Drawing.Size(121, 24);
            this.comboBoxIconList.TabIndex = 0;
            this.comboBoxIconList.SelectedIndexChanged += new System.EventHandler(this.comboBoxIconList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista ikon";
            // 
            // textBoxIconName
            // 
            this.textBoxIconName.Location = new System.Drawing.Point(103, 49);
            this.textBoxIconName.Name = "textBoxIconName";
            this.textBoxIconName.Size = new System.Drawing.Size(121, 22);
            this.textBoxIconName.TabIndex = 2;
            this.textBoxIconName.TextChanged += new System.EventHandler(this.textBoxIconName_TextChanged);
            // 
            // numericUpDownIconSize
            // 
            this.numericUpDownIconSize.Location = new System.Drawing.Point(103, 77);
            this.numericUpDownIconSize.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownIconSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownIconSize.Name = "numericUpDownIconSize";
            this.numericUpDownIconSize.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownIconSize.TabIndex = 3;
            this.numericUpDownIconSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownIconSize.ValueChanged += new System.EventHandler(this.numericUpDownIconSize_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rozmiar";
            // 
            // pictureBox1
            // 
            this.PictureBoxIconEditor.Location = new System.Drawing.Point(12, 116);
            this.PictureBoxIconEditor.Name = "pictureBox1";
            this.PictureBoxIconEditor.Size = new System.Drawing.Size(202, 125);
            this.PictureBoxIconEditor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBoxIconEditor.TabIndex = 6;
            this.PictureBoxIconEditor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PictureBoxIconEditor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownIconSize);
            this.Controls.Add(this.textBoxIconName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxIconList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIconSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxIconEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIconList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIconName;
        private System.Windows.Forms.NumericUpDown numericUpDownIconSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PictureBoxIconEditor;
    }
}

