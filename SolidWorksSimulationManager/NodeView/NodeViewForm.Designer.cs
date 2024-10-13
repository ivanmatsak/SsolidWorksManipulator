
namespace SolidWorksSimulationManager
{
    partial class NodeViewForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonViewChartStress = new System.Windows.Forms.Button();
            this.buttonViewChartStrain = new System.Windows.Forms.Button();
            this.buttonViewNodeStress = new System.Windows.Forms.Button();
            this.buttonViewNodeStrain = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(308, 259);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.buttonViewChartStress, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonViewChartStrain, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonViewNodeStress, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonViewNodeStrain, 0, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(288, 239);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonViewChartStress
            // 
            this.buttonViewChartStress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonViewChartStress.Location = new System.Drawing.Point(0, 0);
            this.buttonViewChartStress.Margin = new System.Windows.Forms.Padding(0);
            this.buttonViewChartStress.Name = "buttonViewChartStress";
            this.buttonViewChartStress.Size = new System.Drawing.Size(288, 52);
            this.buttonViewChartStress.TabIndex = 0;
            this.buttonViewChartStress.Text = "График STRESS";
            this.buttonViewChartStress.UseVisualStyleBackColor = true;
            this.buttonViewChartStress.Click += new System.EventHandler(this.buttonViewChartStress_Click);
            // 
            // buttonViewChartStrain
            // 
            this.buttonViewChartStrain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonViewChartStrain.Location = new System.Drawing.Point(0, 62);
            this.buttonViewChartStrain.Margin = new System.Windows.Forms.Padding(0);
            this.buttonViewChartStrain.Name = "buttonViewChartStrain";
            this.buttonViewChartStrain.Size = new System.Drawing.Size(288, 52);
            this.buttonViewChartStrain.TabIndex = 1;
            this.buttonViewChartStrain.Text = "График STRAIN";
            this.buttonViewChartStrain.UseVisualStyleBackColor = true;
            this.buttonViewChartStrain.Click += new System.EventHandler(this.buttonViewChartStrain_Click);
            // 
            // buttonViewNodeStress
            // 
            this.buttonViewNodeStress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonViewNodeStress.Location = new System.Drawing.Point(0, 124);
            this.buttonViewNodeStress.Margin = new System.Windows.Forms.Padding(0);
            this.buttonViewNodeStress.Name = "buttonViewNodeStress";
            this.buttonViewNodeStress.Size = new System.Drawing.Size(288, 52);
            this.buttonViewNodeStress.TabIndex = 2;
            this.buttonViewNodeStress.Text = "Узлы STRESS";
            this.buttonViewNodeStress.UseVisualStyleBackColor = true;
            this.buttonViewNodeStress.Click += new System.EventHandler(this.buttonViewNodeStress_Click);
            // 
            // buttonViewNodeStrain
            // 
            this.buttonViewNodeStrain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonViewNodeStrain.Location = new System.Drawing.Point(0, 186);
            this.buttonViewNodeStrain.Margin = new System.Windows.Forms.Padding(0);
            this.buttonViewNodeStrain.Name = "buttonViewNodeStrain";
            this.buttonViewNodeStrain.Size = new System.Drawing.Size(288, 53);
            this.buttonViewNodeStrain.TabIndex = 3;
            this.buttonViewNodeStrain.Text = "Узлы STRAIN";
            this.buttonViewNodeStrain.UseVisualStyleBackColor = true;
            this.buttonViewNodeStrain.Click += new System.EventHandler(this.buttonViewNodeStrain_Click);
            // 
            // NodeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 259);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NodeViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonViewChartStress;
        private System.Windows.Forms.Button buttonViewChartStrain;
        private System.Windows.Forms.Button buttonViewNodeStress;
        private System.Windows.Forms.Button buttonViewNodeStrain;
    }
}