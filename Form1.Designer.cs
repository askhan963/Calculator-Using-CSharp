namespace WinFormsApp3
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
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.DivBtn = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.EqualBtn = new System.Windows.Forms.Button();
            this.DotBtn = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.ClearAllBtn = new System.Windows.Forms.Button();
            this.MulBtn = new System.Windows.Forms.Button();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.SingleClearBtn = new System.Windows.Forms.Button();
            this.labelOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxArea
            // 
            this.textBoxArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxArea.Location = new System.Drawing.Point(26, 54);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.ReadOnly = true;
            this.textBoxArea.Size = new System.Drawing.Size(513, 44);
            this.textBoxArea.TabIndex = 0;
            this.textBoxArea.Text = "0";
            this.textBoxArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DivBtn
            // 
            this.DivBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DivBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DivBtn.Location = new System.Drawing.Point(333, 118);
            this.DivBtn.Name = "DivBtn";
            this.DivBtn.Size = new System.Drawing.Size(90, 68);
            this.DivBtn.TabIndex = 1;
            this.DivBtn.Text = "/";
            this.DivBtn.UseVisualStyleBackColor = true;
            this.DivBtn.Click += new System.EventHandler(this.OperationBtnPress);
            // 
            // Btn8
            // 
            this.Btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn8.Location = new System.Drawing.Point(130, 118);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(90, 68);
            this.Btn8.TabIndex = 1;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.DotButtonClick);
            // 
            // Btn7
            // 
            this.Btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn7.Location = new System.Drawing.Point(26, 118);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(90, 68);
            this.Btn7.TabIndex = 1;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = true;
            this.Btn7.Click += new System.EventHandler(this.DotButtonClick);
            // 
            // Btn6
            // 
            this.Btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn6.Location = new System.Drawing.Point(230, 207);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(90, 68);
            this.Btn6.TabIndex = 2;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = true;
            this.Btn6.Click += new System.EventHandler(this.DotButtonClick);
            // 
            // Btn9
            // 
            this.Btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn9.Location = new System.Drawing.Point(230, 118);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(90, 68);
            this.Btn9.TabIndex = 3;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = true;
            this.Btn9.Click += new System.EventHandler(this.DotButtonClick);
            // 
            // Btn3
            // 
            this.Btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn3.Location = new System.Drawing.Point(230, 297);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(90, 68);
            this.Btn3.TabIndex = 4;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.DotButtonClick);
            // 
            // Btn2
            // 
            this.Btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn2.Location = new System.Drawing.Point(130, 297);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(90, 68);
            this.Btn2.TabIndex = 5;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = true;
            this.Btn2.Click += new System.EventHandler(this.DotButtonClick);
            // 
            // Btn1
            // 
            this.Btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn1.Location = new System.Drawing.Point(26, 297);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(90, 68);
            this.Btn1.TabIndex = 6;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = true;
            this.Btn1.Click += new System.EventHandler(this.DotButtonClick);
            // 
            // Btn5
            // 
            this.Btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn5.Location = new System.Drawing.Point(129, 207);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(94, 68);
            this.Btn5.TabIndex = 7;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.DotButtonClick);
            // 
            // Btn4
            // 
            this.Btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn4.Location = new System.Drawing.Point(26, 207);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(90, 68);
            this.Btn4.TabIndex = 8;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = true;
            this.Btn4.Click += new System.EventHandler(this.DotButtonClick);
            // 
            // EqualBtn
            // 
            this.EqualBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EqualBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EqualBtn.Location = new System.Drawing.Point(439, 297);
            this.EqualBtn.Name = "EqualBtn";
            this.EqualBtn.Size = new System.Drawing.Size(90, 152);
            this.EqualBtn.TabIndex = 9;
            this.EqualBtn.Text = "=";
            this.EqualBtn.UseVisualStyleBackColor = true;
            this.EqualBtn.Click += new System.EventHandler(this.EqualBtnClick);
            // 
            // DotBtn
            // 
            this.DotBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DotBtn.Location = new System.Drawing.Point(230, 380);
            this.DotBtn.Name = "DotBtn";
            this.DotBtn.Size = new System.Drawing.Size(90, 68);
            this.DotBtn.TabIndex = 10;
            this.DotBtn.Text = ".";
            this.DotBtn.UseVisualStyleBackColor = true;
            this.DotBtn.Click += new System.EventHandler(this.DotButtonClick);
            // 
            // Btn0
            // 
            this.Btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn0.Location = new System.Drawing.Point(26, 380);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(194, 68);
            this.Btn0.TabIndex = 11;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = true;
            this.Btn0.Click += new System.EventHandler(this.DotButtonClick);
            // 
            // ClearAllBtn
            // 
            this.ClearAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClearAllBtn.Location = new System.Drawing.Point(439, 118);
            this.ClearAllBtn.Name = "ClearAllBtn";
            this.ClearAllBtn.Size = new System.Drawing.Size(90, 68);
            this.ClearAllBtn.TabIndex = 12;
            this.ClearAllBtn.Text = "CA";
            this.ClearAllBtn.UseVisualStyleBackColor = true;
            this.ClearAllBtn.Click += new System.EventHandler(this.ClearAllClick);
            // 
            // MulBtn
            // 
            this.MulBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MulBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MulBtn.Location = new System.Drawing.Point(333, 207);
            this.MulBtn.Name = "MulBtn";
            this.MulBtn.Size = new System.Drawing.Size(90, 68);
            this.MulBtn.TabIndex = 13;
            this.MulBtn.Text = "*";
            this.MulBtn.UseVisualStyleBackColor = true;
            this.MulBtn.Click += new System.EventHandler(this.OperationBtnPress);
            // 
            // MinusBtn
            // 
            this.MinusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinusBtn.Location = new System.Drawing.Point(333, 297);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(90, 68);
            this.MinusBtn.TabIndex = 14;
            this.MinusBtn.Text = "-";
            this.MinusBtn.UseVisualStyleBackColor = true;
            this.MinusBtn.Click += new System.EventHandler(this.OperationBtnPress);
            // 
            // PlusBtn
            // 
            this.PlusBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlusBtn.Location = new System.Drawing.Point(333, 380);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(90, 68);
            this.PlusBtn.TabIndex = 15;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = true;
            this.PlusBtn.Click += new System.EventHandler(this.OperationBtnPress);
            // 
            // SingleClearBtn
            // 
            this.SingleClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SingleClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SingleClearBtn.Location = new System.Drawing.Point(439, 207);
            this.SingleClearBtn.Name = "SingleClearBtn";
            this.SingleClearBtn.Size = new System.Drawing.Size(90, 68);
            this.SingleClearBtn.TabIndex = 16;
            this.SingleClearBtn.Text = "C";
            this.SingleClearBtn.UseVisualStyleBackColor = true;
            this.SingleClearBtn.Click += new System.EventHandler(this.ClearBtnClicked);
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelOperation.Location = new System.Drawing.Point(36, 14);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(0, 25);
            this.labelOperation.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(554, 482);
            this.Controls.Add(this.labelOperation);
            this.Controls.Add(this.SingleClearBtn);
            this.Controls.Add(this.PlusBtn);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.MulBtn);
            this.Controls.Add(this.ClearAllBtn);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.DotBtn);
            this.Controls.Add(this.EqualBtn);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.DivBtn);
            this.Controls.Add(this.textBoxArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(576, 538);
            this.MinimumSize = new System.Drawing.Size(576, 538);
            this.Name = "Form1";
            this.Text = "Calculater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxArea;
        private Button DivBtn;
        private Button Btn8;
        private Button Btn7;
        private Button Btn6;
        private Button Btn9;
        private Button Btn3;
        private Button Btn2;
        private Button Btn1;
        private Button Btn5;
        private Button Btn4;
        private Button EqualBtn;
        private Button DotBtn;
        private Button Btn0;
        private Button ClearAllBtn;
        private Button MulBtn;
        private Button MinusBtn;
        private Button PlusBtn;
        private Button SingleClearBtn;
        private Label labelOperation;
    }
}