﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanQA.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLCuaHangBanQA")]
	public partial class DBSizeDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSize(Size instance);
    partial void UpdateSize(Size instance);
    partial void DeleteSize(Size instance);
    #endregion
		
		public DBSizeDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QLCuaHangBanQAConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBSizeDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBSizeDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBSizeDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBSizeDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Size> Sizes
		{
			get
			{
				return this.GetTable<Size>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Size")]
	public partial class Size : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _S_id;
		
		private string _S_name;
		
		private string _S_PID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnS_idChanging(string value);
    partial void OnS_idChanged();
    partial void OnS_nameChanging(string value);
    partial void OnS_nameChanged();
    partial void OnS_PIDChanging(string value);
    partial void OnS_PIDChanged();
    #endregion
		
		public Size()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_S_id", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string S_id
		{
			get
			{
				return this._S_id;
			}
			set
			{
				if ((this._S_id != value))
				{
					this.OnS_idChanging(value);
					this.SendPropertyChanging();
					this._S_id = value;
					this.SendPropertyChanged("S_id");
					this.OnS_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_S_name", DbType="NVarChar(200)")]
		public string S_name
		{
			get
			{
				return this._S_name;
			}
			set
			{
				if ((this._S_name != value))
				{
					this.OnS_nameChanging(value);
					this.SendPropertyChanging();
					this._S_name = value;
					this.SendPropertyChanged("S_name");
					this.OnS_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_S_PID", DbType="VarChar(10)")]
		public string S_PID
		{
			get
			{
				return this._S_PID;
			}
			set
			{
				if ((this._S_PID != value))
				{
					this.OnS_PIDChanging(value);
					this.SendPropertyChanging();
					this._S_PID = value;
					this.SendPropertyChanged("S_PID");
					this.OnS_PIDChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591