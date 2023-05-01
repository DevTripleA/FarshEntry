using System.Data;

namespace FarshEntry.Forms
{
    public partial class FarshAddForm : Form
    {
        private FarshData _farsh = new FarshData { ReadersIds = new List<int>() };
        private List<Reader> _readers = new List<Reader>();
        private List<ReaderCheckBox> _readersCheckBoxes = new List<ReaderCheckBox>();

        public FarshAddForm()
        {
            InitializeComponent();

            FillChaptersComboBox();
            FetchReaders();
            PrepareReadersCheckBoxes();
        }

        private void PrepareReadersCheckBoxes()
        {
            var checkBoxes = new List<CheckBox>();
            foreach (var control in Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBoxes.Add(checkBox);
                }
            }
            checkBoxes = checkBoxes.OrderBy(c => c.TabIndex).ToList();

            for (int i = 0; i < checkBoxes.Count; i++)
            {
                _readersCheckBoxes.Add(new ReaderCheckBox(checkBoxes[i], _readers.First(r => r.ReaderId == i + 1)));
            }
        }

        private void FillChaptersComboBox()
        {
            var data = DatabaseManager.Fetch(ScriptsFilesNames.ChaptersQuery);
            ChapterComboBox.DisplayMember = "Name";
            ChapterComboBox.ValueMember = "Id";
            ChapterComboBox.DataSource = data;
        }

        private void FetchReaders()
        {
            var data = DatabaseManager.Fetch(ScriptsFilesNames.ReadersQuery);
            foreach (DataRow row in data.Rows)
            {
                var reader = new Reader
                {
                    ReaderId = ConvertRowIdValueToInt("Id").Value,
                    ParentId = ConvertRowIdValueToInt("ParentId"),
                    ReaderName = ConvertRowValueToString("Name")
                };
                _readers.Add(reader);

                int? ConvertRowIdValueToInt(string fieldName)
                {
                    var rowValue = ConvertRowValueToString(fieldName);
                    return string.IsNullOrEmpty(rowValue) ? null : int.Parse(ConvertRowValueToString(fieldName));
                }

                string ConvertRowValueToString(string fieldName) => row[fieldName]?.ToString();
            }
        }

        private void FarshAddForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.H) // أ
            {
                ReadersCheckBoxes_Click(NafeeCheckBox, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.F) // ب
            {
                ReadersCheckBoxes_Click(QaloonCheckBox, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.OemOpenBrackets) // ج
            {
                ReadersCheckBoxes_Click(WarshCheckBox, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.OemCloseBrackets) // د
            {
                ReadersCheckBoxes_Click(IbnKatheerCheckBox, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.I) // هـ
            {
                ReadersCheckBoxes_Click(AlbazzyCheckBox, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.OemPeriod) // ز
            {
                ReadersCheckBoxes_Click(QunbolCheckBox, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.P) // ح
            {
                ReadersCheckBoxes_Click(AbuAmrCheckBox, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.OemQuotes) // ط
            {
                ReadersCheckBoxes_Click(AldoriAbuAmrCheckBox, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.D) // ي
            {
                ReadersCheckBoxes_Click(AlsosiCheckBox, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.OemSemicolon) // ك
            {
                ReadersCheckBoxes_Click(IbnAmirCheckBox, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.G) // ل
            {
                ReadersCheckBoxes_Click(HishamCheckBox, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.L) // م
            {
                ReadersCheckBoxes_Click(IbnThakwanCheckBox, EventArgs.Empty);
            }
            //else if (e.KeyCode == Keys.K) // ن
            //{
            //    ReadersCheckBoxes_Click(AssimCheckBox, EventArgs.Empty);
            //}
            else if (e.KeyCode == Keys.W) // ص
            {
                ReadersCheckBoxes_Click(ShoobaCheckBox, EventArgs.Empty);
            }
            //else if (e.KeyCode == Keys.I) // ع
            //{
            //    ReadersCheckBoxes_Click(HafsCheckBox, EventArgs.Empty);
            //}
            else if (e.KeyCode == Keys.T) // ف
            {
                ReadersCheckBoxes_Click(HamzaCheckBox, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Q) // ض
            {
                ReadersCheckBoxes_Click(KhalafHamzahCheckBox, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.R) // ق
            {
                ReadersCheckBoxes_Click(KhalladCheckBox, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.V) // ر
            {
                ReadersCheckBoxes_Click(AlkesaeeCheckBox, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.S) // س
            {
                ReadersCheckBoxes_Click(AbuAlharethCheckBox, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.J) // ت
            {
                ReadersCheckBoxes_Click(AldoriAlkesaeeCheckBox, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.E) // ث
            {
                ReadersCheckBoxes_Click(AbuJaafarCheckBox, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.O) // خ
            {
                ReadersCheckBoxes_Click(IbnWardanCheckBox, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Oemtilde) // ذ
            {
                ReadersCheckBoxes_Click(IbnJammazCheckBox, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.OemQuestion) // ظ
            {
                ReadersCheckBoxes_Click(YakoobCheckBox, EventArgs.Empty);
            }
            else if (e.Shift && e.KeyCode == Keys.Y) // إ
            {
                ReadersCheckBoxes_Click(KhalafCheckBox, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Y) // غ
            {
                ReadersCheckBoxes_Click(RowaysCheckBox, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.A) // ش
            {
                ReadersCheckBoxes_Click(RawhCheckBox, EventArgs.Empty);
            }
        }

        private void ReadersCheckBoxes_Click(object sender, EventArgs e)
        {
            var senderCheckBox = (CheckBox)sender;

            var readerCheckBox = _readersCheckBoxes.First(c => c.Control == sender);

            var senderHasParent = readerCheckBox.Reader.ParentId.HasValue;

            var parent = senderHasParent ? _readersCheckBoxes.First(c => c.Reader.ReaderId == readerCheckBox.Reader.ParentId).Control : null;

            var senderChecked = !readerCheckBox.Control.Checked;

            var childSelectedWithHisParent = senderChecked && senderHasParent && parent.Checked;
            if (senderChecked && senderHasParent && parent.Checked)
            {
                senderCheckBox.Checked = false;
                RefillReadersNames();
                return;
            }

            if (senderChecked && senderHasParent)
            {
                var otherChild = _readersCheckBoxes.First(c => c.Reader.ParentId == readerCheckBox.Reader.ParentId && c.Reader.ReaderId != readerCheckBox.Reader.ReaderId);
                if (otherChild.Control.Checked)
                {
                    parent.Checked = true;
                    readerCheckBox.Control.Checked = otherChild.Control.Checked = readerCheckBox.Control.Enabled = otherChild.Control.Enabled = false;
                    RefillReadersNames();
                    return;
                }
            }

            senderCheckBox.Checked = !senderCheckBox.Checked;

            var childrenCheckBoxes = _readersCheckBoxes.Where(c => c.Reader.ParentId.HasValue && c.Reader.ParentId == readerCheckBox.Reader.ReaderId);
            foreach (var childCheckBox in childrenCheckBoxes)
            {
                if (childCheckBox.Reader.ReaderName == "حفص")
                {
                    continue;
                }

                childCheckBox.Control.Checked = false;
                childCheckBox.Control.Enabled = !senderCheckBox.Checked;
            }

            RefillReadersNames();

            void RefillReadersNames()
            {
                _farsh.ReadersIds = new List<int>();
                ReadersNamesTextBox.Text = string.Empty;

                foreach (var checkBox in _readersCheckBoxes)
                {
                    if (!checkBox.Control.Checked)
                    {
                        continue;
                    }

                    if (!string.IsNullOrWhiteSpace(ReadersNamesTextBox.Text))
                    {
                        ReadersNamesTextBox.Text += "، ";
                    }

                    _farsh.ReadersIds.Add(checkBox.Reader.ReaderId);
                    ReadersNamesTextBox.Text += checkBox.Reader.ReaderName;
                }
            }
        }

        private void WordTextBox_TextChanged(object sender, EventArgs e)
        {
            ConfigureAutoCompleteTextBoxes(sender, ScriptsFilesNames.WordsQuery);
        }

        private void DifferenceTextBox_TextChanged(object sender, EventArgs e)
        {
            ConfigureAutoCompleteTextBoxes(sender, ScriptsFilesNames.DifferencesQuery);
        }

        private void ConfigureAutoCompleteTextBoxes(object sender, string scriptFileName)
        {
            var textBox = (TextBox)sender;

            var data = DatabaseManager.Fetch(scriptFileName, textBox.Text.Trim());
            var suggestions = new AutoCompleteStringCollection();
            foreach (DataRow row in data.Rows)
            {
                suggestions.Add(row[0].ToString());
            }
            textBox.AutoCompleteCustomSource = suggestions;
            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void WordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            GetSelectedFarshDetails(sender, e, ScriptsFilesNames.DifferenceIdQueryByWord);
        }

        private void DifferenceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            GetSelectedFarshDetails(sender, e, ScriptsFilesNames.DifferenceIdQueryByDifference);
        }

        private void GetSelectedFarshDetails(object sender, KeyEventArgs e, string scriptFileName)
        {
            var textBox = (TextBox)sender;

            if (e.KeyData == Keys.Enter)
            {
                var differenceIdData = DatabaseManager.Fetch(scriptFileName, textBox.Text);
                if (differenceIdData.Rows.Count == 0)
                {
                    return;
                }

                var differenceId = differenceIdData.Rows[0][0].ToString();
                var waysData = DatabaseManager.Fetch(ScriptsFilesNames.WaysQuery, differenceId);
                foreach (DataRow way in waysData.Rows)
                {
                    var readerId = int.Parse(way[0].ToString());
                    var readerCheckBox = _readersCheckBoxes.First(c => c.Reader.ReaderId == readerId);
                    ReadersCheckBoxes_Click(readerCheckBox.Control, EventArgs.Empty);
                }

                var farshData = DatabaseManager.Fetch(ScriptsFilesNames.MinorFarshQuery, differenceId);
                WordTextBox.Text = farshData.Rows[0]["Word"].ToString();
                DifferenceTextBox.Text = farshData.Rows[0]["Difference"].ToString();
            }
        }

        private struct ReaderCheckBox
        {
            public CheckBox Control { get; set; }
            public Reader Reader { get; set; }

            public ReaderCheckBox(CheckBox control, Reader reader)
            {
                Control = control;
                Reader = reader;
            }
        }

        private struct Reader
        {
            public int ReaderId { get; set; }
            public string ReaderName { get; set; }
            public int? ParentId { get; set; }

            public Reader(int readerId, string readerName, int? parentId = default)
            {
                ReaderId = readerId;
                ReaderName = readerName;
                ParentId = parentId;
            }
        }

        private struct FarshData
        {
            public int Id { get; set; }
            public string Word { get; set; }
            public string Difference { get; set; }
            public List<int> ReadersIds { get; set; }
        }
    }
}
