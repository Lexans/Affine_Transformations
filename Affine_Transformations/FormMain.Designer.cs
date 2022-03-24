namespace Affine_Transformations
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelSandbox = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripSandboxTools = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonClearSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCopyAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCreate = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3x3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4x4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSandboxTitle = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanelWorkenv = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripWorkEnvTools = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonMuliplicateReverse = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMultiplicateDirect = new System.Windows.Forms.ToolStripButton();
            this.toolStripWorkEnvTitle = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.toolStripSandboxTools.SuspendLayout();
            this.toolStripSandboxTitle.SuspendLayout();
            this.toolStripWorkEnvTools.SuspendLayout();
            this.toolStripWorkEnvTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.tableLayoutPanelSandbox);
            this.splitContainerMain.Panel1.Controls.Add(this.toolStripSandboxTools);
            this.splitContainerMain.Panel1.Controls.Add(this.toolStripSandboxTitle);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.tableLayoutPanelWorkenv);
            this.splitContainerMain.Panel2.Controls.Add(this.toolStripWorkEnvTools);
            this.splitContainerMain.Panel2.Controls.Add(this.toolStripWorkEnvTitle);
            this.splitContainerMain.Size = new System.Drawing.Size(1059, 635);
            this.splitContainerMain.SplitterDistance = 565;
            this.splitContainerMain.TabIndex = 1;
            // 
            // tableLayoutPanelSandbox
            // 
            this.tableLayoutPanelSandbox.AutoScroll = true;
            this.tableLayoutPanelSandbox.ColumnCount = 1;
            this.tableLayoutPanelSandbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelSandbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSandbox.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutPanelSandbox.Name = "tableLayoutPanelSandbox";
            this.tableLayoutPanelSandbox.RowCount = 1;
            this.tableLayoutPanelSandbox.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelSandbox.Size = new System.Drawing.Size(565, 579);
            this.tableLayoutPanelSandbox.TabIndex = 3;
            // 
            // toolStripSandboxTools
            // 
            this.toolStripSandboxTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonClearSB,
            this.toolStripButtonCopyAll,
            this.toolStripButtonCreate,
            this.toolStripButton3x3,
            this.toolStripButton4x4,
            this.toolStripDropDownButton1});
            this.toolStripSandboxTools.Location = new System.Drawing.Point(0, 26);
            this.toolStripSandboxTools.Name = "toolStripSandboxTools";
            this.toolStripSandboxTools.Size = new System.Drawing.Size(565, 30);
            this.toolStripSandboxTools.TabIndex = 1;
            this.toolStripSandboxTools.Text = "toolStrip2";
            // 
            // toolStripButtonClearSB
            // 
            this.toolStripButtonClearSB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonClearSB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripButtonClearSB.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClearSB.Image")));
            this.toolStripButtonClearSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClearSB.Name = "toolStripButtonClearSB";
            this.toolStripButtonClearSB.Size = new System.Drawing.Size(88, 27);
            this.toolStripButtonClearSB.Text = "Очистить";
            this.toolStripButtonClearSB.Click += new System.EventHandler(this.toolStripButtonClearSB_Click);
            // 
            // toolStripButtonCopyAll
            // 
            this.toolStripButtonCopyAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCopyAll.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripButtonCopyAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCopyAll.Image")));
            this.toolStripButtonCopyAll.ImageTransparentColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripButtonCopyAll.Name = "toolStripButtonCopyAll";
            this.toolStripButtonCopyAll.Size = new System.Drawing.Size(139, 27);
            this.toolStripButtonCopyAll.Text = "Копировать всё";
            this.toolStripButtonCopyAll.Click += new System.EventHandler(this.toolStripButtonCopyAll_Click);
            // 
            // toolStripButtonCreate
            // 
            this.toolStripButtonCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCreate.Name = "toolStripButtonCreate";
            this.toolStripButtonCreate.Size = new System.Drawing.Size(148, 27);
            this.toolStripButtonCreate.Text = "Создать матрицу:";
            // 
            // toolStripButton3x3
            // 
            this.toolStripButton3x3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3x3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripButton3x3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3x3.Name = "toolStripButton3x3";
            this.toolStripButton3x3.Size = new System.Drawing.Size(40, 27);
            this.toolStripButton3x3.Text = "3x3";
            this.toolStripButton3x3.Click += new System.EventHandler(this.toolStripButton3x3_Click);
            // 
            // toolStripButton4x4
            // 
            this.toolStripButton4x4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4x4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripButton4x4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4x4.Name = "toolStripButton4x4";
            this.toolStripButton4x4.Size = new System.Drawing.Size(40, 27);
            this.toolStripButton4x4.Text = "4x4";
            this.toolStripButton4x4.Click += new System.EventHandler(this.toolStripButton4x4_Click);
            // 
            // toolStripSandboxTitle
            // 
            this.toolStripSandboxTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripSandboxTitle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripSandboxTitle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStripSandboxTitle.Location = new System.Drawing.Point(0, 0);
            this.toolStripSandboxTitle.Name = "toolStripSandboxTitle";
            this.toolStripSandboxTitle.Size = new System.Drawing.Size(565, 26);
            this.toolStripSandboxTitle.TabIndex = 0;
            this.toolStripSandboxTitle.Text = "toolStrip3";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(98, 23);
            this.toolStripLabel1.Text = "Песочница";
            // 
            // tableLayoutPanelWorkenv
            // 
            this.tableLayoutPanelWorkenv.AutoScroll = true;
            this.tableLayoutPanelWorkenv.ColumnCount = 1;
            this.tableLayoutPanelWorkenv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelWorkenv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelWorkenv.Location = new System.Drawing.Point(0, 56);
            this.tableLayoutPanelWorkenv.Name = "tableLayoutPanelWorkenv";
            this.tableLayoutPanelWorkenv.RowCount = 1;
            this.tableLayoutPanelWorkenv.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelWorkenv.Size = new System.Drawing.Size(490, 579);
            this.tableLayoutPanelWorkenv.TabIndex = 2;
            // 
            // toolStripWorkEnvTools
            // 
            this.toolStripWorkEnvTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonClear,
            this.toolStripLabel3,
            this.toolStripButtonMuliplicateReverse,
            this.toolStripButtonMultiplicateDirect});
            this.toolStripWorkEnvTools.Location = new System.Drawing.Point(0, 26);
            this.toolStripWorkEnvTools.Name = "toolStripWorkEnvTools";
            this.toolStripWorkEnvTools.Size = new System.Drawing.Size(490, 30);
            this.toolStripWorkEnvTools.TabIndex = 1;
            this.toolStripWorkEnvTools.Text = "toolStrip3";
            // 
            // toolStripButtonClear
            // 
            this.toolStripButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonClear.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Size = new System.Drawing.Size(88, 27);
            this.toolStripButtonClear.Text = "Очистить";
            this.toolStripButtonClear.Click += new System.EventHandler(this.toolStripButtonClear_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(125, 27);
            this.toolStripLabel3.Text = "Перемножить:";
            // 
            // toolStripButtonMuliplicateReverse
            // 
            this.toolStripButtonMuliplicateReverse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonMuliplicateReverse.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripButtonMuliplicateReverse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMuliplicateReverse.Image")));
            this.toolStripButtonMuliplicateReverse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMuliplicateReverse.Name = "toolStripButtonMuliplicateReverse";
            this.toolStripButtonMuliplicateReverse.Size = new System.Drawing.Size(80, 27);
            this.toolStripButtonMuliplicateReverse.Text = "обратно";
            this.toolStripButtonMuliplicateReverse.Click += new System.EventHandler(this.toolStripButtonMuliplicateReverse_Click);
            // 
            // toolStripButtonMultiplicateDirect
            // 
            this.toolStripButtonMultiplicateDirect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonMultiplicateDirect.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripButtonMultiplicateDirect.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMultiplicateDirect.Image")));
            this.toolStripButtonMultiplicateDirect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMultiplicateDirect.Name = "toolStripButtonMultiplicateDirect";
            this.toolStripButtonMultiplicateDirect.Size = new System.Drawing.Size(65, 27);
            this.toolStripButtonMultiplicateDirect.Text = "прямо";
            this.toolStripButtonMultiplicateDirect.Click += new System.EventHandler(this.toolStripButtonMultiplicateDirect_Click);
            // 
            // toolStripWorkEnvTitle
            // 
            this.toolStripWorkEnvTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripWorkEnvTitle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripWorkEnvTitle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2});
            this.toolStripWorkEnvTitle.Location = new System.Drawing.Point(0, 0);
            this.toolStripWorkEnvTitle.Name = "toolStripWorkEnvTitle";
            this.toolStripWorkEnvTitle.Size = new System.Drawing.Size(490, 26);
            this.toolStripWorkEnvTitle.TabIndex = 0;
            this.toolStripWorkEnvTitle.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(127, 23);
            this.toolStripLabel2.Text = "Рабочая среда";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(63, 27);
            this.toolStripDropDownButton1.Text = "файл";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(164, 28);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(164, 28);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Файл матриц|*.matr";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.AddExtension = false;
            this.saveFileDialog1.FileName = "Untitled.matr";
            this.saveFileDialog1.Filter = "Файл матриц|*.matr";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1059, 635);
            this.Controls.Add(this.splitContainerMain);
            this.Name = "FormMain";
            this.Text = "Affine Transformations";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.toolStripSandboxTools.ResumeLayout(false);
            this.toolStripSandboxTools.PerformLayout();
            this.toolStripSandboxTitle.ResumeLayout(false);
            this.toolStripSandboxTitle.PerformLayout();
            this.toolStripWorkEnvTools.ResumeLayout(false);
            this.toolStripWorkEnvTools.PerformLayout();
            this.toolStripWorkEnvTitle.ResumeLayout(false);
            this.toolStripWorkEnvTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ToolStrip toolStripSandboxTitle;
        private System.Windows.Forms.ToolStrip toolStripWorkEnvTitle;
        private System.Windows.Forms.ToolStrip toolStripSandboxTools;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStripWorkEnvTools;
        private System.Windows.Forms.ToolStripButton toolStripButtonClear;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWorkenv;
        private System.Windows.Forms.ToolStripLabel toolStripButtonCreate;
        private System.Windows.Forms.ToolStripButton toolStripButton3x3;
        private System.Windows.Forms.ToolStripButton toolStripButton4x4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSandbox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButtonMuliplicateReverse;
        private System.Windows.Forms.ToolStripButton toolStripButtonMultiplicateDirect;
        private System.Windows.Forms.ToolStripButton toolStripButtonClearSB;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopyAll;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

