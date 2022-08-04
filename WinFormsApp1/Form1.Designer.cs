namespace WinFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbPos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPos = new System.Windows.Forms.Button();
            this.lbPos = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.btnCity = new System.Windows.Forms.Button();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.girdView = new System.Windows.Forms.DataGridView();
            this.btnForm3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.girdView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "데이터를 공급해야하는 라벨";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbPos
            // 
            this.cbPos.FormattingEnabled = true;
            this.cbPos.Location = new System.Drawing.Point(38, 84);
            this.cbPos.Name = "cbPos";
            this.cbPos.Size = new System.Drawing.Size(133, 23);
            this.cbPos.TabIndex = 1;
            this.cbPos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ComBox컨트롤실습";
            // 
            // btnPos
            // 
            this.btnPos.Location = new System.Drawing.Point(177, 83);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(75, 23);
            this.btnPos.TabIndex = 3;
            this.btnPos.Text = "확인";
            this.btnPos.UseVisualStyleBackColor = true;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // lbPos
            // 
            this.lbPos.AutoSize = true;
            this.lbPos.Location = new System.Drawing.Point(258, 87);
            this.lbPos.Name = "lbPos";
            this.lbPos.Size = new System.Drawing.Size(34, 15);
            this.lbPos.TabIndex = 4;
            this.lbPos.Text = "결과:";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(258, 133);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(34, 15);
            this.lbCity.TabIndex = 7;
            this.lbCity.Text = "결과:";
            // 
            // btnCity
            // 
            this.btnCity.Location = new System.Drawing.Point(177, 129);
            this.btnCity.Name = "btnCity";
            this.btnCity.Size = new System.Drawing.Size(75, 23);
            this.btnCity.TabIndex = 6;
            this.btnCity.Text = "확인";
            this.btnCity.UseVisualStyleBackColor = true;
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(38, 130);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(133, 23);
            this.cbCity.TabIndex = 5;
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "DataGridView";
            // 
            // girdView
            // 
            this.girdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.girdView.Location = new System.Drawing.Point(52, 213);
            this.girdView.Name = "girdView";
            this.girdView.RowTemplate.Height = 25;
            this.girdView.Size = new System.Drawing.Size(344, 150);
            this.girdView.TabIndex = 9;
            // 
            // btnForm3
            // 
            this.btnForm3.Location = new System.Drawing.Point(52, 382);
            this.btnForm3.Name = "btnForm3";
            this.btnForm3.Size = new System.Drawing.Size(75, 23);
            this.btnForm3.TabIndex = 10;
            this.btnForm3.Text = "Form3뛰우기";
            this.btnForm3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnForm3);
            this.Controls.Add(this.girdView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.btnCity);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.lbPos);
            this.Controls.Add(this.btnPos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.girdView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cbPos;
        private Label label2;
        private Button btnPos;
        private Label lbPos;
        private Label lbCity;
        private Button btnCity;
        private ComboBox cbCity;
        private Label label3;
        private DataGridView girdView;
        private Button btnForm3;
        private Button button2;
    }
}