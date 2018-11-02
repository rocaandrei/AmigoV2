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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowSchedule));
            this.ScheduleTabControl = new System.Windows.Forms.TabControl();
            this.CalendarTabPage = new System.Windows.Forms.TabPage();
            this.ScheduleEngineersDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ScheduleTabControl.SuspendLayout();
            this.CalendarTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleEngineersDataGridView)).BeginInit();
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
            this.ScheduleTabControl.Size = new System.Drawing.Size(1025, 575);
            this.ScheduleTabControl.TabIndex = 0;
            // 
            // CalendarTabPage
            // 
            this.CalendarTabPage.Controls.Add(this.ScheduleEngineersDataGridView);
            this.CalendarTabPage.Location = new System.Drawing.Point(4, 25);
            this.CalendarTabPage.Name = "CalendarTabPage";
            this.CalendarTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CalendarTabPage.Size = new System.Drawing.Size(1017, 546);
            this.CalendarTabPage.TabIndex = 0;
            this.CalendarTabPage.Text = "Calendar";
            this.CalendarTabPage.UseVisualStyleBackColor = true;
            // 
            // ScheduleEngineersDataGridView
            // 
            this.ScheduleEngineersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ScheduleEngineersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ScheduleEngineersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleEngineersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScheduleEngineersDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ScheduleEngineersDataGridView.Name = "ScheduleEngineersDataGridView";
            this.ScheduleEngineersDataGridView.RowTemplate.Height = 24;
            this.ScheduleEngineersDataGridView.Size = new System.Drawing.Size(1011, 540);
            this.ScheduleEngineersDataGridView.TabIndex = 0;
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
            // ShowSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 575);
            this.Controls.Add(this.ScheduleTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowSchedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.ShowSchedule_Load);
            this.ScheduleTabControl.ResumeLayout(false);
            this.CalendarTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleEngineersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ScheduleTabControl;
        private System.Windows.Forms.TabPage CalendarTabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ScheduleEngineersDataGridView;
    }
}