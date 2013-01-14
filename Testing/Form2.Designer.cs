namespace Testing
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.myCheckBox1 = new MyControls.WindowsControls.myCheckBox(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.myComboBox1 = new MyControls.WindowsControls.myComboBox(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(101, 148);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // myCheckBox1
            // 
            this.myCheckBox1.AutoSize = true;
            this.myCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.myCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myCheckBox1.ForeColor = System.Drawing.Color.White;
            this.myCheckBox1.Location = new System.Drawing.Point(87, 204);
            this.myCheckBox1.Name = "myCheckBox1";
            this.myCheckBox1.ReadOnly = false;
            this.myCheckBox1.Size = new System.Drawing.Size(105, 17);
            this.myCheckBox1.TabIndex = 2;
            this.myCheckBox1.Text = "myCheckBox1";
            this.myCheckBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // myComboBox1
            // 
            this.myComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.myComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.myComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.myComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myComboBox1.ForeColor = System.Drawing.Color.Black;
            this.myComboBox1.FormattingEnabled = true;
            this.myComboBox1.Location = new System.Drawing.Point(267, 215);
            this.myComboBox1.Name = "myComboBox1";
            this.myComboBox1.ReadOnly = false;
            this.myComboBox1.Size = new System.Drawing.Size(219, 21);
            this.myComboBox1.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(530, 365);
            this.Controls.Add(this.myComboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.myCheckBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.KeyPreview = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private MyControls.WindowsControls.myCheckBox myCheckBox1;
        private System.Windows.Forms.TextBox textBox1;
        private MyControls.WindowsControls.myComboBox myComboBox1;
    }
}