namespace sockets
{
    partial class VentanaLog
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox3 = new PictureBox();
            btnIniciar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(121, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(45, 157);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 49);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(97, 171);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Usuario";
            textBox1.Size = new Size(198, 35);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(97, 241);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Contraseña";
            textBox2.Size = new Size(198, 35);
            textBox2.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(45, 227);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 49);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(60, 362);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(235, 68);
            btnIniciar.TabIndex = 5;
            btnIniciar.Text = "Iniciar Sesión";
            btnIniciar.UseVisualStyleBackColor = true;
            // 
            // VentanaLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 461);
            Controls.Add(btnIniciar);
            Controls.Add(textBox2);
            Controls.Add(pictureBox3);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "VentanaLog";
            Load += this.VentanaLog_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox3;
        private Button btnIniciar;
    }
}
