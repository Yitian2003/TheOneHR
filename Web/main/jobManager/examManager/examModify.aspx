﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="examModify.aspx.cs" Inherits="main_jobManager_examManager_examModify" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>

	<head>

		<title>试题修改</title>

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
			table td{
				font-size:12px;
			}
			.inputText{
				width:100px;
			}
		</style>

		<!--<link rel="stylesheet" type="text/css" href="styles.css">-->
		<script type="text/javascript" src="json.js"></script>
		<script type="text/javascript">
	

		function toBack(){
			window.history.go(-1);
		}
			
	
	
		
			

	</script>
	</head>

	<body>

			<div id="man_zone" style="height: auto;">
			    <form id="form1" runat="server">
				<input type="hidden" name="op" value="doUpdateQuestion" />
			<input type="hidden" name="engQuestion.sysUser.userId" value="1">

			<input type="hidden" name="engQuestion.engQuestiontype.qusTypeId" value="6">
			<input type="hidden" name="engQuestion.qusCreateDate" value="2010-03-29">
			<input type="hidden" name="engQuestion.qusId" value="21">
				<table width="99%" border="0" align="center" cellpadding="3"
					cellspacing="1" class="table_style">
					<thead>
						<tr>
							<td class="left_title_header" colspan="4">
								试题修改

							</td>
						</tr>
					</thead>
					<tbody>
						<tr>
							<td width="25%" class="left_title_1" style="text-align: center;">
								试题I级分类
							</td>
							<td width="25%" class="left_title_2" style="text-align: left;">
								
							    <asp:Label ID="lblCategory1" runat="server" Text="Label"></asp:Label>
								
							</td>
							<td width="25%%" class="left_title_1" style="text-align: center;">
								试题II级分类
							</td>
							<td width="25%" class="left_title_2" style="text-align: left;">
								
							    <asp:Label ID="lblCategory2" runat="server" Text="Label"></asp:Label>
								
							</td>
						</tr>
						<tr>
							<td class="left_title_1" style="text-align: center;">
								题干
							</td>
							<td class="left_title_2" style="text-align: left;" colspan="3">
								<asp:TextBox ID="txtQTitle" runat="server" Height="68px" TextMode="MultiLine" Width="503px"></asp:TextBox>
                            </td>
						</tr>

						<tr>
							<td class="left_title_1" style="text-align: center;">
								答案A
							</td>
							<td class="left_title_2" style="text-align: left;" colspan="3">
							<asp:TextBox ID="txtQA" runat="server" Height="40px" TextMode="MultiLine" Width="503px"></asp:TextBox>

							</td>
						</tr>

						<tr>
							<td class="left_title_1" style="text-align: center;">
								答案B
							</td>
							<td class="left_title_2" style="text-align: left;" colspan="3">
							
                                <asp:TextBox ID="txtQB" runat="server" Height="40px" TextMode="MultiLine" Width="503px"></asp:TextBox>
							</td>
						</tr>

						<tr>
							<td class="left_title_1" style="text-align: center;">
								答案C
							</td>
							<td class="left_title_2" style="text-align: left;" colspan="3">
							<asp:TextBox ID="txtQC" runat="server" Height="40px" TextMode="MultiLine" Width="503px"></asp:TextBox></td>
						</tr>

						<tr>
							<td class="left_title_1" style="text-align: center;">
								答案D
							</td>
							<td class="left_title_2" style="text-align: left;" colspan="3">
							<asp:TextBox ID="txtQD" runat="server" Height="40px" TextMode="MultiLine" Width="503px"></asp:TextBox></td>
						</tr>

						<tr>
							<<td class="left_title_1" style="text-align: center;">
								答案E
							</td>
							<td class="left_title_2" style="text-align: left;" colspan="3">
							<asp:TextBox ID="txtQE" runat="server" Height="40px" TextMode="MultiLine" Width="503px"></asp:TextBox></td>

						</tr>

						<tr>
							<td class="left_title_1" style="text-align: center;">
								正确答案
							</td>
							<td class="left_title_2" style="text-align: left;" colspan="3">
								<asp:CheckBoxList ID="chkAnswer" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem>A</asp:ListItem>
                                <asp:ListItem>B</asp:ListItem>
                                <asp:ListItem>C</asp:ListItem>
                                <asp:ListItem>D</asp:ListItem>
                                <asp:ListItem>E</asp:ListItem>
                            </asp:CheckBoxList>
							</td>
						</tr>

						<tr>
							<td class="left_title_1" style="text-align: center;">
								试题出处
							</td>
							<td class="left_title_2" style="text-align: left;" colspan="3">
								<asp:TextBox ID="txtFrom" runat="server"></asp:TextBox>
							</td>
						</tr>

						<tr>
							<td class="left_title_1" style="text-align: center;">
								登记人
							</td>
							<td class="left_title_2" style="text-align: left;">
								<asp:Label ID="lblRegist" runat="server" Text="Label"></asp:Label>
							</td>
							<td class="left_title_1" style="text-align: center;">
								登记时间
							</td>
							<td class="left_title_2" style="text-align: left;">
								<asp:Label ID="lblRegistTime" runat="server" Text="Label"></asp:Label>
							</td>
						</tr>
					</tbody>
					<tfoot>
						<tr bgcolor="#FFFFFF">
							<td class="left_title_1" colspan="4" style="text-align: center;">
								<asp:Button ID="btnSubmit" Text="提交" CssClass="input_button" runat="server" OnClick="btnSubmit_Click" />
								<input type="reset" value="清除" class="input_button" />
								<input type="button" value="返回" class="input_button" onclick="window.history.go(-1);"/>
							</td>
						</tr>
					</tfoot>
				</table>
			    </form>
		</div>
	</body>


</html>