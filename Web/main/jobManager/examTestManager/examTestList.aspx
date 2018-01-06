<%@ Page Language="C#" AutoEventWireup="true" CodeFile="examTestList.aspx.cs" Inherits="main_jobManager_examTestManager_examTestList" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>

	<head>

		<title>考试出题</title>

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
		<div id="man_zone">
			<form id="form1" runat="server">
                <asp:GridView ID="gvExam" runat="server" align="center"  CssClass="GridView" Width="99%" AutoGenerateColumns="False" DataSourceID="odsExam" OnRowDataBound="gvExam_RowDataBound">
                    <Columns>
                        <asp:BoundField HeaderText="序号" />
                        <asp:BoundField DataField="Major_kind_name" HeaderText="职位分类名称" />
                        <asp:BoundField DataField="Major_name" HeaderText="职位名称" />
                        <asp:BoundField DataField="Number" HeaderText="套卷数量" />
                        <asp:TemplateField HeaderText="操作">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:LinkButton ID="linkGo" runat="server" CommandArgument='<%# Eval("Emr_no") %>' OnCommand="linkGo_Command">出题</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>

                </asp:GridView>
			    <asp:ObjectDataSource ID="odsExam" runat="server" SelectMethod="GetEngageExamList" TypeName="TheOneHRBLL.Engage_examManager"></asp:ObjectDataSource>
			</form>
		</div>

	</body>

</html>



