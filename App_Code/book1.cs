using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for book
/// </summary>
public class book1
{
    SqlDataAdapter adap = new SqlDataAdapter();
    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    DataSet d = new DataSet();
	
    public book1()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public string connectionstring()
    {
        string str= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\Desktop\WebSite36\App_Data\hotel.mdf;Integrated Security=True;Connect Timeout=30";
        return (str);
    }
     
     

}