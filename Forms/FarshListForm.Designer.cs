namespace FarshEntry
{
    partial class FarshListForm
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
            FarshGridView = new DataGridView();
            DifferenceId = new DataGridViewTextBoxColumn();
            PositionWord = new DataGridViewTextBoxColumn();
            Difference = new DataGridViewTextBoxColumn();
            ReadersNames = new DataGridViewTextBoxColumn();
            ChapterName = new DataGridViewTextBoxColumn();
            Verse = new DataGridViewTextBoxColumn();
            Page = new DataGridViewTextBoxColumn();
            AddButton = new Button();
            ((System.ComponentModel.ISupportInitialize)FarshGridView).BeginInit();
            SuspendLayout();
            // 
            // FarshGridView
            // 
            FarshGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FarshGridView.Columns.AddRange(new DataGridViewColumn[] { DifferenceId, PositionWord, Difference, ReadersNames, ChapterName, Verse, Page });
            FarshGridView.Location = new Point(12, 12);
            FarshGridView.Name = "FarshGridView";
            FarshGridView.RowTemplate.Height = 25;
            FarshGridView.Size = new Size(1461, 569);
            FarshGridView.TabIndex = 0;
            // 
            // DifferenceId
            // 
            DifferenceId.Frozen = true;
            DifferenceId.HeaderText = "";
            DifferenceId.Name = "DifferenceId";
            DifferenceId.ReadOnly = true;
            // 
            // PositionWord
            // 
            PositionWord.Frozen = true;
            PositionWord.HeaderText = "الكلمة في حفص";
            PositionWord.Name = "PositionWord";
            PositionWord.ReadOnly = true;
            PositionWord.Width = 150;
            // 
            // Difference
            // 
            Difference.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Difference.Frozen = true;
            Difference.HeaderText = "الفرش";
            Difference.Name = "Difference";
            Difference.ReadOnly = true;
            Difference.Width = 400;
            // 
            // ReadersNames
            // 
            ReadersNames.HeaderText = "من قرأ بها";
            ReadersNames.Name = "ReadersNames";
            ReadersNames.ReadOnly = true;
            ReadersNames.Width = 300;
            // 
            // ChapterName
            // 
            ChapterName.HeaderText = "السورة";
            ChapterName.Name = "ChapterName";
            ChapterName.ReadOnly = true;
            // 
            // Verse
            // 
            Verse.HeaderText = "الآية";
            Verse.Name = "Verse";
            // 
            // Page
            // 
            Page.HeaderText = "الصفحة";
            Page.Name = "Page";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(12, 593);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(157, 33);
            AddButton.TabIndex = 1;
            AddButton.Text = "إضافة فرش";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // FarshListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1485, 638);
            Controls.Add(AddButton);
            Controls.Add(FarshGridView);
            Name = "FarshListForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "الفرش";
            ((System.ComponentModel.ISupportInitialize)FarshGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView FarshGridView;
        private DataGridViewTextBoxColumn DifferenceId;
        private DataGridViewTextBoxColumn PositionWord;
        private DataGridViewTextBoxColumn Difference;
        private DataGridViewTextBoxColumn ReadersNames;
        private DataGridViewTextBoxColumn ChapterName;
        private DataGridViewTextBoxColumn Verse;
        private DataGridViewTextBoxColumn Page;
        private Button AddButton;
    }
}