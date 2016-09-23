using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Category : System.Web.UI.UserControl
{
    sqlPublic sql;
    protected void Page_Load(object sender, EventArgs e)
    {

        
        //Chuoi ket noi
        sqlPublic.ConnectionString = "Data Source=GIAMSAT2;Initial Catalog=FamilyStore;User ID=sa; Password=runtoyou";
        //Truy van
        SqlCommand sqlcom = new SqlCommand("select * from Category");
        drlCategory.DataSource = sqlPublic.GetData(sqlcom);
        drlCategory.DataValueField = "ID";
        drlCategory.DataTextField = "LoaiHangHoa";
        drlCategory.DataBind();
    }
}