namespace UserInterface
{
    partial class UniversityInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UniversityInfo));
            this.name = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.adressbox = new System.Windows.Forms.TextBox();
            this.faculties = new System.Windows.Forms.Label();
            this.boxoffac = new System.Windows.Forms.ListBox();
            this.boxofspec = new System.Windows.Forms.ListBox();
            this.special = new System.Windows.Forms.Label();
            this.cashd = new System.Windows.Forms.Label();
            this.cashh = new System.Windows.Forms.Label();
            this.budgetplaces = new System.Windows.Forms.Label();
            this.contestrate = new System.Windows.Forms.Label();
            this.boxcashd = new System.Windows.Forms.TextBox();
            this.boxcashh = new System.Windows.Forms.TextBox();
            this.boxbudpl = new System.Windows.Forms.TextBox();
            this.boxrate = new System.Windows.Forms.TextBox();
            this.direction = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.citybox = new System.Windows.Forms.TextBox();
            this.infobox = new System.Windows.Forms.RichTextBox();
            this.boxofdirect = new System.Windows.Forms.TextBox();
            this.facadress = new System.Windows.Forms.Label();
            this.facadressbox = new System.Windows.Forms.TextBox();
            this.addinfo = new System.Windows.Forms.Label();
            this.tests = new System.Windows.Forms.Label();
            this.testsbox = new System.Windows.Forms.TextBox();
            this.facultyAddBtn = new System.Windows.Forms.Button();
            this.specAddBtn = new System.Windows.Forms.Button();
            this.facultyDelBtn = new System.Windows.Forms.Button();
            this.specDelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(12, 11);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(77, 17);
            this.name.TabIndex = 0;
            this.name.Text = "Название:";
            // 
            // adress
            // 
            this.adress.AutoSize = true;
            this.adress.BackColor = System.Drawing.Color.Transparent;
            this.adress.Location = new System.Drawing.Point(12, 85);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(54, 17);
            this.adress.TabIndex = 0;
            this.adress.Text = "Адрес:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 2;
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(99, 8);
            this.namebox.Name = "namebox";
            this.namebox.ReadOnly = true;
            this.namebox.Size = new System.Drawing.Size(534, 25);
            this.namebox.TabIndex = 1;
            // 
            // adressbox
            // 
            this.adressbox.Location = new System.Drawing.Point(99, 82);
            this.adressbox.Name = "adressbox";
            this.adressbox.ReadOnly = true;
            this.adressbox.Size = new System.Drawing.Size(534, 25);
            this.adressbox.TabIndex = 3;
            // 
            // faculties
            // 
            this.faculties.AutoSize = true;
            this.faculties.BackColor = System.Drawing.Color.Transparent;
            this.faculties.Location = new System.Drawing.Point(12, 123);
            this.faculties.Name = "faculties";
            this.faculties.Size = new System.Drawing.Size(93, 17);
            this.faculties.TabIndex = 0;
            this.faculties.Text = "Факультеты:";
            // 
            // boxoffac
            // 
            this.boxoffac.FormattingEnabled = true;
            this.boxoffac.ItemHeight = 17;
            this.boxoffac.Location = new System.Drawing.Point(16, 153);
            this.boxoffac.Name = "boxoffac";
            this.boxoffac.Size = new System.Drawing.Size(300, 310);
            this.boxoffac.TabIndex = 16;
            this.boxoffac.Click += new System.EventHandler(this.facultyBox_Click);
            // 
            // boxofspec
            // 
            this.boxofspec.FormattingEnabled = true;
            this.boxofspec.ItemHeight = 17;
            this.boxofspec.Location = new System.Drawing.Point(322, 153);
            this.boxofspec.Name = "boxofspec";
            this.boxofspec.Size = new System.Drawing.Size(311, 310);
            this.boxofspec.TabIndex = 17;
            this.boxofspec.Click += new System.EventHandler(this.spezializationBox_Click);
            // 
            // special
            // 
            this.special.AutoSize = true;
            this.special.BackColor = System.Drawing.Color.Transparent;
            this.special.Location = new System.Drawing.Point(319, 123);
            this.special.Name = "special";
            this.special.Size = new System.Drawing.Size(119, 17);
            this.special.TabIndex = 0;
            this.special.Text = "Специальности:";
            // 
            // cashd
            // 
            this.cashd.AutoSize = true;
            this.cashd.BackColor = System.Drawing.Color.Transparent;
            this.cashd.Location = new System.Drawing.Point(658, 48);
            this.cashd.Name = "cashd";
            this.cashd.Size = new System.Drawing.Size(239, 17);
            this.cashd.TabIndex = 0;
            this.cashd.Text = "Контракт/Дневное обучение(грн.):";
            // 
            // cashh
            // 
            this.cashh.AutoSize = true;
            this.cashh.BackColor = System.Drawing.Color.Transparent;
            this.cashh.Location = new System.Drawing.Point(658, 87);
            this.cashh.Name = "cashh";
            this.cashh.Size = new System.Drawing.Size(238, 17);
            this.cashh.TabIndex = 0;
            this.cashh.Text = "Контракт/Заочное обучение(грн.):";
            // 
            // budgetplaces
            // 
            this.budgetplaces.AutoSize = true;
            this.budgetplaces.BackColor = System.Drawing.Color.Transparent;
            this.budgetplaces.Location = new System.Drawing.Point(659, 126);
            this.budgetplaces.Name = "budgetplaces";
            this.budgetplaces.Size = new System.Drawing.Size(178, 17);
            this.budgetplaces.TabIndex = 0;
            this.budgetplaces.Text = "Бюджетных мест(2017г.):";
            // 
            // contestrate
            // 
            this.contestrate.AutoSize = true;
            this.contestrate.BackColor = System.Drawing.Color.Transparent;
            this.contestrate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contestrate.Location = new System.Drawing.Point(659, 166);
            this.contestrate.Name = "contestrate";
            this.contestrate.Size = new System.Drawing.Size(223, 17);
            this.contestrate.TabIndex = 0;
            this.contestrate.Text = "Миним. проходной балл(2017г.):";
            // 
            // boxcashd
            // 
            this.boxcashd.Location = new System.Drawing.Point(903, 45);
            this.boxcashd.Name = "boxcashd";
            this.boxcashd.ReadOnly = true;
            this.boxcashd.Size = new System.Drawing.Size(74, 25);
            this.boxcashd.TabIndex = 5;
            // 
            // boxcashh
            // 
            this.boxcashh.Location = new System.Drawing.Point(903, 84);
            this.boxcashh.Name = "boxcashh";
            this.boxcashh.ReadOnly = true;
            this.boxcashh.Size = new System.Drawing.Size(74, 25);
            this.boxcashh.TabIndex = 6;
            // 
            // boxbudpl
            // 
            this.boxbudpl.Location = new System.Drawing.Point(903, 123);
            this.boxbudpl.Name = "boxbudpl";
            this.boxbudpl.ReadOnly = true;
            this.boxbudpl.Size = new System.Drawing.Size(74, 25);
            this.boxbudpl.TabIndex = 7;
            // 
            // boxrate
            // 
            this.boxrate.Location = new System.Drawing.Point(903, 163);
            this.boxrate.Name = "boxrate";
            this.boxrate.ReadOnly = true;
            this.boxrate.Size = new System.Drawing.Size(74, 25);
            this.boxrate.TabIndex = 8;
            // 
            // direction
            // 
            this.direction.AutoSize = true;
            this.direction.BackColor = System.Drawing.Color.Transparent;
            this.direction.Location = new System.Drawing.Point(658, 11);
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(102, 17);
            this.direction.TabIndex = 0;
            this.direction.Text = "Направление:";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.BackColor = System.Drawing.Color.Transparent;
            this.city.ForeColor = System.Drawing.Color.White;
            this.city.Location = new System.Drawing.Point(12, 48);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(52, 17);
            this.city.TabIndex = 0;
            this.city.Text = "Город:";
            // 
            // citybox
            // 
            this.citybox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.citybox.Location = new System.Drawing.Point(99, 45);
            this.citybox.Name = "citybox";
            this.citybox.ReadOnly = true;
            this.citybox.Size = new System.Drawing.Size(534, 25);
            this.citybox.TabIndex = 2;
            // 
            // infobox
            // 
            this.infobox.Location = new System.Drawing.Point(662, 303);
            this.infobox.Name = "infobox";
            this.infobox.ReadOnly = true;
            this.infobox.Size = new System.Drawing.Size(315, 160);
            this.infobox.TabIndex = 11;
            this.infobox.Text = "";
            // 
            // boxofdirect
            // 
            this.boxofdirect.Location = new System.Drawing.Point(766, 8);
            this.boxofdirect.Name = "boxofdirect";
            this.boxofdirect.ReadOnly = true;
            this.boxofdirect.Size = new System.Drawing.Size(211, 25);
            this.boxofdirect.TabIndex = 4;
            // 
            // facadress
            // 
            this.facadress.AutoSize = true;
            this.facadress.BackColor = System.Drawing.Color.Transparent;
            this.facadress.Location = new System.Drawing.Point(660, 206);
            this.facadress.Name = "facadress";
            this.facadress.Size = new System.Drawing.Size(136, 17);
            this.facadress.TabIndex = 0;
            this.facadress.Text = "Адрес факультета:";
            // 
            // facadressbox
            // 
            this.facadressbox.Location = new System.Drawing.Point(805, 203);
            this.facadressbox.Name = "facadressbox";
            this.facadressbox.ReadOnly = true;
            this.facadressbox.Size = new System.Drawing.Size(172, 25);
            this.facadressbox.TabIndex = 9;
            // 
            // addinfo
            // 
            this.addinfo.AutoSize = true;
            this.addinfo.BackColor = System.Drawing.Color.Transparent;
            this.addinfo.Location = new System.Drawing.Point(663, 282);
            this.addinfo.Name = "addinfo";
            this.addinfo.Size = new System.Drawing.Size(103, 17);
            this.addinfo.TabIndex = 0;
            this.addinfo.Text = "Доп. информ.:";
            // 
            // tests
            // 
            this.tests.AutoSize = true;
            this.tests.BackColor = System.Drawing.Color.Transparent;
            this.tests.Location = new System.Drawing.Point(660, 248);
            this.tests.Name = "tests";
            this.tests.Size = new System.Drawing.Size(90, 17);
            this.tests.TabIndex = 0;
            this.tests.Text = "Тесты ВНО:";
            // 
            // testsbox
            // 
            this.testsbox.Location = new System.Drawing.Point(752, 245);
            this.testsbox.Name = "testsbox";
            this.testsbox.ReadOnly = true;
            this.testsbox.Size = new System.Drawing.Size(225, 25);
            this.testsbox.TabIndex = 10;
            // 
            // facultyAddBtn
            // 
            this.facultyAddBtn.BackColor = System.Drawing.Color.White;
            this.facultyAddBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facultyAddBtn.ForeColor = System.Drawing.Color.Black;
            this.facultyAddBtn.Location = new System.Drawing.Point(111, 116);
            this.facultyAddBtn.Name = "facultyAddBtn";
            this.facultyAddBtn.Size = new System.Drawing.Size(100, 30);
            this.facultyAddBtn.TabIndex = 12;
            this.facultyAddBtn.Text = "Добавить";
            this.facultyAddBtn.UseVisualStyleBackColor = false;
            this.facultyAddBtn.Click += new System.EventHandler(this.facultyAddBtn_Click);
            // 
            // specAddBtn
            // 
            this.specAddBtn.BackColor = System.Drawing.Color.White;
            this.specAddBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specAddBtn.ForeColor = System.Drawing.Color.Black;
            this.specAddBtn.Location = new System.Drawing.Point(444, 116);
            this.specAddBtn.Name = "specAddBtn";
            this.specAddBtn.Size = new System.Drawing.Size(87, 30);
            this.specAddBtn.TabIndex = 14;
            this.specAddBtn.Text = "Добавить";
            this.specAddBtn.UseVisualStyleBackColor = false;
            this.specAddBtn.Click += new System.EventHandler(this.specAddBtn_Click);
            // 
            // facultyDelBtn
            // 
            this.facultyDelBtn.BackColor = System.Drawing.Color.White;
            this.facultyDelBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.facultyDelBtn.ForeColor = System.Drawing.Color.Black;
            this.facultyDelBtn.Location = new System.Drawing.Point(213, 116);
            this.facultyDelBtn.Name = "facultyDelBtn";
            this.facultyDelBtn.Size = new System.Drawing.Size(100, 30);
            this.facultyDelBtn.TabIndex = 13;
            this.facultyDelBtn.Text = "Удалить";
            this.facultyDelBtn.UseVisualStyleBackColor = false;
            this.facultyDelBtn.Click += new System.EventHandler(this.facultyDelBtn_Click);
            // 
            // specDelBtn
            // 
            this.specDelBtn.BackColor = System.Drawing.Color.White;
            this.specDelBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specDelBtn.ForeColor = System.Drawing.Color.Black;
            this.specDelBtn.Location = new System.Drawing.Point(537, 117);
            this.specDelBtn.Name = "specDelBtn";
            this.specDelBtn.Size = new System.Drawing.Size(96, 30);
            this.specDelBtn.TabIndex = 15;
            this.specDelBtn.Text = "Удалить";
            this.specDelBtn.UseVisualStyleBackColor = false;
            this.specDelBtn.Click += new System.EventHandler(this.spezDelBtn_Click);
            // 
            // UniversityInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 475);
            this.Controls.Add(this.specDelBtn);
            this.Controls.Add(this.facultyDelBtn);
            this.Controls.Add(this.specAddBtn);
            this.Controls.Add(this.facultyAddBtn);
            this.Controls.Add(this.testsbox);
            this.Controls.Add(this.tests);
            this.Controls.Add(this.addinfo);
            this.Controls.Add(this.facadressbox);
            this.Controls.Add(this.facadress);
            this.Controls.Add(this.boxofdirect);
            this.Controls.Add(this.infobox);
            this.Controls.Add(this.citybox);
            this.Controls.Add(this.city);
            this.Controls.Add(this.direction);
            this.Controls.Add(this.boxrate);
            this.Controls.Add(this.boxbudpl);
            this.Controls.Add(this.boxcashh);
            this.Controls.Add(this.boxcashd);
            this.Controls.Add(this.contestrate);
            this.Controls.Add(this.budgetplaces);
            this.Controls.Add(this.cashh);
            this.Controls.Add(this.cashd);
            this.Controls.Add(this.special);
            this.Controls.Add(this.boxofspec);
            this.Controls.Add(this.boxoffac);
            this.Controls.Add(this.faculties);
            this.Controls.Add(this.adressbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.name);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UniversityInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Университет";
            this.Load += new System.EventHandler(this.UniversityInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label adress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label faculties;
        private System.Windows.Forms.ListBox boxofspec;
        private System.Windows.Forms.Label special;
        private System.Windows.Forms.Label cashd;
        private System.Windows.Forms.Label cashh;
        private System.Windows.Forms.Label budgetplaces;
        private System.Windows.Forms.Label contestrate;
        private System.Windows.Forms.TextBox boxcashd;
        private System.Windows.Forms.TextBox boxcashh;
        private System.Windows.Forms.TextBox boxbudpl;
        private System.Windows.Forms.TextBox boxrate;
        public System.Windows.Forms.TextBox namebox;
        public System.Windows.Forms.TextBox adressbox;
        private System.Windows.Forms.Label direction;
        private System.Windows.Forms.Label city;
        public System.Windows.Forms.TextBox citybox;
        public System.Windows.Forms.ListBox boxoffac;
        private System.Windows.Forms.RichTextBox infobox;
        private System.Windows.Forms.TextBox boxofdirect;
        private System.Windows.Forms.Label facadress;
        private System.Windows.Forms.TextBox facadressbox;
        private System.Windows.Forms.Label addinfo;
        private System.Windows.Forms.Label tests;
        private System.Windows.Forms.TextBox testsbox;
        private System.Windows.Forms.Button facultyAddBtn;
        private System.Windows.Forms.Button specAddBtn;
        private System.Windows.Forms.Button facultyDelBtn;
        private System.Windows.Forms.Button specDelBtn;
    }
}