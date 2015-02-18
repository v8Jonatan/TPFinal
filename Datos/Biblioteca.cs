// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from biblioteca on 2015-02-18 02:35:24Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//
namespace Datos
{
	using System;
	using System.ComponentModel;
	using System.Data;
#if MONO_STRICT
	using System.Data.Linq;
#else   // MONO_STRICT
	using DbLinq.Data.Linq;
	using DbLinq.Vendor;
#endif  // MONO_STRICT
	using System.Data.Linq.Mapping;
	using System.Diagnostics;
	
	
	public partial class BibLiOtEcA : DataContext
	{
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		#endregion
		
		
		public BibLiOtEcA(string connectionString) : 
				base(connectionString)
		{
			this.OnCreated();
		}
		
		public BibLiOtEcA(string connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public BibLiOtEcA(IDbConnection connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public Table<AutoReS> AutoReS
		{
			get
			{
				return this.GetTable<AutoReS>();
			}
		}
		
		public Table<DETallEs> DETallEs
		{
			get
			{
				return this.GetTable<DETallEs>();
			}
		}
		
		public Table<EJEmPLares> EJEmPLares
		{
			get
			{
				return this.GetTable<EJEmPLares>();
			}
		}
		
		public Table<LiBroS> LiBroS
		{
			get
			{
				return this.GetTable<LiBroS>();
			}
		}
		
		public Table<PRestAmos> PRestAmos
		{
			get
			{
				return this.GetTable<PRestAmos>();
			}
		}
		
		public Table<REseRvAs> REseRvAs
		{
			get
			{
				return this.GetTable<REseRvAs>();
			}
		}
		
		public Table<SoCIoS> SoCIoS
		{
			get
			{
				return this.GetTable<SoCIoS>();
			}
		}
		
		public Table<UsUarIoS> UsUarIoS
		{
			get
			{
				return this.GetTable<UsUarIoS>();
			}
		}
	}
	
	#region Start MONO_STRICT
#if MONO_STRICT

	public partial class BibLiOtEcA
	{
		
		public BibLiOtEcA(IDbConnection connection) : 
				base(connection)
		{
			this.OnCreated();
		}
	}
	#region End MONO_STRICT
	#endregion
#else     // MONO_STRICT
	
	public partial class BibLiOtEcA
	{
		
		public BibLiOtEcA(IDbConnection connection) : 
				base(connection, new DbLinq.MySql.MySqlVendor())
		{
			this.OnCreated();
		}
		
		public BibLiOtEcA(IDbConnection connection, IVendor sqlDialect) : 
				base(connection, sqlDialect)
		{
			this.OnCreated();
		}
		
		public BibLiOtEcA(IDbConnection connection, MappingSource mappingSource, IVendor sqlDialect) : 
				base(connection, mappingSource, sqlDialect)
		{
			this.OnCreated();
		}
	}
	#region End Not MONO_STRICT
	#endregion
#endif     // MONO_STRICT
	#endregion
	
	[Table(Name="biblioteca.autores")]
	public partial class AutoReS : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _apeNoM;
		
		private int _idaUtoR;
		
		private string _naCIonAlIDAd;
		
		private EntitySet<LiBroS> _liBroS;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnApeNoMChanged();
		
		partial void OnApeNoMChanging(string value);
		
		partial void OnIDAutoRChanged();
		
		partial void OnIDAutoRChanging(int value);
		
		partial void OnNAcIonALidAdChanged();
		
		partial void OnNAcIonALidAdChanging(string value);
		#endregion
		
		
		public AutoReS()
		{
			_liBroS = new EntitySet<LiBroS>(new Action<LiBroS>(this.LiBroS_Attach), new Action<LiBroS>(this.LiBroS_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_apeNoM", Name="apenom", DbType="varchar(40)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ApeNoM
		{
			get
			{
				return this._apeNoM;
			}
			set
			{
				if (((_apeNoM == value) 
							== false))
				{
					this.OnApeNoMChanging(value);
					this.SendPropertyChanging();
					this._apeNoM = value;
					this.SendPropertyChanged("ApeNoM");
					this.OnApeNoMChanged();
				}
			}
		}
		
		[Column(Storage="_idaUtoR", Name="id_autor", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDAutoR
		{
			get
			{
				return this._idaUtoR;
			}
			set
			{
				if ((_idaUtoR != value))
				{
					this.OnIDAutoRChanging(value);
					this.SendPropertyChanging();
					this._idaUtoR = value;
					this.SendPropertyChanged("IDAutoR");
					this.OnIDAutoRChanged();
				}
			}
		}
		
		[Column(Storage="_naCIonAlIDAd", Name="nacionalidad", DbType="varchar(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string NAcIonALidAd
		{
			get
			{
				return this._naCIonAlIDAd;
			}
			set
			{
				if (((_naCIonAlIDAd == value) 
							== false))
				{
					this.OnNAcIonALidAdChanging(value);
					this.SendPropertyChanging();
					this._naCIonAlIDAd = value;
					this.SendPropertyChanged("NAcIonALidAd");
					this.OnNAcIonALidAdChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_liBroS", OtherKey="IDAutoR", ThisKey="IDAutoR", Name="libros_ibfk_1")]
		[DebuggerNonUserCode()]
		public EntitySet<LiBroS> LiBroS
		{
			get
			{
				return this._liBroS;
			}
			set
			{
				this._liBroS = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void LiBroS_Attach(LiBroS entity)
		{
			this.SendPropertyChanging();
			entity.AutoReS = this;
		}
		
		private void LiBroS_Detach(LiBroS entity)
		{
			this.SendPropertyChanging();
			entity.AutoReS = null;
		}
		#endregion
	}
	
	[Table(Name="biblioteca.detalles")]
	public partial class DETallEs : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _idejeMPlAR;
		
		private int _idlIBro;
		
		private int _idprEstAmO;
		
		private EntityRef<PRestAmos> _prEstAmos = new EntityRef<PRestAmos>();
		
		private EntityRef<EJEmPLares> _ejeMPlAres = new EntityRef<EJEmPLares>();
		
		private EntityRef<EJEmPLares> _ejeMPlAres1 = new EntityRef<EJEmPLares>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDEJEmPLaRChanged();
		
		partial void OnIDEJEmPLaRChanging(int value);
		
		partial void OnIDLiBroChanged();
		
		partial void OnIDLiBroChanging(int value);
		
		partial void OnIDPRestAmOChanged();
		
		partial void OnIDPRestAmOChanging(int value);
		#endregion
		
		
		public DETallEs()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_idejeMPlAR", Name="id_ejemplar", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDEJEmPLaR
		{
			get
			{
				return this._idejeMPlAR;
			}
			set
			{
				if ((_idejeMPlAR != value))
				{
					this.OnIDEJEmPLaRChanging(value);
					this.SendPropertyChanging();
					this._idejeMPlAR = value;
					this.SendPropertyChanged("IDEJEmPLaR");
					this.OnIDEJEmPLaRChanged();
				}
			}
		}
		
		[Column(Storage="_idlIBro", Name="id_libro", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDLiBro
		{
			get
			{
				return this._idlIBro;
			}
			set
			{
				if ((_idlIBro != value))
				{
					this.OnIDLiBroChanging(value);
					this.SendPropertyChanging();
					this._idlIBro = value;
					this.SendPropertyChanged("IDLiBro");
					this.OnIDLiBroChanged();
				}
			}
		}
		
		[Column(Storage="_idprEstAmO", Name="id_prestamo", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDPRestAmO
		{
			get
			{
				return this._idprEstAmO;
			}
			set
			{
				if ((_idprEstAmO != value))
				{
					this.OnIDPRestAmOChanging(value);
					this.SendPropertyChanging();
					this._idprEstAmO = value;
					this.SendPropertyChanged("IDPRestAmO");
					this.OnIDPRestAmOChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_prEstAmos", OtherKey="IDPRestAmO", ThisKey="IDPRestAmO", Name="detalles_ibfk_1", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public PRestAmos PRestAmos
		{
			get
			{
				return this._prEstAmos.Entity;
			}
			set
			{
				if (((this._prEstAmos.Entity == value) 
							== false))
				{
					if ((this._prEstAmos.Entity != null))
					{
						PRestAmos previousPRestAmos = this._prEstAmos.Entity;
						this._prEstAmos.Entity = null;
						previousPRestAmos.DETallEs.Remove(this);
					}
					this._prEstAmos.Entity = value;
					if ((value != null))
					{
						value.DETallEs.Add(this);
						_idprEstAmO = value.IDPRestAmO;
					}
					else
					{
						_idprEstAmO = default(int);
					}
				}
			}
		}
		
		[Association(Storage="_ejeMPlAres", OtherKey="IDLiBro", ThisKey="IDLiBro", Name="detalles_ibfk_2", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public EJEmPLares EJEmPLares
		{
			get
			{
				return this._ejeMPlAres.Entity;
			}
			set
			{
				if (((this._ejeMPlAres.Entity == value) 
							== false))
				{
					if ((this._ejeMPlAres.Entity != null))
					{
						EJEmPLares previousEJEmPLares = this._ejeMPlAres.Entity;
						this._ejeMPlAres.Entity = null;
						previousEJEmPLares.DETallEs.Remove(this);
					}
					this._ejeMPlAres.Entity = value;
					if ((value != null))
					{
						value.DETallEs.Add(this);
						_idlIBro = value.IDLiBro;
					}
					else
					{
						_idlIBro = default(int);
					}
				}
			}
		}
		
		[Association(Storage="_ejeMPlAres1", OtherKey="IDEJEmPLaR", ThisKey="IDEJEmPLaR", Name="detalles_ibfk_3", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public EJEmPLares EJEmPLares1
		{
			get
			{
				return this._ejeMPlAres1.Entity;
			}
			set
			{
				if (((this._ejeMPlAres1.Entity == value) 
							== false))
				{
					if ((this._ejeMPlAres1.Entity != null))
					{
						EJEmPLares previousEJEmPLares = this._ejeMPlAres1.Entity;
						this._ejeMPlAres1.Entity = null;
						previousEJEmPLares.DETallEs1.Remove(this);
					}
					this._ejeMPlAres1.Entity = value;
					if ((value != null))
					{
						value.DETallEs1.Add(this);
						_idejeMPlAR = value.IDEJEmPLaR;
					}
					else
					{
						_idejeMPlAR = default(int);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="biblioteca.ejemplares")]
	public partial class EJEmPLares : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _estAdoActual;
		
		private int _idejeMPlAR;
		
		private int _idlIBro;
		
		private EntitySet<DETallEs> _detAllEs;
		
		private EntitySet<DETallEs> _detAllEs1;
		
		private EntitySet<REseRvAs> _reSeRvAs;
		
		private EntityRef<LiBroS> _liBroS = new EntityRef<LiBroS>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnEstAdoActualChanged();
		
		partial void OnEstAdoActualChanging(string value);
		
		partial void OnIDEJEmPLaRChanged();
		
		partial void OnIDEJEmPLaRChanging(int value);
		
		partial void OnIDLiBroChanged();
		
		partial void OnIDLiBroChanging(int value);
		#endregion
		
		
		public EJEmPLares()
		{
			_detAllEs = new EntitySet<DETallEs>(new Action<DETallEs>(this.DETallEs_Attach), new Action<DETallEs>(this.DETallEs_Detach));
			_detAllEs1 = new EntitySet<DETallEs>(new Action<DETallEs>(this.DETallEs1_Attach), new Action<DETallEs>(this.DETallEs1_Detach));
			_reSeRvAs = new EntitySet<REseRvAs>(new Action<REseRvAs>(this.REseRvAs_Attach), new Action<REseRvAs>(this.REseRvAs_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_estAdoActual", Name="estado_actual", DbType="varchar(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string EstAdoActual
		{
			get
			{
				return this._estAdoActual;
			}
			set
			{
				if (((_estAdoActual == value) 
							== false))
				{
					this.OnEstAdoActualChanging(value);
					this.SendPropertyChanging();
					this._estAdoActual = value;
					this.SendPropertyChanged("EstAdoActual");
					this.OnEstAdoActualChanged();
				}
			}
		}
		
		[Column(Storage="_idejeMPlAR", Name="id_ejemplar", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDEJEmPLaR
		{
			get
			{
				return this._idejeMPlAR;
			}
			set
			{
				if ((_idejeMPlAR != value))
				{
					this.OnIDEJEmPLaRChanging(value);
					this.SendPropertyChanging();
					this._idejeMPlAR = value;
					this.SendPropertyChanged("IDEJEmPLaR");
					this.OnIDEJEmPLaRChanged();
				}
			}
		}
		
		[Column(Storage="_idlIBro", Name="id_libro", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDLiBro
		{
			get
			{
				return this._idlIBro;
			}
			set
			{
				if ((_idlIBro != value))
				{
					this.OnIDLiBroChanging(value);
					this.SendPropertyChanging();
					this._idlIBro = value;
					this.SendPropertyChanged("IDLiBro");
					this.OnIDLiBroChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_detAllEs", OtherKey="IDLiBro", ThisKey="IDLiBro", Name="detalles_ibfk_2")]
		[DebuggerNonUserCode()]
		public EntitySet<DETallEs> DETallEs
		{
			get
			{
				return this._detAllEs;
			}
			set
			{
				this._detAllEs = value;
			}
		}
		
		[Association(Storage="_detAllEs1", OtherKey="IDEJEmPLaR", ThisKey="IDEJEmPLaR", Name="detalles_ibfk_3")]
		[DebuggerNonUserCode()]
		public EntitySet<DETallEs> DETallEs1
		{
			get
			{
				return this._detAllEs1;
			}
			set
			{
				this._detAllEs1 = value;
			}
		}
		
		[Association(Storage="_reSeRvAs", OtherKey="IDEJEmPLaR", ThisKey="IDEJEmPLaR", Name="reservas_ibfk_2")]
		[DebuggerNonUserCode()]
		public EntitySet<REseRvAs> REseRvAs
		{
			get
			{
				return this._reSeRvAs;
			}
			set
			{
				this._reSeRvAs = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_liBroS", OtherKey="IDLiBro", ThisKey="IDLiBro", Name="ejemplares_ibfk_1", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public LiBroS LiBroS
		{
			get
			{
				return this._liBroS.Entity;
			}
			set
			{
				if (((this._liBroS.Entity == value) 
							== false))
				{
					if ((this._liBroS.Entity != null))
					{
						LiBroS previousLiBroS = this._liBroS.Entity;
						this._liBroS.Entity = null;
						previousLiBroS.EJEmPLares.Remove(this);
					}
					this._liBroS.Entity = value;
					if ((value != null))
					{
						value.EJEmPLares.Add(this);
						_idlIBro = value.IDLiBro;
					}
					else
					{
						_idlIBro = default(int);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void DETallEs_Attach(DETallEs entity)
		{
			this.SendPropertyChanging();
			entity.EJEmPLares = this;
		}
		
		private void DETallEs_Detach(DETallEs entity)
		{
			this.SendPropertyChanging();
			entity.EJEmPLares = null;
		}
		
		private void DETallEs1_Attach(DETallEs entity)
		{
			this.SendPropertyChanging();
			entity.EJEmPLares1 = this;
		}
		
		private void DETallEs1_Detach(DETallEs entity)
		{
			this.SendPropertyChanging();
			entity.EJEmPLares1 = null;
		}
		
		private void REseRvAs_Attach(REseRvAs entity)
		{
			this.SendPropertyChanging();
			entity.EJEmPLares = this;
		}
		
		private void REseRvAs_Detach(REseRvAs entity)
		{
			this.SendPropertyChanging();
			entity.EJEmPLares = null;
		}
		#endregion
	}
	
	[Table(Name="biblioteca.libros")]
	public partial class LiBroS : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _editorial;
		
		private string _geNero;
		
		private int _idaUtoR;
		
		private int _idlIBro;
		
		private System.Nullable<int> _isbn;
		
		private string _titUlO;
		
		private EntitySet<EJEmPLares> _ejeMPlAres;
		
		private EntitySet<REseRvAs> _reSeRvAs;
		
		private EntityRef<AutoReS> _autoReS = new EntityRef<AutoReS>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnEditorialChanged();
		
		partial void OnEditorialChanging(string value);
		
		partial void OnGeNeroChanged();
		
		partial void OnGeNeroChanging(string value);
		
		partial void OnIDAutoRChanged();
		
		partial void OnIDAutoRChanging(int value);
		
		partial void OnIDLiBroChanged();
		
		partial void OnIDLiBroChanging(int value);
		
		partial void OnIsbnChanged();
		
		partial void OnIsbnChanging(System.Nullable<int> value);
		
		partial void OnTitUlOChanged();
		
		partial void OnTitUlOChanging(string value);
		#endregion
		
		
		public LiBroS()
		{
			_ejeMPlAres = new EntitySet<EJEmPLares>(new Action<EJEmPLares>(this.EJEmPLares_Attach), new Action<EJEmPLares>(this.EJEmPLares_Detach));
			_reSeRvAs = new EntitySet<REseRvAs>(new Action<REseRvAs>(this.REseRvAs_Attach), new Action<REseRvAs>(this.REseRvAs_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_editorial", Name="editorial", DbType="varchar(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Editorial
		{
			get
			{
				return this._editorial;
			}
			set
			{
				if (((_editorial == value) 
							== false))
				{
					this.OnEditorialChanging(value);
					this.SendPropertyChanging();
					this._editorial = value;
					this.SendPropertyChanged("Editorial");
					this.OnEditorialChanged();
				}
			}
		}
		
		[Column(Storage="_geNero", Name="genero", DbType="varchar(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string GeNero
		{
			get
			{
				return this._geNero;
			}
			set
			{
				if (((_geNero == value) 
							== false))
				{
					this.OnGeNeroChanging(value);
					this.SendPropertyChanging();
					this._geNero = value;
					this.SendPropertyChanged("GeNero");
					this.OnGeNeroChanged();
				}
			}
		}
		
		[Column(Storage="_idaUtoR", Name="id_autor", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDAutoR
		{
			get
			{
				return this._idaUtoR;
			}
			set
			{
				if ((_idaUtoR != value))
				{
					this.OnIDAutoRChanging(value);
					this.SendPropertyChanging();
					this._idaUtoR = value;
					this.SendPropertyChanged("IDAutoR");
					this.OnIDAutoRChanged();
				}
			}
		}
		
		[Column(Storage="_idlIBro", Name="id_libro", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDLiBro
		{
			get
			{
				return this._idlIBro;
			}
			set
			{
				if ((_idlIBro != value))
				{
					this.OnIDLiBroChanging(value);
					this.SendPropertyChanging();
					this._idlIBro = value;
					this.SendPropertyChanged("IDLiBro");
					this.OnIDLiBroChanged();
				}
			}
		}
		
		[Column(Storage="_isbn", Name="ISBN", DbType="int(13)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Isbn
		{
			get
			{
				return this._isbn;
			}
			set
			{
				if ((_isbn != value))
				{
					this.OnIsbnChanging(value);
					this.SendPropertyChanging();
					this._isbn = value;
					this.SendPropertyChanged("Isbn");
					this.OnIsbnChanged();
				}
			}
		}
		
		[Column(Storage="_titUlO", Name="titulo", DbType="varchar(40)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string TitUlO
		{
			get
			{
				return this._titUlO;
			}
			set
			{
				if (((_titUlO == value) 
							== false))
				{
					this.OnTitUlOChanging(value);
					this.SendPropertyChanging();
					this._titUlO = value;
					this.SendPropertyChanged("TitUlO");
					this.OnTitUlOChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_ejeMPlAres", OtherKey="IDLiBro", ThisKey="IDLiBro", Name="ejemplares_ibfk_1")]
		[DebuggerNonUserCode()]
		public EntitySet<EJEmPLares> EJEmPLares
		{
			get
			{
				return this._ejeMPlAres;
			}
			set
			{
				this._ejeMPlAres = value;
			}
		}
		
		[Association(Storage="_reSeRvAs", OtherKey="IDLiBro", ThisKey="IDLiBro", Name="reservas_ibfk_1")]
		[DebuggerNonUserCode()]
		public EntitySet<REseRvAs> REseRvAs
		{
			get
			{
				return this._reSeRvAs;
			}
			set
			{
				this._reSeRvAs = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_autoReS", OtherKey="IDAutoR", ThisKey="IDAutoR", Name="libros_ibfk_1", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public AutoReS AutoReS
		{
			get
			{
				return this._autoReS.Entity;
			}
			set
			{
				if (((this._autoReS.Entity == value) 
							== false))
				{
					if ((this._autoReS.Entity != null))
					{
						AutoReS previousAutoReS = this._autoReS.Entity;
						this._autoReS.Entity = null;
						previousAutoReS.LiBroS.Remove(this);
					}
					this._autoReS.Entity = value;
					if ((value != null))
					{
						value.LiBroS.Add(this);
						_idaUtoR = value.IDAutoR;
					}
					else
					{
						_idaUtoR = default(int);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void EJEmPLares_Attach(EJEmPLares entity)
		{
			this.SendPropertyChanging();
			entity.LiBroS = this;
		}
		
		private void EJEmPLares_Detach(EJEmPLares entity)
		{
			this.SendPropertyChanging();
			entity.LiBroS = null;
		}
		
		private void REseRvAs_Attach(REseRvAs entity)
		{
			this.SendPropertyChanging();
			entity.LiBroS = this;
		}
		
		private void REseRvAs_Detach(REseRvAs entity)
		{
			this.SendPropertyChanging();
			entity.LiBroS = null;
		}
		#endregion
	}
	
	[Table(Name="biblioteca.prestamos")]
	public partial class PRestAmos : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private sbyte _devolUCiOn;
		
		private System.DateTime _fechaInicio;
		
		private System.DateTime _fechaVencimiento;
		
		private int _idprEstAmO;
		
		private int _idsOCiO;
		
		private EntitySet<DETallEs> _detAllEs;
		
		private EntityRef<SoCIoS> _soCiOS = new EntityRef<SoCIoS>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDEVOLuCIonChanged();
		
		partial void OnDEVOLuCIonChanging(sbyte value);
		
		partial void OnFechaInicioChanged();
		
		partial void OnFechaInicioChanging(System.DateTime value);
		
		partial void OnFechaVencimientoChanged();
		
		partial void OnFechaVencimientoChanging(System.DateTime value);
		
		partial void OnIDPRestAmOChanged();
		
		partial void OnIDPRestAmOChanging(int value);
		
		partial void OnIDSoCIoChanged();
		
		partial void OnIDSoCIoChanging(int value);
		#endregion
		
		
		public PRestAmos()
		{
			_detAllEs = new EntitySet<DETallEs>(new Action<DETallEs>(this.DETallEs_Attach), new Action<DETallEs>(this.DETallEs_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_devolUCiOn", Name="devolucion", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte DEVOLuCIon
		{
			get
			{
				return this._devolUCiOn;
			}
			set
			{
				if ((_devolUCiOn != value))
				{
					this.OnDEVOLuCIonChanging(value);
					this.SendPropertyChanging();
					this._devolUCiOn = value;
					this.SendPropertyChanged("DEVOLuCIon");
					this.OnDEVOLuCIonChanged();
				}
			}
		}
		
		[Column(Storage="_fechaInicio", Name="fechaInicio", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime FechaInicio
		{
			get
			{
				return this._fechaInicio;
			}
			set
			{
				if ((_fechaInicio != value))
				{
					this.OnFechaInicioChanging(value);
					this.SendPropertyChanging();
					this._fechaInicio = value;
					this.SendPropertyChanged("FechaInicio");
					this.OnFechaInicioChanged();
				}
			}
		}
		
		[Column(Storage="_fechaVencimiento", Name="fechaVencimiento", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime FechaVencimiento
		{
			get
			{
				return this._fechaVencimiento;
			}
			set
			{
				if ((_fechaVencimiento != value))
				{
					this.OnFechaVencimientoChanging(value);
					this.SendPropertyChanging();
					this._fechaVencimiento = value;
					this.SendPropertyChanged("FechaVencimiento");
					this.OnFechaVencimientoChanged();
				}
			}
		}
		
		[Column(Storage="_idprEstAmO", Name="id_prestamo", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDPRestAmO
		{
			get
			{
				return this._idprEstAmO;
			}
			set
			{
				if ((_idprEstAmO != value))
				{
					this.OnIDPRestAmOChanging(value);
					this.SendPropertyChanging();
					this._idprEstAmO = value;
					this.SendPropertyChanged("IDPRestAmO");
					this.OnIDPRestAmOChanged();
				}
			}
		}
		
		[Column(Storage="_idsOCiO", Name="id_socio", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDSoCIo
		{
			get
			{
				return this._idsOCiO;
			}
			set
			{
				if ((_idsOCiO != value))
				{
					this.OnIDSoCIoChanging(value);
					this.SendPropertyChanging();
					this._idsOCiO = value;
					this.SendPropertyChanged("IDSoCIo");
					this.OnIDSoCIoChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_detAllEs", OtherKey="IDPRestAmO", ThisKey="IDPRestAmO", Name="detalles_ibfk_1")]
		[DebuggerNonUserCode()]
		public EntitySet<DETallEs> DETallEs
		{
			get
			{
				return this._detAllEs;
			}
			set
			{
				this._detAllEs = value;
			}
		}
		#endregion
		
		#region Parents
		[Association(Storage="_soCiOS", OtherKey="IDSoCIo", ThisKey="IDSoCIo", Name="prestamos_ibfk_1", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public SoCIoS SoCIoS
		{
			get
			{
				return this._soCiOS.Entity;
			}
			set
			{
				if (((this._soCiOS.Entity == value) 
							== false))
				{
					if ((this._soCiOS.Entity != null))
					{
						SoCIoS previousSoCIoS = this._soCiOS.Entity;
						this._soCiOS.Entity = null;
						previousSoCIoS.PRestAmos.Remove(this);
					}
					this._soCiOS.Entity = value;
					if ((value != null))
					{
						value.PRestAmos.Add(this);
						_idsOCiO = value.IDSoCIo;
					}
					else
					{
						_idsOCiO = default(int);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void DETallEs_Attach(DETallEs entity)
		{
			this.SendPropertyChanging();
			entity.PRestAmos = this;
		}
		
		private void DETallEs_Detach(DETallEs entity)
		{
			this.SendPropertyChanging();
			entity.PRestAmos = null;
		}
		#endregion
	}
	
	[Table(Name="biblioteca.reservas")]
	public partial class REseRvAs : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _fechaReserva;
		
		private System.DateTime _fechaRetiro;
		
		private int _idejeMPlAR;
		
		private int _idlIBro;
		
		private int _idreSeRvA;
		
		private int _idsOCiO;
		
		private sbyte _retIrAdo;
		
		private EntityRef<LiBroS> _liBroS = new EntityRef<LiBroS>();
		
		private EntityRef<EJEmPLares> _ejeMPlAres = new EntityRef<EJEmPLares>();
		
		private EntityRef<SoCIoS> _soCiOS = new EntityRef<SoCIoS>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnFechaReservaChanged();
		
		partial void OnFechaReservaChanging(System.DateTime value);
		
		partial void OnFechaRetiroChanged();
		
		partial void OnFechaRetiroChanging(System.DateTime value);
		
		partial void OnIDEJEmPLaRChanged();
		
		partial void OnIDEJEmPLaRChanging(int value);
		
		partial void OnIDLiBroChanged();
		
		partial void OnIDLiBroChanging(int value);
		
		partial void OnIDREseRvAChanged();
		
		partial void OnIDREseRvAChanging(int value);
		
		partial void OnIDSoCIoChanged();
		
		partial void OnIDSoCIoChanging(int value);
		
		partial void OnRetIrAdoChanged();
		
		partial void OnRetIrAdoChanging(sbyte value);
		#endregion
		
		
		public REseRvAs()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_fechaReserva", Name="fechaReserva", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime FechaReserva
		{
			get
			{
				return this._fechaReserva;
			}
			set
			{
				if ((_fechaReserva != value))
				{
					this.OnFechaReservaChanging(value);
					this.SendPropertyChanging();
					this._fechaReserva = value;
					this.SendPropertyChanged("FechaReserva");
					this.OnFechaReservaChanged();
				}
			}
		}
		
		[Column(Storage="_fechaRetiro", Name="fechaRetiro", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime FechaRetiro
		{
			get
			{
				return this._fechaRetiro;
			}
			set
			{
				if ((_fechaRetiro != value))
				{
					this.OnFechaRetiroChanging(value);
					this.SendPropertyChanging();
					this._fechaRetiro = value;
					this.SendPropertyChanged("FechaRetiro");
					this.OnFechaRetiroChanged();
				}
			}
		}
		
		[Column(Storage="_idejeMPlAR", Name="id_ejemplar", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDEJEmPLaR
		{
			get
			{
				return this._idejeMPlAR;
			}
			set
			{
				if ((_idejeMPlAR != value))
				{
					this.OnIDEJEmPLaRChanging(value);
					this.SendPropertyChanging();
					this._idejeMPlAR = value;
					this.SendPropertyChanged("IDEJEmPLaR");
					this.OnIDEJEmPLaRChanged();
				}
			}
		}
		
		[Column(Storage="_idlIBro", Name="id_libro", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDLiBro
		{
			get
			{
				return this._idlIBro;
			}
			set
			{
				if ((_idlIBro != value))
				{
					this.OnIDLiBroChanging(value);
					this.SendPropertyChanging();
					this._idlIBro = value;
					this.SendPropertyChanged("IDLiBro");
					this.OnIDLiBroChanged();
				}
			}
		}
		
		[Column(Storage="_idreSeRvA", Name="id_reserva", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDREseRvA
		{
			get
			{
				return this._idreSeRvA;
			}
			set
			{
				if ((_idreSeRvA != value))
				{
					this.OnIDREseRvAChanging(value);
					this.SendPropertyChanging();
					this._idreSeRvA = value;
					this.SendPropertyChanged("IDREseRvA");
					this.OnIDREseRvAChanged();
				}
			}
		}
		
		[Column(Storage="_idsOCiO", Name="id_socio", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDSoCIo
		{
			get
			{
				return this._idsOCiO;
			}
			set
			{
				if ((_idsOCiO != value))
				{
					this.OnIDSoCIoChanging(value);
					this.SendPropertyChanging();
					this._idsOCiO = value;
					this.SendPropertyChanged("IDSoCIo");
					this.OnIDSoCIoChanged();
				}
			}
		}
		
		[Column(Storage="_retIrAdo", Name="retirado", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte RetIrAdo
		{
			get
			{
				return this._retIrAdo;
			}
			set
			{
				if ((_retIrAdo != value))
				{
					this.OnRetIrAdoChanging(value);
					this.SendPropertyChanging();
					this._retIrAdo = value;
					this.SendPropertyChanged("RetIrAdo");
					this.OnRetIrAdoChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_liBroS", OtherKey="IDLiBro", ThisKey="IDLiBro", Name="reservas_ibfk_1", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public LiBroS LiBroS
		{
			get
			{
				return this._liBroS.Entity;
			}
			set
			{
				if (((this._liBroS.Entity == value) 
							== false))
				{
					if ((this._liBroS.Entity != null))
					{
						LiBroS previousLiBroS = this._liBroS.Entity;
						this._liBroS.Entity = null;
						previousLiBroS.REseRvAs.Remove(this);
					}
					this._liBroS.Entity = value;
					if ((value != null))
					{
						value.REseRvAs.Add(this);
						_idlIBro = value.IDLiBro;
					}
					else
					{
						_idlIBro = default(int);
					}
				}
			}
		}
		
		[Association(Storage="_ejeMPlAres", OtherKey="IDEJEmPLaR", ThisKey="IDEJEmPLaR", Name="reservas_ibfk_2", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public EJEmPLares EJEmPLares
		{
			get
			{
				return this._ejeMPlAres.Entity;
			}
			set
			{
				if (((this._ejeMPlAres.Entity == value) 
							== false))
				{
					if ((this._ejeMPlAres.Entity != null))
					{
						EJEmPLares previousEJEmPLares = this._ejeMPlAres.Entity;
						this._ejeMPlAres.Entity = null;
						previousEJEmPLares.REseRvAs.Remove(this);
					}
					this._ejeMPlAres.Entity = value;
					if ((value != null))
					{
						value.REseRvAs.Add(this);
						_idejeMPlAR = value.IDEJEmPLaR;
					}
					else
					{
						_idejeMPlAR = default(int);
					}
				}
			}
		}
		
		[Association(Storage="_soCiOS", OtherKey="IDSoCIo", ThisKey="IDSoCIo", Name="reservas_ibfk_3", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public SoCIoS SoCIoS
		{
			get
			{
				return this._soCiOS.Entity;
			}
			set
			{
				if (((this._soCiOS.Entity == value) 
							== false))
				{
					if ((this._soCiOS.Entity != null))
					{
						SoCIoS previousSoCIoS = this._soCiOS.Entity;
						this._soCiOS.Entity = null;
						previousSoCIoS.REseRvAs.Remove(this);
					}
					this._soCiOS.Entity = value;
					if ((value != null))
					{
						value.REseRvAs.Add(this);
						_idsOCiO = value.IDSoCIo;
					}
					else
					{
						_idsOCiO = default(int);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="biblioteca.socios")]
	public partial class SoCIoS : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _apeLlIdo;
		
		private int _dnI;
		
		private int _idsOCiO;
		
		private string _noMbReS;
		
		private System.Nullable<int> _teLefoNO;
		
		private string _tipO;
		
		private EntitySet<PRestAmos> _prEstAmos;
		
		private EntitySet<REseRvAs> _reSeRvAs;
		
		private EntitySet<UsUarIoS> _usUarIoS;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnApeLLidoChanged();
		
		partial void OnApeLLidoChanging(string value);
		
		partial void OnDNiChanged();
		
		partial void OnDNiChanging(int value);
		
		partial void OnIDSoCIoChanged();
		
		partial void OnIDSoCIoChanging(int value);
		
		partial void OnNoMbReSChanged();
		
		partial void OnNoMbReSChanging(string value);
		
		partial void OnTeLEFOnOChanged();
		
		partial void OnTeLEFOnOChanging(System.Nullable<int> value);
		
		partial void OnTipOChanged();
		
		partial void OnTipOChanging(string value);
		#endregion
		
		
		public SoCIoS()
		{
			_prEstAmos = new EntitySet<PRestAmos>(new Action<PRestAmos>(this.PRestAmos_Attach), new Action<PRestAmos>(this.PRestAmos_Detach));
			_reSeRvAs = new EntitySet<REseRvAs>(new Action<REseRvAs>(this.REseRvAs_Attach), new Action<REseRvAs>(this.REseRvAs_Detach));
			_usUarIoS = new EntitySet<UsUarIoS>(new Action<UsUarIoS>(this.UsUarIoS_Attach), new Action<UsUarIoS>(this.UsUarIoS_Detach));
			this.OnCreated();
		}
		
		[Column(Storage="_apeLlIdo", Name="apellido", DbType="varchar(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ApeLLido
		{
			get
			{
				return this._apeLlIdo;
			}
			set
			{
				if (((_apeLlIdo == value) 
							== false))
				{
					this.OnApeLLidoChanging(value);
					this.SendPropertyChanging();
					this._apeLlIdo = value;
					this.SendPropertyChanged("ApeLLido");
					this.OnApeLLidoChanged();
				}
			}
		}
		
		[Column(Storage="_dnI", Name="DNI", DbType="int(8)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int DNi
		{
			get
			{
				return this._dnI;
			}
			set
			{
				if ((_dnI != value))
				{
					this.OnDNiChanging(value);
					this.SendPropertyChanging();
					this._dnI = value;
					this.SendPropertyChanged("DNi");
					this.OnDNiChanged();
				}
			}
		}
		
		[Column(Storage="_idsOCiO", Name="id_socio", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDSoCIo
		{
			get
			{
				return this._idsOCiO;
			}
			set
			{
				if ((_idsOCiO != value))
				{
					this.OnIDSoCIoChanging(value);
					this.SendPropertyChanging();
					this._idsOCiO = value;
					this.SendPropertyChanged("IDSoCIo");
					this.OnIDSoCIoChanged();
				}
			}
		}
		
		[Column(Storage="_noMbReS", Name="nombres", DbType="varchar(40)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string NoMbReS
		{
			get
			{
				return this._noMbReS;
			}
			set
			{
				if (((_noMbReS == value) 
							== false))
				{
					this.OnNoMbReSChanging(value);
					this.SendPropertyChanging();
					this._noMbReS = value;
					this.SendPropertyChanged("NoMbReS");
					this.OnNoMbReSChanged();
				}
			}
		}
		
		[Column(Storage="_teLefoNO", Name="telefono", DbType="int(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> TeLEFOnO
		{
			get
			{
				return this._teLefoNO;
			}
			set
			{
				if ((_teLefoNO != value))
				{
					this.OnTeLEFOnOChanging(value);
					this.SendPropertyChanging();
					this._teLefoNO = value;
					this.SendPropertyChanged("TeLEFOnO");
					this.OnTeLEFOnOChanged();
				}
			}
		}
		
		[Column(Storage="_tipO", Name="tipo", DbType="varchar(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string TipO
		{
			get
			{
				return this._tipO;
			}
			set
			{
				if (((_tipO == value) 
							== false))
				{
					this.OnTipOChanging(value);
					this.SendPropertyChanging();
					this._tipO = value;
					this.SendPropertyChanged("TipO");
					this.OnTipOChanged();
				}
			}
		}
		
		#region Children
		[Association(Storage="_prEstAmos", OtherKey="IDSoCIo", ThisKey="IDSoCIo", Name="prestamos_ibfk_1")]
		[DebuggerNonUserCode()]
		public EntitySet<PRestAmos> PRestAmos
		{
			get
			{
				return this._prEstAmos;
			}
			set
			{
				this._prEstAmos = value;
			}
		}
		
		[Association(Storage="_reSeRvAs", OtherKey="IDSoCIo", ThisKey="IDSoCIo", Name="reservas_ibfk_3")]
		[DebuggerNonUserCode()]
		public EntitySet<REseRvAs> REseRvAs
		{
			get
			{
				return this._reSeRvAs;
			}
			set
			{
				this._reSeRvAs = value;
			}
		}
		
		[Association(Storage="_usUarIoS", OtherKey="IDSoCIo", ThisKey="IDSoCIo", Name="usuarios_ibfk_1")]
		[DebuggerNonUserCode()]
		public EntitySet<UsUarIoS> UsUarIoS
		{
			get
			{
				return this._usUarIoS;
			}
			set
			{
				this._usUarIoS = value;
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		#region Attachment handlers
		private void PRestAmos_Attach(PRestAmos entity)
		{
			this.SendPropertyChanging();
			entity.SoCIoS = this;
		}
		
		private void PRestAmos_Detach(PRestAmos entity)
		{
			this.SendPropertyChanging();
			entity.SoCIoS = null;
		}
		
		private void REseRvAs_Attach(REseRvAs entity)
		{
			this.SendPropertyChanging();
			entity.SoCIoS = this;
		}
		
		private void REseRvAs_Detach(REseRvAs entity)
		{
			this.SendPropertyChanging();
			entity.SoCIoS = null;
		}
		
		private void UsUarIoS_Attach(UsUarIoS entity)
		{
			this.SendPropertyChanging();
			entity.SoCIoS = this;
		}
		
		private void UsUarIoS_Detach(UsUarIoS entity)
		{
			this.SendPropertyChanging();
			entity.SoCIoS = null;
		}
		#endregion
	}
	
	[Table(Name="biblioteca.usuarios")]
	public partial class UsUarIoS : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _email;
		
		private int _idsOCiO;
		
		private int _pass;
		
		private EntityRef<SoCIoS> _soCiOS = new EntityRef<SoCIoS>();
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnEmailChanged();
		
		partial void OnEmailChanging(string value);
		
		partial void OnIDSoCIoChanged();
		
		partial void OnIDSoCIoChanging(int value);
		
		partial void OnPassChanged();
		
		partial void OnPassChanging(int value);
		#endregion
		
		
		public UsUarIoS()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_email", Name="email", DbType="varchar(30)", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Email
		{
			get
			{
				return this._email;
			}
			set
			{
				if (((_email == value) 
							== false))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[Column(Storage="_idsOCiO", Name="id_socio", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int IDSoCIo
		{
			get
			{
				return this._idsOCiO;
			}
			set
			{
				if ((_idsOCiO != value))
				{
					this.OnIDSoCIoChanging(value);
					this.SendPropertyChanging();
					this._idsOCiO = value;
					this.SendPropertyChanged("IDSoCIo");
					this.OnIDSoCIoChanged();
				}
			}
		}
		
		[Column(Storage="_pass", Name="pass", DbType="int(41)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int Pass
		{
			get
			{
				return this._pass;
			}
			set
			{
				if ((_pass != value))
				{
					this.OnPassChanging(value);
					this.SendPropertyChanging();
					this._pass = value;
					this.SendPropertyChanged("Pass");
					this.OnPassChanged();
				}
			}
		}
		
		#region Parents
		[Association(Storage="_soCiOS", OtherKey="IDSoCIo", ThisKey="IDSoCIo", Name="usuarios_ibfk_1", IsForeignKey=true)]
		[DebuggerNonUserCode()]
		public SoCIoS SoCIoS
		{
			get
			{
				return this._soCiOS.Entity;
			}
			set
			{
				if (((this._soCiOS.Entity == value) 
							== false))
				{
					if ((this._soCiOS.Entity != null))
					{
						SoCIoS previousSoCIoS = this._soCiOS.Entity;
						this._soCiOS.Entity = null;
						previousSoCIoS.UsUarIoS.Remove(this);
					}
					this._soCiOS.Entity = value;
					if ((value != null))
					{
						value.UsUarIoS.Add(this);
						_idsOCiO = value.IDSoCIo;
					}
					else
					{
						_idsOCiO = default(int);
					}
				}
			}
		}
		#endregion
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
