
namespace sorting1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleSheetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxBubbleSort = new System.Windows.Forms.CheckBox();
            this.checkBoxInsertionSort = new System.Windows.Forms.CheckBox();
            this.checkBoxShakerSort = new System.Windows.Forms.CheckBox();
            this.checkBoxQuickSort = new System.Windows.Forms.CheckBox();
            this.checkBoxBogoSort = new System.Windows.Forms.CheckBox();
            this.checkBoxAscending = new System.Windows.Forms.CheckBox();
            this.checkBoxDescending = new System.Windows.Forms.CheckBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bubbleSortLabel = new System.Windows.Forms.Label();
            this.insertionSortLabel = new System.Windows.Forms.Label();
            this.shakerSortLabel = new System.Windows.Forms.Label();
            this.quickSortLabel = new System.Windows.Forms.Label();
            this.bogoSortLabel = new System.Windows.Forms.Label();
            this.bubbleSortGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.insertionSortGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.shakerSortGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.quickSortGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bogoSortGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.delayLabel = new System.Windows.Forms.Label();
            this.delayTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleSortGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertionSortGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shakerSortGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickSortGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bogoSortGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1385, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleSheetsToolStripMenuItem,
            this.excelToolStripMenuItem,
            this.randomToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.importToolStripMenuItem.Text = "Импорт";
            // 
            // googleSheetsToolStripMenuItem
            // 
            this.googleSheetsToolStripMenuItem.Name = "googleSheetsToolStripMenuItem";
            this.googleSheetsToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.googleSheetsToolStripMenuItem.Text = "Google Sheets";
            this.googleSheetsToolStripMenuItem.Click += new System.EventHandler(this.googleSheetsToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.randomToolStripMenuItem.Text = "Рандом";
            this.randomToolStripMenuItem.Click += new System.EventHandler(this.randomToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.startToolStripMenuItem.Text = "Старт";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.stopToolStripMenuItem.Text = "Стоп";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.clearToolStripMenuItem.Text = "Очистить";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // checkBoxBubbleSort
            // 
            this.checkBoxBubbleSort.AutoSize = true;
            this.checkBoxBubbleSort.Location = new System.Drawing.Point(171, 32);
            this.checkBoxBubbleSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxBubbleSort.Name = "checkBoxBubbleSort";
            this.checkBoxBubbleSort.Size = new System.Drawing.Size(197, 21);
            this.checkBoxBubbleSort.TabIndex = 4;
            this.checkBoxBubbleSort.Text = "Пузырьковая сортировка";
            this.checkBoxBubbleSort.UseVisualStyleBackColor = true;
            // 
            // checkBoxInsertionSort
            // 
            this.checkBoxInsertionSort.AutoSize = true;
            this.checkBoxInsertionSort.Location = new System.Drawing.Point(171, 53);
            this.checkBoxInsertionSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxInsertionSort.Name = "checkBoxInsertionSort";
            this.checkBoxInsertionSort.Size = new System.Drawing.Size(180, 21);
            this.checkBoxInsertionSort.TabIndex = 5;
            this.checkBoxInsertionSort.Text = "Сортировка вставками";
            this.checkBoxInsertionSort.UseVisualStyleBackColor = true;
            // 
            // checkBoxShakerSort
            // 
            this.checkBoxShakerSort.AutoSize = true;
            this.checkBoxShakerSort.Location = new System.Drawing.Point(171, 74);
            this.checkBoxShakerSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxShakerSort.Name = "checkBoxShakerSort";
            this.checkBoxShakerSort.Size = new System.Drawing.Size(184, 21);
            this.checkBoxShakerSort.TabIndex = 6;
            this.checkBoxShakerSort.Text = "Шейкерная сортировка";
            this.checkBoxShakerSort.UseVisualStyleBackColor = true;
            // 
            // checkBoxQuickSort
            // 
            this.checkBoxQuickSort.AutoSize = true;
            this.checkBoxQuickSort.Location = new System.Drawing.Point(171, 95);
            this.checkBoxQuickSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxQuickSort.Name = "checkBoxQuickSort";
            this.checkBoxQuickSort.Size = new System.Drawing.Size(167, 21);
            this.checkBoxQuickSort.TabIndex = 7;
            this.checkBoxQuickSort.Text = "Быстрая сортировка";
            this.checkBoxQuickSort.UseVisualStyleBackColor = true;
            // 
            // checkBoxBogoSort
            // 
            this.checkBoxBogoSort.AutoSize = true;
            this.checkBoxBogoSort.Location = new System.Drawing.Point(171, 116);
            this.checkBoxBogoSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxBogoSort.Name = "checkBoxBogoSort";
            this.checkBoxBogoSort.Size = new System.Drawing.Size(87, 21);
            this.checkBoxBogoSort.TabIndex = 8;
            this.checkBoxBogoSort.Text = "Bogosort";
            this.checkBoxBogoSort.UseVisualStyleBackColor = true;
            // 
            // checkBoxAscending
            // 
            this.checkBoxAscending.AutoSize = true;
            this.checkBoxAscending.Location = new System.Drawing.Point(171, 155);
            this.checkBoxAscending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxAscending.Name = "checkBoxAscending";
            this.checkBoxAscending.Size = new System.Drawing.Size(138, 21);
            this.checkBoxAscending.TabIndex = 9;
            this.checkBoxAscending.Text = "По возрастанию";
            this.checkBoxAscending.UseVisualStyleBackColor = true;
            // 
            // checkBoxDescending
            // 
            this.checkBoxDescending.AutoSize = true;
            this.checkBoxDescending.Location = new System.Drawing.Point(171, 176);
            this.checkBoxDescending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxDescending.Name = "checkBoxDescending";
            this.checkBoxDescending.Size = new System.Drawing.Size(118, 21);
            this.checkBoxDescending.TabIndex = 10;
            this.checkBoxDescending.Text = "По убыванию";
            this.checkBoxDescending.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.value});
            this.dataGridView.Location = new System.Drawing.Point(12, 33);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(138, 571);
            this.dataGridView.TabIndex = 16;
            // 
            // value
            // 
            this.value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.value.HeaderText = "#";
            this.value.MinimumWidth = 6;
            this.value.Name = "value";
            this.value.Width = 45;
            // 
            // bubbleSortLabel
            // 
            this.bubbleSortLabel.AutoSize = true;
            this.bubbleSortLabel.Location = new System.Drawing.Point(400, 32);
            this.bubbleSortLabel.Name = "bubbleSortLabel";
            this.bubbleSortLabel.Size = new System.Drawing.Size(0, 17);
            this.bubbleSortLabel.TabIndex = 17;
            // 
            // insertionSortLabel
            // 
            this.insertionSortLabel.AutoSize = true;
            this.insertionSortLabel.Location = new System.Drawing.Point(400, 53);
            this.insertionSortLabel.Name = "insertionSortLabel";
            this.insertionSortLabel.Size = new System.Drawing.Size(0, 17);
            this.insertionSortLabel.TabIndex = 18;
            // 
            // shakerSortLabel
            // 
            this.shakerSortLabel.AutoSize = true;
            this.shakerSortLabel.Location = new System.Drawing.Point(400, 74);
            this.shakerSortLabel.Name = "shakerSortLabel";
            this.shakerSortLabel.Size = new System.Drawing.Size(0, 17);
            this.shakerSortLabel.TabIndex = 19;
            // 
            // quickSortLabel
            // 
            this.quickSortLabel.AutoSize = true;
            this.quickSortLabel.Location = new System.Drawing.Point(400, 95);
            this.quickSortLabel.Name = "quickSortLabel";
            this.quickSortLabel.Size = new System.Drawing.Size(0, 17);
            this.quickSortLabel.TabIndex = 20;
            // 
            // bogoSortLabel
            // 
            this.bogoSortLabel.AutoSize = true;
            this.bogoSortLabel.Location = new System.Drawing.Point(400, 116);
            this.bogoSortLabel.Name = "bogoSortLabel";
            this.bogoSortLabel.Size = new System.Drawing.Size(0, 17);
            this.bogoSortLabel.TabIndex = 21;
            // 
            // bubbleSortGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.bubbleSortGraph.ChartAreas.Add(chartArea1);
            this.bubbleSortGraph.Location = new System.Drawing.Point(575, 40);
            this.bubbleSortGraph.Name = "bubbleSortGraph";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.bubbleSortGraph.Series.Add(series1);
            this.bubbleSortGraph.Size = new System.Drawing.Size(395, 279);
            this.bubbleSortGraph.TabIndex = 22;
            this.bubbleSortGraph.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Пузырьковая сортировка";
            this.bubbleSortGraph.Titles.Add(title1);
            // 
            // insertionSortGraph
            // 
            chartArea2.Name = "ChartArea2";
            this.insertionSortGraph.ChartAreas.Add(chartArea2);
            this.insertionSortGraph.Location = new System.Drawing.Point(976, 40);
            this.insertionSortGraph.Name = "insertionSortGraph";
            series2.ChartArea = "ChartArea2";
            series2.Name = "Series2";
            this.insertionSortGraph.Series.Add(series2);
            this.insertionSortGraph.Size = new System.Drawing.Size(395, 279);
            this.insertionSortGraph.TabIndex = 23;
            this.insertionSortGraph.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Сортировка вставками";
            this.insertionSortGraph.Titles.Add(title2);
            // 
            // shakerSortGraph
            // 
            chartArea3.Name = "ChartArea1";
            this.shakerSortGraph.ChartAreas.Add(chartArea3);
            this.shakerSortGraph.Location = new System.Drawing.Point(171, 325);
            this.shakerSortGraph.Name = "shakerSortGraph";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            this.shakerSortGraph.Series.Add(series3);
            this.shakerSortGraph.Size = new System.Drawing.Size(395, 279);
            this.shakerSortGraph.TabIndex = 24;
            this.shakerSortGraph.Text = "chart3";
            title3.Name = "Title1";
            title3.Text = "Шейкерная сортировка";
            this.shakerSortGraph.Titles.Add(title3);
            // 
            // quickSortGraph
            // 
            chartArea4.Name = "ChartArea1";
            this.quickSortGraph.ChartAreas.Add(chartArea4);
            this.quickSortGraph.Location = new System.Drawing.Point(575, 325);
            this.quickSortGraph.Name = "quickSortGraph";
            series4.ChartArea = "ChartArea1";
            series4.Name = "Series1";
            this.quickSortGraph.Series.Add(series4);
            this.quickSortGraph.Size = new System.Drawing.Size(395, 279);
            this.quickSortGraph.TabIndex = 25;
            this.quickSortGraph.Text = "chart4";
            title4.Name = "Title1";
            title4.Text = "Быстрая сортировка";
            this.quickSortGraph.Titles.Add(title4);
            // 
            // bogoSortGraph
            // 
            chartArea5.Name = "ChartArea1";
            this.bogoSortGraph.ChartAreas.Add(chartArea5);
            this.bogoSortGraph.Location = new System.Drawing.Point(976, 325);
            this.bogoSortGraph.Name = "bogoSortGraph";
            series5.ChartArea = "ChartArea1";
            series5.Name = "Series1";
            this.bogoSortGraph.Series.Add(series5);
            this.bogoSortGraph.Size = new System.Drawing.Size(395, 279);
            this.bogoSortGraph.TabIndex = 26;
            this.bogoSortGraph.Text = "chart5";
            title5.Name = "Title1";
            title5.Text = "Bogosort";
            this.bogoSortGraph.Titles.Add(title5);
            // 
            // delayLabel
            // 
            this.delayLabel.AutoSize = true;
            this.delayLabel.Location = new System.Drawing.Point(168, 221);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(73, 17);
            this.delayLabel.TabIndex = 28;
            this.delayLabel.Text = "Задержка";
            // 
            // delayTextBox
            // 
            this.delayTextBox.Location = new System.Drawing.Point(171, 241);
            this.delayTextBox.Name = "delayTextBox";
            this.delayTextBox.Size = new System.Drawing.Size(100, 22);
            this.delayTextBox.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 616);
            this.Controls.Add(this.delayTextBox);
            this.Controls.Add(this.delayLabel);
            this.Controls.Add(this.bogoSortGraph);
            this.Controls.Add(this.quickSortGraph);
            this.Controls.Add(this.shakerSortGraph);
            this.Controls.Add(this.insertionSortGraph);
            this.Controls.Add(this.bubbleSortGraph);
            this.Controls.Add(this.bogoSortLabel);
            this.Controls.Add(this.quickSortLabel);
            this.Controls.Add(this.shakerSortLabel);
            this.Controls.Add(this.insertionSortLabel);
            this.Controls.Add(this.bubbleSortLabel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.checkBoxDescending);
            this.Controls.Add(this.checkBoxAscending);
            this.Controls.Add(this.checkBoxBogoSort);
            this.Controls.Add(this.checkBoxQuickSort);
            this.Controls.Add(this.checkBoxShakerSort);
            this.Controls.Add(this.checkBoxInsertionSort);
            this.Controls.Add(this.checkBoxBubbleSort);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Сортировки";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bubbleSortGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insertionSortGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shakerSortGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quickSortGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bogoSortGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleSheetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxBubbleSort;
        private System.Windows.Forms.CheckBox checkBoxInsertionSort;
        private System.Windows.Forms.CheckBox checkBoxShakerSort;
        private System.Windows.Forms.CheckBox checkBoxQuickSort;
        private System.Windows.Forms.CheckBox checkBoxBogoSort;
        private System.Windows.Forms.CheckBox checkBoxAscending;
        private System.Windows.Forms.CheckBox checkBoxDescending;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label bubbleSortLabel;
        private System.Windows.Forms.Label insertionSortLabel;
        private System.Windows.Forms.Label shakerSortLabel;
        private System.Windows.Forms.Label quickSortLabel;
        private System.Windows.Forms.Label bogoSortLabel;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart bubbleSortGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart insertionSortGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart shakerSortGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart quickSortGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart bogoSortGraph;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.Label delayLabel;
        private System.Windows.Forms.TextBox delayTextBox;
    }
}

