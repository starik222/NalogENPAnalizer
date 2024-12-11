namespace NalogENPAnalizer
{
    partial class Form_op_editor
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            dataGridView1 = new DataGridView();
            opIncoming = new DataGridViewCheckBoxColumn();
            opPereplata = new DataGridViewCheckBoxColumn();
            opPokazatel = new DataGridViewComboBoxColumn();
            opDate = new DataGridViewTextBoxColumn();
            opSum = new DataGridViewTextBoxColumn();
            opKbk = new DataGridViewComboBoxColumn();
            opOktmo = new DataGridViewComboBoxColumn();
            opKpp = new DataGridViewComboBoxColumn();
            opDocOsn = new DataGridViewComboBoxColumn();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            LabelSumma = new ToolStripStatusLabel();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.Save;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "Сохранить";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Properties.Resources.AddToFiltered;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "Установить фильтр";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Properties.Resources.DelFromFiltered;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 22);
            toolStripButton3.Text = "Сбросить фильтр";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { opIncoming, opPereplata, opPokazatel, opDate, opSum, opKbk, opOktmo, opKpp, opDocOsn });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 403);
            dataGridView1.TabIndex = 1;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // opIncoming
            // 
            opIncoming.DataPropertyName = "Incoming";
            opIncoming.HeaderText = "Поступление";
            opIncoming.Name = "opIncoming";
            opIncoming.Width = 60;
            // 
            // opPereplata
            // 
            opPereplata.DataPropertyName = "Pereplata";
            opPereplata.HeaderText = "Переплата";
            opPereplata.Name = "opPereplata";
            opPereplata.Width = 60;
            // 
            // opPokazatel
            // 
            opPokazatel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            opPokazatel.DataPropertyName = "PokazatelId";
            opPokazatel.HeaderText = "Показатель";
            opPokazatel.Name = "opPokazatel";
            // 
            // opDate
            // 
            opDate.DataPropertyName = "OperationDate";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            opDate.DefaultCellStyle = dataGridViewCellStyle1;
            opDate.HeaderText = "Дата операции";
            opDate.Name = "opDate";
            // 
            // opSum
            // 
            opSum.DataPropertyName = "Summa";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            opSum.DefaultCellStyle = dataGridViewCellStyle2;
            opSum.HeaderText = "Сумма";
            opSum.Name = "opSum";
            opSum.Width = 120;
            // 
            // opKbk
            // 
            opKbk.DataPropertyName = "KbkId";
            opKbk.HeaderText = "КБК";
            opKbk.Name = "opKbk";
            opKbk.Width = 200;
            // 
            // opOktmo
            // 
            opOktmo.DataPropertyName = "OktmoId";
            opOktmo.HeaderText = "ОКТМО";
            opOktmo.Name = "opOktmo";
            // 
            // opKpp
            // 
            opKpp.DataPropertyName = "KppId";
            opKpp.HeaderText = "КПП";
            opKpp.Name = "opKpp";
            // 
            // opDocOsn
            // 
            opDocOsn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            opDocOsn.DataPropertyName = "DocOsnId";
            opDocOsn.HeaderText = "Основание";
            opDocOsn.Name = "opDocOsn";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, LabelSumma });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(48, 17);
            toolStripStatusLabel1.Text = "Сумма:";
            // 
            // LabelSumma
            // 
            LabelSumma.Name = "LabelSumma";
            LabelSumma.Size = new Size(12, 17);
            LabelSumma.Text = "-";
            // 
            // Form_op_editor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Name = "Form_op_editor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактор данных";
            WindowState = FormWindowState.Maximized;
            Load += Form_op_editor_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private DataGridView dataGridView1;
        private ToolStripButton toolStripButton1;
        private DataGridViewCheckBoxColumn opIncoming;
        private DataGridViewCheckBoxColumn opPereplata;
        private DataGridViewComboBoxColumn opPokazatel;
        private DataGridViewTextBoxColumn opDate;
        private DataGridViewTextBoxColumn opSum;
        private DataGridViewComboBoxColumn opKbk;
        private DataGridViewComboBoxColumn opOktmo;
        private DataGridViewComboBoxColumn opKpp;
        private DataGridViewComboBoxColumn opDocOsn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel LabelSumma;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
    }
}