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
            this.DG_OL_ListOrder = new System.Windows.Forms.DataGridView();
            this.Ordre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GKLev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BN_OL_Add = new System.Windows.Forms.Button();
            this.BN_OL_Luk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_OL_ListOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_OL_ListOrder
            // 
            this.DG_OL_ListOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_OL_ListOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ordre,
            this.Plan,
            this.Sker,
            this.GKLev});
            this.DG_OL_ListOrder.Location = new System.Drawing.Point(73, 12);
            this.DG_OL_ListOrder.Name = "DG_OL_ListOrder";
            this.DG_OL_ListOrder.Size = new System.Drawing.Size(445, 482);
            this.DG_OL_ListOrder.TabIndex = 0;
            // 
            // Ordre
            // 
            this.Ordre.HeaderText = "Ordre";
            this.Ordre.Name = "Ordre";
            // 
            // Plan
            // 
            this.Plan.HeaderText = "Plan";
            this.Plan.Name = "Plan";
            // 
            // Sker
            // 
            this.Sker.HeaderText = "Sker";
            this.Sker.Name = "Sker";
            // 
            // GKLev
            // 
            this.GKLev.HeaderText = "GKLev";
            this.GKLev.Name = "GKLev";
            // 
            // BN_OL_Add
            // 
            this.BN_OL_Add.Location = new System.Drawing.Point(73, 497);
            this.BN_OL_Add.Name = "BN_OL_Add";
            this.BN_OL_Add.Size = new System.Drawing.Size(75, 23);
            this.BN_OL_Add.TabIndex = 1;
            this.BN_OL_Add.Text = "Add";
            this.BN_OL_Add.UseVisualStyleBackColor = true;
            // 
            // BN_OL_Luk
            // 
            this.BN_OL_Luk.Location = new System.Drawing.Point(154, 497);
            this.BN_OL_Luk.Name = "BN_OL_Luk";
            this.BN_OL_Luk.Size = new System.Drawing.Size(75, 23);
            this.BN_OL_Luk.TabIndex = 2;
            this.BN_OL_Luk.Text = "Luk";
            this.BN_OL_Luk.UseVisualStyleBackColor = true;
            // 
            // OrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 524);
            this.Controls.Add(this.BN_OL_Luk);
            this.Controls.Add(this.BN_OL_Add);
            this.Controls.Add(this.DG_OL_ListOrder);
            this.Name = "OrderList";
            this.Text = "Ordre Beskrivelse";
            ((System.ComponentModel.ISupportInitialize)(this.DG_OL_ListOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_OL_ListOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sker;
        private System.Windows.Forms.DataGridViewTextBoxColumn GKLev;
        private System.Windows.Forms.Button BN_OL_Add;
        private System.Windows.Forms.Button BN_OL_Luk;
    }
}