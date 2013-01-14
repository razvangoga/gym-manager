<?xml version='1.0' encoding='utf-8'?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
	xmlns:a="http://tempuri.org/DailyWarnings.xsd" exclude-result-prefixes="a">
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
          </xsl:comment>
        </style>
      </head>
      <body>
        <xsl:variable name="Format" select="'0.00'"></xsl:variable>
        <xsl:variable name="FormatNoDecimal" select="'0.##'"></xsl:variable>
        <table  border="1" align="left" cellpadding="5" cellspacing="0" borderColor="#000000" width="100%">
          <tr>
            <td>
              <table width="100%" border="0" cellspacing="10" cellpadding="0" align="center">
                <tr>
                  <th class="tableReportHeader">
                    <xsl:value-of select="a:DailyWarnings/a:Parameters/a:ReportName"></xsl:value-of>
                    <xsl:text disable-output-escaping="yes">&amp;nbsp;</xsl:text>-<xsl:text disable-output-escaping="yes">&amp;nbsp;</xsl:text>
                    <xsl:value-of  select="a:DailyWarnings/a:Parameters/a:CurrentDate"></xsl:value-of>
                  </th>
                </tr>
                <tr>
                  <td align="center">
                    <xsl:choose>
                      <xsl:when test="count(a:DailyWarnings/a:Report_DailySubscriptionWarnings/a:Number) != 0">
                        <table borderColor="#000000" width="100%" border="1" cellspacing="0" cellpadding="5" >
                          <tr>
                            <th class="tableName" colspan="8">
                              Abonamente inactive incepand cu ziua de azi
                            </th>
                          </tr>
                          <tr>
                            <th class="tableHeader" nowrap='true'>Nr. Crt.</th>
                            <th class="tableHeader" nowrap='true'>Explicatie</th>
                            <th class="tableHeader" nowrap='true'>Tip Abonament</th>
                            <th class="tableHeader" nowrap='true'>Numar</th>
                            <th class="tableHeader" nowrap='true'>Data Expirare</th>
                            <th class="tableHeader" nowrap='true'>Intrari Nelimitate</th>
                            <th class="tableHeader" nowrap='true'>Numar Intrari</th>
                            <th class="tableHeader" nowrap='true'>Intrari Ramase</th>
                          </tr>
                          <xsl:for-each select="a:DailyWarnings/a:Report_DailySubscriptionWarnings">
                            <tr>
                              <td class="underMinimumRowLeft" nowrap='true'>
                                <xsl:value-of select="position()"></xsl:value-of>
                              </td>
                              <td class="underMinimumRowLeft" nowrap='true'>
                                <xsl:value-of select="a:Details"></xsl:value-of>
                              </td>
                              <td class="underMinimumRowLeft" nowrap='true'>
                                <xsl:value-of select="a:SubscriptionType"></xsl:value-of>
                              </td>
                              <td class="underMinimumRow" nowrap='true'>
                                <xsl:value-of select="a:Number"></xsl:value-of>
                              </td>
                              <td class="underMinimumRow" nowrap='true'>
                                <xsl:value-of select="a:Date"></xsl:value-of>
                              </td>
                              <td class="underMinimumRow" nowrap='true'>
                                <xsl:value-of select="a:HasUnilimitedEntries"></xsl:value-of>
                              </td>
                              <td class="underMinimumRowRight" nowrap='true'>
                                <xsl:value-of select="format-number(a:EntryNumber,$FormatNoDecimal)"></xsl:value-of>
                              </td>
                              <td class="underMinimumRowRight" nowrap='true'>
                                <xsl:value-of select="format-number(a:RemainingEntries,$FormatNoDecimal)"></xsl:value-of>
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
                    <p></p>
                  </td>
                </tr>
                <tr>
                  <td align="center">
                    <xsl:choose>
                      <xsl:when test="count(a:DailyWarnings/a:ProductsWithNoStock/a:ProductName) != 0">
                        <table borderColor="#000000" width="100%" border="1" cellspacing="0" cellpadding="5" >
                          <tr>
                            <th class="tableName" colspan="5">
                              Produse Vandute cu Stoc Curent 0
                            </th>
                          </tr>
                          <tr>
                            <th class="tableHeader" nowrap='true'>Nr. Crt.</th>
                            <th class="tableHeader" nowrap='true'>Denumire Produs</th>
                            <th class="tableHeader" nowrap='true'>Stoc</th>
                          </tr>
                          <xsl:for-each select="a:DailyWarnings/a:ProductsWithNoStock">
                            <tr>
                              <td class="underMinimumRowLeft" nowrap='true'>
                                <xsl:value-of select="position()"></xsl:value-of>
                              </td>
                              <td class="underMinimumRowLeft" nowrap='true'>
                                <xsl:value-of select="a:ProductName"></xsl:value-of>
                              </td>
                              <td class="underMinimumRowRight" nowrap='true'>
                                <xsl:value-of select="format-number(a:Stock,$Format)"></xsl:value-of>
                              </td>
                            </tr>
                          </xsl:for-each>
                        </table>
                      </xsl:when>
                    </xsl:choose>
                  </td>
                </tr>
                <tr>
                  <td align="right">
                    <b>
                      Autentificat ca : <xsl:value-of select="a:DailyWarnings/a:Parameters/a:LoggedUser"></xsl:value-of>
                    </b>
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
