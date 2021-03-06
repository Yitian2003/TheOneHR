﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addOne.aspx.cs" Inherits="main_branchManager_addOne" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
	<head>
		<title>一级机构的添加</title>
		
		<meta http-equiv="pragma" content="no-cache">
		<meta http-equiv="cache-control" content="no-cache">
		<meta http-equiv="expires" content="0">
		<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
		<meta http-equiv="description" content="This is my page">
		<link rel="stylesheet" href="/css/common.css"
			type="text/css"></link>
	</head>

	<body>
		<div id="man_zone">
			<form id="engMachineForm" runat="server">
				<input type="hidden" name="op" value="doAddOne" />
				<table width="70%" border="0" align="center" cellpadding="3"
					cellspacing="1" class="table_style">
					<thead>
						<tr>
							<td class="left_title_header" colspan="2">
								新增一级机构
							</td>
						</tr>
					</thead>
					<tbody>
						<tr>
							<td width="33%" class="left_title_2" style="text-align: center;">
								机构名称
							</td>
							<td width="67%" class="left_title_2" style="text-align: left;">
								<input type="text" name="engMachine.macName" maxlength="10" value="" class="input_text" id="txtBranchName" runat="server">
							</td>
						</tr>
					</tbody>
					<tfoot>
						<tr bgcolor="#FFFFFF">
							<td class="left_title_1" colspan="2" style="text-align: center;">
                                <asp:Button runat="server" ID="btnSave" Text="提交" CssClass="input_button"  OnClick="btnSave_Click" />
								
								<input type="reset" value="重置" class="input_button">
								<input type="button" value="返回" class="input_button" onclick="history.go(-1)"/>
							</td>
						</tr>
					</tfoot>
				</table>
			</form>
		</div>
	</body>

</html>

