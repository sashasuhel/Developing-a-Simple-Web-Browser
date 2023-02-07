namespace Web_Browser
{
    partial class FavoriteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavoriteForm));
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.quitbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb2
            // 
            this.tb2.ForeColor = System.Drawing.Color.Black;
            this.tb2.Location = new System.Drawing.Point(60, 66);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(494, 26);
            this.tb2.TabIndex = 0;
            // 
            // tb3
            // 
            this.tb3.ForeColor = System.Drawing.Color.Black;
            this.tb3.Location = new System.Drawing.Point(60, 137);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(494, 26);
            this.tb3.TabIndex = 1;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.savebtn.FlatAppearance.BorderSize = 0;
            this.savebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.ForeColor = System.Drawing.Color.DarkRed;
            this.savebtn.Location = new System.Drawing.Point(109, 196);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(150, 39);
            this.savebtn.TabIndex = 2;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // quitbtn
            // 
            this.quitbtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.quitbtn.FlatAppearance.BorderSize = 0;
            this.quitbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.quitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.quitbtn.Location = new System.Drawing.Point(349, 196);
            this.quitbtn.Name = "quitbtn";
            this.quitbtn.Size = new System.Drawing.Size(150, 39);
            this.quitbtn.TabIndex = 3;
            this.quitbtn.Text = "Close";
            this.quitbtn.UseVisualStyleBackColor = false;
            this.quitbtn.Click += new System.EventHandler(this.Quitbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(61, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Title :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(61, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Address :";
            // 
            // FavoriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 283);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quitbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FavoriteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FavoriteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb2;
        private TextBox tb3;
        private Button savebtn;
        private Button quitbtn;
        private Label label1;
        private Label label2;
    }
}