using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// 引用WCF命名空间
using WCFClient.WCFService;

namespace WCFClient
{
    public partial class WCFTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick(object sender, EventArgs e)
        {         
            WCFService.UserClient user = new UserClient();
            Response.Write(user.ShowName(this.txtName.Text));
        }
    }
}