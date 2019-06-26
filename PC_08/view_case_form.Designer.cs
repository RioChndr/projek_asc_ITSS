namespace PC_08
{
    partial class view_case_form
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
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.input_pertanyaan = new System.Windows.Forms.TextBox();
            this.input_a = new System.Windows.Forms.TextBox();
            this.input_b = new System.Windows.Forms.TextBox();
            this.input_c = new System.Windows.Forms.TextBox();
            this.input_d = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.combobox_answer = new System.Windows.Forms.ComboBox();
            this.button_first = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_for = new System.Windows.Forms.Button();
            this.button_end = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(552, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 47;
            this.button4.Text = "Cari";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(384, 506);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 46;
            this.button6.Text = "Cancel";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(282, 506);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 45;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 140);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(446, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Search By Creator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "View Case";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Question 1/5";
            // 
            // input_pertanyaan
            // 
            this.input_pertanyaan.Enabled = false;
            this.input_pertanyaan.Location = new System.Drawing.Point(32, 318);
            this.input_pertanyaan.Multiline = true;
            this.input_pertanyaan.Name = "input_pertanyaan";
            this.input_pertanyaan.Size = new System.Drawing.Size(595, 56);
            this.input_pertanyaan.TabIndex = 49;
            // 
            // input_a
            // 
            this.input_a.Enabled = false;
            this.input_a.Location = new System.Drawing.Point(71, 392);
            this.input_a.Name = "input_a";
            this.input_a.Size = new System.Drawing.Size(100, 20);
            this.input_a.TabIndex = 50;
            // 
            // input_b
            // 
            this.input_b.Enabled = false;
            this.input_b.Location = new System.Drawing.Point(71, 428);
            this.input_b.Name = "input_b";
            this.input_b.Size = new System.Drawing.Size(100, 20);
            this.input_b.TabIndex = 51;
            // 
            // input_c
            // 
            this.input_c.Enabled = false;
            this.input_c.Location = new System.Drawing.Point(262, 395);
            this.input_c.Name = "input_c";
            this.input_c.Size = new System.Drawing.Size(100, 20);
            this.input_c.TabIndex = 52;
            // 
            // input_d
            // 
            this.input_d.Enabled = false;
            this.input_d.Location = new System.Drawing.Point(262, 431);
            this.input_d.Name = "input_d";
            this.input_d.Size = new System.Drawing.Size(100, 20);
            this.input_d.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "D";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Answer";
            // 
            // combobox_answer
            // 
            this.combobox_answer.Enabled = false;
            this.combobox_answer.FormattingEnabled = true;
            this.combobox_answer.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.combobox_answer.Location = new System.Drawing.Point(446, 391);
            this.combobox_answer.Name = "combobox_answer";
            this.combobox_answer.Size = new System.Drawing.Size(121, 21);
            this.combobox_answer.TabIndex = 59;
            this.combobox_answer.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button_first
            // 
            this.button_first.Location = new System.Drawing.Point(123, 476);
            this.button_first.Name = "button_first";
            this.button_first.Size = new System.Drawing.Size(75, 23);
            this.button_first.TabIndex = 60;
            this.button_first.Text = "<<";
            this.button_first.UseVisualStyleBackColor = true;
            this.button_first.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_back
            // 
            this.button_back.Enabled = false;
            this.button_back.Location = new System.Drawing.Point(220, 477);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 61;
            this.button_back.Text = "<";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_for
            // 
            this.button_for.Enabled = false;
            this.button_for.Location = new System.Drawing.Point(319, 476);
            this.button_for.Name = "button_for";
            this.button_for.Size = new System.Drawing.Size(75, 23);
            this.button_for.TabIndex = 62;
            this.button_for.Text = ">";
            this.button_for.UseVisualStyleBackColor = true;
            this.button_for.Click += new System.EventHandler(this.button7_Click);
            // 
            // button_end
            // 
            this.button_end.Location = new System.Drawing.Point(423, 476);
            this.button_end.Name = "button_end";
            this.button_end.Size = new System.Drawing.Size(75, 23);
            this.button_end.TabIndex = 63;
            this.button_end.Text = ">>";
            this.button_end.UseVisualStyleBackColor = true;
            this.button_end.Click += new System.EventHandler(this.button8_Click);
            // 
            // view_case_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 550);
            this.Controls.Add(this.button_end);
            this.Controls.Add(this.button_for);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_first);
            this.Controls.Add(this.combobox_answer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_d);
            this.Controls.Add(this.input_c);
            this.Controls.Add(this.input_b);
            this.Controls.Add(this.input_a);
            this.Controls.Add(this.input_pertanyaan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "view_case_form";
            this.Text = "view_case_form";
            this.Load += new System.EventHandler(this.view_case_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_pertanyaan;
        private System.Windows.Forms.TextBox input_a;
        private System.Windows.Forms.TextBox input_b;
        private System.Windows.Forms.TextBox input_c;
        private System.Windows.Forms.TextBox input_d;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combobox_answer;
        private System.Windows.Forms.Button button_first;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_for;
        private System.Windows.Forms.Button button_end;
    }
}