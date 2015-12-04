namespace OpretOrdre
{
    partial class OrderList
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
            this.BN_ML_Add = new System.Windows.Forms.Button();
            this.BN_ML_Luk = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ordre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GKLevering = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BN_ML_Add
            // 
            this.BN_ML_Add.Location = new System.Drawing.Point(39, 822);
            this.BN_ML_Add.Name = "BN_ML_Add";
            this.BN_ML_Add.Size = new System.Drawing.Size(118, 55);
            this.BN_ML_Add.TabIndex = 5;
            this.BN_ML_Add.Text = "Add";
            this.BN_ML_Add.UseVisualStyleBackColor = true;
            // 
            // BN_ML_Luk
            // 
            this.BN_ML_Luk.Location = new System.Drawing.Point(191, 822);
            this.BN_ML_Luk.Name = "BN_ML_Luk";
            this.BN_ML_Luk.Size = new System.Drawing.Size(118, 55);
            this.BN_ML_Luk.TabIndex = 6;
            this.BN_ML_Luk.Text = "Luk";
            this.BN_ML_Luk.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ordre,
            this.GKLevering,
            this.Plan,
            this.Sker});
            this.dataGridView1.Location = new System.Drawing.Point(39, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(820, 696);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ordre
            // 
            this.Ordre.HeaderText = "Ordre";
            this.Ordre.Name = "Ordre";
            this.Ordre.Width = 477;
            // 
            // GKLevering
            // 
            this.GKLevering.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GKLevering.HeaderText = "GKLevering";
            this.GKLevering.Name = "GKLevering";
            // 
            // Plan
            // 
            this.Plan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Plan.HeaderText = "Plan";
            this.Plan.Name = "Plan";
            // 
            // Sker
            // 
            this.Sker.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sker.HeaderText = "Sker";
            this.Sker.Name = "Sker";
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 910);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BN_ML_Luk);
            this.Controls.Add(this.BN_ML_Add);
            this.Name = "OrderList";
            this.Text = "OrderList";
            this.Load += new System.EventHandler(this.OrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BN_ML_Add;
        private System.Windows.Forms.Button BN_ML_Luk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordre;
        private System.Windows.Forms.DataGridViewTextBoxColumn GKLevering;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sker;
    }
}