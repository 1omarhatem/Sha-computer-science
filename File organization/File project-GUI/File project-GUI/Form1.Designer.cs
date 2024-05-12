namespace File_project_GUI
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
            MUNIS = new Button();
            ADD = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // MUNIS
            // 
            MUNIS.Location = new Point(124, 173);
            MUNIS.Name = "MUNIS";
            MUNIS.Size = new Size(75, 23);
            MUNIS.TabIndex = 0;
            MUNIS.Text = "-";
            MUNIS.UseVisualStyleBackColor = true;
            MUNIS.Click += MUNIS_Click;
            // 
            // ADD
            // 
            ADD.Location = new Point(350, 173);
            ADD.Name = "ADD";
            ADD.Size = new Size(75, 23);
            ADD.TabIndex = 1;
            ADD.Text = "+";
            ADD.UseVisualStyleBackColor = true;
            ADD.Click += ADD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 75);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "NUM 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(124, 134);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "NUM2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 23);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 235);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 6;
            label3.Text = "NUM2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 322);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ADD);
            Controls.Add(MUNIS);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MUNIS;
        private Button ADD;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
    }
}
