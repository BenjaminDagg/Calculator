namespace Calculator
{
    partial class Calculator
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
            this.TabelLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CalcText = new System.Windows.Forms.TextBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.DivideBtn = new System.Windows.Forms.Button();
            this.MultiplyBtn = new System.Windows.Forms.Button();
            this.SubtractBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.TabelLayout.SuspendLayout();
            this.SuspendLayout();
           
            // 
            // TabelLayout
            // 
            this.TabelLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TabelLayout.ColumnCount = 4;
            this.TabelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TabelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TabelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TabelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TabelLayout.Controls.Add(this.CalcText, 0, 0);
            this.TabelLayout.Controls.Add(this.ClearBtn, 1, 1);
            this.TabelLayout.Controls.Add(this.DelBtn, 2, 1);
            this.TabelLayout.Controls.Add(this.DivideBtn, 3, 1);
            this.TabelLayout.Controls.Add(this.MultiplyBtn, 3, 2);
            this.TabelLayout.Controls.Add(this.SubtractBtn, 3, 3);
            this.TabelLayout.Controls.Add(this.AddBtn, 3, 4);
            this.TabelLayout.Controls.Add(this.EnterBtn, 3, 5);
            this.TabelLayout.Location = new System.Drawing.Point(0, 0);
            this.TabelLayout.Name = "TabelLayout";
            this.TabelLayout.Padding = new System.Windows.Forms.Padding(3);
            this.TabelLayout.RowCount = 6;
            this.TabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.TabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.TabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.TabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.TabelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.TabelLayout.Size = new System.Drawing.Size(334, 441);
            this.TabelLayout.TabIndex = 0;
            // 
            // CalcText
            // 
            this.CalcText.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.TabelLayout.SetColumnSpan(this.CalcText, 4);
            this.CalcText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalcText.Location = new System.Drawing.Point(6, 6);
            this.CalcText.Multiline = true;
            this.CalcText.Name = "CalcText";
            this.CalcText.Size = new System.Drawing.Size(322, 154);
            this.CalcText.TabIndex = 0;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearBtn.Location = new System.Drawing.Point(88, 166);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(76, 43);
            this.ClearBtn.TabIndex = 1;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            // 
            // DelBtn
            // 
            this.DelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelBtn.Location = new System.Drawing.Point(170, 166);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(76, 43);
            this.DelBtn.TabIndex = 2;
            this.DelBtn.Text = "Del";
            this.DelBtn.UseVisualStyleBackColor = true;
            // 
            // DivideBtn
            // 
            this.DivideBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivideBtn.Location = new System.Drawing.Point(252, 166);
            this.DivideBtn.Name = "DivideBtn";
            this.DivideBtn.Size = new System.Drawing.Size(76, 43);
            this.DivideBtn.TabIndex = 3;
            this.DivideBtn.Text = "%";
            this.DivideBtn.UseVisualStyleBackColor = true;
            // 
            // MultiplyBtn
            // 
            this.MultiplyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiplyBtn.Location = new System.Drawing.Point(252, 215);
            this.MultiplyBtn.Name = "MultiplyBtn";
            this.MultiplyBtn.Size = new System.Drawing.Size(76, 44);
            this.MultiplyBtn.TabIndex = 4;
            this.MultiplyBtn.Text = "X";
            this.MultiplyBtn.UseVisualStyleBackColor = true;
            // 
            // SubtractBtn
            // 
            this.SubtractBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubtractBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractBtn.Location = new System.Drawing.Point(252, 265);
            this.SubtractBtn.Name = "SubtractBtn";
            this.SubtractBtn.Size = new System.Drawing.Size(76, 43);
            this.SubtractBtn.TabIndex = 5;
            this.SubtractBtn.Text = "-";
            this.SubtractBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(252, 314);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(76, 40);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "+";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // EnterBtn
            // 
            this.EnterBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterBtn.Location = new System.Drawing.Point(252, 360);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(76, 40);
            this.EnterBtn.TabIndex = 7;
            this.EnterBtn.Text = "=";
            this.EnterBtn.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(334, 441);
            this.Controls.Add(this.TabelLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.TabelLayout.ResumeLayout(false);
            this.TabelLayout.PerformLayout();
            this.ResumeLayout(false);

            

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TabelLayout;
        private System.Windows.Forms.TextBox CalcText;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button DivideBtn;
        private System.Windows.Forms.Button MultiplyBtn;
        private System.Windows.Forms.Button SubtractBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Button[] numButtons = new System.Windows.Forms.Button[10];
    }
}

