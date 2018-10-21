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
            this.groupBox1.Size = new System.Drawing.Size(400, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choix de succursale";
            // 
            // CBB_StoreSelector
            // 
            this.CBB_StoreSelector.FormattingEnabled = true;
            this.CBB_StoreSelector.Location = new System.Drawing.Point(6, 45);
            this.CBB_StoreSelector.Name = "CBB_StoreSelector";
            this.CBB_StoreSelector.Size = new System.Drawing.Size(357, 21);
            this.CBB_StoreSelector.TabIndex = 3;
            // 
            // LB_ZipCode
            // 
            this.LB_ZipCode.AutoSize = true;
            this.LB_ZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ZipCode.Location = new System.Drawing.Point(160, 22);
            this.LB_ZipCode.Name = "LB_ZipCode";
            this.LB_ZipCode.Size = new System.Drawing.Size(161, 13);
            this.LB_ZipCode.TabIndex = 1;
            this.LB_ZipCode.Text = "Recherche par code postal";
            // 
            // MTBX_ZipCode
            // 
            this.MTBX_ZipCode.Location = new System.Drawing.Point(327, 19);
            this.MTBX_ZipCode.Name = "MTBX_ZipCode";
            this.MTBX_ZipCode.Size = new System.Drawing.Size(36, 20);
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
            this.groupBox2.Size = new System.Drawing.Size(400, 123);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations sur le client";
            // 
            // MTBX_Phone
            // 
            this.MTBX_Phone.Location = new System.Drawing.Point(82, 71);
            this.MTBX_Phone.Name = "MTBX_Phone";
            this.MTBX_Phone.Size = new System.Drawing.Size(101, 20);
            this.MTBX_Phone.TabIndex = 2;
            this.MTBX_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MTBX_Phone_KeyPress);
            // 
            // LB_EMail
            // 
            this.LB_EMail.AutoSize = true;
            this.LB_EMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_EMail.Location = new System.Drawing.Point(26, 104);
            this.LB_EMail.Name = "LB_EMail";
            this.LB_EMail.Size = new System.Drawing.Size(50, 13);
            this.LB_EMail.TabIndex = 9;
            this.LB_EMail.Text = "Courriel";
            // 
            // LB_PhoneExtension
            // 
            this.LB_PhoneExtension.AutoSize = true;
            this.LB_PhoneExtension.Location = new System.Drawing.Point(224, 78);
            this.LB_PhoneExtension.Name = "LB_PhoneExtension";
            this.LB_PhoneExtension.Size = new System.Drawing.Size(34, 13);
            this.LB_PhoneExtension.TabIndex = 8;
            this.LB_PhoneExtension.Text = "Poste";
            // 
            // TBX_PhoneExtension
            // 
            this.TBX_PhoneExtension.Location = new System.Drawing.Point(264, 71);
            this.TBX_PhoneExtension.Name = "TBX_PhoneExtension";
            this.TBX_PhoneExtension.Size = new System.Drawing.Size(76, 20);
            this.TBX_PhoneExtension.TabIndex = 3;
            // 
            // LB_Phone
            // 
            this.LB_Phone.AutoSize = true;
            this.LB_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Phone.Location = new System.Drawing.Point(12, 78);
            this.LB_Phone.Name = "LB_Phone";
            this.LB_Phone.Size = new System.Drawing.Size(67, 13);
            this.LB_Phone.TabIndex = 6;
            this.LB_Phone.Text = "Téléphone";
            // 
            // LB_LastName
            // 
            this.LB_LastName.AutoSize = true;
            this.LB_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LastName.Location = new System.Drawing.Point(44, 55);
            this.LB_LastName.Name = "LB_LastName";
            this.LB_LastName.Size = new System.Drawing.Size(32, 13);
            this.LB_LastName.TabIndex = 5;
            this.LB_LastName.Text = "Nom";
            // 
            // LB_First_Name
            // 
            this.LB_First_Name.AutoSize = true;
            this.LB_First_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_First_Name.Location = new System.Drawing.Point(27, 26);
            this.LB_First_Name.Name = "LB_First_Name";
            this.LB_First_Name.Size = new System.Drawing.Size(49, 13);
            this.LB_First_Name.TabIndex = 4;
            this.LB_First_Name.Text = "Prénom";
            // 
            // TBX_EMail
            // 
            this.TBX_EMail.Location = new System.Drawing.Point(82, 97);
            this.TBX_EMail.Name = "TBX_EMail";
            this.TBX_EMail.Size = new System.Drawing.Size(281, 20);
            this.TBX_EMail.TabIndex = 5;
            // 
            // TBX_LastName
            // 
            this.TBX_LastName.Location = new System.Drawing.Point(82, 48);
            this.TBX_LastName.Name = "TBX_LastName";
            this.TBX_LastName.Size = new System.Drawing.Size(281, 20);
            this.TBX_LastName.TabIndex = 1;
            this.TBX_LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBX_LastName_KeyPress);
            // 
            // TBX_FirstName
            // 
            this.TBX_FirstName.Location = new System.Drawing.Point(82, 19);
            this.TBX_FirstName.Name = "TBX_FirstName";
            this.TBX_FirstName.Size = new System.Drawing.Size(281, 20);
            this.TBX_FirstName.TabIndex = 0;
            this.TBX_FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBX_FirstName_KeyPress);
            this.TBX_FirstName.Leave += new System.EventHandler(this.TBX_FirstName_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FBTN_Abort);
            this.groupBox3.Controls.Add(this.FBTN_Add);
            this.groupBox3.Controls.Add(this.LB_Comment);
            this.groupBox3.Controls.Add(this.RBTX_Comment);
            this.groupBox3.Controls.Add(this.LBX_PrescriptionNumber);
            this.groupBox3.Controls.Add(this.MTBX_PrescriptionNumber);
            this.groupBox3.Location = new System.Drawing.Point(12, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 122);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste de numéros d\'ordonnance";
            // 
            // FBTN_Abort
            // 
            this.FBTN_Abort.BackgroundImage = global::Prescription_Renewal.Properties.Resources.ICON_Annuler_Neutral;
            this.FBTN_Abort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_Abort.ImageClick = null;
            this.FBTN_Abort.ImageDisable = null;
            this.FBTN_Abort.ImageNeutral = null;
            this.FBTN_Abort.ImageOver = null;
            this.FBTN_Abort.Location = new System.Drawing.Point(138, 19);
            this.FBTN_Abort.Name = "FBTN_Abort";
            this.FBTN_Abort.Size = new System.Drawing.Size(25, 20);
            this.FBTN_Abort.TabIndex = 6;
            // 
            // FBTN_Add
            // 
            this.FBTN_Add.BackgroundImage = global::Prescription_Renewal.Properties.Resources.ICON_Add_Neutral;
            this.FBTN_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FBTN_Add.ImageClick = null;
            this.FBTN_Add.ImageDisable = null;
            this.FBTN_Add.ImageNeutral = null;
            this.FBTN_Add.ImageOver = null;
            this.FBTN_Add.Location = new System.Drawing.Point(109, 19);
            this.FBTN_Add.Name = "FBTN_Add";
            this.FBTN_Add.Size = new System.Drawing.Size(23, 20);
            this.FBTN_Add.TabIndex = 5;
            // 
            // LB_Comment
            // 
            this.LB_Comment.AutoSize = true;
            this.LB_Comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Comment.Location = new System.Drawing.Point(169, 29);
            this.LB_Comment.Name = "LB_Comment";
            this.LB_Comment.Size = new System.Drawing.Size(166, 13);
            this.LB_Comment.TabIndex = 3;
            this.LB_Comment.Text = "Commentaire du pharmacien";
            // 
            // RBTX_Comment
            // 
            this.RBTX_Comment.Location = new System.Drawing.Point(163, 45);
            this.RBTX_Comment.Name = "RBTX_Comment";
            this.RBTX_Comment.Size = new System.Drawing.Size(208, 69);
            this.RBTX_Comment.TabIndex = 2;
            this.RBTX_Comment.Text = "";
            // 
            // LBX_PrescriptionNumber
            // 
            this.LBX_PrescriptionNumber.FormattingEnabled = true;
            this.LBX_PrescriptionNumber.Location = new System.Drawing.Point(6, 45);
            this.LBX_PrescriptionNumber.Name = "LBX_PrescriptionNumber";
            this.LBX_PrescriptionNumber.Size = new System.Drawing.Size(117, 69);
            this.LBX_PrescriptionNumber.TabIndex = 1;
            // 
            // MTBX_PrescriptionNumber
            // 
            this.MTBX_PrescriptionNumber.Location = new System.Drawing.Point(6, 19);
            this.MTBX_PrescriptionNumber.Name = "MTBX_PrescriptionNumber";
            this.MTBX_PrescriptionNumber.Size = new System.Drawing.Size(100, 20);
            this.MTBX_PrescriptionNumber.TabIndex = 0;
            // 
            // BTN_Ok
            // 
            this.BTN_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Ok.Location = new System.Drawing.Point(256, 350);
            this.BTN_Ok.Name = "BTN_Ok";
            this.BTN_Ok.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ok.TabIndex = 3;
            this.BTN_Ok.Text = "Renouveler";
            this.BTN_Ok.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Cancel.Location = new System.Drawing.Point(337, 350);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(75, 23);
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
            this.ClientSize = new System.Drawing.Size(439, 382);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_Ok);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DLG_PrescriptionRenewal";
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
    }
}