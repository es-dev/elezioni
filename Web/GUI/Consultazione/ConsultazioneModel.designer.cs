using System.Drawing;

namespace Web.GUI.Consultazione
{
    partial class ConsultazioneModel
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
            this.editComune = new Library.Template.Controls.TemplateEditCombo();
            this.editDescrizione = new Library.Template.Controls.TemplateEditText();
            this.editNumero = new Library.Template.Controls.TemplateEditNumeric();
            this.editFine = new Library.Template.Controls.TemplateEditData();
            this.editTipo = new Library.Template.Controls.TemplateEditText();
            this.editInizio = new Library.Template.Controls.TemplateEditData();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.editInizio);
            this.container.Controls.Add(this.editTipo);
            this.container.Controls.Add(this.editFine);
            this.container.Controls.Add(this.editNumero);
            this.container.Controls.Add(this.editDescrizione);
            this.container.Controls.Add(this.editComune);
            this.container.Controls.SetChildIndex(this.infoSubtitleImage, 0);
            this.container.Controls.SetChildIndex(this.infoSubtitle, 0);
            this.container.Controls.SetChildIndex(this.editComune, 0);
            this.container.Controls.SetChildIndex(this.editDescrizione, 0);
            this.container.Controls.SetChildIndex(this.editNumero, 0);
            this.container.Controls.SetChildIndex(this.editFine, 0);
            this.container.Controls.SetChildIndex(this.editTipo, 0);
            this.container.Controls.SetChildIndex(this.editInizio, 0);
            // 
            // infoSubtitle
            // 
            this.infoSubtitle.Location = new System.Drawing.Point(666, 3);
            // 
            // infoSubtitleImage
            // 
            this.infoSubtitleImage.Location = new System.Drawing.Point(610, 3);
            // 
            // editComune
            // 
            this.editComune.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editComune.BackColor = System.Drawing.Color.Transparent;
            this.editComune.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editComune.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editComune.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editComune.Changed = false;
            this.editComune.Editing = false;
            this.editComune.Label = "Comune";
            this.editComune.LabelWidth = 175;
            this.editComune.Location = new System.Drawing.Point(20, 75);
            this.editComune.Model = null;
            this.editComune.Name = "editComune";
            this.editComune.ReadOnly = false;
            this.editComune.Required = false;
            this.editComune.Size = new System.Drawing.Size(800, 30);
            this.editComune.TabIndex = 2;
            this.editComune.Text = "EditControl";
            this.editComune.Value = "";
            this.editComune.ComboConfirm += new Library.Template.Controls.TemplateEditCombo.ComboConfirmHanlder(this.editComune_ComboConfirm);
            this.editComune.ComboClick += new Library.Template.Controls.TemplateEditCombo.ComboClickHandler(this.editComune_ComboClick);
            // 
            // editDescrizione
            // 
            this.editDescrizione.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editDescrizione.BackColor = System.Drawing.Color.Transparent;
            this.editDescrizione.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editDescrizione.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editDescrizione.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editDescrizione.Changed = false;
            this.editDescrizione.Editing = false;
            this.editDescrizione.Label = "Descrizione";
            this.editDescrizione.LabelWidth = 175;
            this.editDescrizione.Location = new System.Drawing.Point(20, 167);
            this.editDescrizione.Name = "editDescrizione";
            this.editDescrizione.ReadOnly = false;
            this.editDescrizione.Required = false;
            this.editDescrizione.Size = new System.Drawing.Size(800, 30);
            this.editDescrizione.TabIndex = 4;
            this.editDescrizione.Text = "EditControl";
            this.editDescrizione.Value = "";
            // 
            // editNumero
            // 
            this.editNumero.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editNumero.BackColor = System.Drawing.Color.Transparent;
            this.editNumero.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editNumero.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editNumero.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editNumero.Changed = false;
            this.editNumero.Editing = false;
            this.editNumero.Label = "Numero";
            this.editNumero.LabelWidth = 175;
            this.editNumero.Location = new System.Drawing.Point(20, 305);
            this.editNumero.Name = "editNumero";
            this.editNumero.ReadOnly = false;
            this.editNumero.Required = false;
            this.editNumero.Size = new System.Drawing.Size(800, 30);
            this.editNumero.TabIndex = 7;
            this.editNumero.Text = "EditControl";
            this.editNumero.Value = 0;
            // 
            // editFine
            // 
            this.editFine.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editFine.BackColor = System.Drawing.Color.Transparent;
            this.editFine.Changed = false;
            this.editFine.Editing = false;
            this.editFine.Label = "Fine";
            this.editFine.LabelWidth = 175;
            this.editFine.Location = new System.Drawing.Point(20, 259);
            this.editFine.Name = "templateEditData2";
            this.editFine.ReadOnly = false;
            this.editFine.Required = false;
            this.editFine.Size = new System.Drawing.Size(386, 30);
            this.editFine.TabIndex = 9;
            this.editFine.Text = "TemplateEditData";
            this.editFine.Value = null;
            // 
            // editTipo
            // 
            this.editTipo.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editTipo.BackColor = System.Drawing.Color.Transparent;
            this.editTipo.BorderColor = new Gizmox.WebGUI.Forms.BorderColor(System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))));
            this.editTipo.BorderStyle = Gizmox.WebGUI.Forms.BorderStyle.FixedSingle;
            this.editTipo.BorderWidth = new Gizmox.WebGUI.Forms.BorderWidth(0, 0, 0, 1);
            this.editTipo.Changed = false;
            this.editTipo.Editing = false;
            this.editTipo.Label = "Tipo";
            this.editTipo.LabelWidth = 175;
            this.editTipo.Location = new System.Drawing.Point(20, 121);
            this.editTipo.Name = "editTipo";
            this.editTipo.ReadOnly = false;
            this.editTipo.Required = false;
            this.editTipo.Size = new System.Drawing.Size(800, 30);
            this.editTipo.TabIndex = 10;
            this.editTipo.Text = "EditControl";
            this.editTipo.Value = "";
            // 
            // editInizio
            // 
            this.editInizio.AutoValidate = Gizmox.WebGUI.Forms.AutoValidate.EnablePreventFocusChange;
            this.editInizio.BackColor = System.Drawing.Color.Transparent;
            this.editInizio.Changed = false;
            this.editInizio.Editing = false;
            this.editInizio.Label = "Inizio";
            this.editInizio.LabelWidth = 175;
            this.editInizio.Location = new System.Drawing.Point(20, 210);
            this.editInizio.Name = "editInizio";
            this.editInizio.ReadOnly = false;
            this.editInizio.Required = false;
            this.editInizio.Size = new System.Drawing.Size(400, 30);
            this.editInizio.TabIndex = 11;
            this.editInizio.Text = "TemplateEditData";
            this.editInizio.Value = null;
            this.Controls.SetChildIndex(this.container, 0);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoSubtitleImage)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private Library.Template.Controls.TemplateEditNumeric editNumero;
        private Library.Template.Controls.TemplateEditText editDescrizione;
        private Library.Template.Controls.TemplateEditCombo editComune;
        private Library.Template.Controls.TemplateEditData editFine;
        private Library.Template.Controls.TemplateEditText editTipo;
        private Library.Template.Controls.TemplateEditData editInizio;


    }
}
