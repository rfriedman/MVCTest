﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TablePage.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DevelopmentTest")]
	public partial class TableContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    #endregion
		
		public TableContextDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DevelopmentTestConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TableContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TableContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TableContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TableContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private double _id;
		
		private string _first_name;
		
		private string _last_name;
		
		private string _email;
		
		private string _phone;
		
		private string _street;
		
		private string _city;
		
		private string _region;
		
		private System.Nullable<double> _postal_code;
		
		private string _country;
		
		private string _dob;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(double value);
    partial void OnidChanged();
    partial void Onfirst_nameChanging(string value);
    partial void Onfirst_nameChanged();
    partial void Onlast_nameChanging(string value);
    partial void Onlast_nameChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnphoneChanging(string value);
    partial void OnphoneChanged();
    partial void OnstreetChanging(string value);
    partial void OnstreetChanged();
    partial void OncityChanging(string value);
    partial void OncityChanged();
    partial void OnregionChanging(string value);
    partial void OnregionChanged();
    partial void Onpostal_codeChanging(System.Nullable<double> value);
    partial void Onpostal_codeChanged();
    partial void OncountryChanging(string value);
    partial void OncountryChanged();
    partial void OndobChanging(string value);
    partial void OndobChanged();
    #endregion
		
		public Customer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Float NOT NULL", IsPrimaryKey=true)]
		public double id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_first_name", DbType="NVarChar(255)")]
		public string first_name
		{
			get
			{
				return this._first_name;
			}
			set
			{
				if ((this._first_name != value))
				{
					this.Onfirst_nameChanging(value);
					this.SendPropertyChanging();
					this._first_name = value;
					this.SendPropertyChanged("first_name");
					this.Onfirst_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_last_name", DbType="NVarChar(255)")]
		public string last_name
		{
			get
			{
				return this._last_name;
			}
			set
			{
				if ((this._last_name != value))
				{
					this.Onlast_nameChanging(value);
					this.SendPropertyChanging();
					this._last_name = value;
					this.SendPropertyChanged("last_name");
					this.Onlast_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(255)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="NVarChar(255)")]
		public string phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_street", DbType="NVarChar(255)")]
		public string street
		{
			get
			{
				return this._street;
			}
			set
			{
				if ((this._street != value))
				{
					this.OnstreetChanging(value);
					this.SendPropertyChanging();
					this._street = value;
					this.SendPropertyChanged("street");
					this.OnstreetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_city", DbType="NVarChar(255)")]
		public string city
		{
			get
			{
				return this._city;
			}
			set
			{
				if ((this._city != value))
				{
					this.OncityChanging(value);
					this.SendPropertyChanging();
					this._city = value;
					this.SendPropertyChanged("city");
					this.OncityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_region", DbType="NVarChar(255)")]
		public string region
		{
			get
			{
				return this._region;
			}
			set
			{
				if ((this._region != value))
				{
					this.OnregionChanging(value);
					this.SendPropertyChanging();
					this._region = value;
					this.SendPropertyChanged("region");
					this.OnregionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_postal_code", DbType="Float")]
		public System.Nullable<double> postal_code
		{
			get
			{
				return this._postal_code;
			}
			set
			{
				if ((this._postal_code != value))
				{
					this.Onpostal_codeChanging(value);
					this.SendPropertyChanging();
					this._postal_code = value;
					this.SendPropertyChanged("postal_code");
					this.Onpostal_codeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_country", DbType="NVarChar(255)")]
		public string country
		{
			get
			{
				return this._country;
			}
			set
			{
				if ((this._country != value))
				{
					this.OncountryChanging(value);
					this.SendPropertyChanging();
					this._country = value;
					this.SendPropertyChanged("country");
					this.OncountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dob", DbType="NVarChar(255)")]
		public string dob
		{
			get
			{
				return this._dob;
			}
			set
			{
				if ((this._dob != value))
				{
					this.OndobChanging(value);
					this.SendPropertyChanging();
					this._dob = value;
					this.SendPropertyChanged("dob");
					this.OndobChanged();
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
