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

namespace WebBanQA.Models.Cart
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
	public partial class DBCartDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCart(Cart instance);
    partial void UpdateCart(Cart instance);
    partial void DeleteCart(Cart instance);
    partial void InsertCartdeta(Cartdeta instance);
    partial void UpdateCartdeta(Cartdeta instance);
    partial void DeleteCartdeta(Cartdeta instance);
    partial void InsertProduct(Product instance);
    partial void UpdateProduct(Product instance);
    partial void DeleteProduct(Product instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public DBCartDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["QLCuaHangBanQAConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBCartDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBCartDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBCartDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBCartDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Cart> Carts
		{
			get
			{
				return this.GetTable<Cart>();
			}
		}
		
		public System.Data.Linq.Table<Cartdeta> Cartdetas
		{
			get
			{
				return this.GetTable<Cartdeta>();
			}
		}
		
		public System.Data.Linq.Table<Product> Products
		{
			get
			{
				return this.GetTable<Product>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cart")]
	public partial class Cart : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CAR_id;
		
		private string _CAR_UID;
		
		private string _CAR_select;
		
		private string _CAR_status;
		
		private System.Nullable<System.DateTime> _car_date;
		
		private EntitySet<Cartdeta> _Cartdetas;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCAR_idChanging(string value);
    partial void OnCAR_idChanged();
    partial void OnCAR_UIDChanging(string value);
    partial void OnCAR_UIDChanged();
    partial void OnCAR_selectChanging(string value);
    partial void OnCAR_selectChanged();
    partial void OnCAR_statusChanging(string value);
    partial void OnCAR_statusChanged();
    partial void Oncar_dateChanging(System.Nullable<System.DateTime> value);
    partial void Oncar_dateChanged();
    #endregion
		
		public Cart()
		{
			this._Cartdetas = new EntitySet<Cartdeta>(new Action<Cartdeta>(this.attach_Cartdetas), new Action<Cartdeta>(this.detach_Cartdetas));
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CAR_id", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CAR_id
		{
			get
			{
				return this._CAR_id;
			}
			set
			{
				if ((this._CAR_id != value))
				{
					this.OnCAR_idChanging(value);
					this.SendPropertyChanging();
					this._CAR_id = value;
					this.SendPropertyChanged("CAR_id");
					this.OnCAR_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CAR_UID", DbType="VarChar(10)")]
		public string CAR_UID
		{
			get
			{
				return this._CAR_UID;
			}
			set
			{
				if ((this._CAR_UID != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCAR_UIDChanging(value);
					this.SendPropertyChanging();
					this._CAR_UID = value;
					this.SendPropertyChanged("CAR_UID");
					this.OnCAR_UIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CAR_select", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string CAR_select
		{
			get
			{
				return this._CAR_select;
			}
			set
			{
				if ((this._CAR_select != value))
				{
					this.OnCAR_selectChanging(value);
					this.SendPropertyChanging();
					this._CAR_select = value;
					this.SendPropertyChanged("CAR_select");
					this.OnCAR_selectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CAR_status", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string CAR_status
		{
			get
			{
				return this._CAR_status;
			}
			set
			{
				if ((this._CAR_status != value))
				{
					this.OnCAR_statusChanging(value);
					this.SendPropertyChanging();
					this._CAR_status = value;
					this.SendPropertyChanged("CAR_status");
					this.OnCAR_statusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_car_date", DbType="DateTime")]
		public System.Nullable<System.DateTime> car_date
		{
			get
			{
				return this._car_date;
			}
			set
			{
				if ((this._car_date != value))
				{
					this.Oncar_dateChanging(value);
					this.SendPropertyChanging();
					this._car_date = value;
					this.SendPropertyChanged("car_date");
					this.Oncar_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cart_Cartdeta", Storage="_Cartdetas", ThisKey="CAR_id", OtherKey="CD_CarID")]
		public EntitySet<Cartdeta> Cartdetas
		{
			get
			{
				return this._Cartdetas;
			}
			set
			{
				this._Cartdetas.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Cart", Storage="_User", ThisKey="CAR_UID", OtherKey="U_id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Carts.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Carts.Add(this);
						this._CAR_UID = value.U_id;
					}
					else
					{
						this._CAR_UID = default(string);
					}
					this.SendPropertyChanged("User");
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
		
		private void attach_Cartdetas(Cartdeta entity)
		{
			this.SendPropertyChanging();
			entity.Cart = this;
		}
		
		private void detach_Cartdetas(Cartdeta entity)
		{
			this.SendPropertyChanging();
			entity.Cart = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cartdeta")]
	public partial class Cartdeta : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CD_id;
		
		private string _CD_PID;
		
		private string _CD_CarID;
		
		private string _CD_COLslug;
		
		private string _CD_S_name;
		
		private System.Nullable<int> _CD_amount;
		
		private EntityRef<Cart> _Cart;
		
		private EntityRef<Product> _Product;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCD_idChanging(string value);
    partial void OnCD_idChanged();
    partial void OnCD_PIDChanging(string value);
    partial void OnCD_PIDChanged();
    partial void OnCD_CarIDChanging(string value);
    partial void OnCD_CarIDChanged();
    partial void OnCD_COLslugChanging(string value);
    partial void OnCD_COLslugChanged();
    partial void OnCD_S_nameChanging(string value);
    partial void OnCD_S_nameChanged();
    partial void OnCD_amountChanging(System.Nullable<int> value);
    partial void OnCD_amountChanged();
    #endregion
		
		public Cartdeta()
		{
			this._Cart = default(EntityRef<Cart>);
			this._Product = default(EntityRef<Product>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CD_id", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CD_id
		{
			get
			{
				return this._CD_id;
			}
			set
			{
				if ((this._CD_id != value))
				{
					this.OnCD_idChanging(value);
					this.SendPropertyChanging();
					this._CD_id = value;
					this.SendPropertyChanged("CD_id");
					this.OnCD_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CD_PID", DbType="VarChar(10)")]
		public string CD_PID
		{
			get
			{
				return this._CD_PID;
			}
			set
			{
				if ((this._CD_PID != value))
				{
					if (this._Product.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCD_PIDChanging(value);
					this.SendPropertyChanging();
					this._CD_PID = value;
					this.SendPropertyChanged("CD_PID");
					this.OnCD_PIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CD_CarID", DbType="VarChar(10)")]
		public string CD_CarID
		{
			get
			{
				return this._CD_CarID;
			}
			set
			{
				if ((this._CD_CarID != value))
				{
					if (this._Cart.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCD_CarIDChanging(value);
					this.SendPropertyChanging();
					this._CD_CarID = value;
					this.SendPropertyChanged("CD_CarID");
					this.OnCD_CarIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CD_COLslug", DbType="NVarChar(20)")]
		public string CD_COLslug
		{
			get
			{
				return this._CD_COLslug;
			}
			set
			{
				if ((this._CD_COLslug != value))
				{
					this.OnCD_COLslugChanging(value);
					this.SendPropertyChanging();
					this._CD_COLslug = value;
					this.SendPropertyChanged("CD_COLslug");
					this.OnCD_COLslugChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CD_S_name", DbType="NVarChar(20)")]
		public string CD_S_name
		{
			get
			{
				return this._CD_S_name;
			}
			set
			{
				if ((this._CD_S_name != value))
				{
					this.OnCD_S_nameChanging(value);
					this.SendPropertyChanging();
					this._CD_S_name = value;
					this.SendPropertyChanged("CD_S_name");
					this.OnCD_S_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CD_amount", DbType="Int")]
		public System.Nullable<int> CD_amount
		{
			get
			{
				return this._CD_amount;
			}
			set
			{
				if ((this._CD_amount != value))
				{
					this.OnCD_amountChanging(value);
					this.SendPropertyChanging();
					this._CD_amount = value;
					this.SendPropertyChanged("CD_amount");
					this.OnCD_amountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Cart_Cartdeta", Storage="_Cart", ThisKey="CD_CarID", OtherKey="CAR_id", IsForeignKey=true)]
		public Cart Cart
		{
			get
			{
				return this._Cart.Entity;
			}
			set
			{
				Cart previousValue = this._Cart.Entity;
				if (((previousValue != value) 
							|| (this._Cart.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Cart.Entity = null;
						previousValue.Cartdetas.Remove(this);
					}
					this._Cart.Entity = value;
					if ((value != null))
					{
						value.Cartdetas.Add(this);
						this._CD_CarID = value.CAR_id;
					}
					else
					{
						this._CD_CarID = default(string);
					}
					this.SendPropertyChanged("Cart");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Cartdeta", Storage="_Product", ThisKey="CD_PID", OtherKey="P_id", IsForeignKey=true)]
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
						previousValue.Cartdetas.Remove(this);
					}
					this._Product.Entity = value;
					if ((value != null))
					{
						value.Cartdetas.Add(this);
						this._CD_PID = value.P_id;
					}
					else
					{
						this._CD_PID = default(string);
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
		
		private EntitySet<Cartdeta> _Cartdetas;
		
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
			this._Cartdetas = new EntitySet<Cartdeta>(new Action<Cartdeta>(this.attach_Cartdetas), new Action<Cartdeta>(this.detach_Cartdetas));
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Product_Cartdeta", Storage="_Cartdetas", ThisKey="P_id", OtherKey="CD_PID")]
		public EntitySet<Cartdeta> Cartdetas
		{
			get
			{
				return this._Cartdetas;
			}
			set
			{
				this._Cartdetas.Assign(value);
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
		
		private void attach_Cartdetas(Cartdeta entity)
		{
			this.SendPropertyChanging();
			entity.Product = this;
		}
		
		private void detach_Cartdetas(Cartdeta entity)
		{
			this.SendPropertyChanging();
			entity.Product = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _U_id;
		
		private string _U_Fname;
		
		private string _U_Lname;
		
		private string _U_email;
		
		private string _U_status;
		
		private string _U_add;
		
		private string _U_name;
		
		private string _U_contact;
		
		private System.Nullable<System.DateTime> _U_created;
		
		private string _U_pass;
		
		private EntitySet<Cart> _Carts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnU_idChanging(string value);
    partial void OnU_idChanged();
    partial void OnU_FnameChanging(string value);
    partial void OnU_FnameChanged();
    partial void OnU_LnameChanging(string value);
    partial void OnU_LnameChanged();
    partial void OnU_emailChanging(string value);
    partial void OnU_emailChanged();
    partial void OnU_statusChanging(string value);
    partial void OnU_statusChanged();
    partial void OnU_addChanging(string value);
    partial void OnU_addChanged();
    partial void OnU_nameChanging(string value);
    partial void OnU_nameChanged();
    partial void OnU_contactChanging(string value);
    partial void OnU_contactChanged();
    partial void OnU_createdChanging(System.Nullable<System.DateTime> value);
    partial void OnU_createdChanged();
    partial void OnU_passChanging(string value);
    partial void OnU_passChanged();
    #endregion
		
		public User()
		{
			this._Carts = new EntitySet<Cart>(new Action<Cart>(this.attach_Carts), new Action<Cart>(this.detach_Carts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_U_id", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string U_id
		{
			get
			{
				return this._U_id;
			}
			set
			{
				if ((this._U_id != value))
				{
					this.OnU_idChanging(value);
					this.SendPropertyChanging();
					this._U_id = value;
					this.SendPropertyChanged("U_id");
					this.OnU_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_U_Fname", DbType="NVarChar(200)")]
		public string U_Fname
		{
			get
			{
				return this._U_Fname;
			}
			set
			{
				if ((this._U_Fname != value))
				{
					this.OnU_FnameChanging(value);
					this.SendPropertyChanging();
					this._U_Fname = value;
					this.SendPropertyChanged("U_Fname");
					this.OnU_FnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_U_Lname", DbType="NVarChar(200)")]
		public string U_Lname
		{
			get
			{
				return this._U_Lname;
			}
			set
			{
				if ((this._U_Lname != value))
				{
					this.OnU_LnameChanging(value);
					this.SendPropertyChanging();
					this._U_Lname = value;
					this.SendPropertyChanged("U_Lname");
					this.OnU_LnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_U_email", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string U_email
		{
			get
			{
				return this._U_email;
			}
			set
			{
				if ((this._U_email != value))
				{
					this.OnU_emailChanging(value);
					this.SendPropertyChanging();
					this._U_email = value;
					this.SendPropertyChanged("U_email");
					this.OnU_emailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_U_status", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string U_status
		{
			get
			{
				return this._U_status;
			}
			set
			{
				if ((this._U_status != value))
				{
					this.OnU_statusChanging(value);
					this.SendPropertyChanging();
					this._U_status = value;
					this.SendPropertyChanged("U_status");
					this.OnU_statusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_U_add", DbType="NVarChar(200)")]
		public string U_add
		{
			get
			{
				return this._U_add;
			}
			set
			{
				if ((this._U_add != value))
				{
					this.OnU_addChanging(value);
					this.SendPropertyChanging();
					this._U_add = value;
					this.SendPropertyChanged("U_add");
					this.OnU_addChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_U_name", DbType="NVarChar(200)")]
		public string U_name
		{
			get
			{
				return this._U_name;
			}
			set
			{
				if ((this._U_name != value))
				{
					this.OnU_nameChanging(value);
					this.SendPropertyChanging();
					this._U_name = value;
					this.SendPropertyChanged("U_name");
					this.OnU_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_U_contact", DbType="NVarChar(15)")]
		public string U_contact
		{
			get
			{
				return this._U_contact;
			}
			set
			{
				if ((this._U_contact != value))
				{
					this.OnU_contactChanging(value);
					this.SendPropertyChanging();
					this._U_contact = value;
					this.SendPropertyChanged("U_contact");
					this.OnU_contactChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_U_created", DbType="DateTime")]
		public System.Nullable<System.DateTime> U_created
		{
			get
			{
				return this._U_created;
			}
			set
			{
				if ((this._U_created != value))
				{
					this.OnU_createdChanging(value);
					this.SendPropertyChanging();
					this._U_created = value;
					this.SendPropertyChanged("U_created");
					this.OnU_createdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_U_pass", DbType="NVarChar(200)")]
		public string U_pass
		{
			get
			{
				return this._U_pass;
			}
			set
			{
				if ((this._U_pass != value))
				{
					this.OnU_passChanging(value);
					this.SendPropertyChanging();
					this._U_pass = value;
					this.SendPropertyChanged("U_pass");
					this.OnU_passChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Cart", Storage="_Carts", ThisKey="U_id", OtherKey="CAR_UID")]
		public EntitySet<Cart> Carts
		{
			get
			{
				return this._Carts;
			}
			set
			{
				this._Carts.Assign(value);
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
		
		private void attach_Carts(Cart entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Carts(Cart entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
}
#pragma warning restore 1591
