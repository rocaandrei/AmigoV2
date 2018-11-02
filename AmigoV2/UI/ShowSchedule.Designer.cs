namespace AmigoV2.UI
{
    partial class ShowSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowSchedule));
            this.ScheduleTabControl = new System.Windows.Forms.TabControl();
            this.CalendarTabPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ScheduleTabControl.SuspendLayout();
            this.CalendarTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ScheduleTabControl
            // 
            this.ScheduleTabControl.Controls.Add(this.CalendarTabPage);
            this.ScheduleTabControl.Controls.Add(this.tabPage2);
            this.ScheduleTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScheduleTabControl.Location = new System.Drawing.Point(0, 0);
            this.ScheduleTabControl.Name = "ScheduleTabControl";
            this.ScheduleTabControl.SelectedIndex = 0;
            this.ScheduleTabControl.Size = new System.Drawing.Size(758, 475);
            this.ScheduleTabControl.TabIndex = 0;
            // 
            // CalendarTabPage
            // 
            this.CalendarTabPage.Controls.Add(this.dataGridView1);
            this.CalendarTabPage.Location = new System.Drawing.Point(4, 25);
            this.CalendarTabPage.Name = "CalendarTabPage";
            this.CalendarTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CalendarTabPage.Size = new System.Drawing.Size(750, 446);
            this.CalendarTabPage.TabIndex = 0;
            this.CalendarTabPage.Text = "Calendar";
            this.CalendarTabPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(750, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(744, 440);
            this.dataGridView1.TabIndex = 0;
            // 
            // ShowSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 475);
            this.Controls.Add(this.ScheduleTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowSchedule";
            this.Text = "Schedule";
            this.ScheduleTabControl.ResumeLayout(false);
            this.CalendarTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ScheduleTabControl;
        private System.Windows.Forms.TabPage CalendarTabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}