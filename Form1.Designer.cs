namespace Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TxtResultado = new TextBox();
            Clear = new Button();
            Bnt7 = new Button();
            Bnt4 = new Button();
            Btn1 = new Button();
            Btn0 = new Button();
            Btn8 = new Button();
            Btn5 = new Button();
            Btn2 = new Button();
            BtnPonto = new Button();
            Btn9 = new Button();
            Btn6 = new Button();
            Btn3 = new Button();
            BtnIgual = new Button();
            BtnSoma = new Button();
            BtnSub = new Button();
            BtnMulti = new Button();
            BtnDiv = new Button();
            SuspendLayout();
            // 
            // TxtResultado
            // 
            TxtResultado.Location = new Point(33, 24);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(292, 34);
            TxtResultado.TabIndex = 0;
            TxtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // Clear
            // 
            Clear.BackColor = Color.Transparent;
            Clear.Location = new Point(33, 106);
            Clear.Name = "Clear";
            Clear.Size = new Size(53, 44);
            Clear.TabIndex = 1;
            Clear.Text = "C";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // Bnt7
            // 
            Bnt7.Location = new Point(33, 170);
            Bnt7.Name = "Bnt7";
            Bnt7.Size = new Size(53, 43);
            Bnt7.TabIndex = 2;
            Bnt7.Text = "7";
            Bnt7.UseVisualStyleBackColor = true;
            Bnt7.Click += Bnt7_Click;
            // 
            // Bnt4
            // 
            Bnt4.Location = new Point(33, 228);
            Bnt4.Name = "Bnt4";
            Bnt4.Size = new Size(53, 43);
            Bnt4.TabIndex = 3;
            Bnt4.Text = "4";
            Bnt4.UseVisualStyleBackColor = true;
            Bnt4.Click += Bnt4_Click;
            // 
            // Btn1
            // 
            Btn1.Location = new Point(33, 292);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(53, 42);
            Btn1.TabIndex = 4;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = true;
            Btn1.Click += Btn1_Click;
            // 
            // Btn0
            // 
            Btn0.Location = new Point(33, 360);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(53, 42);
            Btn0.TabIndex = 5;
            Btn0.Text = "0";
            Btn0.UseVisualStyleBackColor = true;
            Btn0.Click += Btn0_Click;
            // 
            // Btn8
            // 
            Btn8.Location = new Point(116, 170);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(53, 43);
            Btn8.TabIndex = 6;
            Btn8.Text = "8";
            Btn8.UseVisualStyleBackColor = true;
            Btn8.Click += Btn8_Click;
            // 
            // Btn5
            // 
            Btn5.Location = new Point(116, 228);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(53, 43);
            Btn5.TabIndex = 7;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = true;
            Btn5.Click += Btn5_Click;
            // 
            // Btn2
            // 
            Btn2.Location = new Point(116, 292);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(53, 43);
            Btn2.TabIndex = 8;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = true;
            Btn2.Click += Btn2_Click;
            // 
            // BtnPonto
            // 
            BtnPonto.Location = new Point(116, 360);
            BtnPonto.Name = "BtnPonto";
            BtnPonto.Size = new Size(53, 43);
            BtnPonto.TabIndex = 9;
            BtnPonto.Text = ",";
            BtnPonto.UseVisualStyleBackColor = true;
            BtnPonto.Click += BtnPonto_Click;
            // 
            // Btn9
            // 
            Btn9.Location = new Point(196, 170);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(53, 43);
            Btn9.TabIndex = 10;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = true;
            Btn9.Click += Btn9_Click;
            // 
            // Btn6
            // 
            Btn6.Location = new Point(196, 228);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(53, 43);
            Btn6.TabIndex = 11;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = true;
            Btn6.Click += Btn6_Click;
            // 
            // Btn3
            // 
            Btn3.Location = new Point(196, 292);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(53, 43);
            Btn3.TabIndex = 12;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = true;
            Btn3.Click += Btn3_Click;
            // 
            // BtnIgual
            // 
            BtnIgual.Location = new Point(196, 359);
            BtnIgual.Name = "BtnIgual";
            BtnIgual.Size = new Size(53, 43);
            BtnIgual.TabIndex = 13;
            BtnIgual.Text = "=";
            BtnIgual.UseVisualStyleBackColor = true;
            BtnIgual.Click += BtnIgual_Click;
            // 
            // BtnSoma
            // 
            BtnSoma.Location = new Point(272, 170);
            BtnSoma.Name = "BtnSoma";
            BtnSoma.Size = new Size(53, 43);
            BtnSoma.TabIndex = 14;
            BtnSoma.Text = "+";
            BtnSoma.UseVisualStyleBackColor = true;
            BtnSoma.Click += BtnSoma_Click;
            // 
            // BtnSub
            // 
            BtnSub.Location = new Point(272, 228);
            BtnSub.Name = "BtnSub";
            BtnSub.Size = new Size(53, 43);
            BtnSub.TabIndex = 15;
            BtnSub.Text = "-";
            BtnSub.UseVisualStyleBackColor = true;
            BtnSub.Click += BtnSub_Click;
            // 
            // BtnMulti
            // 
            BtnMulti.Location = new Point(272, 291);
            BtnMulti.Name = "BtnMulti";
            BtnMulti.Size = new Size(53, 43);
            BtnMulti.TabIndex = 16;
            BtnMulti.Text = "x";
            BtnMulti.UseVisualStyleBackColor = true;
            BtnMulti.Click += BtnMulti_Click;
            // 
            // BtnDiv
            // 
            BtnDiv.Location = new Point(272, 360);
            BtnDiv.Name = "BtnDiv";
            BtnDiv.Size = new Size(53, 43);
            BtnDiv.TabIndex = 17;
            BtnDiv.Text = "÷";
            BtnDiv.UseVisualStyleBackColor = true;
            BtnDiv.Click += BtnDiv_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.Disable;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(357, 450);
            Controls.Add(BtnDiv);
            Controls.Add(BtnMulti);
            Controls.Add(BtnSub);
            Controls.Add(BtnSoma);
            Controls.Add(BtnIgual);
            Controls.Add(Btn3);
            Controls.Add(Btn6);
            Controls.Add(Btn9);
            Controls.Add(BtnPonto);
            Controls.Add(Btn2);
            Controls.Add(Btn5);
            Controls.Add(Btn8);
            Controls.Add(Btn0);
            Controls.Add(Btn1);
            Controls.Add(Bnt4);
            Controls.Add(Bnt7);
            Controls.Add(Clear);
            Controls.Add(TxtResultado);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtResultado;
        private Button Clear;
        private Button Bnt7;
        private Button Bnt4;
        private Button Btn1;
        private Button Btn0;
        private Button Btn8;
        private Button Btn5;
        private Button Btn2;
        private Button BtnPonto;
        private Button Btn9;
        private Button Btn6;
        private Button Btn3;
        private Button BtnIgual;
        private Button BtnSoma;
        private Button BtnSub;
        private Button BtnMulti;
        private Button BtnDiv;
    }
}
