namespace WindowsFormsApp5
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.panelleft = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.testDataSet = new WindowsFormsApp5.TestDataSet();
            this.testDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet1 = new WindowsFormsApp5.TestDataSet();
            this.testtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testtTableAdapter = new WindowsFormsApp5.TestDataSetTableAdapters.TesttTableAdapter();
            this.testDataSet2 = new WindowsFormsApp5.TestDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.mainDataBaseDataSet = new WindowsFormsApp5.MainDataBaseDataSet();
            this.componentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.componentsTableAdapter = new WindowsFormsApp5.MainDataBaseDataSetTableAdapters.ComponentsTableAdapter();
            this.mainDataBaseDataSet1 = new WindowsFormsApp5.MainDataBaseDataSet();
            this.panelleft.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataBaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelleft.Controls.Add(this.button4);
            this.panelleft.Controls.Add(this.button3);
            this.panelleft.Controls.Add(this.button2);
            this.panelleft.Controls.Add(this.button1);
            this.panelleft.Controls.Add(this.button8);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(191, 638);
            this.panelleft.TabIndex = 1;
            this.panelleft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelleft_Paint);
            this.panelleft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(191, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 59);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana Pro Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Components Shop";
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "TestDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDataSetBindingSource
            // 
            this.testDataSetBindingSource.DataSource = this.testDataSet;
            this.testDataSetBindingSource.Position = 0;
            // 
            // testDataSetBindingSource1
            // 
            this.testDataSetBindingSource1.DataSource = this.testDataSet;
            this.testDataSetBindingSource1.Position = 0;
            // 
            // testDataSet1
            // 
            this.testDataSet1.DataSetName = "TestDataSet";
            this.testDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testtBindingSource
            // 
            this.testtBindingSource.DataMember = "Testt";
            this.testtBindingSource.DataSource = this.testDataSetBindingSource;
            // 
            // testtTableAdapter
            // 
            this.testtTableAdapter.ClearBeforeFill = true;
            // 
            // testDataSet2
            // 
            this.testDataSet2.DataSetName = "TestDataSet";
            this.testDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::WindowsFormsApp5.Properties.Resources.clear_shopping_cart_60px;
            this.button4.Location = new System.Drawing.Point(6, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 129);
            this.button4.TabIndex = 9;
            this.button4.Text = "Shop";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::WindowsFormsApp5.Properties.Resources.print_64px;
            this.button3.Location = new System.Drawing.Point(6, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 152);
            this.button3.TabIndex = 8;
            this.button3.Text = "Invoice";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::WindowsFormsApp5.Properties.Resources.warehouse_64px;
            this.button2.Location = new System.Drawing.Point(6, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 125);
            this.button2.TabIndex = 7;
            this.button2.Text = "Storage";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::WindowsFormsApp5.Properties.Resources.settings_64px;
            this.button1.Location = new System.Drawing.Point(3, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 129);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Component";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::WindowsFormsApp5.Properties.Resources.delete_32px;
            this.button8.Location = new System.Drawing.Point(3, 567);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(185, 64);
            this.button8.TabIndex = 0;
            this.button8.Text = "Close";
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // mainDataBaseDataSet
            // 
            this.mainDataBaseDataSet.DataSetName = "MainDataBaseDataSet";
            this.mainDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // componentsBindingSource
            // 
            this.componentsBindingSource.DataMember = "Components";
            this.componentsBindingSource.DataSource = this.mainDataBaseDataSet;
            // 
            // componentsTableAdapter
            // 
            this.componentsTableAdapter.ClearBeforeFill = true;
            // 
            // mainDataBaseDataSet1
            // 
            this.mainDataBaseDataSet1.DataSetName = "MainDataBaseDataSet";
            this.mainDataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(838, 638);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelleft);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelleft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataBaseDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private TestDataSet testDataSet;
        private System.Windows.Forms.BindingSource testDataSetBindingSource;
        private System.Windows.Forms.BindingSource testDataSetBindingSource1;
        private TestDataSet testDataSet1;
        private System.Windows.Forms.BindingSource testtBindingSource;
        private TestDataSetTableAdapters.TesttTableAdapter testtTableAdapter;
        public System.Windows.Forms.Button button1;
        private TestDataSet testDataSet2;
        private MainDataBaseDataSet mainDataBaseDataSet;
        private System.Windows.Forms.BindingSource componentsBindingSource;
        private MainDataBaseDataSetTableAdapters.ComponentsTableAdapter componentsTableAdapter;
        private MainDataBaseDataSet mainDataBaseDataSet1;
    }
}