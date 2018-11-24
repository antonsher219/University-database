namespace UserInterface
{
    partial class FacultyAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultyAdd));
            this.facname = new System.Windows.Forms.Label();
            this.facnamebox = new System.Windows.Forms.TextBox();
            this.addspec = new System.Windows.Forms.Button();
            this.newfacdirbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newfacadressbox = new System.Windows.Forms.TextBox();
            this.facadress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // facname
            // 
            this.facname.AutoSize = true;
            this.facname.BackColor = System.Drawing.Color.Transparent;
            this.facname.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facname.ForeColor = System.Drawing.Color.White;
            this.facname.Location = new System.Drawing.Point(12, 20);
            this.facname.Name = "facname";
            this.facname.Size = new System.Drawing.Size(159, 17);
            this.facname.TabIndex = 0;
            this.facname.Text = "Название факультета:";
            // 
            // facnamebox
            // 
            this.facnamebox.BackColor = System.Drawing.Color.White;
            this.facnamebox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facnamebox.ForeColor = System.Drawing.Color.Black;
            this.facnamebox.Location = new System.Drawing.Point(172, 17);
            this.facnamebox.Name = "facnamebox";
            this.facnamebox.Size = new System.Drawing.Size(264, 25);
            this.facnamebox.TabIndex = 1;
            // 
            // addspec
            // 
            this.addspec.BackColor = System.Drawing.Color.White;
            this.addspec.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addspec.ForeColor = System.Drawing.Color.Black;
            this.addspec.Location = new System.Drawing.Point(209, 109);
            this.addspec.Name = "addspec";
            this.addspec.Size = new System.Drawing.Size(100, 30);
            this.addspec.TabIndex = 4;
            this.addspec.Text = "Добавить";
            this.addspec.UseVisualStyleBackColor = false;
            this.addspec.Click += new System.EventHandler(this.save_Click);
            // 
            // newfacdirbox
            // 
            this.newfacdirbox.BackColor = System.Drawing.Color.White;
            this.newfacdirbox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newfacdirbox.ForeColor = System.Drawing.Color.Black;
            this.newfacdirbox.Location = new System.Drawing.Point(172, 48);
            this.newfacdirbox.Name = "newfacdirbox";
            this.newfacdirbox.Size = new System.Drawing.Size(264, 25);
            this.newfacdirbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 144;
            this.label1.Text = "Направление:";
            // 
            // newfacadressbox
            // 
            this.newfacadressbox.BackColor = System.Drawing.Color.White;
            this.newfacadressbox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newfacadressbox.ForeColor = System.Drawing.Color.Black;
            this.newfacadressbox.Location = new System.Drawing.Point(172, 79);
            this.newfacadressbox.Name = "newfacadressbox";
            this.newfacadressbox.Size = new System.Drawing.Size(264, 25);
            this.newfacadressbox.TabIndex = 3;
            // 
            // facadress
            // 
            this.facadress.AutoSize = true;
            this.facadress.BackColor = System.Drawing.Color.Transparent;
            this.facadress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facadress.ForeColor = System.Drawing.Color.White;
            this.facadress.Location = new System.Drawing.Point(12, 82);
            this.facadress.Name = "facadress";
            this.facadress.Size = new System.Drawing.Size(136, 17);
            this.facadress.TabIndex = 146;
            this.facadress.Text = "Адрес факультета:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 17);
            this.label2.TabIndex = 148;
            this.label2.Text = "Добавить специальность:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(336, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 149;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddFacultyChanged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(448, 151);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newfacadressbox);
            this.Controls.Add(this.facadress);
            this.Controls.Add(this.newfacdirbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addspec);
            this.Controls.Add(this.facnamebox);
            this.Controls.Add(this.facname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddFacultyChanged";
            this.Text = "Добавление факультета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label facname;
        private System.Windows.Forms.Button addspec;
        private System.Windows.Forms.TextBox newfacdirbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newfacadressbox;
        private System.Windows.Forms.Label facadress;
        public System.Windows.Forms.TextBox facnamebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}