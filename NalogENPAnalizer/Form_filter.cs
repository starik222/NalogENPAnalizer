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
    public partial class Form_filter : Form
    {
        public Form_filter()
        {
            InitializeComponent();
            BindTableToCB<DocOsnData>(comboBoxDocOsn);
            //BindTableToCB<KbkData>(comboBoxKbk);
            var nKbk = Program.MainDb.Kbk.Select(a => new { Id = a.Id, Name = (a.Name == "" ? a.KodKbk : a.Name) }).ToList();
            comboBoxKbk.DataSource = nKbk;
            BindTableToCB<KppData>(comboBoxKpp);
            BindTableToCB<OktmoData>(comboBoxOktmo);
            BindTableToCB<PokazatelData>(comboBoxPokazatel);
            if (Program.MainDb.Operations.Count() > 0)
            {
                dateTimePickerStart.Value = Program.MainDb.Operations.Min(a => a.OperationDate);
                dateTimePickerEnd.Value = Program.MainDb.Operations.Max(a => a.OperationDate);
            }
        }

        public FilterData GetFilterData()
        {
            FilterData data = new FilterData();
            data.Start = dateTimePickerStart.Value;
            data.End = dateTimePickerEnd.Value;
            if (checkBoxDocOsn.Checked)
                data.DocOsn = (int)comboBoxDocOsn.SelectedValue;
            if (checkBoxKbk.Checked)
                data.Kbk = (int)comboBoxKbk.SelectedValue;
            if (checkBoxKpp.Checked)
                data.Kpp = (int)comboBoxKpp.SelectedValue;
            if (checkBoxOktmo.Checked)
                data.Oktmo = (int)comboBoxOktmo.SelectedValue;
            if (checkBoxPokazatel.Checked)
                data.Pokazatel = (int)comboBoxPokazatel.SelectedValue;
            return data;
        }

        private void BindTableToCB<T>(ComboBox cb) where T : class
        {
            cb.DataSource = Program.MainDb.Set<T>().Local.ToBindingList();
        }

        private void checkBoxKbk_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxKbk.Enabled = checkBoxKbk.Checked;
        }

        private void checkBoxPokazatel_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPokazatel.Enabled = checkBoxPokazatel.Checked;
        }

        private void checkBoxDocOsn_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDocOsn.Enabled = checkBoxDocOsn.Checked;
        }

        private void checkBoxOktmo_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxOktmo.Enabled = checkBoxOktmo.Checked;
        }

        private void checkBoxKpp_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxKpp.Enabled = checkBoxKpp.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
