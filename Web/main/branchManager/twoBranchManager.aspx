<%@ Page Language="C#" AutoEventWireup="true" CodeFile="twoBranchManager.aspx.cs" Inherits="main_branchManager_twoBranchManager" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
	<head>
		<title>二级机构管理</title>
		
		<meta http-equiv="pragma" content="no-cache">
		<meta http-equiv="cache-control" content="no-cache">
		<meta http-equiv="expires" content="0">
		<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
		<meta http-equiv="description" content="This is my page">
		<link rel="stylesheet" href="/css/common.css"
			type="text/css" />
	</head>

	<body>
		<div id="man_zone">
			<form id="engMachineForm" runat="server">
				
				<table width="70%" border="0" align="center" cellpadding="3"
					cellspacing="1" class="table_style">
					<thead>
						<tr>
							<td class="left_title_header" colspan="2">
								二级机构查询
							</td>
						</tr>
					</thead>
					<tbody>
						<tr>
							<td width="50%" class="left_title_1" style="text-align: center;">
								二级机构名称
							</td>
							<td width="50%" class="left_title_1" style="text-align: center;">
								一级机构名称
							</td>
						</tr>


						<tr>
							<td class="left_title_2" style="text-align: center;">
								<input type="text" maxlength="10" value="" class="input_text" id="txtBranchName" runat="server">
							</td>
							<td class="left_title_2" style="text-align: center;">
								
								
								
							    <asp:DropDownList ID="ddlBranch1"  AppendDataBoundItems="true" runat="server" DataSourceID="odsBranch11" DataTextField="First_kind_name" DataValueField="Id">
                                    <asp:ListItem Selected="True" Value="0">Choose...</asp:ListItem>
                                </asp:DropDownList>
                                <asp:ObjectDataSource ID="odsBranch11" runat="server" SelectMethod="GetAllSConfig_file_first_kinds" TypeName="TheOneHRBLL.Config_file_first_kindManager"></asp:ObjectDataSource>
								
								
								
							</td>
						</tr>
					</tbody>
					<tfoot>
						<tr bgcolor="#FFFFFF">
							<td class="left_title_1" colspan="2" style="text-align: center;">
								
                                <asp:Button id="btnSearch" CssClass="input_button" Text="查询" runat="server" OnClick="btnSearch_Click"/>
								<input type="reset" value="重置" class="input_button">
							</td>
						</tr>
					</tfoot>
				</table>

				<br />

                <asp:Repeater ID="rptBranch" runat="server" DataSourceID="odsBranch1">
                    <HeaderTemplate>
                        <table width="99%" border="0" align="center" cellpadding="3"
					cellspacing="1" class="table_style">
					<thead>
						<tr>
							<td width="25%" class="left_title_header">
								序号
							</td>
							<td width="25%" class="left_title_header">
								I级机构
							</td>
							<td width="25%" class="left_title_header">
								II级机构
							</td>
							<td width="25%" class="left_title_header">
								<input type="button" name="addAndSelMachineTwo" value="新增"
									class="input_button"
									onclick="location.href='/main/branchManager/addTwo.aspx'">
							</td>
						</tr>
					</thead>
                    </HeaderTemplate>

                    <ItemTemplate>
                        <tr>
									<td class="left_title_2" style="text-align: center;">
										<%#Eval("Id") %>
									</td>
									<td class="left_title_2" style="text-align: center;">
										<%#Eval("Cfk.First_kind_name") %>
									</td>
									<td class="left_title_2" style="text-align: center;">
										<%#Eval("Second_kind_name") %>
									</td>
									<td class="left_title_2" style="text-align: center;">
										<a href='/main/branchManager/editTwo.aspx?id=<%#Eval("Id") %>'>修改</a>
										<a href='/main/branchManager/delTwo.aspx?id=<%#Eval("Id") %>'
											onclick="return confirm('确定要删除吗?');">删除</a>
									</td>
								</tr>
                    </ItemTemplate>

                    <FooterTemplate>
                        <tfoot>
						
					</tfoot>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>

					
				
			    <asp:ObjectDataSource ID="odsBranch1" runat="server" SelectMethod="GetSecondBranchByCondition" TypeName="TheOneHRBLL.Config_file_second_kindManager">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="1=1" Name="condition" Type="String" />
                    </SelectParameters>
			    </asp:ObjectDataSource>

			</form>
		</div>
	</body>
	
</html>