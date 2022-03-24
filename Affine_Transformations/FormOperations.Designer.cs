namespace Affine_Transformations
{
    partial class FormOperations
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDet = new System.Windows.Forms.TextBox();
            this.dataGridViewColumn = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewColumnRes = new System.Windows.Forms.DataGridView();
            this.buttonColumnMult = new System.Windows.Forms.Button();
            this.dataGridViewReverse = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSaveToSandbox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColumnRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReverse)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Определитель";
            // 
            // textBoxDet
            // 
            this.textBoxDet.Location = new System.Drawing.Point(12, 41);
            this.textBoxDet.Multiline = true;
            this.textBoxDet.Name = "textBoxDet";
            this.textBoxDet.Size = new System.Drawing.Size(275, 70);
            this.textBoxDet.TabIndex = 1;
            // 
            // dataGridViewColumn
            // 
            this.dataGridViewColumn.AllowUserToAddRows = false;
            this.dataGridViewColumn.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewColumn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewColumn.ColumnHeadersVisible = false;
            this.dataGridViewColumn.Location = new System.Drawing.Point(16, 172);
            this.dataGridViewColumn.Name = "dataGridViewColumn";
            this.dataGridViewColumn.RowHeadersVisible = false;
            this.dataGridViewColumn.RowTemplate.Height = 24;
            this.dataGridViewColumn.Size = new System.Drawing.Size(105, 130);
            this.dataGridViewColumn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Умножение на столбец";
            // 
            // dataGridViewColumnRes
            // 
            this.dataGridViewColumnRes.AllowUserToAddRows = false;
            this.dataGridViewColumnRes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewColumnRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewColumnRes.ColumnHeadersVisible = false;
            this.dataGridViewColumnRes.Location = new System.Drawing.Point(175, 172);
            this.dataGridViewColumnRes.Name = "dataGridViewColumnRes";
            this.dataGridViewColumnRes.RowHeadersVisible = false;
            this.dataGridViewColumnRes.RowTemplate.Height = 24;
            this.dataGridViewColumnRes.Size = new System.Drawing.Size(284, 130);
            this.dataGridViewColumnRes.TabIndex = 4;
            // 
            // buttonColumnMult
            // 
            this.buttonColumnMult.Location = new System.Drawing.Point(127, 222);
            this.buttonColumnMult.Name = "buttonColumnMult";
            this.buttonColumnMult.Size = new System.Drawing.Size(42, 38);
            this.buttonColumnMult.TabIndex = 5;
            this.buttonColumnMult.Text = "=";
            this.buttonColumnMult.UseVisualStyleBackColor = true;
            this.buttonColumnMult.Click += new System.EventHandler(this.buttonColumnMult_Click);
            // 
            // dataGridViewReverse
            // 
            this.dataGridViewReverse.AllowUserToAddRows = false;
            this.dataGridViewReverse.AllowUserToDeleteRows = false;
            this.dataGridViewReverse.AllowUserToResizeRows = false;
            this.dataGridViewReverse.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewReverse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReverse.ColumnHeadersVisible = false;
            this.dataGridViewReverse.Location = new System.Drawing.Point(16, 353);
            this.dataGridViewReverse.Name = "dataGridViewReverse";
            this.dataGridViewReverse.ReadOnly = true;
            this.dataGridViewReverse.RowHeadersVisible = false;
            this.dataGridViewReverse.RowTemplate.Height = 24;
            this.dataGridViewReverse.Size = new System.Drawing.Size(538, 164);
            this.dataGridViewReverse.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Обратная матрица";
            // 
            // buttonSaveToSandbox
            // 
            this.buttonSaveToSandbox.Location = new System.Drawing.Point(12, 523);
            this.buttonSaveToSandbox.Name = "buttonSaveToSandbox";
            this.buttonSaveToSandbox.Size = new System.Drawing.Size(214, 30);
            this.buttonSaveToSandbox.TabIndex = 8;
            this.buttonSaveToSandbox.Text = "Сохранить в песочнице";
            this.buttonSaveToSandbox.UseVisualStyleBackColor = true;
            this.buttonSaveToSandbox.Click += new System.EventHandler(this.buttonSaveToSandbox_Click);
            // 
            // FormOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 651);
            this.Controls.Add(this.buttonSaveToSandbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewReverse);
            this.Controls.Add(this.buttonColumnMult);
            this.Controls.Add(this.dataGridViewColumnRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewColumn);
            this.Controls.Add(this.textBoxDet);
            this.Controls.Add(this.label1);
            this.Name = "FormOperations";
            this.Text = "Операции с матрицей";
            this.Load += new System.EventHandler(this.FormOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColumnRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReverse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDet;
        private System.Windows.Forms.DataGridView dataGridViewColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewColumnRes;
        private System.Windows.Forms.Button buttonColumnMult;
        private System.Windows.Forms.DataGridView dataGridViewReverse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSaveToSandbox;
    }
}