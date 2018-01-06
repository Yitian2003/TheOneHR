<%@ Page Language="C#" AutoEventWireup="true" CodeFile="interviewList.aspx.cs" Inherits="main_jobManager_interviewManager_interviewList" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
<head>

    <title>面试管理</title>

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
    <script type="text/javascript" src="/cal/calShow.js"></script>
    <style type="text/css">
        .auto-style1 {
            background-color: #fff;
            color: #73938E;
            font-weight: bold;
            line-height: 20px;
            text-align: right;
            font-size: 11px;
            height: 38px;
        }

        .auto-style2 {
            height: 38px;
        }
    </style>
</head>

<body>
    <div id="man_zone">
        <form id="engFaceresultForm" runat="server">

            <table width="99%" border="0" align="center" cellpadding="3"
                cellspacing="1" class="table_style">
                <thead>
                    <tr>
                        <td class="left_title_header" colspan="5">面试管理
                        </td>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td width="25%" class="left_title_2" style="text-align: center;"
                            rowspan="2">职位分类
                        </td>
                        <td width="25%" class="left_title_2" style="text-align: left;">职位类型
                        </td>
                        <td width="25%" class="left_title_2" style="text-align: left;">职位名称
                        </td>
                        <td width="25%" class="left_title_2" style="text-align: left;">面试状态
                        </td>

                    </tr>
                    <tr>
                        <td class="auto-style1" style="text-align: left;">
                            <asp:DropDownList ID="ddlMajorKind" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataSourceID="odsMajorKind" DataTextField="Major_kind_name" DataValueField="Id" OnSelectedIndexChanged="ddlMajorKind_SelectedIndexChanged">
                                <asp:ListItem Value="-1">Choose...</asp:ListItem>
                            </asp:DropDownList>
                            <asp:ObjectDataSource ID="odsMajorKind" runat="server" SelectMethod="GetAllConfig_major_kinds" TypeName="TheOneHRBLL.Config_major_kindManager"></asp:ObjectDataSource>
                            &nbsp;</td>
                        <td class="auto-style1" style="text-align: left;">
                            <asp:DropDownList ID="ddlMajor" runat="server" AppendDataBoundItems="True">
                                <asp:ListItem Value="-1">Choose...</asp:ListItem>
                            </asp:DropDownList>
                        &nbsp;<td class="auto-style2">&nbsp;<asp:DropDownList ID="ddlInterviewStatus" runat="server" AppendDataBoundItems="True">
                            <asp:ListItem Value="-1">Choose...</asp:ListItem>
                        </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="left_title_2" style="text-align: center;">关键字
                        </td>
                        <td class="left_title_2" style="text-align: left;" colspan="3">&nbsp;
                            <div id="listDiv"
                            style="position: absolute; border: 1px solid #cccccc; top: 121px; left: 238px; width: 150px; display: none">
                        </div>
                            <asp:TextBox ID="txtKey" runat="server"></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td class="left_title_2" style="text-align: center;">面试时间
                        </td>
                        <td class="left_title_2" style="text-align: left;">
                            <input type="text" id="beginTime" value="" onclick="calShow('beginTime');" readonly="readonly" class="input_text" runat="server">
                        </td>
                        <td class="left_title_2" style="text-align: left;" colspan="2">
                            <input type="text" id="endTime" value="" onclick="calShow('endTime');" readonly="readonly" class="input_text" runat="server">
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


            <asp:GridView ID="gvInterview" runat="server" align="center" CssClass="GridView" Width="99%" PageSize="5" AutoGenerateColumns="False" DataSourceID="odsInterview" Height="286px" OnRowDataBound="gvInterview_RowDataBound">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="序号" SortExpression="Id" />
                    <asp:TemplateField ConvertEmptyStringToNull="False" HeaderText="姓名" SortExpression="Er_no">
                        <EditItemTemplate>
                            <asp:DynamicControl ID="DynamicControl1" runat="server" DataField="Er_no" Mode="Edit" />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("Er_no.Human_name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Image_degree" HeaderText="形象评价" SortExpression="Image_degree" />
                    <asp:BoundField DataField="Native_language_degree" HeaderText="口才评价" SortExpression="Native_language_degree" />
                    <asp:BoundField DataField="Foreign_language_degree" HeaderText="外语能力" SortExpression="Foreign_language_degree" />
                    <asp:BoundField DataField="Response_speed_degree" HeaderText="应变能力" SortExpression="Response_speed_degree" />
                    <asp:BoundField DataField="EQ_degree" HeaderText="EQ" SortExpression="EQ_degree" />
                    <asp:BoundField DataField="IQ_degree" HeaderText="IQ" SortExpression="IQ_degree" />
                    <asp:BoundField DataField="Multi_quality_degree" HeaderText="综合素质" SortExpression="Multi_quality_degree" />
                    <asp:BoundField DataField="Regist_time" HeaderText="面试时间" SortExpression="Regist_time" />
                    <asp:TemplateField HeaderText="操作">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkConfirm" runat="server" CommandArgument='<%# Eval("Id") %>' OnCommand="LinkConfirm_Command">待审核</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>

            <asp:ObjectDataSource ID="odsInterview" runat="server" SelectMethod="Engage_InterviewAdvSearch" TypeName="TheOneHRBLL.Engage_interviewManager">
                <SelectParameters>
                    <asp:Parameter DefaultValue="-1" Name="majorId" Type="Int32" />
                    <asp:Parameter DefaultValue="-1" Name="resumeStatusId" Type="Int32" />
                    <asp:Parameter Name="key" Type="String" />
                    <asp:Parameter Name="beginTime" Type="String" />
                    <asp:Parameter Name="endTime" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>

        </form>

    </div>
</body>
</html>


