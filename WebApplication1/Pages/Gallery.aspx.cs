using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace WebApplication1
{
    public partial class Gallery : System.Web.UI.Page
    {
        public String[] files;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[] filePaths = Directory.GetFiles(Server.MapPath("~/Pages/content/"));
                List<ListItem> files = new List<ListItem>();
                foreach (string filePath in filePaths)
                {
                    string fileName = Path.GetFileName(filePath);
                    if(fileName.EndsWith(".jpg"))
                        files.Add(new ListItem(fileName, "~/Pages/content/" + fileName));
                }
                GridView1.DataSource = files;
                GridView1.DataBind();
            }
        }
    }
}