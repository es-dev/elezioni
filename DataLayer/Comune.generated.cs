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
	public partial class Comune
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
		
		private string _provincia;
		public virtual string Provincia
		{
			get
			{
				return this._provincia;
			}
			set
			{
				this._provincia = value;
			}
		}
		
		private string _codiceISTAT;
		public virtual string CodiceISTAT
		{
			get
			{
				return this._codiceISTAT;
			}
			set
			{
				this._codiceISTAT = value;
			}
		}
		
		private IList<Consultazione> _consultaziones = new List<Consultazione>();
		public virtual IList<Consultazione> Consultaziones
		{
			get
			{
				return this._consultaziones;
			}
		}
		
		private IList<SedeElettorale> _sedeElettorales = new List<SedeElettorale>();
		public virtual IList<SedeElettorale> SedeElettorales
		{
			get
			{
				return this._sedeElettorales;
			}
		}
		
	}
}
#pragma warning restore 1591
