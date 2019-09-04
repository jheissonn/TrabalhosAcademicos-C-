namespace AlgoritimoDeOrdenacao
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
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.richTextBoxMostrar = new System.Windows.Forms.RichTextBox();
            this.progressBarProgresso = new System.Windows.Forms.ProgressBar();
            this.checkBoxBubble = new System.Windows.Forms.CheckBox();
            this.checkBoxSelection = new System.Windows.Forms.CheckBox();
            this.checkBoxInsertion = new System.Windows.Forms.CheckBox();
            this.checkBoxQuick = new System.Windows.Forms.CheckBox();
            this.checkBoxCocktail = new System.Windows.Forms.CheckBox();
            this.groupBoxMetodos = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxMetodos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(456, 107);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // richTextBoxMostrar
            // 
            this.richTextBoxMostrar.Location = new System.Drawing.Point(12, 169);
            this.richTextBoxMostrar.Name = "richTextBoxMostrar";
            this.richTextBoxMostrar.ReadOnly = true;
            this.richTextBoxMostrar.Size = new System.Drawing.Size(519, 268);
            this.richTextBoxMostrar.TabIndex = 2;
            this.richTextBoxMostrar.Text = "";
            // 
            // progressBarProgresso
            // 
            this.progressBarProgresso.Location = new System.Drawing.Point(204, 140);
            this.progressBarProgresso.Name = "progressBarProgresso";
            this.progressBarProgresso.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBarProgresso.Size = new System.Drawing.Size(327, 23);
            this.progressBarProgresso.TabIndex = 6;
            // 
            // checkBoxBubble
            // 
            this.checkBoxBubble.AutoSize = true;
            this.checkBoxBubble.Location = new System.Drawing.Point(20, 32);
            this.checkBoxBubble.Name = "checkBoxBubble";
            this.checkBoxBubble.Size = new System.Drawing.Size(79, 17);
            this.checkBoxBubble.TabIndex = 5;
            this.checkBoxBubble.Text = "Bubble sort";
            this.checkBoxBubble.UseVisualStyleBackColor = true;
            // 
            // checkBoxSelection
            // 
            this.checkBoxSelection.AutoSize = true;
            this.checkBoxSelection.Location = new System.Drawing.Point(20, 55);
            this.checkBoxSelection.Name = "checkBoxSelection";
            this.checkBoxSelection.Size = new System.Drawing.Size(92, 17);
            this.checkBoxSelection.TabIndex = 6;
            this.checkBoxSelection.Text = "Selection Sort";
            this.checkBoxSelection.UseVisualStyleBackColor = true;
            // 
            // checkBoxInsertion
            // 
            this.checkBoxInsertion.AutoSize = true;
            this.checkBoxInsertion.Location = new System.Drawing.Point(20, 78);
            this.checkBoxInsertion.Name = "checkBoxInsertion";
            this.checkBoxInsertion.Size = new System.Drawing.Size(88, 17);
            this.checkBoxInsertion.TabIndex = 7;
            this.checkBoxInsertion.Text = "Insertion Sort";
            this.checkBoxInsertion.UseVisualStyleBackColor = true;
            // 
            // checkBoxQuick
            // 
            this.checkBoxQuick.AutoSize = true;
            this.checkBoxQuick.Location = new System.Drawing.Point(20, 101);
            this.checkBoxQuick.Name = "checkBoxQuick";
            this.checkBoxQuick.Size = new System.Drawing.Size(76, 17);
            this.checkBoxQuick.TabIndex = 8;
            this.checkBoxQuick.Text = "Quick Sort";
            this.checkBoxQuick.UseVisualStyleBackColor = true;
            // 
            // checkBoxCocktail
            // 
            this.checkBoxCocktail.AutoSize = true;
            this.checkBoxCocktail.Location = new System.Drawing.Point(20, 124);
            this.checkBoxCocktail.Name = "checkBoxCocktail";
            this.checkBoxCocktail.Size = new System.Drawing.Size(86, 17);
            this.checkBoxCocktail.TabIndex = 9;
            this.checkBoxCocktail.Text = "Cocktail Sort";
            this.checkBoxCocktail.UseVisualStyleBackColor = true;
            // 
            // groupBoxMetodos
            // 
            this.groupBoxMetodos.Controls.Add(this.checkBoxBubble);
            this.groupBoxMetodos.Controls.Add(this.checkBoxCocktail);
            this.groupBoxMetodos.Controls.Add(this.checkBoxSelection);
            this.groupBoxMetodos.Controls.Add(this.checkBoxQuick);
            this.groupBoxMetodos.Controls.Add(this.checkBoxInsertion);
            this.groupBoxMetodos.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMetodos.Name = "groupBoxMetodos";
            this.groupBoxMetodos.Size = new System.Drawing.Size(186, 151);
            this.groupBoxMetodos.TabIndex = 10;
            this.groupBoxMetodos.TabStop = false;
            this.groupBoxMetodos.Text = "Selecione os métodos desejados.";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 478);
            this.Controls.Add(this.groupBoxMetodos);
            this.Controls.Add(this.progressBarProgresso);
            this.Controls.Add(this.richTextBoxMostrar);
            this.Controls.Add(this.btnOrdenar);
            this.Name = "Form1";
            this.Text = "Algoritmos de ordenação";
            this.groupBoxMetodos.ResumeLayout(false);
            this.groupBoxMetodos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.RichTextBox richTextBoxMostrar;
        private System.Windows.Forms.ProgressBar progressBarProgresso;
        private System.Windows.Forms.CheckBox checkBoxBubble;
        private System.Windows.Forms.CheckBox checkBoxSelection;
        private System.Windows.Forms.CheckBox checkBoxInsertion;
        private System.Windows.Forms.CheckBox checkBoxQuick;
        private System.Windows.Forms.CheckBox checkBoxCocktail;
        private System.Windows.Forms.GroupBox groupBoxMetodos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

