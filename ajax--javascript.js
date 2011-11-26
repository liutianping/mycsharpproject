
<script language="javascript" type="text/javascript">
    function send_request(flag)
    {
        //创建http对象
         
        http_request=false;
        if(window.XMLHttpRequest)
        {   
            //飞IE浏览器
            http_request=new XMLHttpRequest();
        }
        else if(window.ActiveXObject)
        {
            //IE浏览器
            try
            {
                http_request=new ActiveXObject("Msxml2.XMLHTTP");
            }
            catch(e)
            {
                try
                {
                    http_request=new ActiveXOBject("Microsoft XMLHTTP");
                    
                }catch(e){}
            }
        }
        else
        {
            window.alert("不能创建XMLHttpRequest对象，无法应用Ajax");
            return false;
        }        
        if(flag=="updateTitle")
        {
          http_request.onreadystatechange=updateTitle;
          //创建http请求
          i=document.getElementById("ddlVoteTitle").selectedIndex;//选择的缩影
          id=document.form1.ddlVoteTitle.options[i].value;
        http_request.open("get","Handler.ashx?flag=updateTitle&id="+id,true);
        //发送上面创建的HTTP请求
        }
        else if(flag="addadmin")
        {
        //指定回调函数
         http_request.onreadystatechange=addAdmin;
         http_request.open("get","Handler.ashx?flag=addAdmin&userName="+document.getElementById("txtUserName").value,true);
        } 
        http_request.send(null);
    }
    function addAdmin()
    {
        
        if(http_request.readyState==4)//发送成功
        {
            if(http_request.status==200)//交易成功
            {
                //正式处理有信息
                if(http_request.responseText=="该用户已存在")
                {
                    document.getElementById("Button1").style.display="none";
                }
                else
                {
                    document.getElementById("Button1").style.display="";
                }
                document.getElementById("lblShow").innerText=http_request.responseText;
            }
        }
    }
    
        function updateTitle()
    {
        if(http_request.readyState==4)//发送成功
        {
            if(http_request.status==200)//交易成功
            {
                //正式处理有信息
                document.getElementById("lblTitle").innerText=http_request.responseText;
            }
        }
    }
    
    </script>