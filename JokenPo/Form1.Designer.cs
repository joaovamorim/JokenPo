using System.Configuration.Internal;

namespace JokenPo
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
            labelTitulo = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            picResultado = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            labelResultado = new Label();
            label4 = new Label();
            label5 = new Label();
            btnPedra = new Button();
            btnPapel = new Button();
            btnTesoura = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picResultado).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.Location = new Point(29, 24);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(780, 105);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Escolha: Pedra, Papel ou Tesoura...\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(29, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(276, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 200);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            // 
            // picResultado
            // 
            picResultado.Location = new Point(516, 100);
            picResultado.Name = "picResultado";
            picResultado.Size = new Size(200, 200);
            picResultado.TabIndex = 3;
            picResultado.TabStop = false;
            picResultado.BackgroundImageLayout = ImageLayout.Stretch;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(96, 184);
            label1.Name = "label1";
            label1.Size = new Size(60, 30);
            label1.TabIndex = 4;
            label1.Text = "Você";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(357, 184);
            label2.Name = "label2";
            label2.Size = new Size(39, 30);
            label2.TabIndex = 5;
            label2.Text = "PC";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelResultado.ForeColor = SystemColors.Highlight;
            labelResultado.Location = new Point(604, 184);
            labelResultado.Name = "label3";
            labelResultado.Size = new Size(22, 30);
            labelResultado.TabIndex = 6;
            labelResultado.Text = "?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(235, 184);
            label4.Name = "label4";
            label4.Size = new Size(39, 30);
            label4.TabIndex = 7;
            label4.Text = "VS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(482, 184);
            label5.Name = "label5";
            label5.Size = new Size(28, 30);
            label5.TabIndex = 8;
            label5.Text = "=";
            // 
            // btnPedra
            // 
            btnPedra.BackgroundImage = Properties.Resources.Pedra;
            btnPedra.BackgroundImageLayout = ImageLayout.Stretch;
            btnPedra.Location = new Point(29, 306);
            btnPedra.Name = "btnPedra";
            btnPedra.Size = new Size(200, 200);
            btnPedra.TabIndex = 9;
            btnPedra.UseVisualStyleBackColor = true;
            btnPedra.Click += btnPedra_Click;
            // 
            // btnPapel
            // 
            btnPapel.BackgroundImage = Properties.Resources.Papel;
            btnPapel.BackgroundImageLayout = ImageLayout.Stretch;
            btnPapel.Location = new Point(276, 306);
            btnPapel.Name = "btnPapel";
            btnPapel.Size = new Size(200, 200);
            btnPapel.TabIndex = 10;
            btnPapel.UseVisualStyleBackColor = true;
            btnPapel.Click += btnPapel_Click;
            // 
            // btnTesoura
            // 
            btnTesoura.BackgroundImage = Properties.Resources.Tesoura;
            btnTesoura.BackgroundImageLayout = ImageLayout.Stretch;
            btnTesoura.Location = new Point(516, 306);
            btnTesoura.Name = "btnTesoura";
            btnTesoura.Size = new Size(200, 200);
            btnTesoura.TabIndex = 11;
            btnTesoura.UseVisualStyleBackColor = true;
            btnTesoura.Click += btnTesoura_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 540);
            Controls.Add(btnTesoura);
            Controls.Add(btnPapel);
            Controls.Add(btnPedra);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(labelResultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picResultado);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(labelTitulo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JokenPo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picResultado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox picResultado;
        private Label label1;
        private Label label2;
        private Label labelResultado;
        private Label label4;
        private Label label5;
        private Button btnPedra;
        private Button btnPapel;
        private Button btnTesoura;
    }
}
