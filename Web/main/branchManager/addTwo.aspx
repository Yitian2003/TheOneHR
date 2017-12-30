<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addTwo.aspx.cs" Inherits="main_branchManager_addTwo" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
	<head>
		<title>增加二级机构</title>
		
		<meta http-equiv="pragma" content="no-cache">
		<meta http-equiv="cache-control" content="no-cache">
		<meta http-equiv="expires" content="0">
		<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
		<meta http-equiv="description" content="This is my page">
		<link rel="stylesheet" href="h/css/common.css"
			type="text/css"></link>
	</head>
	<body>
		<div id="man_zone">
			<form id="form1" runat="server">
				<input type="hidden" name="op" value="doAddTwo" />
				<table width="70%" border="0" align="center" cellpadding="3"
					cellspacing="1" class="table_style">
					<thead>
						<tr>
							<td class="left_title_header" colspan="2">
								新增二级机构
							</td>
						</tr>
					</thead>
					<tbody>
						<tr>
							<td width="40%" class="left_title_1" style="text-align: center;">
								一级机构名称
							</td>
							<td width="60%" class="left_title_2"
								style="text-align: left;padding-left:20%;">
								
									&nbsp;<asp:DropDownList ID="ddlBranch11" AppendDataBoundItems="true" runat="server" DataSourceID="ObjectDataSource1" DataTextField="First_kind_name" DataValueField="Id">
                                        <asp:ListItem Selected="True" Value="0">Choose...</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllSConfig_file_first_kinds" TypeName="TheOneHRBLL.Config_file_first_kindManager"></asp:ObjectDataSource>
								
							</td>
						</tr>

						<tr>
							<td width="40%" class="left_title_1" style="text-align: center;">
								二级机构名称
							</td>
							<td width="60%" class="left_title_2"
								style="text-align: left;padding-left:20%;">
								<input type="text" name="engMachine.macName" maxlength="10" value="" CssClass="input_text" id="txtBranchName" runat="server">
							</td>
						</tr>
					</tbody>
					<tfoot>
						<tr bgcolor="#FFFFFF">
							<td class="left_title_1" colspan="2"
								style="text-align: left;padding-left:40%;">
                                <asp:Button ID="btnSave" runat="server" CssClass="input_button" Text="提交"  OnClick="btnSave_Click" />
								
								<input type="reset" value="重置" class="input_button">
								<input type="button" value="返回" class="input_button"
									onclick="history.go(-1)" ;/>
							</td>
						</tr>
					</tfoot>
				</table>
			</form>
		</div>
	</body>
	
</html>