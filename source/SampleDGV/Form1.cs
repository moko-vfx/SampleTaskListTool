using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleDGV
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// 表データの読み込み
			LoadTaskData();

			// プルダウンメニューを登録
			priorityDataSet.PriorityDataTable.AddPriorityDataTableRow("高");
			priorityDataSet.PriorityDataTable.AddPriorityDataTableRow("中");
			priorityDataSet.PriorityDataTable.AddPriorityDataTableRow("低");
			statusDataSet.StatusDataTable.AddStatusDataTableRow("未着手");
			statusDataSet.StatusDataTable.AddStatusDataTableRow("進行中");
			statusDataSet.StatusDataTable.AddStatusDataTableRow("待ち");
			statusDataSet.StatusDataTable.AddStatusDataTableRow("完了");

			// DataGridView上でNoとプルダウンの項目の列は編集不可にする
			dataGridView1.Columns[0].ReadOnly = true;
			dataGridView1.Columns[3].ReadOnly = true;
			dataGridView1.Columns[4].ReadOnly = true;
		}

		// 表データの読み込み
		private void LoadTaskData()
		{
			// 入力先のパス
			string path = @"SaveData.txt";

			string delimStr = ",";                      // 区切り文字
			char[] delimiter = delimStr.ToCharArray();  // 区切り文字をまとめる
			string[] strData;                           // 分解後の文字の入れ物
			string strLine;                             // 1行分のデータ

			// 入力設定
			StreamReader sr = new StreamReader(
				path,
				Encoding.Default);

			// 次の文字が読み込めなくなるまで続ける(Peekは良くない？)
			while (sr.Peek() >= 0)
			{
				// 1行読み込む
				strLine = sr.ReadLine();

				// 区切り文字で区切って配列に代入する
				strData = strLine.Split(delimiter);

				// 表に新しく行を追加して配列を各列に入れる
				taskDataSet.TaskDataTable.AddTaskDataTableRow(
											int.Parse(strData[0]),
											strData[1],
											strData[2],
											strData[3],
											strData[4],
											int.Parse(strData[5]));
			}
			sr.Close();
		}


		// ボタン：「Add」
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			// 登録Noを割り振る用
			int count = taskDataSet.TaskDataTable.Count;

			taskDataSet.TaskDataTable.AddTaskDataTableRow(
					count,					// No
					"",						// カテゴリ
					"",						// 内容
					this.CbPriority.Text,   // 優先度
					this.CbStatus.Text,		// 進捗
					1);						// 工数
		}

		// ボタン：「Dublocate」
		private void BtnDuplicate_Click(object sender, EventArgs e)
		{
			// 登録Noを割り振る用
			int count = taskDataSet.TaskDataTable.Count;

			taskDataSet.TaskDataTable.AddTaskDataTableRow(
					count,												// No
					dataGridView1.CurrentRow.Cells[1].Value.ToString(), // カテゴリ
					dataGridView1.CurrentRow.Cells[2].Value.ToString(), // 内容
					dataGridView1.CurrentRow.Cells[3].Value.ToString(),	// 優先度
					"未着手",											// 進捗
					(int)dataGridView1.CurrentRow.Cells[5].Value);		// 工数
		}

		// ボタン：「Delete」
		private void BtnDelete_Click(object sender, EventArgs e)
		{
			// 削除を実行
			this.dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

			// Noを振り直す
			int i = 0;
			foreach (DataRow r in taskDataSet.TaskDataTable.Rows)
			{
				r["No"] = i;
				i++;
			}
		}


		// ボタン：フィルタ「すべて」
		private void BtnFilterAll_Click(object sender, EventArgs e)
		{
			// タブの文字カラーを変える
			this.BtnFilterAll.ForeColor		= Color.Red;
			this.BtnFilterNotDone.ForeColor = Color.Black;
			this.BtnFilterDone.ForeColor	= Color.Black;

			// すべてのタスクを表示する
			taskDataTableBindingSource.Filter = null;
		}

		// ボタン：フィルタ「完了以外」
		private void BtnFilterNotDone_Click(object sender, EventArgs e)
		{
			// タブの文字カラーを変える
			this.BtnFilterAll.ForeColor		= Color.Black;
			this.BtnFilterNotDone.ForeColor = Color.Red;
			this.BtnFilterDone.ForeColor	= Color.Black;

			// フィルタ
			taskDataTableBindingSource.Filter = "進捗 <> '完了'";
		}

		// ボタン：フィルタ「完了」
		private void BtnFilterDone_Click(object sender, EventArgs e)
		{
			// タブの文字カラーを変える
			this.BtnFilterAll.ForeColor		= Color.Black;
			this.BtnFilterNotDone.ForeColor = Color.Black;
			this.BtnFilterDone.ForeColor	= Color.Red;

			// フィルタ
			taskDataTableBindingSource.Filter = "進捗 = '完了'";
		}
	}
}
