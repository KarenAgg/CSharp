
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
            this.txtnum1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum1.Location = new System.Drawing.Point(104, 48);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(176, 23);
            this.txtnum1.TabIndex = 0;
            // 
            // txtnum2
            // 
            this.txtnum2.AllowDrop = true;
            this.txtnum2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum2.Location = new System.Drawing.Point(104, 98);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(176, 23);
            this.txtnum2.TabIndex = 1;
            // 
            // txtresult
            // 
            this.txtresult.Enabled = false;
            this.txtresult.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.HideSelection = false;
            this.txtresult.Location = new System.Drawing.Point(29, 364);
            this.txtresult.Name = "txtresult";
            this.txtresult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtresult.Size = new System.Drawing.Size(137, 23);
            this.txtresult.TabIndex = 2;
            this.txtresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rbadicao
            // 
            this.rbadicao.AllowDrop = true;
            this.rbadicao.AutoSize = true;
            this.rbadicao.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbadicao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.rbadicao.Location = new System.Drawing.Point(29, 19);
            this.rbadicao.Name = "rbadicao";
            this.rbadicao.Size = new System.Drawing.Size(64, 20);
            this.rbadicao.TabIndex = 3;
            this.rbadicao.Text = "Adição";
            this.rbadicao.UseVisualStyleBackColor = true;
            this.rbadicao.CheckedChanged += new System.EventHandler(this.rbadicao_CheckedChanged);
            // 
            // rbsub
            // 
            this.rbsub.AllowDrop = true;
            this.rbsub.AutoSize = true;
            this.rbsub.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbsub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.rbsub.Location = new System.Drawing.Point(29, 62);
            this.rbsub.Name = "rbsub";
            this.rbsub.Size = new System.Drawing.Size(84, 20);
            this.rbsub.TabIndex = 4;
            this.rbsub.Text = "Subtração";
            this.rbsub.UseVisualStyleBackColor = true;
            this.rbsub.CheckedChanged += new System.EventHandler(this.rbsub_CheckedChanged);
            // 
            // rbmult
            // 
            this.rbmult.AllowDrop = true;
            this.rbmult.AutoSize = true;
            this.rbmult.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbmult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.rbmult.Location = new System.Drawing.Point(135, 19);
            this.rbmult.Name = "rbmult";
            this.rbmult.Size = new System.Drawing.Size(99, 20);
            this.rbmult.TabIndex = 5;
            this.rbmult.Text = "Multiplicação";
            this.rbmult.UseVisualStyleBackColor = true;
            this.rbmult.CheckedChanged += new System.EventHandler(this.rbmult_CheckedChanged);
            // 
            // rbdiv
            // 
            this.rbdiv.AllowDrop = true;
            this.rbdiv.AutoSize = true;
            this.rbdiv.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbdiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.rbdiv.Location = new System.Drawing.Point(135, 62);
            this.rbdiv.Name = "rbdiv";
            this.rbdiv.Size = new System.Drawing.Size(66, 20);
            this.rbdiv.TabIndex = 6;
            this.rbdiv.Text = "Divisão";
            this.rbdiv.UseVisualStyleBackColor = true;
            this.rbdiv.CheckedChanged += new System.EventHandler(this.rbdiv_CheckedChanged);
            // 
            // btlimpar
            // 
            this.btlimpar.AllowDrop = true;
            this.btlimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(170)))));
            this.btlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlimpar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btlimpar.Location = new System.Drawing.Point(203, 361);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(77, 26);
            this.btlimpar.TabIndex = 7;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btlimpar.UseVisualStyleBackColor = false;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // lbnum1
            // 
            this.lbnum1.AutoSize = true;
            this.lbnum1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnum1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.lbnum1.Location = new System.Drawing.Point(26, 48);
            this.lbnum1.Name = "lbnum1";
            this.lbnum1.Size = new System.Drawing.Size(69, 16);
            this.lbnum1.TabIndex = 8;
            this.lbnum1.Text = "Número 1:";
            this.lbnum1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbnum2
            // 
            this.lbnum2.AutoSize = true;
            this.lbnum2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnum2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.lbnum2.Location = new System.Drawing.Point(26, 98);
            this.lbnum2.Name = "lbnum2";
            this.lbnum2.Size = new System.Drawing.Size(69, 16);
            this.lbnum2.TabIndex = 9;
            this.lbnum2.Text = "Número 2:";
            // 
            // lbresult
            // 
            this.lbresult.AutoSize = true;
            this.lbresult.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbresult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.lbresult.Location = new System.Drawing.Point(26, 348);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(69, 16);
            this.lbresult.TabIndex = 10;
            this.lbresult.Text = "Resultado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(170)))));
            this.label1.Location = new System.Drawing.Point(55, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seleciona a operação desejada:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbsub);
            this.groupBox1.Controls.Add(this.rbdiv);
            this.groupBox1.Controls.Add(this.rbmult);
            this.groupBox1.Controls.Add(this.rbadicao);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(170)))));
            this.groupBox1.Location = new System.Drawing.Point(29, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(251, 103);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // formcal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(311, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbresult);
            this.Controls.Add(this.lbnum2);
            this.Controls.Add(this.lbnum1);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Label lbnum1;
        private System.Windows.Forms.Label lbnum2;
        private System.Windows.Forms.Label lbresult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btlimpar;
    }
}

