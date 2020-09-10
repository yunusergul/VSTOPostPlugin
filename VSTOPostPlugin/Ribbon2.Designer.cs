namespace WordAddIn9
{
    partial class Ribbon2 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon2()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.button1 = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.editBox2 = this.Factory.CreateRibbonEditBox();
            this.editBox1 = this.Factory.CreateRibbonEditBox();
            this.label1 = this.Factory.CreateRibbonLabel();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.label4 = this.Factory.CreateRibbonLabel();
            this.label3 = this.Factory.CreateRibbonLabel();
            this.button4 = this.Factory.CreateRibbonButton();
            this.button3 = this.Factory.CreateRibbonButton();
            this.group4 = this.Factory.CreateRibbonGroup();
            this.editBox3 = this.Factory.CreateRibbonEditBox();
            this.editBox4 = this.Factory.CreateRibbonEditBox();
            this.button2 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            this.group4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Groups.Add(this.group4);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.button1);
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // button1
            // 
            this.button1.Label = "button1";
            this.button1.Name = "button1";
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.editBox2);
            this.group2.Items.Add(this.editBox1);
            this.group2.Items.Add(this.label1);
            this.group2.Label = "group2";
            this.group2.Name = "group2";
            // 
            // editBox2
            // 
            this.editBox2.Label = "editBox2";
            this.editBox2.Name = "editBox2";
            this.editBox2.Text = null;
            // 
            // editBox1
            // 
            this.editBox1.Label = "editBox1";
            this.editBox1.Name = "editBox1";
            this.editBox1.Text = null;
            // 
            // label1
            // 
            this.label1.Label = "label1";
            this.label1.Name = "label1";
            // 
            // group3
            // 
            this.group3.Items.Add(this.label4);
            this.group3.Items.Add(this.label3);
            this.group3.Items.Add(this.button4);
            this.group3.Items.Add(this.button3);
            this.group3.Label = "group3";
            this.group3.Name = "group3";
            // 
            // label4
            // 
            this.label4.Label = "label4";
            this.label4.Name = "label4";
            // 
            // label3
            // 
            this.label3.Label = "label3";
            this.label3.Name = "label3";
            // 
            // button4
            // 
            this.button4.Label = "detay getir";
            this.button4.Name = "button4";
            this.button4.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Label = "Çıkış Yap";
            this.button3.Name = "button3";
            this.button3.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button3_Click);
            // 
            // group4
            // 
            this.group4.Items.Add(this.editBox3);
            this.group4.Items.Add(this.editBox4);
            this.group4.Items.Add(this.button2);
            this.group4.Label = "Kullanıcı Girişi";
            this.group4.Name = "group4";
            // 
            // editBox3
            // 
            this.editBox3.Label = "Mail";
            this.editBox3.Name = "editBox3";
            this.editBox3.Text = null;
            // 
            // editBox4
            // 
            this.editBox4.Label = "Şifre";
            this.editBox4.Name = "editBox4";
            this.editBox4.Text = null;
            // 
            // button2
            // 
            this.button2.Label = "Giriş Yap";
            this.button2.Name = "button2";
            this.button2.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button2_Click);
            // 
            // Ribbon2
            // 
            this.Name = "Ribbon2";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon2_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.group4.ResumeLayout(false);
            this.group4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBox2;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBox1;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label4;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label3;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group4;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBox3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button4;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox editBox4;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon2 Ribbon2
        {
            get { return this.GetRibbon<Ribbon2>(); }
        }
    }
}
