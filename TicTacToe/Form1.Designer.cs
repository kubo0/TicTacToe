
namespace TicTacToe
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BottomRight = new System.Windows.Forms.Button();
            this.BottomCentre = new System.Windows.Forms.Button();
            this.BottomLeft = new System.Windows.Forms.Button();
            this.CentreRight = new System.Windows.Forms.Button();
            this.CentreCentre = new System.Windows.Forms.Button();
            this.CentreLeft = new System.Windows.Forms.Button();
            this.TopRight = new System.Windows.Forms.Button();
            this.TopCentre = new System.Windows.Forms.Button();
            this.TopLeft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.BottomRight, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BottomCentre, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BottomLeft, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.CentreRight, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.CentreCentre, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CentreLeft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TopRight, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TopCentre, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TopLeft, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(348, 245);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BottomRight
            // 
            this.BottomRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomRight.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BottomRight.Location = new System.Drawing.Point(235, 165);
            this.BottomRight.Name = "BottomRight";
            this.BottomRight.Size = new System.Drawing.Size(110, 77);
            this.BottomRight.TabIndex = 8;
            this.BottomRight.UseVisualStyleBackColor = true;
            this.BottomRight.Click += new System.EventHandler(this.Mark);
            // 
            // BottomCentre
            // 
            this.BottomCentre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomCentre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BottomCentre.Location = new System.Drawing.Point(119, 165);
            this.BottomCentre.Name = "BottomCentre";
            this.BottomCentre.Size = new System.Drawing.Size(110, 77);
            this.BottomCentre.TabIndex = 7;
            this.BottomCentre.UseVisualStyleBackColor = true;
            this.BottomCentre.Click += new System.EventHandler(this.Mark);
            // 
            // BottomLeft
            // 
            this.BottomLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomLeft.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BottomLeft.Location = new System.Drawing.Point(3, 165);
            this.BottomLeft.Name = "BottomLeft";
            this.BottomLeft.Size = new System.Drawing.Size(110, 77);
            this.BottomLeft.TabIndex = 6;
            this.BottomLeft.UseVisualStyleBackColor = true;
            this.BottomLeft.Click += new System.EventHandler(this.Mark);
            // 
            // CentreRight
            // 
            this.CentreRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentreRight.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CentreRight.Location = new System.Drawing.Point(235, 84);
            this.CentreRight.Name = "CentreRight";
            this.CentreRight.Size = new System.Drawing.Size(110, 75);
            this.CentreRight.TabIndex = 5;
            this.CentreRight.UseVisualStyleBackColor = true;
            this.CentreRight.Click += new System.EventHandler(this.Mark);
            // 
            // CentreCentre
            // 
            this.CentreCentre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentreCentre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CentreCentre.Location = new System.Drawing.Point(119, 84);
            this.CentreCentre.Name = "CentreCentre";
            this.CentreCentre.Size = new System.Drawing.Size(110, 75);
            this.CentreCentre.TabIndex = 4;
            this.CentreCentre.UseVisualStyleBackColor = true;
            this.CentreCentre.Click += new System.EventHandler(this.Mark);
            // 
            // CentreLeft
            // 
            this.CentreLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentreLeft.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CentreLeft.Location = new System.Drawing.Point(3, 84);
            this.CentreLeft.Name = "CentreLeft";
            this.CentreLeft.Size = new System.Drawing.Size(110, 75);
            this.CentreLeft.TabIndex = 3;
            this.CentreLeft.UseVisualStyleBackColor = true;
            this.CentreLeft.Click += new System.EventHandler(this.Mark);
            // 
            // TopRight
            // 
            this.TopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopRight.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TopRight.Location = new System.Drawing.Point(235, 3);
            this.TopRight.Name = "TopRight";
            this.TopRight.Size = new System.Drawing.Size(110, 75);
            this.TopRight.TabIndex = 2;
            this.TopRight.UseVisualStyleBackColor = true;
            this.TopRight.Click += new System.EventHandler(this.Mark);
            // 
            // TopCentre
            // 
            this.TopCentre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopCentre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TopCentre.Location = new System.Drawing.Point(119, 3);
            this.TopCentre.Name = "TopCentre";
            this.TopCentre.Size = new System.Drawing.Size(110, 75);
            this.TopCentre.TabIndex = 1;
            this.TopCentre.UseVisualStyleBackColor = true;
            this.TopCentre.Click += new System.EventHandler(this.Mark);
            // 
            // TopLeft
            // 
            this.TopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopLeft.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TopLeft.Location = new System.Drawing.Point(3, 3);
            this.TopLeft.Name = "TopLeft";
            this.TopLeft.Size = new System.Drawing.Size(110, 75);
            this.TopLeft.TabIndex = 0;
            this.TopLeft.UseVisualStyleBackColor = true;
            this.TopLeft.Click += new System.EventHandler(this.Mark);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aktualny ruch: ";
            // 
            // currentLabel
            // 
            this.currentLabel.AutoSize = true;
            this.currentLabel.Location = new System.Drawing.Point(108, 275);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(0, 15);
            this.currentLabel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(348, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button TopLeft;
        private System.Windows.Forms.Button BottomRight;
        private System.Windows.Forms.Button BottomCentre;
        private System.Windows.Forms.Button BottomLeft;
        private System.Windows.Forms.Button CentreRight;
        private System.Windows.Forms.Button CentreCentre;
        private System.Windows.Forms.Button CentreLeft;
        private System.Windows.Forms.Button TopRight;
        private System.Windows.Forms.Button TopCentre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Button button1;
    }
}

