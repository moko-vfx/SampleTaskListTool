namespace SampleDGV
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			this.BtnAdd = new System.Windows.Forms.Button();
			this.BtnDuplicate = new System.Windows.Forms.Button();
			this.BtnDelete = new System.Windows.Forms.Button();
			this.BtnFilterAll = new System.Windows.Forms.Button();
			this.BtnFilterNotDone = new System.Windows.Forms.Button();
			this.BtnFilterDone = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.カテゴリDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.内容DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.優先度DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.進捗DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.工数DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.taskDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.taskDataSet = new SampleDGV.TaskDataSet();
			this.CbPriority = new System.Windows.Forms.ComboBox();
			this.priorityDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.priorityDataSet = new SampleDGV.PriorityDataSet();
			this.CbStatus = new System.Windows.Forms.ComboBox();
			this.statusDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.statusDataSet = new SampleDGV.StatusDataSet();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.taskDataTableBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.taskDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.priorityDataTableBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.priorityDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusDataTableBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusDataSet)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// BtnAdd
			// 
			this.BtnAdd.Location = new System.Drawing.Point(20, 28);
			this.BtnAdd.Name = "BtnAdd";
			this.BtnAdd.Size = new System.Drawing.Size(62, 46);
			this.BtnAdd.TabIndex = 0;
			this.BtnAdd.Text = "Add";
			this.BtnAdd.UseVisualStyleBackColor = true;
			this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// BtnDuplicate
			// 
			this.BtnDuplicate.Location = new System.Drawing.Point(88, 28);
			this.BtnDuplicate.Name = "BtnDuplicate";
			this.BtnDuplicate.Size = new System.Drawing.Size(62, 46);
			this.BtnDuplicate.TabIndex = 0;
			this.BtnDuplicate.Text = "Duplicate";
			this.BtnDuplicate.UseVisualStyleBackColor = true;
			this.BtnDuplicate.Click += new System.EventHandler(this.BtnDuplicate_Click);
			// 
			// BtnDelete
			// 
			this.BtnDelete.Location = new System.Drawing.Point(156, 28);
			this.BtnDelete.Name = "BtnDelete";
			this.BtnDelete.Size = new System.Drawing.Size(62, 46);
			this.BtnDelete.TabIndex = 0;
			this.BtnDelete.Text = "Delete";
			this.BtnDelete.UseVisualStyleBackColor = true;
			this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// BtnFilterAll
			// 
			this.BtnFilterAll.ForeColor = System.Drawing.Color.Red;
			this.BtnFilterAll.Location = new System.Drawing.Point(20, 28);
			this.BtnFilterAll.Name = "BtnFilterAll";
			this.BtnFilterAll.Size = new System.Drawing.Size(62, 46);
			this.BtnFilterAll.TabIndex = 0;
			this.BtnFilterAll.Text = "すべて";
			this.BtnFilterAll.UseVisualStyleBackColor = true;
			this.BtnFilterAll.Click += new System.EventHandler(this.BtnFilterAll_Click);
			// 
			// BtnFilterNotDone
			// 
			this.BtnFilterNotDone.Location = new System.Drawing.Point(89, 28);
			this.BtnFilterNotDone.Name = "BtnFilterNotDone";
			this.BtnFilterNotDone.Size = new System.Drawing.Size(62, 46);
			this.BtnFilterNotDone.TabIndex = 0;
			this.BtnFilterNotDone.Text = "完了以外";
			this.BtnFilterNotDone.UseVisualStyleBackColor = true;
			this.BtnFilterNotDone.Click += new System.EventHandler(this.BtnFilterNotDone_Click);
			// 
			// BtnFilterDone
			// 
			this.BtnFilterDone.Location = new System.Drawing.Point(157, 28);
			this.BtnFilterDone.Name = "BtnFilterDone";
			this.BtnFilterDone.Size = new System.Drawing.Size(62, 46);
			this.BtnFilterDone.TabIndex = 0;
			this.BtnFilterDone.Text = "完了";
			this.BtnFilterDone.UseVisualStyleBackColor = true;
			this.BtnFilterDone.Click += new System.EventHandler(this.BtnFilterDone_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.カテゴリDataGridViewTextBoxColumn,
            this.内容DataGridViewTextBoxColumn,
            this.優先度DataGridViewTextBoxColumn,
            this.進捗DataGridViewTextBoxColumn,
            this.工数DataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.taskDataTableBindingSource;
			dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle19.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(203)))), ((int)(((byte)(180)))));
			dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle19;
			this.dataGridView1.Location = new System.Drawing.Point(12, 120);
			this.dataGridView1.Name = "dataGridView1";
			dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle20.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.Height = 21;
			this.dataGridView1.Size = new System.Drawing.Size(719, 321);
			this.dataGridView1.TabIndex = 1;
			// 
			// noDataGridViewTextBoxColumn
			// 
			this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.noDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
			this.noDataGridViewTextBoxColumn.HeaderText = "No";
			this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
			// 
			// カテゴリDataGridViewTextBoxColumn
			// 
			this.カテゴリDataGridViewTextBoxColumn.DataPropertyName = "カテゴリ";
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.カテゴリDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
			this.カテゴリDataGridViewTextBoxColumn.HeaderText = "カテゴリ";
			this.カテゴリDataGridViewTextBoxColumn.Name = "カテゴリDataGridViewTextBoxColumn";
			// 
			// 内容DataGridViewTextBoxColumn
			// 
			this.内容DataGridViewTextBoxColumn.DataPropertyName = "内容";
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.内容DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
			this.内容DataGridViewTextBoxColumn.HeaderText = "内容";
			this.内容DataGridViewTextBoxColumn.Name = "内容DataGridViewTextBoxColumn";
			// 
			// 優先度DataGridViewTextBoxColumn
			// 
			this.優先度DataGridViewTextBoxColumn.DataPropertyName = "優先度";
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.優先度DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
			this.優先度DataGridViewTextBoxColumn.HeaderText = "優先度";
			this.優先度DataGridViewTextBoxColumn.Name = "優先度DataGridViewTextBoxColumn";
			// 
			// 進捗DataGridViewTextBoxColumn
			// 
			this.進捗DataGridViewTextBoxColumn.DataPropertyName = "進捗";
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.進捗DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
			this.進捗DataGridViewTextBoxColumn.HeaderText = "進捗";
			this.進捗DataGridViewTextBoxColumn.Name = "進捗DataGridViewTextBoxColumn";
			// 
			// 工数DataGridViewTextBoxColumn
			// 
			this.工数DataGridViewTextBoxColumn.DataPropertyName = "工数";
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.工数DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
			this.工数DataGridViewTextBoxColumn.HeaderText = "工数";
			this.工数DataGridViewTextBoxColumn.Name = "工数DataGridViewTextBoxColumn";
			// 
			// taskDataTableBindingSource
			// 
			this.taskDataTableBindingSource.DataMember = "TaskDataTable";
			this.taskDataTableBindingSource.DataSource = this.taskDataSet;
			// 
			// taskDataSet
			// 
			this.taskDataSet.DataSetName = "TaskDataSet";
			this.taskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// CbPriority
			// 
			this.CbPriority.DataSource = this.priorityDataTableBindingSource;
			this.CbPriority.DisplayMember = "優先度";
			this.CbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbPriority.FormattingEnabled = true;
			this.CbPriority.Location = new System.Drawing.Point(236, 28);
			this.CbPriority.Name = "CbPriority";
			this.CbPriority.Size = new System.Drawing.Size(70, 20);
			this.CbPriority.TabIndex = 2;
			// 
			// priorityDataTableBindingSource
			// 
			this.priorityDataTableBindingSource.DataMember = "PriorityDataTable";
			this.priorityDataTableBindingSource.DataSource = this.priorityDataSet;
			// 
			// priorityDataSet
			// 
			this.priorityDataSet.DataSetName = "PriorityDataSet";
			this.priorityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// CbStatus
			// 
			this.CbStatus.DataSource = this.statusDataTableBindingSource;
			this.CbStatus.DisplayMember = "進捗";
			this.CbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbStatus.FormattingEnabled = true;
			this.CbStatus.Location = new System.Drawing.Point(327, 28);
			this.CbStatus.Name = "CbStatus";
			this.CbStatus.Size = new System.Drawing.Size(70, 20);
			this.CbStatus.TabIndex = 2;
			// 
			// statusDataTableBindingSource
			// 
			this.statusDataTableBindingSource.DataMember = "StatusDataTable";
			this.statusDataTableBindingSource.DataSource = this.statusDataSet;
			// 
			// statusDataSet
			// 
			this.statusDataSet.DataSetName = "StatusDataSet";
			this.statusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.BtnAdd);
			this.groupBox1.Controls.Add(this.CbStatus);
			this.groupBox1.Controls.Add(this.BtnDuplicate);
			this.groupBox1.Controls.Add(this.CbPriority);
			this.groupBox1.Controls.Add(this.BtnDelete);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(419, 93);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "リスト操作";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.BtnFilterAll);
			this.groupBox2.Controls.Add(this.BtnFilterNotDone);
			this.groupBox2.Controls.Add(this.BtnFilterDone);
			this.groupBox2.Location = new System.Drawing.Point(451, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(245, 93);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "フィルタリング";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(743, 453);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.taskDataTableBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.taskDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.priorityDataTableBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.priorityDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusDataTableBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusDataSet)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BtnAdd;
		private System.Windows.Forms.Button BtnDuplicate;
		private System.Windows.Forms.Button BtnDelete;
		private System.Windows.Forms.Button BtnFilterAll;
		private System.Windows.Forms.Button BtnFilterNotDone;
		private System.Windows.Forms.Button BtnFilterDone;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource taskDataTableBindingSource;
		private TaskDataSet taskDataSet;
		private System.Windows.Forms.ComboBox CbPriority;
		private System.Windows.Forms.ComboBox CbStatus;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.BindingSource priorityDataTableBindingSource;
		private PriorityDataSet priorityDataSet;
		private System.Windows.Forms.BindingSource statusDataTableBindingSource;
		private StatusDataSet statusDataSet;
		private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn カテゴリDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn 内容DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn 優先度DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn 進捗DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn 工数DataGridViewTextBoxColumn;
	}
}

