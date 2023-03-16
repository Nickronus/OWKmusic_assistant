namespace OWKmusic_assistant
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            this.tabPageInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.tabPageInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.tabPage1);
            this.tabPageInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageInfo.Location = new System.Drawing.Point(0, 0);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.SelectedIndex = 0;
            this.tabPageInfo.Size = new System.Drawing.Size(805, 468);
            this.tabPageInfo.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::OWKmusic_assistant.Properties.Resources.Fon1;
            this.tabPage1.Controls.Add(this.richTextBoxInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(797, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Информация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxInfo.Location = new System.Drawing.Point(6, 6);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(783, 428);
            this.richTextBoxInfo.TabIndex = 0;
            this.richTextBoxInfo.Text = resources.GetString("richTextBoxInfo.Text");
            this.richTextBoxInfo.ReadOnly = true;
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OWKmusic_assistant.Properties.Resources.Fon1;
            this.ClientSize = new System.Drawing.Size(805, 468);
            this.Controls.Add(this.tabPageInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInfo";
            this.Text = "О программе";
            this.tabPageInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPageInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
    }
}