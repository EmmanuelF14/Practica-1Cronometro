namespace Practica1
{
    partial class frmTemporizador
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
            components = new System.ComponentModel.Container();
            tmrCronometro = new System.Windows.Forms.Timer(components);
            button1Iniciar = new Button();
            button2Detener = new Button();
            button3Resetear = new Button();
            lblCronometro = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // tmrCronometro
            // 
            tmrCronometro.Interval = 1000;
            tmrCronometro.Tick += tmrCronometro_Tick;
            // 
            // button1Iniciar
            // 
            button1Iniciar.BackColor = SystemColors.HotTrack;
            button1Iniciar.Location = new Point(27, 121);
            button1Iniciar.Margin = new Padding(6, 5, 6, 5);
            button1Iniciar.Name = "button1Iniciar";
            button1Iniciar.Size = new Size(139, 36);
            button1Iniciar.TabIndex = 0;
            button1Iniciar.Text = "Iniciar";
            button1Iniciar.UseVisualStyleBackColor = false;
            button1Iniciar.Click += button1Iniciar_Click;
            // 
            // button2Detener
            // 
            button2Detener.BackColor = SystemColors.Highlight;
            button2Detener.Location = new Point(239, 123);
            button2Detener.Margin = new Padding(6, 5, 6, 5);
            button2Detener.Name = "button2Detener";
            button2Detener.Size = new Size(139, 36);
            button2Detener.TabIndex = 1;
            button2Detener.Text = "Detener";
            button2Detener.UseVisualStyleBackColor = false;
            button2Detener.Click += button2Detener_Click;
            // 
            // button3Resetear
            // 
            button3Resetear.BackColor = SystemColors.HotTrack;
            button3Resetear.ForeColor = SystemColors.Desktop;
            button3Resetear.Location = new Point(475, 121);
            button3Resetear.Margin = new Padding(6, 5, 6, 5);
            button3Resetear.Name = "button3Resetear";
            button3Resetear.Size = new Size(139, 36);
            button3Resetear.TabIndex = 2;
            button3Resetear.Text = "Resetear";
            button3Resetear.UseVisualStyleBackColor = false;
            button3Resetear.Click += button3_Click;
            // 
            // lblCronometro
            // 
            lblCronometro.AutoSize = true;
            lblCronometro.Font = new Font("Elephant", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCronometro.Location = new Point(201, 73);
            lblCronometro.Margin = new Padding(6, 0, 6, 0);
            lblCronometro.Name = "lblCronometro";
            lblCronometro.Size = new Size(212, 45);
            lblCronometro.TabIndex = 3;
            lblCronometro.Text = "00:00:00";
            lblCronometro.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Wide Latin", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(122, 19);
            label1.Name = "label1";
            label1.Size = new Size(350, 29);
            label1.TabIndex = 4;
            label1.Text = "CRONOMETRO";
            // 
            // frmTemporizador
            // 
            AutoScaleDimensions = new SizeF(13F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(724, 201);
            Controls.Add(label1);
            Controls.Add(lblCronometro);
            Controls.Add(button3Resetear);
            Controls.Add(button2Detener);
            Controls.Add(button1Iniciar);
            Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(6, 5, 6, 5);
            Name = "frmTemporizador";
            Text = "Cronometro";
            Load += Temporizador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrCronometro;
        private Button button1Iniciar;
        private Button button2Detener;
        private Button button3Resetear;
        private Label lblCronometro;
        private Label label1;
    }
}
