namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuHeader = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новоеОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыСтраницыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискСПомощьюBingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиДалееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиРанееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перейтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.времяИДатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переносПоСловамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.масштабToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уменьшитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.восстановитьМасштабПоУмолчаниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.строкаСостоянияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьСправкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отправитьОтзывToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.currentSelectedStart = new System.Windows.Forms.Label();
            this.currentScale = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuHeader
            // 
            this.menuHeader.BackColor = System.Drawing.SystemColors.Window;
            this.menuHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.форматToolStripMenuItem,
            this.видToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuHeader.Location = new System.Drawing.Point(0, 0);
            this.menuHeader.Name = "menuHeader";
            this.menuHeader.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuHeader.Size = new System.Drawing.Size(1053, 25);
            this.menuHeader.TabIndex = 0;
            this.menuHeader.Text = "menuStrip1";
            this.menuHeader.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuHeader_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.новоеОкноToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.параметрыСтраницыToolStripMenuItem,
            this.печатьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // новоеОкноToolStripMenuItem
            // 
            this.новоеОкноToolStripMenuItem.Name = "новоеОкноToolStripMenuItem";
            this.новоеОкноToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.новоеОкноToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.новоеОкноToolStripMenuItem.Text = "Новое окно";
            this.новоеОкноToolStripMenuItem.Click += new System.EventHandler(this.новоеОкноToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // параметрыСтраницыToolStripMenuItem
            // 
            this.параметрыСтраницыToolStripMenuItem.Name = "параметрыСтраницыToolStripMenuItem";
            this.параметрыСтраницыToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.параметрыСтраницыToolStripMenuItem.Text = "Параметры страницы";
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьToolStripMenuItem,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.поискСПомощьюBingToolStripMenuItem,
            this.найтиToolStripMenuItem,
            this.найтиДалееToolStripMenuItem,
            this.найтиРанееToolStripMenuItem,
            this.заменитьToolStripMenuItem,
            this.перейтиToolStripMenuItem,
            this.выделитьВсеToolStripMenuItem,
            this.времяИДатаToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 19);
            this.правкаToolStripMenuItem.Text = "Правка";
            this.правкаToolStripMenuItem.Click += new System.EventHandler(this.правкаToolStripMenuItem_Click);
            // 
            // отменитьToolStripMenuItem
            // 
            this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            this.отменитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.отменитьToolStripMenuItem.Text = "Отменить";
            this.отменитьToolStripMenuItem.Click += new System.EventHandler(this.отменитьToolStripMenuItem_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.вставитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // поискСПомощьюBingToolStripMenuItem
            // 
            this.поискСПомощьюBingToolStripMenuItem.Name = "поискСПомощьюBingToolStripMenuItem";
            this.поискСПомощьюBingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.поискСПомощьюBingToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.поискСПомощьюBingToolStripMenuItem.Text = "Поиск с помощью Bing...";
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.найтиToolStripMenuItem.Text = "Найти";
            this.найтиToolStripMenuItem.Click += new System.EventHandler(this.найтиToolStripMenuItem_Click);
            // 
            // найтиДалееToolStripMenuItem
            // 
            this.найтиДалееToolStripMenuItem.Name = "найтиДалееToolStripMenuItem";
            this.найтиДалееToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.найтиДалееToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.найтиДалееToolStripMenuItem.Text = "Найти далее";
            this.найтиДалееToolStripMenuItem.Click += new System.EventHandler(this.найтиДалееToolStripMenuItem_Click);
            // 
            // найтиРанееToolStripMenuItem
            // 
            this.найтиРанееToolStripMenuItem.Name = "найтиРанееToolStripMenuItem";
            this.найтиРанееToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.найтиРанееToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.найтиРанееToolStripMenuItem.Text = "Найти ранее";
            this.найтиРанееToolStripMenuItem.Click += new System.EventHandler(this.найтиРанееToolStripMenuItem_Click);
            // 
            // заменитьToolStripMenuItem
            // 
            this.заменитьToolStripMenuItem.Name = "заменитьToolStripMenuItem";
            this.заменитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.заменитьToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.заменитьToolStripMenuItem.Text = "Заменить";
            this.заменитьToolStripMenuItem.Click += new System.EventHandler(this.заменитьToolStripMenuItem_Click);
            // 
            // перейтиToolStripMenuItem
            // 
            this.перейтиToolStripMenuItem.Name = "перейтиToolStripMenuItem";
            this.перейтиToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.перейтиToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.перейтиToolStripMenuItem.Text = "Перейти";
            this.перейтиToolStripMenuItem.Click += new System.EventHandler(this.перейтиToolStripMenuItem_Click);
            // 
            // выделитьВсеToolStripMenuItem
            // 
            this.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            this.выделитьВсеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.выделитьВсеToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.выделитьВсеToolStripMenuItem.Text = "Выделить все";
            this.выделитьВсеToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem_Click);
            // 
            // времяИДатаToolStripMenuItem
            // 
            this.времяИДатаToolStripMenuItem.Name = "времяИДатаToolStripMenuItem";
            this.времяИДатаToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.времяИДатаToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.времяИДатаToolStripMenuItem.Text = "Время и дата";
            this.времяИДатаToolStripMenuItem.Click += new System.EventHandler(this.времяИДатаToolStripMenuItem_Click);
            // 
            // форматToolStripMenuItem
            // 
            this.форматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переносПоСловамToolStripMenuItem,
            this.шрифтToolStripMenuItem});
            this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            this.форматToolStripMenuItem.Size = new System.Drawing.Size(62, 19);
            this.форматToolStripMenuItem.Text = "Формат";
            // 
            // переносПоСловамToolStripMenuItem
            // 
            this.переносПоСловамToolStripMenuItem.Name = "переносПоСловамToolStripMenuItem";
            this.переносПоСловамToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.переносПоСловамToolStripMenuItem.Text = "Перенос по словам";
            this.переносПоСловамToolStripMenuItem.Click += new System.EventHandler(this.переносПоСловамToolStripMenuItem_Click);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.масштабToolStripMenuItem,
            this.строкаСостоянияToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // масштабToolStripMenuItem
            // 
            this.масштабToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.увеличитьToolStripMenuItem,
            this.уменьшитьToolStripMenuItem,
            this.восстановитьМасштабПоУмолчаниюToolStripMenuItem});
            this.масштабToolStripMenuItem.Name = "масштабToolStripMenuItem";
            this.масштабToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.масштабToolStripMenuItem.Text = "Масштаб";
            // 
            // увеличитьToolStripMenuItem
            // 
            this.увеличитьToolStripMenuItem.Name = "увеличитьToolStripMenuItem";
            this.увеличитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.увеличитьToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.увеличитьToolStripMenuItem.Text = "Увеличить";
            this.увеличитьToolStripMenuItem.Click += new System.EventHandler(this.увеличитьToolStripMenuItem_Click);
            // 
            // уменьшитьToolStripMenuItem
            // 
            this.уменьшитьToolStripMenuItem.Name = "уменьшитьToolStripMenuItem";
            this.уменьшитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.уменьшитьToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.уменьшитьToolStripMenuItem.Text = "Уменьшить";
            this.уменьшитьToolStripMenuItem.Click += new System.EventHandler(this.уменьшитьToolStripMenuItem_Click);
            // 
            // восстановитьМасштабПоУмолчаниюToolStripMenuItem
            // 
            this.восстановитьМасштабПоУмолчаниюToolStripMenuItem.Name = "восстановитьМасштабПоУмолчаниюToolStripMenuItem";
            this.восстановитьМасштабПоУмолчаниюToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.восстановитьМасштабПоУмолчаниюToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.восстановитьМасштабПоУмолчаниюToolStripMenuItem.Text = "Восстановить масштаб по умолчанию";
            this.восстановитьМасштабПоУмолчаниюToolStripMenuItem.Click += new System.EventHandler(this.восстановитьМасштабПоУмолчаниюToolStripMenuItem_Click);
            // 
            // строкаСостоянияToolStripMenuItem
            // 
            this.строкаСостоянияToolStripMenuItem.Name = "строкаСостоянияToolStripMenuItem";
            this.строкаСостоянияToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.строкаСостоянияToolStripMenuItem.Text = "Строка состояния";
            this.строкаСостоянияToolStripMenuItem.Click += new System.EventHandler(this.строкаСостоянияToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотретьСправкуToolStripMenuItem,
            this.отправитьОтзывToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // просмотретьСправкуToolStripMenuItem
            // 
            this.просмотретьСправкуToolStripMenuItem.Name = "просмотретьСправкуToolStripMenuItem";
            this.просмотретьСправкуToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.просмотретьСправкуToolStripMenuItem.Text = "Просмотреть справку";
            this.просмотретьСправкуToolStripMenuItem.Click += new System.EventHandler(this.просмотретьСправкуToolStripMenuItem_Click);
            // 
            // отправитьОтзывToolStripMenuItem
            // 
            this.отправитьОтзывToolStripMenuItem.Name = "отправитьОтзывToolStripMenuItem";
            this.отправитьОтзывToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.отправитьОтзывToolStripMenuItem.Text = "Отправить отзыв";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(0, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(1053, 473);
            this.textBox1.TabIndex = 1;
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Resize += new System.EventHandler(this.textBox1_Resize);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt|*.txt";
            this.openFileDialog1.Title = "Открытие";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "txt|*txt";
            this.saveFileDialog1.Title = "Сохранение";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.2423F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.7577F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel1.Controls.Add(this.currentSelectedStart, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.currentScale, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 468);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(0, 30);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1053, 30);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Visible = false;
            // 
            // currentSelectedStart
            // 
            this.currentSelectedStart.BackColor = System.Drawing.SystemColors.Window;
            this.currentSelectedStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentSelectedStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.currentSelectedStart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentSelectedStart.Location = new System.Drawing.Point(478, 4);
            this.currentSelectedStart.Margin = new System.Windows.Forms.Padding(0);
            this.currentSelectedStart.Name = "currentSelectedStart";
            this.currentSelectedStart.Size = new System.Drawing.Size(139, 22);
            this.currentSelectedStart.TabIndex = 0;
            this.currentSelectedStart.Text = "Стр 1, слб 0";
            this.currentSelectedStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentScale
            // 
            this.currentScale.BackColor = System.Drawing.SystemColors.Window;
            this.currentScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentScale.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentScale.Location = new System.Drawing.Point(617, 4);
            this.currentScale.Margin = new System.Windows.Forms.Padding(0);
            this.currentScale.Name = "currentScale";
            this.currentScale.Size = new System.Drawing.Size(70, 22);
            this.currentScale.TabIndex = 1;
            this.currentScale.Text = "100%";
            this.currentScale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(687, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Windows (CRLF)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(873, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "UTF-8";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1053, 498);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuHeader;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Безымянный - Блокнот";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuHeader.ResumeLayout(false);
            this.menuHeader.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuHeader;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem новоеОкноToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private ToolStripMenuItem параметрыСтраницыToolStripMenuItem;
        private ToolStripMenuItem печатьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem отменитьToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem поискСПомощьюBingToolStripMenuItem;
        private ToolStripMenuItem найтиToolStripMenuItem;
        private ToolStripMenuItem найтиДалееToolStripMenuItem;
        private ToolStripMenuItem найтиРанееToolStripMenuItem;
        private ToolStripMenuItem заменитьToolStripMenuItem;
        private ToolStripMenuItem перейтиToolStripMenuItem;
        private ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private ToolStripMenuItem времяИДатаToolStripMenuItem;
        private ToolStripMenuItem форматToolStripMenuItem;
        private ToolStripMenuItem переносПоСловамToolStripMenuItem;
        private ToolStripMenuItem шрифтToolStripMenuItem;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem масштабToolStripMenuItem;
        private ToolStripMenuItem увеличитьToolStripMenuItem;
        private ToolStripMenuItem уменьшитьToolStripMenuItem;
        private ToolStripMenuItem восстановитьМасштабПоУмолчаниюToolStripMenuItem;
        private ToolStripMenuItem строкаСостоянияToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem просмотретьСправкуToolStripMenuItem;
        private ToolStripMenuItem отправитьОтзывToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        public TextBox textBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label currentSelectedStart;
        private Label currentScale;
        private Label label2;
        private Label label3;
    }
}