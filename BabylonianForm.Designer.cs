namespace BabylonianMethod
{
    partial class BabylonianMethodForm
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
            this.BabylonianDataGridView = new System.Windows.Forms.DataGridView();
            this.nColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qDividedByQnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.differenceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.qTextBox = new System.Windows.Forms.TextBox();
            this.SquareRootButton = new System.Windows.Forms.Button();
            this.SquareRootLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BabylonianDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BabylonianDataGridView
            // 
            this.BabylonianDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BabylonianDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BabylonianDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BabylonianDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nColumn,
            this.qn,
            this.qDividedByQnColumn,
            this.differenceColumn});
            this.BabylonianDataGridView.EnableHeadersVisualStyles = false;
            this.BabylonianDataGridView.Location = new System.Drawing.Point(12, 104);
            this.BabylonianDataGridView.Name = "BabylonianDataGridView";
            this.BabylonianDataGridView.ReadOnly = true;
            this.BabylonianDataGridView.RowHeadersVisible = false;
            this.BabylonianDataGridView.Size = new System.Drawing.Size(549, 283);
            this.BabylonianDataGridView.TabIndex = 0;
            // 
            // nColumn
            // 
            this.nColumn.HeaderText = "n";
            this.nColumn.Name = "nColumn";
            this.nColumn.ReadOnly = true;
            // 
            // qn
            // 
            this.qn.HeaderText = "qn";
            this.qn.Name = "qn";
            this.qn.ReadOnly = true;
            // 
            // qDividedByQnColumn
            // 
            this.qDividedByQnColumn.HeaderText = "q Divided by qn";
            this.qDividedByQnColumn.Name = "qDividedByQnColumn";
            this.qDividedByQnColumn.ReadOnly = true;
            // 
            // differenceColumn
            // 
            this.differenceColumn.HeaderText = "Difference (qn - q/qn)";
            this.differenceColumn.Name = "differenceColumn";
            this.differenceColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter any nonnegative value:";
            // 
            // qTextBox
            // 
            this.qTextBox.Location = new System.Drawing.Point(164, 25);
            this.qTextBox.Name = "qTextBox";
            this.qTextBox.Size = new System.Drawing.Size(220, 20);
            this.qTextBox.TabIndex = 2;
            // 
            // SquareRootButton
            // 
            this.SquareRootButton.Location = new System.Drawing.Point(390, 23);
            this.SquareRootButton.Name = "SquareRootButton";
            this.SquareRootButton.Size = new System.Drawing.Size(171, 23);
            this.SquareRootButton.TabIndex = 3;
            this.SquareRootButton.Text = "Calculate Square Root";
            this.SquareRootButton.UseVisualStyleBackColor = true;
            this.SquareRootButton.Click += new System.EventHandler(this.SquareRootButton_Click);
            // 
            // SquareRootLabel
            // 
            this.SquareRootLabel.AutoSize = true;
            this.SquareRootLabel.Location = new System.Drawing.Point(12, 67);
            this.SquareRootLabel.Name = "SquareRootLabel";
            this.SquareRootLabel.Size = new System.Drawing.Size(0, 13);
            this.SquareRootLabel.TabIndex = 4;
            // 
            // BabylonianMethodForm
            // 
            this.AcceptButton = this.SquareRootButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 394);
            this.Controls.Add(this.SquareRootLabel);
            this.Controls.Add(this.SquareRootButton);
            this.Controls.Add(this.qTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BabylonianDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "BabylonianMethodForm";
            this.Text = "Babylonian Method for Approximating Square Roots";
            ((System.ComponentModel.ISupportInitialize)(this.BabylonianDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BabylonianDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qDividedByQnColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn differenceColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qTextBox;
        private System.Windows.Forms.Button SquareRootButton;
        private System.Windows.Forms.Label SquareRootLabel;
    }
}

