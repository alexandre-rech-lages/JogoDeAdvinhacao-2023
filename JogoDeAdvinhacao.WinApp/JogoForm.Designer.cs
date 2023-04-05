namespace JogoDeAdvinhacao.WinApp
{
    partial class JogoForm
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
            txtPalpite = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            labelDica = new Label();
            SuspendLayout();
            // 
            // txtPalpite
            // 
            txtPalpite.Location = new Point(30, 72);
            txtPalpite.Name = "txtPalpite";
            txtPalpite.Size = new Size(190, 23);
            txtPalpite.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 54);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Palpite:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 109);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Dica:";
            // 
            // button1
            // 
            button1.Location = new Point(226, 72);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Chutar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 24);
            label3.Name = "label3";
            label3.Size = new Size(190, 15);
            label3.TabIndex = 4;
            label3.Text = "Informe um número entre 1 e 100: ";
            // 
            // labelDica
            // 
            labelDica.AutoSize = true;
            labelDica.Location = new Point(69, 109);
            labelDica.Name = "labelDica";
            labelDica.Size = new Size(37, 15);
            labelDica.TabIndex = 5;
            labelDica.Text = "[dica]";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelDica);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPalpite);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPalpite;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label labelDica;
    }
}