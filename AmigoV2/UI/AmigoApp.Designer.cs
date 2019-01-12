namespace AmigoV2
{
    partial class AmigoApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AmigoApp));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.SourceToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.ShowScheduleButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.FormTabPage = new System.Windows.Forms.TabPage();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.GenderTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RoleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EngineersIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeesListBox = new System.Windows.Forms.ListBox();
            this.tabPageGrid = new System.Windows.Forms.TabPage();
            this.EmployeesDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.FormTabPage.SuspendLayout();
            this.tabPageGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.SourceToolStripComboBox,
            this.toolStripSeparator4,
            this.toolStripLabel3,
            this.ShowScheduleButton,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(999, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 25);
            this.toolStripButton1.Text = "PreviousToolStripButton";
            this.toolStripButton1.Click += new System.EventHandler(this.OnClickMovePrevious_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 25);
            this.toolStripButton2.Text = "ForwordToolStripButton";
            this.toolStripButton2.Click += new System.EventHandler(this.OnClickMoveNext_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 25);
            this.toolStripButton3.Text = "Add";
            this.toolStripButton3.Click += new System.EventHandler(this.AddEngineer_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 25);
            this.toolStripButton4.Text = "Delete";
            this.toolStripButton4.Click += new System.EventHandler(this.DeleteEngineer_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(24, 25);
            this.toolStripButton5.Text = "Save";
            this.toolStripButton5.Click += new System.EventHandler(this.OnClickSave_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(61, 25);
            this.toolStripLabel2.Text = "Source: ";
            // 
            // SourceToolStripComboBox
            // 
            this.SourceToolStripComboBox.Items.AddRange(new object[] {
            "Objects",
            "DataSet"});
            this.SourceToolStripComboBox.Name = "SourceToolStripComboBox";
            this.SourceToolStripComboBox.Size = new System.Drawing.Size(160, 28);
            this.SourceToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.SourceToolStripComboBox_SelectedIndexChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(136, 25);
            this.toolStripLabel3.Text = "SHOW SCHEDULE:";
            // 
            // ShowScheduleButton
            // 
            this.ShowScheduleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ShowScheduleButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowScheduleButton.Image")));
            this.ShowScheduleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowScheduleButton.Name = "ShowScheduleButton";
            this.ShowScheduleButton.Size = new System.Drawing.Size(24, 25);
            this.ShowScheduleButton.Text = "Show Schedule";
            this.ShowScheduleButton.Click += new System.EventHandler(this.ShowScheduleButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.FormTabPage);
            this.tabControl.Controls.Add(this.tabPageGrid);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 28);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(999, 552);
            this.tabControl.TabIndex = 1;
            // 
            // FormTabPage
            // 
            this.FormTabPage.Controls.Add(this.UpdateButton);
            this.FormTabPage.Controls.Add(this.label4);
            this.FormTabPage.Controls.Add(this.GenderTextBox);
            this.FormTabPage.Controls.Add(this.label3);
            this.FormTabPage.Controls.Add(this.RoleTextBox);
            this.FormTabPage.Controls.Add(this.label2);
            this.FormTabPage.Controls.Add(this.EngineersIDTextBox);
            this.FormTabPage.Controls.Add(this.label1);
            this.FormTabPage.Controls.Add(this.NameTextBox);
            this.FormTabPage.Controls.Add(this.EmployeesListBox);
            this.FormTabPage.Location = new System.Drawing.Point(4, 25);
            this.FormTabPage.Margin = new System.Windows.Forms.Padding(4);
            this.FormTabPage.Name = "FormTabPage";
            this.FormTabPage.Padding = new System.Windows.Forms.Padding(4);
            this.FormTabPage.Size = new System.Drawing.Size(991, 523);
            this.FormTabPage.TabIndex = 0;
            this.FormTabPage.Text = "Form";
            this.FormTabPage.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateButton.Location = new System.Drawing.Point(412, 235);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(143, 56);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender";
            // 
            // GenderTextBox
            // 
            this.GenderTextBox.Location = new System.Drawing.Point(388, 161);
            this.GenderTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.GenderTextBox.Name = "GenderTextBox";
            this.GenderTextBox.Size = new System.Drawing.Size(255, 22);
            this.GenderTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Role";
            // 
            // RoleTextBox
            // 
            this.RoleTextBox.Location = new System.Drawing.Point(388, 129);
            this.RoleTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RoleTextBox.Name = "RoleTextBox";
            this.RoleTextBox.Size = new System.Drawing.Size(255, 22);
            this.RoleTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Engineers ID";
            // 
            // EngineersIDTextBox
            // 
            this.EngineersIDTextBox.Location = new System.Drawing.Point(388, 96);
            this.EngineersIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EngineersIDTextBox.Name = "EngineersIDTextBox";
            this.EngineersIDTextBox.ReadOnly = true;
            this.EngineersIDTextBox.Size = new System.Drawing.Size(255, 22);
            this.EngineersIDTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(388, 64);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(255, 22);
            this.NameTextBox.TabIndex = 0;
            // 
            // EmployeesListBox
            // 
            this.EmployeesListBox.FormattingEnabled = true;
            this.EmployeesListBox.ItemHeight = 16;
            this.EmployeesListBox.Location = new System.Drawing.Point(11, 64);
            this.EmployeesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeesListBox.Name = "EmployeesListBox";
            this.EmployeesListBox.Size = new System.Drawing.Size(249, 452);
            this.EmployeesListBox.TabIndex = 4;
            // 
            // tabPageGrid
            // 
            this.tabPageGrid.Controls.Add(this.EmployeesDataGridView);
            this.tabPageGrid.Location = new System.Drawing.Point(4, 25);
            this.tabPageGrid.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageGrid.Name = "tabPageGrid";
            this.tabPageGrid.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageGrid.Size = new System.Drawing.Size(991, 523);
            this.tabPageGrid.TabIndex = 1;
            this.tabPageGrid.Text = "Grid";
            this.tabPageGrid.UseVisualStyleBackColor = true;
            // 
            // EmployeesDataGridView
            // 
            this.EmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeesDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.EmployeesDataGridView.Location = new System.Drawing.Point(4, 4);
            this.EmployeesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeesDataGridView.Name = "EmployeesDataGridView";
            this.EmployeesDataGridView.Size = new System.Drawing.Size(983, 515);
            this.EmployeesDataGridView.TabIndex = 0;
            // 
            // AmigoApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 580);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AmigoApp";
            this.Text = "Weel of Fate - Amigo V2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.FormTabPage.ResumeLayout(false);
            this.FormTabPage.PerformLayout();
            this.tabPageGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage FormTabPage;
        private System.Windows.Forms.TabPage tabPageGrid;
        private System.Windows.Forms.DataGridView EmployeesDataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GenderTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RoleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EngineersIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ListBox EmployeesListBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox SourceToolStripComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton ShowScheduleButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

