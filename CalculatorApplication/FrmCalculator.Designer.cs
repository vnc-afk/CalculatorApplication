namespace CalculatorApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBoxInput1 = new TextBox();
            label1 = new Label();
            cbOperator = new ComboBox();
            label2 = new Label();
            txtBoxInput2 = new TextBox();
            lblDisplayTotal = new Label();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Font = new Font("Segoe UI", 12F);
            txtBoxInput1.Location = new Point(186, 17);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(233, 29);
            txtBoxInput1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(35, 20);
            label1.Name = "label1";
            label1.Size = new Size(145, 21);
            label1.TabIndex = 1;
            label1.Text = "Enter First Number:";
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Consolas", 12F);
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(260, 52);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(85, 27);
            cbOperator.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(14, 88);
            label2.Name = "label2";
            label2.Size = new Size(166, 21);
            label2.TabIndex = 3;
            label2.Text = "Enter Second Number:";
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Font = new Font("Segoe UI", 12F);
            txtBoxInput2.Location = new Point(186, 88);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(233, 29);
            txtBoxInput2.TabIndex = 4;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Segoe UI", 12F);
            lblDisplayTotal.Location = new Point(115, 137);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(65, 21);
            lblDisplayTotal.TabIndex = 5;
            lblDisplayTotal.Text = "Answer:";
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Consolas", 12F);
            btnEqual.Location = new Point(314, 231);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(105, 37);
            btnEqual.TabIndex = 6;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 280);
            Controls.Add(btnEqual);
            Controls.Add(lblDisplayTotal);
            Controls.Add(txtBoxInput2);
            Controls.Add(label2);
            Controls.Add(cbOperator);
            Controls.Add(label1);
            Controls.Add(txtBoxInput1);
            Name = "Form1";
            Text = "FrmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxInput1;
        private Label label1;
        private ComboBox cbOperator;
        private Label label2;
        private TextBox txtBoxInput2;
        private Label lblDisplayTotal;
        private Button btnEqual;
    }
}
