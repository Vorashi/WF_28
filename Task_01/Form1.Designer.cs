namespace Task_01
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLoading = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDraft = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChange = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.TbxInput = new System.Windows.Forms.TextBox();
            this.TabCont = new System.Windows.Forms.TabControl();
            this.TdJanuary = new System.Windows.Forms.TabPage();
            this.LboxJanuary = new System.Windows.Forms.ListBox();
            this.TdFebruary = new System.Windows.Forms.TabPage();
            this.LboxFebruary = new System.Windows.Forms.ListBox();
            this.TdMarch = new System.Windows.Forms.TabPage();
            this.LboxMarch = new System.Windows.Forms.ListBox();
            this.TdApril = new System.Windows.Forms.TabPage();
            this.LboxApril = new System.Windows.Forms.ListBox();
            this.TdMay = new System.Windows.Forms.TabPage();
            this.LboxMay = new System.Windows.Forms.ListBox();
            this.TdJune = new System.Windows.Forms.TabPage();
            this.LboxJune = new System.Windows.Forms.ListBox();
            this.TdJuly = new System.Windows.Forms.TabPage();
            this.LboxJuly = new System.Windows.Forms.ListBox();
            this.TdAugust = new System.Windows.Forms.TabPage();
            this.LboxAugust = new System.Windows.Forms.ListBox();
            this.TdSeptemder = new System.Windows.Forms.TabPage();
            this.LboxSeptember = new System.Windows.Forms.ListBox();
            this.TdOctober = new System.Windows.Forms.TabPage();
            this.LboxOctober = new System.Windows.Forms.ListBox();
            this.TdNovember = new System.Windows.Forms.TabPage();
            this.LboxNovember = new System.Windows.Forms.ListBox();
            this.TdDecember = new System.Windows.Forms.TabPage();
            this.LboxDecember = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.MenuStrip.SuspendLayout();
            this.TabCont.SuspendLayout();
            this.TdJanuary.SuspendLayout();
            this.TdFebruary.SuspendLayout();
            this.TdMarch.SuspendLayout();
            this.TdApril.SuspendLayout();
            this.TdMay.SuspendLayout();
            this.TdJune.SuspendLayout();
            this.TdJuly.SuspendLayout();
            this.TdAugust.SuspendLayout();
            this.TdSeptemder.SuspendLayout();
            this.TdOctober.SuspendLayout();
            this.TdNovember.SuspendLayout();
            this.TdDecember.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemDraft});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(763, 28);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemLoading,
            this.MenuItemSave,
            this.MenuItemClose});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(59, 24);
            this.MenuItemFile.Text = "Файл";
            // 
            // MenuItemLoading
            // 
            this.MenuItemLoading.Name = "MenuItemLoading";
            this.MenuItemLoading.Size = new System.Drawing.Size(224, 26);
            this.MenuItemLoading.Text = "Загрузить";
            this.MenuItemLoading.Click += new System.EventHandler(this.MenuItemLoading_Click);
            // 
            // MenuItemSave
            // 
            this.MenuItemSave.Name = "MenuItemSave";
            this.MenuItemSave.Size = new System.Drawing.Size(224, 26);
            this.MenuItemSave.Text = "Сохранить";
            this.MenuItemSave.Click += new System.EventHandler(this.MenuItemSave_Click);
            // 
            // MenuItemClose
            // 
            this.MenuItemClose.Name = "MenuItemClose";
            this.MenuItemClose.Size = new System.Drawing.Size(224, 26);
            this.MenuItemClose.Text = "Выход";
            this.MenuItemClose.Click += new System.EventHandler(this.MenuItemClose_Click);
            // 
            // MenuItemDraft
            // 
            this.MenuItemDraft.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAdd,
            this.MenuItemChange,
            this.MenuItemDelete});
            this.MenuItemDraft.Name = "MenuItemDraft";
            this.MenuItemDraft.Size = new System.Drawing.Size(125, 24);
            this.MenuItemDraft.Text = "Редактировать";
            // 
            // MenuItemAdd
            // 
            this.MenuItemAdd.Name = "MenuItemAdd";
            this.MenuItemAdd.Size = new System.Drawing.Size(161, 26);
            this.MenuItemAdd.Text = "Добавить";
            this.MenuItemAdd.Click += new System.EventHandler(this.MenuItemAdd_Click);
            // 
            // MenuItemChange
            // 
            this.MenuItemChange.Name = "MenuItemChange";
            this.MenuItemChange.Size = new System.Drawing.Size(161, 26);
            this.MenuItemChange.Text = "Изменить";
            this.MenuItemChange.Click += new System.EventHandler(this.MenuItemChange_Click);
            // 
            // MenuItemDelete
            // 
            this.MenuItemDelete.Name = "MenuItemDelete";
            this.MenuItemDelete.Size = new System.Drawing.Size(161, 26);
            this.MenuItemDelete.Text = "Удалить";
            this.MenuItemDelete.Click += new System.EventHandler(this.MenuItemDelete_Click);
            // 
            // TbxInput
            // 
            this.TbxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbxInput.Location = new System.Drawing.Point(16, 340);
            this.TbxInput.Name = "TbxInput";
            this.TbxInput.Size = new System.Drawing.Size(727, 22);
            this.TbxInput.TabIndex = 1;
            // 
            // TabCont
            // 
            this.TabCont.Controls.Add(this.TdJanuary);
            this.TabCont.Controls.Add(this.TdFebruary);
            this.TabCont.Controls.Add(this.TdMarch);
            this.TabCont.Controls.Add(this.TdApril);
            this.TabCont.Controls.Add(this.TdMay);
            this.TabCont.Controls.Add(this.TdJune);
            this.TabCont.Controls.Add(this.TdJuly);
            this.TabCont.Controls.Add(this.TdAugust);
            this.TabCont.Controls.Add(this.TdSeptemder);
            this.TabCont.Controls.Add(this.TdOctober);
            this.TabCont.Controls.Add(this.TdNovember);
            this.TabCont.Controls.Add(this.TdDecember);
            this.TabCont.Location = new System.Drawing.Point(12, 40);
            this.TabCont.Name = "TabCont";
            this.TabCont.SelectedIndex = 0;
            this.TabCont.Size = new System.Drawing.Size(735, 281);
            this.TabCont.TabIndex = 2;
            // 
            // TdJanuary
            // 
            this.TdJanuary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TdJanuary.Controls.Add(this.LboxJanuary);
            this.TdJanuary.Location = new System.Drawing.Point(4, 25);
            this.TdJanuary.Name = "TdJanuary";
            this.TdJanuary.Padding = new System.Windows.Forms.Padding(3);
            this.TdJanuary.Size = new System.Drawing.Size(727, 252);
            this.TdJanuary.TabIndex = 0;
            this.TdJanuary.Text = "Январь";
            this.TdJanuary.UseVisualStyleBackColor = true;
            // 
            // LboxJanuary
            // 
            this.LboxJanuary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LboxJanuary.FormattingEnabled = true;
            this.LboxJanuary.ItemHeight = 16;
            this.LboxJanuary.Location = new System.Drawing.Point(5, 6);
            this.LboxJanuary.Name = "LboxJanuary";
            this.LboxJanuary.Size = new System.Drawing.Size(713, 226);
            this.LboxJanuary.TabIndex = 0;
            // 
            // TdFebruary
            // 
            this.TdFebruary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TdFebruary.Controls.Add(this.LboxFebruary);
            this.TdFebruary.Location = new System.Drawing.Point(4, 25);
            this.TdFebruary.Name = "TdFebruary";
            this.TdFebruary.Padding = new System.Windows.Forms.Padding(3);
            this.TdFebruary.Size = new System.Drawing.Size(727, 252);
            this.TdFebruary.TabIndex = 1;
            this.TdFebruary.Text = "Февраль";
            this.TdFebruary.UseVisualStyleBackColor = true;
            // 
            // LboxFebruary
            // 
            this.LboxFebruary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LboxFebruary.FormattingEnabled = true;
            this.LboxFebruary.ItemHeight = 16;
            this.LboxFebruary.Location = new System.Drawing.Point(6, 7);
            this.LboxFebruary.Name = "LboxFebruary";
            this.LboxFebruary.Size = new System.Drawing.Size(713, 226);
            this.LboxFebruary.TabIndex = 0;
            // 
            // TdMarch
            // 
            this.TdMarch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TdMarch.Controls.Add(this.LboxMarch);
            this.TdMarch.Location = new System.Drawing.Point(4, 25);
            this.TdMarch.Name = "TdMarch";
            this.TdMarch.Padding = new System.Windows.Forms.Padding(3);
            this.TdMarch.Size = new System.Drawing.Size(727, 252);
            this.TdMarch.TabIndex = 2;
            this.TdMarch.Text = "Март";
            this.TdMarch.UseVisualStyleBackColor = true;
            // 
            // LboxMarch
            // 
            this.LboxMarch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LboxMarch.FormattingEnabled = true;
            this.LboxMarch.ItemHeight = 16;
            this.LboxMarch.Location = new System.Drawing.Point(6, 7);
            this.LboxMarch.Name = "LboxMarch";
            this.LboxMarch.Size = new System.Drawing.Size(713, 226);
            this.LboxMarch.TabIndex = 0;
            // 
            // TdApril
            // 
            this.TdApril.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TdApril.Controls.Add(this.LboxApril);
            this.TdApril.Location = new System.Drawing.Point(4, 25);
            this.TdApril.Name = "TdApril";
            this.TdApril.Padding = new System.Windows.Forms.Padding(3);
            this.TdApril.Size = new System.Drawing.Size(727, 252);
            this.TdApril.TabIndex = 3;
            this.TdApril.Text = "Апрель";
            this.TdApril.UseVisualStyleBackColor = true;
            // 
            // LboxApril
            // 
            this.LboxApril.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LboxApril.FormattingEnabled = true;
            this.LboxApril.ItemHeight = 16;
            this.LboxApril.Location = new System.Drawing.Point(6, 6);
            this.LboxApril.Name = "LboxApril";
            this.LboxApril.Size = new System.Drawing.Size(713, 226);
            this.LboxApril.TabIndex = 1;
            // 
            // TdMay
            // 
            this.TdMay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TdMay.Controls.Add(this.LboxMay);
            this.TdMay.Location = new System.Drawing.Point(4, 25);
            this.TdMay.Name = "TdMay";
            this.TdMay.Padding = new System.Windows.Forms.Padding(3);
            this.TdMay.Size = new System.Drawing.Size(727, 252);
            this.TdMay.TabIndex = 4;
            this.TdMay.Text = "Май";
            this.TdMay.UseVisualStyleBackColor = true;
            // 
            // LboxMay
            // 
            this.LboxMay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LboxMay.FormattingEnabled = true;
            this.LboxMay.ItemHeight = 16;
            this.LboxMay.Location = new System.Drawing.Point(6, 6);
            this.LboxMay.Name = "LboxMay";
            this.LboxMay.Size = new System.Drawing.Size(713, 226);
            this.LboxMay.TabIndex = 1;
            // 
            // TdJune
            // 
            this.TdJune.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TdJune.Controls.Add(this.LboxJune);
            this.TdJune.Location = new System.Drawing.Point(4, 25);
            this.TdJune.Name = "TdJune";
            this.TdJune.Padding = new System.Windows.Forms.Padding(3);
            this.TdJune.Size = new System.Drawing.Size(727, 252);
            this.TdJune.TabIndex = 5;
            this.TdJune.Text = "Июнь";
            this.TdJune.UseVisualStyleBackColor = true;
            // 
            // LboxJune
            // 
            this.LboxJune.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LboxJune.FormattingEnabled = true;
            this.LboxJune.ItemHeight = 16;
            this.LboxJune.Location = new System.Drawing.Point(7, 6);
            this.LboxJune.Name = "LboxJune";
            this.LboxJune.Size = new System.Drawing.Size(712, 226);
            this.LboxJune.TabIndex = 1;
            // 
            // TdJuly
            // 
            this.TdJuly.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TdJuly.Controls.Add(this.LboxJuly);
            this.TdJuly.Location = new System.Drawing.Point(4, 25);
            this.TdJuly.Name = "TdJuly";
            this.TdJuly.Padding = new System.Windows.Forms.Padding(3);
            this.TdJuly.Size = new System.Drawing.Size(727, 252);
            this.TdJuly.TabIndex = 6;
            this.TdJuly.Text = "Июль";
            this.TdJuly.UseVisualStyleBackColor = true;
            // 
            // LboxJuly
            // 
            this.LboxJuly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LboxJuly.FormattingEnabled = true;
            this.LboxJuly.ItemHeight = 16;
            this.LboxJuly.Location = new System.Drawing.Point(6, 6);
            this.LboxJuly.Name = "LboxJuly";
            this.LboxJuly.Size = new System.Drawing.Size(713, 226);
            this.LboxJuly.TabIndex = 1;
            // 
            // TdAugust
            // 
            this.TdAugust.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TdAugust.Controls.Add(this.LboxAugust);
            this.TdAugust.Location = new System.Drawing.Point(4, 25);
            this.TdAugust.Name = "TdAugust";
            this.TdAugust.Padding = new System.Windows.Forms.Padding(3);
            this.TdAugust.Size = new System.Drawing.Size(727, 252);
            this.TdAugust.TabIndex = 7;
            this.TdAugust.Text = "Август";
            this.TdAugust.UseVisualStyleBackColor = true;
            // 
            // LboxAugust
            // 
            this.LboxAugust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LboxAugust.FormattingEnabled = true;
            this.LboxAugust.ItemHeight = 16;
            this.LboxAugust.Location = new System.Drawing.Point(7, 6);
            this.LboxAugust.Name = "LboxAugust";
            this.LboxAugust.Size = new System.Drawing.Size(712, 226);
            this.LboxAugust.TabIndex = 1;
            // 
            // TdSeptemder
            // 
            this.TdSeptemder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TdSeptemder.Controls.Add(this.LboxSeptember);
            this.TdSeptemder.Location = new System.Drawing.Point(4, 25);
            this.TdSeptemder.Name = "TdSeptemder";
            this.TdSeptemder.Padding = new System.Windows.Forms.Padding(3);
            this.TdSeptemder.Size = new System.Drawing.Size(727, 252);
            this.TdSeptemder.TabIndex = 8;
            this.TdSeptemder.Text = "Сентябрь";
            this.TdSeptemder.UseVisualStyleBackColor = true;
            // 
            // LboxSeptember
            // 
            this.LboxSeptember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LboxSeptember.FormattingEnabled = true;
            this.LboxSeptember.ItemHeight = 16;
            this.LboxSeptember.Location = new System.Drawing.Point(6, 6);
            this.LboxSeptember.Name = "LboxSeptember";
            this.LboxSeptember.Size = new System.Drawing.Size(713, 226);
            this.LboxSeptember.TabIndex = 1;
            // 
            // TdOctober
            // 
            this.TdOctober.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TdOctober.Controls.Add(this.LboxOctober);
            this.TdOctober.Location = new System.Drawing.Point(4, 25);
            this.TdOctober.Name = "TdOctober";
            this.TdOctober.Padding = new System.Windows.Forms.Padding(3);
            this.TdOctober.Size = new System.Drawing.Size(727, 252);
            this.TdOctober.TabIndex = 9;
            this.TdOctober.Text = "Октябрь";
            this.TdOctober.UseVisualStyleBackColor = true;
            // 
            // LboxOctober
            // 
            this.LboxOctober.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LboxOctober.FormattingEnabled = true;
            this.LboxOctober.ItemHeight = 16;
            this.LboxOctober.Location = new System.Drawing.Point(6, 6);
            this.LboxOctober.Name = "LboxOctober";
            this.LboxOctober.Size = new System.Drawing.Size(713, 226);
            this.LboxOctober.TabIndex = 1;
            // 
            // TdNovember
            // 
            this.TdNovember.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TdNovember.Controls.Add(this.LboxNovember);
            this.TdNovember.Location = new System.Drawing.Point(4, 25);
            this.TdNovember.Name = "TdNovember";
            this.TdNovember.Padding = new System.Windows.Forms.Padding(3);
            this.TdNovember.Size = new System.Drawing.Size(727, 252);
            this.TdNovember.TabIndex = 10;
            this.TdNovember.Text = "Ноябрь";
            this.TdNovember.UseVisualStyleBackColor = true;
            // 
            // LboxNovember
            // 
            this.LboxNovember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LboxNovember.FormattingEnabled = true;
            this.LboxNovember.ItemHeight = 16;
            this.LboxNovember.Location = new System.Drawing.Point(6, 6);
            this.LboxNovember.Name = "LboxNovember";
            this.LboxNovember.Size = new System.Drawing.Size(713, 226);
            this.LboxNovember.TabIndex = 1;
            // 
            // TdDecember
            // 
            this.TdDecember.AutoScroll = true;
            this.TdDecember.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TdDecember.Controls.Add(this.LboxDecember);
            this.TdDecember.Location = new System.Drawing.Point(4, 25);
            this.TdDecember.Name = "TdDecember";
            this.TdDecember.Padding = new System.Windows.Forms.Padding(3);
            this.TdDecember.Size = new System.Drawing.Size(727, 252);
            this.TdDecember.TabIndex = 11;
            this.TdDecember.Text = "Декабрь";
            this.TdDecember.UseVisualStyleBackColor = true;
            // 
            // LboxDecember
            // 
            this.LboxDecember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LboxDecember.FormattingEnabled = true;
            this.LboxDecember.ItemHeight = 16;
            this.LboxDecember.Location = new System.Drawing.Point(6, 6);
            this.LboxDecember.Name = "LboxDecember";
            this.LboxDecember.Size = new System.Drawing.Size(713, 226);
            this.LboxDecember.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 388);
            this.Controls.Add(this.TabCont);
            this.Controls.Add(this.TbxInput);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Form1";
            this.Text = "WF_28_Блокнот";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.TabCont.ResumeLayout(false);
            this.TdJanuary.ResumeLayout(false);
            this.TdFebruary.ResumeLayout(false);
            this.TdMarch.ResumeLayout(false);
            this.TdApril.ResumeLayout(false);
            this.TdMay.ResumeLayout(false);
            this.TdJune.ResumeLayout(false);
            this.TdJuly.ResumeLayout(false);
            this.TdAugust.ResumeLayout(false);
            this.TdSeptemder.ResumeLayout(false);
            this.TdOctober.ResumeLayout(false);
            this.TdNovember.ResumeLayout(false);
            this.TdDecember.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLoading;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemClose;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDraft;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChange;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDelete;
        private System.Windows.Forms.TextBox TbxInput;
        private System.Windows.Forms.TabControl TabCont;
        private System.Windows.Forms.TabPage TdJanuary;
        private System.Windows.Forms.TabPage TdFebruary;
        private System.Windows.Forms.TabPage TdMarch;
        private System.Windows.Forms.TabPage TdApril;
        private System.Windows.Forms.TabPage TdMay;
        private System.Windows.Forms.TabPage TdJune;
        private System.Windows.Forms.TabPage TdJuly;
        private System.Windows.Forms.TabPage TdAugust;
        private System.Windows.Forms.TabPage TdSeptemder;
        private System.Windows.Forms.TabPage TdOctober;
        private System.Windows.Forms.TabPage TdNovember;
        private System.Windows.Forms.TabPage TdDecember;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox LboxJanuary;
        private System.Windows.Forms.ListBox LboxFebruary;
        private System.Windows.Forms.ListBox LboxMarch;
        private System.Windows.Forms.ListBox LboxApril;
        private System.Windows.Forms.ListBox LboxMay;
        private System.Windows.Forms.ListBox LboxJune;
        private System.Windows.Forms.ListBox LboxJuly;
        private System.Windows.Forms.ListBox LboxAugust;
        private System.Windows.Forms.ListBox LboxSeptember;
        private System.Windows.Forms.ListBox LboxOctober;
        private System.Windows.Forms.ListBox LboxNovember;
        private System.Windows.Forms.ListBox LboxDecember;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

