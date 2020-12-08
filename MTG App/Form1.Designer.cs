
namespace MTG_App
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtExpansion = new System.Windows.Forms.TextBox();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTextbox = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdoExpansion = new System.Windows.Forms.RadioButton();
            this.rdoType = new System.Windows.Forms.RadioButton();
            this.rdoName = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Expansion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Power";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(124, 72);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(183, 20);
            this.txtCost.TabIndex = 6;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(124, 130);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(183, 20);
            this.txtType.TabIndex = 7;
            // 
            // txtExpansion
            // 
            this.txtExpansion.Location = new System.Drawing.Point(124, 191);
            this.txtExpansion.Name = "txtExpansion";
            this.txtExpansion.Size = new System.Drawing.Size(183, 20);
            this.txtExpansion.TabIndex = 8;
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(124, 247);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(183, 20);
            this.txtPower.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 470);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 307);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(326, 18);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(326, 65);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(326, 109);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(326, 154);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Textbox";
            // 
            // txtTextbox
            // 
            this.txtTextbox.Location = new System.Drawing.Point(78, 305);
            this.txtTextbox.Multiline = true;
            this.txtTextbox.Name = "txtTextbox";
            this.txtTextbox.Size = new System.Drawing.Size(229, 145);
            this.txtTextbox.TabIndex = 16;
            // 
            // btnQuit
            // 
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQuit.Location = new System.Drawing.Point(326, 427);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 18;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.rdoExpansion);
            this.groupBox1.Controls.Add(this.rdoType);
            this.groupBox1.Controls.Add(this.rdoName);
            this.groupBox1.Location = new System.Drawing.Point(407, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 91);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(16, 63);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(325, 20);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // rdoExpansion
            // 
            this.rdoExpansion.AutoSize = true;
            this.rdoExpansion.Location = new System.Drawing.Point(242, 24);
            this.rdoExpansion.Name = "rdoExpansion";
            this.rdoExpansion.Size = new System.Drawing.Size(74, 17);
            this.rdoExpansion.TabIndex = 2;
            this.rdoExpansion.TabStop = true;
            this.rdoExpansion.Text = "Expansion";
            this.rdoExpansion.UseVisualStyleBackColor = true;
            // 
            // rdoType
            // 
            this.rdoType.AutoSize = true;
            this.rdoType.Location = new System.Drawing.Point(139, 24);
            this.rdoType.Name = "rdoType";
            this.rdoType.Size = new System.Drawing.Size(49, 17);
            this.rdoType.TabIndex = 1;
            this.rdoType.TabStop = true;
            this.rdoType.Text = "Type";
            this.rdoType.UseVisualStyleBackColor = true;
            // 
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.Location = new System.Drawing.Point(25, 24);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(53, 17);
            this.rdoName.TabIndex = 0;
            this.rdoName.TabStop = true;
            this.rdoName.Text = "Name";
            this.rdoName.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 789);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.txtTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPower);
            this.Controls.Add(this.txtExpansion);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtExpansion;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTextbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdoExpansion;
        private System.Windows.Forms.RadioButton rdoType;
        private System.Windows.Forms.RadioButton rdoName;
    }
}

