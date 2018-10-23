using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Validation;
using System.Text.RegularExpressions;
using Prescription_Renewal;

namespace Prescription_Renewal
{
    public partial class DLG_PrescriptionRenewal : Form
    {
        internal Stores Stores;
        private Validation.ValidationProvider ValidationProvider;
        private const string EmailRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        public PrescriptionRenewal prescriptionRenewal;
        public DLG_PrescriptionRenewal(PrescriptionRenewal prescription = null)
        {
            InitializeComponent();
            prescriptionRenewal = prescription;
        }
        private void InitValidationProvider()
        {
            ValidationProvider = new Validation.ValidationProvider(this);

            ValidationProvider.AddControlToValidate(TBX_FirstName, Validate_FirstName);
            ValidationProvider.AddControlToValidate(TBX_LastName, Validate_LastName);
            ValidationProvider.AddControlToValidate(MTBX_ZipCode, Validate_ZipCode);
            ValidationProvider.AddControlToValidate(MTBX_Phone, Validate_Phone);
            ValidationProvider.AddControlToValidate(TBX_EMail, Validate_Email);
            ValidationProvider.AddControlToValidate(CBB_StoreSelector, Validate_StoreSelector);
            ValidationProvider.AddControlToValidate(MTBX_PrescriptionNumber, Validate_Prescription_Number);
        }
        private bool Validate_FirstName(ref string message)
        {
            if (TBX_FirstName.Text == "")
            message = "Prénom absent";
            return TBX_FirstName.Text != "";
        }
        private bool Validate_Prescription_Number(ref string message)
        {
            if (MTBX_PrescriptionNumber.MaskCompleted && !LBX_PrescriptionNumber.Items.Contains(MTBX_PrescriptionNumber.Text))
            {
                FBTN_Add.Enabled = true;
                FBTN_Add.Visible = true;
                LBX_PrescriptionNumber.Enabled = false;
            }
            else if (LBX_PrescriptionNumber.Items.Contains(MTBX_PrescriptionNumber.Text))
            {
                FBTN_Add.Enabled = false;
                FBTN_Add.Visible = false;
                LBX_PrescriptionNumber.Enabled = true;
                message = "Numero deja dans la liste";
                return MTBX_PrescriptionNumber.Text == "";
            }
            else
            {
                FBTN_Add.Enabled = false;
                FBTN_Add.Visible = false;
            }
            return MTBX_PrescriptionNumber.Text != "";
        }
        private bool Validate_StoreSelector(ref string message)
        {
            if (CBB_StoreSelector.SelectedItem == null)
                message = "Aucune succursale sélectionnée";
            else
                message = "Aucune succursale sélectionnée";
            return CBB_StoreSelector.Text != "";
           
        }
        private bool Validate_LastName(ref string message)
        {
            message = "Nom absent";
            return TBX_LastName.Text != "";
        }
        private bool Validate_ZipCode(ref string message)
        {
            Store foundedStore = null;
            if (MTBX_ZipCode.Text == "")
                message = "Zip code absent";
            if (MTBX_ZipCode.MaskCompleted)
            {
                 foundedStore = Stores.FindByZipCode(MTBX_ZipCode.Text);
                CBB_StoreSelector.SelectedItem = foundedStore;
                message = "Aucune surcusale trouvée";
            }
            return foundedStore != null && MTBX_ZipCode.MaskCompleted;
        }
        private bool Validate_Phone(ref string message)
        {
            if (MTBX_Phone.Text.Length != 9)
                message = "Téléphone absent / incorrecte";
            else
                message = "Téléphone absent / incorrecte";
            return MTBX_Phone.MaskCompleted;
        }
        private bool Validate_Email(ref string message)
        {
            Regex regex = new Regex(EmailRegex);
            if (!regex.IsMatch(TBX_EMail.Text))
            {
                message = "Adresse de courriel absente / incorrecte ";
            }
            return regex.Match(TBX_EMail.Text).Success;
        }
        
        private void Init_UI()
        {
            MTBX_ZipCode.Mask = "L0L";
            MTBX_ZipCode.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;

            MTBX_Phone.Mask = "(000) 000-0000";
            MTBX_Phone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;

            MTBX_PrescriptionNumber.Mask = "Rx 0000000-0000";
            MTBX_PrescriptionNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;

            if (prescriptionRenewal != null)
            {
                prescriptionRenewal_to_Dlg();
                BTN_Ok.Text = "Modify";
            }
            else
            {
                prescriptionRenewal = new PrescriptionRenewal();
                prescriptionRenewal.Store = Stores[14];
                prescriptionRenewal.Client = new Client();
            }
            

        }
        private void DLG_PrescriptionRenewal_Load(object sender, EventArgs e)
        {
            InitValidationProvider();
            Init_UI();

            CBB_StoreSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            CBB_StoreSelector.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CBB_StoreSelector.AutoCompleteSource = AutoCompleteSource.ListItems;
         
            for (int i=0; i<325;i++)
            {
                CBB_StoreSelector.Items.Add(Stores[i]);
            }
            FBTN_Abort.Visible = false;
        }

        private void prescriptionRenewal_to_Dlg()
        {
           if (prescriptionRenewal.Client != null)
            {
                CBB_StoreSelector.Text = prescriptionRenewal.Store.Address;
                TBX_FirstName.Text = prescriptionRenewal.Client.FirstName;
                TBX_LastName.Text = prescriptionRenewal.Client.LastName;
                MTBX_ZipCode.Text = prescriptionRenewal.Store.ZipCode;
                MTBX_Phone.Text = prescriptionRenewal.Client.Phone;
                TBX_EMail.Text = prescriptionRenewal.Client.EMail;
                RBTX_Comment.Text = prescriptionRenewal.Comment;
                TBX_PhoneExtension.Text = prescriptionRenewal.Client.PhoneExtension;
                LBX_PrescriptionNumber.Items.Clear();
                MTBX_PrescriptionNumber.Text = prescriptionRenewal.PrescriptionNumbers.ToString();
                LBX_PrescriptionNumber.Items.AddRange(prescriptionRenewal.PrescriptionNumbers.ToArray());
            }
        }
        private void Dlg_to_prescriptionRenewal()
        {
            prescriptionRenewal.Client.FirstName = TBX_FirstName.Text;
            prescriptionRenewal.Client.LastName = TBX_LastName.Text;
            prescriptionRenewal.Client.Phone = MTBX_Phone.Text;
            prescriptionRenewal.Client.EMail = TBX_EMail.Text;
            prescriptionRenewal.Store = (Store)(CBB_StoreSelector.SelectedItem);
            prescriptionRenewal.Comment = RBTX_Comment.Text;
            prescriptionRenewal.Store.Phone = TBX_PhoneExtension.Text;
            LBX_PrescriptionNumber.Items.AddRange(prescriptionRenewal.PrescriptionNumbers.ToArray());
        }
        private string ReformatName(string name)
        {
            // exemple: jean-françois devient Jean-François
            string reformattedName = "";
            for (int i = 0; i < name.Length; i++)
            {
                if ((i == 0) || ((i > 0) && (name[i - 1] == '\'' || name[i - 1] == '-')))
                    reformattedName += char.ToUpper(name[i]);
                else
                    reformattedName += name[i];
            }
            return reformattedName;
        }

        private void TBX_FirstName_Leave(object sender, EventArgs e)
        {
            var tbx = sender as TextBox;
            tbx.Text = ReformatName(tbx.Text);
        }

        private void TBX_FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != '\''))
            {
                e.Handled = true;
            }
        }

        private void MTBX_ZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void TBX_LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '-')
                && (e.KeyChar != '\''))
            {
                e.Handled = true;
            }
        }

        private void DLG_PrescriptionRenewal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                Dlg_to_prescriptionRenewal();
            }
        }

        private void MTBX_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)(Keys.Back)))
            {
                e.Handled = true;
            }
            else
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    if (MTBX_Phone.Text.Length > 9)
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void FBTN_Add_Click(object sender, EventArgs e)
        {
            LBX_PrescriptionNumber.Items.Add(MTBX_PrescriptionNumber.Text);
            prescriptionRenewal.Add_Prescription(MTBX_PrescriptionNumber.Text);
            MTBX_PrescriptionNumber.Text = "";
            LBX_PrescriptionNumber.Enabled = true;
        }

        private void CBB_StoreSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            string foundedZip = "";
            if (CBB_StoreSelector.SelectedItem != null)
            { 
                foundedZip = ((Store)CBB_StoreSelector.SelectedItem).ZipCode;
                MTBX_ZipCode.Text = foundedZip;
            }
        }

        private void FBTN_Abort_Click(object sender, EventArgs e)
        {
            FBTN_Abort.Visible = false;
            if (MTBX_PrescriptionNumber.MaskCompleted == false)
            {
                MTBX_PrescriptionNumber.Text = "";
            }
            else
            {
                MTBX_PrescriptionNumber.Text = "";
            }
        }

        private void FBTN_Add_MouseHover(object sender, EventArgs e)
        {
            this.FBTN_Add.BackgroundImage = Properties.Resources.ICON_Add_Over;
        }

        private void FBTN_Add_MouseLeave(object sender, EventArgs e)
        {
            this.FBTN_Add.BackgroundImage = Properties.Resources.ICON_Add_Neutral;
        }

        private void FBTN_Add_MouseDown(object sender, MouseEventArgs e)
        {
            this.FBTN_Add.BackgroundImage = Properties.Resources.ICON_Add_Click;
        }

        private void FBTN_Abort_MouseDown(object sender, MouseEventArgs e)
        {
            this.FBTN_Abort.BackgroundImage = Properties.Resources.ICON_Annuler_Click;
        }

        private void FBTN_Abort_MouseLeave(object sender, EventArgs e)
        {
            this.FBTN_Abort.BackgroundImage = Properties.Resources.ICON_Annuler_Neutral;
        }

        private void FBTN_Abort_MouseHover(object sender, EventArgs e)
        {
            this.FBTN_Abort.BackgroundImage = Properties.Resources.ICON_Annuler_Over;
        }

        private void MTBX_PrescriptionNumber_Click(object sender, EventArgs e)
        {
            if (MTBX_PrescriptionNumber.Focused)
            {
                FBTN_Abort.Visible = true;
                BTN_Cancel.Enabled = false;
                BTN_Ok.Enabled = false;
            }
            else
            {
                FBTN_Abort.Visible = false;
                BTN_Cancel.Enabled = true ;
                BTN_Ok.Enabled = true;
            }
        }

        private void MTBX_PrescriptionNumber_Leave(object sender, EventArgs e)
        {
            if (!FBTN_Abort.Focused)
            {
                FBTN_Abort.Visible = false;
                BTN_Cancel.Enabled = true;
                BTN_Ok.Enabled = true;
            }
        }

        private void FBTN_Abort_Leave(object sender, EventArgs e)
        {
            if (!MTBX_PrescriptionNumber.Focused)
            {
                FBTN_Abort.Visible = false;
                BTN_Cancel.Enabled = true;
                BTN_Ok.Enabled = true;
            }
        }

        private void MTBX_PrescriptionNumber_Enter(object sender, EventArgs e)
        {
            MTBX_PrescriptionNumber.Visible = true;
            BTN_Cancel.Enabled = false;
            BTN_Ok.Enabled = false;
        }
    }
}
