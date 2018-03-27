<%@ Page Language="C#" ContentType="text/html" ResponseEncoding="gb2312" AutoEventWireup="true"%>

<%
    string strName = System.Web.HttpUtility.UrlDecode(Request["name"]);
    string strHtml = "<div class='clsShow'>";
    if (strName == "qiang.c.chen")
    {
        strHtml += "Name : qiang.c.chen";
        strHtml += "Email : qiang.c.chen@accenture.com";
    }
    strHtml += "</div>";
    Response.Write(strHtml);
%>
