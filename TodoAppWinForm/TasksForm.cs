using Npgsql;
using System.Data;

namespace TodoAppWinForm
{
    public partial class TasksForm : Form
    {
        DBConnection conn;
        DataSet ds;
        //BindingSource bindingSource;

        public TasksForm()
        {
            InitializeComponent();
            conn = new DBConnection();
            ds = new DataSet();

            SetupTable();
            FillTable();
        }

        void SetupTable()
        {
            tasksDataGridView.Columns[0].DataPropertyName = "task";
            tasksDataGridView.Columns[1].DataPropertyName = "is_done";
        }

        void FillTable()
        {
            string query = "SELECT * FROM tasks ORDER BY id ASC";

            ds = conn.ExecuteQueryRows(query);

            tasksDataGridView.AutoGenerateColumns = false;
            tasksDataGridView.DataSource = ds.Tables[0];

            //foreach (DataGridViewRow row in tasksDataGridView.Rows)
            //{
            //    DataRowView dataRow = (DataRowView) row.DataBoundItem;
            //    if ((bool)dataRow.Row.ItemArray[2])
            //    {
            //        row.Cells["status"].Value = "Done";
            //    } else
            //    {
            //        row.Cells["status"].Value = "Not Done";
            //        Console.WriteLine("uwu");
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (addTaskTextBox.Text != "")
            {
                string newTask = addTaskTextBox.Text;
                string query = "INSERT INTO public.tasks (task) VALUES (@task);";
                NpgsqlParameter[] queryParams = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@task", newTask)
                };
                bool isSuccess = conn.ExecuteNonQuery(query, queryParams);

                if (!isSuccess)
                {
                    MessageBox.Show("Terjadi kesalahan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    ClearTextBox();
                    FillTable();
                }
            }
        }

        private void ClearTextBox()
        {
            addTaskTextBox.Text = "";
        }

        private void tasksDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (e.RowIndex < 0)
            {
                return;
            }

            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                if (e.ColumnIndex == 2)
                {
                    var currentTask = ((DataRowView) tasksDataGridView.Rows[e.RowIndex].DataBoundItem).Row;

                    var currentTaskId = currentTask.ItemArray[0];

                    string query = "UPDATE public.tasks SET is_done = true WHERE id = @id ;";

                    NpgsqlParameter[] queryParams = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@id", currentTaskId)
                    };

                    bool isSuccess = conn.ExecuteNonQuery(query, queryParams);

                    if (!isSuccess)
                    {
                        MessageBox.Show("Terjadi kesalahan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FillTable();
                    }
                }

                if (e.ColumnIndex == 3)
                {
                    var currentTask = ((DataRowView)tasksDataGridView.Rows[e.RowIndex].DataBoundItem).Row;

                    var currentTaskId = currentTask.ItemArray[0];

                    string query = "DELETE FROM public.tasks WHERE id = @id ;";

                    NpgsqlParameter[] queryParams = new NpgsqlParameter[]
                    {
                        new NpgsqlParameter("@id", currentTaskId)
                    };

                    bool isSuccess = conn.ExecuteNonQuery(query, queryParams);

                    if (!isSuccess)
                    {
                        MessageBox.Show("Terjadi kesalahan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        FillTable();
                    }
                }
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var usersForm = new UsersForm();
            usersForm.ShowDialog();
        }
    }
}