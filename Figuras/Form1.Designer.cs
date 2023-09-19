namespace Figuras
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
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            cmb_Figuras = new ComboBox();
            label2 = new Label();
            txt_RadioBI = new TextBox();
            btn_enviar = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txt_BaseBI = new TextBox();
            txt_AlturaBi = new TextBox();
            txt_Lado1Bi = new TextBox();
            txt_ALturaTri = new TextBox();
            txt_BaseTRi = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label16 = new Label();
            txt_RadioTRi = new TextBox();
            txt_ladoTri = new TextBox();
            lab = new Label();
            txt_lado2BI = new TextBox();
            label9 = new Label();
            txt_lado3BI = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(235, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 47);
            label1.TabIndex = 0;
            label1.Text = "Figuras";
            // 
            // cmb_Figuras
            // 
            cmb_Figuras.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Figuras.FormattingEnabled = true;
            cmb_Figuras.Items.AddRange(new object[] { "Círculo", "Cuadrado", "Triángulo", " Esfera ", "Cubo ", "Tetraedro" });
            cmb_Figuras.Location = new Point(235, 75);
            cmb_Figuras.Name = "cmb_Figuras";
            cmb_Figuras.Size = new Size(138, 23);
            cmb_Figuras.TabIndex = 1;
            cmb_Figuras.SelectedIndexChanged += cmb_Figuras_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 78);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 2;
            label2.Text = "Seleccione su figura";
            // 
            // txt_RadioBI
            // 
            txt_RadioBI.Location = new Point(55, 161);
            txt_RadioBI.Name = "txt_RadioBI";
            txt_RadioBI.Size = new Size(45, 23);
            txt_RadioBI.TabIndex = 4;
            txt_RadioBI.KeyPress += txt_RadioBI_KeyPress;
            // 
            // btn_enviar
            // 
            btn_enviar.Location = new Point(234, 265);
            btn_enviar.Name = "btn_enviar";
            btn_enviar.Size = new Size(94, 28);
            btn_enviar.TabIndex = 7;
            btn_enviar.Text = "Enviar";
            btn_enviar.UseVisualStyleBackColor = true;
            btn_enviar.Click += btn_enviar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 122);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 8;
            label3.Text = "Figura bidimensionales";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(382, 137);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 9;
            label4.Text = "Figura Tridimensionales";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 164);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 10;
            label5.Text = "Radio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(127, 164);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 11;
            label6.Text = "lado 1:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 203);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 12;
            label7.Text = "Base";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 242);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 13;
            label8.Text = "Altura:";
            // 
            // txt_BaseBI
            // 
            txt_BaseBI.Location = new Point(55, 200);
            txt_BaseBI.Name = "txt_BaseBI";
            txt_BaseBI.Size = new Size(45, 23);
            txt_BaseBI.TabIndex = 14;
            txt_BaseBI.KeyPress += txt_RadioBI_KeyPress;
            // 
            // txt_AlturaBi
            // 
            txt_AlturaBi.Location = new Point(60, 239);
            txt_AlturaBi.Name = "txt_AlturaBi";
            txt_AlturaBi.Size = new Size(45, 23);
            txt_AlturaBi.TabIndex = 15;
            txt_AlturaBi.KeyPress += txt_RadioBI_KeyPress;
            // 
            // txt_Lado1Bi
            // 
            txt_Lado1Bi.Location = new Point(175, 161);
            txt_Lado1Bi.Name = "txt_Lado1Bi";
            txt_Lado1Bi.Size = new Size(45, 23);
            txt_Lado1Bi.TabIndex = 18;
            txt_Lado1Bi.KeyPress += txt_RadioBI_KeyPress;
            // 
            // txt_ALturaTri
            // 
            txt_ALturaTri.Location = new Point(390, 244);
            txt_ALturaTri.Name = "txt_ALturaTri";
            txt_ALturaTri.Size = new Size(45, 23);
            txt_ALturaTri.TabIndex = 27;
            txt_ALturaTri.KeyPress += txt_RadioBI_KeyPress;
            // 
            // txt_BaseTRi
            // 
            txt_BaseTRi.Location = new Point(385, 205);
            txt_BaseTRi.Name = "txt_BaseTRi";
            txt_BaseTRi.Size = new Size(45, 23);
            txt_BaseTRi.TabIndex = 26;
            txt_BaseTRi.KeyPress += txt_RadioBI_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(342, 247);
            label13.Name = "label13";
            label13.Size = new Size(42, 15);
            label13.TabIndex = 25;
            label13.Text = "Altura:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(342, 208);
            label14.Name = "label14";
            label14.Size = new Size(31, 15);
            label14.TabIndex = 24;
            label14.Text = "Base";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(342, 169);
            label16.Name = "label16";
            label16.Size = new Size(37, 15);
            label16.TabIndex = 22;
            label16.Text = "Radio";
            // 
            // txt_RadioTRi
            // 
            txt_RadioTRi.Location = new Point(385, 166);
            txt_RadioTRi.Name = "txt_RadioTRi";
            txt_RadioTRi.Size = new Size(45, 23);
            txt_RadioTRi.TabIndex = 21;
            txt_RadioTRi.KeyPress += txt_RadioBI_KeyPress;
            // 
            // txt_ladoTri
            // 
            txt_ladoTri.Location = new Point(504, 169);
            txt_ladoTri.Name = "txt_ladoTri";
            txt_ladoTri.Size = new Size(45, 23);
            txt_ladoTri.TabIndex = 29;
            txt_ladoTri.KeyPress += txt_RadioBI_KeyPress;
            // 
            // lab
            // 
            lab.AutoSize = true;
            lab.Location = new Point(456, 172);
            lab.Name = "lab";
            lab.Size = new Size(42, 15);
            lab.TabIndex = 28;
            lab.Text = "lado 1:";
            // 
            // txt_lado2BI
            // 
            txt_lado2BI.Location = new Point(175, 195);
            txt_lado2BI.Name = "txt_lado2BI";
            txt_lado2BI.Size = new Size(45, 23);
            txt_lado2BI.TabIndex = 31;
            txt_lado2BI.KeyPress += txt_RadioBI_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(127, 198);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 30;
            label9.Text = "lado 2:";
            // 
            // txt_lado3BI
            // 
            txt_lado3BI.Location = new Point(175, 242);
            txt_lado3BI.Name = "txt_lado3BI";
            txt_lado3BI.Size = new Size(45, 23);
            txt_lado3BI.TabIndex = 33;
            txt_lado3BI.KeyPress += txt_RadioBI_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(127, 245);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 32;
            label10.Text = "lado 3:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 320);
            Controls.Add(txt_lado3BI);
            Controls.Add(label10);
            Controls.Add(txt_lado2BI);
            Controls.Add(label9);
            Controls.Add(txt_ladoTri);
            Controls.Add(lab);
            Controls.Add(txt_ALturaTri);
            Controls.Add(txt_BaseTRi);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label16);
            Controls.Add(txt_RadioTRi);
            Controls.Add(txt_Lado1Bi);
            Controls.Add(txt_AlturaBi);
            Controls.Add(txt_BaseBI);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_enviar);
            Controls.Add(txt_RadioBI);
            Controls.Add(label2);
            Controls.Add(cmb_Figuras);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "figuras";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox cmb_Figuras;
        private Label label2;
        private TextBox txt_RadioBI;
        private TextBox txt_BaseBI;
        private Button btn_enviar;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txt_AlturaBi;
        private TextBox txt_Lado1Bi;
        private TextBox txt_ALturaTri;
        private TextBox txt_BaseTRi;
        private Label label13;
        private Label label14;
        private Label label16;
        private TextBox txt_RadioTRi;
        private TextBox txt_ladoTri;
        private Label lab;
        private TextBox txt_lado2BI;
        private Label label9;
        private TextBox txt_lado3BI;
        private Label label10;
    }
}