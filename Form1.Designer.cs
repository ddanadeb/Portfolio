namespace ProjekatRezervacije
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.hotelDataSet1 = new ProjekatRezervacije.HotelDataSet();
            this.tableRezTableAdapter1 = new ProjekatRezervacije.HotelDataSetTableAdapters.TableRezTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jMBGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojSobeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipSobeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojRezervacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableRezBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbUkupno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRezBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelDataSet1
            // 
            this.hotelDataSet1.DataSetName = "HotelDataSet";
            this.hotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableRezTableAdapter1
            // 
            this.tableRezTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.jMBGDataGridViewTextBoxColumn,
            this.brojSobeDataGridViewTextBoxColumn,
            this.tipSobeDataGridViewTextBoxColumn,
            this.brojRezervacijeDataGridViewTextBoxColumn,
            this.dateInDataGridViewTextBoxColumn,
            this.dateOutDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableRezBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1096, 198);
            this.dataGridView1.TabIndex = 0;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.Width = 125;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // jMBGDataGridViewTextBoxColumn
            // 
            this.jMBGDataGridViewTextBoxColumn.DataPropertyName = "JMBG";
            this.jMBGDataGridViewTextBoxColumn.HeaderText = "JMBG";
            this.jMBGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jMBGDataGridViewTextBoxColumn.Name = "jMBGDataGridViewTextBoxColumn";
            this.jMBGDataGridViewTextBoxColumn.Width = 125;
            // 
            // brojSobeDataGridViewTextBoxColumn
            // 
            this.brojSobeDataGridViewTextBoxColumn.DataPropertyName = "BrojSobe";
            this.brojSobeDataGridViewTextBoxColumn.HeaderText = "BrojSobe";
            this.brojSobeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brojSobeDataGridViewTextBoxColumn.Name = "brojSobeDataGridViewTextBoxColumn";
            this.brojSobeDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipSobeDataGridViewTextBoxColumn
            // 
            this.tipSobeDataGridViewTextBoxColumn.DataPropertyName = "TipSobe";
            this.tipSobeDataGridViewTextBoxColumn.HeaderText = "TipSobe";
            this.tipSobeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipSobeDataGridViewTextBoxColumn.Name = "tipSobeDataGridViewTextBoxColumn";
            this.tipSobeDataGridViewTextBoxColumn.Width = 125;
            // 
            // brojRezervacijeDataGridViewTextBoxColumn
            // 
            this.brojRezervacijeDataGridViewTextBoxColumn.DataPropertyName = "BrojRezervacije";
            this.brojRezervacijeDataGridViewTextBoxColumn.HeaderText = "BrojRezervacije";
            this.brojRezervacijeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brojRezervacijeDataGridViewTextBoxColumn.Name = "brojRezervacijeDataGridViewTextBoxColumn";
            this.brojRezervacijeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateInDataGridViewTextBoxColumn
            // 
            this.dateInDataGridViewTextBoxColumn.DataPropertyName = "DateIn";
            this.dateInDataGridViewTextBoxColumn.HeaderText = "DateIn";
            this.dateInDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateInDataGridViewTextBoxColumn.Name = "dateInDataGridViewTextBoxColumn";
            this.dateInDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateOutDataGridViewTextBoxColumn
            // 
            this.dateOutDataGridViewTextBoxColumn.DataPropertyName = "DateOut";
            this.dateOutDataGridViewTextBoxColumn.HeaderText = "DateOut";
            this.dateOutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOutDataGridViewTextBoxColumn.Name = "dateOutDataGridViewTextBoxColumn";
            this.dateOutDataGridViewTextBoxColumn.Width = 125;
            // 
            // tableRezBindingSource
            // 
            this.tableRezBindingSource.DataMember = "TableRez";
            this.tableRezBindingSource.DataSource = this.hotelDataSet1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ukupno rezervisanih soba:";
            // 
            // tbUkupno
            // 
            this.tbUkupno.Location = new System.Drawing.Point(392, 246);
            this.tbUkupno.Name = "tbUkupno";
            this.tbUkupno.ReadOnly = true;
            this.tbUkupno.Size = new System.Drawing.Size(100, 22);
            this.tbUkupno.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1120, 564);
            this.Controls.Add(this.tbUkupno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRezBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDataSet hotelDataSet1;
        private HotelDataSetTableAdapters.TableRezTableAdapter tableRezTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jMBGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojSobeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipSobeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojRezervacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tableRezBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUkupno;
    }
}

