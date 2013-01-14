﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Views.Security
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Gray_GymManager")]
	public partial class SecurityViewDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public SecurityViewDataContext() : 
				base(global::DAL.Properties.Settings.Default.Gray_GymManagerConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SecurityViewDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SecurityViewDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SecurityViewDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SecurityViewDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Locked_Objects_View> Locked_Objects_Views
		{
			get
			{
				return this.GetTable<Locked_Objects_View>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Locked_Objects_View")]
	public partial class Locked_Objects_View
	{
		
		private string _Description;
		
		private string _UserName;
		
		private int _ModuleCode;
		
		private int _User_id;
		
		private int _Pk_Id;
		
		private System.DateTime _LockDate;
		
		public Locked_Objects_View()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this._Description = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(101) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this._UserName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModuleCode", DbType="Int NOT NULL")]
		public int ModuleCode
		{
			get
			{
				return this._ModuleCode;
			}
			set
			{
				if ((this._ModuleCode != value))
				{
					this._ModuleCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_id", DbType="Int NOT NULL")]
		public int User_id
		{
			get
			{
				return this._User_id;
			}
			set
			{
				if ((this._User_id != value))
				{
					this._User_id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pk_Id", DbType="Int NOT NULL")]
		public int Pk_Id
		{
			get
			{
				return this._Pk_Id;
			}
			set
			{
				if ((this._Pk_Id != value))
				{
					this._Pk_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LockDate", DbType="DateTime NOT NULL")]
		public System.DateTime LockDate
		{
			get
			{
				return this._LockDate;
			}
			set
			{
				if ((this._LockDate != value))
				{
					this._LockDate = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
