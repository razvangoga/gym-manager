using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using DAL.Logic;
using DAL.Models.Operations;

namespace DAL.Models.Operations
{
    public class OperationsModelMethods
    {
        #region Entries
        public class EntriesMethods
        {
            public static void GetData()
            {
                try
                {
                    var _entries = from entry in Session.OperationsModel.Entries
                                   select entry;
                    Session.Entries = ((IListSource)_entries).GetList() as BindingList<Entry>;
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

            public static void GetDataByDay(DateTime p_date)
            {
                try
                {
                    var _entries = from entry in Session.OperationsModel.Entries
                                   where entry.EntryDate.Date == p_date.Date
                                   select entry;
                    //ModelLogic.MergeLists<Entry>(Session.Entries, _entries.ToList());

                    Session.Entries = ((IListSource)_entries).GetList() as BindingList<Entry>;
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

            public static Entry GetDataById(int p_id)
            {
                try
                {
                    var _query = from entry in Session.OperationsRefresherModel.Entries
                                 where entry.id == p_id
                                 select entry;
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

            public static void AddEntry(Entry p_entry)
            {
                try
                {
                    int? nId = -1;

                    Session.OperationsModel.Entries_Insert(ref nId,
                        p_entry.Entry_Type_id, p_entry.EntryDate,
                        p_entry.Price, p_entry.DiscountProcent, p_entry.Details,
                        p_entry.Client_id,
                        p_entry.created_by, p_entry.created_at);
                    p_entry.id = nId.Value;
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void EditEntry(Entry p_entry)
            {
                try
                {
                    Session.OperationsModel.Entries_Update(p_entry.id,
                        p_entry.Entry_Type_id, p_entry.EntryDate,
                        p_entry.Price, p_entry.DiscountProcent, p_entry.Details,
                        p_entry.Client_id,
                        p_entry.updated_by, p_entry.updated_at);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void DeleteEntry(Entry p_entry)
            {
                try
                {
                    Session.OperationsModel.Entries_Delete(p_entry.id);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void CancelModifications(Entry p_entry)
            {
                if (p_entry != null)
                    ModelLogic.MergeRows(p_entry, GetDataById(p_entry.id));
            }

            public static string BuildFilterByDate(DateTime p_date)
            {
                return string.Format("EntryDate >= '{0} 00:00:00' AND EntryDate <= '{0} 23:59:59'", p_date.ToString("dd/MM/yyyy"));
            }
        }
        #endregion

        #region Field Reservations
        public class FieldReservationsMethods
        {
            public static List<Field_Reservation> GetActiveDataForFieldInDay(int p_Field_id, DateTime p_date)
            {
                try
                {
                    var _fieldReservations = from fieldReservation in Session.OperationsModel.Field_Reservations
                                             where fieldReservation.Field_id == p_Field_id 
                                                && ((fieldReservation.ReservationFromDate >= new DateTime(p_date.Year, p_date.Month, p_date.Day, p_date.Hour, 14, 0 ,0) 
                                                    && fieldReservation.ReservationFromDate < new DateTime(p_date.Year, p_date.Month, p_date.Day + 1, p_date.Hour, 0, 0 ,0))
                                                    || ((fieldReservation.ReservationFromDate >= new DateTime(p_date.Year, p_date.Month, p_date.Day + 1, p_date.Hour, 0, 0 ,0) 
                                                    && fieldReservation.ReservationFromDate < new DateTime(p_date.Year, p_date.Month, p_date.Day + 1, p_date.Hour, 4, 0 ,0))))
                                                && fieldReservation.Field_Reservation_Status_id != 4
                                             orderby fieldReservation.ReservationFromDate
                                             select fieldReservation;

                    List<Field_Reservation> _list = _fieldReservations.ToList();

                    if (_list == null)
                        _list = new List<Field_Reservation>();

                    for (int i = 0; i < _list.Count; i++)
                        CancelModifications(_list[i]);

                    return _list;
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

            public static List<Field_Reservation> GetCanceldDataForFieldInDay(int p_Field_id, DateTime p_date)
            {
                try
                {
                    var _fieldReservations = from fieldReservation in Session.OperationsModel.Field_Reservations
                                             where fieldReservation.Field_id == p_Field_id
                                                && ((fieldReservation.ReservationFromDate >= new DateTime(p_date.Year, p_date.Month, p_date.Day, p_date.Hour, 14, 0, 0)
                                                    && fieldReservation.ReservationFromDate < new DateTime(p_date.Year, p_date.Month, p_date.Day + 1, p_date.Hour, 0, 0, 0))
                                                    || ((fieldReservation.ReservationFromDate >= new DateTime(p_date.Year, p_date.Month, p_date.Day + 1, p_date.Hour, 0, 0, 0)
                                                    && fieldReservation.ReservationFromDate < new DateTime(p_date.Year, p_date.Month, p_date.Day + 1, p_date.Hour, 4, 0, 0))))
                                                && fieldReservation.Field_Reservation_Status_id == 4
                                             orderby fieldReservation.ReservationFromDate
                                             select fieldReservation;

                    List<Field_Reservation> _list = _fieldReservations.ToList();

                    if (_list == null)
                        _list = new List<Field_Reservation>();

                    return _list;
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

            public static Field_Reservation GetDataById(int p_id)
            {
                try
                {
                    var _query = from fieldReservation in Session.OperationsRefresherModel.Field_Reservations
                                 where fieldReservation.id == p_id
                                 select fieldReservation;
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

            public static void AddFieldReservation(Field_Reservation p_field_Reservation)
            {
                try
                {
                    int? nId = -1;

                    if (p_field_Reservation.ReservationToDate.Hour == 0
                        && p_field_Reservation.ReservationToDate.Minute == 0)
                    {
                        p_field_Reservation.ReservationToDate.AddSeconds(-1);
                    }

                    Session.OperationsModel.Field_Reservations_Insert(ref nId,
                        p_field_Reservation.Field_id, p_field_Reservation.Client_id,
                        p_field_Reservation.Price, p_field_Reservation.DiscountProcent, p_field_Reservation.Description,
                        p_field_Reservation.ReservationFromDate, p_field_Reservation.ReservationToDate, p_field_Reservation.Field_Reservation_Status_id,
                        p_field_Reservation.created_by, p_field_Reservation.created_at);
                    p_field_Reservation.id = nId.Value;
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void EditFieldReservation(Field_Reservation p_field_Reservation)
            {
                try
                {
                    Session.OperationsModel.Field_Reservations_Update(p_field_Reservation.id,
                        p_field_Reservation.Field_id, p_field_Reservation.Client_id,
                        p_field_Reservation.Price, p_field_Reservation.DiscountProcent, p_field_Reservation.Description,
                        p_field_Reservation.ReservationFromDate, p_field_Reservation.ReservationToDate, p_field_Reservation.Field_Reservation_Status_id,
                        p_field_Reservation.updated_by, p_field_Reservation.updated_at);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void DeleteFieldReservation(Field_Reservation p_field_Reservation)
            {
                try
                {
                    Session.OperationsModel.Field_Reservations_Delete(p_field_Reservation.id);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void CancelModifications(Field_Reservation p_field_Reservation)
            {
                if (p_field_Reservation != null)
                    ModelLogic.MergeRows(p_field_Reservation, GetDataById(p_field_Reservation.id));
            }

            public static void UpdateStatuses()
            {
                try
                {
                    Session.OperationsModel.Field_Reservations_UpdateStatusesJob();
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }
        }
        #endregion

        #region Invoices
        public class Invoices
        {
            public static void AddInvoice(Invoice p_Invoice)
            {
                try
                {
                    int? nId = -1;

                    Session.OperationsModel.Invoices_Insert(ref nId,
                        p_Invoice.Client_id, p_Invoice.InvoiceYear, p_Invoice.InvoiceMonth, p_Invoice.InvoiceDay);

                    p_Invoice.id = nId.Value;
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static Invoice GetInvoice(int p_nClientId, int p_nYear, int p_nMonth)
            {
                ISingleResult<Invoice> _query = Session.OperationsModel.Invoices_GetInvoice(p_nClientId, p_nYear, p_nMonth);

                if (_query == null)
                {
                    return null;
                }
                else
                {
                    return _query.FirstOrDefault();
                }

            }
        }
        #endregion

        #region Product Entries
        public class ProductEntriesMethods
        {
            public static void GetData()
            {
                try
                {
                    var _productEntries = from productEntry in Session.OperationsModel.Product_Entries
                                          select productEntry;
                    Session.Product_Entries = ((IListSource)_productEntries).GetList() as BindingList<Product_Entry>;
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

            public static void GetDataByDay(DateTime p_date)
            {
                try
                {
                    var _productEntries = from productEntry in Session.OperationsModel.Product_Entries
                                          where productEntry.ProductEntryDate.Date == p_date.Date
                                          select productEntry;
                    //ModelLogic.MergeLists<Entry>(Session.Entries, _entries.ToList());

                    Session.Product_Entries = ((IListSource)_productEntries).GetList() as BindingList<Product_Entry>;
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

            public static Product_Entry GetDataById(int p_id)
            {
                try
                {
                    var _query = from productEntry in Session.OperationsRefresherModel.Product_Entries
                                 where productEntry.id == p_id
                                 select productEntry;
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

            public static void AddProductEntry(Product_Entry p_product_Entry)
            {
                try
                {
                    int? nId = -1;

                    Session.OperationsModel.Product_Entries_Insert(ref nId,
                        p_product_Entry.Product_id, p_product_Entry.ProductEntryDate,
                        p_product_Entry.EntryPrice, p_product_Entry.EntryQuantity,
                        p_product_Entry.created_by, p_product_Entry.created_at);
                    p_product_Entry.id = nId.Value;
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void EditProductEntry(Product_Entry p_product_Entry)
            {
                try
                {
                    Session.OperationsModel.Product_Entries_Update(p_product_Entry.id,
                        p_product_Entry.Product_id, p_product_Entry.ProductEntryDate,
                        p_product_Entry.EntryPrice, p_product_Entry.EntryQuantity,
                        p_product_Entry.updated_by, p_product_Entry.updated_at);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void DeleteProductEntry(Product_Entry p_product_Entry)
            {
                try
                {
                    Session.OperationsModel.Product_Entries_Delete(p_product_Entry.id);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void CancelModifications(Product_Entry p_product_Entry)
            {
                if (p_product_Entry != null)
                    ModelLogic.MergeRows(p_product_Entry, GetDataById(p_product_Entry.id));
            }
        }
        #endregion

        #region Product Sales
        public class ProductSalesMethods
        {
            public static void GetData()
            {
                try
                {
                    var _productSales = from productSale in Session.OperationsModel.Product_Sales
                                        select productSale;
                    Session.Product_Sales = ((IListSource)_productSales).GetList() as BindingList<Product_Sale>;
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

            public static void GetDataByDay(DateTime p_date)
            {
                try
                {
                    var _productSales = from productSale in Session.OperationsModel.Product_Sales
                                        where productSale.ProductSalesDate.Date == p_date.Date
                                        select productSale;
                    //ModelLogic.MergeLists<Entry>(Session.Entries, _entries.ToList());

                    Session.Product_Sales = ((IListSource)_productSales).GetList() as BindingList<Product_Sale>;
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

            public static Product_Sale GetDataById(int p_id)
            {
                try
                {
                    var _query = from productSale in Session.OperationsRefresherModel.Product_Sales
                                 where productSale.id == p_id
                                 select productSale;
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

            public static void AddProductSale(Product_Sale p_product_Sale)
            {
                try
                {
                    int? nId = -1;

                    Session.OperationsModel.Product_Sales_Insert(ref nId,
                        p_product_Sale.Product_id, p_product_Sale.ProductSalesDate,
                        p_product_Sale.SalesPrice, p_product_Sale.DiscountProcent, p_product_Sale.SalesQuantity,
                        p_product_Sale.Client_id,
                        p_product_Sale.created_by, p_product_Sale.created_at);
                    p_product_Sale.id = nId.Value;
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void EditProductSale(Product_Sale p_product_Sale)
            {
                try
                {
                    Session.OperationsModel.Product_Sales_Update(p_product_Sale.id,
                       p_product_Sale.Product_id, p_product_Sale.ProductSalesDate,
                        p_product_Sale.SalesPrice, p_product_Sale.DiscountProcent, p_product_Sale.SalesQuantity,
                        p_product_Sale.Client_id,
                        p_product_Sale.created_by, p_product_Sale.created_at);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void DeleteProductSale(Product_Sale p_product_Sale)
            {
                try
                {
                    Session.OperationsModel.Product_Entries_Delete(p_product_Sale.id);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }

            public static void CancelModifications(Product_Sale p_product_Sale)
            {
                if (p_product_Sale != null)
                    ModelLogic.MergeRows(p_product_Sale, GetDataById(p_product_Sale.id));
            }
        }
        #endregion

        #region Subscriptions
        public class SubscriptionMethods
        {
            public static void GetData()
            {
                try
                {
                    var _subscriptions = from subscription in Session.OperationsModel.Subscriptions
                                         select subscription;
                    Session.Subscriptions = ((IListSource)_subscriptions).GetList() as BindingList<Subscription>;
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

            public static void GetDataByDay(DateTime p_date)
            {
                try
                {
                    var _subscriptions = from subscription in Session.OperationsModel.Subscriptions
                                         where subscription.SubscriptionStartDate.Date == p_date.Date
                                         select subscription;
                    //ModelLogic.MergeLists<Entry>(Session.Entries, _entries.ToList());

                    Session.Subscriptions = ((IListSource)_subscriptions).GetList() as BindingList<Subscription>;
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

            public static Subscription GetDataById(int p_id)
            {
                try
                {
                    var _query = from subscription in Session.OperationsRefresherModel.Subscriptions
                                 where subscription.id == p_id
                                 select subscription;
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

            public static void CancelModifications(Subscription p_subscription)
            {
                if (p_subscription != null)
                {
                    //refresh Subscription row
                    Session.OperationsModel.Refresh(RefreshMode.OverwriteCurrentValues, p_subscription);
                    //get newly added Subscription Entries
                    var _query_mem = from se in p_subscription.Subscription_Entries
                                     where se.Subscription_id == p_subscription.id && se.id == 0
                                     select se;
                    List<Subscription_Entry> _list_mem = _query_mem.ToList();

                    //detach newly added Subscription Entries
                    for (int i = 0; i < _list_mem.Count; i++)
                    {
                        _list_mem[i].Detach();
                        _list_mem[i] = null;
                    }

                    //get original Subscription Enties from DB
                    var _query_db = from se in Session.OperationsRefresherModel.Subscription_Entries
                                    where se.Subscription_id == p_subscription.id
                                    select se;
                    List<Subscription_Entry> _list_db = _query_db.ToList();

                    for (int i = 0; i < _list_db.Count; i++)
                    {
                        //check if Subscription Entry is still atached to Subscription
                        var _qse = from se in p_subscription.Subscription_Entries
                                   where se.Subscription_id == p_subscription.id && se.id == _list_db[i].id
                                   select se;

                        Subscription_Entry _se = _qse.FirstOrDefault();

                        if (_se == null)
                        {
                            //if Subscription Entry is not atached
                            //locating Subscription Entry
                            Subscription_Entry _se_mem = (from se in Session.OperationsModel.Subscription_Entries
                                                          where se.id == _list_db[i].id
                                                          select se).FirstOrDefault();

                            if (_se_mem != null)
                            {
                                //if Subscription Entry located
                                //set links to Subscription
                                _se_mem.Subscription = p_subscription;
                                _se_mem.Subscription_id = p_subscription.id;
                                Session.OperationsModel.Refresh(RefreshMode.OverwriteCurrentValues, _se_mem);
                            }
                            else
                            {
                                //if Subscription Entry not located
                                //atach row from db
                                Session.OperationsModel.Subscription_Entries.Attach(_list_db[i]);
                            }
                        }
                        else
                        {
                            //if Subscription Entry is atached
                            //merge with row from db
                            ModelLogic.MergeRows(_se, _list_db[i]);
                        }
                    }
                }
            }
        }
        #endregion

        #region Subscription Entries
        public class SubscriptionEntriesMethods
        {
            public static void GetData()
            {
                try
                {
                    var _subscriptionEntries = from subscriptionEntry in Session.OperationsModel.Subscription_Entries
                                               select subscriptionEntry;
                    Session.Subscription_Entries = ((IListSource)_subscriptionEntries).GetList() as BindingList<Subscription_Entry>;
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

            public static Subscription_Entry GetDataById(int p_id)
            {
                try
                {
                    var _query = from subscriptionEntry in Session.OperationsRefresherModel.Subscription_Entries
                                 where subscriptionEntry.id == p_id
                                 select subscriptionEntry;
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
        }
        #endregion
    }
}
