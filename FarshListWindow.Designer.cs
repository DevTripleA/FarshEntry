namespace FarshEntry
{
    partial class FarshListWindow
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
            dataGridView1 = new DataGridView();
            WayIdColumn = new DataGridViewTextBoxColumn();
            PositionWordColumn = new DataGridViewTextBoxColumn();
            DifferenceColumn = new DataGridViewTextBoxColumn();
            ReadersNamesColumn = new DataGridViewTextBoxColumn();
            ChapterNameColumn = new DataGridViewTextBoxColumn();
            VerseColumn = new DataGridViewTextBoxColumn();
            PageColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { WayIdColumn, PositionWordColumn, DifferenceColumn, ReadersNamesColumn, ChapterNameColumn, VerseColumn, PageColumn });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 426);
            dataGridView1.TabIndex = 0;
            // 
            // WayIdColumn
            // 
            WayIdColumn.HeaderText = "";
            WayIdColumn.Name = "WayIdColumn";
            WayIdColumn.ReadOnly = true;
            // 
            // PositionWordColumn
            // 
            PositionWordColumn.HeaderText = "الكلمة في حفص";
            PositionWordColumn.Name = "PositionWordColumn";
            PositionWordColumn.ReadOnly = true;
            // 
            // DifferenceColumn
            // 
            DifferenceColumn.HeaderText = "الفرش";
            DifferenceColumn.Name = "DifferenceColumn";
            DifferenceColumn.ReadOnly = true;
            // 
            // ReadersNamesColumn
            // 
            ReadersNamesColumn.HeaderText = "من قرأ بها";
            ReadersNamesColumn.Name = "ReadersNamesColumn";
            ReadersNamesColumn.ReadOnly = true;
            // 
            // ChapterNameColumn
            // 
            ChapterNameColumn.HeaderText = "السورة";
            ChapterNameColumn.Name = "ChapterNameColumn";
            ChapterNameColumn.ReadOnly = true;
            // 
            // VerseColumn
            // 
            VerseColumn.HeaderText = "الآية";
            VerseColumn.Name = "VerseColumn";
            // 
            // PageColumn
            // 
            PageColumn.HeaderText = "الصفحة";
            PageColumn.Name = "PageColumn";
            // 
            // FarshListWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "FarshListWindow";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الفرش";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn WayIdColumn;
        private DataGridViewTextBoxColumn PositionWordColumn;
        private DataGridViewTextBoxColumn DifferenceColumn;
        private DataGridViewTextBoxColumn ReadersNamesColumn;
        private DataGridViewTextBoxColumn ChapterNameColumn;
        private DataGridViewTextBoxColumn VerseColumn;
        private DataGridViewTextBoxColumn PageColumn;
    }
}