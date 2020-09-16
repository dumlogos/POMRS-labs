namespace Lab_2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментальнаяПанельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolBar = new System.Windows.Forms.Panel();
            this.ttHint = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.bExit = new System.Windows.Forms.Button();
            this.bHelp = new System.Windows.Forms.Button();
            this.bPaste = new System.Windows.Forms.Button();
            this.bCopy = new System.Windows.Forms.Button();
            this.bCut = new System.Windows.Forms.Button();
            this.bFileClose = new System.Windows.Forms.Button();
            this.bFileSave = new System.Windows.Forms.Button();
            this.bFileOpen = new System.Windows.Forms.Button();
            this.bFileNew = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pToolBar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.редактированиеToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.создатьToolStripMenuItem.Text = "&Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.bFileNew_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.открытьToolStripMenuItem.Text = "&Открыть...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.bFileOpen_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.сохранитьToolStripMenuItem.Text = "&Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.bFileSave_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.сохранитьКакToolStripMenuItem.Text = "&Сохранить как...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.выходToolStripMenuItem.Text = "&Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.bExit_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инструментальнаяПанельToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "&Вид";
            // 
            // инструментальнаяПанельToolStripMenuItem
            // 
            this.инструментальнаяПанельToolStripMenuItem.Name = "инструментальнаяПанельToolStripMenuItem";
            this.инструментальнаяПанельToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.инструментальнаяПанельToolStripMenuItem.Text = "&Инструментальная панель";
            this.инструментальнаяПанельToolStripMenuItem.Click += new System.EventHandler(this.инструментальнаяПанельToolStripItem_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.редактированиеToolStripMenuItem.Text = "&Редактирование";
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.вырезатьToolStripMenuItem.Text = "&Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.bCut_Click);

            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.копироватьToolStripMenuItem.Text = "&Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.вставитьToolStripMenuItem.Text = "&Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.bPaste_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "&?";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "&О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.bHelp_Click);
            // 
            // pToolBar
            // 
            this.pToolBar.Controls.Add(this.bExit);
            this.pToolBar.Controls.Add(this.bHelp);
            this.pToolBar.Controls.Add(this.bPaste);
            this.pToolBar.Controls.Add(this.bCopy);
            this.pToolBar.Controls.Add(this.bCut);
            this.pToolBar.Controls.Add(this.bFileClose);
            this.pToolBar.Controls.Add(this.bFileSave);
            this.pToolBar.Controls.Add(this.bFileOpen);
            this.pToolBar.Controls.Add(this.bFileNew);
            this.pToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pToolBar.Location = new System.Drawing.Point(0, 24);
            this.pToolBar.Name = "pToolBar";
            this.pToolBar.Size = new System.Drawing.Size(384, 66);
            this.pToolBar.TabIndex = 1;
            // 
            // ttHint
            // 
            this.ttHint.IsBalloon = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 364);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(384, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(64, 17);
            this.toolStripStatusLabel1.Text = "Без имени";
            // 
            // rtbText
            // 
            this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbText.Location = new System.Drawing.Point(0, 90);
            this.rtbText.Name = "rtbText";
            this.rtbText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbText.Size = new System.Drawing.Size(384, 274);
            this.rtbText.TabIndex = 3;
            this.rtbText.Text = "";
            // 
            // openFD
            // 
            this.openFD.FileName = "openFileDialog1";
            this.openFD.Filter = "TXT файлы|*.txt";
            // 
            // saveFD
            // 
            this.saveFD.Filter = "TXT файлы|*.txt";
            // 
            // bExit
            // 
            this.bExit.Image = global::Lab_2.Properties.Resources.Home_16x;
            this.bExit.Location = new System.Drawing.Point(340, 30);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(25, 25);
            this.bExit.TabIndex = 8;
            this.ttHint.SetToolTip(this.bExit, "«Выход»");
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bHelp
            // 
            this.bHelp.Image = global::Lab_2.Properties.Resources.Question_16x;
            this.bHelp.Location = new System.Drawing.Point(288, 30);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(25, 25);
            this.bHelp.TabIndex = 7;
            this.ttHint.SetToolTip(this.bHelp, "«Справка»");
            this.bHelp.UseVisualStyleBackColor = true;
            this.bHelp.Click += new System.EventHandler(this.bHelp_Click);
            // 
            // bPaste
            // 
            this.bPaste.Image = global::Lab_2.Properties.Resources.ASX_Paste_grey_16x;
            this.bPaste.Location = new System.Drawing.Point(225, 30);
            this.bPaste.Name = "bPaste";
            this.bPaste.Size = new System.Drawing.Size(25, 25);
            this.bPaste.TabIndex = 6;
            this.ttHint.SetToolTip(this.bPaste, "«Вставить»");
            this.bPaste.UseVisualStyleBackColor = true;
            this.bPaste.Click += new System.EventHandler(this.bPaste_Click);
            // 
            // bCopy
            // 
            this.bCopy.Image = global::Lab_2.Properties.Resources.ASX_Copy_grey_16x;
            this.bCopy.Location = new System.Drawing.Point(194, 30);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(25, 25);
            this.bCopy.TabIndex = 5;
            this.ttHint.SetToolTip(this.bCopy, "«Копировать»");
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // bCut
            // 
            this.bCut.Image = global::Lab_2.Properties.Resources.Cut_16x;
            this.bCut.Location = new System.Drawing.Point(163, 30);
            this.bCut.Name = "bCut";
            this.bCut.Size = new System.Drawing.Size(25, 25);
            this.bCut.TabIndex = 4;
            this.ttHint.SetToolTip(this.bCut, "«Вырезать»");
            this.bCut.UseVisualStyleBackColor = true;
            this.bCut.Click += new System.EventHandler(this.bCut_Click);
            // 
            // bFileClose
            // 
            this.bFileClose.Image = global::Lab_2.Properties.Resources.Close_red_16x;
            this.bFileClose.Location = new System.Drawing.Point(105, 30);
            this.bFileClose.Name = "bFileClose";
            this.bFileClose.Size = new System.Drawing.Size(25, 25);
            this.bFileClose.TabIndex = 3;
            this.ttHint.SetToolTip(this.bFileClose, "«Закрыть»");
            this.bFileClose.UseVisualStyleBackColor = true;
            this.bFileClose.Click += new System.EventHandler(this.bFileClose_Click);
            // 
            // bFileSave
            // 
            this.bFileSave.Image = global::Lab_2.Properties.Resources.Save_grey_16x;
            this.bFileSave.Location = new System.Drawing.Point(74, 30);
            this.bFileSave.Name = "bFileSave";
            this.bFileSave.Size = new System.Drawing.Size(25, 25);
            this.bFileSave.TabIndex = 2;
            this.bFileSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ttHint.SetToolTip(this.bFileSave, "«Сохранить»");
            this.bFileSave.UseMnemonic = false;
            this.bFileSave.UseVisualStyleBackColor = true;
            this.bFileSave.Click += new System.EventHandler(this.bFileSave_Click);

            // 
            // bFileOpen
            // 
            this.bFileOpen.Image = global::Lab_2.Properties.Resources.OpenFile_16x;
            this.bFileOpen.Location = new System.Drawing.Point(43, 30);
            this.bFileOpen.Name = "bFileOpen";
            this.bFileOpen.Size = new System.Drawing.Size(25, 25);
            this.bFileOpen.TabIndex = 1;
            this.ttHint.SetToolTip(this.bFileOpen, "«Открыть»");
            this.bFileOpen.UseVisualStyleBackColor = true;
            this.bFileOpen.Click += new System.EventHandler(this.bFileOpen_Click);
            // 
            // bFileNew
            // 
            this.bFileNew.Image = ((System.Drawing.Image)(resources.GetObject("bFileNew.Image")));
            this.bFileNew.Location = new System.Drawing.Point(12, 30);
            this.bFileNew.Name = "bFileNew";
            this.bFileNew.Size = new System.Drawing.Size(25, 25);
            this.bFileNew.TabIndex = 0;
            this.ttHint.SetToolTip(this.bFileNew, "«Создать»");
            this.bFileNew.UseVisualStyleBackColor = true;
            this.bFileNew.Click += new System.EventHandler(this.bFileNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 386);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pToolBar);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Текстовый редактор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pToolBar.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментальнаяПанельToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Panel pToolBar;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bHelp;
        private System.Windows.Forms.Button bPaste;
        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.Button bCut;
        private System.Windows.Forms.Button bFileClose;
        private System.Windows.Forms.Button bFileSave;
        private System.Windows.Forms.Button bFileOpen;
        private System.Windows.Forms.Button bFileNew;
        private System.Windows.Forms.ToolTip ttHint;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.SaveFileDialog saveFD;
    }
}

