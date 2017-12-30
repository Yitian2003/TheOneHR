<%@ Page Language="C#" AutoEventWireup="true" CodeFile="jobPublishChange.aspx.cs" Inherits="main_jobManager_jobPublish_jobPublishChange" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>

<head>

    <title>职位发布修改</title>

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

        .input_Text {
            width: 100px;
        }

        .input_Text2 {
            width: 100px;
        }
    </style>
    <link rel="stylesheet" href="/Web/css/common.css"
        type="text/css" />
    <!--<link rel="stylesheet" type="text/css" href="styles.css">-->
    <link type="text/css" rel="stylesheet" href="cal/calendar-system.css" />
    <script type="text/javascript" src="/cal/calendar.js"></script>
    <script type="text/javascript" src="/cal/calendar-en.js"></script>
    <script type="text/javascript" src="/cal/calenderJS.js"></script>
    <script type="JavaScript" src="/cal/calShow.js">

		
    </script>

</head>

<body>
    <div id="man_zone">
        <form id="form1" runat="server">
            <input type="hidden" name="op" value="doUpdate" />
            <input type="hidden" name="engJobissue.jobIssueId" value="6">
            <input type="hidden" name="engJobissue.sysUser.userId" value="1">
            <input type="hidden" name="engJobissue.jobIssueId" value="6">
            <input type="hidden" name="engJobissue.engJob.jobId" value="2">
            <table width="99%" border="0" align="center" cellpadding="3"
                cellspacing="1" class="table_style">
                <thead>
                    <tr>
                        <td class="left_title_header" colspan="8">职位发布变更
                        </td>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td width="8%" class="left_title_1" style="text-align: center;">I级机构
                        </td>
                        <td width="17%" class="left_title_2" style="text-align: left;">
                            <asp:Label ID="lblBranch1" runat="server"></asp:Label>
                        </td>
                        <td width="8%" class="left_title_1" style="text-align: center;">II级机构
                        </td>
                        <td width="17%" class="left_title_2" style="text-align: left;">
                            <asp:Label ID="lblBranch2" runat="server"></asp:Label>
                        </td>
                        <td width="9%" class="left_title_1" style="text-align: center;">III级机构
                        </td>
                        <td width="16%" class="left_title_2" style="text-align: left;">
                            <asp:Label ID="lblBranch3" runat="server"></asp:Label>
                        </td>
                        <td width="9%" class="left_title_1" style="text-align: center;">招聘类型
                        </td>
                        <td width="16%" class="left_title_2" style="text-align: left;">
                            <asp:DropDownList ID="ddlRequestType" runat="server">
                                <asp:ListItem Value="-1">Choose...</asp:ListItem>
                                <asp:ListItem>社会招聘</asp:ListItem>
                                <asp:ListItem>校园招聘</asp:ListItem>
                            </asp:DropDownList>
                            &nbsp;</td>
                    </tr>


                    <tr>
                        <td width="8%" class="left_title_1" style="text-align: center;">职位类型
                        </td>
                        <td width="17%" class="left_title_2" style="text-align: left;">
                            <asp:Label ID="lblJobType" runat="server"></asp:Label>
                        </td>
                        <td width="8%" class="left_title_1" style="text-align: center;">职位名称
                        </td>
                        <td width="17%" class="left_title_2" style="text-align: left;">
                            <asp:Label ID="lblJobName" runat="server"></asp:Label>
                        </td>
                        <td width="9%" class="left_title_1" style="text-align: center;">截止日期
                        </td>
                        <td width="16%" class="left_title_2" style="text-align: left;">
                            <asp:TextBox ID="txtEndDate" runat="server" onclick="HS_setDate(this);" Width="98px"></asp:TextBox>

                        </td>
                        <td width="9%" class="left_title_1" style="text-align: center;">招聘人数
                        </td>
                        <td width="16%" class="left_title_2" style="text-align: left;">
                            <asp:TextBox ID="txtRequestNum" runat="server" Width="62px"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td width="8%" class="left_title_1" style="text-align: center;">登记人
                        </td>
                        <td width="17%" class="left_title_2" style="text-align: left;">
                            <asp:Label ID="lblRegister" runat="server"></asp:Label>
                        </td>
                        <td width="8%" class="left_title_1" style="text-align: center;">更新时间
                        </td>
                        <td width="17%" class="left_title_2" style="text-align: left;">
                            <asp:Label ID="lblUpdateTime" runat="server"></asp:Label>

                        </td>
                        <td class="left_title_2" style="text-align: center;" colspan="4"></td>
                    </tr>

                    <tr>
                        <td width="8%" class="left_title_1" style="text-align: center;">职位描述
                        </td>
                        <td class="left_title_2" style="text-align: left;" colspan="7">
                            <asp:TextBox ID="txtjobDesc" runat="server" Height="81px" TextMode="MultiLine" Width="574px"></asp:TextBox>
                            &nbsp;</td>
                    </tr>

                    <tr>
                        <td width="8%" class="left_title_1" style="text-align: center;">招聘要求
                        </td>
                        <td class="left_title_2" style="text-align: left;" colspan="7">
                            <asp:TextBox ID="txtJobRequest" runat="server" Height="81px" TextMode="MultiLine" Width="574px"></asp:TextBox>
                        </td>
                    </tr>
                </tbody>
                <tfoot>
                    <tr bgcolor="#FFFFFF">
                        <td class="left_title_1" colspan="8" style="text-align: center;">
                            <asp:Button ID="btnSubmit" Text="提交" CssClass="input_button" runat="server" OnClick="btnSubmit_Click" />
                            
                            <input type="button" value="返回" class="input_button"
                                onclick="window.history.go(-1);" />
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
    build_validate("engJobissue.engRetaintype.retainTypeId", "", "WkLimit");
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
