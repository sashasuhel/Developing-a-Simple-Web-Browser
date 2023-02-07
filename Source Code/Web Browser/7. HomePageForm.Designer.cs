namespace Web_Browser
{
    partial class HomePageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageForm));
            this.tb4 = new System.Windows.Forms.TextBox();
            this.quitbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb4
            // 
            this.tb4.ForeColor = System.Drawing.Color.Black;
            this.tb4.Location = new System.Drawing.Point(48, 104);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(504, 26);
            this.tb4.TabIndex = 0;
            // 
            // quitbtn
            // 
            this.quitbtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.quitbtn.FlatAppearance.BorderSize = 0;
            this.quitbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.quitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.quitbtn.Location = new System.Drawing.Point(363, 170);
            this.quitbtn.Name = "quitbtn";
            this.quitbtn.Size = new System.Drawing.Size(150, 39);
            this.quitbtn.TabIndex = 4;
            this.quitbtn.Text = "Close";
            this.quitbtn.UseVisualStyleBackColor = false;
            this.quitbtn.Click += new System.EventHandler(this.Quitbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.savebtn.FlatAppearance.BorderSize = 0;
            this.savebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.ForeColor = System.Drawing.Color.DarkRed;
            this.savebtn.Location = new System.Drawing.Point(119, 170);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(150, 39);
            this.savebtn.TabIndex = 5;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Home Address :";
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 283);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.quitbtn);
            this.Controls.Add(this.tb4);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HomePageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb4;
        private Button quitbtn;
        private Button savebtn;
        private Label label1;
    }
}