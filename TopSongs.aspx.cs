using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class TopsSongs : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void songclick(object sender, EventArgs e)
    {
        HtmlButton b= (HtmlButton)sender;
        string bid = b.ID;
        switch (bid)
        {
            case "s10":
                FindVideo2.Src = "https://www.youtube.com/embed/6PRfDJQY_Y8?autoplay=1";
                break;
            case "s9":
                FindVideo2.Src = "https://www.youtube.com/embed/DelhLppPSxY?autoplay=1";
                break;
            case "s8":
                FindVideo2.Src = "https://www.youtube.com/embed/ThwSWIXhiRw?autoplay=1";
                break;
            case "s7":
                FindVideo2.Src = "https://www.youtube.com/embed/ZXTC0SmgE2s?autoplay=1";
                break;
            case "s6":
                FindVideo2.Src = "https://www.youtube.com/embed/VurhzANQ_B0?autoplay=1";
                break;
            case "s5":
                FindVideo2.Src = "https://www.youtube.com/embed/jUkoL9RE72o?autoplay=1";
                break;
            case "s4":
                FindVideo2.Src = "https://www.youtube.com/embed/hbFFGOv2gtg?autoplay=1";
                break;
            case "s3":
                FindVideo2.Src = "https://www.youtube.com/embed/Fi_GN1pHCVc?autoplay=1";
                break;
            case "s2":
                FindVideo2.Src = "https://www.youtube.com/embed/94bGzWyHbu0?autoplay=1";
                break;
            case "s1":
                FindVideo2.Src = "https://www.youtube.com/embed/oJaBHSIRVlE?autoplay=1";
                break;
            
        }

    }

    protected void nullify(object sender, EventArgs e)
    {
        FindVideo2.Src = "";
    }
}