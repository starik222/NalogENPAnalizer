using BitmagnetUI;
using Microsoft.EntityFrameworkCore;
using NalogENPAnalizer.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NalogENPAnalizer
{
    public partial class Form_op_editor : Form
    {
        public Form_op_editor()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            fFilter = new Form_filter();
        }
        private BindingSource bs;
        private Form_filter fFilter;
        private void Form_op_editor_Load(object sender, EventArgs e)
        {
            Program.MainDb.Operations.Load();
            bs = new BindingSource();
            bs.DataSource = Program.MainDb.Operations.Local.ToBindingList();
            bs.Sort = "OperationDate";
            dataGridView1.DataSource = bs;
            BindTableToCB<DocOsnData>("opDocOsn", "Name", "Id");
            BindTableToCB<KppData>("opKpp", "Kpp", "Id");
            BindTableToCB<OktmoData>("opOktmo", "Oktmo", "Id");
            BindTableToCB<PokazatelData>("opPokazatel", "Name", "Id");
            //BindTableToCB<KbkData>("opKbk", "KodKbk", "Id");

            var cb = ((DataGridViewComboBoxColumn)dataGridView1.Columns["opKbk"]);
            var nKbk = Program.MainDb.Kbk.Select(a => new { Id = a.Id, Name = (a.Name == "" ? a.KodKbk : a.Name) }).ToList();
            cb.DataSource = nKbk;
            cb.DisplayMember = "Name";
            cb.ValueMember = "Id";

            dataGridView1.Refresh();
        }

        private void BindTableToCB<T>(string colName, string DisplayMember, string ValueMember) where T : class
        {
            var cb = ((DataGridViewComboBoxColumn)dataGridView1.Columns[colName]);
            cb.DataSource = Program.MainDb.Set<T>().Local.ToBindingList();
            cb.DisplayMember = DisplayMember;
            cb.ValueMember = ValueMember;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Program.MainDb.SaveChanges();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            decimal res = 0;
            for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
            {
                if (dataGridView1.SelectedCells[i].ValueType == typeof(decimal))
                {
                    res += (decimal)dataGridView1.SelectedCells[i].Value;
                }
            }
            LabelSumma.Text = res.ToString("N2");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (fFilter.ShowDialog() != DialogResult.OK)
                return;
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
            op = op.OrderBy(a => a.OperationDate);
            bs.DataSource = op.ToList();
            toolStripButton1.Enabled = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bs.DataSource = Program.MainDb.Operations.Local.ToBindingList();
            toolStripButton1.Enabled = true;
        }
    }
}
