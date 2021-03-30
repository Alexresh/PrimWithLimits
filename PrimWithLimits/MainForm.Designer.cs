
namespace PrimWithLimits
{
    partial class MainForm
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
            this.calculateBtn = new System.Windows.Forms.Button();
            this.picOutGraph = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходAltF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataGridMatrix = new System.Windows.Forms.DataGridView();
            this.NumericNodesCount = new System.Windows.Forms.NumericUpDown();
            this.picInitGraph = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numLimit = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.AutoCalc = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picOutGraph)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericNodesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInitGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimit)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(568, 27);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(89, 23);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Расчитать";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // picOutGraph
            // 
            this.picOutGraph.BackColor = System.Drawing.Color.Black;
            this.picOutGraph.Location = new System.Drawing.Point(437, 56);
            this.picOutGraph.Name = "picOutGraph";
            this.picOutGraph.Size = new System.Drawing.Size(220, 220);
            this.picOutGraph.TabIndex = 1;
            this.picOutGraph.TabStop = false;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(669, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходAltF4ToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.новыйToolStripMenuItem.Text = "Новый";
            this.новыйToolStripMenuItem.Click += new System.EventHandler(this.НовыйToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.ЗагрузитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.СохранитьToolStripMenuItem_Click);
            // 
            // выходAltF4ToolStripMenuItem
            // 
            this.выходAltF4ToolStripMenuItem.Name = "выходAltF4ToolStripMenuItem";
            this.выходAltF4ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.выходAltF4ToolStripMenuItem.Text = "Выход Alt+F4";
            this.выходAltF4ToolStripMenuItem.Click += new System.EventHandler(this.ВыходAltF4ToolStripMenuItem_Click);
            // 
            // DataGridMatrix
            // 
            this.DataGridMatrix.AllowUserToAddRows = false;
            this.DataGridMatrix.AllowUserToDeleteRows = false;
            this.DataGridMatrix.AllowUserToOrderColumns = true;
            this.DataGridMatrix.AllowUserToResizeColumns = false;
            this.DataGridMatrix.AllowUserToResizeRows = false;
            this.DataGridMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridMatrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMatrix.ColumnHeadersVisible = false;
            this.DataGridMatrix.Location = new System.Drawing.Point(12, 56);
            this.DataGridMatrix.Name = "DataGridMatrix";
            this.DataGridMatrix.RowHeadersVisible = false;
            this.DataGridMatrix.Size = new System.Drawing.Size(193, 184);
            this.DataGridMatrix.TabIndex = 3;
            this.DataGridMatrix.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridMatrix_CellValueChanged);
            // 
            // NumericNodesCount
            // 
            this.NumericNodesCount.Location = new System.Drawing.Point(128, 30);
            this.NumericNodesCount.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumericNodesCount.Name = "NumericNodesCount";
            this.NumericNodesCount.Size = new System.Drawing.Size(39, 20);
            this.NumericNodesCount.TabIndex = 4;
            this.NumericNodesCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumericNodesCount.ValueChanged += new System.EventHandler(this.NumericNodesCount_ValueChanged);
            // 
            // picInitGraph
            // 
            this.picInitGraph.BackColor = System.Drawing.Color.Black;
            this.picInitGraph.Location = new System.Drawing.Point(211, 56);
            this.picInitGraph.Name = "picInitGraph";
            this.picInitGraph.Size = new System.Drawing.Size(220, 220);
            this.picInitGraph.TabIndex = 5;
            this.picInitGraph.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Количество вершин:";
            // 
            // numLimit
            // 
            this.numLimit.Location = new System.Drawing.Point(417, 30);
            this.numLimit.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numLimit.Name = "numLimit";
            this.numLimit.Size = new System.Drawing.Size(36, 20);
            this.numLimit.TabIndex = 7;
            this.numLimit.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numLimit.ValueChanged += new System.EventHandler(this.NumLimit_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ограничение на локальные степени вершин: ";
            // 
            // AutoCalc
            // 
            this.AutoCalc.AutoSize = true;
            this.AutoCalc.Location = new System.Drawing.Point(459, 31);
            this.AutoCalc.Name = "AutoCalc";
            this.AutoCalc.Size = new System.Drawing.Size(84, 17);
            this.AutoCalc.TabIndex = 9;
            this.AutoCalc.Text = "Авторасчёт";
            this.AutoCalc.UseVisualStyleBackColor = true;
            this.AutoCalc.CheckedChanged += new System.EventHandler(this.AutoCalc_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 291);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(669, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(134, 17);
            this.status.Text = "Последнее сообщение";
            // 
            // openFile
            // 
            this.openFile.FileName = "matrix.txt";
            this.openFile.Filter = "TXT file|*.txt|All files|*.*";
            // 
            // saveFile
            // 
            this.saveFile.FileName = "matrix.txt";
            this.saveFile.Filter = "TXT file|*.txt|All files|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 313);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.AutoCalc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numLimit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picInitGraph);
            this.Controls.Add(this.NumericNodesCount);
            this.Controls.Add(this.DataGridMatrix);
            this.Controls.Add(this.picOutGraph);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Алгоритм Прима при ограничениях на локальные степени вершин";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picOutGraph)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericNodesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInitGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimit)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.PictureBox picOutGraph;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходAltF4ToolStripMenuItem;
        private System.Windows.Forms.DataGridView DataGridMatrix;
        private System.Windows.Forms.NumericUpDown NumericNodesCount;
        private System.Windows.Forms.PictureBox picInitGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox AutoCalc;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}

