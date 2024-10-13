
namespace SolidWorksLoader
{
    partial class SolidWorksLoaderForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxLoadDocPart = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonAutoDocCreator = new System.Windows.Forms.RadioButton();
            this.radioButtonAutoDocOpen = new System.Windows.Forms.RadioButton();
            this.labelLine3 = new System.Windows.Forms.Label();
            this.labelLine4 = new System.Windows.Forms.Label();
            this.labelLine5 = new System.Windows.Forms.Label();
            this.groupBoxLoadSolidWorks = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonAutoAppCreator = new System.Windows.Forms.RadioButton();
            this.labelLine1 = new System.Windows.Forms.Label();
            this.labelLine2 = new System.Windows.Forms.Label();
            this.buttonApplyAppSettings = new System.Windows.Forms.Button();
            this.radioButtonManualDocOpen = new System.Windows.Forms.RadioButton();
            this.radioButtonManualAppCreator = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxLoadDocPart.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBoxLoadSolidWorks.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxLoadDocPart, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxLoadSolidWorks, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonApplyAppSettings, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(556, 479);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxLoadDocPart
            // 
            this.groupBoxLoadDocPart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLoadDocPart.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxLoadDocPart.Location = new System.Drawing.Point(4, 204);
            this.groupBoxLoadDocPart.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxLoadDocPart.Name = "groupBoxLoadDocPart";
            this.groupBoxLoadDocPart.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxLoadDocPart.Size = new System.Drawing.Size(548, 204);
            this.groupBoxLoadDocPart.TabIndex = 1;
            this.groupBoxLoadDocPart.TabStop = false;
            this.groupBoxLoadDocPart.Text = "Загрузка документа Part";
            this.groupBoxLoadDocPart.Enter += new System.EventHandler(this.groupBoxLoadDocPart_Enter);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.radioButtonAutoDocCreator, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.radioButtonAutoDocOpen, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.labelLine3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelLine4, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.labelLine5, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.radioButtonManualDocOpen, 0, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(540, 181);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // radioButtonAutoDocCreator
            // 
            this.radioButtonAutoDocCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonAutoDocCreator.AutoSize = true;
            this.radioButtonAutoDocCreator.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonAutoDocCreator.Checked = true;
            this.radioButtonAutoDocCreator.Location = new System.Drawing.Point(4, 16);
            this.radioButtonAutoDocCreator.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonAutoDocCreator.Name = "radioButtonAutoDocCreator";
            this.radioButtonAutoDocCreator.Size = new System.Drawing.Size(152, 20);
            this.radioButtonAutoDocCreator.TabIndex = 0;
            this.radioButtonAutoDocCreator.TabStop = true;
            this.radioButtonAutoDocCreator.Text = "Автоматическое создание.";
            this.radioButtonAutoDocCreator.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonAutoDocCreator.UseVisualStyleBackColor = true;
            // 
            // radioButtonAutoDocOpen
            // 
            this.radioButtonAutoDocOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonAutoDocOpen.AutoSize = true;
            this.radioButtonAutoDocOpen.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonAutoDocOpen.Location = new System.Drawing.Point(4, 56);
            this.radioButtonAutoDocOpen.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonAutoDocOpen.Name = "radioButtonAutoDocOpen";
            this.radioButtonAutoDocOpen.Size = new System.Drawing.Size(152, 36);
            this.radioButtonAutoDocOpen.TabIndex = 5;
            this.radioButtonAutoDocOpen.TabStop = true;
            this.radioButtonAutoDocOpen.Text = "Автоматическое открытие.\r\n\r\n";
            this.radioButtonAutoDocOpen.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonAutoDocOpen.UseVisualStyleBackColor = true;
            // 
            // labelLine3
            // 
            this.labelLine3.AutoSize = true;
            this.labelLine3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel3.SetColumnSpan(this.labelLine3, 3);
            this.labelLine3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLine3.Location = new System.Drawing.Point(4, 40);
            this.labelLine3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLine3.MaximumSize = new System.Drawing.Size(0, 1);
            this.labelLine3.MinimumSize = new System.Drawing.Size(0, 1);
            this.labelLine3.Name = "labelLine3";
            this.labelLine3.Size = new System.Drawing.Size(532, 1);
            this.labelLine3.TabIndex = 4;
            this.labelLine3.Text = "Line";
            // 
            // labelLine4
            // 
            this.labelLine4.AutoSize = true;
            this.labelLine4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel3.SetColumnSpan(this.labelLine4, 3);
            this.labelLine4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLine4.Location = new System.Drawing.Point(4, 96);
            this.labelLine4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLine4.MaximumSize = new System.Drawing.Size(0, 1);
            this.labelLine4.MinimumSize = new System.Drawing.Size(0, 1);
            this.labelLine4.Name = "labelLine4";
            this.labelLine4.Size = new System.Drawing.Size(532, 1);
            this.labelLine4.TabIndex = 9;
            this.labelLine4.Text = "Line";
            // 
            // labelLine5
            // 
            this.labelLine5.AutoSize = true;
            this.labelLine5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel3.SetColumnSpan(this.labelLine5, 3);
            this.labelLine5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLine5.Location = new System.Drawing.Point(4, 136);
            this.labelLine5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLine5.MaximumSize = new System.Drawing.Size(0, 1);
            this.labelLine5.MinimumSize = new System.Drawing.Size(0, 1);
            this.labelLine5.Name = "labelLine5";
            this.labelLine5.Size = new System.Drawing.Size(532, 1);
            this.labelLine5.TabIndex = 10;
            this.labelLine5.Text = "Line";
            // 
            // groupBoxLoadSolidWorks
            // 
            this.groupBoxLoadSolidWorks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLoadSolidWorks.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxLoadSolidWorks.Location = new System.Drawing.Point(4, 14);
            this.groupBoxLoadSolidWorks.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxLoadSolidWorks.Name = "groupBoxLoadSolidWorks";
            this.groupBoxLoadSolidWorks.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxLoadSolidWorks.Size = new System.Drawing.Size(548, 172);
            this.groupBoxLoadSolidWorks.TabIndex = 0;
            this.groupBoxLoadSolidWorks.TabStop = false;
            this.groupBoxLoadSolidWorks.Text = "Загрузка Solid Works";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.radioButtonAutoAppCreator, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonManualAppCreator, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelLine1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelLine2, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 19);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(540, 149);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // radioButtonAutoAppCreator
            // 
            this.radioButtonAutoAppCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonAutoAppCreator.AutoSize = true;
            this.radioButtonAutoAppCreator.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonAutoAppCreator.Checked = true;
            this.radioButtonAutoAppCreator.Location = new System.Drawing.Point(4, 16);
            this.radioButtonAutoAppCreator.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonAutoAppCreator.Name = "radioButtonAutoAppCreator";
            this.radioButtonAutoAppCreator.Size = new System.Drawing.Size(152, 20);
            this.radioButtonAutoAppCreator.TabIndex = 0;
            this.radioButtonAutoAppCreator.TabStop = true;
            this.radioButtonAutoAppCreator.Text = "Автоматический запуск.";
            this.radioButtonAutoAppCreator.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonAutoAppCreator.UseVisualStyleBackColor = true;
            // 
            // labelLine1
            // 
            this.labelLine1.AutoSize = true;
            this.labelLine1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel2.SetColumnSpan(this.labelLine1, 3);
            this.labelLine1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLine1.Location = new System.Drawing.Point(4, 40);
            this.labelLine1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLine1.MaximumSize = new System.Drawing.Size(0, 1);
            this.labelLine1.MinimumSize = new System.Drawing.Size(0, 1);
            this.labelLine1.Name = "labelLine1";
            this.labelLine1.Size = new System.Drawing.Size(532, 1);
            this.labelLine1.TabIndex = 3;
            this.labelLine1.Text = "line";
            this.labelLine1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLine2
            // 
            this.labelLine2.AutoSize = true;
            this.labelLine2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel2.SetColumnSpan(this.labelLine2, 3);
            this.labelLine2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLine2.Location = new System.Drawing.Point(4, 80);
            this.labelLine2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLine2.MaximumSize = new System.Drawing.Size(0, 1);
            this.labelLine2.MinimumSize = new System.Drawing.Size(0, 1);
            this.labelLine2.Name = "labelLine2";
            this.labelLine2.Size = new System.Drawing.Size(532, 1);
            this.labelLine2.TabIndex = 5;
            this.labelLine2.Text = "Line";
            // 
            // buttonApplyAppSettings
            // 
            this.buttonApplyAppSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonApplyAppSettings.Location = new System.Drawing.Point(144, 422);
            this.buttonApplyAppSettings.Margin = new System.Windows.Forms.Padding(0);
            this.buttonApplyAppSettings.MaximumSize = new System.Drawing.Size(267, 0);
            this.buttonApplyAppSettings.MinimumSize = new System.Drawing.Size(267, 0);
            this.buttonApplyAppSettings.Name = "buttonApplyAppSettings";
            this.buttonApplyAppSettings.Size = new System.Drawing.Size(267, 40);
            this.buttonApplyAppSettings.TabIndex = 2;
            this.buttonApplyAppSettings.Text = "Применить настройки.";
            this.buttonApplyAppSettings.UseVisualStyleBackColor = true;
            this.buttonApplyAppSettings.Click += new System.EventHandler(this.buttonApplyAppSettings_Click);
            // 
            // radioButtonManualDocOpen
            // 
            this.radioButtonManualDocOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonManualDocOpen.AutoSize = true;
            this.radioButtonManualDocOpen.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonManualDocOpen.Location = new System.Drawing.Point(4, 112);
            this.radioButtonManualDocOpen.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonManualDocOpen.Name = "radioButtonManualDocOpen";
            this.radioButtonManualDocOpen.Size = new System.Drawing.Size(152, 20);
            this.radioButtonManualDocOpen.TabIndex = 7;
            this.radioButtonManualDocOpen.Text = "Ручное открытие.";
            this.radioButtonManualDocOpen.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonManualDocOpen.UseVisualStyleBackColor = true;
            // 
            // radioButtonManualAppCreator
            // 
            this.radioButtonManualAppCreator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonManualAppCreator.AutoSize = true;
            this.radioButtonManualAppCreator.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonManualAppCreator.Location = new System.Drawing.Point(4, 56);
            this.radioButtonManualAppCreator.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonManualAppCreator.Name = "radioButtonManualAppCreator";
            this.radioButtonManualAppCreator.Size = new System.Drawing.Size(152, 20);
            this.radioButtonManualAppCreator.TabIndex = 0;
            this.radioButtonManualAppCreator.Text = "Ручной запуск.";
            this.radioButtonManualAppCreator.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonManualAppCreator.UseVisualStyleBackColor = true;
            // 
            // SolidWorksLoaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 479);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SolidWorksLoaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки загрузки проекта.";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxLoadDocPart.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBoxLoadSolidWorks.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxLoadDocPart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton radioButtonAutoDocCreator;
        private System.Windows.Forms.GroupBox groupBoxLoadSolidWorks;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButtonAutoAppCreator;
        private System.Windows.Forms.Button buttonApplyAppSettings;
        private System.Windows.Forms.RadioButton radioButtonAutoDocOpen;
        private System.Windows.Forms.Label labelLine1;
        private System.Windows.Forms.Label labelLine3;
        private System.Windows.Forms.Label labelLine4;
        private System.Windows.Forms.Label labelLine5;
        private System.Windows.Forms.Label labelLine2;
        private System.Windows.Forms.RadioButton radioButtonManualDocOpen;
        private System.Windows.Forms.RadioButton radioButtonManualAppCreator;
    }
}

