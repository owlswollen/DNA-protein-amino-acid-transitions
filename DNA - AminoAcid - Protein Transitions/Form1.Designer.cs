namespace DNA___AminoAcid___Protein_Transitions
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
            this.comboBoxSelect = new System.Windows.Forms.ComboBox();
            this.richTextBoxDNA = new System.Windows.Forms.RichTextBox();
            this.labelSelect = new System.Windows.Forms.Label();
            this.richTextBoxAminoAcid = new System.Windows.Forms.RichTextBox();
            this.labelDNA = new System.Windows.Forms.Label();
            this.labelAminoAcid = new System.Windows.Forms.Label();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.richTextBoxAminoAcid2 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDNA1 = new System.Windows.Forms.RichTextBox();
            this.buttonTranslate1 = new System.Windows.Forms.Button();
            this.labelDNA1 = new System.Windows.Forms.Label();
            this.labelAminoAcid2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonTranslate2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxProtein = new System.Windows.Forms.RichTextBox();
            this.labelDNA2 = new System.Windows.Forms.Label();
            this.richTextBoxDNA2 = new System.Windows.Forms.RichTextBox();
            this.labelProtein = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSelect
            // 
            this.comboBoxSelect.FormattingEnabled = true;
            this.comboBoxSelect.Items.AddRange(new object[] {
            "DNA - Amino Acid",
            "DNA - Protein",
            "Amino Acid - DNA"});
            this.comboBoxSelect.Location = new System.Drawing.Point(60, 75);
            this.comboBoxSelect.Name = "comboBoxSelect";
            this.comboBoxSelect.Size = new System.Drawing.Size(236, 24);
            this.comboBoxSelect.TabIndex = 0;
            this.comboBoxSelect.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelect_SelectedIndexChanged);
            // 
            // richTextBoxDNA
            // 
            this.richTextBoxDNA.Location = new System.Drawing.Point(24, 67);
            this.richTextBoxDNA.Name = "richTextBoxDNA";
            this.richTextBoxDNA.Size = new System.Drawing.Size(486, 88);
            this.richTextBoxDNA.TabIndex = 1;
            this.richTextBoxDNA.Text = "";
            // 
            // labelSelect
            // 
            this.labelSelect.AutoSize = true;
            this.labelSelect.Location = new System.Drawing.Point(57, 55);
            this.labelSelect.Name = "labelSelect";
            this.labelSelect.Size = new System.Drawing.Size(116, 17);
            this.labelSelect.TabIndex = 2;
            this.labelSelect.Text = "Select Translator";
            // 
            // richTextBoxAminoAcid
            // 
            this.richTextBoxAminoAcid.Location = new System.Drawing.Point(24, 256);
            this.richTextBoxAminoAcid.Name = "richTextBoxAminoAcid";
            this.richTextBoxAminoAcid.Size = new System.Drawing.Size(486, 88);
            this.richTextBoxAminoAcid.TabIndex = 3;
            this.richTextBoxAminoAcid.Text = "";
            // 
            // labelDNA
            // 
            this.labelDNA.AutoSize = true;
            this.labelDNA.Location = new System.Drawing.Point(21, 47);
            this.labelDNA.Name = "labelDNA";
            this.labelDNA.Size = new System.Drawing.Size(435, 17);
            this.labelDNA.TabIndex = 5;
            this.labelDNA.Text = "DNA (Only nucleotide letters -except \'u\'. No whitespace characters.)";
            // 
            // labelAminoAcid
            // 
            this.labelAminoAcid.AutoSize = true;
            this.labelAminoAcid.Location = new System.Drawing.Point(21, 236);
            this.labelAminoAcid.Name = "labelAminoAcid";
            this.labelAminoAcid.Size = new System.Drawing.Size(78, 17);
            this.labelAminoAcid.TabIndex = 6;
            this.labelAminoAcid.Text = "Amino Acid";
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Location = new System.Drawing.Point(423, 161);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(87, 39);
            this.buttonTranslate.TabIndex = 8;
            this.buttonTranslate.Text = "Translate";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTransform_Click);
            // 
            // richTextBoxAminoAcid2
            // 
            this.richTextBoxAminoAcid2.Location = new System.Drawing.Point(20, 50);
            this.richTextBoxAminoAcid2.Name = "richTextBoxAminoAcid2";
            this.richTextBoxAminoAcid2.Size = new System.Drawing.Size(486, 88);
            this.richTextBoxAminoAcid2.TabIndex = 9;
            this.richTextBoxAminoAcid2.Text = "";
            // 
            // richTextBoxDNA1
            // 
            this.richTextBoxDNA1.Location = new System.Drawing.Point(20, 239);
            this.richTextBoxDNA1.Name = "richTextBoxDNA1";
            this.richTextBoxDNA1.Size = new System.Drawing.Size(486, 88);
            this.richTextBoxDNA1.TabIndex = 10;
            this.richTextBoxDNA1.Text = "";
            // 
            // buttonTranslate1
            // 
            this.buttonTranslate1.Location = new System.Drawing.Point(419, 144);
            this.buttonTranslate1.Name = "buttonTranslate1";
            this.buttonTranslate1.Size = new System.Drawing.Size(87, 39);
            this.buttonTranslate1.TabIndex = 11;
            this.buttonTranslate1.Text = "Translate";
            this.buttonTranslate1.UseVisualStyleBackColor = true;
            this.buttonTranslate1.Click += new System.EventHandler(this.buttonTransform1_Click);
            // 
            // labelDNA1
            // 
            this.labelDNA1.AutoSize = true;
            this.labelDNA1.Location = new System.Drawing.Point(17, 219);
            this.labelDNA1.Name = "labelDNA1";
            this.labelDNA1.Size = new System.Drawing.Size(37, 17);
            this.labelDNA1.TabIndex = 12;
            this.labelDNA1.Text = "DNA";
            // 
            // labelAminoAcid2
            // 
            this.labelAminoAcid2.AutoSize = true;
            this.labelAminoAcid2.Location = new System.Drawing.Point(17, 30);
            this.labelAminoAcid2.Name = "labelAminoAcid2";
            this.labelAminoAcid2.Size = new System.Drawing.Size(411, 17);
            this.labelAminoAcid2.TabIndex = 13;
            this.labelAminoAcid2.Text = "Amino Acid (Only amino acid letters. No whitespace characters.)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxDNA);
            this.groupBox1.Controls.Add(this.richTextBoxAminoAcid);
            this.groupBox1.Controls.Add(this.labelDNA);
            this.groupBox1.Controls.Add(this.labelAminoAcid);
            this.groupBox1.Controls.Add(this.buttonTranslate);
            this.groupBox1.Location = new System.Drawing.Point(40, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 364);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBoxDNA1);
            this.groupBox3.Controls.Add(this.labelAminoAcid2);
            this.groupBox3.Controls.Add(this.richTextBoxAminoAcid2);
            this.groupBox3.Controls.Add(this.labelDNA1);
            this.groupBox3.Controls.Add(this.buttonTranslate2);
            this.groupBox3.Location = new System.Drawing.Point(40, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(525, 352);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // buttonTranslate2
            // 
            this.buttonTranslate2.Location = new System.Drawing.Point(419, 144);
            this.buttonTranslate2.Name = "buttonTranslate2";
            this.buttonTranslate2.Size = new System.Drawing.Size(87, 39);
            this.buttonTranslate2.TabIndex = 11;
            this.buttonTranslate2.Text = "Translate";
            this.buttonTranslate2.UseVisualStyleBackColor = true;
            this.buttonTranslate2.Click += new System.EventHandler(this.buttonTransform2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBoxProtein);
            this.groupBox2.Controls.Add(this.labelDNA2);
            this.groupBox2.Controls.Add(this.richTextBoxDNA2);
            this.groupBox2.Controls.Add(this.labelProtein);
            this.groupBox2.Controls.Add(this.buttonTranslate1);
            this.groupBox2.Location = new System.Drawing.Point(40, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 370);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // richTextBoxProtein
            // 
            this.richTextBoxProtein.Location = new System.Drawing.Point(20, 239);
            this.richTextBoxProtein.Name = "richTextBoxProtein";
            this.richTextBoxProtein.Size = new System.Drawing.Size(486, 88);
            this.richTextBoxProtein.TabIndex = 10;
            this.richTextBoxProtein.Text = "";
            // 
            // labelDNA2
            // 
            this.labelDNA2.AutoSize = true;
            this.labelDNA2.Location = new System.Drawing.Point(17, 30);
            this.labelDNA2.Name = "labelDNA2";
            this.labelDNA2.Size = new System.Drawing.Size(435, 17);
            this.labelDNA2.TabIndex = 13;
            this.labelDNA2.Text = "DNA (Only nucleotide letters -except \'u\'. No whitespace characters.)";
            // 
            // richTextBoxDNA2
            // 
            this.richTextBoxDNA2.Location = new System.Drawing.Point(20, 50);
            this.richTextBoxDNA2.Name = "richTextBoxDNA2";
            this.richTextBoxDNA2.Size = new System.Drawing.Size(486, 88);
            this.richTextBoxDNA2.TabIndex = 9;
            this.richTextBoxDNA2.Text = "";
            // 
            // labelProtein
            // 
            this.labelProtein.AutoSize = true;
            this.labelProtein.Location = new System.Drawing.Point(17, 219);
            this.labelProtein.Name = "labelProtein";
            this.labelProtein.Size = new System.Drawing.Size(53, 17);
            this.labelProtein.TabIndex = 12;
            this.labelProtein.Text = "Protein";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 579);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelSelect);
            this.Controls.Add(this.comboBoxSelect);
            this.Name = "Form1";
            this.Text = "DNA - Amino Acid - Protein Translator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelect;
        private System.Windows.Forms.RichTextBox richTextBoxDNA;
        private System.Windows.Forms.Label labelSelect;
        private System.Windows.Forms.RichTextBox richTextBoxAminoAcid;
        private System.Windows.Forms.Label labelDNA;
        private System.Windows.Forms.Label labelAminoAcid;
        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.RichTextBox richTextBoxAminoAcid2;
        private System.Windows.Forms.RichTextBox richTextBoxDNA1;
        private System.Windows.Forms.Button buttonTranslate1;
        private System.Windows.Forms.Label labelDNA1;
        private System.Windows.Forms.Label labelAminoAcid2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxProtein;
        private System.Windows.Forms.Label labelDNA2;
        private System.Windows.Forms.RichTextBox richTextBoxDNA2;
        private System.Windows.Forms.Label labelProtein;
        private System.Windows.Forms.Button buttonTranslate2;
    }
}

