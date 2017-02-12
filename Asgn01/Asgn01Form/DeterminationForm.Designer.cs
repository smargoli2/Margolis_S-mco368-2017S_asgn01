namespace Asgn01Form
{
    partial class DeterminationForm
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
            this.naturalCitizen = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.birthYear = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yrsInUS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.terms = new System.Windows.Forms.TextBox();
            this.rebelled = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // naturalCitizen
            // 
            this.naturalCitizen.AutoSize = true;
            this.naturalCitizen.Location = new System.Drawing.Point(15, 13);
            this.naturalCitizen.Name = "naturalCitizen";
            this.naturalCitizen.Size = new System.Drawing.Size(153, 18);
            this.naturalCitizen.TabIndex = 0;
            this.naturalCitizen.Text = "Natural Born US Citizen";
            this.naturalCitizen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "What is your birth year?";
            // 
            // birthYear
            // 
            this.birthYear.Location = new System.Drawing.Point(252, 47);
            this.birthYear.Name = "birthYear";
            this.birthYear.Size = new System.Drawing.Size(65, 22);
            this.birthYear.TabIndex = 2;
            this.birthYear.TextChanged += new System.EventHandler(this.birthYear_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "How many years have you resided in the US?";
            // 
            // yrsInUS
            // 
            this.yrsInUS.Location = new System.Drawing.Point(281, 87);
            this.yrsInUS.Name = "yrsInUS";
            this.yrsInUS.Size = new System.Drawing.Size(30, 22);
            this.yrsInUS.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "How many prior terms have you served?";
            // 
            // terms
            // 
            this.terms.Location = new System.Drawing.Point(281, 128);
            this.terms.Name = "terms";
            this.terms.Size = new System.Drawing.Size(30, 22);
            this.terms.TabIndex = 6;
            // 
            // rebelled
            // 
            this.rebelled.AutoSize = true;
            this.rebelled.Location = new System.Drawing.Point(15, 171);
            this.rebelled.Name = "rebelled";
            this.rebelled.Size = new System.Drawing.Size(185, 18);
            this.rebelled.TabIndex = 7;
            this.rebelled.Text = "I have rebelled againt the US";
            this.rebelled.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Plum;
            this.button1.ForeColor = System.Drawing.Color.DarkViolet;
            this.button1.Location = new System.Drawing.Point(119, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Determine Eligibility";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(12, 258);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(316, 14);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.Text = "You are eligible to be a candidate for US presidency!";
            this.resultLabel.Visible = false;
            // 
            // DeterminationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(331, 281);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rebelled);
            this.Controls.Add(this.terms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yrsInUS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.birthYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.naturalCitizen);
            this.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DeterminationForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox naturalCitizen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox birthYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yrsInUS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox terms;
        private System.Windows.Forms.CheckBox rebelled;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label resultLabel;
    }
}

