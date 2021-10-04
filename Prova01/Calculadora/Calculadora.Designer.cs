
namespace Calculadora
{
    partial class formcal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formcal));
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.rbadicao = new System.Windows.Forms.RadioButton();
            this.rbsub = new System.Windows.Forms.RadioButton();
            this.rbmult = new System.Windows.Forms.RadioButton();
            this.rbdiv = new System.Windows.Forms.RadioButton();
            this.btlimpar = new System.Windows.Forms.Button();
            this.lbnum1 = new System.Windows.Forms.Label();
            this.lbnum2 = new System.Windows.Forms.Label();
            this.lbresult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnum1
            // 
            this.txtnum1.AllowDrop = true;
            this.txtnum1.Location = new System.Drawing.Point(109, 41);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(152, 20);
            this.txtnum1.TabIndex = 0;
            // 
            // txtnum2
            // 
            this.txtnum2.AllowDrop = true;
            this.txtnum2.Location = new System.Drawing.Point(109, 104);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(152, 20);
            this.txtnum2.TabIndex = 1;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(122, 324);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(116, 20);
            this.txtresult.TabIndex = 2;
            // 
            // rbadicao
            // 
            this.rbadicao.AllowDrop = true;
            this.rbadicao.AutoSize = true;
            this.rbadicao.Location = new System.Drawing.Point(37, 19);
            this.rbadicao.Name = "rbadicao";
            this.rbadicao.Size = new System.Drawing.Size(58, 17);
            this.rbadicao.TabIndex = 3;
            this.rbadicao.TabStop = true;
            this.rbadicao.Text = "Adição";
            this.rbadicao.UseVisualStyleBackColor = true;
            this.rbadicao.CheckedChanged += new System.EventHandler(this.rbadicao_CheckedChanged);
            // 
            // rbsub
            // 
            this.rbsub.AllowDrop = true;
            this.rbsub.AutoSize = true;
            this.rbsub.Location = new System.Drawing.Point(37, 62);
            this.rbsub.Name = "rbsub";
            this.rbsub.Size = new System.Drawing.Size(74, 17);
            this.rbsub.TabIndex = 4;
            this.rbsub.TabStop = true;
            this.rbsub.Text = "Subtração";
            this.rbsub.UseVisualStyleBackColor = true;
            this.rbsub.CheckedChanged += new System.EventHandler(this.rbsub_CheckedChanged);
            // 
            // rbmult
            // 
            this.rbmult.AllowDrop = true;
            this.rbmult.AutoSize = true;
            this.rbmult.Location = new System.Drawing.Point(142, 19);
            this.rbmult.Name = "rbmult";
            this.rbmult.Size = new System.Drawing.Size(87, 17);
            this.rbmult.TabIndex = 5;
            this.rbmult.TabStop = true;
            this.rbmult.Text = "Multiplicação";
            this.rbmult.UseVisualStyleBackColor = true;
            this.rbmult.CheckedChanged += new System.EventHandler(this.rbmult_CheckedChanged);
            // 
            // rbdiv
            // 
            this.rbdiv.AllowDrop = true;
            this.rbdiv.AutoSize = true;
            this.rbdiv.Location = new System.Drawing.Point(142, 62);
            this.rbdiv.Name = "rbdiv";
            this.rbdiv.Size = new System.Drawing.Size(60, 17);
            this.rbdiv.TabIndex = 6;
            this.rbdiv.TabStop = true;
            this.rbdiv.Text = "Divisão";
            this.rbdiv.UseVisualStyleBackColor = true;
            this.rbdiv.CheckedChanged += new System.EventHandler(this.rbdiv_CheckedChanged);
            // 
            // btlimpar
            // 
            this.btlimpar.AllowDrop = true;
            this.btlimpar.Location = new System.Drawing.Point(147, 368);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(75, 23);
            this.btlimpar.TabIndex = 7;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // lbnum1
            // 
            this.lbnum1.AutoSize = true;
            this.lbnum1.Location = new System.Drawing.Point(47, 44);
            this.lbnum1.Name = "lbnum1";
            this.lbnum1.Size = new System.Drawing.Size(56, 13);
            this.lbnum1.TabIndex = 8;
            this.lbnum1.Text = "Número 1:";
            this.lbnum1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbnum2
            // 
            this.lbnum2.AutoSize = true;
            this.lbnum2.Location = new System.Drawing.Point(47, 107);
            this.lbnum2.Name = "lbnum2";
            this.lbnum2.Size = new System.Drawing.Size(56, 13);
            this.lbnum2.TabIndex = 9;
            this.lbnum2.Text = "Número 2:";
            // 
            // lbresult
            // 
            this.lbresult.AutoSize = true;
            this.lbresult.Location = new System.Drawing.Point(56, 327);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(58, 13);
            this.lbresult.TabIndex = 10;
            this.lbresult.Text = "Resultado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seleciona a operação desejada";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbsub);
            this.groupBox1.Controls.Add(this.rbdiv);
            this.groupBox1.Controls.Add(this.rbmult);
            this.groupBox1.Controls.Add(this.rbadicao);
            this.groupBox1.Location = new System.Drawing.Point(59, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 103);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // formcal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbresult);
            this.Controls.Add(this.lbnum2);
            this.Controls.Add(this.lbnum1);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "formcal";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.formcal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.RadioButton rbadicao;
        private System.Windows.Forms.RadioButton rbsub;
        private System.Windows.Forms.RadioButton rbmult;
        private System.Windows.Forms.RadioButton rbdiv;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.Label lbnum1;
        private System.Windows.Forms.Label lbnum2;
        private System.Windows.Forms.Label lbresult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

