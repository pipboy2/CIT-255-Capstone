using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace MTG_App
{
    public partial class Form1 : Form
    {
        SQLiteConnection myConnection = new SQLiteConnection(@"Data Source = C:\Users\pipbo\Desktop\Final Project 255\MTGDB.db");
      

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadData();
            InitButtons();
            StateTextboxes(false);
        }

        // --------
        // Buttons
        // --------

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            StateTextboxes(true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTextBoxs();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
            UpdateRecord(id);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // ----------
        // Tool Strip Menu
        //-----------

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridToTextBoxes();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int recordID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
            DeleteRecord(recordID);
            ReadData();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            StateTextboxes(true);
            DataGridToTextBoxes();

        }




        // ---------
        // Methods
        // ---------

        private void DeleteRecord(int recordID)
        {
            try
            {
                myConnection.Open();
                SQLiteCommand myCommand = new SQLiteCommand(myConnection);
                myCommand.CommandText = "DELETE FROM MTGDB WHERE ID=" + recordID;
                myCommand.ExecuteNonQuery();
                MessageBox.Show("The Record is deleted");
            }
            catch
            {
                MessageBox.Show("Can't connect to the database!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            finally
            {
                myConnection.Close();
            }

        }

        private void UpdateRecord(int id)
        {
            try
            {
                myConnection.Open();
                SQLiteCommand myCommand = new SQLiteCommand(myConnection);
                myCommand.CommandText = "UPDATE MTGDB SET Name='" + txtName.Text + "', Cost='" + txtCost.Text + "', Type= '" + txtType.Text + "', Expansion='" + txtExpansion.Text + "', Textbox='" + txtTextbox.Text + "', Power='" + txtPower.Text + "' WHERE ID=" + id;
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Data Updated.");
                ReadData();
                clearTextBoxs();
            }
            catch 
            {
                MessageBox.Show("Can't connect to the database!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            finally
            {
                myConnection.Close();
            }

        }

        private void InsertData()
        {
            try
            {
                myConnection.Open();
                SQLiteCommand myCommand = new SQLiteCommand(myConnection);
                myCommand.CommandText = " INSERT INTO MTGDB (Name, Cost, Type, Expansion, Textbox, Power) values ('" + txtName.Text + "', '" + txtCost.Text + "', '" + txtType.Text + "', '" + txtExpansion.Text + "', '" + txtTextbox.Text + "', '" + txtPower.Text + "')";
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Data Saved.");
                ReadData();
                clearTextBoxs();
            }
            catch 
            {
                MessageBox.Show("Can't connect to the database!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            finally
            {
                myConnection.Close();
            }

        }

        private void clearTextBoxs()
        {
            txtName.Text = "";
            txtCost.Text = "";
            txtType.Text = "";
            txtExpansion.Text = "";
            txtTextbox.Text = "";
            txtPower.Text = "";
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            StateTextboxes(false);
        }

        public void ReadData()
        {
            try
            {
                myConnection.Open();
                var datatable = new DataTable();
                string commandText = "SELECT * FROM MTGDB";
                SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(commandText, myConnection);
                myDataAdapter.Fill(datatable);
                dataGridView1.DataSource = datatable;
            }
            catch
            {
                MessageBox.Show("Can't connect to the database!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            finally
            {
                myConnection.Close();
                //MessageBox.Show("Connection Closed");
            }

        }

        private void InitButtons()
        {
            btnNew.Enabled = true;
            btnUpdate.Enabled = false;
            btnSave.Enabled = false;
        }

        public void StateTextboxes(bool state)
        {
            if (state == false)
            {
                txtName.Enabled = false;
            }
            else if (state == true)
            {
                txtName.Enabled = true;
            }

            if (state == false)
            {
                txtCost.Enabled = false;
            }
            else if (state == true)
            {
                txtCost.Enabled = true;
            }

            if (state == false)
            {
                txtType.Enabled = false;
            }
            else if (state == true)
            {
                txtType.Enabled = true;
            }

            if (state == false)
            {
                txtExpansion.Enabled = false;
            }
            else if (state == true)
            {
                txtExpansion.Enabled = true;
            }

            if (state == false)
            {
                txtTextbox.Enabled = false;
            }
            else if (state == true)
            {
                txtTextbox.Enabled = true;
            }

            if (state == false)
            {
                txtPower.Enabled = false;
            }
            else if (state == true)
            {
                txtPower.Enabled = true;
            }
        }

        private void DataGridToTextBoxes()
        {
            txtName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            txtCost.Text = dataGridView1.CurrentRow.Cells["Cost"].Value.ToString();
            txtType.Text = dataGridView1.CurrentRow.Cells["Type"].Value.ToString();
            txtExpansion.Text = dataGridView1.CurrentRow.Cells["Expansion"].Value.ToString();
            txtTextbox.Text = dataGridView1.CurrentRow.Cells["Textbox"].Value.ToString();
            txtPower.Text = dataGridView1.CurrentRow.Cells["Power"].Value.ToString();
            btnNew.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            StateTextboxes(true);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "";
            var datatable = new DataTable();
            try
            {
                // Building the query strings(s)
                if (rdoName.Checked)
                    query = "SELECT * FROM MTGDB WHERE Name LIKE '%" + txtSearch.Text + "%'";
                if (rdoType.Checked)
                    query = "SELECT * FROM MTGDB WHERE Type LIKE '%" + txtSearch.Text + "%'";
                if (rdoExpansion.Checked)
                    query = "SELECT * FROM MTGDB WHERE Expansion LIKE '%" + txtSearch.Text + "%'";
                myConnection.Open();
                SQLiteDataAdapter myDataAdapter = new SQLiteDataAdapter(query, myConnection);
                myDataAdapter.Fill(datatable);
                dataGridView1.DataSource = datatable;
                myConnection.Close();
            }
            catch (SQLiteException)
            {
                MessageBox.Show("Can't connect to the database!", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
    }
}
