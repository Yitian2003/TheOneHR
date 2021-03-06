﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="examSearch.aspx.cs" Inherits="main_jobManager_examManager_examSearch" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
<head>

    <title>试题查询</title>

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
    <link rel="stylesheet" href="/css/common.css"
        type="text/css" />
    <link type="text/css" rel="stylesheet" href="/cal/calendar-system.css" />
    <script type="text/javascript" src="/cal/calenderJS.js"></script>
    <script type="text/javascript" src="/cal/calendar.js"></script>
    <script type="text/javascript" src="/cal/calendar-en.js"></script>
    <script type="JavaScript" src="/cal/calShow.js"></script>
    <script type="text/javascript" src="json.js"></script>
    <script type="text/javascript">
        //二级试题二级级联
        var xmlHttpRequest;
        function doSearch(obj) {
            var que = obj.value;
            if (que == null || que == "") {
                return;
            }
            var url = "engQuestiontype.do?op=doSearch&id=" + que + "&strDate=" + new Date();
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




        var one;
        var two;
        //用来设置 select 的初始大小
        window.attachEvent("onload", initCallPurposeDetailPage);
        function initCallPurposeDetailPage()//初始化页面
        {
            one = document.getElementById("qusTypeId1");
            two = document.getElementById("qusTypeId2");
        }

        //一级刷新二级列表
        function callback() {
            if (xmlHttpRequest.readyState == 4) {
                if (xmlHttpRequest.status == 200) {
                    var str = xmlHttpRequest.responseText;
                    var ques = str.parseJSON();
                    two.length = 1;
                    for (i = 0 ; i < ques.questionList.length; i++) {
                        two.options[two.length] = new Option(ques.questionList[i].qusTypeName, ques.questionList[i].qusTypeId);
                    }
                }
            }
        }

        function toBack() {
            window.history.go(-1);

        }

        function checkByDate() {
            var inceptDate = document.forms[0].elements["beginTime"].value;
            var finishDate = document.forms[0].elements["endTime"].value;
            var incept = inceptDate.split("-");
            var finish = finishDate.split("-");
            if (finish[0] < incept[0]) {
                return false;
            }
            if (finish[1] < incept[1] && finish[0] == incept[0]) {
                return false;
            }
            if (finish[2] < incept[2] && finish[1] == incept[1] && finish[0] == incept[0]) {
                return false;
            }
            return true;
        }


        function checkForm() {
            if (checkByDate()) {
                document.getElementById("timeErro").style.display = 'none';
                document.forms[0].submit();
            } else {
                document.getElementById("timeErro").style.display = 'block';
            }
        }

        function clearTerm() {
            var jobType = document.getElementById("qusTypeId1");
            var job = document.getElementById("qusTypeId2");
            var term = document.getElementById("term");
            var beginTime = document.getElementById("beginTime");
            var endTime = document.getElementById("endTime");
            jobType.value = '0';
            job.value = '0';
            term.value = "";
            beginTime.value = "";
            endTime.value = "";
        }


    </script>


</head>

<body>
    <div id="man_zone">
        <form id="form1" runat="server">
            <input type="hidden" name="op" value="toSearch" />
            <table width="99%" border="0" align="center" cellpadding="3"
                cellspacing="1" class="table_style">
                <thead>
                    <tr>
                        <td class="left_title_header" colspan="5">试题查询
                        </td>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td width="30%" class="left_title_2" style="text-align: center;"
                            rowspan="2">试题分类
                        </td>
                        <td width="35%" class="left_title_2" style="text-align: left;">试题I级分类
                        </td>

                        <td width="35%" class="left_title_2" style="text-align: left;">试题II级分类
                        </td>

                    </tr>
                    <tr>
                        <td class="left_title_2" style="text-align: left;">&nbsp;<asp:DropDownList ID="ddlCategory1" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataSourceID="odsCategory1" DataTextField="First_kind_name" DataValueField="Id" OnSelectedIndexChanged="ddlCategory1_SelectedIndexChanged">
                            <asp:ListItem Value="-1">Choose...</asp:ListItem>
                        </asp:DropDownList>
                            <asp:ObjectDataSource ID="odsCategory1" runat="server" SelectMethod="GetAllConfig_question_first_kinds" TypeName="TheOneHRBLL.Config_question_first_kindManager"></asp:ObjectDataSource>
                        </td>
                        <td class="left_title_2" style="text-align: left;">
                            <asp:DropDownList ID="ddlCategory2" runat="server">
                                <asp:ListItem Value="-1">Choose...</asp:ListItem>
                            </asp:DropDownList>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="left_title_2" style="text-align: center;">关键字
                        </td>
                        <td class="left_title_2" style="text-align: left;" colspan="2">
                            <asp:TextBox ID="txtTerm" runat="server"></asp:TextBox>
                            &nbsp;</td>
                    </tr>

                    <tr>
                        <td class="left_title_2" style="text-align: center;">登记时间
                        </td>
                        <td class="left_title_2" style="text-align: left;">
                            <input type="text" id="beginTime" value="" onclick="HS_setDate(this);" readonly="readonly" class="input_text" runat="server">
                        </td>
                        <td class="left_title_2" style="text-align: left;">
                            <input type="text" id="endTime" value="" onclick="HS_setDate(this);" readonly="readonly" class="input_text" runat="server">
                            <div id="timeErro" style="position: absolute; display: none"><font color="red">查询时间有误</font></div>
                        </td>
                    </tr>
                </tbody>
                <tfoot>
                    <tr bgcolor="#FFFFFF">
                        <td class="left_title_1" colspan="5" style="text-align: center;">
                            <asp:Button ID="btnSearch" Text="查询" CssClass="input_button" runat="server" OnClick="btnSearch_Click" />

                            <input type="button" onclick="clearTerm();" value="清除" class="input_button" />
                        </td>
                    </tr>
                </tfoot>
            </table>


            <br />

            <asp:GridView ID="gvExam" runat="server" CssClass="GridView" Width="90%" align="center" AutoGenerateColumns="False" DataSourceID="odsEngageSubject" AllowPaging="True" PageSize="5">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="序号" SortExpression="Id" />
                    <asp:BoundField DataField="Context" HeaderText="题干" SortExpression="Context" />
                    <asp:TemplateField ConvertEmptyStringToNull="False" HeaderText="试题I级分类" SortExpression="Cqsk_No">
                        <EditItemTemplate>
                            <asp:DynamicControl ID="DynamicControl1" runat="server" DataField="Cqsk_No" Mode="Edit" />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("Cqsk_No.Cqfk_no.First_kind_name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ConvertEmptyStringToNull="False" HeaderText="试题II级分类" SortExpression="Cqsk_No">
                        <EditItemTemplate>
                            <asp:DynamicControl ID="DynamicControl2" runat="server" DataField="Cqsk_No" Mode="Edit" />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("Cqsk_No.Second_kind_name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Derivation" HeaderText="出处" SortExpression="Derivation" />
                    <asp:BoundField DataField="Correct_key" HeaderText="正确答案" SortExpression="Correct_key" />
                    <asp:TemplateField HeaderText="操作">
                        <ItemTemplate>
                            <asp:LinkButton ID="linkModify" runat="server" CommandArgument='<%# Eval("Id") %>' OnCommand="linkModify_Command">修改</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

            <asp:ObjectDataSource ID="odsEngageSubject" runat="server" SelectMethod="SearchEngage_subjectAdv" TypeName="TheOneHRBLL.Engage_subjectManager">
                <SelectParameters>
                    <asp:Parameter Name="categoryId" Type="Int32" DefaultValue="-1" />
                    <asp:Parameter Name="key" Type="String" />
                    <asp:Parameter Name="startTime" Type="String" />
                    <asp:Parameter Name="endTime" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>

        </form>
    </div>
</body>

</html>
