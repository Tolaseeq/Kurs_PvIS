﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using LinqConnect template.
// Code is generated on: 04.09.2021 19:21:43
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using Devart.Data.Linq;
using Devart.Data.Linq.Mapping;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;

namespace FsDbContext
{

    [DatabaseAttribute(Name = "fs_db")]
    [ProviderAttribute(typeof(Devart.Data.MySql.Linq.Provider.MySqlDataProvider))]
    public partial class FsDbDataContext : Devart.Data.Linq.DataContext
    {
        public static CompiledQueryCache compiledQueryCache = CompiledQueryCache.RegisterDataContext(typeof(FsDbDataContext));
        private static MappingSource mappingSource = new Devart.Data.Linq.Mapping.AttributeMappingSource();

        #region Extensibility Method Definitions
    
        partial void OnCreated();
        partial void OnSubmitError(Devart.Data.Linq.SubmitErrorEventArgs args);
        partial void InsertFilm(Film instance);
        partial void UpdateFilm(Film instance);
        partial void DeleteFilm(Film instance);
        partial void InsertUser(User instance);
        partial void UpdateUser(User instance);
        partial void DeleteUser(User instance);

        #endregion

        public FsDbDataContext() :
        base(@"User Id=root;Password=1234;Host=localhost;Database=fs_db;Persist Security Info=True", mappingSource)
        {
            OnCreated();
        }

        public FsDbDataContext(MappingSource mappingSource) :
        base(@"User Id=root;Password=1234;Host=localhost;Database=fs_db;Persist Security Info=True", mappingSource)
        {
            OnCreated();
        }

        public FsDbDataContext(string connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public FsDbDataContext(System.Data.IDbConnection connection) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public FsDbDataContext(string connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public FsDbDataContext(System.Data.IDbConnection connection, MappingSource mappingSource) :
            base(connection, mappingSource)
        {
          OnCreated();
        }

        public Devart.Data.Linq.Table<Film> Films
        {
            get
            {
                return this.GetTable<Film>();
            }
        }

        public Devart.Data.Linq.Table<User> Users
        {
            get
            {
                return this.GetTable<User>();
            }
        }
    }
}

namespace FsDbContext
{

    /// <summary>
    /// There are no comments for FsDbContext.Film in the schema.
    /// </summary>
    [Table(Name = @"fs_db.films")]
    public partial class Film : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _FilmId;

        private string _FilmName;

        private string _FilmGenre;

        private string _FilmDescription;

        private int? _CriticRate;
        #pragma warning restore 0649

        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnFilmIdChanging(int value);
        partial void OnFilmIdChanged();
        partial void OnFilmNameChanging(string value);
        partial void OnFilmNameChanged();
        partial void OnFilmGenreChanging(string value);
        partial void OnFilmGenreChanged();
        partial void OnFilmDescriptionChanging(string value);
        partial void OnFilmDescriptionChanged();
        partial void OnCriticRateChanging(int? value);
        partial void OnCriticRateChanged();
        #endregion

        public Film()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for FilmId in the schema.
        /// </summary>
        [Column(Name = @"film_id", Storage = "_FilmId", AutoSync = AutoSync.OnInsert, CanBeNull = false, DbType = "INT NOT NULL AUTO_INCREMENT", IsDbGenerated = true, IsPrimaryKey = true)]
        public int FilmId
        {
            get
            {
                return this._FilmId;
            }
            set
            {
                if (this._FilmId != value)
                {
                    this.OnFilmIdChanging(value);
                    this.SendPropertyChanging("FilmId");
                    this._FilmId = value;
                    this.SendPropertyChanged("FilmId");
                    this.OnFilmIdChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for FilmName in the schema.
        /// </summary>
        [Column(Name = @"film_name", Storage = "_FilmName", CanBeNull = false, DbType = "VARCHAR(45) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string FilmName
        {
            get
            {
                return this._FilmName;
            }
            set
            {
                if (this._FilmName != value)
                {
                    this.OnFilmNameChanging(value);
                    this.SendPropertyChanging("FilmName");
                    this._FilmName = value;
                    this.SendPropertyChanged("FilmName");
                    this.OnFilmNameChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for FilmGenre in the schema.
        /// </summary>
        [Column(Name = @"film_genre", Storage = "_FilmGenre", CanBeNull = false, DbType = "VARCHAR(45) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string FilmGenre
        {
            get
            {
                return this._FilmGenre;
            }
            set
            {
                if (this._FilmGenre != value)
                {
                    this.OnFilmGenreChanging(value);
                    this.SendPropertyChanging("FilmGenre");
                    this._FilmGenre = value;
                    this.SendPropertyChanged("FilmGenre");
                    this.OnFilmGenreChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for FilmDescription in the schema.
        /// </summary>
        [Column(Name = @"film_description", Storage = "_FilmDescription", DbType = "VARCHAR(45) NULL", UpdateCheck = UpdateCheck.Never)]
        public string FilmDescription
        {
            get
            {
                return this._FilmDescription;
            }
            set
            {
                if (this._FilmDescription != value)
                {
                    this.OnFilmDescriptionChanging(value);
                    this.SendPropertyChanging("FilmDescription");
                    this._FilmDescription = value;
                    this.SendPropertyChanged("FilmDescription");
                    this.OnFilmDescriptionChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for CriticRate in the schema.
        /// </summary>
        [Column(Name = @"critic_rate", Storage = "_CriticRate", DbType = "INT NULL", UpdateCheck = UpdateCheck.Never)]
        public int? CriticRate
        {
            get
            {
                return this._CriticRate;
            }
            set
            {
                if (this._CriticRate != value)
                {
                    this.OnCriticRateChanging(value);
                    this.SendPropertyChanging("CriticRate");
                    this._CriticRate = value;
                    this.SendPropertyChanged("CriticRate");
                    this.OnCriticRateChanged();
                }
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    /// <summary>
    /// There are no comments for FsDbContext.User in the schema.
    /// </summary>
    [Table(Name = @"fs_db.users")]
    public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
    {

        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(System.String.Empty);
        #pragma warning disable 0649

        private int _UserId;

        private string _Username;

        private string _Password;

        private sbyte _BanStatus;

        private sbyte _IsAdmin;
        #pragma warning restore 0649

        #region Extensibility Method Definitions

        partial void OnLoaded();
        partial void OnValidate(ChangeAction action);
        partial void OnCreated();
        partial void OnUserIdChanging(int value);
        partial void OnUserIdChanged();
        partial void OnUsernameChanging(string value);
        partial void OnUsernameChanged();
        partial void OnPasswordChanging(string value);
        partial void OnPasswordChanged();
        partial void OnBanStatusChanging(sbyte value);
        partial void OnBanStatusChanged();
        partial void OnIsAdminChanging(sbyte value);
        partial void OnIsAdminChanged();
        #endregion

        public User()
        {
            OnCreated();
        }

    
        /// <summary>
        /// There are no comments for UserId in the schema.
        /// </summary>
        [Column(Name = @"user_id", Storage = "_UserId", AutoSync = AutoSync.OnInsert, CanBeNull = false, DbType = "INT NOT NULL AUTO_INCREMENT", IsDbGenerated = true, IsPrimaryKey = true)]
        public int UserId
        {
            get
            {
                return this._UserId;
            }
            set
            {
                if (this._UserId != value)
                {
                    this.OnUserIdChanging(value);
                    this.SendPropertyChanging("UserId");
                    this._UserId = value;
                    this.SendPropertyChanged("UserId");
                    this.OnUserIdChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Username in the schema.
        /// </summary>
        [Column(Name = @"username", Storage = "_Username", CanBeNull = false, DbType = "VARCHAR(45) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Username
        {
            get
            {
                return this._Username;
            }
            set
            {
                if (this._Username != value)
                {
                    this.OnUsernameChanging(value);
                    this.SendPropertyChanging("Username");
                    this._Username = value;
                    this.SendPropertyChanged("Username");
                    this.OnUsernameChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for Password in the schema.
        /// </summary>
        [Column(Name = @"`password`", Storage = "_Password", CanBeNull = false, DbType = "VARCHAR(45) NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public string Password
        {
            get
            {
                return this._Password;
            }
            set
            {
                if (this._Password != value)
                {
                    this.OnPasswordChanging(value);
                    this.SendPropertyChanging("Password");
                    this._Password = value;
                    this.SendPropertyChanged("Password");
                    this.OnPasswordChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for BanStatus in the schema.
        /// </summary>
        [Column(Name = @"ban_status", Storage = "_BanStatus", CanBeNull = false, DbType = "TINYINT NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public sbyte BanStatus
        {
            get
            {
                return this._BanStatus;
            }
            set
            {
                if (this._BanStatus != value)
                {
                    this.OnBanStatusChanging(value);
                    this.SendPropertyChanging("BanStatus");
                    this._BanStatus = value;
                    this.SendPropertyChanged("BanStatus");
                    this.OnBanStatusChanged();
                }
            }
        }

    
        /// <summary>
        /// There are no comments for IsAdmin in the schema.
        /// </summary>
        [Column(Name = @"is_admin", Storage = "_IsAdmin", CanBeNull = false, DbType = "TINYINT NOT NULL", UpdateCheck = UpdateCheck.Never)]
        public sbyte IsAdmin
        {
            get
            {
                return this._IsAdmin;
            }
            set
            {
                if (this._IsAdmin != value)
                {
                    this.OnIsAdminChanging(value);
                    this.SendPropertyChanging("IsAdmin");
                    this._IsAdmin = value;
                    this.SendPropertyChanged("IsAdmin");
                    this.OnIsAdminChanged();
                }
            }
        }
   
        public event PropertyChangingEventHandler PropertyChanging;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void SendPropertyChanging()
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, emptyChangingEventArgs);
        }

        protected virtual void SendPropertyChanging(System.String propertyName) 
        {
            var handler = this.PropertyChanging;
            if (handler != null)
                handler(this, new PropertyChangingEventArgs(propertyName));
        }

        protected virtual void SendPropertyChanged(System.String propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
