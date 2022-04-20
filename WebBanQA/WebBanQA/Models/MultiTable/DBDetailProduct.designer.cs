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

namespace WebBanQA.Models.MultiTable
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
	public partial class DBDetailProductDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertSize(Size instance);
    partial void UpdateSize(Size instance);
    partial void DeleteSize(Size instance);
    partial void InsertColor(Color instance);
    partial void UpdateColor(Color instance);
    partial void DeleteColor(Color instance);
    #endregion
		
		public DBDetailProductDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QLCuaHangBanQAConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBDetailProductDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDetailProductDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDetailProductDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDetailProductDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<Size> Sizes
		{
			get
			{
				return this.GetTable<Size>();
			}
		}
		
		public System.Data.Linq.Table<Color> Colors
		{
			get
			{
				return this.GetTable<Color>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Product")]
	public partial class Product : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _P_id;
		
		private string _P_name;
		
		private System.Nullable<double> _P_discount;
		
		private System.Nullable<decimal> _P_Price;
		
		private string _P_image;
		
		private string _P_note;
		
		private System.Nullable<int> _P_amount;
		
		private string _P_content;
		
		private string _P_CAID;
		
		private string _P_slug;
		
		private EntitySet<Size> _Sizes;
		
		private EntitySet<Color> _Colors;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnP_idChanging(string value);
    partial void OnP_idChanged();
    partial void OnP_nameChanging(string value);
    partial void OnP_nameChanged();
    partial void OnP_discountChanging(System.Nullable<double> value);
    partial void OnP_discountChanged();
    partial void OnP_PriceChanging(System.Nullable<decimal> value);
    partial void OnP_PriceChanged();
    partial void OnP_imageChanging(string value);
    partial void OnP_imageChanged();
    partial void OnP_noteChanging(string value);
    partial void OnP_noteChanged();
    partial void OnP_amountChanging(System.Nullable<int> value);
    partial void OnP_amountChanged();
    partial void OnP_contentChanging(string value);
    partial void OnP_contentChanged();
    partial void OnP_CAIDChanging(string value);
    partial void OnP_CAIDChanged();
    partial void OnP_slugChanging(string value);
    partial void OnP_slugChanged();
    #endregion
		
		public Product()
		{
			this._Sizes = new EntitySet<Size>(new Action<Size>(this.attach_Sizes), new Action<Size>(this.detach_Sizes));
			this._Colors = new EntitySet<Color>(new Action<Color>(this.attach_Colors), new Action<Color>(this.detach_Colors));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_id", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string P_id
		{
			get
			{
				return this._P_id;
			}
			set
			{
				if ((this._P_id != value))
				{
					this.OnP_idChanging(value);
					this.SendPropertyChanging();
					this._P_id = value;
					this.SendPropertyChanged("P_id");
					this.OnP_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_name", DbType="NVarChar(200)")]
		public string P_name
		{
			get
			{
				return this._P_name;
			}
			set
			{
				if ((this._P_name != value))
				{
					this.OnP_nameChanging(value);
					this.SendPropertyChanging();
					this._P_name = value;
					this.SendPropertyChanged("P_name");
					this.OnP_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_discount", DbType="Float")]
		public System.Nullable<double> P_discount
		{
			get
			{
				return this._P_discount;
			}
			set
			{
				if ((this._P_discount != value))
				{
					this.OnP_discountChanging(value);
					this.SendPropertyChanging();
					this._P_discount = value;
					this.SendPropertyChanged("P_discount");
					this.OnP_discountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_Price", DbType="Money")]
		public System.Nullable<decimal> P_Price
		{
			get
			{
				return this._P_Price;
			}
			set
			{
				if ((this._P_Price != value))
				{
					this.OnP_PriceChanging(value);
					this.SendPropertyChanging();
					this._P_Price = value;
					this.SendPropertyChanged("P_Price");
					this.OnP_PriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_image", DbType="NVarChar(300)")]
		public string P_image
		{
			get
			{
				return this._P_image;
			}
			set
			{
				if ((this._P_image != value))
				{
					this.OnP_imageChanging(value);
					this.SendPropertyChanging();
					this._P_image = value;
					this.SendPropertyChanged("P_image");
					this.OnP_imageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_note", DbType="NVarChar(2000)")]
		public string P_note
		{
			get
			{
				return this._P_note;
			}
			set
			{
				if ((this._P_note != value))
				{
					this.OnP_noteChanging(value);
					this.SendPropertyChanging();
					this._P_note = value;
					this.SendPropertyChanged("P_note");
					this.OnP_noteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_amount", DbType="Int")]
		public System.Nullable<int> P_amount
		{
			get
			{
				return this._P_amount;
			}
			set
			{
				if ((this._P_amount != value))
				{
					this.OnP_amountChanging(value);
					this.SendPropertyChanging();
					this._P_amount = value;
					this.SendPropertyChanged("P_amount");
					this.OnP_amountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_content", DbType="NVarChar(2000)")]
		public string P_content
		{
			get
			{
				return this._P_content;
			}
			set
			{
				if ((this._P_content != value))
				{
					this.OnP_contentChanging(value);
					this.SendPropertyChanging();
					this._P_content = value;
					this.SendPropertyChanged("P_content");
					this.OnP_contentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_CAID", DbType="VarChar(10)")]
		public string P_CAID
		{
			get
			{
				return this._P_CAID;
			}
			set
			{
				if ((this._P_CAID != value))
				{
					this.OnP_CAIDChanging(value);
					this.SendPropertyChanging();
					this._P_CAID = value;
					this.SendPropertyChanged("P_CAID");
					this.OnP_CAIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_P_slug", DbType="NVarChar(100)")]
		public string P_slug
		{
			get
			{
				return this._P_slug;
			}
			set
			{
				if ((this._P_slug != value))
				{
					this.OnP_slugChanging(value);
					this.SendPropertyChanging();
					this._P_slug = value;
					this.SendPropertyChanged("P_slug");
					this.OnP_slugChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Size", Storage="_Sizes", ThisKey="P_id", OtherKey="S_PID")]
		public EntitySet<Size> Sizes
		{
			get
			{
				return this._Sizes;
			}
			set
			{
				this._Sizes.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Color", Storage="_Colors", ThisKey="P_id", OtherKey="COL_PID")]
		public EntitySet<Color> Colors
		{
			get
			{
				return this._Colors;
			}
			set
			{
				this._Colors.Assign(value);
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
		
		private void attach_Sizes(Size entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Sizes(Size entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
		
		private void attach_Colors(Color entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Colors(Color entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Size")]
	public partial class Size : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _S_id;
		
		private string _S_name;
		
		private string _S_PID;
		
		private EntityRef<Product> _Product;
		
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
			this._Product = default(EntityRef<Product>);
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
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnS_PIDChanging(value);
					this.SendPropertyChanging();
					this._S_PID = value;
					this.SendPropertyChanged("S_PID");
					this.OnS_PIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Size", Storage="_Product", ThisKey="S_PID", OtherKey="P_id", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Sizes.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Sizes.Add(this);
						this._S_PID = value.P_id;
					}
					else
					{
						this._S_PID = default(string);
					}
					this.SendPropertyChanged("Product");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Color")]
	public partial class Color : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _COL_id;
		
		private string _COL_name;
		
		private string _COL_slug;
		
		private string _COL_PID;
		
		private EntityRef<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCOL_idChanging(string value);
    partial void OnCOL_idChanged();
    partial void OnCOL_nameChanging(string value);
    partial void OnCOL_nameChanged();
    partial void OnCOL_slugChanging(string value);
    partial void OnCOL_slugChanged();
    partial void OnCOL_PIDChanging(string value);
    partial void OnCOL_PIDChanged();
    #endregion
		
		public Color()
		{
			this._Product = default(EntityRef<Product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COL_id", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string COL_id
		{
			get
			{
				return this._COL_id;
			}
			set
			{
				if ((this._COL_id != value))
				{
					this.OnCOL_idChanging(value);
					this.SendPropertyChanging();
					this._COL_id = value;
					this.SendPropertyChanged("COL_id");
					this.OnCOL_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COL_name", DbType="NVarChar(200)")]
		public string COL_name
		{
			get
			{
				return this._COL_name;
			}
			set
			{
				if ((this._COL_name != value))
				{
					this.OnCOL_nameChanging(value);
					this.SendPropertyChanging();
					this._COL_name = value;
					this.SendPropertyChanged("COL_name");
					this.OnCOL_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COL_slug", DbType="NVarChar(100)")]
		public string COL_slug
		{
			get
			{
				return this._COL_slug;
			}
			set
			{
				if ((this._COL_slug != value))
				{
					this.OnCOL_slugChanging(value);
					this.SendPropertyChanging();
					this._COL_slug = value;
					this.SendPropertyChanged("COL_slug");
					this.OnCOL_slugChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COL_PID", DbType="VarChar(10)")]
		public string COL_PID
		{
			get
			{
				return this._COL_PID;
			}
			set
			{
				if ((this._COL_PID != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCOL_PIDChanging(value);
					this.SendPropertyChanging();
					this._COL_PID = value;
					this.SendPropertyChanged("COL_PID");
					this.OnCOL_PIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Color", Storage="_Product", ThisKey="COL_PID", OtherKey="P_id", IsForeignKey=true)]
		public Product Product
		{
			get
			{
				return this._Product.Entity;
			}
			set
			{
				Product previousValue = this._Product.Entity;
				if (((previousValue != value) 
							|| (this._Product.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Product.Entity = null;
						previousValue.Colors.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Colors.Add(this);
						this._COL_PID = value.P_id;
					}
					else
					{
						this._COL_PID = default(string);
					}
					this.SendPropertyChanged("Product");
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
