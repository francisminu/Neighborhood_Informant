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

namespace DataTier
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="UsersDB")]
	public partial class UsersDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertListing(Listing instance);
    partial void UpdateListing(Listing instance);
    partial void DeleteListing(Listing instance);
    partial void InsertMessage(Message instance);
    partial void UpdateMessage(Message instance);
    partial void DeleteMessage(Message instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertNEIGHBORHOOD_CRIMERATE(NEIGHBORHOOD_CRIMERATE instance);
    partial void UpdateNEIGHBORHOOD_CRIMERATE(NEIGHBORHOOD_CRIMERATE instance);
    partial void DeleteNEIGHBORHOOD_CRIMERATE(NEIGHBORHOOD_CRIMERATE instance);
    #endregion
		
		public UsersDBDataContext() : 
				base(global::DataTier.Properties.Settings.Default.UsersDBConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public UsersDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UsersDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UsersDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UsersDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Listing> Listings
		{
			get
			{
				return this.GetTable<Listing>();
			}
		}
		
		public System.Data.Linq.Table<Message> Messages
		{
			get
			{
				return this.GetTable<Message>();
			}
		}
		
		public System.Data.Linq.Table<NEIGHBORHOOD_HOSPITAL> NEIGHBORHOOD_HOSPITALs
		{
			get
			{
				return this.GetTable<NEIGHBORHOOD_HOSPITAL>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<NEIGHBORHOOD_POLICESTATION> NEIGHBORHOOD_POLICESTATIONs
		{
			get
			{
				return this.GetTable<NEIGHBORHOOD_POLICESTATION>();
			}
		}
		
		public System.Data.Linq.Table<NEIGHBORHOOD_SCHOOL> NEIGHBORHOOD_SCHOOLs
		{
			get
			{
				return this.GetTable<NEIGHBORHOOD_SCHOOL>();
			}
		}
		
		public System.Data.Linq.Table<NEIGHBORHOOD_CRIMERATE> NEIGHBORHOOD_CRIMERATEs
		{
			get
			{
				return this.GetTable<NEIGHBORHOOD_CRIMERATE>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Listings")]
	public partial class Listing : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ListingID;
		
		private int _UserID;
		
		private string _StAddr;
		
		private int _ZipCode;
		
		private int _SqFeet;
		
		private double _NoBath;
		
		private int _NoBed;
		
		private string _Type;
		
		private decimal _Price;
		
		private string _Picture;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnListingIDChanging(int value);
    partial void OnListingIDChanged();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnStAddrChanging(string value);
    partial void OnStAddrChanged();
    partial void OnZipCodeChanging(int value);
    partial void OnZipCodeChanged();
    partial void OnSqFeetChanging(int value);
    partial void OnSqFeetChanged();
    partial void OnNoBathChanging(double value);
    partial void OnNoBathChanged();
    partial void OnNoBedChanging(int value);
    partial void OnNoBedChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnPictureChanging(string value);
    partial void OnPictureChanged();
    #endregion
		
		public Listing()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ListingID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ListingID
		{
			get
			{
				return this._ListingID;
			}
			set
			{
				if ((this._ListingID != value))
				{
					this.OnListingIDChanging(value);
					this.SendPropertyChanging();
					this._ListingID = value;
					this.SendPropertyChanged("ListingID");
					this.OnListingIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL")]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StAddr", DbType="NVarChar(128) NOT NULL", CanBeNull=false)]
		public string StAddr
		{
			get
			{
				return this._StAddr;
			}
			set
			{
				if ((this._StAddr != value))
				{
					this.OnStAddrChanging(value);
					this.SendPropertyChanging();
					this._StAddr = value;
					this.SendPropertyChanged("StAddr");
					this.OnStAddrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCode", DbType="Int NOT NULL")]
		public int ZipCode
		{
			get
			{
				return this._ZipCode;
			}
			set
			{
				if ((this._ZipCode != value))
				{
					this.OnZipCodeChanging(value);
					this.SendPropertyChanging();
					this._ZipCode = value;
					this.SendPropertyChanged("ZipCode");
					this.OnZipCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SqFeet", DbType="Int NOT NULL")]
		public int SqFeet
		{
			get
			{
				return this._SqFeet;
			}
			set
			{
				if ((this._SqFeet != value))
				{
					this.OnSqFeetChanging(value);
					this.SendPropertyChanging();
					this._SqFeet = value;
					this.SendPropertyChanged("SqFeet");
					this.OnSqFeetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoBath", DbType="Float NOT NULL")]
		public double NoBath
		{
			get
			{
				return this._NoBath;
			}
			set
			{
				if ((this._NoBath != value))
				{
					this.OnNoBathChanging(value);
					this.SendPropertyChanging();
					this._NoBath = value;
					this.SendPropertyChanged("NoBath");
					this.OnNoBathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoBed", DbType="Int NOT NULL")]
		public int NoBed
		{
			get
			{
				return this._NoBed;
			}
			set
			{
				if ((this._NoBed != value))
				{
					this.OnNoBedChanging(value);
					this.SendPropertyChanging();
					this._NoBed = value;
					this.SendPropertyChanged("NoBed");
					this.OnNoBedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="NVarChar(32) NOT NULL", CanBeNull=false)]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="Money NOT NULL")]
		public decimal Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Picture", DbType="NVarChar(1014)")]
		public string Picture
		{
			get
			{
				return this._Picture;
			}
			set
			{
				if ((this._Picture != value))
				{
					this.OnPictureChanging(value);
					this.SendPropertyChanging();
					this._Picture = value;
					this.SendPropertyChanged("Picture");
					this.OnPictureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Listing", Storage="_User", ThisKey="UserID", OtherKey="UserID", IsForeignKey=true)]
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
						previousValue.Listings.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Listings.Add(this);
						this._UserID = value.UserID;
					}
					else
					{
						this._UserID = default(int);
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
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Messages")]
	public partial class Message : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MessageID;
		
		private int _SenderID;
		
		private int _ReceiverID;
		
		private int _ThreadID;
		
		private string _MessageBody;
		
		private EntityRef<User> _User;
		
		private EntityRef<User> _User1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMessageIDChanging(int value);
    partial void OnMessageIDChanged();
    partial void OnSenderIDChanging(int value);
    partial void OnSenderIDChanged();
    partial void OnReceiverIDChanging(int value);
    partial void OnReceiverIDChanged();
    partial void OnThreadIDChanging(int value);
    partial void OnThreadIDChanged();
    partial void OnMessageBodyChanging(string value);
    partial void OnMessageBodyChanged();
    #endregion
		
		public Message()
		{
			this._User = default(EntityRef<User>);
			this._User1 = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MessageID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MessageID
		{
			get
			{
				return this._MessageID;
			}
			set
			{
				if ((this._MessageID != value))
				{
					this.OnMessageIDChanging(value);
					this.SendPropertyChanging();
					this._MessageID = value;
					this.SendPropertyChanged("MessageID");
					this.OnMessageIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SenderID", DbType="Int NOT NULL")]
		public int SenderID
		{
			get
			{
				return this._SenderID;
			}
			set
			{
				if ((this._SenderID != value))
				{
					if (this._User1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSenderIDChanging(value);
					this.SendPropertyChanging();
					this._SenderID = value;
					this.SendPropertyChanged("SenderID");
					this.OnSenderIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ReceiverID", DbType="Int NOT NULL")]
		public int ReceiverID
		{
			get
			{
				return this._ReceiverID;
			}
			set
			{
				if ((this._ReceiverID != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnReceiverIDChanging(value);
					this.SendPropertyChanging();
					this._ReceiverID = value;
					this.SendPropertyChanged("ReceiverID");
					this.OnReceiverIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThreadID", DbType="Int NOT NULL")]
		public int ThreadID
		{
			get
			{
				return this._ThreadID;
			}
			set
			{
				if ((this._ThreadID != value))
				{
					this.OnThreadIDChanging(value);
					this.SendPropertyChanging();
					this._ThreadID = value;
					this.SendPropertyChanged("ThreadID");
					this.OnThreadIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MessageBody", DbType="NVarChar(1024) NOT NULL", CanBeNull=false)]
		public string MessageBody
		{
			get
			{
				return this._MessageBody;
			}
			set
			{
				if ((this._MessageBody != value))
				{
					this.OnMessageBodyChanging(value);
					this.SendPropertyChanging();
					this._MessageBody = value;
					this.SendPropertyChanged("MessageBody");
					this.OnMessageBodyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Message", Storage="_User", ThisKey="ReceiverID", OtherKey="UserID", IsForeignKey=true)]
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
						previousValue.Messages.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Messages.Add(this);
						this._ReceiverID = value.UserID;
					}
					else
					{
						this._ReceiverID = default(int);
					}
					this.SendPropertyChanged("User");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Message1", Storage="_User1", ThisKey="SenderID", OtherKey="UserID", IsForeignKey=true)]
		public User User1
		{
			get
			{
				return this._User1.Entity;
			}
			set
			{
				User previousValue = this._User1.Entity;
				if (((previousValue != value) 
							|| (this._User1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User1.Entity = null;
						previousValue.Messages1.Remove(this);
					}
					this._User1.Entity = value;
					if ((value != null))
					{
						value.Messages1.Add(this);
						this._SenderID = value.UserID;
					}
					else
					{
						this._SenderID = default(int);
					}
					this.SendPropertyChanged("User1");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NEIGHBORHOOD_HOSPITALS")]
	public partial class NEIGHBORHOOD_HOSPITAL
	{
		
		private int _HospitalID;
		
		private string _HospitalName;
		
		private string _HospitalAddress;
		
		private System.Nullable<int> _HospitalZipCode;
		
		private System.Nullable<int> _HospitalWardNumber;
		
		private System.Nullable<int> _HospitalAreaNumber;
		
		private string _HospitalCommunity;
		
		public NEIGHBORHOOD_HOSPITAL()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HospitalID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int HospitalID
		{
			get
			{
				return this._HospitalID;
			}
			set
			{
				if ((this._HospitalID != value))
				{
					this._HospitalID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HospitalName", DbType="VarChar(MAX)")]
		public string HospitalName
		{
			get
			{
				return this._HospitalName;
			}
			set
			{
				if ((this._HospitalName != value))
				{
					this._HospitalName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HospitalAddress", DbType="VarChar(MAX)")]
		public string HospitalAddress
		{
			get
			{
				return this._HospitalAddress;
			}
			set
			{
				if ((this._HospitalAddress != value))
				{
					this._HospitalAddress = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HospitalZipCode", DbType="Int")]
		public System.Nullable<int> HospitalZipCode
		{
			get
			{
				return this._HospitalZipCode;
			}
			set
			{
				if ((this._HospitalZipCode != value))
				{
					this._HospitalZipCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HospitalWardNumber", DbType="Int")]
		public System.Nullable<int> HospitalWardNumber
		{
			get
			{
				return this._HospitalWardNumber;
			}
			set
			{
				if ((this._HospitalWardNumber != value))
				{
					this._HospitalWardNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HospitalAreaNumber", DbType="Int")]
		public System.Nullable<int> HospitalAreaNumber
		{
			get
			{
				return this._HospitalAreaNumber;
			}
			set
			{
				if ((this._HospitalAreaNumber != value))
				{
					this._HospitalAreaNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HospitalCommunity", DbType="VarChar(MAX)")]
		public string HospitalCommunity
		{
			get
			{
				return this._HospitalCommunity;
			}
			set
			{
				if ((this._HospitalCommunity != value))
				{
					this._HospitalCommunity = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserID;
		
		private string _UserName;
		
		private string _Password;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _Email;
		
		private string _MobileNo;
		
		private byte _Seller;
		
		private EntitySet<Listing> _Listings;
		
		private EntitySet<Message> _Messages;
		
		private EntitySet<Message> _Messages1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnMobileNoChanging(string value);
    partial void OnMobileNoChanged();
    partial void OnSellerChanging(byte value);
    partial void OnSellerChanged();
    #endregion
		
		public User()
		{
			this._Listings = new EntitySet<Listing>(new Action<Listing>(this.attach_Listings), new Action<Listing>(this.detach_Listings));
			this._Messages = new EntitySet<Message>(new Action<Message>(this.attach_Messages), new Action<Message>(this.detach_Messages));
			this._Messages1 = new EntitySet<Message>(new Action<Message>(this.attach_Messages1), new Action<Message>(this.detach_Messages1));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
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
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(320) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MobileNo", DbType="NVarChar(15)")]
		public string MobileNo
		{
			get
			{
				return this._MobileNo;
			}
			set
			{
				if ((this._MobileNo != value))
				{
					this.OnMobileNoChanging(value);
					this.SendPropertyChanging();
					this._MobileNo = value;
					this.SendPropertyChanged("MobileNo");
					this.OnMobileNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Seller", DbType="TinyInt NOT NULL")]
		public byte Seller
		{
			get
			{
				return this._Seller;
			}
			set
			{
				if ((this._Seller != value))
				{
					this.OnSellerChanging(value);
					this.SendPropertyChanging();
					this._Seller = value;
					this.SendPropertyChanged("Seller");
					this.OnSellerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Listing", Storage="_Listings", ThisKey="UserID", OtherKey="UserID")]
		public EntitySet<Listing> Listings
		{
			get
			{
				return this._Listings;
			}
			set
			{
				this._Listings.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Message", Storage="_Messages", ThisKey="UserID", OtherKey="ReceiverID")]
		public EntitySet<Message> Messages
		{
			get
			{
				return this._Messages;
			}
			set
			{
				this._Messages.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Message1", Storage="_Messages1", ThisKey="UserID", OtherKey="SenderID")]
		public EntitySet<Message> Messages1
		{
			get
			{
				return this._Messages1;
			}
			set
			{
				this._Messages1.Assign(value);
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
		
		private void attach_Listings(Listing entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Listings(Listing entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_Messages(Message entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Messages(Message entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_Messages1(Message entity)
		{
			this.SendPropertyChanging();
			entity.User1 = this;
		}
		
		private void detach_Messages1(Message entity)
		{
			this.SendPropertyChanging();
			entity.User1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NEIGHBORHOOD_POLICESTATIONS")]
	public partial class NEIGHBORHOOD_POLICESTATION
	{
		
		private int _StationID;
		
		private string _StationAdress;
		
		private string _StationCity;
		
		private string _StationState;
		
		private System.Nullable<int> _StationZipCode;
		
		public NEIGHBORHOOD_POLICESTATION()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StationID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int StationID
		{
			get
			{
				return this._StationID;
			}
			set
			{
				if ((this._StationID != value))
				{
					this._StationID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StationAdress", DbType="VarChar(MAX)")]
		public string StationAdress
		{
			get
			{
				return this._StationAdress;
			}
			set
			{
				if ((this._StationAdress != value))
				{
					this._StationAdress = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StationCity", DbType="VarChar(1000)")]
		public string StationCity
		{
			get
			{
				return this._StationCity;
			}
			set
			{
				if ((this._StationCity != value))
				{
					this._StationCity = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StationState", DbType="VarChar(200)")]
		public string StationState
		{
			get
			{
				return this._StationState;
			}
			set
			{
				if ((this._StationState != value))
				{
					this._StationState = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StationZipCode", DbType="Int")]
		public System.Nullable<int> StationZipCode
		{
			get
			{
				return this._StationZipCode;
			}
			set
			{
				if ((this._StationZipCode != value))
				{
					this._StationZipCode = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NEIGHBORHOOD_SCHOOLS")]
	public partial class NEIGHBORHOOD_SCHOOL
	{
		
		private int _SchoolID;
		
		private string _SchoolName;
		
		private string _SchoolAddress;
		
		private System.Nullable<int> _SchoolZipCode;
		
		private string _SchoolGradeCat;
		
		private string _SchoolGrades;
		
		private string _SchoolPhone;
		
		private string _SchoolCommArea;
		
		public NEIGHBORHOOD_SCHOOL()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SchoolID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int SchoolID
		{
			get
			{
				return this._SchoolID;
			}
			set
			{
				if ((this._SchoolID != value))
				{
					this._SchoolID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SchoolName", DbType="VarChar(MAX)")]
		public string SchoolName
		{
			get
			{
				return this._SchoolName;
			}
			set
			{
				if ((this._SchoolName != value))
				{
					this._SchoolName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SchoolAddress", DbType="VarChar(MAX)")]
		public string SchoolAddress
		{
			get
			{
				return this._SchoolAddress;
			}
			set
			{
				if ((this._SchoolAddress != value))
				{
					this._SchoolAddress = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SchoolZipCode", DbType="Int")]
		public System.Nullable<int> SchoolZipCode
		{
			get
			{
				return this._SchoolZipCode;
			}
			set
			{
				if ((this._SchoolZipCode != value))
				{
					this._SchoolZipCode = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SchoolGradeCat", DbType="VarChar(10)")]
		public string SchoolGradeCat
		{
			get
			{
				return this._SchoolGradeCat;
			}
			set
			{
				if ((this._SchoolGradeCat != value))
				{
					this._SchoolGradeCat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SchoolGrades", DbType="VarChar(MAX)")]
		public string SchoolGrades
		{
			get
			{
				return this._SchoolGrades;
			}
			set
			{
				if ((this._SchoolGrades != value))
				{
					this._SchoolGrades = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SchoolPhone", DbType="VarChar(20)")]
		public string SchoolPhone
		{
			get
			{
				return this._SchoolPhone;
			}
			set
			{
				if ((this._SchoolPhone != value))
				{
					this._SchoolPhone = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SchoolCommArea", DbType="VarChar(200)")]
		public string SchoolCommArea
		{
			get
			{
				return this._SchoolCommArea;
			}
			set
			{
				if ((this._SchoolCommArea != value))
				{
					this._SchoolCommArea = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NEIGHBORHOOD_CRIMERATE")]
	public partial class NEIGHBORHOOD_CRIMERATE : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CID;
		
		private int _CrimeZipCodes;
		
		private double _CrimeRate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCIDChanging(int value);
    partial void OnCIDChanged();
    partial void OnCrimeZipCodesChanging(int value);
    partial void OnCrimeZipCodesChanged();
    partial void OnCrimeRateChanging(double value);
    partial void OnCrimeRateChanged();
    #endregion
		
		public NEIGHBORHOOD_CRIMERATE()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CID
		{
			get
			{
				return this._CID;
			}
			set
			{
				if ((this._CID != value))
				{
					this.OnCIDChanging(value);
					this.SendPropertyChanging();
					this._CID = value;
					this.SendPropertyChanged("CID");
					this.OnCIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CrimeZipCodes", DbType="Int NOT NULL")]
		public int CrimeZipCodes
		{
			get
			{
				return this._CrimeZipCodes;
			}
			set
			{
				if ((this._CrimeZipCodes != value))
				{
					this.OnCrimeZipCodesChanging(value);
					this.SendPropertyChanging();
					this._CrimeZipCodes = value;
					this.SendPropertyChanged("CrimeZipCodes");
					this.OnCrimeZipCodesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CrimeRate", DbType="Float NOT NULL")]
		public double CrimeRate
		{
			get
			{
				return this._CrimeRate;
			}
			set
			{
				if ((this._CrimeRate != value))
				{
					this.OnCrimeRateChanging(value);
					this.SendPropertyChanging();
					this._CrimeRate = value;
					this.SendPropertyChanged("CrimeRate");
					this.OnCrimeRateChanged();
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
