<?xml version='1.0' encoding='utf-8'?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
	xmlns:a="http://tempuri.org/MonthlyInvoice.xsd" exclude-result-prefixes="a">
  <xsl:output method="html"/>
  <xsl:template match="/">
    <html>
      <head>
        <title>Raport Zilnic</title>
        <style type="text/css">
          <xsl:comment>
            .tableHeader {
            font-size: 10px;
            font-family:Arial, Helvetica, sans-serif;
            font-weight: bold;
            color: #000000;
            background-color: #adc9dc;
            text-align: center;
            vertical-align: middle;
            }

            .tableName {
            font-size: 12px;
            font-family:Arial, Helvetica, sans-serif;
            font-weight: bold;
            color: #CC0000;
            background-color: #ffe4a6;
            text-align: left;
            vertical-align: middle;
            }
            .tableReportHeader {
            font-size: 20px;
            font-family:Arial, Helvetica, sans-serif;
            font-weight: bold;
            color: #CC0000;
            text-align: center;
            vertical-align: middle;
            }
            .underMinimumRow {
            font-size: 10px;
            font-family:Arial, Helvetica, sans-serif;
            color: #000000;
            background-color: #f8f8f8;
            text-align: center;
            }

            .underMinimumRowLeft {
            font-size: 10px;
            font-family:Arial, Helvetica, sans-serif;
            color: #000000;
            background-color: #f8f8f8;
            text-align: left;
            }
            .underMinimumRowRight {
            font-size: 10px;
            font-family:Arial, Helvetica, sans-serif;
            color: #000000;
            background-color: #f8f8f8;
            text-align: right;
            }
            .organizationDetails {
            font-size: 10px;
            font-family:Arial, Helvetica, sans-serif;
            color: #000000;
            text-align: left;
            }
            .footerDetails {
            font-size: 10px;
            font-family:Arial, Helvetica, sans-serif;
            color: #000000;
            text-align: left;
            vertical-align: top;
            }
          </xsl:comment>
        </style>
      </head>
      <body>
        <xsl:variable name="Format" select="'0.00'"></xsl:variable>
        <xsl:variable name="FormatNoDecimal" select="'0.##'"></xsl:variable>
        <table  border="0" align="left" cellpadding="5" cellspacing="0" borderColor="#000000" width="100%">
          <tr>
            <td align ="center">
              <table border="1" align="center" cellpadding="5" cellspacing="0" borderColor="#000000" width="100%">
                <tr>
                  <td width ="30%" class="tableReportHeader">
                    Furnizor
                  </td>
                  <td width ="40%" rowspan ="8" align ="center" valign="center">
                    <h2>Factura</h2>
                    <br />
                    Numarul : <xsl:value-of select="a:MonthlyInvoice/a:Parameters/a:InvoiceNumber"></xsl:value-of>
                    <br />
                    Data : <xsl:value-of select="a:MonthlyInvoice/a:Parameters/a:InvoiceDate"></xsl:value-of>
                    <br />
                    TVA :19%
                  </td>
                  <td width ="30%" class="tableReportHeader">
                    Beneficiar
                  </td>
                </tr>
                <tr class="organizationDetails">
                  <td width ="30%">
                    <b>Denumire :</b><xsl:value-of select="a:MonthlyInvoice/a:Organization_Details/a:OrganizationName"></xsl:value-of>
                  </td>
                  <td width ="30%">
                    <b>Denumire :</b><xsl:value-of select="a:MonthlyInvoice/a:Clients/a:ClientName"></xsl:value-of>
                  </td>
                </tr>
                <tr class="organizationDetails">
                  <td width ="30%">
                    <b>Cod Fiscal :</b><xsl:value-of select="a:MonthlyInvoice/a:Organization_Details/a:FiscalCode"></xsl:value-of>
                  </td>
                  <td width ="30%">
                    <b>Cod Fiscal :</b><xsl:value-of select="a:MonthlyInvoice/a:Clients/a:FiscalCode"></xsl:value-of>
                  </td>
                </tr>
                <tr class="organizationDetails">
                  <td width ="30%">
                    <b>Nr. Registrul Comertului :</b><xsl:value-of select="a:MonthlyInvoice/a:Organization_Details/a:TradeCode"></xsl:value-of>
                  </td>
                  <td width ="30%">
                    <b>Nr. Registrul Comertului :</b><xsl:value-of select="a:MonthlyInvoice/a:Clients/a:TradeCode"></xsl:value-of>
                  </td>
                </tr>
                <tr class="organizationDetails">
                  <td width ="30%">
                    <b>Adresa :</b><xsl:value-of select="a:MonthlyInvoice/a:Organization_Details/a:Address"></xsl:value-of>
                  </td>
                  <td width ="30%">
                    <b>Adresa :</b><xsl:value-of select="a:MonthlyInvoice/a:Clients/a:Address"></xsl:value-of>
                  </td>
                </tr>
                <tr class="organizationDetails">
                  <td width ="30%">
                    <b>Telefon :</b><xsl:value-of select="a:MonthlyInvoice/a:Organization_Details/a:Phone"></xsl:value-of>
                  </td>
                  <td width ="30%">
                    <b>Telefon :</b><xsl:value-of select="a:MonthlyInvoice/a:Clients/a:Phone"></xsl:value-of>
                  </td>
                </tr>
                <tr class="organizationDetails">
                  <td width ="30%">
                    <b>Banca :</b><xsl:value-of select="a:MonthlyInvoice/a:Organization_Details/a:Bank"></xsl:value-of>
                  </td>
                  <td width ="30%">
                    <b>Banca :</b><xsl:value-of select="a:MonthlyInvoice/a:Clients/a:Bank"></xsl:value-of>
                  </td>
                </tr>
                <tr class="organizationDetails">
                  <td width ="30%">
                    <b>Cont Bancar :</b><xsl:value-of select="a:MonthlyInvoice/a:Organization_Details/a:BankAccount"></xsl:value-of>
                  </td>
                  <td width ="30%">
                    <b>Cont Bancar :</b><xsl:value-of select="a:MonthlyInvoice/a:Clients/a:BankAccount"></xsl:value-of>
                  </td>
                </tr>
              </table>
            </td>
          </tr>
          <tr>
            <td align="center">
              <xsl:choose>
                <xsl:when test="count(a:MonthlyInvoice/a:Report_MonthlyInvoiceForClient/a:IncomeType) > 0">
                  <table borderColor="#000000" width="100%" border="1" cellspacing="0" cellpadding="5" >
                    <tr>
                      <th class="tableHeader" nowrap='true'>Nr. Crt.</th>
                      <th class="tableHeader" nowrap='true'>Produs</th>
                      <th class="tableHeader" nowrap='true'>Cantitate</th>
                      <th class="tableHeader" nowrap='true'>Pret</th>
                      <th class="tableHeader" nowrap='true'>TVA</th>
                      <th class="tableHeader" nowrap='true'>Pret Cu TVA</th>
                    </tr>
                    <xsl:for-each select="a:MonthlyInvoice/a:Report_MonthlyInvoiceForClient">
                      <tr>
                        <td class="underMinimumRowLeft" nowrap='true'>
                          <xsl:value-of select="position()"></xsl:value-of>
                        </td>
                        <td class="underMinimumRowLeft" nowrap='true'>
                          <xsl:value-of select="a:IncomeType"></xsl:value-of>
                        </td>
                        <td class="underMinimumRowLeft" nowrap='true'>
                          1
                        </td>
                        <td class="underMinimumRowRight" nowrap='true'>
                          <xsl:value-of select="format-number((a:Income div 1.19),$Format)"></xsl:value-of>
                        </td>
                        <td class="underMinimumRowRight" nowrap='true'>
                          <xsl:value-of select="format-number(a:Income div 1.19 * 0.19,$Format)"></xsl:value-of>
                        </td>
                        <td class="underMinimumRowRight" nowrap='true'>
                          <xsl:value-of select="format-number(a:Income,$Format)"></xsl:value-of>
                        </td>
                      </tr>
                    </xsl:for-each>
                  </table>
                </xsl:when>
              </xsl:choose>
            </td>
          </tr>
          <tr>
            <td>
              <table border="1" align="center" cellpadding="5" cellspacing="0" borderColor="#000000" width="100%">
                <tr>
                  <td class="footerDetails" align ="center" rowspan ="2">
                    Semnatura si stampila
                  </td>
                  <td class="footerDetails" align ="center">
                    Delegat : <xsl:value-of select="a:MonthlyInvoice/a:Parameters/a:LoggedUser"></xsl:value-of>
                  </td>
                  <td  align ="center">
                    <b>Total :</b><xsl:value-of select="format-number((sum(a:MonthlyInvoice/a:Report_MonthlyInvoiceForClient/a:Income) div 1.19),$Format)"></xsl:value-of>
                  </td>
                  <td  align ="center">
                    <b>TVA :</b><xsl:value-of select="format-number((sum(a:MonthlyInvoice/a:Report_MonthlyInvoiceForClient/a:Income) div 1.19 * 0.19),$Format)"></xsl:value-of>
                  </td>
                </tr>
                <tr>
                  <td class="footerDetails" align ="center">
                    Semnatura delegat
                  </td>
                  <td colspan="2" align ="center" style="vertical-align:center;">
                    <h3>
                      <xsl:value-of select="format-number(sum(a:MonthlyInvoice/a:Report_MonthlyInvoiceForClient/a:Income),$Format)"></xsl:value-of>
                    </h3>
                  </td>
                </tr>
              </table>
            </td>
          </tr>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>

