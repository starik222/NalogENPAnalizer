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
        }

        private void Form_op_editor_Load(object sender, EventArgs e)
        {
            Program.MainDb.Operations.Load();
            BindingSource bs = new BindingSource();
            bs.DataSource = Program.MainDb.Operations.Local.ToBindingList();
            bs.Sort = "OperationDate";
            dataGridView1.DataSource = bs;
            BindTableToCB<DocOsnData>("opDocOsn", "Name", "Id");
            BindTableToCB<KbkData>("opKbk", "KodKbk", "Id");
            BindTableToCB<KppData>("opKpp", "Kpp", "Id");
            BindTableToCB<OktmoData>("opOktmo", "Oktmo", "Id");
            BindTableToCB<PokazatelData>("opPokazatel", "Name", "Id");
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
    }
}
