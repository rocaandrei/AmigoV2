namespace AmigoV2
{
    partial class AddNewEngieer
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
            this.label4 = new System.Windows.Forms.Label();
            this.GenderTBAddForm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RoleTBAddForm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EngineersIDTBAddForm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTBAddForm = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Gender";
            // 
            // GenderTBAddForm
            // 
            this.GenderTBAddForm.Location = new System.Drawing.Point(89, 105);
            this.GenderTBAddForm.Name = "GenderTBAddForm";
            this.GenderTBAddForm.Size = new System.Drawing.Size(134, 20);
            this.GenderTBAddForm.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Role";
            // 
            // RoleTBAddForm
            // 
            this.RoleTBAddForm.Location = new System.Drawing.Point(89, 79);
            this.RoleTBAddForm.Name = "RoleTBAddForm";
            this.RoleTBAddForm.Size = new System.Drawing.Size(134, 20);
            this.RoleTBAddForm.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Engineers ID";
            // 
            // EngineersIDTBAddForm
            // 
            this.EngineersIDTBAddForm.Location = new System.Drawing.Point(89, 52);
            this.EngineersIDTBAddForm.Name = "EngineersIDTBAddForm";
            this.EngineersIDTBAddForm.Size = new System.Drawing.Size(134, 20);
            this.EngineersIDTBAddForm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // NameTBAddForm
            // 
            this.NameTBAddForm.Location = new System.Drawing.Point(89, 26);
            this.NameTBAddForm.Name = "NameTBAddForm";
            this.NameTBAddForm.Size = new System.Drawing.Size(134, 20);
            this.NameTBAddForm.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddButton.Location = new System.Drawing.Point(34, 144);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(162, 144);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // AddEngineer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 203);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GenderTBAddForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RoleTBAddForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EngineersIDTBAddForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTBAddForm);
            this.Name = "AddEngineer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Engineer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GenderTBAddForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RoleTBAddForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EngineersIDTBAddForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTBAddForm;
        private System.Windows.Forms.Button AddButton;
        private new System.Windows.Forms.Button CancelButton;
    }
}