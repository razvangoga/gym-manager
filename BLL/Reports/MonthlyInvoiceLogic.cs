using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL.Logic;
using DAL.Models.Nomenclators;
using DAL.Models.Operations;

namespace BLL.Reports
{
    public class MonthlyInvoiceLogic
    {
        public static Invoice CheckIfInvoiceExists(Client p_client, DateTime p_invoiceDate)
        {
            Invoice _invoice = OperationsModelMethods.Invoices.GetInvoice(p_client.id,
                p_invoiceDate.Year, p_invoiceDate.Month);

            if (_invoice != null)
            {
                return _invoice;
            }
            else
            {
                Invoice _newInvoice = new Invoice();

                _newInvoice.Client_id = p_client.id;
                _newInvoice.InvoiceYear = p_invoiceDate.Year;
                _newInvoice.InvoiceMonth = p_invoiceDate.Month;
                _newInvoice.InvoiceDay = p_invoiceDate.Day;

                OperationsModelMethods.Invoices.AddInvoice(_newInvoice);

                return _newInvoice;
            }
        }
    }
}
