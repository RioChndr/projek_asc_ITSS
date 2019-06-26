namespace PC_08
{
    partial class schedule_form
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
            this.examiner = new PC_08.examiner();
            this.examinerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pC_08DataSet3 = new PC_08.PC_08DataSet3();
            this.getexaminerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_examinerTableAdapter = new PC_08.PC_08DataSet3TableAdapters.get_examinerTableAdapter();
            this.pC_08DataSet = new PC_08.PC_08DataSet();
            this.typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typesTableAdapter = new PC_08.PC_08DataSetTableAdapters.typesTableAdapter();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new PC_08.PC_08DataSetTableAdapters.roomsTableAdapter();
            this.casesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casesTableAdapter = new PC_08.PC_08DataSetTableAdapters.casesTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Participant = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.usersTableAdapter = new PC_08.PC_08DataSetTableAdapters.usersTableAdapter();
            this.pC_08DataSet1 = new PC_08.PC_08DataSet();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.schedulesTableAdapter = new PC_08.PC_08DataSetTableAdapters.schedulesTableAdapter();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.examiner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examinerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC_08DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getexaminerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC_08DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Participant.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC_08DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // examiner
            // 
            this.examiner.DataSetName = "examiner";
            this.examiner.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examinerBindingSource
            // 
            this.examinerBindingSource.DataSource = this.examiner;
            this.examinerBindingSource.Position = 0;
            // 
            // pC_08DataSet3
            // 
            this.pC_08DataSet3.DataSetName = "PC_08DataSet3";
            this.pC_08DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getexaminerBindingSource
            // 
            this.getexaminerBindingSource.DataMember = "get_examiner";
            this.getexaminerBindingSource.DataSource = this.pC_08DataSet3;
            // 
            // get_examinerTableAdapter
            // 
            this.get_examinerTableAdapter.ClearBeforeFill = true;
            // 
            // pC_08DataSet
            // 
            this.pC_08DataSet.DataSetName = "PC_08DataSet";
            this.pC_08DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typesBindingSource
            // 
            this.typesBindingSource.DataMember = "types";
            this.typesBindingSource.DataSource = this.pC_08DataSet;
            // 
            // typesTableAdapter
            // 
            this.typesTableAdapter.ClearBeforeFill = true;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "rooms";
            this.roomsBindingSource.DataSource = this.pC_08DataSet;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // casesBindingSource
            // 
            this.casesBindingSource.DataMember = "cases";
            this.casesBindingSource.DataSource = this.pC_08DataSet;
            // 
            // casesTableAdapter
            // 
            this.casesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 373);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scheduler";
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(356, 270);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "cancel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(356, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(275, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(275, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(392, 125);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 330);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Case";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.casesBindingSource;
            this.comboBox4.DisplayMember = "code";
            this.comboBox4.Enabled = false;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(109, 294);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 16;
            this.comboBox4.ValueMember = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Room";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.roomsBindingSource;
            this.comboBox3.DisplayMember = "code";
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(109, 256);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 14;
            this.comboBox3.ValueMember = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Type";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.typesBindingSource;
            this.comboBox2.DisplayMember = "name";
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(109, 217);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.ValueMember = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Examiner";
            // 
            // Participant
            // 
            this.Participant.Controls.Add(this.button8);
            this.Participant.Controls.Add(this.button7);
            this.Participant.Controls.Add(this.groupBox2);
            this.Participant.Controls.Add(this.dataGridView2);
            this.Participant.Location = new System.Drawing.Point(514, 22);
            this.Participant.Name = "Participant";
            this.Participant.Size = new System.Drawing.Size(378, 373);
            this.Participant.TabIndex = 11;
            this.Participant.TabStop = false;
            this.Participant.Text = "Participant";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.comboBox5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(7, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Participant";
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.usersBindingSource;
            this.comboBox5.DisplayMember = "name";
            this.comboBox5.Enabled = false;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(96, 24);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 1;
            this.comboBox5.ValueMember = "id";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.pC_08DataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Participant";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 33);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(356, 125);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // pC_08DataSet1
            // 
            this.pC_08DataSet1.DataSetName = "PC_08DataSet";
            this.pC_08DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.pC_08DataSet1;
            this.usersBindingSource1.CurrentChanged += new System.EventHandler(this.usersBindingSource1_CurrentChanged);
            // 
            // schedulesTableAdapter
            // 
            this.schedulesTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "users";
            this.usersBindingSource2.DataSource = this.pC_08DataSet1;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.usersBindingSource2;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.ValueMember = "id";
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(247, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "add";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(7, 256);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(164, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = "Delete Selected Participant";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(199, 256);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(164, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "Delete All Participant";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // schedule_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 438);
            this.Controls.Add(this.Participant);
            this.Controls.Add(this.groupBox1);
            this.Name = "schedule_form";
            this.Text = "schedule_form";
            this.Load += new System.EventHandler(this.schedule_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examiner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examinerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC_08DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getexaminerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC_08DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Participant.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC_08DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource examinerBindingSource;
        private examiner examiner;
        private PC_08DataSet3 pC_08DataSet3;
        private System.Windows.Forms.BindingSource getexaminerBindingSource;
        private PC_08DataSet3TableAdapters.get_examinerTableAdapter get_examinerTableAdapter;
        private PC_08DataSet pC_08DataSet;
        private System.Windows.Forms.BindingSource typesBindingSource;
        private PC_08DataSetTableAdapters.typesTableAdapter typesTableAdapter;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private PC_08DataSetTableAdapters.roomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.BindingSource casesBindingSource;
        private PC_08DataSetTableAdapters.casesTableAdapter casesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Participant;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private PC_08DataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private PC_08DataSet pC_08DataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private PC_08DataSetTableAdapters.schedulesTableAdapter schedulesTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
    }
}