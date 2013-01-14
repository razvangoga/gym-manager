using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

using DAL.Models.Nomenclators;
using DAL.Models.Operations;
using DAL.Models.Security;
using DAL.Views.Operations;
using DAL.Views.Security;
using Helpers.GeneralOperations;

namespace DAL.Logic
{
    public class Session
    {
        #region Session Variables
        #region General
        private static User _loggedUser = null;

        private static NomenclatorsModelDataContext _nomenclatorsModelDataContext = null;
        private static OperationsModelDataContext _operationsModelDataContext = null;
        private static SecurityModelDataContext _securityModelDataContext = null;

        private static NomenclatorsModelDataContext _nomenclatorsRefresherModelDataContext = null;
        private static OperationsModelDataContext _operationsRefresherModelDataContext = null;
        private static SecurityModelDataContext _securityRefresherModelDataContext = null;

        private static OperationsViewDataContext _operationsViewDataContext = null;
        private static SecurityViewDataContext _securityViewDataContext = null; 
        #endregion

        #region Nomenclators
        private static BindingList<Client> _clients = null;
        private static BindingList<Entry_Type> _entry_types = null;
        private static BindingList<Field> _fields = null;
        private static BindingList<Field_Reservation_Status> _field_Reservation_Statuses = null;
        private static BindingList<Organization_Detail> _organization_Details = null;
        private static BindingList<Product> _products = null;
        private static BindingList<Product_Type> _product_Types = null;
        private static BindingList<Subscription_Type> _subscription_Types = null;
        #endregion
        #region Operations
        private static BindingList<Entry> _entries = null;
        private static BindingList<Field_Reservation> _field_Reservations = null;
        private static BindingList<Product_Entry> _product_Entries = null;
        private static BindingList<Product_Sale> _product_Sales = null;
        private static BindingList<Subscription> _subscriptions = null;
        private static BindingList<Subscription_Entry> _subscription_Entries = null;
        #endregion
        #region Security
        private static BindingList<Access_Right> _access_Rights = null;
        private static BindingList<Role> _roles = null;
        private static BindingList<Roles_Access_Right> _roles_Access_Rights = null;
        private static BindingList<User> _users = null; 
        #endregion
        #endregion

        #region Session Cache
        #region Nomenclatos
        public static BindingList<Client> Clients
        {
            get
            {
                if (_clients == null)
                    _clients = new BindingList<Client>();
                return _clients;
            }
            set
            {
                _clients = value;
            }
        }
        public static BindingList<Entry_Type> Entry_Types
        {
            get
            {
                if (_entry_types == null)
                    _entry_types = new BindingList<Entry_Type>();
                return _entry_types;
            }
            set
            {
                _entry_types = value;
            }
        }
        public static BindingList<Field> Fields
        {
            get
            {
                if (_fields == null)
                    _fields = new BindingList<Field>();
                return _fields;
            }
            set
            {
                _fields = value;
            }
        }
        public static BindingList<Field_Reservation_Status> Field_Reservation_Statuses
        {
            get
            {
                if (_field_Reservation_Statuses == null)
                    _field_Reservation_Statuses = new BindingList<Field_Reservation_Status>();
                return _field_Reservation_Statuses;
            }
            set
            {
                _field_Reservation_Statuses = value;
            }
        }
        public static BindingList<Organization_Detail> Organization_Details
        {
            get
            {
                if (_organization_Details == null)
                    _organization_Details = new BindingList<Organization_Detail>();
                return _organization_Details;
            }
            set
            {
                _organization_Details = value;
            }
        }
        public static BindingList<Product> Products
        {
            get
            {
                if (_products == null)
                    _products = new BindingList<Product>();
                return _products;
            }
            set
            {
                _products = value;
            }
        }
        public static BindingList<Product_Type> Product_Types
        {
            get
            {
                if (_product_Types == null)
                    _product_Types = new BindingList<Product_Type>();
                return _product_Types;
            }
            set
            {
                _product_Types = value;
            }
        }
        public static BindingList<Subscription_Type> Subscription_Types
        {
            get
            {
                if (_subscription_Types == null)
                    _subscription_Types = new BindingList<Subscription_Type>();
                return _subscription_Types;
            }
            set
            {
                _subscription_Types = value;
            }
        }
        #endregion
        #region Operation
        public static BindingList<Entry> Entries
        {
            get
            {
                if (_entries == null)
                    _entries = new BindingList<Entry>();
                return _entries;
            }
            set
            {
                _entries = value;
            }
        }
        public static BindingList<Field_Reservation> Field_Reservations
        {
            get
            {
                if (_field_Reservations == null)
                    _field_Reservations = new BindingList<Field_Reservation>();
                return _field_Reservations;
            }
            set
            {
                _field_Reservations = value;
            }
        }
        public static BindingList<Product_Entry> Product_Entries
        {
            get
            {
                if (_product_Entries == null)
                    _product_Entries = new BindingList<Product_Entry>();
                return _product_Entries;
            }
            set
            {
                _product_Entries = value;
            }
        }
        public static BindingList<Product_Sale> Product_Sales
        {
            get
            {
                if (_product_Sales == null)
                    _product_Sales = new BindingList<Product_Sale>();
                return _product_Sales;
            }
            set
            {
                _product_Sales = value;
            }
        }
        public static BindingList<Subscription> Subscriptions
        {
            get
            {
                if (_subscriptions == null)
                    _subscriptions = new BindingList<Subscription>();
                return _subscriptions;
            }
            set
            {
                _subscriptions = value;
            }
        }
        public static BindingList<Subscription_Entry> Subscription_Entries
        {
            get
            {
                if (_subscription_Entries == null)
                    _subscription_Entries = new BindingList<Subscription_Entry>();
                return _subscription_Entries;
            }
            set
            {
                _subscription_Entries = value;
            }
        }
        #endregion
        #region Security
        public static BindingList<Access_Right> Access_Rights
        {
            get
            {
                if (_access_Rights == null)
                    _access_Rights = new BindingList<Access_Right>();
                return _access_Rights;
            }
            set
            {
                _access_Rights = value;
            }
        }
        public static BindingList<Role> Roles
        {
            get
            {
                if (_roles == null)
                    _roles = new BindingList<Role>();
                return _roles;
            }
            set
            {
                _roles = value;
            }
        }
        public static BindingList<Roles_Access_Right> Roles_Access_Rights
        {
            get
            {
                if (_roles_Access_Rights == null)
                    _roles_Access_Rights = new BindingList<Roles_Access_Right>();
                return _roles_Access_Rights;
            }
            set
            {
                _roles_Access_Rights = value;
            }
        }
        public static BindingList<User> Users
        {
            get
            {
                if (_users == null)
                    _users = new BindingList<User>();
                return _users;
            }
            set
            {
                _users = value;
            }
        }  
        #endregion
        #endregion

        #region Session Models Initialization
        public static User LoggedUser
        {
            get
            {
                return _loggedUser;
            }
            set
            {
                _loggedUser = value;
            }
        }

        public static NomenclatorsModelDataContext NomenclatorsModel
        {
            get
            {
                try
                {
                    if (_nomenclatorsModelDataContext == null)
                    {
                        _nomenclatorsModelDataContext = new NomenclatorsModelDataContext(Properties.Settings.Default.Gray_GymManagerConnectionString);
                        _nomenclatorsModelDataContext.Log = Console.Out;
                    }
                    return _nomenclatorsModelDataContext;
                }
                catch (SqlException se)
                {
                    FileOperations.WriteToExceptionLog("DAL.Logic.Session.NomenclatorsDataContext", se.ToString());
                    throw se;
                }
            }
        }
        public static OperationsModelDataContext OperationsModel
        {
            get
            {
                try
                {
                    if (_operationsModelDataContext == null)
                    {
                        _operationsModelDataContext = new OperationsModelDataContext(Properties.Settings.Default.Gray_GymManagerConnectionString);
                        _operationsModelDataContext.Log = Console.Out;
                    }
                    return _operationsModelDataContext;
                }
                catch (SqlException se)
                {
                    FileOperations.WriteToExceptionLog("DAL.Logic.Session.OperationsModelDataContext", se.ToString());
                    throw se;
                }
            }
        }
        public static SecurityModelDataContext SecurityModel
        {
            get
            {
                try
                {
                    if (_securityModelDataContext == null)
                    {
                        _securityModelDataContext = new SecurityModelDataContext(Properties.Settings.Default.Gray_GymManagerConnectionString);
                        _securityModelDataContext.Log = Console.Out;
                    }
                    return _securityModelDataContext;
                }
                catch (SqlException se)
                {
                    FileOperations.WriteToExceptionLog("DAL.Logic.Session.SecurityModelDataContext", se.ToString());
                    throw se;
                }
            }
        }

        internal static NomenclatorsModelDataContext NomenclatorsRefresherModel
        {
            get
            {
                try
                {
                    _nomenclatorsRefresherModelDataContext = new NomenclatorsModelDataContext(Properties.Settings.Default.Gray_GymManagerConnectionString);
                    _nomenclatorsRefresherModelDataContext.Log = Console.Out;
                    return _nomenclatorsRefresherModelDataContext;
                }
                catch (SqlException se)
                {
                    FileOperations.WriteToExceptionLog("DAL.Logic.Session.NomenclatorsRefresherDataContext", se.ToString());
                    throw se;
                }
            }
        }
        internal static OperationsModelDataContext OperationsRefresherModel
        {
            get
            {
                try
                {
                    _operationsRefresherModelDataContext = new OperationsModelDataContext(Properties.Settings.Default.Gray_GymManagerConnectionString);
                    _operationsRefresherModelDataContext.Log = Console.Out;
                    return _operationsRefresherModelDataContext;
                }
                catch (SqlException se)
                {
                    FileOperations.WriteToExceptionLog("DAL.Logic.Session.OperationsRefresherModelDataContext", se.ToString());
                    throw se;
                }
            }
        }
        internal static SecurityModelDataContext SecurityRefresherModel
        {
            get
            {
                try
                {
                    _securityRefresherModelDataContext = new SecurityModelDataContext(Properties.Settings.Default.Gray_GymManagerConnectionString);
                    _securityRefresherModelDataContext.Log = Console.Out;
                    return _securityRefresherModelDataContext;
                }
                catch (SqlException se)
                {
                    FileOperations.WriteToExceptionLog("DAL.Logic.Session.SecurityMRefresherodelDataContext", se.ToString());
                    throw se;
                }
            }
        }

        internal static OperationsViewDataContext OperationsView
        {
            get
            {
                try
                {
                    if (_operationsViewDataContext == null)
                    {
                        _operationsViewDataContext = new OperationsViewDataContext(Properties.Settings.Default.Gray_GymManagerConnectionString);
                        _operationsViewDataContext.Log = Console.Out;
                    }
                    return _operationsViewDataContext;
                }
                catch (SqlException se)
                {
                    FileOperations.WriteToExceptionLog("DAL.Logic.Session.OperationsViewDataContext", se.ToString());
                    throw se;
                }
            }
        }
        internal static SecurityViewDataContext SecurityView
        {
            get
            {
                try
                {
                    if (_securityViewDataContext == null)
                    {
                        _securityViewDataContext = new SecurityViewDataContext(Properties.Settings.Default.Gray_GymManagerConnectionString);
                        _securityViewDataContext.Log = Console.Out;
                    }
                    return _securityViewDataContext;
                }
                catch (SqlException se)
                {
                    FileOperations.WriteToExceptionLog("DAL.Logic.Session.SecurityViewDataContext", se.ToString());
                    throw se;
                }
            }
        }
        #endregion

        public static void ResetSessionConnections()
        {

        }

        public static void LoadStaticData()
        {
            #region Nomenclators
            NomenclatorsModelMethods.ClientMethods.GetData();
            NomenclatorsModelMethods.EntryTypeMethods.GetData();
            NomenclatorsModelMethods.FieldReservationStatusesMethods.GetData();
            NomenclatorsModelMethods.FieldMethods.GetData();
            NomenclatorsModelMethods.OrganizationDetailsMethods.GetData();
            NomenclatorsModelMethods.ProductTypeMethods.GetData();
            NomenclatorsModelMethods.ProductMethods.GetData();
            NomenclatorsModelMethods.SubscriptionTypeMethods.GetData(); 
            #endregion

            #region Security
            SecurityModelMethods.AccessRightsMethods.GetData();
            SecurityModelMethods.RoleMethods.GetData();
            SecurityModelMethods.RolesAccessRigtsMethods.GetData();
            SecurityModelMethods.UserMethods.GetData(); 
            #endregion
        }

        public static string ConnectionString
        {
            get { return DAL.Properties.Settings.Default.ConnectionString; }
        }
    }
}
