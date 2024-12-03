namespace NalogENPAnalizer
{
    partial class Form_filter
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
            groupBox1 = new GroupBox();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            comboBoxKpp = new ComboBox();
            comboBoxOktmo = new ComboBox();
            comboBoxDocOsn = new ComboBox();
            comboBoxPokazatel = new ComboBox();
            comboBoxKbk = new ComboBox();
            checkBoxKpp = new CheckBox();
            checkBoxOktmo = new CheckBox();
            checkBoxDocOsn = new CheckBox();
            checkBoxPokazatel = new CheckBox();
            checkBoxKbk = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePickerEnd);
            groupBox1.Controls.Add(dateTimePickerStart);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(583, 60);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Период";
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Format = DateTimePickerFormat.Short;
            dateTimePickerEnd.Location = new Point(354, 18);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(117, 23);
            dateTimePickerEnd.TabIndex = 2;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Format = DateTimePickerFormat.Short;
            dateTimePickerStart.Location = new Point(114, 18);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(117, 23);
            dateTimePickerStart.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 24);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "Дата окончания";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Дата начала";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxKpp);
            groupBox2.Controls.Add(comboBoxOktmo);
            groupBox2.Controls.Add(comboBoxDocOsn);
            groupBox2.Controls.Add(comboBoxPokazatel);
            groupBox2.Controls.Add(comboBoxKbk);
            groupBox2.Controls.Add(checkBoxKpp);
            groupBox2.Controls.Add(checkBoxOktmo);
            groupBox2.Controls.Add(checkBoxDocOsn);
            groupBox2.Controls.Add(checkBoxPokazatel);
            groupBox2.Controls.Add(checkBoxKbk);
            groupBox2.Location = new Point(12, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(583, 177);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Дополнительные фильтры";
            // 
            // comboBoxKpp
            // 
            comboBoxKpp.DisplayMember = "Kpp";
            comboBoxKpp.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxKpp.Enabled = false;
            comboBoxKpp.FormattingEnabled = true;
            comboBoxKpp.Location = new Point(169, 136);
            comboBoxKpp.Name = "comboBoxKpp";
            comboBoxKpp.Size = new Size(408, 23);
            comboBoxKpp.TabIndex = 1;
            comboBoxKpp.ValueMember = "Id";
            // 
            // comboBoxOktmo
            // 
            comboBoxOktmo.DisplayMember = "Oktmo";
            comboBoxOktmo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOktmo.Enabled = false;
            comboBoxOktmo.FormattingEnabled = true;
            comboBoxOktmo.Location = new Point(169, 107);
            comboBoxOktmo.Name = "comboBoxOktmo";
            comboBoxOktmo.Size = new Size(408, 23);
            comboBoxOktmo.TabIndex = 1;
            comboBoxOktmo.ValueMember = "Id";
            // 
            // comboBoxDocOsn
            // 
            comboBoxDocOsn.DisplayMember = "Name";
            comboBoxDocOsn.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDocOsn.Enabled = false;
            comboBoxDocOsn.FormattingEnabled = true;
            comboBoxDocOsn.Location = new Point(169, 78);
            comboBoxDocOsn.Name = "comboBoxDocOsn";
            comboBoxDocOsn.Size = new Size(408, 23);
            comboBoxDocOsn.TabIndex = 1;
            comboBoxDocOsn.ValueMember = "Id";
            // 
            // comboBoxPokazatel
            // 
            comboBoxPokazatel.DisplayMember = "Name";
            comboBoxPokazatel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPokazatel.DropDownWidth = 900;
            comboBoxPokazatel.Enabled = false;
            comboBoxPokazatel.FormattingEnabled = true;
            comboBoxPokazatel.Location = new Point(169, 49);
            comboBoxPokazatel.Name = "comboBoxPokazatel";
            comboBoxPokazatel.Size = new Size(408, 23);
            comboBoxPokazatel.TabIndex = 1;
            comboBoxPokazatel.ValueMember = "Id";
            // 
            // comboBoxKbk
            // 
            comboBoxKbk.DisplayMember = "Name";
            comboBoxKbk.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxKbk.Enabled = false;
            comboBoxKbk.FormattingEnabled = true;
            comboBoxKbk.Location = new Point(169, 20);
            comboBoxKbk.Name = "comboBoxKbk";
            comboBoxKbk.Size = new Size(408, 23);
            comboBoxKbk.TabIndex = 1;
            comboBoxKbk.ValueMember = "Id";
            // 
            // checkBoxKpp
            // 
            checkBoxKpp.AutoSize = true;
            checkBoxKpp.Location = new Point(6, 138);
            checkBoxKpp.Name = "checkBoxKpp";
            checkBoxKpp.Size = new Size(51, 19);
            checkBoxKpp.TabIndex = 0;
            checkBoxKpp.Text = "КПП";
            checkBoxKpp.UseVisualStyleBackColor = true;
            checkBoxKpp.CheckedChanged += checkBoxKpp_CheckedChanged;
            // 
            // checkBoxOktmo
            // 
            checkBoxOktmo.AutoSize = true;
            checkBoxOktmo.Location = new Point(6, 109);
            checkBoxOktmo.Name = "checkBoxOktmo";
            checkBoxOktmo.Size = new Size(68, 19);
            checkBoxOktmo.TabIndex = 0;
            checkBoxOktmo.Text = "ОКТМО";
            checkBoxOktmo.UseVisualStyleBackColor = true;
            checkBoxOktmo.CheckedChanged += checkBoxOktmo_CheckedChanged;
            // 
            // checkBoxDocOsn
            // 
            checkBoxDocOsn.AutoSize = true;
            checkBoxDocOsn.Location = new Point(6, 80);
            checkBoxDocOsn.Name = "checkBoxDocOsn";
            checkBoxDocOsn.Size = new Size(87, 19);
            checkBoxDocOsn.TabIndex = 0;
            checkBoxDocOsn.Text = "Основание";
            checkBoxDocOsn.UseVisualStyleBackColor = true;
            checkBoxDocOsn.CheckedChanged += checkBoxDocOsn_CheckedChanged;
            // 
            // checkBoxPokazatel
            // 
            checkBoxPokazatel.AutoSize = true;
            checkBoxPokazatel.Location = new Point(6, 51);
            checkBoxPokazatel.Name = "checkBoxPokazatel";
            checkBoxPokazatel.Size = new Size(89, 19);
            checkBoxPokazatel.TabIndex = 0;
            checkBoxPokazatel.Text = "Показатель";
            checkBoxPokazatel.UseVisualStyleBackColor = true;
            checkBoxPokazatel.CheckedChanged += checkBoxPokazatel_CheckedChanged;
            // 
            // checkBoxKbk
            // 
            checkBoxKbk.AutoSize = true;
            checkBoxKbk.Location = new Point(6, 22);
            checkBoxKbk.Name = "checkBoxKbk";
            checkBoxKbk.Size = new Size(47, 19);
            checkBoxKbk.TabIndex = 0;
            checkBoxKbk.Text = "КБК";
            checkBoxKbk.UseVisualStyleBackColor = true;
            checkBoxKbk.CheckedChanged += checkBoxKbk_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 272);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 272);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form_filter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 327);
            ControlBox = false;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form_filter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Фильтр";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerStart;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ComboBox comboBoxKbk;
        private CheckBox checkBoxKpp;
        private CheckBox checkBoxOktmo;
        private CheckBox checkBoxDocOsn;
        private CheckBox checkBoxPokazatel;
        private CheckBox checkBoxKbk;
        private Button button1;
        private ComboBox comboBoxKpp;
        private ComboBox comboBoxOktmo;
        private ComboBox comboBoxDocOsn;
        private ComboBox comboBoxPokazatel;
        private Button button2;
    }
}