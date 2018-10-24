namespace Prescription_Renewal
{
    partial class DLG_PrescriptionRenewal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBB_StoreSelector = new System.Windows.Forms.ComboBox();
            this.LB_ZipCode = new System.Windows.Forms.Label();
            this.MTBX_ZipCode = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MTBX_Phone = new System.Windows.Forms.MaskedTextBox();
            this.LB_EMail = new System.Windows.Forms.Label();
            this.LB_PhoneExtension = new System.Windows.Forms.Label();
            this.TBX_PhoneExtension = new System.Windows.Forms.TextBox();
            this.LB_Phone = new System.Windows.Forms.Label();
            this.LB_LastName = new System.Windows.Forms.Label();
            this.LB_First_Name = new System.Windows.Forms.Label();
            this.TBX_EMail = new System.Windows.Forms.TextBox();
            this.TBX_LastName = new System.Windows.Forms.TextBox();
            this.TBX_FirstName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FBTN_Editer = new FlashButton.FlashButton();
            this.FBTN_Delete = new FlashButton.FlashButton();
            this.FBTN_Abort = new FlashButton.FlashButton();
            this.FBTN_Add = new FlashButton.FlashButton();
            this.LB_Comment = new System.Windows.Forms.Label();
            this.RBTX_Comment = new System.Windows.Forms.RichTextBox();
            this.LBX_PrescriptionNumber = new System.Windows.Forms.ListBox();
            this.MTBX_PrescriptionNumber = new System.Windows.Forms.MaskedTextBox();
            this.BTN_Ok = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBB_StoreSelector);
            this.groupBox1.Controls.Add(this.LB_ZipCode);
            this.groupBox1.Controls.Add(this.MTBX_ZipCode);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choix de succursale";
            // 
            // CBB_StoreSelector
            // 
            this.CBB_StoreSelector.FormattingEnabled = true;
            this.CBB_StoreSelector.Location = new System.Drawing.Point(6, 45);
            this.CBB_StoreSelector.Name = "CBB_StoreSelector";
            this.CBB_StoreSelector.Size = new System.Drawing.Size(352, 21);
            this.CBB_StoreSelector.TabIndex = 3;
            this.CBB_StoreSelector.SelectedIndexChanged += new System.EventHandler(this.CBB_StoreSelector_SelectedIndexChanged);
            // 
            // LB_ZipCode
            // 
            this.LB_ZipCode.AutoSize = true;
            this.LB_ZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ZipCode.Location = new System.Drawing.Point(145, 22);
            this.LB_ZipCode.Name = "LB_ZipCode";
            this.LB_ZipCode.Size = new System.Drawing.Size(161, 13);
            this.LB_ZipCode.TabIndex = 1;
            this.LB_ZipCode.Text = "Recherche par code postal";
            // 
            // MTBX_ZipCode
            // 
            this.MTBX_ZipCode.Location = new System.Drawing.Point(312, 19);
            this.MTBX_ZipCode.Name = "MTBX_ZipCode";
            this.MTBX_ZipCode.Size = new System.Drawing.Size(46, 20);
            this.MTBX_ZipCode.TabIndex = 0;
            this.MTBX_ZipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MTBX_ZipCode_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MTBX_Phone);
            this.groupBox2.Controls.Add(this.LB_EMail);
            this.groupBox2.Controls.Add(this.LB_PhoneExtension);
            this.groupBox2.Controls.Add(this.TBX_PhoneExtension);
            this.groupBox2.Controls.Add(this.LB_Phone);
            this.groupBox2.Controls.Add(this.LB_LastName);
            this.groupBox2.Controls.Add(this.LB_First_Name);
            this.groupBox2.Controls.Add(this.TBX_EMail);
            this.groupBox2.Controls.Add(this.TBX_LastName);
            this.groupBox2.Controls.Add(this.TBX_FirstName);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations sur le client";
            // 
            // MTBX_Phone
            // 
            this.MTBX_Phone.Location = new System.Drawing.Point(82, 89);
            this.MTBX_Phone.Name = "MTBX_Phone";
            this.MTBX_Phone.Size = new System.Drawing.Size(88, 20);
            this.MTBX_Phone.TabIndex = 2;
            this.MTBX_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MTBX_Phone_KeyPress);
            // 
            // LB_EMail
            // 
            this.LB_EMail.AutoSize = true;
            this.LB_EMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EMail.Location = new System.Drawing.Point(27, 118);
            this.LB_EMail.Name = "LB_EMail";
            this.LB_EMail.Size = new System.Drawing.Size(50, 13);
            this.LB_EMail.TabIndex = 9;
            this.LB_EMail.Text = "Courriel";
            // 
            // LB_PhoneExtension
            // 
            this.LB_PhoneExtension.AutoSize = true;
            this.LB_PhoneExtension.Location = new System.Drawing.Point(236, 92);
            this.LB_PhoneExtension.Name = "LB_PhoneExtension";
            this.LB_PhoneExtension.Size = new System.Drawing.Size(34, 13);
            this.LB_PhoneExtension.TabIndex = 8;
            this.LB_PhoneExtension.Text = "Poste";
            // 
            // TBX_PhoneExtension
            // 
            this.TBX_PhoneExtension.Location = new System.Drawing.Point(278, 89);
            this.TBX_PhoneExtension.Name = "TBX_PhoneExtension";
            this.TBX_PhoneExtension.Size = new System.Drawing.Size(44, 20);
            this.TBX_PhoneExtension.TabIndex = 3;
            // 
            // LB_Phone
            // 
            this.LB_Phone.AutoSize = true;
            this.LB_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Phone.Location = new System.Drawing.Point(12, 92);
            this.LB_Phone.Name = "LB_Phone";
            this.LB_Phone.Size = new System.Drawing.Size(67, 13);
            this.LB_Phone.TabIndex = 6;
            this.LB_Phone.Text = "Téléphone";
            // 
            // LB_LastName
            // 
            this.LB_LastName.AutoSize = true;
            this.LB_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LastName.Location = new System.Drawing.Point(44, 62);
            this.LB_LastName.Name = "LB_LastName";
            this.LB_LastName.Size = new System.Drawing.Size(32, 13);
            this.LB_LastName.TabIndex = 5;
            this.LB_LastName.Text = "Nom";
            // 
            // LB_First_Name
            // 
            this.LB_First_Name.AutoSize = true;
            this.LB_First_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_First_Name.Location = new System.Drawing.Point(27, 29);
            this.LB_First_Name.Name = "LB_First_Name";
            this.LB_First_Name.Size = new System.Drawing.Size(49, 13);
            this.LB_First_Name.TabIndex = 4;
            this.LB_First_Name.Text = "Prénom";
            // 
            // TBX_EMail
            // 
            this.TBX_EMail.Location = new System.Drawing.Point(82, 115);
            this.TBX_EMail.Name = "TBX_EMail";
            this.TBX_EMail.Size = new System.Drawing.Size(276, 20);
            this.TBX_EMail.TabIndex = 5;
            // 
            // TBX_LastName
            // 
            this.TBX_LastName.Location = new System.Drawing.Point(82, 55);
            this.TBX_LastName.Name = "TBX_LastName";
            this.TBX_LastName.Size = new System.Drawing.Size(276, 20);
            this.TBX_LastName.TabIndex = 1;
            this.TBX_LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBX_LastName_KeyPress);
            this.TBX_LastName.Leave += new System.EventHandler(this.TBX_LastName_Leave);
            // 
            // TBX_FirstName
            // 
            this.TBX_FirstName.Location = new System.Drawing.Point(82, 26);
            this.TBX_FirstName.Name = "TBX_FirstName";
            this.TBX_FirstName.Size = new System.Drawing.Size(276, 20);
            this.TBX_FirstName.TabIndex = 0;
            this.TBX_FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBX_FirstName_KeyPress);
            this.TBX_FirstName.Leave += new System.EventHandler(this.TBX_FirstName_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FBTN_Editer);
            this.groupBox3.Controls.Add(this.FBTN_Delete);
            this.groupBox3.Controls.Add(this.FBTN_Abort);
            this.groupBox3.Controls.Add(this.FBTN_Add);
            this.groupBox3.Controls.Add(this.LB_Comment);
            this.groupBox3.Controls.Add(this.RBTX_Comment);
            this.groupBox3.Controls.Add(this.LBX_PrescriptionNumber);
            this.groupBox3.Controls.Add(this.MTBX_PrescriptionNumber);
            this.groupBox3.Location = new System.Drawing.Point(12, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 168);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste de numéros d\'ordonnance";
            // 
            // FBTN_Editer
            // 
            this.FBTN_Editer.BackgroundImage = global::Prescription_Renewal.Properties.Resources.ICON_Editer_Neutre;
            this.FBTN_Editer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_Editer.ImageClick = null;
            this.FBTN_Editer.ImageDisable = null;
            this.FBTN_Editer.ImageNeutral = null;
            this.FBTN_Editer.ImageOver = null;
            this.FBTN_Editer.Location = new System.Drawing.Point(119, 19);
            this.FBTN_Editer.Name = "FBTN_Editer";
            this.FBTN_Editer.Size = new System.Drawing.Size(23, 26);
            this.FBTN_Editer.TabIndex = 5;
            this.FBTN_Editer.Click += new System.EventHandler(this.FBTN_Editer_Click);
            this.FBTN_Editer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FBTN_Editer_MouseDown);
            this.FBTN_Editer.MouseLeave += new System.EventHandler(this.FBTN_Editer_MouseLeave);
            this.FBTN_Editer.MouseHover += new System.EventHandler(this.FBTN_Editer_MouseHover);
            // 
            // FBTN_Delete
            // 
            this.FBTN_Delete.BackgroundImage = global::Prescription_Renewal.Properties.Resources.ICON_Delete_Neutral;
            this.FBTN_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_Delete.ImageClick = null;
            this.FBTN_Delete.ImageDisable = null;
            this.FBTN_Delete.ImageNeutral = null;
            this.FBTN_Delete.ImageOver = null;
            this.FBTN_Delete.Location = new System.Drawing.Point(119, 19);
            this.FBTN_Delete.Name = "FBTN_Delete";
            this.FBTN_Delete.Size = new System.Drawing.Size(23, 26);
            this.FBTN_Delete.TabIndex = 7;
            this.FBTN_Delete.Visible = false;
            this.FBTN_Delete.Click += new System.EventHandler(this.FBTN_Delete_Click);
            this.FBTN_Delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FBTN_Delete_MouseDown);
            this.FBTN_Delete.MouseLeave += new System.EventHandler(this.FBTN_Delete_MouseLeave);
            this.FBTN_Delete.MouseHover += new System.EventHandler(this.FBTN_Delete_MouseHover);
            // 
            // FBTN_Abort
            // 
            this.FBTN_Abort.BackgroundImage = global::Prescription_Renewal.Properties.Resources.ICON_Annuler_Neutral;
            this.FBTN_Abort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_Abort.ImageClick = null;
            this.FBTN_Abort.ImageDisable = null;
            this.FBTN_Abort.ImageNeutral = null;
            this.FBTN_Abort.ImageOver = null;
            this.FBTN_Abort.Location = new System.Drawing.Point(148, 22);
            this.FBTN_Abort.Name = "FBTN_Abort";
            this.FBTN_Abort.Size = new System.Drawing.Size(22, 23);
            this.FBTN_Abort.TabIndex = 6;
            this.FBTN_Abort.Click += new System.EventHandler(this.FBTN_Abort_Click);
            this.FBTN_Abort.Leave += new System.EventHandler(this.FBTN_Abort_Leave);
            this.FBTN_Abort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FBTN_Abort_MouseDown);
            this.FBTN_Abort.MouseLeave += new System.EventHandler(this.FBTN_Abort_MouseLeave);
            this.FBTN_Abort.MouseHover += new System.EventHandler(this.FBTN_Abort_MouseHover);
            // 
            // FBTN_Add
            // 
            this.FBTN_Add.BackgroundImage = global::Prescription_Renewal.Properties.Resources.ICON_Add_Neutral;
            this.FBTN_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_Add.ImageClick = null;
            this.FBTN_Add.ImageDisable = null;
            this.FBTN_Add.ImageNeutral = null;
            this.FBTN_Add.ImageOver = null;
            this.FBTN_Add.Location = new System.Drawing.Point(116, 22);
            this.FBTN_Add.Name = "FBTN_Add";
            this.FBTN_Add.Size = new System.Drawing.Size(26, 20);
            this.FBTN_Add.TabIndex = 5;
            this.FBTN_Add.Click += new System.EventHandler(this.FBTN_Add_Click);
            this.FBTN_Add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FBTN_Add_MouseDown);
            this.FBTN_Add.MouseLeave += new System.EventHandler(this.FBTN_Add_MouseLeave);
            this.FBTN_Add.MouseHover += new System.EventHandler(this.FBTN_Add_MouseHover);
            // 
            // LB_Comment
            // 
            this.LB_Comment.AutoSize = true;
            this.LB_Comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Comment.Location = new System.Drawing.Point(176, 25);
            this.LB_Comment.Name = "LB_Comment";
            this.LB_Comment.Size = new System.Drawing.Size(166, 13);
            this.LB_Comment.TabIndex = 3;
            this.LB_Comment.Text = "Commentaire au pharmacien";
            // 
            // RBTX_Comment
            // 
            this.RBTX_Comment.AcceptsTab = true;
            this.RBTX_Comment.Location = new System.Drawing.Point(179, 48);
            this.RBTX_Comment.Name = "RBTX_Comment";
            this.RBTX_Comment.Size = new System.Drawing.Size(179, 108);
            this.RBTX_Comment.TabIndex = 2;
            this.RBTX_Comment.Text = "";
            // 
            // LBX_PrescriptionNumber
            // 
            this.LBX_PrescriptionNumber.FormattingEnabled = true;
            this.LBX_PrescriptionNumber.Location = new System.Drawing.Point(15, 48);
            this.LBX_PrescriptionNumber.Name = "LBX_PrescriptionNumber";
            this.LBX_PrescriptionNumber.Size = new System.Drawing.Size(124, 108);
            this.LBX_PrescriptionNumber.TabIndex = 1;
            this.LBX_PrescriptionNumber.Click += new System.EventHandler(this.LBX_PrescriptionNumber_Click);
            this.LBX_PrescriptionNumber.SelectedIndexChanged += new System.EventHandler(this.LBX_PrescriptionNumber_SelectedIndexChanged);
            // 
            // MTBX_PrescriptionNumber
            // 
            this.MTBX_PrescriptionNumber.Location = new System.Drawing.Point(15, 22);
            this.MTBX_PrescriptionNumber.Name = "MTBX_PrescriptionNumber";
            this.MTBX_PrescriptionNumber.Size = new System.Drawing.Size(94, 20);
            this.MTBX_PrescriptionNumber.TabIndex = 0;
            this.MTBX_PrescriptionNumber.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MTBX_PrescriptionNumber_MaskInputRejected);
            this.MTBX_PrescriptionNumber.Click += new System.EventHandler(this.MTBX_PrescriptionNumber_Click);
            this.MTBX_PrescriptionNumber.TextChanged += new System.EventHandler(this.MTBX_PrescriptionNumber_TextChanged);
            this.MTBX_PrescriptionNumber.Enter += new System.EventHandler(this.MTBX_PrescriptionNumber_Enter);
            this.MTBX_PrescriptionNumber.Leave += new System.EventHandler(this.MTBX_PrescriptionNumber_Leave);
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.Cursor = System.Windows.Forms.Cursors.Default;
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(290, 423);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(105, 25);
            this.BTN_Ok.TabIndex = 3;
            this.BTN_Ok.Text = "Renouveler";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(175, 423);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(107, 25);
            this.BTN_Cancel.TabIndex = 4;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // DLG_PrescriptionRenewal
            // 
            this.AcceptButton = this.BTN_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BTN_Cancel;
            this.ClientSize = new System.Drawing.Size(407, 460);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DLG_PrescriptionRenewal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renouvellement d\'ordonnance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DLG_PrescriptionRenewal_FormClosing);
            this.Load += new System.EventHandler(this.DLG_PrescriptionRenewal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBB_StoreSelector;
        private System.Windows.Forms.Label LB_ZipCode;
        private System.Windows.Forms.MaskedTextBox MTBX_ZipCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TBX_EMail;
        private System.Windows.Forms.TextBox TBX_LastName;
        private System.Windows.Forms.TextBox TBX_FirstName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LB_First_Name;
        private System.Windows.Forms.Label LB_LastName;
        private System.Windows.Forms.Label LB_PhoneExtension;
        private System.Windows.Forms.TextBox TBX_PhoneExtension;
        private System.Windows.Forms.Label LB_Phone;
        private System.Windows.Forms.Label LB_EMail;
        private System.Windows.Forms.Label LB_Comment;
        private System.Windows.Forms.RichTextBox RBTX_Comment;
        private System.Windows.Forms.ListBox LBX_PrescriptionNumber;
        private System.Windows.Forms.MaskedTextBox MTBX_PrescriptionNumber;
        private System.Windows.Forms.Button BTN_Ok;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.MaskedTextBox MTBX_Phone;
        private FlashButton.FlashButton FBTN_Add;
        private FlashButton.FlashButton FBTN_Abort;
        private FlashButton.FlashButton FBTN_Delete;
        private FlashButton.FlashButton FBTN_Editer;
    }
}