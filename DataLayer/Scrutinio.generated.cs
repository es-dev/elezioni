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
	public partial class Scrutinio
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
		
		private Int _votiUomini;
		public virtual Int VotiUomini
		{
			get
			{
				return this._votiUomini;
			}
			set
			{
				this._votiUomini = value;
			}
		}
		
		private Int _votiDonne;
		public virtual Int VotiDonne
		{
			get
			{
				return this._votiDonne;
			}
			set
			{
				this._votiDonne = value;
			}
		}
		
		private Int _votiEspressi;
		public virtual Int VotiEspressi
		{
			get
			{
				return this._votiEspressi;
			}
			set
			{
				this._votiEspressi = value;
			}
		}
		
		private Int _votiValidi;
		public virtual Int VotiValidi
		{
			get
			{
				return this._votiValidi;
			}
			set
			{
				this._votiValidi = value;
			}
		}
		
		private Int _schedeNulle;
		public virtual Int SchedeNulle
		{
			get
			{
				return this._schedeNulle;
			}
			set
			{
				this._schedeNulle = value;
			}
		}
		
		private Int _schedeBianche;
		public virtual Int SchedeBianche
		{
			get
			{
				return this._schedeBianche;
			}
			set
			{
				this._schedeBianche = value;
			}
		}
		
		private Int _schedeContestate;
		public virtual Int SchedeContestate
		{
			get
			{
				return this._schedeContestate;
			}
			set
			{
				this._schedeContestate = value;
			}
		}
		
		private string _stato;
		public virtual string Stato
		{
			get
			{
				return this._stato;
			}
			set
			{
				this._stato = value;
			}
		}
		
		private Nullable`1[[Int _si;
		public virtual Nullable`1[[Int Si
		{
			get
			{
				return this._si;
			}
			set
			{
				this._si = value;
			}
		}
		
		private Nullable`1[[Int _no;
		public virtual Nullable`1[[Int No
		{
			get
			{
				return this._no;
			}
			set
			{
				this._no = value;
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
		
	}
}
#pragma warning restore 1591
