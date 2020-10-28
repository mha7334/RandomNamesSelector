namespace RandomNamesSelector
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstNames = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtHowmany = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResetResult = new System.Windows.Forms.Button();
            this.btnResetNames = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.ItemHeight = 15;
            this.lstNames.Location = new System.Drawing.Point(53, 85);
            this.lstNames.Name = "lstNames";
            this.lstNames.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstNames.Size = new System.Drawing.Size(272, 334);
            this.lstNames.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(111, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(129, 23);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(53, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(246, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(365, 231);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 39);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Get Result";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtHowmany
            // 
            this.txtHowmany.Location = new System.Drawing.Point(356, 163);
            this.txtHowmany.Name = "txtHowmany";
            this.txtHowmany.Size = new System.Drawing.Size(100, 23);
            this.txtHowmany.TabIndex = 5;
            this.txtHowmany.Text = "9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "How many?";
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 15;
            this.lstResult.Location = new System.Drawing.Point(503, 85);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(236, 334);
            this.lstResult.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Result";
            // 
            // btnResetResult
            // 
            this.btnResetResult.Location = new System.Drawing.Point(503, 425);
            this.btnResetResult.Name = "btnResetResult";
            this.btnResetResult.Size = new System.Drawing.Size(75, 23);
            this.btnResetResult.TabIndex = 3;
            this.btnResetResult.Text = "Reset";
            this.btnResetResult.UseVisualStyleBackColor = true;
            this.btnResetResult.Click += new System.EventHandler(this.btnResetResult_Click);
            // 
            // btnResetNames
            // 
            this.btnResetNames.Location = new System.Drawing.Point(53, 425);
            this.btnResetNames.Name = "btnResetNames";
            this.btnResetNames.Size = new System.Drawing.Size(75, 23);
            this.btnResetNames.TabIndex = 3;
            this.btnResetNames.Text = "Reset";
            this.btnResetNames.UseVisualStyleBackColor = true;
            this.btnResetNames.Click += new System.EventHandler(this.btnResetNames_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Remove);
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Location = new System.Drawing.Point(246, 13);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(75, 23);
            this.btnLoadAll.TabIndex = 9;
            this.btnLoadAll.Text = "Load All";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.btnLoadAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnResetNames);
            this.Controls.Add(this.btnResetResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHowmany);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lstNames);
            this.Name = "Main";
            this.Text = "RandomNamesSelector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtHowmany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResetResult;
        private System.Windows.Forms.Button btnResetNames;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLoadAll;
    }
}

