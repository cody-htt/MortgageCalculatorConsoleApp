
namespace MortgageCalculator
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label annualInterestLabel;
            System.Windows.Forms.Label principalLabel;
            System.Windows.Forms.Label yearsLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.annualInterestTextBox = new System.Windows.Forms.TextBox();
            this.principalTextBox = new System.Windows.Forms.TextBox();
            this.yearsTextBox = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MortgageToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mortgageModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            annualInterestLabel = new System.Windows.Forms.Label();
            principalLabel = new System.Windows.Forms.Label();
            yearsLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mortgageModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // annualInterestLabel
            // 
            annualInterestLabel.AutoSize = true;
            annualInterestLabel.Location = new System.Drawing.Point(12, 22);
            annualInterestLabel.Name = "annualInterestLabel";
            annualInterestLabel.Size = new System.Drawing.Size(81, 13);
            annualInterestLabel.TabIndex = 1;
            annualInterestLabel.Text = "Annual Interest:";
            // 
            // principalLabel
            // 
            principalLabel.AutoSize = true;
            principalLabel.Location = new System.Drawing.Point(12, 48);
            principalLabel.Name = "principalLabel";
            principalLabel.Size = new System.Drawing.Size(50, 13);
            principalLabel.TabIndex = 3;
            principalLabel.Text = "Principal:";
            // 
            // yearsLabel
            // 
            yearsLabel.AutoSize = true;
            yearsLabel.Location = new System.Drawing.Point(12, 74);
            yearsLabel.Name = "yearsLabel";
            yearsLabel.Size = new System.Drawing.Size(37, 13);
            yearsLabel.TabIndex = 5;
            yearsLabel.Text = "Years:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(3, 139);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 17);
            label1.TabIndex = 10;
            label1.Text = "Result:";
            // 
            // annualInterestTextBox
            // 
            this.annualInterestTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mortgageModelBindingSource, "AnnualInterest", true));
            this.annualInterestTextBox.Location = new System.Drawing.Point(99, 19);
            this.annualInterestTextBox.Name = "annualInterestTextBox";
            this.annualInterestTextBox.Size = new System.Drawing.Size(100, 20);
            this.annualInterestTextBox.TabIndex = 2;
            this.annualInterestTextBox.MouseHover += new System.EventHandler(this.annualInterestTextBox_MouseHover);
            // 
            // principalTextBox
            // 
            this.principalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mortgageModelBindingSource, "Principal", true));
            this.principalTextBox.Location = new System.Drawing.Point(99, 45);
            this.principalTextBox.Name = "principalTextBox";
            this.principalTextBox.Size = new System.Drawing.Size(100, 20);
            this.principalTextBox.TabIndex = 4;
            this.principalTextBox.MouseHover += new System.EventHandler(this.principalTextBox_MouseHover);
            // 
            // yearsTextBox
            // 
            this.yearsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mortgageModelBindingSource, "Years", true));
            this.yearsTextBox.Location = new System.Drawing.Point(99, 71);
            this.yearsTextBox.Name = "yearsTextBox";
            this.yearsTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearsTextBox.TabIndex = 6;
            this.yearsTextBox.MouseHover += new System.EventHandler(this.yearsTextBox_MouseHover);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(18, 99);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(124, 99);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // resultListBox
            // 
            this.resultListBox.BackColor = System.Drawing.SystemColors.Info;
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.HorizontalScrollbar = true;
            this.resultListBox.Location = new System.Drawing.Point(6, 159);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(506, 355);
            this.resultListBox.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MortgageCalculator.Properties.Resources.logo_home;
            this.pictureBox1.Location = new System.Drawing.Point(205, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 137);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // mortgageModelBindingSource
            // 
            this.mortgageModelBindingSource.DataSource = typeof(MortgageCalculator.MortgageModel);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(519, 518);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(label1);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(annualInterestLabel);
            this.Controls.Add(this.annualInterestTextBox);
            this.Controls.Add(principalLabel);
            this.Controls.Add(this.principalTextBox);
            this.Controls.Add(yearsLabel);
            this.Controls.Add(this.yearsTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(535, 557);
            this.MinimumSize = new System.Drawing.Size(535, 557);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mortgage Calculator App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mortgageModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource mortgageModelBindingSource;
        private System.Windows.Forms.TextBox annualInterestTextBox;
        private System.Windows.Forms.TextBox principalTextBox;
        private System.Windows.Forms.TextBox yearsTextBox;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip MortgageToolTip;
    }
}

