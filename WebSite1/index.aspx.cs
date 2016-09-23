using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Session
        //Session["taikhoan"] = "thuxeko";

        //DataTable dt = new DataTable();
        //dt.Columns.Add("Cot 1");
        //dt.Columns.Add("Cot 2");
        //dt.Columns.Add("Cot 3");
        //dt.Columns.Add("Cot 4");
        //dt.Columns.Add("Cot 5");

        //Session["dttable"] = dt.Columns.Count.ToString();

        //Response.Write(Session["dttable"].ToString());

        //Cookie
        //HttpCookie cookies = new HttpCookie("name");
        //cookies.Value = "thuxeko";
        //cookies.Expires = DateTime.Now.AddDays(1);
        //Response.Cookies.Add(cookies);

        //string s = cookies.Value;
        //Response.Write(s);

        //Usercontrol
        //string s = Request.QueryString["id"];
        //switch (s)
        //{
        //    case  "1":
        //        plLoad.Controls.Add(LoadControl("Tintuc.ascx"));
        //        break;
        //    case "2":
        //        plLoad.Controls.Add(LoadControl("Sanpham.ascx"));
        //        break;
        //    default:
        //        Response.Write("Lỗi tí :D");
        //        break;
        //}

        plLoad.Controls.Add(LoadControl("Category.ascx"));

    }
}