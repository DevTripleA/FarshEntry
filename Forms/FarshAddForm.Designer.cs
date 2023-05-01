namespace FarshEntry.Forms
{
    partial class FarshAddForm
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
            WordTextBox = new TextBox();
            WordLabel = new Label();
            DifferenceTextBox = new TextBox();
            DifferenceLabel = new Label();
            ReadersNamesTextBox = new TextBox();
            ReadersNamesLabel = new Label();
            VerseTextBox = new TextBox();
            ChapterLabel = new Label();
            VerseLabel = new Label();
            PageTextBox = new TextBox();
            PageLabel = new Label();
            ChapterComboBox = new ComboBox();
            NafeeCheckBox = new CheckBox();
            IbnKatheerCheckBox = new CheckBox();
            AbuAmrCheckBox = new CheckBox();
            IbnAmirCheckBox = new CheckBox();
            AssimCheckBox = new CheckBox();
            HamzaCheckBox = new CheckBox();
            AlkesaeeCheckBox = new CheckBox();
            AbuJaafarCheckBox = new CheckBox();
            YakoobCheckBox = new CheckBox();
            KhalafCheckBox = new CheckBox();
            QaloonCheckBox = new CheckBox();
            AlbazzyCheckBox = new CheckBox();
            AldoriAbuAmrCheckBox = new CheckBox();
            HishamCheckBox = new CheckBox();
            ShoobaCheckBox = new CheckBox();
            KhalafHamzahCheckBox = new CheckBox();
            AbuAlharethCheckBox = new CheckBox();
            IbnWardanCheckBox = new CheckBox();
            RowaysCheckBox = new CheckBox();
            IsshaqCheckBox = new CheckBox();
            WarshCheckBox = new CheckBox();
            QunbolCheckBox = new CheckBox();
            AlsosiCheckBox = new CheckBox();
            IbnThakwanCheckBox = new CheckBox();
            HafsCheckBox = new CheckBox();
            KhalladCheckBox = new CheckBox();
            AldoriAlkesaeeCheckBox = new CheckBox();
            IbnJammazCheckBox = new CheckBox();
            RawhCheckBox = new CheckBox();
            IdreesCheckBox = new CheckBox();
            AddButton = new Button();
            SuspendLayout();
            // 
            // WordTextBox
            // 
            WordTextBox.Location = new Point(105, 22);
            WordTextBox.Name = "WordTextBox";
            WordTextBox.Size = new Size(150, 23);
            WordTextBox.TabIndex = 0;
            WordTextBox.TextChanged += WordTextBox_TextChanged;
            WordTextBox.KeyDown += WordTextBox_KeyDown;
            // 
            // WordLabel
            // 
            WordLabel.AutoSize = true;
            WordLabel.Location = new Point(11, 25);
            WordLabel.Name = "WordLabel";
            WordLabel.Size = new Size(88, 15);
            WordLabel.TabIndex = 1;
            WordLabel.Text = "الكلمة في حفص";
            // 
            // DifferenceTextBox
            // 
            DifferenceTextBox.Location = new Point(385, 22);
            DifferenceTextBox.Name = "DifferenceTextBox";
            DifferenceTextBox.Size = new Size(409, 23);
            DifferenceTextBox.TabIndex = 1;
            DifferenceTextBox.TextChanged += DifferenceTextBox_TextChanged;
            DifferenceTextBox.KeyDown += DifferenceTextBox_KeyDown;
            // 
            // DifferenceLabel
            // 
            DifferenceLabel.AutoSize = true;
            DifferenceLabel.Location = new Point(341, 25);
            DifferenceLabel.Name = "DifferenceLabel";
            DifferenceLabel.Size = new Size(38, 15);
            DifferenceLabel.TabIndex = 1;
            DifferenceLabel.Text = "الفرش";
            // 
            // ReadersNamesTextBox
            // 
            ReadersNamesTextBox.Location = new Point(105, 61);
            ReadersNamesTextBox.Name = "ReadersNamesTextBox";
            ReadersNamesTextBox.ReadOnly = true;
            ReadersNamesTextBox.Size = new Size(689, 23);
            ReadersNamesTextBox.TabIndex = 2;
            ReadersNamesTextBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // ReadersNamesLabel
            // 
            ReadersNamesLabel.AutoSize = true;
            ReadersNamesLabel.Location = new Point(45, 64);
            ReadersNamesLabel.Name = "ReadersNamesLabel";
            ReadersNamesLabel.Size = new Size(54, 15);
            ReadersNamesLabel.TabIndex = 1;
            ReadersNamesLabel.Text = "من قرأ بها";
            // 
            // VerseTextBox
            // 
            VerseTextBox.Location = new Point(385, 101);
            VerseTextBox.Name = "VerseTextBox";
            VerseTextBox.Size = new Size(150, 23);
            VerseTextBox.TabIndex = 4;
            // 
            // ChapterLabel
            // 
            ChapterLabel.AutoSize = true;
            ChapterLabel.Location = new Point(59, 104);
            ChapterLabel.Name = "ChapterLabel";
            ChapterLabel.Size = new Size(40, 15);
            ChapterLabel.TabIndex = 1;
            ChapterLabel.Text = "السورة";
            // 
            // VerseLabel
            // 
            VerseLabel.Location = new Point(352, 104);
            VerseLabel.Name = "VerseLabel";
            VerseLabel.Size = new Size(27, 23);
            VerseLabel.TabIndex = 1;
            VerseLabel.Text = "الآية";
            // 
            // PageTextBox
            // 
            PageTextBox.Location = new Point(644, 101);
            PageTextBox.Name = "PageTextBox";
            PageTextBox.Size = new Size(150, 23);
            PageTextBox.TabIndex = 5;
            // 
            // PageLabel
            // 
            PageLabel.AutoSize = true;
            PageLabel.Location = new Point(593, 104);
            PageLabel.Name = "PageLabel";
            PageLabel.Size = new Size(45, 15);
            PageLabel.TabIndex = 1;
            PageLabel.Text = "الصفحة";
            // 
            // ChapterComboBox
            // 
            ChapterComboBox.FormattingEnabled = true;
            ChapterComboBox.Location = new Point(105, 101);
            ChapterComboBox.Name = "ChapterComboBox";
            ChapterComboBox.Size = new Size(150, 23);
            ChapterComboBox.TabIndex = 3;
            // 
            // NafeeCheckBox
            // 
            NafeeCheckBox.AccessibleDescription = "";
            NafeeCheckBox.AutoCheck = false;
            NafeeCheckBox.AutoSize = true;
            NafeeCheckBox.Location = new Point(105, 183);
            NafeeCheckBox.Name = "NafeeCheckBox";
            NafeeCheckBox.Size = new Size(57, 19);
            NafeeCheckBox.TabIndex = 6;
            NafeeCheckBox.Text = "أ- نافع";
            NafeeCheckBox.UseVisualStyleBackColor = true;
            NafeeCheckBox.Click += ReadersCheckBoxes_Click;
            NafeeCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // IbnKatheerCheckBox
            // 
            IbnKatheerCheckBox.AccessibleDescription = "";
            IbnKatheerCheckBox.AutoCheck = false;
            IbnKatheerCheckBox.AutoSize = true;
            IbnKatheerCheckBox.Location = new Point(105, 208);
            IbnKatheerCheckBox.Name = "IbnKatheerCheckBox";
            IbnKatheerCheckBox.Size = new Size(77, 19);
            IbnKatheerCheckBox.TabIndex = 9;
            IbnKatheerCheckBox.Text = "د- ابن كثير";
            IbnKatheerCheckBox.UseVisualStyleBackColor = true;
            IbnKatheerCheckBox.Click += ReadersCheckBoxes_Click;
            IbnKatheerCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // AbuAmrCheckBox
            // 
            AbuAmrCheckBox.AccessibleDescription = "";
            AbuAmrCheckBox.AutoCheck = false;
            AbuAmrCheckBox.AutoSize = true;
            AbuAmrCheckBox.Location = new Point(105, 233);
            AbuAmrCheckBox.Name = "AbuAmrCheckBox";
            AbuAmrCheckBox.Size = new Size(81, 19);
            AbuAmrCheckBox.TabIndex = 12;
            AbuAmrCheckBox.Text = "ح- أبو عمرو";
            AbuAmrCheckBox.UseVisualStyleBackColor = true;
            AbuAmrCheckBox.Click += ReadersCheckBoxes_Click;
            AbuAmrCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // IbnAmirCheckBox
            // 
            IbnAmirCheckBox.AutoCheck = false;
            IbnAmirCheckBox.AutoSize = true;
            IbnAmirCheckBox.Location = new Point(105, 258);
            IbnAmirCheckBox.Name = "IbnAmirCheckBox";
            IbnAmirCheckBox.Size = new Size(84, 19);
            IbnAmirCheckBox.TabIndex = 15;
            IbnAmirCheckBox.Text = "ك- ابن عامر";
            IbnAmirCheckBox.UseVisualStyleBackColor = true;
            IbnAmirCheckBox.Click += ReadersCheckBoxes_Click;
            IbnAmirCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // AssimCheckBox
            // 
            AssimCheckBox.AutoCheck = false;
            AssimCheckBox.AutoSize = true;
            AssimCheckBox.Enabled = false;
            AssimCheckBox.Location = new Point(105, 283);
            AssimCheckBox.Name = "AssimCheckBox";
            AssimCheckBox.Size = new Size(71, 19);
            AssimCheckBox.TabIndex = 18;
            AssimCheckBox.Text = "ن- عاصم";
            AssimCheckBox.UseVisualStyleBackColor = true;
            AssimCheckBox.Click += ReadersCheckBoxes_Click;
            AssimCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // HamzaCheckBox
            // 
            HamzaCheckBox.AutoCheck = false;
            HamzaCheckBox.AutoSize = true;
            HamzaCheckBox.Location = new Point(105, 308);
            HamzaCheckBox.Name = "HamzaCheckBox";
            HamzaCheckBox.Size = new Size(70, 19);
            HamzaCheckBox.TabIndex = 21;
            HamzaCheckBox.Text = "ف- حمزة";
            HamzaCheckBox.UseVisualStyleBackColor = true;
            HamzaCheckBox.Click += ReadersCheckBoxes_Click;
            HamzaCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // AlkesaeeCheckBox
            // 
            AlkesaeeCheckBox.AutoCheck = false;
            AlkesaeeCheckBox.AutoSize = true;
            AlkesaeeCheckBox.Location = new Point(105, 333);
            AlkesaeeCheckBox.Name = "AlkesaeeCheckBox";
            AlkesaeeCheckBox.Size = new Size(79, 19);
            AlkesaeeCheckBox.TabIndex = 24;
            AlkesaeeCheckBox.Text = "ر- الكسائي";
            AlkesaeeCheckBox.UseVisualStyleBackColor = true;
            AlkesaeeCheckBox.Click += ReadersCheckBoxes_Click;
            AlkesaeeCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // AbuJaafarCheckBox
            // 
            AbuJaafarCheckBox.AutoCheck = false;
            AbuJaafarCheckBox.AutoSize = true;
            AbuJaafarCheckBox.Location = new Point(105, 358);
            AbuJaafarCheckBox.Name = "AbuJaafarCheckBox";
            AbuJaafarCheckBox.Size = new Size(86, 19);
            AbuJaafarCheckBox.TabIndex = 27;
            AbuJaafarCheckBox.Text = "ث- أبو جعفر";
            AbuJaafarCheckBox.UseVisualStyleBackColor = true;
            AbuJaafarCheckBox.Click += ReadersCheckBoxes_Click;
            AbuJaafarCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // YakoobCheckBox
            // 
            YakoobCheckBox.AutoCheck = false;
            YakoobCheckBox.AutoSize = true;
            YakoobCheckBox.Location = new Point(105, 383);
            YakoobCheckBox.Name = "YakoobCheckBox";
            YakoobCheckBox.Size = new Size(78, 19);
            YakoobCheckBox.TabIndex = 30;
            YakoobCheckBox.Text = "ظ- يعقوب";
            YakoobCheckBox.UseVisualStyleBackColor = true;
            YakoobCheckBox.Click += ReadersCheckBoxes_Click;
            YakoobCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // KhalafCheckBox
            // 
            KhalafCheckBox.AutoCheck = false;
            KhalafCheckBox.AutoSize = true;
            KhalafCheckBox.Location = new Point(105, 408);
            KhalafCheckBox.Name = "KhalafCheckBox";
            KhalafCheckBox.Size = new Size(60, 19);
            KhalafCheckBox.TabIndex = 33;
            KhalafCheckBox.Text = "إ- خلف";
            KhalafCheckBox.UseVisualStyleBackColor = true;
            KhalafCheckBox.Click += ReadersCheckBoxes_Click;
            KhalafCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // QaloonCheckBox
            // 
            QaloonCheckBox.AccessibleDescription = "";
            QaloonCheckBox.AutoCheck = false;
            QaloonCheckBox.AutoSize = true;
            QaloonCheckBox.Location = new Point(385, 183);
            QaloonCheckBox.Name = "QaloonCheckBox";
            QaloonCheckBox.Size = new Size(72, 19);
            QaloonCheckBox.TabIndex = 7;
            QaloonCheckBox.Text = "ب- قالون";
            QaloonCheckBox.UseVisualStyleBackColor = true;
            QaloonCheckBox.Click += ReadersCheckBoxes_Click;
            QaloonCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // AlbazzyCheckBox
            // 
            AlbazzyCheckBox.AccessibleDescription = "";
            AlbazzyCheckBox.AutoCheck = false;
            AlbazzyCheckBox.AutoSize = true;
            AlbazzyCheckBox.Location = new Point(385, 208);
            AlbazzyCheckBox.Name = "AlbazzyCheckBox";
            AlbazzyCheckBox.Size = new Size(68, 19);
            AlbazzyCheckBox.TabIndex = 10;
            AlbazzyCheckBox.Text = "هـ- البزي";
            AlbazzyCheckBox.UseVisualStyleBackColor = true;
            AlbazzyCheckBox.Click += ReadersCheckBoxes_Click;
            AlbazzyCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // AldoriAbuAmrCheckBox
            // 
            AldoriAbuAmrCheckBox.AutoCheck = false;
            AldoriAbuAmrCheckBox.AutoSize = true;
            AldoriAbuAmrCheckBox.Location = new Point(385, 233);
            AldoriAbuAmrCheckBox.Name = "AldoriAbuAmrCheckBox";
            AldoriAbuAmrCheckBox.Size = new Size(141, 19);
            AldoriAbuAmrCheckBox.TabIndex = 13;
            AldoriAbuAmrCheckBox.Text = "ط- الدوري عن أبي عمرو";
            AldoriAbuAmrCheckBox.UseVisualStyleBackColor = true;
            AldoriAbuAmrCheckBox.Click += ReadersCheckBoxes_Click;
            AldoriAbuAmrCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // HishamCheckBox
            // 
            HishamCheckBox.AutoCheck = false;
            HishamCheckBox.AutoSize = true;
            HishamCheckBox.Location = new Point(385, 258);
            HishamCheckBox.Name = "HishamCheckBox";
            HishamCheckBox.Size = new Size(70, 19);
            HishamCheckBox.TabIndex = 16;
            HishamCheckBox.Text = "ل- هشام";
            HishamCheckBox.UseVisualStyleBackColor = true;
            HishamCheckBox.Click += ReadersCheckBoxes_Click;
            HishamCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // ShoobaCheckBox
            // 
            ShoobaCheckBox.AutoCheck = false;
            ShoobaCheckBox.AutoSize = true;
            ShoobaCheckBox.Location = new Point(385, 283);
            ShoobaCheckBox.Name = "ShoobaCheckBox";
            ShoobaCheckBox.Size = new Size(77, 19);
            ShoobaCheckBox.TabIndex = 19;
            ShoobaCheckBox.Text = "ص- شعبة";
            ShoobaCheckBox.UseVisualStyleBackColor = true;
            ShoobaCheckBox.Click += ReadersCheckBoxes_Click;
            ShoobaCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // KhalafHamzahCheckBox
            // 
            KhalafHamzahCheckBox.AutoCheck = false;
            KhalafHamzahCheckBox.AutoSize = true;
            KhalafHamzahCheckBox.Location = new Point(385, 308);
            KhalafHamzahCheckBox.Name = "KhalafHamzahCheckBox";
            KhalafHamzahCheckBox.Size = new Size(118, 19);
            KhalafHamzahCheckBox.TabIndex = 22;
            KhalafHamzahCheckBox.Text = "ض- خلف عن حمزة";
            KhalafHamzahCheckBox.UseVisualStyleBackColor = true;
            KhalafHamzahCheckBox.Click += ReadersCheckBoxes_Click;
            KhalafHamzahCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // AbuAlharethCheckBox
            // 
            AbuAlharethCheckBox.AutoCheck = false;
            AbuAlharethCheckBox.AutoSize = true;
            AbuAlharethCheckBox.Location = new Point(385, 333);
            AbuAlharethCheckBox.Name = "AbuAlharethCheckBox";
            AbuAlharethCheckBox.Size = new Size(96, 19);
            AbuAlharethCheckBox.TabIndex = 25;
            AbuAlharethCheckBox.Text = "س- أبو الحارث";
            AbuAlharethCheckBox.UseVisualStyleBackColor = true;
            AbuAlharethCheckBox.Click += ReadersCheckBoxes_Click;
            AbuAlharethCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // IbnWardanCheckBox
            // 
            IbnWardanCheckBox.AutoCheck = false;
            IbnWardanCheckBox.AutoSize = true;
            IbnWardanCheckBox.Location = new Point(385, 358);
            IbnWardanCheckBox.Name = "IbnWardanCheckBox";
            IbnWardanCheckBox.Size = new Size(86, 19);
            IbnWardanCheckBox.TabIndex = 28;
            IbnWardanCheckBox.Text = "خ- ابن وردان";
            IbnWardanCheckBox.UseVisualStyleBackColor = true;
            IbnWardanCheckBox.Click += ReadersCheckBoxes_Click;
            IbnWardanCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // RowaysCheckBox
            // 
            RowaysCheckBox.AutoCheck = false;
            RowaysCheckBox.AutoSize = true;
            RowaysCheckBox.Location = new Point(385, 383);
            RowaysCheckBox.Name = "RowaysCheckBox";
            RowaysCheckBox.Size = new Size(69, 19);
            RowaysCheckBox.TabIndex = 31;
            RowaysCheckBox.Text = "غ- رويس";
            RowaysCheckBox.UseVisualStyleBackColor = true;
            RowaysCheckBox.Click += ReadersCheckBoxes_Click;
            RowaysCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // IsshaqCheckBox
            // 
            IsshaqCheckBox.AutoCheck = false;
            IsshaqCheckBox.AutoSize = true;
            IsshaqCheckBox.Location = new Point(385, 408);
            IsshaqCheckBox.Name = "IsshaqCheckBox";
            IsshaqCheckBox.Size = new Size(58, 19);
            IsshaqCheckBox.TabIndex = 34;
            IsshaqCheckBox.Text = "إسحاق";
            IsshaqCheckBox.UseVisualStyleBackColor = true;
            IsshaqCheckBox.Click += ReadersCheckBoxes_Click;
            IsshaqCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // WarshCheckBox
            // 
            WarshCheckBox.AccessibleDescription = "";
            WarshCheckBox.AutoCheck = false;
            WarshCheckBox.AutoSize = true;
            WarshCheckBox.Location = new Point(644, 183);
            WarshCheckBox.Name = "WarshCheckBox";
            WarshCheckBox.Size = new Size(65, 19);
            WarshCheckBox.TabIndex = 8;
            WarshCheckBox.Text = "ج- ورش";
            WarshCheckBox.UseVisualStyleBackColor = true;
            WarshCheckBox.Click += ReadersCheckBoxes_Click;
            WarshCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // QunbolCheckBox
            // 
            QunbolCheckBox.AccessibleDescription = "";
            QunbolCheckBox.AutoCheck = false;
            QunbolCheckBox.AutoSize = true;
            QunbolCheckBox.Location = new Point(644, 208);
            QunbolCheckBox.Name = "QunbolCheckBox";
            QunbolCheckBox.Size = new Size(61, 19);
            QunbolCheckBox.TabIndex = 11;
            QunbolCheckBox.Text = "ز- قنبل";
            QunbolCheckBox.UseVisualStyleBackColor = true;
            QunbolCheckBox.Click += ReadersCheckBoxes_Click;
            QunbolCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // AlsosiCheckBox
            // 
            AlsosiCheckBox.AutoCheck = false;
            AlsosiCheckBox.AutoSize = true;
            AlsosiCheckBox.FlatStyle = FlatStyle.System;
            AlsosiCheckBox.Location = new Point(644, 232);
            AlsosiCheckBox.Name = "AlsosiCheckBox";
            AlsosiCheckBox.Size = new Size(92, 20);
            AlsosiCheckBox.TabIndex = 14;
            AlsosiCheckBox.Text = " ي- السوسي";
            AlsosiCheckBox.UseVisualStyleBackColor = true;
            AlsosiCheckBox.Click += ReadersCheckBoxes_Click;
            AlsosiCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // IbnThakwanCheckBox
            // 
            IbnThakwanCheckBox.AutoCheck = false;
            IbnThakwanCheckBox.AutoSize = true;
            IbnThakwanCheckBox.Location = new Point(644, 258);
            IbnThakwanCheckBox.Name = "IbnThakwanCheckBox";
            IbnThakwanCheckBox.Size = new Size(88, 19);
            IbnThakwanCheckBox.TabIndex = 17;
            IbnThakwanCheckBox.Text = "م- ابن ذكوان";
            IbnThakwanCheckBox.UseVisualStyleBackColor = true;
            IbnThakwanCheckBox.Click += ReadersCheckBoxes_Click;
            IbnThakwanCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // HafsCheckBox
            // 
            HafsCheckBox.AutoCheck = false;
            HafsCheckBox.AutoSize = true;
            HafsCheckBox.Enabled = false;
            HafsCheckBox.Location = new Point(644, 283);
            HafsCheckBox.Name = "HafsCheckBox";
            HafsCheckBox.Size = new Size(69, 19);
            HafsCheckBox.TabIndex = 20;
            HafsCheckBox.Text = "ع- حفص";
            HafsCheckBox.UseVisualStyleBackColor = true;
            HafsCheckBox.Click += ReadersCheckBoxes_Click;
            HafsCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // KhalladCheckBox
            // 
            KhalladCheckBox.AutoCheck = false;
            KhalladCheckBox.AutoSize = true;
            KhalladCheckBox.Location = new Point(644, 308);
            KhalladCheckBox.Name = "KhalladCheckBox";
            KhalladCheckBox.Size = new Size(63, 19);
            KhalladCheckBox.TabIndex = 23;
            KhalladCheckBox.Text = "ق- خلاد";
            KhalladCheckBox.UseVisualStyleBackColor = true;
            KhalladCheckBox.Click += ReadersCheckBoxes_Click;
            KhalladCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // AldoriAlkesaeeCheckBox
            // 
            AldoriAlkesaeeCheckBox.AutoCheck = false;
            AldoriAlkesaeeCheckBox.AutoSize = true;
            AldoriAlkesaeeCheckBox.Location = new Point(644, 333);
            AldoriAlkesaeeCheckBox.Name = "AldoriAlkesaeeCheckBox";
            AldoriAlkesaeeCheckBox.Size = new Size(138, 19);
            AldoriAlkesaeeCheckBox.TabIndex = 26;
            AldoriAlkesaeeCheckBox.Text = "ت- الدوري عن الكسائي";
            AldoriAlkesaeeCheckBox.UseVisualStyleBackColor = true;
            AldoriAlkesaeeCheckBox.Click += ReadersCheckBoxes_Click;
            AldoriAlkesaeeCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // IbnJammazCheckBox
            // 
            IbnJammazCheckBox.AutoCheck = false;
            IbnJammazCheckBox.AutoSize = true;
            IbnJammazCheckBox.Location = new Point(644, 358);
            IbnJammazCheckBox.Name = "IbnJammazCheckBox";
            IbnJammazCheckBox.Size = new Size(80, 19);
            IbnJammazCheckBox.TabIndex = 29;
            IbnJammazCheckBox.Text = "ذ- ابن جماز";
            IbnJammazCheckBox.UseVisualStyleBackColor = true;
            IbnJammazCheckBox.Click += ReadersCheckBoxes_Click;
            IbnJammazCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // RawhCheckBox
            // 
            RawhCheckBox.AutoCheck = false;
            RawhCheckBox.AutoSize = true;
            RawhCheckBox.Location = new Point(644, 383);
            RawhCheckBox.Name = "RawhCheckBox";
            RawhCheckBox.Size = new Size(66, 19);
            RawhCheckBox.TabIndex = 32;
            RawhCheckBox.Text = "ش- روح";
            RawhCheckBox.UseVisualStyleBackColor = true;
            RawhCheckBox.Click += ReadersCheckBoxes_Click;
            RawhCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // IdreesCheckBox
            // 
            IdreesCheckBox.AutoCheck = false;
            IdreesCheckBox.AutoSize = true;
            IdreesCheckBox.Location = new Point(644, 408);
            IdreesCheckBox.Name = "IdreesCheckBox";
            IdreesCheckBox.Size = new Size(59, 19);
            IdreesCheckBox.TabIndex = 35;
            IdreesCheckBox.Text = "إدريس";
            IdreesCheckBox.UseVisualStyleBackColor = true;
            IdreesCheckBox.Click += ReadersCheckBoxes_Click;
            IdreesCheckBox.KeyDown += FarshAddForm_KeyDown;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(341, 502);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(157, 33);
            AddButton.TabIndex = 36;
            AddButton.Text = "حفظ";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // FarshAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 547);
            Controls.Add(AddButton);
            Controls.Add(IdreesCheckBox);
            Controls.Add(IsshaqCheckBox);
            Controls.Add(KhalafCheckBox);
            Controls.Add(RawhCheckBox);
            Controls.Add(RowaysCheckBox);
            Controls.Add(YakoobCheckBox);
            Controls.Add(IbnJammazCheckBox);
            Controls.Add(IbnWardanCheckBox);
            Controls.Add(AbuJaafarCheckBox);
            Controls.Add(AldoriAlkesaeeCheckBox);
            Controls.Add(AbuAlharethCheckBox);
            Controls.Add(AlkesaeeCheckBox);
            Controls.Add(KhalladCheckBox);
            Controls.Add(KhalafHamzahCheckBox);
            Controls.Add(HamzaCheckBox);
            Controls.Add(HafsCheckBox);
            Controls.Add(ShoobaCheckBox);
            Controls.Add(AssimCheckBox);
            Controls.Add(IbnThakwanCheckBox);
            Controls.Add(HishamCheckBox);
            Controls.Add(IbnAmirCheckBox);
            Controls.Add(AlsosiCheckBox);
            Controls.Add(AldoriAbuAmrCheckBox);
            Controls.Add(AbuAmrCheckBox);
            Controls.Add(QunbolCheckBox);
            Controls.Add(AlbazzyCheckBox);
            Controls.Add(IbnKatheerCheckBox);
            Controls.Add(WarshCheckBox);
            Controls.Add(QaloonCheckBox);
            Controls.Add(NafeeCheckBox);
            Controls.Add(ChapterComboBox);
            Controls.Add(DifferenceLabel);
            Controls.Add(PageLabel);
            Controls.Add(VerseLabel);
            Controls.Add(ChapterLabel);
            Controls.Add(PageTextBox);
            Controls.Add(ReadersNamesLabel);
            Controls.Add(VerseTextBox);
            Controls.Add(WordLabel);
            Controls.Add(ReadersNamesTextBox);
            Controls.Add(DifferenceTextBox);
            Controls.Add(WordTextBox);
            Name = "FarshAddForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إضافة فرش";
            KeyDown += FarshAddForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox WordTextBox;
        private Label WordLabel;
        private TextBox DifferenceTextBox;
        private Label DifferenceLabel;
        private TextBox ReadersNamesTextBox;
        private Label ReadersNamesLabel;
        private TextBox VerseTextBox;
        private Label ChapterLabel;
        private TextBox PageTextBox;
        private Label VerseLabel;
        private Label PageLabel;
        private ComboBox ChapterComboBox;
        private CheckBox NafeeCheckBox;
        private CheckBox IbnKatheerCheckBox;
        private CheckBox AbuAmrCheckBox;
        private CheckBox IbnAmirCheckBox;
        private CheckBox AssimCheckBox;
        private CheckBox HamzaCheckBox;
        private CheckBox AlkesaeeCheckBox;
        private CheckBox AbuJaafarCheckBox;
        private CheckBox YakoobCheckBox;
        private CheckBox KhalafCheckBox;
        private CheckBox QaloonCheckBox;
        private CheckBox AlbazzyCheckBox;
        private CheckBox AldoriAbuAmrCheckBox;
        private CheckBox HishamCheckBox;
        private CheckBox ShoobaCheckBox;
        private CheckBox KhalafHamzahCheckBox;
        private CheckBox AbuAlharethCheckBox;
        private CheckBox IbnWardanCheckBox;
        private CheckBox RowaysCheckBox;
        private CheckBox IsshaqCheckBox;
        private CheckBox WarshCheckBox;
        private CheckBox QunbolCheckBox;
        private CheckBox AlsosiCheckBox;
        private CheckBox IbnThakwanCheckBox;
        private CheckBox HafsCheckBox;
        private CheckBox KhalladCheckBox;
        private CheckBox AldoriAlkesaeeCheckBox;
        private CheckBox IbnJammazCheckBox;
        private CheckBox RawhCheckBox;
        private CheckBox IdreesCheckBox;
        private Button AddButton;
    }
}