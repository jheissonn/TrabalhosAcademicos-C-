namespace sudokuProntoFuncionando
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridSudoku = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonResolver = new System.Windows.Forms.Button();
            this.openFileDialogPrincipal = new System.Windows.Forms.OpenFileDialog();
            this.buttonImportar = new System.Windows.Forms.Button();
            this.buttonReiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSudoku)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSudoku
            // 
            this.dataGridSudoku.AllowUserToAddRows = false;
            this.dataGridSudoku.AllowUserToDeleteRows = false;
            this.dataGridSudoku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSudoku.ColumnHeadersVisible = false;
            this.dataGridSudoku.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridSudoku.Location = new System.Drawing.Point(40, 26);
            this.dataGridSudoku.Name = "dataGridSudoku";
            this.dataGridSudoku.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridSudoku.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSudoku.RowTemplate.Height = 35;
            this.dataGridSudoku.Size = new System.Drawing.Size(363, 318);
            this.dataGridSudoku.TabIndex = 0;
            this.dataGridSudoku.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSudoku_CellEndEdit);
            this.dataGridSudoku.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridSudoku_Paint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Width = 40;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.Width = 40;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.Width = 40;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.Width = 40;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.Width = 40;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.Width = 40;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.Width = 40;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.Width = 40;
            // 
            // buttonResolver
            // 
            this.buttonResolver.Location = new System.Drawing.Point(434, 26);
            this.buttonResolver.Name = "buttonResolver";
            this.buttonResolver.Size = new System.Drawing.Size(168, 45);
            this.buttonResolver.TabIndex = 1;
            this.buttonResolver.Text = "Resolver automaticamente";
            this.buttonResolver.UseVisualStyleBackColor = true;
            this.buttonResolver.Click += new System.EventHandler(this.buttonResolver_Click);
            // 
            // openFileDialogPrincipal
            // 
            this.openFileDialogPrincipal.FileName = "openFileDialog1";
            // 
            // buttonImportar
            // 
            this.buttonImportar.Location = new System.Drawing.Point(509, 100);
            this.buttonImportar.Name = "buttonImportar";
            this.buttonImportar.Size = new System.Drawing.Size(93, 28);
            this.buttonImportar.TabIndex = 2;
            this.buttonImportar.Text = "Importar";
            this.buttonImportar.UseVisualStyleBackColor = true;
            this.buttonImportar.Click += new System.EventHandler(this.buttonImportar_Click);
            // 
            // buttonReiniciar
            // 
            this.buttonReiniciar.Location = new System.Drawing.Point(509, 149);
            this.buttonReiniciar.Name = "buttonReiniciar";
            this.buttonReiniciar.Size = new System.Drawing.Size(93, 28);
            this.buttonReiniciar.TabIndex = 3;
            this.buttonReiniciar.Text = "Reiniciar";
            this.buttonReiniciar.UseVisualStyleBackColor = true;
            this.buttonReiniciar.Click += new System.EventHandler(this.buttonReiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 401);
            this.Controls.Add(this.buttonReiniciar);
            this.Controls.Add(this.buttonImportar);
            this.Controls.Add(this.buttonResolver);
            this.Controls.Add(this.dataGridSudoku);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSudoku)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSudoku;
        private System.Windows.Forms.Button buttonResolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.OpenFileDialog openFileDialogPrincipal;
        private System.Windows.Forms.Button buttonImportar;
        private System.Windows.Forms.Button buttonReiniciar;
    }
}

