using System.Windows.Forms;
namespace Affine_Transformations
{
    partial class FormMultiplication
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
            this.dataGridViewMatr = new System.Windows.Forms.DataGridView();
            this.buttonSaveToSandbox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatr)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMatr
            // 
            this.dataGridViewMatr.AllowUserToAddRows = false;
            this.dataGridViewMatr.AllowUserToDeleteRows = false;
            this.dataGridViewMatr.AllowUserToResizeRows = false;
            this.dataGridViewMatr.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewMatr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatr.ColumnHeadersVisible = false;
            this.dataGridViewMatr.Location = new System.Drawing.Point(12, 30);
            this.dataGridViewMatr.Name = "dataGridViewMatr";
            this.dataGridViewMatr.ReadOnly = true;
            this.dataGridViewMatr.RowHeadersVisible = false;
            this.dataGridViewMatr.RowTemplate.Height = 24;
            this.dataGridViewMatr.Size = new System.Drawing.Size(671, 230);
            this.dataGridViewMatr.TabIndex = 5;
            // 
            // buttonSaveToSandbox
            // 
            this.buttonSaveToSandbox.Location = new System.Drawing.Point(12, 266);
            this.buttonSaveToSandbox.Name = "buttonSaveToSandbox";
            this.buttonSaveToSandbox.Size = new System.Drawing.Size(215, 33);
            this.buttonSaveToSandbox.TabIndex = 6;
            this.buttonSaveToSandbox.Text = "Сохранить в песочнице";
            this.buttonSaveToSandbox.UseVisualStyleBackColor = true;
            this.buttonSaveToSandbox.Click += new System.EventHandler(this.buttonSaveToSandbox_Click);
            // 
            // FormMultiplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 317);
            this.Controls.Add(this.buttonSaveToSandbox);
            this.Controls.Add(this.dataGridViewMatr);
            this.Name = "FormMultiplication";
            this.Text = "Перемножение матриц";
            this.Load += new System.EventHandler(this.FormMultiplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMatr;
        private System.Windows.Forms.Button buttonSaveToSandbox;

    }
}