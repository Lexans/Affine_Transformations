namespace Affine_Transformations
{
    partial class FormCreate3
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMove = new System.Windows.Forms.TabPage();
            this.buttonSaveMove = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxMoveDy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMoveDx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxMoveTitle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMoveOBJ = new System.Windows.Forms.RadioButton();
            this.radioButtonMoveSK = new System.Windows.Forms.RadioButton();
            this.tabPageZoom = new System.Windows.Forms.TabPage();
            this.tabPageTurn = new System.Windows.Forms.TabPage();
            this.tabPageShear = new System.Windows.Forms.TabPage();
            this.tabPageCustom = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitleCustom = new System.Windows.Forms.TextBox();
            this.buttonSaveCustom = new System.Windows.Forms.Button();
            this.dataGridViewMatrCustom = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxZoomTitle = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButtonZoomObj = new System.Windows.Forms.RadioButton();
            this.radioButtonZoomSk = new System.Windows.Forms.RadioButton();
            this.buttonZoomSave = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBoxZoomKy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxZoomKx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonTurnSave = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxTurnAngle = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBoxTurnTitle = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.radioButtonTurnObj = new System.Windows.Forms.RadioButton();
            this.radioButtonTurnSk = new System.Windows.Forms.RadioButton();
            this.checkBoxTurnNoSolve = new System.Windows.Forms.CheckBox();
            this.buttonShearSave = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBoxShearH = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.textBoxShearTitle = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.radioButtonShearObj = new System.Windows.Forms.RadioButton();
            this.radioButtonShearSk = new System.Windows.Forms.RadioButton();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.radioButtonShearY = new System.Windows.Forms.RadioButton();
            this.radioButtonShearX = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPageMove.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageZoom.SuspendLayout();
            this.tabPageTurn.SuspendLayout();
            this.tabPageShear.SuspendLayout();
            this.tabPageCustom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrCustom)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMove);
            this.tabControl1.Controls.Add(this.tabPageZoom);
            this.tabControl1.Controls.Add(this.tabPageTurn);
            this.tabControl1.Controls.Add(this.tabPageShear);
            this.tabControl1.Controls.Add(this.tabPageCustom);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(585, 637);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageMove
            // 
            this.tabPageMove.Controls.Add(this.buttonSaveMove);
            this.tabPageMove.Controls.Add(this.groupBox3);
            this.tabPageMove.Controls.Add(this.groupBox2);
            this.tabPageMove.Controls.Add(this.groupBox1);
            this.tabPageMove.Location = new System.Drawing.Point(4, 25);
            this.tabPageMove.Name = "tabPageMove";
            this.tabPageMove.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMove.Size = new System.Drawing.Size(577, 608);
            this.tabPageMove.TabIndex = 1;
            this.tabPageMove.Text = "Перемещение";
            this.tabPageMove.UseVisualStyleBackColor = true;
            // 
            // buttonSaveMove
            // 
            this.buttonSaveMove.Location = new System.Drawing.Point(14, 303);
            this.buttonSaveMove.Name = "buttonSaveMove";
            this.buttonSaveMove.Size = new System.Drawing.Size(114, 36);
            this.buttonSaveMove.TabIndex = 16;
            this.buttonSaveMove.Text = "Сохранить";
            this.buttonSaveMove.UseVisualStyleBackColor = true;
            this.buttonSaveMove.Click += new System.EventHandler(this.buttonSaveMove_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxMoveDy);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxMoveDx);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(8, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 139);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Коэффициенты смещения";
            // 
            // textBoxMoveDy
            // 
            this.textBoxMoveDy.Location = new System.Drawing.Point(12, 97);
            this.textBoxMoveDy.Name = "textBoxMoveDy";
            this.textBoxMoveDy.Size = new System.Drawing.Size(404, 22);
            this.textBoxMoveDy.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "По y (d_y):";
            // 
            // textBoxMoveDx
            // 
            this.textBoxMoveDx.Location = new System.Drawing.Point(9, 48);
            this.textBoxMoveDx.Name = "textBoxMoveDx";
            this.textBoxMoveDx.Size = new System.Drawing.Size(407, 22);
            this.textBoxMoveDx.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "По x (d_x):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxMoveTitle);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 60);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Название матрицы";
            // 
            // textBoxMoveTitle
            // 
            this.textBoxMoveTitle.Location = new System.Drawing.Point(6, 21);
            this.textBoxMoveTitle.Name = "textBoxMoveTitle";
            this.textBoxMoveTitle.Size = new System.Drawing.Size(416, 22);
            this.textBoxMoveTitle.TabIndex = 8;
            this.textBoxMoveTitle.Text = "Перемещение";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMoveOBJ);
            this.groupBox1.Controls.Add(this.radioButtonMoveSK);
            this.groupBox1.Location = new System.Drawing.Point(8, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 80);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип перобразования";
            // 
            // radioButtonMoveOBJ
            // 
            this.radioButtonMoveOBJ.AutoSize = true;
            this.radioButtonMoveOBJ.Location = new System.Drawing.Point(6, 47);
            this.radioButtonMoveOBJ.Name = "radioButtonMoveOBJ";
            this.radioButtonMoveOBJ.Size = new System.Drawing.Size(74, 20);
            this.radioButtonMoveOBJ.TabIndex = 11;
            this.radioButtonMoveOBJ.Text = "Объект";
            this.radioButtonMoveOBJ.UseVisualStyleBackColor = true;
            // 
            // radioButtonMoveSK
            // 
            this.radioButtonMoveSK.AutoSize = true;
            this.radioButtonMoveSK.Checked = true;
            this.radioButtonMoveSK.Location = new System.Drawing.Point(6, 21);
            this.radioButtonMoveSK.Name = "radioButtonMoveSK";
            this.radioButtonMoveSK.Size = new System.Drawing.Size(147, 20);
            this.radioButtonMoveSK.TabIndex = 10;
            this.radioButtonMoveSK.TabStop = true;
            this.radioButtonMoveSK.Text = "Система координат";
            this.radioButtonMoveSK.UseVisualStyleBackColor = true;
            // 
            // tabPageZoom
            // 
            this.tabPageZoom.Controls.Add(this.buttonZoomSave);
            this.tabPageZoom.Controls.Add(this.groupBox6);
            this.tabPageZoom.Controls.Add(this.groupBox4);
            this.tabPageZoom.Controls.Add(this.groupBox5);
            this.tabPageZoom.Location = new System.Drawing.Point(4, 25);
            this.tabPageZoom.Name = "tabPageZoom";
            this.tabPageZoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageZoom.Size = new System.Drawing.Size(577, 608);
            this.tabPageZoom.TabIndex = 2;
            this.tabPageZoom.Text = "Масштабирование";
            this.tabPageZoom.UseVisualStyleBackColor = true;
            // 
            // tabPageTurn
            // 
            this.tabPageTurn.Controls.Add(this.buttonTurnSave);
            this.tabPageTurn.Controls.Add(this.groupBox7);
            this.tabPageTurn.Controls.Add(this.groupBox8);
            this.tabPageTurn.Controls.Add(this.groupBox9);
            this.tabPageTurn.Location = new System.Drawing.Point(4, 25);
            this.tabPageTurn.Name = "tabPageTurn";
            this.tabPageTurn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTurn.Size = new System.Drawing.Size(577, 608);
            this.tabPageTurn.TabIndex = 3;
            this.tabPageTurn.Text = "Поворот";
            this.tabPageTurn.UseVisualStyleBackColor = true;
            // 
            // tabPageShear
            // 
            this.tabPageShear.Controls.Add(this.groupBox13);
            this.tabPageShear.Controls.Add(this.buttonShearSave);
            this.tabPageShear.Controls.Add(this.groupBox10);
            this.tabPageShear.Controls.Add(this.groupBox11);
            this.tabPageShear.Controls.Add(this.groupBox12);
            this.tabPageShear.Location = new System.Drawing.Point(4, 25);
            this.tabPageShear.Name = "tabPageShear";
            this.tabPageShear.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShear.Size = new System.Drawing.Size(577, 608);
            this.tabPageShear.TabIndex = 4;
            this.tabPageShear.Text = "Сдвиг";
            this.tabPageShear.UseVisualStyleBackColor = true;
            // 
            // tabPageCustom
            // 
            this.tabPageCustom.AutoScroll = true;
            this.tabPageCustom.Controls.Add(this.label2);
            this.tabPageCustom.Controls.Add(this.label1);
            this.tabPageCustom.Controls.Add(this.textBoxTitleCustom);
            this.tabPageCustom.Controls.Add(this.buttonSaveCustom);
            this.tabPageCustom.Controls.Add(this.dataGridViewMatrCustom);
            this.tabPageCustom.Location = new System.Drawing.Point(4, 25);
            this.tabPageCustom.Name = "tabPageCustom";
            this.tabPageCustom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustom.Size = new System.Drawing.Size(577, 608);
            this.tabPageCustom.TabIndex = 0;
            this.tabPageCustom.Text = "Произвольная";
            this.tabPageCustom.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Значения матрицы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название матрицы";
            // 
            // textBoxTitleCustom
            // 
            this.textBoxTitleCustom.Location = new System.Drawing.Point(6, 35);
            this.textBoxTitleCustom.Name = "textBoxTitleCustom";
            this.textBoxTitleCustom.Size = new System.Drawing.Size(325, 22);
            this.textBoxTitleCustom.TabIndex = 6;
            this.textBoxTitleCustom.Text = "Произвольная";
            // 
            // buttonSaveCustom
            // 
            this.buttonSaveCustom.Location = new System.Drawing.Point(8, 233);
            this.buttonSaveCustom.Name = "buttonSaveCustom";
            this.buttonSaveCustom.Size = new System.Drawing.Size(114, 36);
            this.buttonSaveCustom.TabIndex = 5;
            this.buttonSaveCustom.Text = "Сохранить";
            this.buttonSaveCustom.UseVisualStyleBackColor = true;
            this.buttonSaveCustom.Click += new System.EventHandler(this.buttonSaveCustom_Click);
            // 
            // dataGridViewMatrCustom
            // 
            this.dataGridViewMatrCustom.AllowUserToAddRows = false;
            this.dataGridViewMatrCustom.AllowUserToDeleteRows = false;
            this.dataGridViewMatrCustom.AllowUserToResizeRows = false;
            this.dataGridViewMatrCustom.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewMatrCustom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrCustom.ColumnHeadersVisible = false;
            //this.dataGridViewMatrCustom.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewMatrCustom.Location = new System.Drawing.Point(3, 88);
            this.dataGridViewMatrCustom.Name = "dataGridViewMatrCustom";
            this.dataGridViewMatrCustom.RowHeadersVisible = false;
            this.dataGridViewMatrCustom.RowTemplate.Height = 24;
            this.dataGridViewMatrCustom.Size = new System.Drawing.Size(390, 139);
            this.dataGridViewMatrCustom.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxZoomTitle);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(437, 60);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Название матрицы";
            // 
            // textBoxZoomTitle
            // 
            this.textBoxZoomTitle.Location = new System.Drawing.Point(6, 21);
            this.textBoxZoomTitle.Name = "textBoxZoomTitle";
            this.textBoxZoomTitle.Size = new System.Drawing.Size(416, 22);
            this.textBoxZoomTitle.TabIndex = 8;
            this.textBoxZoomTitle.Text = "Масштабирование";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButtonZoomObj);
            this.groupBox5.Controls.Add(this.radioButtonZoomSk);
            this.groupBox5.Location = new System.Drawing.Point(6, 72);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(437, 80);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Тип перобразования";
            // 
            // radioButtonZoomObj
            // 
            this.radioButtonZoomObj.AutoSize = true;
            this.radioButtonZoomObj.Location = new System.Drawing.Point(6, 47);
            this.radioButtonZoomObj.Name = "radioButtonZoomObj";
            this.radioButtonZoomObj.Size = new System.Drawing.Size(74, 20);
            this.radioButtonZoomObj.TabIndex = 11;
            this.radioButtonZoomObj.Text = "Объект";
            this.radioButtonZoomObj.UseVisualStyleBackColor = true;
            // 
            // radioButtonZoomSk
            // 
            this.radioButtonZoomSk.AutoSize = true;
            this.radioButtonZoomSk.Checked = true;
            this.radioButtonZoomSk.Location = new System.Drawing.Point(6, 21);
            this.radioButtonZoomSk.Name = "radioButtonZoomSk";
            this.radioButtonZoomSk.Size = new System.Drawing.Size(147, 20);
            this.radioButtonZoomSk.TabIndex = 10;
            this.radioButtonZoomSk.TabStop = true;
            this.radioButtonZoomSk.Text = "Система координат";
            this.radioButtonZoomSk.UseVisualStyleBackColor = true;
            // 
            // buttonZoomSave
            // 
            this.buttonZoomSave.Location = new System.Drawing.Point(12, 303);
            this.buttonZoomSave.Name = "buttonZoomSave";
            this.buttonZoomSave.Size = new System.Drawing.Size(114, 36);
            this.buttonZoomSave.TabIndex = 18;
            this.buttonZoomSave.Text = "Сохранить";
            this.buttonZoomSave.UseVisualStyleBackColor = true;
            this.buttonZoomSave.Click += new System.EventHandler(this.buttonZoomSave_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBoxZoomKy);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.textBoxZoomKx);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(6, 158);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(431, 139);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Коэффициенты масштабирования";
            // 
            // textBoxZoomKy
            // 
            this.textBoxZoomKy.Location = new System.Drawing.Point(12, 97);
            this.textBoxZoomKy.Name = "textBoxZoomKy";
            this.textBoxZoomKy.Size = new System.Drawing.Size(404, 22);
            this.textBoxZoomKy.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "По y (k_y):";
            // 
            // textBoxZoomKx
            // 
            this.textBoxZoomKx.Location = new System.Drawing.Point(9, 48);
            this.textBoxZoomKx.Name = "textBoxZoomKx";
            this.textBoxZoomKx.Size = new System.Drawing.Size(407, 22);
            this.textBoxZoomKx.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "По x (k_x):";
            // 
            // buttonTurnSave
            // 
            this.buttonTurnSave.Location = new System.Drawing.Point(8, 246);
            this.buttonTurnSave.Name = "buttonTurnSave";
            this.buttonTurnSave.Size = new System.Drawing.Size(114, 36);
            this.buttonTurnSave.TabIndex = 22;
            this.buttonTurnSave.Text = "Сохранить";
            this.buttonTurnSave.UseVisualStyleBackColor = true;
            this.buttonTurnSave.Click += new System.EventHandler(this.buttonTurnSave_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBoxTurnNoSolve);
            this.groupBox7.Controls.Add(this.textBoxTurnAngle);
            this.groupBox7.Location = new System.Drawing.Point(8, 158);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(437, 82);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Угол поворота (в градусах)";
            // 
            // textBoxTurnAngle
            // 
            this.textBoxTurnAngle.Location = new System.Drawing.Point(6, 21);
            this.textBoxTurnAngle.Name = "textBoxTurnAngle";
            this.textBoxTurnAngle.Size = new System.Drawing.Size(407, 22);
            this.textBoxTurnAngle.TabIndex = 1;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBoxTurnTitle);
            this.groupBox8.Location = new System.Drawing.Point(8, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(437, 60);
            this.groupBox8.TabIndex = 20;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Название матрицы";
            // 
            // textBoxTurnTitle
            // 
            this.textBoxTurnTitle.Location = new System.Drawing.Point(6, 21);
            this.textBoxTurnTitle.Name = "textBoxTurnTitle";
            this.textBoxTurnTitle.Size = new System.Drawing.Size(416, 22);
            this.textBoxTurnTitle.TabIndex = 8;
            this.textBoxTurnTitle.Text = "Поворот";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.radioButtonTurnObj);
            this.groupBox9.Controls.Add(this.radioButtonTurnSk);
            this.groupBox9.Location = new System.Drawing.Point(8, 72);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(437, 80);
            this.groupBox9.TabIndex = 19;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Тип перобразования";
            // 
            // radioButtonTurnObj
            // 
            this.radioButtonTurnObj.AutoSize = true;
            this.radioButtonTurnObj.Location = new System.Drawing.Point(6, 47);
            this.radioButtonTurnObj.Name = "radioButtonTurnObj";
            this.radioButtonTurnObj.Size = new System.Drawing.Size(74, 20);
            this.radioButtonTurnObj.TabIndex = 11;
            this.radioButtonTurnObj.Text = "Объект";
            this.radioButtonTurnObj.UseVisualStyleBackColor = true;
            // 
            // radioButtonTurnSk
            // 
            this.radioButtonTurnSk.AutoSize = true;
            this.radioButtonTurnSk.Checked = true;
            this.radioButtonTurnSk.Location = new System.Drawing.Point(6, 21);
            this.radioButtonTurnSk.Name = "radioButtonTurnSk";
            this.radioButtonTurnSk.Size = new System.Drawing.Size(147, 20);
            this.radioButtonTurnSk.TabIndex = 10;
            this.radioButtonTurnSk.TabStop = true;
            this.radioButtonTurnSk.Text = "Система координат";
            this.radioButtonTurnSk.UseVisualStyleBackColor = true;
            // 
            // checkBoxTurnNoSolve
            // 
            this.checkBoxTurnNoSolve.AutoSize = true;
            this.checkBoxTurnNoSolve.Location = new System.Drawing.Point(7, 50);
            this.checkBoxTurnNoSolve.Name = "checkBoxTurnNoSolve";
            this.checkBoxTurnNoSolve.Size = new System.Drawing.Size(296, 20);
            this.checkBoxTurnNoSolve.TabIndex = 2;
            this.checkBoxTurnNoSolve.Text = "Не вычислять тригонометрические функции";
            this.checkBoxTurnNoSolve.UseVisualStyleBackColor = true;
            // 
            // buttonShearSave
            // 
            this.buttonShearSave.Location = new System.Drawing.Point(8, 310);
            this.buttonShearSave.Name = "buttonShearSave";
            this.buttonShearSave.Size = new System.Drawing.Size(114, 36);
            this.buttonShearSave.TabIndex = 26;
            this.buttonShearSave.Text = "Сохранить";
            this.buttonShearSave.UseVisualStyleBackColor = true;
            this.buttonShearSave.Click += new System.EventHandler(this.buttonShearSave_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBoxShearH);
            this.groupBox10.Location = new System.Drawing.Point(8, 244);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(437, 60);
            this.groupBox10.TabIndex = 25;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Величина сдвига";
            // 
            // textBoxShearH
            // 
            this.textBoxShearH.Location = new System.Drawing.Point(6, 21);
            this.textBoxShearH.Name = "textBoxShearH";
            this.textBoxShearH.Size = new System.Drawing.Size(407, 22);
            this.textBoxShearH.TabIndex = 1;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.textBoxShearTitle);
            this.groupBox11.Location = new System.Drawing.Point(8, 6);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(437, 60);
            this.groupBox11.TabIndex = 24;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Название матрицы";
            // 
            // textBoxShearTitle
            // 
            this.textBoxShearTitle.Location = new System.Drawing.Point(6, 21);
            this.textBoxShearTitle.Name = "textBoxShearTitle";
            this.textBoxShearTitle.Size = new System.Drawing.Size(416, 22);
            this.textBoxShearTitle.TabIndex = 8;
            this.textBoxShearTitle.Text = "Сдвиг";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.radioButtonShearObj);
            this.groupBox12.Controls.Add(this.radioButtonShearSk);
            this.groupBox12.Location = new System.Drawing.Point(8, 72);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(437, 80);
            this.groupBox12.TabIndex = 23;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Тип перобразования";
            // 
            // radioButtonShearObj
            // 
            this.radioButtonShearObj.AutoSize = true;
            this.radioButtonShearObj.Location = new System.Drawing.Point(6, 47);
            this.radioButtonShearObj.Name = "radioButtonShearObj";
            this.radioButtonShearObj.Size = new System.Drawing.Size(74, 20);
            this.radioButtonShearObj.TabIndex = 11;
            this.radioButtonShearObj.Text = "Объект";
            this.radioButtonShearObj.UseVisualStyleBackColor = true;
            // 
            // radioButtonShearSk
            // 
            this.radioButtonShearSk.AutoSize = true;
            this.radioButtonShearSk.Checked = true;
            this.radioButtonShearSk.Location = new System.Drawing.Point(6, 21);
            this.radioButtonShearSk.Name = "radioButtonShearSk";
            this.radioButtonShearSk.Size = new System.Drawing.Size(147, 20);
            this.radioButtonShearSk.TabIndex = 10;
            this.radioButtonShearSk.TabStop = true;
            this.radioButtonShearSk.Text = "Система координат";
            this.radioButtonShearSk.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.radioButtonShearY);
            this.groupBox13.Controls.Add(this.radioButtonShearX);
            this.groupBox13.Location = new System.Drawing.Point(8, 158);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(437, 80);
            this.groupBox13.TabIndex = 27;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Ось сдвига";
            // 
            // radioButtonShearY
            // 
            this.radioButtonShearY.AutoSize = true;
            this.radioButtonShearY.Location = new System.Drawing.Point(6, 47);
            this.radioButtonShearY.Name = "radioButtonShearY";
            this.radioButtonShearY.Size = new System.Drawing.Size(38, 20);
            this.radioButtonShearY.TabIndex = 11;
            this.radioButtonShearY.Text = "Y";
            this.radioButtonShearY.UseVisualStyleBackColor = true;
            // 
            // radioButtonShearX
            // 
            this.radioButtonShearX.AutoSize = true;
            this.radioButtonShearX.Checked = true;
            this.radioButtonShearX.Location = new System.Drawing.Point(6, 21);
            this.radioButtonShearX.Name = "radioButtonShearX";
            this.radioButtonShearX.Size = new System.Drawing.Size(38, 20);
            this.radioButtonShearX.TabIndex = 10;
            this.radioButtonShearX.TabStop = true;
            this.radioButtonShearX.Text = "X";
            this.radioButtonShearX.UseVisualStyleBackColor = true;
            // 
            // FormCreate3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 637);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormCreate3";
            this.Text = "Создание матриц 3x3";
            this.tabControl1.ResumeLayout(false);
            this.tabPageMove.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageZoom.ResumeLayout(false);
            this.tabPageTurn.ResumeLayout(false);
            this.tabPageShear.ResumeLayout(false);
            this.tabPageCustom.ResumeLayout(false);
            this.tabPageCustom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrCustom)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCustom;
        private System.Windows.Forms.TabPage tabPageMove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTitleCustom;
        private System.Windows.Forms.Button buttonSaveCustom;
        private System.Windows.Forms.DataGridView dataGridViewMatrCustom;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabPageZoom;
        private System.Windows.Forms.TabPage tabPageTurn;
        private System.Windows.Forms.TabPage tabPageShear;
        private System.Windows.Forms.TextBox textBoxMoveTitle;
        private System.Windows.Forms.RadioButton radioButtonMoveOBJ;
        private System.Windows.Forms.RadioButton radioButtonMoveSK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSaveMove;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxMoveDy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMoveDx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonZoomSave;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxZoomKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxZoomKx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxZoomTitle;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButtonZoomObj;
        private System.Windows.Forms.RadioButton radioButtonZoomSk;
        private System.Windows.Forms.Button buttonTurnSave;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBoxTurnAngle;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBoxTurnTitle;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RadioButton radioButtonTurnObj;
        private System.Windows.Forms.RadioButton radioButtonTurnSk;
        private System.Windows.Forms.CheckBox checkBoxTurnNoSolve;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.RadioButton radioButtonShearY;
        private System.Windows.Forms.RadioButton radioButtonShearX;
        private System.Windows.Forms.Button buttonShearSave;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox textBoxShearH;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox textBoxShearTitle;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.RadioButton radioButtonShearObj;
        private System.Windows.Forms.RadioButton radioButtonShearSk;
    }
}