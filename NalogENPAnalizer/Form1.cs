using BitmagnetUI;
using NalogENPAnalizer.DataModels;
using System.Data;

namespace NalogENPAnalizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fFilter = new Form_filter();
        }
        private Form_filter fFilter;
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "xml files|*.xml";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            EnpXmlReaderToDb reader = new EnpXmlReaderToDb();
            reader.ReadXmlToDb(openFileDialog.FileName);
        }

        private void кБКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Dicts dicts = new Form_Dicts();
            dicts.dataGridView1.DataSource = Program.MainDb.Kbk.Local.ToBindingList();
            dicts.ShowDialog();
            dicts.Close();
        }

        private void суммированиеДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fFilter.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            FilterData fd = fFilter.GetFilterData();
            IQueryable<OperationData> op = Program.MainDb.Operations;
            var predicate = PredicateBuilder.True<OperationData>();
            predicate = predicate.AND(a => a.OperationDate >= fd.Start);
            predicate = predicate.AND(a => a.OperationDate <= fd.End);
            if (fd.DocOsn != null)
                predicate = predicate.AND(a => a.DocOsnId == fd.DocOsn);
            if (fd.Kbk != null)
                predicate = predicate.AND(a => a.KbkId == fd.Kbk);
            if (fd.Kpp != null)
                predicate = predicate.AND(a => a.KppId == fd.Kpp);
            if (fd.Oktmo != null)
                predicate = predicate.AND(a => a.OktmoId == fd.Oktmo);
            if (fd.Pokazatel != null)
                predicate = predicate.AND(a => a.PokazatelId == fd.Pokazatel);
            op = op.Where(predicate);
            decimal sum = op.Sum(a => a.Summa);
            DataTable dt = new DataTable();
            dt.Columns.Add("Показатель", typeof(string));
            dt.Columns.Add("Результат", typeof(decimal));
            dt.Rows.Add("Сумма за период", sum);
            dataGridView1.DataSource = dt;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                if (dataGridView1.Columns[i].ValueType == typeof(decimal))
                {
                    dataGridView1.Columns[i].DefaultCellStyle.Format = "N2";
                }
            }

        }

        private void редакторЗагруженныхДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_op_editor op_Editor = new Form_op_editor();
            op_Editor.ShowDialog();
            op_Editor.Close();
        }
    }
}
