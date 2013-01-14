using System;
using System.Globalization;
using System.Data.SqlClient;

using DAL.Models.Nomenclators;
using DAL.Models.Operations;
using DAL.Reports.MonthlyInvoice.MonthlyInvoiceTableAdapters;

namespace DAL.Reports.MonthlyInvoice
{
    public partial class MonthlyInvoice
    {
        public void PrepareReportData(string p_sUserName, Invoice p_invoice, Client p_client, Organization_Detail p_organizationDetails, 
            int p_nYear, int p_nMonth)
        {
            this.Report_MonthlyInvoiceForClient.GetDataForReport(p_client.id, p_nYear, p_nMonth);
            this.Parameters.GetDataForReport(p_sUserName, p_invoice);
            this.Clients.GetDataForReport(p_client);
            this.Organization_Details.GetDataForReport(p_organizationDetails);
        }

        partial class ParametersDataTable
        {
            internal void GetDataForReport(string p_sUserName, Invoice p_invoice)
            {
                this.Rows.Clear();
                ParametersRow _newRow = this.NewParametersRow();

                _newRow.LoggedUser = p_sUserName;
                _newRow.InvoiceNumber = p_invoice.id.ToString();
                _newRow.InvoiceDate = new DateTime(p_invoice.InvoiceYear, p_invoice.InvoiceMonth, p_invoice.InvoiceDay).ToString("dd MMM yyyy", new CultureInfo("ro-Ro"));

                this.AddParametersRow(_newRow);
            }
        }
    
        partial class ClientsDataTable
        {
            internal void GetDataForReport(Client p_Client)
            {
                this.Rows.Clear();
                ClientsRow _newRow = this.NewClientsRow();

                _newRow.ClientName = p_Client.ClientName;
                _newRow.FiscalCode = p_Client.FiscalCode;
                _newRow.TradeCode = p_Client.TradeCode;
                _newRow.Address = p_Client.Address;
                _newRow.Phone = p_Client.Phone;
                _newRow.Bank = p_Client.Bank;
                _newRow.BankAccount = p_Client.BankAccount;

                this.AddClientsRow(_newRow);
            }
        }
    
        partial class Organization_DetailsDataTable
        {
            internal void GetDataForReport(Organization_Detail p_organizationDetails)
            {
                this.Rows.Clear();
                Organization_DetailsRow _newRow = this.NewOrganization_DetailsRow();

                _newRow.OrganizationName = p_organizationDetails.OrganizationName;
                _newRow.FiscalCode = p_organizationDetails.FiscalCode;
                _newRow.TradeCode = p_organizationDetails.TradeCode;
                _newRow.Address = p_organizationDetails.Address;
                _newRow.Phone = p_organizationDetails.Phone;
                _newRow.Bank = p_organizationDetails.Bank;
                _newRow.BankAccount = p_organizationDetails.BankAccount;

                this.AddOrganization_DetailsRow(_newRow);
            }
        }

        partial class Report_MonthlyInvoiceForClientDataTable
        {
            private Report_MonthlyInvoiceForClientTableAdapter _tableAdapter = null;

            private Report_MonthlyInvoiceForClientTableAdapter TableAdapter
            {
                get
                {
                    if (_tableAdapter == null)
                        _tableAdapter = new Report_MonthlyInvoiceForClientTableAdapter();
                    return _tableAdapter;
                }
            }

            internal void GetDataForReport(int p_nClientId, int p_nYear, int p_nMonth)
            {
                try
                {
                    this.TableAdapter.ClearBeforeFill = true;
                    this.TableAdapter.Fill(this, p_nClientId, p_nYear, p_nMonth);
                }
                catch (SqlException se)
                {
                    throw se;
                }
            }
        }
    }
}
