<%@ Page Language="C#" AutoEventWireup="true" CodeFile="jobPublishConfirm.aspx.cs" Inherits="main_jobManager_jobPublish_jobPublishConfirm" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>

<head>

    <title>职位发布变更</title>

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
</head>

<body>
    <form id="form1" runat="server">
        <div id="man_zone">
            <table width="99%" border="0" align="center" cellpadding="3"
                cellspacing="1" class="table_style">
                <thead>
                    <tr>
                        <td class="left_title_header" colspan="9">职位发布变更
                        </td>
                    </tr>
                </thead>
            </table>

            <asp:GridView ID="gvJobList" runat="server" CssClass="GridView" Width="99%" align="center" AutoGenerateColumns="False" DataSourceID="odsJob">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="序号" SortExpression="Id" />
                    <asp:TemplateField HeaderText="职位名称" SortExpression="Cm">
                        <EditItemTemplate>
                            <asp:DynamicControl ID="DynamicControl1" runat="server" DataField="Cm" Mode="Edit" />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("Cm.Major_name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="机构名称" SortExpression="Ctk">
                        <EditItemTemplate>
                            <asp:DynamicControl ID="DynamicControl2" runat="server" DataField="Ctk" Mode="Edit" />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Eval("Ctk.Csk.Cfk.First_kind_name") + "-" + Eval("Ctk.Csk.Second_kind_name") + "-" + Eval("Ctk.Third_kind_name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Human_amount" HeaderText="招聘人数" SortExpression="Human_amount" />
                    <asp:BoundField DataField="Regist_time" HeaderText="登记时间" SortExpression="Regist_time" DataFormatString="{0:d}" />
                    <asp:BoundField DataField="Deadline" HeaderText="截至时间" SortExpression="Deadline" DataFormatString="{0:d}" />
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:Button ID="btnAdd" runat="server" CssClass="input_button" OnClick="btnAdd_Click" Text="新增" />
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:LinkButton ID="linkEdit" runat="server" CommandArgument='<%# Eval("Id") %>' Text="修改" OnCommand="linkEdit_Command"></asp:LinkButton>
                            <asp:LinkButton ID="linkDel" runat="server" CommandArgument='<%# Eval("Id") %>' OnClientClick="return confirm('你确定要删除？')" OnCommand="linkDel_Command">删除</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="odsJob" runat="server" SelectMethod="GetAllEngage_major_releases" TypeName="TheOneHRBLL.Engage_major_releaseManager"></asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
