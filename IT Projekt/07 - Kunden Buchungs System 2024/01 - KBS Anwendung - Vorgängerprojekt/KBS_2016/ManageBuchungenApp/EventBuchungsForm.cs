using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ManageBuchungenApp
{
	/// <summary>
	/// Klasse zu UC 01.1 Buchen eines Events.Ermittelt die Anzahl der zu buchenden Plaetze
	/// </summary>
	/// <remarks>
	/// Ermittelt die Anzahl der zu buchenden Plaetze.
	///</remarks>
	public class EventBuchungsForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblDaten;
		private System.Windows.Forms.TextBox txtAnzahl;
		private System.Windows.Forms.Label lblPlaetze;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// Konstruktor
		/// </summary>
		public EventBuchungsForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblDaten = new System.Windows.Forms.Label();
			this.txtAnzahl = new System.Windows.Forms.TextBox();
			this.lblPlaetze = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblDaten
			// 
			this.lblDaten.Location = new System.Drawing.Point(16, 16);
			this.lblDaten.Name = "lblDaten";
			this.lblDaten.Size = new System.Drawing.Size(272, 56);
			this.lblDaten.TabIndex = 1;
			this.lblDaten.Text = "Buchungsdaten";
			// 
			// txtAnzahl
			// 
			this.txtAnzahl.Location = new System.Drawing.Point(240, 80);
			this.txtAnzahl.Name = "txtAnzahl";
			this.txtAnzahl.Size = new System.Drawing.Size(48, 20);
			this.txtAnzahl.TabIndex = 2;
			this.txtAnzahl.Text = "";
			// 
			// lblPlaetze
			// 
			this.lblPlaetze.Location = new System.Drawing.Point(8, 80);
			this.lblPlaetze.Name = "lblPlaetze";
			this.lblPlaetze.Size = new System.Drawing.Size(216, 16);
			this.lblPlaetze.TabIndex = 3;
			this.lblPlaetze.Text = "Bitte geben Sie die Anzahl der Plätze ein!";
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(59, 120);
			this.btnOK.Name = "btnOK";
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "OK";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(163, 120);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Abbrechen";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// EventBuchungsForm
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(296, 157);
			this.ControlBox = false;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnCancel,
																		  this.btnOK,
																		  this.lblPlaetze,
																		  this.txtAnzahl,
																		  this.lblDaten});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "EventBuchungsForm";
			this.Text = "Bestätigen Sie die Buchung!";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// UC 01.2 Plaetze bei einem Event reservieren lassen
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnOK_Click(object sender, System.EventArgs e)
		{
			try
			{
				// Die gebuchten Plaetze einer Buchung werden gesetzt
				((KundenBuchungsForm) this.Owner).BuchungsPlaetze = int.Parse(this.txtAnzahl.Text);
				this.Close();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Abbruch der Buchung
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			// Form schliessen
			this.Close();
		}

		/// <summary>
		/// Die aktuellen Daten der Buchung werden uebernommen und angezeigt
		/// </summary>
		public string BuchungsDaten
		{
			set
			{
				this.lblDaten.Text = value;
			}
		}

		
	}
}
