namespace AppGSB.Forms
{
    partial class MyExpenseReportForm
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
            btnAddReport = new Button();
            SuspendLayout();
            // 
            // btnAddReport
            // 
            btnAddReport.Location = new Point(566, 12);
            btnAddReport.Name = "btnAddReport";
            btnAddReport.Size = new Size(222, 29);
            btnAddReport.TabIndex = 0;
            btnAddReport.Text = "Nouvelle fiche de frais";
            btnAddReport.UseVisualStyleBackColor = true;
            btnAddReport.Click += btnAddReport_Click;
            // 
            // MyExpenseReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddReport);
            Name = "MyExpenseReportForm";
            Text = "MyExpenseReportForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddReport;
    }
}