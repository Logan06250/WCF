using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           

            HelloService.HelloServiceClient client = new HelloService.HelloServiceClient("BasicHttpBinding_IHelloService");

            //msg.data()
            //Label1.Text = client.dispatching(msg);

            int value1;
            int value2;

            if (int.TryParse(TextBox1.Text, out value1))
            {
                if (int.TryParse(TextBox2.Text, out value2))
                {
                    Label1.Text = client.dispatching("add", "loganToken", value1, value2).ToString();
                }
                else
                {
                    //parsing failed. 
                }
            }
            else
            {
                //parsing failed. 
            }

            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            HelloService.HelloServiceClient client = new HelloService.HelloServiceClient("BasicHttpBinding_IHelloService");

            int value1;
            int value2;

            if (int.TryParse(TextBox1.Text, out value1))
            {
                if (int.TryParse(TextBox2.Text, out value2))
                {
                    Label1.Text = client.dispatching("sous", "loganToken", value1, value2).ToString();
                }
                else
                {
                    //parsing failed. 
                }
            }
            else
            {
                //parsing failed. 
            }

        }
    }
}