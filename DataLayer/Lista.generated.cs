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
	public partial class Lista
	{
		private Int _id;
		public virtual Int Id
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
		
		private Int _candidatoPresidenteId;
		public virtual Int CandidatoPresidenteId
		{
			get
			{
				return this._candidatoPresidenteId;
			}
			set
			{
				this._candidatoPresidenteId = value;
			}
		}
		
		private Int _numero;
		public virtual Int Numero
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
		
		private string _descrizione;
		public virtual string Descrizione
		{
			get
			{
				return this._descrizione;
			}
			set
			{
				this._descrizione = value;
			}
		}
		
		private string _simbolo;
		public virtual string Simbolo
		{
			get
			{
				return this._simbolo;
			}
			set
			{
				this._simbolo = value;
			}
		}
		
		private Capolista _candidatoPresidente1;
		public virtual Capolista CandidatoPresidente1
		{
			get
			{
				return this._candidatoPresidente1;
			}
			set
			{
				this._candidatoPresidente1 = value;
			}
		}
		
		private IList<Candidato> _candidatos = new List<Candidato>();
		public virtual IList<Candidato> Candidatos
		{
			get
			{
				return this._candidatos;
			}
		}
		
	}
}
#pragma warning restore 1591
