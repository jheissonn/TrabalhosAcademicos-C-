namespace ArvoreBináriaCSharp
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
            this.btnInserir = new System.Windows.Forms.Button();
            this.richTextBoxMostrar = new System.Windows.Forms.RichTextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnOrdem = new System.Windows.Forms.Button();
            this.btnPosOrdem = new System.Windows.Forms.Button();
            this.btnPreOrdem = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLargura = new System.Windows.Forms.Button();
            this.numericUpDownItem = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownItem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(153, 60);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(124, 23);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // richTextBoxMostrar
            // 
            this.richTextBoxMostrar.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxMostrar.Name = "richTextBoxMostrar";
            this.richTextBoxMostrar.ReadOnly = true;
            this.richTextBoxMostrar.Size = new System.Drawing.Size(457, 426);
            this.richTextBoxMostrar.TabIndex = 1;
            this.richTextBoxMostrar.Text = "";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(154, 89);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(123, 23);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnOrdem
            // 
            this.btnOrdem.Location = new System.Drawing.Point(153, 37);
            this.btnOrdem.Name = "btnOrdem";
            this.btnOrdem.Size = new System.Drawing.Size(124, 23);
            this.btnOrdem.TabIndex = 3;
            this.btnOrdem.Text = "Mostrar em ordem";
            this.btnOrdem.UseVisualStyleBackColor = true;
            this.btnOrdem.Click += new System.EventHandler(this.btnOrdem_Click);
            // 
            // btnPosOrdem
            // 
            this.btnPosOrdem.Location = new System.Drawing.Point(153, 66);
            this.btnPosOrdem.Name = "btnPosOrdem";
            this.btnPosOrdem.Size = new System.Drawing.Size(124, 23);
            this.btnPosOrdem.TabIndex = 4;
            this.btnPosOrdem.Text = "Mostrar em PósOrdem";
            this.btnPosOrdem.UseVisualStyleBackColor = true;
            this.btnPosOrdem.Click += new System.EventHandler(this.btnPosOrdem_Click);
            // 
            // btnPreOrdem
            // 
            this.btnPreOrdem.Location = new System.Drawing.Point(153, 95);
            this.btnPreOrdem.Name = "btnPreOrdem";
            this.btnPreOrdem.Size = new System.Drawing.Size(124, 23);
            this.btnPreOrdem.TabIndex = 5;
            this.btnPreOrdem.Text = "Mostrar em Pré ordem";
            this.btnPreOrdem.UseVisualStyleBackColor = true;
            this.btnPreOrdem.Click += new System.EventHandler(this.btnPreOrdem_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(154, 118);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(123, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLargura
            // 
            this.btnLargura.Location = new System.Drawing.Point(153, 124);
            this.btnLargura.Name = "btnLargura";
            this.btnLargura.Size = new System.Drawing.Size(124, 23);
            this.btnLargura.TabIndex = 7;
            this.btnLargura.Text = "Mostrar em Largura";
            this.btnLargura.UseVisualStyleBackColor = true;
            this.btnLargura.Click += new System.EventHandler(this.btnLargura_Click);
            // 
            // numericUpDownItem
            // 
            this.numericUpDownItem.Location = new System.Drawing.Point(475, 13);
            this.numericUpDownItem.Name = "numericUpDownItem";
            this.numericUpDownItem.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownItem.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOrdem);
            this.groupBox1.Controls.Add(this.btnPosOrdem);
            this.groupBox1.Controls.Add(this.btnLargura);
            this.groupBox1.Controls.Add(this.btnPreOrdem);
            this.groupBox1.Location = new System.Drawing.Point(484, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 182);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exibição";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInserir);
            this.groupBox2.Controls.Add(this.btnRemover);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Location = new System.Drawing.Point(484, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 171);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operações";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDownItem);
            this.Controls.Add(this.richTextBoxMostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownItem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.RichTextBox richTextBoxMostrar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnOrdem;
        private System.Windows.Forms.Button btnPosOrdem;
        private System.Windows.Forms.Button btnPreOrdem;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLargura;
        private System.Windows.Forms.NumericUpDown numericUpDownItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

