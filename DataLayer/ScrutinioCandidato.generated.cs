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
	public partial class ScrutinioCandidato
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
		
		private int _voti;
		public virtual int Voti
		{
			get
			{
				return this._voti;
			}
			set
			{
				this._voti = value;
			}
		}
		
		private int _sezioneId;
		public virtual int SezioneId
		{
			get
			{
				return this._sezioneId;
			}
			set
			{
				this._sezioneId = value;
			}
		}
		
		private int _candidatoId;
		public virtual int CandidatoId
		{
			get
			{
				return this._candidatoId;
			}
			set
			{
				this._candidatoId = value;
			}
		}
		
		private Sezione _sezione;
		public virtual Sezione Sezione
		{
			get
			{
				return this._sezione;
			}
			set
			{
				this._sezione = value;
			}
		}
		
		private Candidato _candidato;
		public virtual Candidato Candidato
		{
			get
			{
				return this._candidato;
			}
			set
			{
				this._candidato = value;
			}
		}
		
	}
}
#pragma warning restore 1591