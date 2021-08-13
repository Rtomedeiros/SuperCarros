
namespace SuperCarros
{
    partial class FormEditarCartas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarCartas));
            this.dataGridViewEditarCartas = new System.Windows.Forms.DataGridView();
            this.pictureBoxUpImg = new System.Windows.Forms.PictureBox();
            this.buttonAbrirImg = new System.Windows.Forms.Button();
            this.labelEditID = new System.Windows.Forms.Label();
            this.labelEditMar = new System.Windows.Forms.Label();
            this.labelEditNom = new System.Windows.Forms.Label();
            this.labelEditVel = new System.Windows.Forms.Label();
            this.labelEditPot = new System.Windows.Forms.Label();
            this.labelEditMot = new System.Windows.Forms.Label();
            this.labelEditAce = new System.Windows.Forms.Label();
            this.labelEditPes = new System.Windows.Forms.Label();
            this.textBoxEditID = new System.Windows.Forms.TextBox();
            this.textBoxEditMar = new System.Windows.Forms.TextBox();
            this.textBoxEditNom = new System.Windows.Forms.TextBox();
            this.textBoxEditVel = new System.Windows.Forms.TextBox();
            this.textBoxEditPot = new System.Windows.Forms.TextBox();
            this.textBoxEditMot = new System.Windows.Forms.TextBox();
            this.textBoxEditAce = new System.Windows.Forms.TextBox();
            this.textBoxEditPes = new System.Windows.Forms.TextBox();
            this.buttonCriarCarta = new System.Windows.Forms.Button();
            this.buttonUpCarta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditarCartas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpImg)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEditarCartas
            // 
            this.dataGridViewEditarCartas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEditarCartas.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewEditarCartas.Name = "dataGridViewEditarCartas";
            this.dataGridViewEditarCartas.Size = new System.Drawing.Size(859, 279);
            this.dataGridViewEditarCartas.TabIndex = 0;
            this.dataGridViewEditarCartas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEditarCartas_CellContentClick);
            // 
            // pictureBoxUpImg
            // 
            this.pictureBoxUpImg.Location = new System.Drawing.Point(12, 297);
            this.pictureBoxUpImg.Name = "pictureBoxUpImg";
            this.pictureBoxUpImg.Size = new System.Drawing.Size(295, 162);
            this.pictureBoxUpImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUpImg.TabIndex = 1;
            this.pictureBoxUpImg.TabStop = false;
            this.pictureBoxUpImg.Click += new System.EventHandler(this.pictureBoxUpImg_Click);
            // 
            // buttonAbrirImg
            // 
            this.buttonAbrirImg.BackColor = System.Drawing.Color.LightBlue;
            this.buttonAbrirImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbrirImg.Location = new System.Drawing.Point(86, 465);
            this.buttonAbrirImg.Name = "buttonAbrirImg";
            this.buttonAbrirImg.Size = new System.Drawing.Size(144, 38);
            this.buttonAbrirImg.TabIndex = 2;
            this.buttonAbrirImg.Text = "Abrir Imagem";
            this.buttonAbrirImg.UseVisualStyleBackColor = false;
            this.buttonAbrirImg.Click += new System.EventHandler(this.buttonAbrirImg_Click);
            // 
            // labelEditID
            // 
            this.labelEditID.AutoSize = true;
            this.labelEditID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditID.Location = new System.Drawing.Point(347, 304);
            this.labelEditID.Name = "labelEditID";
            this.labelEditID.Size = new System.Drawing.Size(33, 20);
            this.labelEditID.TabIndex = 3;
            this.labelEditID.Text = "ID:";
            // 
            // labelEditMar
            // 
            this.labelEditMar.AutoSize = true;
            this.labelEditMar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditMar.Location = new System.Drawing.Point(317, 337);
            this.labelEditMar.Name = "labelEditMar";
            this.labelEditMar.Size = new System.Drawing.Size(63, 20);
            this.labelEditMar.TabIndex = 4;
            this.labelEditMar.Text = "Marca:";
            // 
            // labelEditNom
            // 
            this.labelEditNom.AutoSize = true;
            this.labelEditNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditNom.Location = new System.Drawing.Point(320, 369);
            this.labelEditNom.Name = "labelEditNom";
            this.labelEditNom.Size = new System.Drawing.Size(60, 20);
            this.labelEditNom.TabIndex = 5;
            this.labelEditNom.Text = "Nome:";
            // 
            // labelEditVel
            // 
            this.labelEditVel.AutoSize = true;
            this.labelEditVel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditVel.Location = new System.Drawing.Point(579, 302);
            this.labelEditVel.Name = "labelEditVel";
            this.labelEditVel.Size = new System.Drawing.Size(82, 20);
            this.labelEditVel.TabIndex = 6;
            this.labelEditVel.Text = "Vel. Máx:";
            // 
            // labelEditPot
            // 
            this.labelEditPot.AutoSize = true;
            this.labelEditPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditPot.Location = new System.Drawing.Point(577, 336);
            this.labelEditPot.Name = "labelEditPot";
            this.labelEditPot.Size = new System.Drawing.Size(84, 20);
            this.labelEditPot.TabIndex = 7;
            this.labelEditPot.Text = "Potência:";
            // 
            // labelEditMot
            // 
            this.labelEditMot.AutoSize = true;
            this.labelEditMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditMot.Location = new System.Drawing.Point(601, 368);
            this.labelEditMot.Name = "labelEditMot";
            this.labelEditMot.Size = new System.Drawing.Size(60, 20);
            this.labelEditMot.TabIndex = 8;
            this.labelEditMot.Text = "Motor:";
            // 
            // labelEditAce
            // 
            this.labelEditAce.AutoSize = true;
            this.labelEditAce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditAce.Location = new System.Drawing.Point(557, 401);
            this.labelEditAce.Name = "labelEditAce";
            this.labelEditAce.Size = new System.Drawing.Size(104, 20);
            this.labelEditAce.TabIndex = 9;
            this.labelEditAce.Text = "Aceleração:";
            // 
            // labelEditPes
            // 
            this.labelEditPes.AutoSize = true;
            this.labelEditPes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditPes.Location = new System.Drawing.Point(607, 432);
            this.labelEditPes.Name = "labelEditPes";
            this.labelEditPes.Size = new System.Drawing.Size(54, 20);
            this.labelEditPes.TabIndex = 10;
            this.labelEditPes.Text = "Peso:";
            // 
            // textBoxEditID
            // 
            this.textBoxEditID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditID.Location = new System.Drawing.Point(386, 299);
            this.textBoxEditID.Name = "textBoxEditID";
            this.textBoxEditID.Size = new System.Drawing.Size(81, 26);
            this.textBoxEditID.TabIndex = 11;
            // 
            // textBoxEditMar
            // 
            this.textBoxEditMar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditMar.Location = new System.Drawing.Point(386, 331);
            this.textBoxEditMar.Name = "textBoxEditMar";
            this.textBoxEditMar.Size = new System.Drawing.Size(157, 26);
            this.textBoxEditMar.TabIndex = 12;
            // 
            // textBoxEditNom
            // 
            this.textBoxEditNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditNom.Location = new System.Drawing.Point(386, 363);
            this.textBoxEditNom.Name = "textBoxEditNom";
            this.textBoxEditNom.Size = new System.Drawing.Size(157, 26);
            this.textBoxEditNom.TabIndex = 13;
            // 
            // textBoxEditVel
            // 
            this.textBoxEditVel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditVel.Location = new System.Drawing.Point(667, 299);
            this.textBoxEditVel.Name = "textBoxEditVel";
            this.textBoxEditVel.Size = new System.Drawing.Size(118, 26);
            this.textBoxEditVel.TabIndex = 14;
            // 
            // textBoxEditPot
            // 
            this.textBoxEditPot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditPot.Location = new System.Drawing.Point(667, 331);
            this.textBoxEditPot.Name = "textBoxEditPot";
            this.textBoxEditPot.Size = new System.Drawing.Size(118, 26);
            this.textBoxEditPot.TabIndex = 15;
            // 
            // textBoxEditMot
            // 
            this.textBoxEditMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditMot.Location = new System.Drawing.Point(667, 363);
            this.textBoxEditMot.Name = "textBoxEditMot";
            this.textBoxEditMot.Size = new System.Drawing.Size(118, 26);
            this.textBoxEditMot.TabIndex = 16;
            // 
            // textBoxEditAce
            // 
            this.textBoxEditAce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditAce.Location = new System.Drawing.Point(667, 395);
            this.textBoxEditAce.Name = "textBoxEditAce";
            this.textBoxEditAce.Size = new System.Drawing.Size(118, 26);
            this.textBoxEditAce.TabIndex = 17;
            // 
            // textBoxEditPes
            // 
            this.textBoxEditPes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEditPes.Location = new System.Drawing.Point(667, 426);
            this.textBoxEditPes.Name = "textBoxEditPes";
            this.textBoxEditPes.Size = new System.Drawing.Size(118, 26);
            this.textBoxEditPes.TabIndex = 18;
            // 
            // buttonCriarCarta
            // 
            this.buttonCriarCarta.BackColor = System.Drawing.Color.LightBlue;
            this.buttonCriarCarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriarCarta.Location = new System.Drawing.Point(430, 465);
            this.buttonCriarCarta.Name = "buttonCriarCarta";
            this.buttonCriarCarta.Size = new System.Drawing.Size(144, 38);
            this.buttonCriarCarta.TabIndex = 19;
            this.buttonCriarCarta.Text = "Criar Carta";
            this.buttonCriarCarta.UseVisualStyleBackColor = false;
            this.buttonCriarCarta.Click += new System.EventHandler(this.buttonCriarCarta_Click);
            // 
            // buttonUpCarta
            // 
            this.buttonUpCarta.BackColor = System.Drawing.Color.LightBlue;
            this.buttonUpCarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpCarta.Location = new System.Drawing.Point(594, 465);
            this.buttonUpCarta.Name = "buttonUpCarta";
            this.buttonUpCarta.Size = new System.Drawing.Size(144, 38);
            this.buttonUpCarta.TabIndex = 20;
            this.buttonUpCarta.Text = "Update Carta";
            this.buttonUpCarta.UseVisualStyleBackColor = false;
            this.buttonUpCarta.Click += new System.EventHandler(this.buttonUpCarta_Click);
            // 
            // FormEditarCartas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(883, 511);
            this.Controls.Add(this.buttonUpCarta);
            this.Controls.Add(this.buttonCriarCarta);
            this.Controls.Add(this.textBoxEditPes);
            this.Controls.Add(this.textBoxEditAce);
            this.Controls.Add(this.textBoxEditMot);
            this.Controls.Add(this.textBoxEditPot);
            this.Controls.Add(this.textBoxEditVel);
            this.Controls.Add(this.textBoxEditNom);
            this.Controls.Add(this.textBoxEditMar);
            this.Controls.Add(this.textBoxEditID);
            this.Controls.Add(this.labelEditPes);
            this.Controls.Add(this.labelEditAce);
            this.Controls.Add(this.labelEditMot);
            this.Controls.Add(this.labelEditPot);
            this.Controls.Add(this.labelEditVel);
            this.Controls.Add(this.labelEditNom);
            this.Controls.Add(this.labelEditMar);
            this.Controls.Add(this.labelEditID);
            this.Controls.Add(this.buttonAbrirImg);
            this.Controls.Add(this.pictureBoxUpImg);
            this.Controls.Add(this.dataGridViewEditarCartas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEditarCartas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Cartas";
            this.Load += new System.EventHandler(this.FormEditarCartas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditarCartas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUpImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEditarCartas;
        private System.Windows.Forms.PictureBox pictureBoxUpImg;
        private System.Windows.Forms.Button buttonAbrirImg;
        private System.Windows.Forms.Label labelEditID;
        private System.Windows.Forms.Label labelEditMar;
        private System.Windows.Forms.Label labelEditNom;
        private System.Windows.Forms.Label labelEditVel;
        private System.Windows.Forms.Label labelEditPot;
        private System.Windows.Forms.Label labelEditMot;
        private System.Windows.Forms.Label labelEditAce;
        private System.Windows.Forms.Label labelEditPes;
        private System.Windows.Forms.TextBox textBoxEditID;
        private System.Windows.Forms.TextBox textBoxEditMar;
        private System.Windows.Forms.TextBox textBoxEditNom;
        private System.Windows.Forms.TextBox textBoxEditVel;
        private System.Windows.Forms.TextBox textBoxEditPot;
        private System.Windows.Forms.TextBox textBoxEditMot;
        private System.Windows.Forms.TextBox textBoxEditAce;
        private System.Windows.Forms.TextBox textBoxEditPes;
        private System.Windows.Forms.Button buttonCriarCarta;
        private System.Windows.Forms.Button buttonUpCarta;
    }
}