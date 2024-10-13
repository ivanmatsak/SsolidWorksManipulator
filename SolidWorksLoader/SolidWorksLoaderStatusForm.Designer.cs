
namespace SolidWorksLoader
{
    partial class SolidWorksLoaderStatusForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDocTitle = new System.Windows.Forms.Label();
            this.progressBarAppLoad = new System.Windows.Forms.ProgressBar();
            this.labelAppTitle = new System.Windows.Forms.Label();
            this.progressBarDocLoad = new System.Windows.Forms.ProgressBar();
            this.labelAppInfo = new System.Windows.Forms.Label();
            this.labelDocInfo = new System.Windows.Forms.Label();
            this.labelManualInfo = new System.Windows.Forms.Label();
            this.labelErrorInfo = new System.Windows.Forms.Label();
            this.openFileDialogDocPart = new System.Windows.Forms.OpenFileDialog();
            this.timerFindActiveApp = new System.Windows.Forms.Timer();
            this.timerFindActiveDoc = new System.Windows.Forms.Timer();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelDocTitle, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.progressBarAppLoad, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAppTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.progressBarDocLoad, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelAppInfo, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelDocInfo, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelManualInfo, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelErrorInfo, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(529, 215);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelDocTitle
            // 
            this.labelDocTitle.AutoSize = true;
            this.labelDocTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDocTitle.Location = new System.Drawing.Point(4, 73);
            this.labelDocTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDocTitle.Name = "labelDocTitle";
            this.labelDocTitle.Size = new System.Drawing.Size(165, 36);
            this.labelDocTitle.TabIndex = 0;
            this.labelDocTitle.Text = "Создание документа:";
            this.labelDocTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBarAppLoad
            // 
            this.progressBarAppLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarAppLoad.Location = new System.Drawing.Point(190, 29);
            this.progressBarAppLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarAppLoad.Name = "progressBarAppLoad";
            this.progressBarAppLoad.Size = new System.Drawing.Size(125, 28);
            this.progressBarAppLoad.TabIndex = 3;
            // 
            // labelAppTitle
            // 
            this.labelAppTitle.AutoSize = true;
            this.labelAppTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAppTitle.Location = new System.Drawing.Point(4, 25);
            this.labelAppTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAppTitle.Name = "labelAppTitle";
            this.labelAppTitle.Size = new System.Drawing.Size(165, 36);
            this.labelAppTitle.TabIndex = 0;
            this.labelAppTitle.Text = "Запуск приложения:";
            this.labelAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBarDocLoad
            // 
            this.progressBarDocLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarDocLoad.Location = new System.Drawing.Point(190, 77);
            this.progressBarDocLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarDocLoad.Name = "progressBarDocLoad";
            this.progressBarDocLoad.Size = new System.Drawing.Size(125, 28);
            this.progressBarDocLoad.TabIndex = 6;
            // 
            // labelAppInfo
            // 
            this.labelAppInfo.AutoSize = true;
            this.labelAppInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAppInfo.Location = new System.Drawing.Point(336, 25);
            this.labelAppInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAppInfo.Name = "labelAppInfo";
            this.labelAppInfo.Size = new System.Drawing.Size(189, 36);
            this.labelAppInfo.TabIndex = 9;
            this.labelAppInfo.Text = "Приложение не запущено !";
            this.labelAppInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDocInfo
            // 
            this.labelDocInfo.AutoSize = true;
            this.labelDocInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDocInfo.Location = new System.Drawing.Point(336, 73);
            this.labelDocInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDocInfo.Name = "labelDocInfo";
            this.labelDocInfo.Size = new System.Drawing.Size(189, 36);
            this.labelDocInfo.TabIndex = 12;
            this.labelDocInfo.Text = "Документ не создан !";
            this.labelDocInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelManualInfo
            // 
            this.labelManualInfo.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelManualInfo, 5);
            this.labelManualInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelManualInfo.Location = new System.Drawing.Point(4, 134);
            this.labelManualInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManualInfo.Name = "labelManualInfo";
            this.labelManualInfo.Size = new System.Drawing.Size(521, 16);
            this.labelManualInfo.TabIndex = 14;
            this.labelManualInfo.Text = "Необходимые действия пользователя.";
            // 
            // labelErrorInfo
            // 
            this.labelErrorInfo.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelErrorInfo, 5);
            this.labelErrorInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelErrorInfo.Location = new System.Drawing.Point(4, 162);
            this.labelErrorInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorInfo.Name = "labelErrorInfo";
            this.labelErrorInfo.Size = new System.Drawing.Size(521, 16);
            this.labelErrorInfo.TabIndex = 13;
            this.labelErrorInfo.Text = "Если это окно не закрылось само значит что-то пошло не так.";
            // 
            // timerFindActiveApp
            // 
            this.timerFindActiveApp.Interval = 500;
            this.timerFindActiveApp.Tick += new System.EventHandler(this.TimerFindActiveApp_Tick);
            // 
            // timerFindActiveDoc
            // 
            this.timerFindActiveDoc.Interval = 500;
            this.timerFindActiveDoc.Tick += new System.EventHandler(this.TimerFindActiveDoc_Tick);
            // 
            // SolidWorksLoaderStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 215);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SolidWorksLoaderStatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Состояние загрузки проекта.";
            this.Load += new System.EventHandler(this.SolidWorkLoadStatusForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialogDocPart;
        private System.Windows.Forms.Label labelAppTitle;
        private System.Windows.Forms.Label labelDocTitle;
        private System.Windows.Forms.ProgressBar progressBarAppLoad;
        private System.Windows.Forms.ProgressBar progressBarDocLoad;
        private System.Windows.Forms.Label labelAppInfo;
        private System.Windows.Forms.Label labelDocInfo;
        private System.Windows.Forms.Timer timerFindActiveApp;
        private System.Windows.Forms.Timer timerFindActiveDoc;
        private System.Windows.Forms.Label labelErrorInfo;
        private System.Windows.Forms.Label labelManualInfo;
    }
}