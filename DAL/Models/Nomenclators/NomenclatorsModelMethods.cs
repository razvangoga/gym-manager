using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using DAL.Logic;
using DAL.Models.Nomenclators;

namespace DAL.Models.Nomenclators
{
    public class NomenclatorsModelMethods
    {
        #region Clients
        public class ClientMethods
        {
            public static void GetData()
            {
                try
                {
                    var _clients = from client in Session.NomenclatorsModel.Clients
                                   select client;
                    Session.Clients = ((IListSource)_clients).GetList() as BindingList<Client>;
                }
                catch (SqlException se)
                {
                    throw se;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static Client GetDataById(int p_id)
            {
                try
                {
                    var _query = from client in Session.NomenclatorsRefresherModel.Clients
                                 where client.id == p_id
                                 select client;
                    return _query.FirstOrDefault();
                }
                catch (SqlException se)
                {
                    throw se;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static Client GetClientById(int p_id)
            {
                try
                {
                    var _query = from client in Session.Clients
                                 where client.id == p_id
                                 select client;
                    return _query.FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static string GetFKValue(int p_id)
            {
                Client _client = GetClientById(p_id);

                if (_client == null)
                {
                    return "n/a";
                }
                else
                {
                    return _client.ClientName;
                }
            }

            public static bool CheckUniqueKey(Client p_client)
            {
                try
                {
                    ISingleResult<Client> _result = Session.NomenclatorsModel.Clients_GetClientByUniqueKey(p_client.ClientName, p_client.id);
                    if (_result.FirstOrDefault() == null)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception(string.Format("Exista definit deja un client cu numele '{0}'", p_client.ClientName));
                        return false;
                    }
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static bool CanDelete(Client p_client)
            {
                try
                {
                    var _result = Session.NomenclatorsModel.Clients_CanDelete(p_client.id);

                    int _nCount = _result.FirstOrDefault().ClientCount.Value;
                    if (_nCount == 0)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception(string.Format("Clientul '{0}' a facut rezervari de terenuri. El nu poate fi sters!", p_client.ClientName));
                        return false;
                    }
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void AddClient(Client p_client)
            {
                try
                {
                    int? nId = -1;

                    Session.NomenclatorsModel.Clients_Insert(ref nId,
                        p_client.ClientName, p_client.FiscalCode, p_client.TradeCode,
                        p_client.Address, p_client.Phone, p_client.Bank, p_client.BankAccount,
                        p_client.DiscountProcent, p_client.IsActive, p_client.created_by, p_client.created_at);
                    p_client.id = nId.Value;
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void EditClient(Client p_client)
            {
                try
                {
                    Session.NomenclatorsModel.Clients_Update(p_client.id,
                        p_client.ClientName, p_client.FiscalCode, p_client.TradeCode,
                        p_client.Address, p_client.Phone, p_client.Bank, p_client.BankAccount,
                        p_client.DiscountProcent, p_client.IsActive, p_client.updated_by, p_client.updated_at);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void DeleteClient(Client p_client)
            {
                try
                {
                    Session.NomenclatorsModel.Clients_Delete(p_client.id);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void CancelModifications(Client p_client)
            {
                if (p_client != null)
                    ModelLogic.MergeRows(p_client, GetDataById(p_client.id));
            }

            public static string BuildFilterByActiveStatus(bool p_bIsActive)
            {
                return string.Format("IsActive = {0}", p_bIsActive);
            }

            public static string BuildSort()
            {
                return "ClientName ASC";
            }

            public static List<Client> GetActiveClients()
            {
                var _query = from client in Session.Clients
                             where client.IsActive == true
                             orderby client.ClientName
                             select client;
                List<Client> _list = _query.ToList();

                if (_list == null)
                    _list = new List<Client>();

                return _list;
            }

            public static List<Client> GetActiveInvoicebleClients()
            {
                var _query = from client in Session.Clients
                             where client.IsActive == true && client.id > 0
                             orderby client.ClientName
                             select client;
                List<Client> _list = _query.ToList();

                if (_list == null)
                    _list = new List<Client>();

                return _list;
            }
        }
        #endregion

        #region Entry Types
        public class EntryTypeMethods
        {
            public static void GetData()
            {
                try
                {
                    var _entryTypes = from entryType in Session.NomenclatorsModel.Entry_Types
                                      select entryType;
                    Session.Entry_Types = ((IListSource)_entryTypes).GetList() as BindingList<Entry_Type>;
                }
                catch (SqlException se)
                {
                    throw se;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private static Entry_Type GetDataById(int p_id)
            {
                try
                {
                    var _query = from entryType in Session.NomenclatorsRefresherModel.Entry_Types
                                 where entryType.id == p_id
                                 select entryType;
                    return _query.FirstOrDefault();
                }
                catch (SqlException se)
                {
                    throw se;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static Entry_Type GetEntryTypeById(int p_id)
            {
                try
                {
                    var _query = from entryType in Session.Entry_Types
                                 where entryType.id == p_id
                                 select entryType;
                    return _query.FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static string GetFKValue(int p_id)
            {
                Entry_Type _entry_type = GetEntryTypeById(p_id);

                if (_entry_type == null)
                {
                    return "n/a";
                }
                else
                {
                    return _entry_type.EntryType;
                }
            }

            public static bool CheckUniqueKey(Entry_Type p_entryType)
            {
                try
                {
                    ISingleResult<Entry_Type> _result = Session.NomenclatorsModel.Entry_Types_GetEntryTypeByUniqueKey(p_entryType.EntryType, p_entryType.id);
                    if (_result.FirstOrDefault() == null)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception(string.Format("Exista definita o categorie de intrari cu aceasta denumire '{0}'", p_entryType.EntryType));
                        return false;
                    }
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static bool CanDelete(Entry_Type p_entryType)
            {
                try
                {
                    var _result = Session.NomenclatorsModel.Entry_Types_CanDelete(p_entryType.id);

                    int _nCount = _result.FirstOrDefault().EntryTypeCount.Value;
                    if (_nCount == 0)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception(string.Format("Au fost facute intrari de tipul '{0}'. Tipul nu poate fi sters!", p_entryType.EntryType));
                        return false;
                    }
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void AddEntryType(Entry_Type p_entryType)
            {
                try
                {
                    int? nId = -1;

                    Session.NomenclatorsModel.Entry_Types_Insert(ref nId,
                        p_entryType.EntryType, p_entryType.Description,
                        p_entryType.Price, p_entryType.IsActive,
                        p_entryType.created_by, p_entryType.created_at);
                    p_entryType.id = nId.Value;
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void EditEntryType(Entry_Type p_entryType)
            {
                try
                {
                    Session.NomenclatorsModel.Entry_Types_Update(p_entryType.id,
                        p_entryType.EntryType, p_entryType.Description,
                        p_entryType.Price, p_entryType.IsActive,
                        p_entryType.updated_by, p_entryType.updated_at);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void DeleteEntryType(Entry_Type p_entryType)
            {
                try
                {
                    Session.NomenclatorsModel.Entry_Types_Delete(p_entryType.id);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void CancelModifications(Entry_Type p_entryType)
            {
                if (p_entryType != null)
                    ModelLogic.MergeRows(p_entryType, GetDataById(p_entryType.id));
            }

            public static string BuildFilterByActiveStatus(bool p_bIsActive)
            {
                return string.Format("IsActive = {0}", p_bIsActive);
            }

            public static string BuildSort()
            {
                return "EntryType ASC";
            }

            public static List<Entry_Type> GetActiveEntryTypes()
            {
                var _query = from entryType in Session.Entry_Types
                             where entryType.IsActive == true
                             orderby entryType.EntryType
                             select entryType;
                List<Entry_Type> _list = _query.ToList();

                if (_list == null)
                    _list = new List<Entry_Type>();

                return _list;
            }
        }
        #endregion

        #region Fields
        public class FieldMethods
        {
            public static void GetData()
            {
                try
                {
                    var _fields = from field in Session.NomenclatorsModel.Fields
                                  select field;
                    Session.Fields = ((IListSource)_fields).GetList() as BindingList<Field>;
                }
                catch (SqlException se)
                {
                    throw se;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            private static Field GetDataById(int p_id)
            {
                try
                {
                    var _query = from field in Session.NomenclatorsRefresherModel.Fields
                                 where field.id == p_id
                                 select field;
                    return _query.FirstOrDefault();
                }
                catch (SqlException se)
                {
                    throw se;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static Field GetFieldById(int p_id)
            {
                try
                {
                    var _query = from field in Session.Fields
                                 where field.id == p_id
                                 select field;
                    return _query.FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static bool CheckUniqueKey(Field p_field)
            {
                try
                {
                    ISingleResult<Field> _result = Session.NomenclatorsModel.Fields_GetFieldByUniqueKey(p_field.FieldName, p_field.id);
                    if (_result.FirstOrDefault() == null)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception(string.Format("Exista definit un teren cu acest nume '{0}'", p_field.FieldName));
                        return false;
                    }
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static bool CanDelete(Field p_field)
            {
                try
                {
                    var _result = Session.NomenclatorsModel.Fields_CanDelete(p_field.id);

                    int _nCount = _result.FirstOrDefault().FieldCount.Value;
                    if (_nCount == 0)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception(string.Format("Au fost facute rezervari pentru terenul '{0}'. Terenul nu poate fi sters!", p_field.FieldName));
                        return false;
                    }
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void AddField(Field p_field)
            {
                try
                {
                    int? nId = -1;

                    Session.NomenclatorsModel.Fields_Insert(ref nId,
                        p_field.FieldName, p_field.Description,
                        p_field.Price, p_field.MinimumRentHours,
                        p_field.IsActive,
                        p_field.created_by, p_field.created_at);
                    p_field.id = nId.Value;
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void EditField(Field p_field)
            {
                try
                {
                    Session.NomenclatorsModel.Fields_Update(p_field.id,
                        p_field.FieldName, p_field.Description,
                        p_field.Price, p_field.MinimumRentHours,
                        p_field.IsActive,
                        p_field.updated_by, p_field.updated_at);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void DeleteField(Field p_field)
            {
                try
                {
                    Session.NomenclatorsModel.Fields_Delete(p_field.id);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void CancelModifications(Field p_field)
            {
                if (p_field != null)
                    ModelLogic.MergeRows(p_field, GetDataById(p_field.id));
            }

            public static List<Field> GetActiveFields()
            {
                var _query = from field in Session.Fields
                             where field.IsActive == true
                             orderby field.FieldName
                             select field;
                List<Field> _list = _query.ToList();

                if (_list == null)
                    _list = new List<Field>();

                return _list;
            }
        }
        #endregion

        #region Field Reservation Statuses
        public class FieldReservationStatusesMethods
        {
            public static void GetData()
            {
                try
                {
                    var _fieldReservationsStatus = from fieldReservationsStatus in Session.NomenclatorsModel.Field_Reservation_Status
                                                   select fieldReservationsStatus;
                    Session.Field_Reservation_Statuses = ((IListSource)_fieldReservationsStatus).GetList() as BindingList<Field_Reservation_Status>;
                }
                catch (SqlException se)
                {
                    throw se;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }

            public static Field_Reservation_Status GetFieldReservationStatusById(int p_id)
            {
                try
                {
                    var _query = from fielRezervationStatus in Session.Field_Reservation_Statuses
                                 where fielRezervationStatus.id == p_id
                                 select fielRezervationStatus;
                    return _query.FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static string BuildSortByFieldReservationStatusName()
            {
                return "FieldReservationStatus ASC";
            }

            public static string GetFKValue(int p_id)
            {
                Field_Reservation_Status _field_Reservation_Status = GetFieldReservationStatusById(p_id);

                if (_field_Reservation_Status == null)
                {
                    return "n/a";
                }
                else
                {
                    return _field_Reservation_Status.FieldReservationStatus;
                }
            }
        }
        #endregion

        #region Organization Details
        public class OrganizationDetailsMethods
        {
            public static void GetData()
            {
                try
                {
                    var _organizationDetails = from organizationDetails in Session.NomenclatorsModel.Organization_Details
                                               select organizationDetails;
                    Session.Organization_Details = ((IListSource)_organizationDetails).GetList() as BindingList<Organization_Detail>;
                }
                catch (SqlException se)
                {
                    throw se;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static void EditOrganizationDetails(Organization_Detail p_organization_Detail)
            {
                try
                {
                    Session.NomenclatorsModel.Organization_Details_Update(p_organization_Detail.id,
                p_organization_Detail.OrganizationName, p_organization_Detail.FiscalCode, p_organization_Detail.TradeCode,
                p_organization_Detail.Address, p_organization_Detail.Phone, p_organization_Detail.Bank,
                p_organization_Detail.BankAccount,
                p_organization_Detail.updated_by, p_organization_Detail.updated_at);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void CancelModifications(Organization_Detail p_organization_Detail)
            {
                if (p_organization_Detail != null)
                    Session.NomenclatorsModel.Refresh(RefreshMode.OverwriteCurrentValues, p_organization_Detail);
            }

            public static Organization_Detail GetOrganizationDetails()
            {
                if (Session.Organization_Details == null)
                    GetData();

                return Session.Organization_Details[0];
            }
        }
        #endregion

        #region Product Types
        public class ProductTypeMethods
        {
            public static void GetData()
            {
                try
                {
                    var _productTypes = from productType in Session.NomenclatorsModel.Product_Types
                                        select productType;
                    Session.Product_Types = ((IListSource)_productTypes).GetList() as BindingList<Product_Type>;
                }
                catch (SqlException se)
                {
                    throw se;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static List<Product_Type> GetActiveProductTypes()
            {
                var _query = from productType in Session.Product_Types
                             where productType.IsActive == true
                             orderby productType.ProductType ascending
                             select productType;

                List<Product_Type> _list = _query.ToList();

                if (_list == null)
                    _list = new List<Product_Type>();

                return _list;
            }

            public static Product_Type GetDataById(int p_id)
            {
                try
                {
                    var _productType = from productType in Session.NomenclatorsRefresherModel.Product_Types
                                       where productType.id == p_id
                                       select productType;
                    return _productType.FirstOrDefault();
                }
                catch (SqlException se)
                {
                    throw se;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static bool CheckUniqueKey(Product_Type p_productType)
            {
                try
                {
                    ISingleResult<Product_Type> _result = Session.NomenclatorsModel.Product_Types_GetProductTypeByUniqueKey(p_productType.ProductType, p_productType.id);
                    if (_result.FirstOrDefault() == null)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception(string.Format("Exista definita o categorie de produse cu acesta denumire '{0}'", p_productType.ProductType));
                        return false;
                    }
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static bool CanDelete(Product_Type p_productType)
            {
                try
                {
                    var _result = Session.NomenclatorsModel.Product_Types_CanDelete(p_productType.id);

                    int _nCount = _result.FirstOrDefault().ProductTypeCount.Value;
                    if (_nCount == 0)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception(string.Format("Exista produse cu aceasta categorie : '{0}'. Categoria nu poate fi stearsa!", p_productType.ProductType));
                        return false;
                    }
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void AddProductType(Product_Type p_productType)
            {
                try
                {
                    int? nId = -1;

                    Session.NomenclatorsModel.Product_Types_Insert(ref nId,
                        p_productType.ProductType, p_productType.IsActive,
                        p_productType.created_by, p_productType.created_at);
                    p_productType.id = nId.Value;
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void EditProductType(Product_Type p_productType)
            {
                try
                {
                    Session.NomenclatorsModel.Product_Types_Update(p_productType.id,
                        p_productType.ProductType, p_productType.IsActive,
                        p_productType.updated_by, p_productType.updated_at);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void DeleteProductType(Product_Type p_productType)
            {
                try
                {
                    Session.NomenclatorsModel.Product_Types_Delete(p_productType.id);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void CancelModifications(Product_Type p_productType)
            {
                if (p_productType != null)
                    ModelLogic.MergeRows(p_productType, GetDataById(p_productType.id));
            }
        }
        #endregion

        #region Products
        public class ProductMethods
        {
            public static void GetData()
            {
                try
                {
                    var _products = from product in Session.NomenclatorsModel.Products
                                    select product;
                    Session.Products = ((IListSource)_products).GetList() as BindingList<Product>;
                }
                catch (SqlException se)
                {
                    throw se;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static List<Product> GetActiveProducts()
            {
                var _query = from product in Session.Products
                             where product.IsActive == true
                             orderby product.ProductName ascending
                             select product;
                             
                List<Product> _list = _query.ToList();

                if (_list == null)
                    _list = new List<Product>();

                return _list;
            }

            private static Product GetDataById(int p_id)
            {
                try
                {
                    var _query = from product in Session.NomenclatorsRefresherModel.Products
                                 where product.id == p_id
                                 select product;
                    return _query.FirstOrDefault();
                }
                catch (SqlException se)
                {
                    throw se;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static Product GetProductById(int p_id)
            {
                try
                {
                    var _query = from product in Session.Products
                                 where product.id == p_id
                                 select product;
                    return _query.FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static string GetFKValue(int p_id)
            {
                Product _product = GetProductById(p_id);

                if (_product == null)
                {
                    return "n/a";
                }
                else
                {
                    return _product.ProductName;
                }
            }

            public static bool CheckUniqueKey(Product p_product)
            {
                try
                {
                    ISingleResult<Product> _result = Session.NomenclatorsModel.Products_GetProductByUniqueKey(p_product.ProductName, p_product.id);
                    if (_result.FirstOrDefault() == null)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception(string.Format("Exista definit un produs cu acesta denumire '{0}'", p_product.ProductName));
                        return false;
                    }
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static bool CanDelete(Product p_product)
            {
                try
                {
                    var _result = Session.NomenclatorsModel.Products_CanDelete(p_product.id);

                    int _nCount = _result.FirstOrDefault().ProductsCount.Value;
                    if (_nCount == 0)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception(string.Format("Exista miscari pentru produsul '{0}'. Produsul nu poate fi sters!", p_product.ProductName));
                        return false;
                    }
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void AddProduct(Product p_product)
            {
                try
                {
                    int? nId = -1;

                    Session.NomenclatorsModel.Products_Insert(ref nId,
                        p_product.ProductName, p_product.Description, p_product.Product_Type_id,
                        p_product.SalesPrice, p_product.LastPurchasePrice, p_product.LastPurchaseDate,
                        p_product.IsActive, p_product.created_by, p_product.created_at);
                    p_product.id = nId.Value;
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void EditProduct(Product p_product)
            {
                try
                {
                    Session.NomenclatorsModel.Products_Update(p_product.id,
                       p_product.ProductName, p_product.Description, p_product.Product_Type_id,
                       p_product.SalesPrice, p_product.LastPurchasePrice, p_product.LastPurchaseDate,
                       p_product.IsActive, p_product.updated_by, p_product.updated_at);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void DeleteProduct(Product p_product)
            {
                try
                {
                    Session.NomenclatorsModel.Products_Delete(p_product.id);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void CancelModifications(Product p_product)
            {
                if (p_product != null)
                    ModelLogic.MergeRows(p_product, GetDataById(p_product.id));
            }
        }
        #endregion

        #region Subscription Type
        public class SubscriptionTypeMethods
        {
            public static void GetData()
            {
                try
                {
                    var _subscriptionTypes = from subscriptionType in Session.NomenclatorsModel.Subscription_Types
                                             select subscriptionType;
                    Session.Subscription_Types = ((IListSource)_subscriptionTypes).GetList() as BindingList<Subscription_Type>;
                }
                catch (SqlException se)
                {
                    throw se;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static List<Subscription_Type> GetActiveSubscriptionTypes()
            {
                var _query = from subscription in Session.Subscription_Types
                             where subscription.IsActive == true
                             orderby subscription.SubscriptionType ascending
                             select subscription;

                List<Subscription_Type> _list = _query.ToList();

                if (_list == null)
                    _list = new List<Subscription_Type>();

                return _list;
            }

            private static Subscription_Type GetDataById(int p_id)
            {
                try
                {
                    var _query = from subscriptionType in Session.NomenclatorsRefresherModel.Subscription_Types
                                 where subscriptionType.id == p_id
                                 select subscriptionType;
                    return _query.FirstOrDefault();
                }
                catch (SqlException se)
                {
                    throw se;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static Subscription_Type GetSubscriptionTypeById(int p_id)
            {
                try
                {
                    var _query = from subscriptionType in Session.Subscription_Types
                                 where subscriptionType.id == p_id
                                 select subscriptionType;
                    return _query.FirstOrDefault();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static string GetFKValue(int p_id)
            {
                Subscription_Type _subscription_Type = GetSubscriptionTypeById(p_id);

                if (_subscription_Type == null)
                {
                    return "n/a";
                }
                else
                {
                    return _subscription_Type.SubscriptionType;
                }
            }

            public static bool CheckUniqueKey(Subscription_Type p_subscription_Type)
            {
                try
                {
                    ISingleResult<Subscription_Type> _result = Session.NomenclatorsModel.Subscription_Types_GetSubscriptionTypeByUniqueKey(p_subscription_Type.SubscriptionType, p_subscription_Type.id);
                    if (_result.FirstOrDefault() == null)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception(string.Format("Exista definita o categorie de abonamente cu acesta denumire '{0}'", p_subscription_Type.SubscriptionType));
                        return false;
                    }
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static bool CanDelete(Subscription_Type p_subscription_Type)
            {
                try
                {
                    var _result = Session.NomenclatorsModel.Subscription_Types_CanDelete(p_subscription_Type.id);

                    int _nCount = _result.FirstOrDefault().SubscriptionTypeCount.Value;
                    if (_nCount == 0)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception(string.Format("Exista abonamente definite cu categoria '{0}'. Categoria nu poate fi stearsa!", p_subscription_Type.SubscriptionType));
                        return false;
                    }
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void AddSubscriptionType(Subscription_Type p_subscription_Type)
            {
                try
                {
                    int? nId = -1;

                    Session.NomenclatorsModel.Subscription_Types_Insert(ref nId,
                        p_subscription_Type.SubscriptionType, p_subscription_Type.Description,
                        p_subscription_Type.Price, p_subscription_Type.HasUnilimitedEntries,
                        p_subscription_Type.EntryNumber, p_subscription_Type.IsActive,
                        p_subscription_Type.created_by, p_subscription_Type.created_at);
                    p_subscription_Type.id = nId.Value;
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void EditSubscriptionType(Subscription_Type p_subscription_Type)
            {
                try
                {
                    Session.NomenclatorsModel.Subscription_Types_Update(p_subscription_Type.id,
                        p_subscription_Type.SubscriptionType, p_subscription_Type.Description,
                        p_subscription_Type.Price, p_subscription_Type.HasUnilimitedEntries,
                        p_subscription_Type.EntryNumber, p_subscription_Type.IsActive,
                        p_subscription_Type.updated_by, p_subscription_Type.updated_at);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void DeleteSubscriptionType(Subscription_Type p_subscription_Type)
            {
                try
                {
                    Session.NomenclatorsModel.Subscription_Types_Delete(p_subscription_Type.id);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void CancelModifications(Subscription_Type p_subscription_Type)
            {
                if (p_subscription_Type != null)
                    ModelLogic.MergeRows(p_subscription_Type, GetDataById(p_subscription_Type.id));
            }
        }
        #endregion
    }
}
