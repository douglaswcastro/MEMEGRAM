namespace Criador_de_memes
{
    partial class Form1
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
            this.txtcaminho = new System.Windows.Forms.TextBox();
            this.txttextosup = new System.Windows.Forms.TextBox();
            this.txttextoinf = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnvisualizar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnmais = new System.Windows.Forms.Button();
            this.btnmenos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblfonte = new System.Windows.Forms.Label();
            this.txtfontsup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfontinf = new System.Windows.Forms.TextBox();
            this.btnmaiinf = new System.Windows.Forms.Button();
            this.btnmeninf = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbfonte = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbcorsup = new System.Windows.Forms.ComboBox();
            this.cbcorinf = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcaminho
            // 
            this.txtcaminho.Cursor = System.Windows.Forms.Cursors.No;
            this.txtcaminho.Location = new System.Drawing.Point(13, 25);
            this.txtcaminho.Name = "txtcaminho";
            this.txtcaminho.Size = new System.Drawing.Size(462, 20);
            this.txtcaminho.TabIndex = 0;
            this.txtcaminho.TextChanged += new System.EventHandler(this.txtcaminho_TextChanged);
            // 
            // txttextosup
            // 
            this.txttextosup.Location = new System.Drawing.Point(13, 126);
            this.txttextosup.Name = "txttextosup";
            this.txttextosup.Size = new System.Drawing.Size(259, 20);
            this.txttextosup.TabIndex = 1;
            this.txttextosup.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txttextoinf
            // 
            this.txttextoinf.Location = new System.Drawing.Point(13, 185);
            this.txttextoinf.Name = "txttextoinf";
            this.txttextoinf.Size = new System.Drawing.Size(259, 20);
            this.txttextoinf.TabIndex = 2;
            // 
            // btnbuscar
            // 
            this.btnbuscar.AutoSize = true;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.Location = new System.Drawing.Point(497, 23);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(113, 25);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "Buscar Imagem";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnvisualizar
            // 
            this.btnvisualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvisualizar.Location = new System.Drawing.Point(434, 246);
            this.btnvisualizar.Name = "btnvisualizar";
            this.btnvisualizar.Size = new System.Drawing.Size(129, 23);
            this.btnvisualizar.TabIndex = 4;
            this.btnvisualizar.Text = "Visualizar";
            this.btnvisualizar.UseVisualStyleBackColor = true;
            this.btnvisualizar.Click += new System.EventHandler(this.btnvisualizar_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalvar.Location = new System.Drawing.Point(155, 246);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(128, 23);
            this.btnsalvar.TabIndex = 5;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Caminho Imagem";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Texto Superior";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Texto Inferior";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // btnmais
            // 
            this.btnmais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmais.Location = new System.Drawing.Point(444, 123);
            this.btnmais.Name = "btnmais";
            this.btnmais.Size = new System.Drawing.Size(31, 23);
            this.btnmais.TabIndex = 10;
            this.btnmais.Text = "+";
            this.btnmais.UseVisualStyleBackColor = true;
            this.btnmais.Click += new System.EventHandler(this.btnmais_Click);
            // 
            // btnmenos
            // 
            this.btnmenos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmenos.Location = new System.Drawing.Point(408, 123);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(30, 23);
            this.btnmenos.TabIndex = 11;
            this.btnmenos.Text = "-";
            this.btnmenos.UseVisualStyleBackColor = true;
            this.btnmenos.Click += new System.EventHandler(this.btnmenos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tamanho Fonte:";
            // 
            // lblfonte
            // 
            this.lblfonte.AutoSize = true;
            this.lblfonte.Location = new System.Drawing.Point(113, 220);
            this.lblfonte.Name = "lblfonte";
            this.lblfonte.Size = new System.Drawing.Size(0, 13);
            this.lblfonte.TabIndex = 13;
            // 
            // txtfontsup
            // 
            this.txtfontsup.Location = new System.Drawing.Point(279, 126);
            this.txtfontsup.Name = "txtfontsup";
            this.txtfontsup.Size = new System.Drawing.Size(114, 20);
            this.txtfontsup.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tamanho Fonte:";
            // 
            // txtfontinf
            // 
            this.txtfontinf.Location = new System.Drawing.Point(279, 185);
            this.txtfontinf.Name = "txtfontinf";
            this.txtfontinf.Size = new System.Drawing.Size(113, 20);
            this.txtfontinf.TabIndex = 16;
            // 
            // btnmaiinf
            // 
            this.btnmaiinf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmaiinf.Location = new System.Drawing.Point(444, 182);
            this.btnmaiinf.Name = "btnmaiinf";
            this.btnmaiinf.Size = new System.Drawing.Size(31, 23);
            this.btnmaiinf.TabIndex = 17;
            this.btnmaiinf.Text = "+";
            this.btnmaiinf.UseVisualStyleBackColor = true;
            this.btnmaiinf.Click += new System.EventHandler(this.btnmaiinf_Click);
            // 
            // btnmeninf
            // 
            this.btnmeninf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmeninf.Location = new System.Drawing.Point(408, 182);
            this.btnmeninf.Name = "btnmeninf";
            this.btnmeninf.Size = new System.Drawing.Size(30, 23);
            this.btnmeninf.TabIndex = 18;
            this.btnmeninf.Text = "-";
            this.btnmeninf.UseVisualStyleBackColor = true;
            this.btnmeninf.Click += new System.EventHandler(this.btnmeninf_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Fonte:";
            // 
            // cbfonte
            // 
            this.cbfonte.FormattingEnabled = true;
            this.cbfonte.Items.AddRange(new object[] {
            "Consolas",
            "Comic Sans MS",
            "Arial",
            "Times New Roman",
            "Vivaldi",
            "FangSong",
            "KaiTi"});
            this.cbfonte.Location = new System.Drawing.Point(66, 63);
            this.cbfonte.Name = "cbfonte";
            this.cbfonte.Size = new System.Drawing.Size(409, 21);
            this.cbfonte.TabIndex = 19;
            this.cbfonte.SelectedIndexChanged += new System.EventHandler(this.cbfonte_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(494, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Cor ";
            // 
            // cbcorsup
            // 
            this.cbcorsup.FormattingEnabled = true;
            this.cbcorsup.Items.AddRange(new object[] {
            "Branco",
            "Preto",
            "Azul",
            "Vermelho",
            "Verde",
            "Rosa",
            "Amarelo"});
            this.cbcorsup.Location = new System.Drawing.Point(497, 123);
            this.cbcorsup.Name = "cbcorsup";
            this.cbcorsup.Size = new System.Drawing.Size(113, 21);
            this.cbcorsup.TabIndex = 22;
            // 
            // cbcorinf
            // 
            this.cbcorinf.FormattingEnabled = true;
            this.cbcorinf.Items.AddRange(new object[] {
            "Branco",
            "Preto",
            "Azul",
            "Vermelho",
            "Verde",
            "Rosa",
            "Amarelo"});
            this.cbcorinf.Location = new System.Drawing.Point(497, 184);
            this.cbcorinf.Name = "cbcorinf";
            this.cbcorinf.Size = new System.Drawing.Size(113, 21);
            this.cbcorinf.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(494, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cor ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 442);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbcorinf);
            this.Controls.Add(this.cbcorsup);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbfonte);
            this.Controls.Add(this.btnmeninf);
            this.Controls.Add(this.btnmaiinf);
            this.Controls.Add(this.txtfontinf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtfontsup);
            this.Controls.Add(this.lblfonte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnmenos);
            this.Controls.Add(this.btnmais);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnvisualizar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txttextoinf);
            this.Controls.Add(this.txttextosup);
            this.Controls.Add(this.txtcaminho);
            this.Name = "Form1";
            this.Text = "MemeGram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcaminho;
        private System.Windows.Forms.TextBox txttextosup;
        private System.Windows.Forms.TextBox txttextoinf;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnvisualizar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnmais;
        private System.Windows.Forms.Button btnmenos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblfonte;
        private System.Windows.Forms.TextBox txtfontsup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfontinf;
        private System.Windows.Forms.Button btnmaiinf;
        private System.Windows.Forms.Button btnmeninf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbfonte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbcorsup;
        private System.Windows.Forms.ComboBox cbcorinf;
        private System.Windows.Forms.Label label8;
    }
}

