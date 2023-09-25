using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace WebApplication1
{
    public partial class News : System.Web.UI.Page
    {
        public List<Models.News> list;
     
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var dbContext = ApplicationDbContext.Create()) {
                list = dbContext.News.ToList();
            }
        }
    }
}