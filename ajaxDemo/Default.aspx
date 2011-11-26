<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <script language="javascript" type="text/javascript">
        function btnSend(){
            var xmlhttp=new ActiveXObject("Microsoft.XMLHTTP");
            if(!xmlhttp){
                alert("new xmlhttp error");
                return false;
            }
            xmlhttp.open("POST","GetDate.ashx",false);
            xmlhttp.onreadystatechange=function(){
                if(xmlhttp.readyState==4){
                    if(xmlhttp.status==200){
                        document.getElementById("txtTimeNow").value=xmlhttp.responseText;
                    }
                    else{
                        alert("server ruturn error");
                    }
                }
            }
            xmlhttp.send();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <input type="text" id="txtTimeNow" />
    <input type ="button" id="btnTime" onclick="btnSend()" />
    </div>
    </form>
</body>
</html>
