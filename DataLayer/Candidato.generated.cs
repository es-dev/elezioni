#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using DataLayer;

namespace DataLayer	
{
	public partial class Candidato
	{
		private int _id;
		public virtual int Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		
		private int _listaId;
		public virtual int ListaId
		{
			get
			{
				return this._listaId;
			}
			set
			{
				this._listaId = value;
			}
		}
		
		private int _numero;
		public virtual int Numero
		{
			get
			{
				return this._numero;
			}
			set
			{
				this._numero = value;
			}
		}
		
		private string _cognome;
		public virtual string Cognome
		{
			get
			{
				return this._cognome;
			}
			set
			{
				this._cognome = value;
			}
		}
		
		private string _nome;
		public virtual string Nome
		{
			get
			{
				return this._nome;
			}
			set
			{
				this._nome = value;
			}
		}
		
		private Lista _lista;
		public virtual Lista Lista
		{
			get
			{
				return this._lista;
			}
			set
			{
				this._lista = value;
			}
		}
		
		private IList<ScrutinioCandidato> _scrutinioCandidatos = new List<ScrutinioCandidato>();
		public virtual IList<ScrutinioCandidato> ScrutinioCandidatos
		{
			get
			{
				return this._scrutinioCandidatos;
			}
		}
		
	}
}
#pragma warning restore 1591
