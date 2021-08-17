
namespace SuperCarros
{
    partial class FormNovoJogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNovoJogo));
            this.dataGridViewNovoJogo = new System.Windows.Forms.DataGridView();
            this.groupBoxDigID = new System.Windows.Forms.GroupBox();
            this.textBoxC3 = new System.Windows.Forms.TextBox();
            this.textBoxC2 = new System.Windows.Forms.TextBox();
            this.textBoxC1 = new System.Windows.Forms.TextBox();
            this.labelC3 = new System.Windows.Forms.Label();
            this.labelC2 = new System.Windows.Forms.Label();
            this.labelC1 = new System.Windows.Forms.Label();
            this.buttonSelCarNJ = new System.Windows.Forms.Button();
            this.buttonRdmCarNJ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNovoJogo)).BeginInit();
            this.groupBoxDigID.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewNovoJogo
            // 
            this.dataGridViewNovoJogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNovoJogo.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewNovoJogo.Name = "dataGridViewNovoJogo";
            this.dataGridViewNovoJogo.Size = new System.Drawing.Size(859, 269);
            this.dataGridViewNovoJogo.TabIndex = 0;
            // 
            // groupBoxDigID
            // 
            this.groupBoxDigID.Controls.Add(this.textBoxC3);
            this.groupBoxDigID.Controls.Add(this.textBoxC2);
            this.groupBoxDigID.Controls.Add(this.textBoxC1);
            this.groupBoxDigID.Controls.Add(this.labelC3);
            this.groupBoxDigID.Controls.Add(this.labelC2);
            this.groupBoxDigID.Controls.Add(this.labelC1);
            this.groupBoxDigID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDigID.Location = new System.Drawing.Point(135, 302);
            this.groupBoxDigID.Name = "groupBoxDigID";
            this.groupBoxDigID.Size = new System.Drawing.Size(616, 66);
            this.groupBoxDigID.TabIndex = 1;
            this.groupBoxDigID.TabStop = false;
            this.groupBoxDigID.Text = "Digite os ids das cartas:";
            // 
            // textBoxC3
            // 
            this.textBoxC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxC3.Location = new System.Drawing.Point(511, 29);
            this.textBoxC3.Name = "textBoxC3";
            this.textBoxC3.Size = new System.Drawing.Size(100, 26);
            this.textBoxC3.TabIndex = 4;
            // 
            // textBoxC2
            // 
            this.textBoxC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxC2.Location = new System.Drawing.Point(286, 29);
            this.textBoxC2.Name = "textBoxC2";
            this.textBoxC2.Size = new System.Drawing.Size(100, 26);
            this.textBoxC2.TabIndex = 3;
            // 
            // textBoxC1
            // 
            this.textBoxC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxC1.Location = new System.Drawing.Point(81, 29);
            this.textBoxC1.Name = "textBoxC1";
            this.textBoxC1.Size = new System.Drawing.Size(100, 26);
            this.textBoxC1.TabIndex = 2;
            // 
            // labelC3
            // 
            this.labelC3.AutoSize = true;
            this.labelC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC3.Location = new System.Drawing.Point(435, 32);
            this.labelC3.Name = "labelC3";
            this.labelC3.Size = new System.Drawing.Size(73, 20);
            this.labelC3.TabIndex = 2;
            this.labelC3.Text = "Carta 3:";
            // 
            // labelC2
            // 
            this.labelC2.AutoSize = true;
            this.labelC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC2.Location = new System.Drawing.Point(211, 32);
            this.labelC2.Name = "labelC2";
            this.labelC2.Size = new System.Drawing.Size(73, 20);
            this.labelC2.TabIndex = 1;
            this.labelC2.Text = "Carta 2:";
            // 
            // labelC1
            // 
            this.labelC1.AutoSize = true;
            this.labelC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC1.Location = new System.Drawing.Point(6, 32);
            this.labelC1.Name = "labelC1";
            this.labelC1.Size = new System.Drawing.Size(73, 20);
            this.labelC1.TabIndex = 0;
            this.labelC1.Text = "Carta 1:";
            // 
            // buttonSelCarNJ
            // 
            this.buttonSelCarNJ.BackColor = System.Drawing.Color.LightBlue;
            this.buttonSelCarNJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelCarNJ.Location = new System.Drawing.Point(257, 399);
            this.buttonSelCarNJ.Name = "buttonSelCarNJ";
            this.buttonSelCarNJ.Size = new System.Drawing.Size(162, 37);
            this.buttonSelCarNJ.TabIndex = 2;
            this.buttonSelCarNJ.Text = "Selecionar Cartas";
            this.buttonSelCarNJ.UseVisualStyleBackColor = false;
            this.buttonSelCarNJ.Click += new System.EventHandler(this.buttonSelCarNJ_Click);
            // 
            // buttonRdmCarNJ
            // 
            this.buttonRdmCarNJ.BackColor = System.Drawing.Color.LightBlue;
            this.buttonRdmCarNJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRdmCarNJ.Location = new System.Drawing.Point(459, 399);
            this.buttonRdmCarNJ.Name = "buttonRdmCarNJ";
            this.buttonRdmCarNJ.Size = new System.Drawing.Size(162, 37);
            this.buttonRdmCarNJ.TabIndex = 3;
            this.buttonRdmCarNJ.Text = "Randomizar Cartas";
            this.buttonRdmCarNJ.UseVisualStyleBackColor = false;
            this.buttonRdmCarNJ.Click += new System.EventHandler(this.buttonRdmCarNJ_Click);
            // 
            // FormNovoJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(883, 443);
            this.Controls.Add(this.buttonRdmCarNJ);
            this.Controls.Add(this.buttonSelCarNJ);
            this.Controls.Add(this.groupBoxDigID);
            this.Controls.Add(this.dataGridViewNovoJogo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormNovoJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção de Cartas - Novo Jogo";
            this.Load += new System.EventHandler(this.FormNovoJogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNovoJogo)).EndInit();
            this.groupBoxDigID.ResumeLayout(false);
            this.groupBoxDigID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNovoJogo;
        private System.Windows.Forms.GroupBox groupBoxDigID;
        private System.Windows.Forms.Label labelC1;
        private System.Windows.Forms.Label labelC2;
        private System.Windows.Forms.TextBox textBoxC1;
        private System.Windows.Forms.Label labelC3;
        private System.Windows.Forms.TextBox textBoxC3;
        private System.Windows.Forms.TextBox textBoxC2;
        private System.Windows.Forms.Button buttonSelCarNJ;
        private System.Windows.Forms.Button buttonRdmCarNJ;
    }
}