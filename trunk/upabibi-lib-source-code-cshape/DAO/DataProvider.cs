/*
 * Created by SharpDevelop.
 * User: Hoang Anh Tran
 * Date: 6/28/2009
 * Time: 6:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;

namespace DAO
{
	/// <summary>
	/// Description of DataProvider.
	/// </summary>
	public class DataProvider
	{
		public static OleDbConnection ConnectionData()
		{
			string strCon = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = upabibi-lib-database.mdb";
			OleDbConnection cn = new OleDbConnection(strCon);
			cn.Open();
			return cn;
		}
	}
}
