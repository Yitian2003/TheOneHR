﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="editTwo.aspx.cs" Inherits="main_branchManager_editTwo" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
	<head>

		<title>修改二级机构</title>

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
				<input type="hidden" name="engMachine.macId" value="20">
				<input type="hidden" name="op" value="doUpdateTwo" />
				<table width="70%" border="0" align="center" cellpadding="3"
					cellspacing="1" class="table_style">
					<thead>
						<tr>
							<td class="left_title_header" colspan="2">
								二级机构修改
							</td>
						</tr>
					</thead>
					<tbody>
						<tr>
							<td width="40%" class="left_title_2" style="text-align: center;">
								机构名称
							</td>
							<td width="60%" class="left_title_2" style="text-align: left;">
								<input runat="server" type="text" name="engMachine.macName" maxlength="10" value="安徽" class="input_text" id="txtBranchName" >
							</td>
						</tr>
					</tbody>
					<tfoot>
						<tr bgcolor="#FFFFFF">
							<td class="left_title_1" colspan="2"
								style="text-align: left;padding-left:40%;">
                                <asp:Button ID="btnSave" Text="提交" CssClass="input_button" runat="server" OnClick="btnSave_Click" />
								
								<input type="reset" value="重置" class="input_button">
								<input type="button" value="返回" class="input_button"
									onclick="history.go(-1)" />
							</td>
						</tr>
					</tfoot>
				</table>
			</form>
		</div>
	</body>
	<script type="text/javascript" src="/js/validate2.js"></script>
	<script type="text/javascript">
build_validate("engMachine.macName","","WkCENString");
function jsCheckForm(){
	if (Validator.Validate(document.forms[0],3)){
		return true;
	}
	return false;
}
function formSubmit(){
	if(jsCheckForm()){
		document.forms[0].submit();
	}
	return;
}
</script>

</html>
