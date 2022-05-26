
namespace Exepabd
{
    partial class Form3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mahasiswaCobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodiTIDataSet = new Exepabd.ProdiTIDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.mahasiswa_CobaTableAdapter = new Exepabd.ProdiTIDataSetTableAdapters.Mahasiswa_CobaTableAdapter();
            this.pRODIDataSet = new Exepabd.PRODIDataSet();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaTableAdapter = new Exepabd.PRODIDataSetTableAdapters.mahasiswaTableAdapter();
            this.nimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namamahasiswaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeniskelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgllahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idprodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaCobaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nimDataGridViewTextBoxColumn,
            this.namamahasiswaDataGridViewTextBoxColumn,
            this.jeniskelDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.tgllahirDataGridViewTextBoxColumn,
            this.idprodiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mahasiswaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(153, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(821, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // mahasiswaCobaBindingSource
            // 
            this.mahasiswaCobaBindingSource.DataMember = "Mahasiswa_Coba";
            this.mahasiswaCobaBindingSource.DataSource = this.prodiTIDataSet;
            // 
            // prodiTIDataSet
            // 
            this.prodiTIDataSet.DataSetName = "ProdiTIDataSet";
            this.prodiTIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Montserrat Subrayada", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Mahasiswa";
            // 
            // mahasiswa_CobaTableAdapter
            // 
            this.mahasiswa_CobaTableAdapter.ClearBeforeFill = true;
            // 
            // pRODIDataSet
            // 
            this.pRODIDataSet.DataSetName = "PRODIDataSet";
            this.pRODIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.pRODIDataSet;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // nimDataGridViewTextBoxColumn
            // 
            this.nimDataGridViewTextBoxColumn.DataPropertyName = "nim";
            this.nimDataGridViewTextBoxColumn.HeaderText = "nim";
            this.nimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nimDataGridViewTextBoxColumn.Name = "nimDataGridViewTextBoxColumn";
            this.nimDataGridViewTextBoxColumn.Width = 125;
            // 
            // namamahasiswaDataGridViewTextBoxColumn
            // 
            this.namamahasiswaDataGridViewTextBoxColumn.DataPropertyName = "nama_mahasiswa";
            this.namamahasiswaDataGridViewTextBoxColumn.HeaderText = "nama_mahasiswa";
            this.namamahasiswaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namamahasiswaDataGridViewTextBoxColumn.Name = "namamahasiswaDataGridViewTextBoxColumn";
            this.namamahasiswaDataGridViewTextBoxColumn.Width = 125;
            // 
            // jeniskelDataGridViewTextBoxColumn
            // 
            this.jeniskelDataGridViewTextBoxColumn.DataPropertyName = "jenis_kel";
            this.jeniskelDataGridViewTextBoxColumn.HeaderText = "jenis_kel";
            this.jeniskelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jeniskelDataGridViewTextBoxColumn.Name = "jeniskelDataGridViewTextBoxColumn";
            this.jeniskelDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "alamat";
            this.alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.Width = 125;
            // 
            // tgllahirDataGridViewTextBoxColumn
            // 
            this.tgllahirDataGridViewTextBoxColumn.DataPropertyName = "tgl_lahir";
            this.tgllahirDataGridViewTextBoxColumn.HeaderText = "tgl_lahir";
            this.tgllahirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tgllahirDataGridViewTextBoxColumn.Name = "tgllahirDataGridViewTextBoxColumn";
            this.tgllahirDataGridViewTextBoxColumn.Width = 125;
            // 
            // idprodiDataGridViewTextBoxColumn
            // 
            this.idprodiDataGridViewTextBoxColumn.DataPropertyName = "id_prodi";
            this.idprodiDataGridViewTextBoxColumn.HeaderText = "id_prodi";
            this.idprodiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idprodiDataGridViewTextBoxColumn.Name = "idprodiDataGridViewTextBoxColumn";
            this.idprodiDataGridViewTextBoxColumn.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Exepabd.Properties.Resources.img_204972;
            this.pictureBox1.Location = new System.Drawing.Point(12, 368);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Exepabd.Properties.Resources.vapor;
            this.ClientSize = new System.Drawing.Size(1019, 499);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaCobaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private ProdiTIDataSet prodiTIDataSet;
        private System.Windows.Forms.BindingSource mahasiswaCobaBindingSource;
        private ProdiTIDataSetTableAdapters.Mahasiswa_CobaTableAdapter mahasiswa_CobaTableAdapter;
        private PRODIDataSet pRODIDataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private PRODIDataSetTableAdapters.mahasiswaTableAdapter mahasiswaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namamahasiswaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeniskelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgllahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodiDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}