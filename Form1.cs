using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ChromiumWebBrowser chrome1;
        ChromiumWebBrowser chrome2;
        ChromiumWebBrowser chrome3;
        Panel Panel1;
        Panel Panel2;
        Panel Panel3;
        void _1366x768_mod2()
        {


            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.section-title').hide();");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.section-title').hide();");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.section-title').hide();");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('footer').hide();");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('footer').hide();");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('footer').hide();");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('header').hide();");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('header').hide();");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('header').hide();");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('position','relative')");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('position','static')");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('position','relative')");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('padding','0 0 20px 0')");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('padding','0 0 20px 0')");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('padding','0 0 20px 0')");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.banner-content').css('margin-top','0')");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.banner-content').css('margin-top','0')");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.banner-content').css('margin-top','0')");


            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.col-lg-10').css('margin','0')");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.col-lg-10').css('margin','0')");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.col-lg-10').css('margin','0')");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.document-area').hide();");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.document-area').hide();");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.document-area').hide();");

            string script4 = "document.getElementsByClassName('row')[0].style.display='none';";

            chrome1.ExecuteScriptAsyncWhenPageLoaded(script4);
            chrome2.ExecuteScriptAsyncWhenPageLoaded(script4);
            chrome3.ExecuteScriptAsyncWhenPageLoaded(script4);


        }

        void _1366x768_mod3()
        {


            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.section-title').hide();");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.section-title').hide();");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.section-title').hide();");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('footer').hide();");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('footer').hide();");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('footer').hide();");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('header').hide();");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('header').hide();");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('header').hide();");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('position','static')");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('position','static')");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('position','static')");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('padding','0 0 20px 0')");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('padding','0 0 20px 0')");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('padding','0 0 20px 0')");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.banner-content').css('margin-top','0')");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.banner-content').css('margin-top','0')");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.banner-content').css('margin-top','0')");


            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.col-lg-10').css('margin','0')");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.col-lg-10').css('margin','0')");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.col-lg-10').css('margin','0')");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.document-area').hide();");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.document-area').hide();");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.document-area').hide();");

            string script4 = "document.getElementsByClassName('row')[0].style.display='none';";

            chrome1.ExecuteScriptAsyncWhenPageLoaded(script4);
            chrome2.ExecuteScriptAsyncWhenPageLoaded(script4);
            chrome3.ExecuteScriptAsyncWhenPageLoaded(script4);


            chrome1.ExecuteScriptAsyncWhenPageLoaded("setInterval(()=>{\r\n    for (let element of document.querySelectorAll(\"table p\"))\r\n    {\r\n        element.style.paddingTop = '0px'; \r\n        element.style.paddingBottom='0px';\r\n        element.style.marginBottom='0px';\r\n        element.style.marginBottom='0px';\r\n    element.style.height='20px';\r\n    element.style.fontSize = \"14px\";\r\n    }\r\n},1)");
            //  chrome2.ExecuteScriptAsyncWhenPageLoaded("setInterval(()=>{\r\n    for (let element of document.querySelectorAll(\"table *\"))\r\n    {\r\n        element.style.paddingTop = '0px'; \r\n        element.style.paddingBottom='0px';\r\n        element.style.marginBottom='0px';\r\n        element.style.marginBottom='0px';\r\n        element.style.fontSize = \"14px\";\r\n    }\r\n},1)");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("setInterval(()=>{\r\n    for (let element of document.querySelectorAll(\"table *\"))\r\n    {\r\n        element.style.paddingTop = '0px'; \r\n        element.style.paddingBottom='0px';\r\n        element.style.marginBottom='0px';\r\n        element.style.marginBottom='0px';\r\n   element.style.height='18px';\r\n      element.style.fontSize = \"14px\";\r\n    }\r\n},1)");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);

            chrome1 = new ChromiumWebBrowser(form2.url1);
            chrome2 = new ChromiumWebBrowser(form2.url2);
            chrome3 = new ChromiumWebBrowser(form2.url3);

            int genislik = Screen.AllScreens[form2.ekran].Bounds.Width;
            int yukseklik = Screen.AllScreens[form2.ekran].Bounds.Height;

            if (form2.mod == 3)
            {
                if (genislik > 1600) _1920x1080_mod3();
                else _1366x768_mod3();
            }

            if (form2.mod == 2)
            {
                if (genislik > 1600) _1920x1080_mod2();
                else _1366x768_mod2();
            }
       

            Panel1 = new Panel();
            Panel2 = new Panel();
            Panel3 = new Panel();

            Panel1.Controls.Add(chrome1);
            Panel2.Controls.Add(chrome2);
            Panel3.Controls.Add(chrome3);

            chrome1.Dock = DockStyle.Fill;
            chrome2.Dock = DockStyle.Fill;
            chrome3.Dock = DockStyle.Fill;

            Panel1.Width = this.Width/3;
            Panel2.Width = this.Width/3;
            Panel3.Width = this.Width/3;

            Panel1.Height = this.Height;
            Panel2.Height = this.Height;
            Panel3.Height = this.Height;

            Panel1.Location = new Point(0, 0);
            Panel2.Location = new Point(Panel1.Width, 0);
            Panel3.Location = new Point(Panel1.Width+Panel2.Width, 0);

            Panel1.BackColor = Color.Red;
            Panel2.BackColor = Color.Green;
            Panel3.BackColor = Color.Blue;

            this.Controls.Add(Panel1);
            this.Controls.Add(Panel2);
            this.Controls.Add(Panel3);
        }

        private void _1920x1080_mod3()
        {
            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.section-title').hide();");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.section-title').hide();");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.section-title').hide();");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('footer').hide();");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('footer').hide();");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('footer').hide();");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('header').hide();");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('header').hide();");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('header').hide();");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('position','static')");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('position','static')");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('position','static')");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('padding','0 0 20px 0')");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('padding','33% 0 20px 0')");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('padding','0 0 20px 0')");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.banner-content').css('margin-top','0')");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.banner-content').css('margin-top','0')");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.banner-content').css('margin-top','0')");


            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.col-lg-10').css('margin','0')");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.col-lg-10').css('margin','0')");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.col-lg-10').css('margin','0')");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.document-area').hide();");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.document-area').hide();");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.document-area').hide();");

            string script4 = "document.getElementsByClassName('row')[0].style.display='none';";

            chrome1.ExecuteScriptAsyncWhenPageLoaded(script4);
            chrome2.ExecuteScriptAsyncWhenPageLoaded(script4);
            chrome3.ExecuteScriptAsyncWhenPageLoaded(script4);


            chrome1.ExecuteScriptAsyncWhenPageLoaded("setInterval(()=>{\r\n    for (let element of document.querySelectorAll(\"table p\"))\r\n    {\r\n        element.style.paddingTop = '0px'; \r\n        element.style.paddingBottom='0px';\r\n        element.style.marginBottom='0px';\r\n        element.style.marginBottom='0px';\r\n        element.style.fontSize = \"20px\";\r\n    }\r\n},1)");
            //  chrome2.ExecuteScriptAsyncWhenPageLoaded("setInterval(()=>{\r\n    for (let element of document.querySelectorAll(\"table *\"))\r\n    {\r\n        element.style.paddingTop = '0px'; \r\n        element.style.paddingBottom='0px';\r\n        element.style.marginBottom='0px';\r\n        element.style.marginBottom='0px';\r\n        element.style.fontSize = \"14px\";\r\n    }\r\n},1)");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("setInterval(()=>{\r\n    for (let element of document.querySelectorAll(\"table *\"))\r\n    {\r\n        element.style.paddingTop = '0px'; \r\n        element.style.paddingBottom='0px';\r\n        element.style.marginBottom='0px';\r\n        element.style.marginBottom='0px';\r\n        element.style.fontSize = \"16px\";\r\n    }\r\n},1)");

        }

        private void _1920x1080_mod2()
        {
            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.section-title').hide();");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.section-title').hide();");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.section-title').hide();");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('footer').hide();");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('footer').hide();");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('footer').hide();");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('header').hide();");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('header').hide();");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('header').hide();");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('position','static')");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('position','static')");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('position','relative')");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('padding','0 0 13px 0')");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('padding','33% 0 20px 0')");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.team-area').css('padding','0 0 20px 0')");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.banner-content').css('margin-top','0')");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.banner-content').css('margin-top','0')");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.banner-content').css('margin-top','0')");


            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.col-lg-10').css('margin','0')");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.col-lg-10').css('margin','0')");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.col-lg-10').css('margin','0')");

            chrome1.ExecuteScriptAsyncWhenPageLoaded("$('.document-area').hide();");
            chrome2.ExecuteScriptAsyncWhenPageLoaded("$('.document-area').hide();");
            chrome3.ExecuteScriptAsyncWhenPageLoaded("$('.document-area').hide();");

            string script4 = "document.getElementsByClassName('row')[0].style.display='none';";

            chrome1.ExecuteScriptAsyncWhenPageLoaded(script4);
            chrome2.ExecuteScriptAsyncWhenPageLoaded(script4);
            chrome3.ExecuteScriptAsyncWhenPageLoaded(script4);


        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            Panel1.Width = this.Width/3;
            Panel2.Width = this.Width/3;
            Panel3.Width = this.Width/3;

            Panel1.Height = this.Height;
            Panel2.Height = this.Height;
            Panel3.Height = this.Height;

            Panel1.Location = new Point(0, 0);
            Panel2.Location = new Point(Panel1.Width, 0);
            Panel3.Location = new Point(Panel1.Width+Panel2.Width, 0);
        }
    }
}
