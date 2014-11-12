using System.Drawing;

namespace Web.GUI.Operatore
{
    partial class OperatoreModel
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
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Visual WebGui Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.editEmail = new Library.Template.Controls.TemplateEditEmail();
            this.editCognome = new Library.Template.Controls.TemplateEditText();
            this.editConfermaPassword = new Library.Template.Controls.TemplateEditPassword();
            this.editPassword = new Library.Template.Controls.TemplateEditPassword();
            this.editNome = new Library.Template.Controls.TemplateEditText();
            this.editNomeUtente = new Library.Template.Controls.TemplateEditText();
            this.editTelefono = new Library.Template.Controls.TemplateEditText();
            this.editAmministratore = new Library.Template.Controls.TemplateEditCheckBox();
            this.editUtente = new Library.Template.Controls.TemplateEditCheckBox();
            this.editSupervisor = new Library.Template.Controls.TemplateEditCheckBox();
            this.editConsultazione = new Library.Template.Controls.TemplateEditCombo();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editConsultazione);
            this.container.Controls.Add(this.editSupervisor);
            this.container.Controls.Add(this.editUtente);
            this.container.Controls.Add(this.editAmministratore);
            this.container.Controls.Add(this.editTelefono);
            this.container.Controls.Add(this.editNomeUtente);
            this.container.Controls.Add(this.editNome);
            this.container.Controls.Add(this.editPassword);
            this.container.Controls.Add(this.editConfermaPassword);
            this.container.Controls.Add(this.editCognome);
            this.container.Controls.Add(this.editEmail);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editEmail, 0);
            this.container.Controls.SetChildIndex(this.editCognome, 0);
            this.container.Controls.SetChildIndex(this.editConfermaPassword, 0);
            this.container.Controls.SetChildIndex(this.editPassword, 0);
            this.container.Controls.SetChildIndex(this.editNome, 0);
            this.container.Controls.SetChildIndex(this.editNomeUtente, 0);
            this.container.Controls.SetChildIndex(this.editTelefono, 0);
            this.container.Controls.SetChildIndex(this.editAmministratore, 0);
            this.container.Controls.SetChildIndex(this.editUtente, 0);
            this.container.Controls.SetChildIndex(this.editSupervisor, 0);
            this.container.Controls.SetChildIndex(this.editConsultazione, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(666, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(610, 3);
            // 
            // editEmail
            // 
            this.editEmail.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editEmail.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editEmail.BackColor = System.Drawing.Color.Transparent;
            this.editEmail.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editEmail.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editEmail.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editEmail.Changed = false;
            this.editEmail.Editing = false;
            this.editEmail.Label = "Email";
            this.editEmail.LabelWidth = 175;
            this.editEmail.Location = new System.Drawing.Point(20, 345);
            this.editEmail.Name = "templateEditEmail1";
            this.editEmail.ReadOnly = false;
            this.editEmail.Required = false;
            this.editEmail.Size = new System.Drawing.Size(800, 30);
            this.editEmail.TabIndex = 2;
            this.editEmail.Text = "TemplateEditEmail";
            this.editEmail.Value = "";
            // 
            // editCognome
            // 
            this.editCognome.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editCognome.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editCognome.BackColor = System.Drawing.Color.Transparent;
            this.editCognome.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editCognome.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editCognome.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editCognome.Changed = false;
            this.editCognome.Editing = false;
            this.editCognome.Label = "Cognome";
            this.editCognome.LabelWidth = 175;
            this.editCognome.Location = new System.Drawing.Point(20, 120);
            this.editCognome.Multiline = false;
            this.editCognome.Name = "editCognome";
            this.editCognome.ReadOnly = false;
            this.editCognome.Required = false;
            this.editCognome.Size = new System.Drawing.Size(800, 30);
            this.editCognome.TabIndex = 3;
            this.editCognome.Text = "EditControl";
            this.editCognome.Value = "";
            // 
            // editConfermaPassword
            // 
            this.editConfermaPassword.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editConfermaPassword.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editConfermaPassword.BackColor = System.Drawing.Color.Transparent;
            this.editConfermaPassword.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editConfermaPassword.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editConfermaPassword.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editConfermaPassword.Changed = false;
            this.editConfermaPassword.Editing = true;
            this.editConfermaPassword.Label = "Conferma password";
            this.editConfermaPassword.LabelWidth = 175;
            this.editConfermaPassword.Location = new System.Drawing.Point(20, 300);
            this.editConfermaPassword.Name = "editConfermaPassword";
            this.editConfermaPassword.Password = true;
            this.editConfermaPassword.ReadOnly = false;
            this.editConfermaPassword.Required = false;
            this.editConfermaPassword.Size = new System.Drawing.Size(800, 30);
            this.editConfermaPassword.TabIndex = 4;
            this.editConfermaPassword.Text = "EditControl";
            this.editConfermaPassword.Value = "";
            // 
            // editPassword
            // 
            this.editPassword.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editPassword.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editPassword.BackColor = System.Drawing.Color.Transparent;
            this.editPassword.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editPassword.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editPassword.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editPassword.Changed = false;
            this.editPassword.Editing = false;
            this.editPassword.Label = "Password";
            this.editPassword.LabelWidth = 175;
            this.editPassword.Location = new System.Drawing.Point(20, 255);
            this.editPassword.Name = "templateEditPassword2";
            this.editPassword.Password = true;
            this.editPassword.ReadOnly = false;
            this.editPassword.Required = false;
            this.editPassword.Size = new System.Drawing.Size(800, 30);
            this.editPassword.TabIndex = 5;
            this.editPassword.Text = "EditControl";
            this.editPassword.Value = "";
            // 
            // editNome
            // 
            this.editNome.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editNome.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editNome.BackColor = System.Drawing.Color.Transparent;
            this.editNome.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editNome.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editNome.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editNome.Changed = false;
            this.editNome.Editing = false;
            this.editNome.Label = "Nome";
            this.editNome.LabelWidth = 175;
            this.editNome.Location = new System.Drawing.Point(20, 165);
            this.editNome.Multiline = false;
            this.editNome.Name = "editNome";
            this.editNome.ReadOnly = false;
            this.editNome.Required = false;
            this.editNome.Size = new System.Drawing.Size(800, 30);
            this.editNome.TabIndex = 6;
            this.editNome.Text = "EditControl";
            this.editNome.Value = "";
            // 
            // editNomeUtente
            // 
            this.editNomeUtente.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editNomeUtente.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editNomeUtente.BackColor = System.Drawing.Color.Transparent;
            this.editNomeUtente.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editNomeUtente.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editNomeUtente.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editNomeUtente.Changed = false;
            this.editNomeUtente.Editing = false;
            this.editNomeUtente.Label = "Nome utente";
            this.editNomeUtente.LabelWidth = 175;
            this.editNomeUtente.Location = new System.Drawing.Point(20, 210);
            this.editNomeUtente.Multiline = false;
            this.editNomeUtente.Name = "editNomeUtente";
            this.editNomeUtente.ReadOnly = false;
            this.editNomeUtente.Required = false;
            this.editNomeUtente.Size = new System.Drawing.Size(800, 30);
            this.editNomeUtente.TabIndex = 7;
            this.editNomeUtente.Text = "EditControl";
            this.editNomeUtente.Value = "";
            // 
            // editTelefono
            // 
            this.editTelefono.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editTelefono.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTelefono.BackColor = System.Drawing.Color.Transparent;
            this.editTelefono.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTelefono.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTelefono.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTelefono.Changed = false;
            this.editTelefono.Editing = false;
            this.editTelefono.Label = "Telefono";
            this.editTelefono.LabelWidth = 175;
            this.editTelefono.Location = new System.Drawing.Point(20, 390);
            this.editTelefono.Multiline = false;
            this.editTelefono.Name = "editTelefono";
            this.editTelefono.ReadOnly = false;
            this.editTelefono.Required = false;
            this.editTelefono.Size = new System.Drawing.Size(800, 30);
            this.editTelefono.TabIndex = 8;
            this.editTelefono.Text = "EditControl";
            this.editTelefono.Value = "";
            // 
            // editAmministratore
            // 
            this.editAmministratore.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editAmministratore.BackColor = System.Drawing.Color.Transparent;
            this.editAmministratore.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editAmministratore.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editAmministratore.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editAmministratore.Changed = false;
            this.editAmministratore.Editing = false;
            this.editAmministratore.Label = "Amministratore";
            this.editAmministratore.LabelWidth = 175;
            this.editAmministratore.Location = new System.Drawing.Point(20, 480);
            this.editAmministratore.Name = "editAmministratore";
            this.editAmministratore.ReadOnly = false;
            this.editAmministratore.Required = false;
            this.editAmministratore.Size = new System.Drawing.Size(456, 30);
            this.editAmministratore.TabIndex = 9;
            this.editAmministratore.Text = "TemplateCheckBox";
            this.editAmministratore.TextFalse = "";
            this.editAmministratore.TextTrue = "";
            this.editAmministratore.Value = null;
            // 
            // editUtente
            // 
            this.editUtente.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editUtente.BackColor = System.Drawing.Color.Transparent;
            this.editUtente.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editUtente.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editUtente.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editUtente.Changed = false;
            this.editUtente.Editing = false;
            this.editUtente.Label = "Utente";
            this.editUtente.LabelWidth = 175;
            this.editUtente.Location = new System.Drawing.Point(20, 525);
            this.editUtente.Name = "editUtente";
            this.editUtente.ReadOnly = false;
            this.editUtente.Required = false;
            this.editUtente.Size = new System.Drawing.Size(456, 30);
            this.editUtente.TabIndex = 10;
            this.editUtente.Text = "TemplateCheckBox";
            this.editUtente.TextFalse = "";
            this.editUtente.TextTrue = "";
            this.editUtente.Value = null;
            // 
            // editSupervisor
            // 
            this.editSupervisor.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editSupervisor.BackColor = System.Drawing.Color.Transparent;
            this.editSupervisor.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editSupervisor.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editSupervisor.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editSupervisor.Changed = false;
            this.editSupervisor.Editing = false;
            this.editSupervisor.Label = "Supervisor";
            this.editSupervisor.LabelWidth = 175;
            this.editSupervisor.Location = new System.Drawing.Point(20, 435);
            this.editSupervisor.Name = "editSupervisor";
            this.editSupervisor.ReadOnly = false;
            this.editSupervisor.Required = false;
            this.editSupervisor.Size = new System.Drawing.Size(456, 30);
            this.editSupervisor.TabIndex = 11;
            this.editSupervisor.Text = "TemplateCheckBox";
            this.editSupervisor.TextFalse = "";
            this.editSupervisor.TextTrue = "";
            this.editSupervisor.Value = null;
            // 
            // editConsultazione
            // 
            this.editConsultazione.Anchor = ((Gizmox.WebGUI.Forms.AnchorStyles)(((Gizmox.WebGUI.Forms.AnchorStyles.Top | Gizmox.WebGUI.Forms.AnchorStyles.Left) 
            | Gizmox.WebGUI.Forms.AnchorStyles.Right)));
            this.editConsultazione.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editConsultazione.BackColor = System.Drawing.Color.Transparent;
            this.editConsultazione.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editConsultazione.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editConsultazione.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editConsultazione.Changed = false;
            this.editConsultazione.Editing = false;
            this.editConsultazione.Label = "Consultazione";
            this.editConsultazione.LabelWidth = 175;
            this.editConsultazione.Location = new System.Drawing.Point(20, 75);
            this.editConsultazione.Model = null;
            this.editConsultazione.Multiline = false;
            this.editConsultazione.Name = "editConsultazione";
            this.editConsultazione.ReadOnly = false;
            this.editConsultazione.Required = false;
            this.editConsultazione.Size = new System.Drawing.Size(798, 30);
            this.editConsultazione.TabIndex = 12;
            this.editConsultazione.Text = "EditControl";
            this.editConsultazione.Value = "";
            this.editConsultazione.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editConsultazione_ComboConfirm);
            this.editConsultazione.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editConsultazione_ComboClick);
            this.Controls.SetChildIndex(this.container, 0);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditText editNomeUtente;
        private Library.Template.Controls.TemplateEditText editNome;
        private Library.Template.Controls.TemplateEditPassword editConfermaPassword;
        private Library.Template.Controls.TemplateEditText editCognome;
        private Library.Template.Controls.TemplateEditText editTelefono;
        private Library.Template.Controls.TemplateEditPassword editPassword;
        private Library.Template.Controls.TemplateEditEmail editEmail;
        private Library.Template.Controls.TemplateEditCheckBox editSupervisor;
        private Library.Template.Controls.TemplateEditCheckBox editUtente;
        private Library.Template.Controls.TemplateEditCheckBox editAmministratore;
        private Library.Template.Controls.TemplateEditCombo editConsultazione;


    }
}
