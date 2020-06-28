namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.bAddTask = new System.Windows.Forms.PictureBox();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.listBoxTask = new System.Windows.Forms.ListBox();
            this.labelTask = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.bСlose = new System.Windows.Forms.Button();
            this.isDone = new System.Windows.Forms.CheckBox();
            this.creationData = new System.Windows.Forms.Label();
            this.Notepad = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйДокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bDelete = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bAddTask)).BeginInit();
            this.panelRight.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.AutoSize = true;
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(15)))));
            this.panelLeft.Controls.Add(this.bDelete);
            this.panelLeft.Controls.Add(this.bAddTask);
            this.panelLeft.Controls.Add(this.TaskName);
            this.panelLeft.Controls.Add(this.listBoxTask);
            this.panelLeft.Controls.Add(this.labelTask);
            this.panelLeft.Location = new System.Drawing.Point(-2, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(257, 761);
            this.panelLeft.TabIndex = 0;
            // 
            // bAddTask
            // 
            this.bAddTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bAddTask.Image = global::ToDoList.Properties.Resources.iconfinder_Plus_2190977;
            this.bAddTask.InitialImage = null;
            this.bAddTask.Location = new System.Drawing.Point(210, 41);
            this.bAddTask.Name = "bAddTask";
            this.bAddTask.Size = new System.Drawing.Size(34, 26);
            this.bAddTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bAddTask.TabIndex = 5;
            this.bAddTask.TabStop = false;
            this.bAddTask.Click += new System.EventHandler(this.bAddTask_Click);
            this.bAddTask.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bAddTask_MouseDown);
            this.bAddTask.MouseLeave += new System.EventHandler(this.bAddTask_MouseLeave);
            this.bAddTask.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bAddTask_MouseMove);
            // 
            // TaskName
            // 
            this.TaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskName.Location = new System.Drawing.Point(8, 41);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(204, 26);
            this.TaskName.TabIndex = 3;
            // 
            // listBoxTask
            // 
            this.listBoxTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(16)))), ((int)(((byte)(15)))));
            this.listBoxTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxTask.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxTask.FormattingEnabled = true;
            this.listBoxTask.ItemHeight = 20;
            this.listBoxTask.Location = new System.Drawing.Point(14, 112);
            this.listBoxTask.Name = "listBoxTask";
            this.listBoxTask.Size = new System.Drawing.Size(233, 640);
            this.listBoxTask.TabIndex = 1;
            // 
            // labelTask
            // 
            this.labelTask.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTask.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTask.Location = new System.Drawing.Point(3, 0);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(241, 38);
            this.labelTask.TabIndex = 0;
            this.labelTask.Text = "Задачи";
            this.labelTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(22)))));
            this.panelRight.Controls.Add(this.bСlose);
            this.panelRight.Controls.Add(this.isDone);
            this.panelRight.Controls.Add(this.creationData);
            this.panelRight.Controls.Add(this.Notepad);
            this.panelRight.Controls.Add(this.menuStrip1);
            this.panelRight.ForeColor = System.Drawing.SystemColors.Control;
            this.panelRight.Location = new System.Drawing.Point(248, 2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(584, 761);
            this.panelRight.TabIndex = 1;
            // 
            // bСlose
            // 
            this.bСlose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bСlose.Location = new System.Drawing.Point(506, 0);
            this.bСlose.Name = "bСlose";
            this.bСlose.Size = new System.Drawing.Size(75, 23);
            this.bСlose.TabIndex = 3;
            this.bСlose.Text = "X";
            this.bСlose.UseVisualStyleBackColor = true;
            this.bСlose.Click += new System.EventHandler(this.bСlose_Click);
            // 
            // isDone
            // 
            this.isDone.AutoSize = true;
            this.isDone.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isDone.Location = new System.Drawing.Point(23, 28);
            this.isDone.Name = "isDone";
            this.isDone.Size = new System.Drawing.Size(144, 30);
            this.isDone.TabIndex = 2;
            this.isDone.Text = "Выполнена";
            this.isDone.UseVisualStyleBackColor = true;
            // 
            // creationData
            // 
            this.creationData.AutoSize = true;
            this.creationData.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creationData.Location = new System.Drawing.Point(201, 29);
            this.creationData.Name = "creationData";
            this.creationData.Size = new System.Drawing.Size(165, 26);
            this.creationData.TabIndex = 1;
            this.creationData.Text = "Дата Создания";
            // 
            // Notepad
            // 
            this.Notepad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Notepad.Location = new System.Drawing.Point(3, 143);
            this.Notepad.Multiline = true;
            this.Notepad.Name = "Notepad";
            this.Notepad.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Notepad.Size = new System.Drawing.Size(584, 615);
            this.Notepad.TabIndex = 0;
            this.Notepad.Leave += new System.EventHandler(this.Notepad_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 119);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(115, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйДокументToolStripMenuItem,
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйДокументToolStripMenuItem
            // 
            this.новыйДокументToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.новыйДокументToolStripMenuItem.Name = "новыйДокументToolStripMenuItem";
            this.новыйДокументToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.новыйДокументToolStripMenuItem.Text = "Новый документ";
            this.новыйДокументToolStripMenuItem.Click += new System.EventHandler(this.CreatNewDocument);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.открытьToolStripMenuItem.Text = "Открыть...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.вставитьToolStripMenuItem});
            this.правкаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.OnCopyClick);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.OnCutClick);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.OnPasteClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(169, 84);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 6;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(831, 766);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список Задач";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bAddTask)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.ListBox listBoxTask;
        private System.Windows.Forms.TextBox Notepad;
        private System.Windows.Forms.Label creationData;
        private System.Windows.Forms.CheckBox isDone;
        private System.Windows.Forms.TextBox TaskName;
        private System.Windows.Forms.Button bСlose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйДокументToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox bAddTask;
        private System.Windows.Forms.Button bDelete;
    }
}

