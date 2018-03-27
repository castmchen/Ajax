<%@ Page Language="C#" ContentType="text/html" ResponseEncoding="gb2312" AutoEventWireup="true"%>

<%
    var name = System.Web.HttpUtility.UrlDecode(Request["txtName"]);
    var password = System.Web.HttpUtility.UrlDecode(Request["txtPass"]);
    bool loginFlag = false;
    if (name.Equals("qiang.c.chen") && password.Equals("1234"))
    {
        loginFlag = true;
    }
    Response.Write(loginFlag);
%>
