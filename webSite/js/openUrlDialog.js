



function OpenUrl(url)
{
    var con;
    con = confirm("即将跳转到外部网站，是否继续?"); //在页面上弹出对话框
    if (con == true)
    { window.open(url, '_blank') }
    else {  }
}