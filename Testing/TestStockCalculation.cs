using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

using DAL;
using MySql.Data.MySqlClient;


namespace Testing
{
    public class TestStockCalculation
    {
        public TimeSpan CalculateStock()
        {
            DateTime dtBegin = DateTime.Now;
            DateTime dtEnd;

            int nCrrProductId = 0;
            double nStoc = 0;
            double nLastMedimPrice = 0;
            double nMediumPrice = 0;

            MySqlConnection cnn = new MySqlConnection("server=localhost;user id=root;password=rootmysql;persist security info=True;database=gemini");
            MySqlConnection ccnn = new MySqlConnection("server=localhost;user id=root;password=rootmysql;persist security info=True;database=gemini");
            MySqlConnection cinn = new MySqlConnection("server=localhost;user id=root;password=rootmysql;persist security info=True;database=gemini");
            MySqlCommand cmd;
            MySqlCommand ccmd;
            MySqlCommand cicmd;
            MySqlDataReader rdr = null;
            MySqlDataReader cRdr = null;
            string sSQL = string.Empty;
            string scSQL = string.Empty;
            string siSQL = string.Empty;
            string smSQL = string.Empty;

            cnn.Open();
            ccnn.Open();
            cinn.Open();

            sSQL = @"select dh_id, dh_document_date, dl_pr_id, dl_qty, dl_price, dt_stock_influence, dt_document_id
			from document_headers
				inner join document_lines on dh_id = dl_dh_id
				inner join document_types on dt_document_id = dl_dt_id
			where dt_document_id not in ( 3, 4)
			 and dl_recepy_item_type <> 2	
			order by dl_pr_id, dh_document_date, dh_id";

            scSQL = @"select count(pr_id) as Cnt
							from report_descarcare_gestiune_mediu_negative_stoc
							where pr_id = {0}";

            siSQL = @"insert into report_descarcare_gestiune_mediu_negative_stoc 
									(pr_id, negative_stock_date, stock, wh_id)
									values
									({0}, '{1}', {2}, -1)";

            smSQL = @"insert into report_descarcare_gestiune_mediu_prices 
									(DocumentHeaderId, DocumentDate, ProductId, Price, WarehouseId)
									values
									({0}, '{1}', {2}, ifnull({3},0), -1);";

            cmd = new MySqlCommand(sSQL, cnn);

            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                if (nCrrProductId == 0 && nCrrProductId != Convert.ToInt32(rdr["dl_pr_id"]))
                {
                    nCrrProductId = Convert.ToInt32(rdr["dl_pr_id"]);
                    nLastMedimPrice = 0;
                    nStoc = 0;
                }

                ccmd = new MySqlCommand(string.Format(scSQL, rdr["dl_pr_id"]), ccnn);
                cRdr = ccmd.ExecuteReader();

                cRdr.Read();

                if (Convert.ToInt32(cRdr["Cnt"]) == 0)
                {
                    if (Convert.ToInt32(rdr["dt_stock_influence"]) == 1 || Convert.ToInt32(rdr["dt_document_id"]) == 12)
                    {
                        if (nStoc >= 0)
                        {
                            nMediumPrice = Math.Round(
                                (nStoc * nLastMedimPrice + 
                                (Convert.ToInt32(rdr["dt_stock_influence"]) + Convert.ToDouble(rdr["dl_qty"])) * Convert.ToDouble(rdr["dl_price"])) /
                                (nStoc + (Convert.ToInt32(rdr["dt_stock_influence"]) + Convert.ToDouble(rdr["dl_qty"]))), 2);

                            nLastMedimPrice = nMediumPrice;
                            nStoc += Convert.ToDouble(rdr["dl_qty"]);

                            cicmd = new MySqlCommand(
                                string.Format(smSQL,
                                    rdr["dh_id"], Convert.ToDateTime(rdr["dh_document_date"]).ToString("yyyy-MM-dd"), rdr["dl_pr_id"], nMediumPrice),
                                    cinn);
                            cicmd.ExecuteNonQuery();
                        }
                        else
                        {
                            cicmd = new MySqlCommand(
                                string.Format(siSQL,
                                rdr["dl_pr_id"], Convert.ToDateTime(rdr["dh_document_date"]).ToString("yyyy-MM-dd"), nStoc),
                                cinn);

                            cicmd.ExecuteNonQuery();
                        }
                    }

                    if (Convert.ToInt32(rdr["dt_stock_influence"]) == -1 && Convert.ToInt32(rdr["dt_document_id"]) != 12)
                    {
                        nStoc -= Convert.ToDouble(rdr["dl_qty"]);

                        if (nStoc < 0)
                        {
                            cicmd = new MySqlCommand(
                                string.Format(siSQL,
                                rdr["dl_pr_id"], Convert.ToDateTime(rdr["dh_document_date"]).ToString("yyyy-MM-dd"), nStoc),
                                cinn);

                            cicmd.ExecuteNonQuery();
                        }
                    }
                }

                cRdr.Close();

            }

            cnn.Close();
            ccnn.Close();
            cinn.Close();

            dtEnd = DateTime.Now;

            return dtEnd.Subtract(dtBegin);
        }
    }
}