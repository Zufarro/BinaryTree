namespace Tree
{
    partial class MainForm
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.cbTraversal = new System.Windows.Forms.ComboBox();
            this.tbPrint = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(107, 93);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(68, 22);
            this.tbInput.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.HideSelection = false;
            this.tbOutput.Location = new System.Drawing.Point(107, 269);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(563, 123);
            this.tbOutput.TabIndex = 10;
            // 
            // cbTraversal
            // 
            this.cbTraversal.AccessibleDescription = "";
            this.cbTraversal.AccessibleName = "";
            this.cbTraversal.DropDownWidth = 121;
            this.cbTraversal.FormattingEnabled = true;
            this.cbTraversal.Location = new System.Drawing.Point(107, 225);
            this.cbTraversal.Name = "cbTraversal";
            this.cbTraversal.Size = new System.Drawing.Size(200, 24);
            this.cbTraversal.TabIndex = 9;
            this.cbTraversal.Text = "Обход";
            this.cbTraversal.SelectedIndexChanged += new System.EventHandler(this.CbTraversal_SelectedIndexChanged);
            // 
            // tbPrint
            // 
            this.tbPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbPrint.Location = new System.Drawing.Point(357, 19);
            this.tbPrint.Multiline = true;
            this.tbPrint.Name = "tbPrint";
            this.tbPrint.ReadOnly = true;
            this.tbPrint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPrint.Size = new System.Drawing.Size(312, 229);
            this.tbPrint.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPrint);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.cbTraversal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbInput);
            this.HelpButton = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.ComboBox cbTraversal;
        private System.Windows.Forms.TextBox tbPrint;
    }
}

