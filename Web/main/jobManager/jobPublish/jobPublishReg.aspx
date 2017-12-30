<%@ Page Language="C#" AutoEventWireup="true" CodeFile="jobPublishReg.aspx.cs" Inherits="main_jobManager_jobPublish_jobPublishReg" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>

<head>

    <title>职位发布登记</title>

    <meta name="author" content="Wk">
    <meta name="robots" content="all">
    <meta name="keywords" content="keyword">
    <meta name="description" content="Wk Java Server Pages">
    <meta http-equiv="keywords" content="keyword">
    <meta http-equiv="description" content="Wk Java Server Pages">
    <meta http-equiv="Content-Type" content="text/html; charset=GBK">
    <meta http-equiv="windows-Target" content="_top">
    <meta http-equiv="pragma" content="no-cache">
    <meta http-equiv="cache-control" content="no-cache">
    <meta http-equiv="expires" content="0">
    <link rel="stylesheet" href="/Web/css/common.css"
        type="text/css" />
    <style type="text/css">
        table td {
            font-size: 12px;
        }

        .input_text {
            width: 100px;
        }

        .input_text2 {
            width: 100px;
        }
    </style>
    <link rel="stylesheet" href="/css/common.css"
        type="text/css" />
    <!--<link rel="stylesheet" type="text/css" href="styles.css">-->
    <link type="text/css" rel="stylesheet" href="/cal/calendar-system.css" />
    <script type="text/javascript" src="/cal/calenderJS.js"></script>
    <script type="text/javascript" src="/cal/calendar.js"></script>
    <script type="text/javascript" src="/cal/calendar-en.js"></script>
    <script type="JavaScript" src="/cal/calShow.js"></script>
    <script type="text/javascript" src="/js/json.js"></script>
    <script type="text/javascript">

        //三级机构三级级联
        var xmlHttpRequest;
        var flag = 0;
        var selIndex = 0;
        function doSearch(leave, obj) {

            selIndex = obj.value;
            flag = leave;
            var mac1 = obj.value;
            if (mac1 == null || mac1 == "") {
                return;
            }
            var url = "engMachine.do?op=doSearch&macLeave=" + leave + "&macParentId=" + mac1 + "&date=" + new Date();
            //JUser.doLogin(username,password,callback);
            xmlHttpRequest = createXmlHttpRequest();
            xmlHttpRequest.onreadystatechange = callback;
            xmlHttpRequest.open("post", url, true);
            xmlHttpRequest.send(null);
        }


        function createXmlHttpRequest() {
            if (window.ActiveXObject) { //IE浏览器
                return new ActiveXObject("Microsoft.XMLHTTP");
            } else if (window.xmlHttpRequest) {  //非IE浏览器
                return new XMLHttpRequest();
            }
        }

        var arr;
        function callback() {

            if (xmlHttpRequest.readyState == 4) {
                if (xmlHttpRequest.status == 200) {
                    var str = xmlHttpRequest.responseText;

                    arr = str.parseJSON();

                    if (flag == 2) {
                        a(selIndex);
                    }
                    else {
                        b(selIndex);
                    }
                }
            }
        }

        var one;
        var two;
        var three;
        var four;
        var five;
        //用来设置 select 的初始大小
        window.attachEvent("onload", initCallPurposeDetailPage);
        function initCallPurposeDetailPage()//初始化页面
        {
            one = document.getElementById("machine1");
            two = document.getElementById("machine2");
            three = document.getElementById("machine3");
            four = document.getElementById("jobType");
            five = document.getElementById("engJobissue.engJob.jobId");
        }

        //一级机构掉此函数刷新二级列表	
        function a(tValue) {

            two.selectedIndex = 0;
            three.selectedIndex = 0;
            if (tValue == 0) {
                two.length = 1;//当我们选择“请选择”时设置全部 select 的大小
                three.length = 1;
            }
            else {
                two.length = 1;
                three.length = 1;

                for (i = 0 ; i < arr.macList.length; i++) {
                    two.options[two.length] = new Option(arr.macList[i].macName, arr.macList[i].macId);

                }
            }
        }

        //二级机构掉此函数刷新三级列表	
        function b(tValue) {
            three.selectedIndex = 0;
            if (tValue == "0") {
                three.length = 1;//当我们选择“请选择”时设置全部 select 的大小
            }
            else {
                three.length = 1;
                for (i = 0 ; i < arr.macList.length; i++) {
                    three.options[three.length] = new Option(arr.macList[i].macName, arr.macList[i].macId);

                }
            }
        }

        //职位类型和职位名称二级级联
        function doSearchJob(obj) {
            five.selectedIndex = 0;
            var jobTypeId = obj.value;
            if (jobTypeId == null || jobTypeId == "") {
                return;
            }
            if (jobTypeId == "0") {
                five.length = 1;
                return;
            }
            var url = "engJob.do?op=doSearch&jboTypeId=" + jobTypeId + "&date=" + new Date();
            //JUser.doLogin(username,password,callback);
            xmlHttpRequest = createXmlHttpRequest();
            xmlHttpRequest.onreadystatechange = callbackJob;
            xmlHttpRequest.open("post", url, true);
            xmlHttpRequest.send(null);
        }

        //职位名称查询回调，刷新职位名称下拉列表
        function callbackJob() {
            if (xmlHttpRequest.readyState == 4) {
                if (xmlHttpRequest.status == 200) {
                    var str = xmlHttpRequest.responseText;
                    var jobs = str.parseJSON();
                    five.length = 1;
                    for (i = 0 ; i < jobs.jobList.length; i++) {
                        five.options[five.length] = new Option(jobs.jobList[i].jobName, jobs.jobList[i].jobId);

                    }
                }
            }
        }
        function toBack() {
            window.history.go(-1);

        }




    </script>
</head>

<body>
    <div id="man_zone">
        <form id="form1" runat="server">
            <input type="hidden" name="op" value="doAddJobissue" />
            <input type="hidden" name="engJobissue.sysUser.userId" value="1">
            <input type="hidden" name="engJobissue.jobIssueApplyNum" value="0">
            <input type="hidden" name="engJobissue.jobIssueEmployNum" value="0">
            <table width="99%" border="0" align="center" cellpadding="3"
                cellspacing="1" class="table_style">
                <thead>
                    <tr>
                        <td class="left_title_header" colspan="8">职位发布登记
                        </td>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td width="8%" class="left_title_1" style="text-align: center;">I级机构
                        </td>
                        <td width="17%" class="left_title_2" style="text-align: left;">&nbsp;<asp:DropDownList ID="ddlBranch1" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataSourceID="odsBranch1" DataTextField="First_kind_name" DataValueField="Id" OnSelectedIndexChanged="ddlBranch1_SelectedIndexChanged">
                            <asp:ListItem Selected="True" Value="-1">Choose...</asp:ListItem>
                        </asp:DropDownList>
                            <asp:ObjectDataSource ID="odsBranch1" runat="server" SelectMethod="GetAllSConfig_file_first_kinds" TypeName="TheOneHRBLL.Config_file_first_kindManager"></asp:ObjectDataSource>
                        </td>
                        <td width="8%" class="left_title_1" style="text-align: center;">II级机构
                        </td>
                        <td width="17%" class="left_title_2" style="text-align: left;">&nbsp;<asp:DropDownList ID="ddlBranch2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlBranch2_SelectedIndexChanged">
                            <asp:ListItem Value="-1">Choose...</asp:ListItem>
                        </asp:DropDownList>
                        </td>
                        <td width="9%" class="left_title_1" style="text-align: center;">III级机构
                        </td>
                        <td width="16%" class="left_title_2" style="text-align: left;">&nbsp;<asp:DropDownList ID="ddlBranch3" runat="server">
                            <asp:ListItem Value="-1">Choose...</asp:ListItem>
                        </asp:DropDownList>
                        </td>
                        <td width="9%" class="left_title_1" style="text-align: center;">招聘类型
                        </td>
                        <td width="16%" class="left_title_2" style="text-align: left;">&nbsp;<asp:DropDownList ID="ddlRequestType" runat="server" Height="19px">
                            <asp:ListItem Selected="True" Value="-1">Choose...</asp:ListItem>
                            <asp:ListItem>社会招聘</asp:ListItem>
                            <asp:ListItem>校园招聘</asp:ListItem>
                        </asp:DropDownList>
                        </td>
                    </tr>


                    <tr>
                        <td width="8%" class="left_title_1" style="text-align: center;">职位类型
                        </td>
                        <td width="17%" class="left_title_2" style="text-align: left;">&nbsp;<asp:DropDownList ID="ddlMajorKind" runat="server" AppendDataBoundItems="True" DataSourceID="odsMajorKind" DataTextField="Major_kind_name" DataValueField="Id">
                            <asp:ListItem Selected="True" Value="-1">Choose</asp:ListItem>
                        </asp:DropDownList>
                            <asp:ObjectDataSource ID="odsMajorKind" runat="server" SelectMethod="GetAllConfig_major_kinds" TypeName="TheOneHRBLL.Config_major_kindManager"></asp:ObjectDataSource>
                        </td>
                        <td width="8%" class="left_title_1" style="text-align: center;">职位名称
                        </td>
                        <td width="17%" class="left_title_2" style="text-align: left;">&nbsp;<asp:DropDownList ID="ddlMajor" runat="server" AppendDataBoundItems="True" DataSourceID="odsMajor" DataTextField="Major_name" DataValueField="Id">
                            <asp:ListItem Selected="True" Value="-1">Choose...</asp:ListItem>
                        </asp:DropDownList>
                            <asp:ObjectDataSource ID="odsMajor" runat="server" SelectMethod="GetAllConfig_majors" TypeName="TheOneHRBLL.Config_majorManager"></asp:ObjectDataSource>
                        </td>
                        <td width="9%" class="left_title_1" style="text-align: center;">截止日期
                        </td>
                        <td width="16%" class="left_title_2" style="text-align: left;">&nbsp;
                            <div id="timeErro" style="position: absolute; display: none"><font color="red">*</font></div>
                            <asp:TextBox ID="txtEndDate" Width="98px" runat="server" onclick="HS_setDate(this);"></asp:TextBox>
                        </td>
                        <td width="9%" class="left_title_1" style="text-align: center;">招聘人数
                        </td>
                        <td width="16%" class="left_title_2" style="text-align: left;">&nbsp;<asp:TextBox ID="txtRequestNum" runat="server" Width="62"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td width="8%" class="left_title_1" style="text-align: center;">登记人
                        </td>
                        <td width="17%" class="left_title_2" style="text-align: left;">&nbsp;<asp:TextBox ID="txtRegister" runat="server" Width="84px" ReadOnly="true" CssClass="input_text2"></asp:TextBox>
                        </td>
                        <td width="8%" class="left_title_1" style="text-align: center;">登记时间
                        </td>
                        <td width="17%" class="left_title_2" style="text-align: left;">&nbsp;<asp:TextBox ID="txtRegTime" runat="server" Width="104" ReadOnly="true" CssClass="input_text2"></asp:TextBox>
                        </td>
                        <td class="left_title_2" style="text-align: center;" colspan="4"></td>
                    </tr>

                    <tr>
                        <td width="8%" class="left_title_1" style="text-align: center;">职位描述
                        </td>
                        <td class="left_title_2" style="text-align: left;" colspan="7">&nbsp;<asp:TextBox ID="txtjobDesc" runat="server" Height="81px" TextMode="MultiLine" Width="574px"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td width="8%" class="left_title_1" style="text-align: center;">招聘要求
                        </td>
                        <td class="left_title_2" style="text-align: left;" colspan="7">&nbsp;<asp:TextBox ID="txtJobRequest" runat="server" Height="81px" TextMode="MultiLine" Width="574px"></asp:TextBox>
                        </td>
                    </tr>
                </tbody>
                <tfoot>
                    <tr bgcolor="#FFFFFF">
                        <td class="left_title_1" colspan="8" style="text-align: center;">
                            <asp:Button ID="btnSubmit" runat="server" CssClass="input_button" Text="提交" OnClick="btnSubmit_Click" />

                        </td>
                    </tr>
                </tfoot>
            </table>
        </form>
    </div>
</body>
<script type="text/javascript" src="/Web/js/validate2.js"></script>
<script type="text/javascript">
    build_validate("engJobissue.jobIssueDesc", "", "SafeString");
    build_validate("engJobissue.jobIssuePeopleNum", "", "Limit", "1", "2");
    build_validate("engJobissue.jobIssueEndTime", "", "Limit", "5", "15");
    build_validate("engJobissue.jobIssueDesc", "", "Limit", "1", "250");
    build_validate("engJobissue.jobIssueAppeal", "", "Limit", "1", "250");
    build_validate("machine1", "", "WkLimit");
    build_validate("engJobissue.engRetaintype.retainTypeId", "", "WkLimit");
    build_validate("jobType", "", "WkLimit");
    build_validate("engJobissue.engJob.jobId", "", "WkLimit");
    function formSubmit() {
        jsCheckForm();
    }
    function jsCheckForm() {
        if (Validator.Validate(document.forms[0], 3)) {
            if (checkByDate()) {
                document.getElementById("timeErro").style.display = 'none';
                document.forms[0].submit();
            } else {
                document.getElementById("timeErro").style.display = 'block';
            }
        }
        return false;
    }
    function checkNumkey(obj) {
        var key = event.keyCode;
        if ((key > 95 && key < 106) || (key > 47 && key < 60) || (key == 110 && obj.value.indexOf(".") > -1)) {
        } else {
            if (key != 8) {
                event.returnValue = false;
            }
        }
    }

    function checkByDate() {
        var inceptDate = document.getElementById("engJobissue.jobIssueBeginTime").value;
        var finishDate = document.getElementById("engJobissue.jobIssueEndTime").value;
        document.getElementById("timeErro").style.display = 'none';
        var incept = inceptDate.split("-");
        var finish = finishDate.split("-");

        if (finish[0] < incept[0]) {
            document.getElementById("timeErro").style.display = 'block';
            return false;
        }
        if (finish[1] < incept[1] && finish[0] == incept[0]) {
            document.getElementById("timeErro").style.display = 'block';
            return false;
        }
        if (finish[2] < incept[2] && finish[1] == incept[1] && finish[0] == incept[0]) {
            document.getElementById("timeErro").style.display = 'block';
            return false;
        }
        document.getElementById("timeErro").style.display = 'none';
        return true;
    }





</script>
</html>
