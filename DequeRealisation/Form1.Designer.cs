namespace DequeRealisation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.grbStatistics = new System.Windows.Forms.GroupBox();
            this.dataGridViewStatistics = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.grbProperties = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDel2 = new System.Windows.Forms.TextBox();
            this.tbAdd2 = new System.Windows.Forms.TextBox();
            this.tbDel1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAdd1 = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnLimit = new System.Windows.Forms.RadioButton();
            this.rbtnInfinity = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.grbDeque = new System.Windows.Forms.GroupBox();
            this.dataGridViewDeque = new System.Windows.Forms.DataGridView();
            this.grbStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).BeginInit();
            this.grbProperties.SuspendLayout();
            this.grbDeque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeque)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(787, 314);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(35, 32);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.White;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.Location = new System.Drawing.Point(706, 314);
            this.btnPause.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(34, 32);
            this.btnPause.TabIndex = 25;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // grbStatistics
            // 
            this.grbStatistics.BackColor = System.Drawing.SystemColors.Control;
            this.grbStatistics.Controls.Add(this.dataGridViewStatistics);
            this.grbStatistics.Location = new System.Drawing.Point(12, 365);
            this.grbStatistics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbStatistics.Name = "grbStatistics";
            this.grbStatistics.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbStatistics.Size = new System.Drawing.Size(820, 179);
            this.grbStatistics.TabIndex = 21;
            this.grbStatistics.TabStop = false;
            this.grbStatistics.Text = "Статистика";
            // 
            // dataGridViewStatistics
            // 
            this.dataGridViewStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStatistics.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewStatistics.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewStatistics.Location = new System.Drawing.Point(11, 21);
            this.dataGridViewStatistics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewStatistics.Name = "dataGridViewStatistics";
            this.dataGridViewStatistics.Size = new System.Drawing.Size(803, 108);
            this.dataGridViewStatistics.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Количество добавленных элементов слева";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Количество добавленных элементов справа";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Количество удаленных элементов слева";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Количество удаленных элементов справа";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Количество отказов";
            this.Column5.Name = "Column5";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(746, 314);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(35, 32);
            this.btnStop.TabIndex = 26;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.White;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(666, 314);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(34, 32);
            this.btnPlay.TabIndex = 24;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 318);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(635, 28);
            this.progressBar1.TabIndex = 23;
            // 
            // grbProperties
            // 
            this.grbProperties.BackColor = System.Drawing.SystemColors.Control;
            this.grbProperties.Controls.Add(this.label5);
            this.grbProperties.Controls.Add(this.label6);
            this.grbProperties.Controls.Add(this.tbDel2);
            this.grbProperties.Controls.Add(this.tbAdd2);
            this.grbProperties.Controls.Add(this.tbDel1);
            this.grbProperties.Controls.Add(this.label4);
            this.grbProperties.Controls.Add(this.label3);
            this.grbProperties.Controls.Add(this.tbAdd1);
            this.grbProperties.Controls.Add(this.tbTime);
            this.grbProperties.Controls.Add(this.label2);
            this.grbProperties.Controls.Add(this.rbtnLimit);
            this.grbProperties.Controls.Add(this.rbtnInfinity);
            this.grbProperties.Controls.Add(this.label1);
            this.grbProperties.Controls.Add(this.tbSize);
            this.grbProperties.Location = new System.Drawing.Point(12, 39);
            this.grbProperties.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbProperties.Name = "grbProperties";
            this.grbProperties.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbProperties.Size = new System.Drawing.Size(820, 169);
            this.grbProperties.TabIndex = 22;
            this.grbProperties.TabStop = false;
            this.grbProperties.Text = "Свойства";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "±";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(718, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "±";
            // 
            // tbDel2
            // 
            this.tbDel2.Location = new System.Drawing.Point(738, 136);
            this.tbDel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDel2.Name = "tbDel2";
            this.tbDel2.Size = new System.Drawing.Size(45, 20);
            this.tbDel2.TabIndex = 22;
            // 
            // tbAdd2
            // 
            this.tbAdd2.Location = new System.Drawing.Point(457, 136);
            this.tbAdd2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAdd2.Name = "tbAdd2";
            this.tbAdd2.Size = new System.Drawing.Size(45, 20);
            this.tbAdd2.TabIndex = 21;
            // 
            // tbDel1
            // 
            this.tbDel1.Location = new System.Drawing.Point(665, 136);
            this.tbDel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDel1.Name = "tbDel1";
            this.tbDel1.Size = new System.Drawing.Size(47, 20);
            this.tbDel1.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(538, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Диапазон удаления";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(255, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Диапазон добавления";
            // 
            // tbAdd1
            // 
            this.tbAdd1.Location = new System.Drawing.Point(384, 136);
            this.tbAdd1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbAdd1.Name = "tbAdd1";
            this.tbAdd1.Size = new System.Drawing.Size(47, 20);
            this.tbAdd1.TabIndex = 17;
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(113, 136);
            this.tbTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(116, 20);
            this.tbTime.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(23, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Введите время";
            // 
            // rbtnLimit
            // 
            this.rbtnLimit.AutoSize = true;
            this.rbtnLimit.Location = new System.Drawing.Point(13, 35);
            this.rbtnLimit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnLimit.Name = "rbtnLimit";
            this.rbtnLimit.Size = new System.Drawing.Size(216, 17);
            this.rbtnLimit.TabIndex = 14;
            this.rbtnLimit.TabStop = true;
            this.rbtnLimit.Text = "Ограниченное количество элементов";
            this.rbtnLimit.UseVisualStyleBackColor = true;
            this.rbtnLimit.CheckedChanged += new System.EventHandler(this.rbtnLimit_CheckedChanged);
            // 
            // rbtnInfinity
            // 
            this.rbtnInfinity.AutoSize = true;
            this.rbtnInfinity.Location = new System.Drawing.Point(334, 35);
            this.rbtnInfinity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnInfinity.Name = "rbtnInfinity";
            this.rbtnInfinity.Size = new System.Drawing.Size(228, 17);
            this.rbtnInfinity.TabIndex = 13;
            this.rbtnInfinity.TabStop = true;
            this.rbtnInfinity.Text = "Неограниченное количество элементов";
            this.rbtnInfinity.UseVisualStyleBackColor = true;
            this.rbtnInfinity.CheckedChanged += new System.EventHandler(this.rbtnInfinity_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Размерность двусвязной очереди";
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(216, 69);
            this.tbSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(116, 20);
            this.tbSize.TabIndex = 7;
            // 
            // grbDeque
            // 
            this.grbDeque.BackColor = System.Drawing.SystemColors.Control;
            this.grbDeque.Controls.Add(this.dataGridViewDeque);
            this.grbDeque.Location = new System.Drawing.Point(12, 216);
            this.grbDeque.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDeque.Name = "grbDeque";
            this.grbDeque.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDeque.Size = new System.Drawing.Size(820, 90);
            this.grbDeque.TabIndex = 20;
            this.grbDeque.TabStop = false;
            this.grbDeque.Text = "Двусвязная очередь";
            // 
            // dataGridViewDeque
            // 
            this.dataGridViewDeque.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDeque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeque.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewDeque.Location = new System.Drawing.Point(7, 17);
            this.dataGridViewDeque.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewDeque.Name = "dataGridViewDeque";
            this.dataGridViewDeque.Size = new System.Drawing.Size(782, 65);
            this.dataGridViewDeque.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(848, 557);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.grbStatistics);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.grbProperties);
            this.Controls.Add(this.grbDeque);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).EndInit();
            this.grbProperties.ResumeLayout(false);
            this.grbProperties.PerformLayout();
            this.grbDeque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.GroupBox grbStatistics;
        private System.Windows.Forms.DataGridView dataGridViewStatistics;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox grbProperties;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDel2;
        private System.Windows.Forms.TextBox tbAdd2;
        private System.Windows.Forms.TextBox tbDel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAdd1;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnLimit;
        private System.Windows.Forms.RadioButton rbtnInfinity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.GroupBox grbDeque;
        private System.Windows.Forms.DataGridView dataGridViewDeque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

