<%@ Page Language="C#" AutoEventWireup="true" CodeFile="resumeConfirm.aspx.cs" Inherits="main_jobManager_resumeManager_resumeConfirm" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>

	<head>

		<title>简历初审</title>

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
		<style type="text/css">
			table td{
				font-size:12px;
			}
			.inputText{
				width:80px;
			}
		</style>
		<link rel="stylesheet" href="/css/common.css"
			type="text/css" />
	</head>

	<body>

<form id="engResumehandleForm" runat="server">
			<div id="man_zone" style="height: 500px;">
				<table width="99%" border="0" align="center" cellpadding="3"
					cellspacing="1" class="table_style">
					<thead>
						<tr>
							<td class="left_title_header" colspan="8">
								简历初审
							</td>
						</tr>
					</thead>
					<tbody>
						<tr>
							<td width="12%" class="left_title_1" style="text-align: center;">
								职位类型
							</td>
							<td width="13%" class="left_title_2" style="text-align: left;">
								<span></span>
							</td>
							<td width="12%" class="left_title_1" style="text-align: center;">
								职位名称
							</td>
							<td width="13%" class="left_title_2" style="text-align: left;">
								<span></span>
                                <asp:Label ID="lblMajor" runat="server"></asp:Label>
							</td>
							<td width="12%" class="left_title_1" style="text-align: center;">
								招聘类型
							</td>
							<td width="13%" class="left_title_2" style="text-align: left;">
								<span>
                                    <asp:Label ID="lblJobType" runat="server"></asp:Label></span></td>
							<td width="25%" class="left_title_2" style="text-align: center;"
								colspan="2" rowspan="4">
								<img id="showImg" style="width: 100px;height: 100px"
									 src="/pic/091030101845593.jpg">
							</td>
						</tr>

						<tr>
							<td class="left_title_1" style="text-align: center;">
								姓名
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span>
                                    <asp:Label ID="lblName" runat="server"></asp:Label></span></td>
							<td class="left_title_1" style="text-align: center;">
								性别
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span></span>
							</td>
							<td class="left_title_1" style="text-align: center;">
								EMAIL
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span></span>
							</td>
						</tr>

						<tr>
							<td class="left_title_1" style="text-align: center;">
								电话
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span></span>
							</td>
							<td class="left_title_1" style="text-align: center;">
								手机
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span></span>
							</td>
							<td class="left_title_1" style="text-align: center;">
								邮编
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span></span>
							</td>
						</tr>

						<tr>
							<td class="left_title_1" style="text-align: center;">
								国籍
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span>
                                    <asp:Label ID="lblCoun" runat="server"></asp:Label></span></td>
							<td class="left_title_1" style="text-align: center;">
								出生地
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span></span>
							</td>
							<td class="left_title_1" style="text-align: center;">
								生日
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span></span>
							</td>
						</tr>

						<tr>
							<td class="left_title_1" style="text-align: center;">
								民族
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span></span>
							</td>
							<td class="left_title_1" style="text-align: center;">
								宗教信仰
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span>
                                    <asp:Label ID="lblregine" runat="server"></asp:Label></span></td>
							<td class="left_title_1" style="text-align: center;">
								政治面貌
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span></span>
							</td>
							<td class="left_title_1" style="text-align: center;">
								注册时间
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span>
                                    <asp:Label ID="lblRegTime" runat="server"></asp:Label></span></td>
						</tr>


						
						<tr>
							<td class="left_title_1" style="text-align: center;">
								身份证号码
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span></span>
							</td>
							<td class="left_title_1" style="text-align: center;">
								年龄
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span></span>
							</td>
							<td class="left_title_1" style="text-align: center;">
								毕业学校
							</td>
							<td class="left_title_2" style="text-align: left;">
							</td>
							<td class="left_title_1" style="text-align: center;">
								学历
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span>
                                    <asp:Label ID="lbleducation" runat="server"></asp:Label></span>
							</td>
						</tr>


						
						<tr>
							<td class="left_title_1" style="text-align: center;">
								教育年限
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span></span>
							</td>
							<td class="left_title_1" style="text-align: center;">
								学历专业
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span>
                                    <asp:Label ID="lblspecial" runat="server"></asp:Label></span></td>
							<td class="left_title_1" style="text-align: center;">
								薪酬要求
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span></span>
							</td>
							<td class="left_title_1" style="text-align: center;">
								审核时间
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span>
                                    <asp:Label ID="lblConfirmTime" runat="server"></asp:Label></span></td>
						</tr>

						<tr>
						<td class="left_title_1" style="text-align: center; height: 20px;">
								特长
							</td>
							<td class="left_title_2" style="text-align: left; height: 20px;">
							<span></span>
							</td>
							<td class="left_title_1" style="text-align: center; height: 20px;">
								爱好
							</td>
							<td class="left_title_2" style="text-align: left; height: 20px;">
								<span></span>
							</td>
							<td class="left_title_1" style="text-align: center; height: 20px;">
								住址
							</td>
							<td class="left_title_2" style="text-align: left; height: 20px;" colspan="4">
								<span></span>
							</td>
						</tr>


						
						<tr>
							<td class="left_title_1" style="text-align: center;">
								个人履历
							</td>
							<td class="left_title_2" style="text-align: left;" colspan="7">

								<textarea rows="3" cols="80" class="input_textarea" readonly="readonly" ></textarea>

							</td>
						</tr>
						<tr>
							<td class="left_title_1" style="text-align: center; height: 59px;">
								备注
							</td>
							<td class="left_title_2" style="text-align: left; height: 59px;" colspan="7">

								<textarea rows="3" cols="80" class="input_textarea" readonly="readonly" ></textarea>

							</td>
						</tr>
							<tr>
							<td class="left_title_1" style="text-align: center;">
								筛选推荐意见
							</td>
							<td class="left_title_2" style="text-align: left;" colspan="7">
								<textarea name="engResumehandle.resHandleAttitude" cols="80" rows="3" class="input_textarea" id="txtSuggest" runat="server"></textarea>
							</td>
						</tr>
						<tr>
							<td class="left_title_1" style="text-align: center;" colspan="4" >
                                <asp:RadioButton ID="rdOK" runat="server" Text="建议面试" Checked="True" GroupName="rdIntreview" /></td>
							<td class="left_title_1" style="text-align: left;" colspan="4">
                                <asp:RadioButton ID="rdNo" runat="server" Text="删除简历" GroupName="rdIntreview" /></td>
						</tr>
						
						
						
					</tbody>
					<tfoot>
						<tr bgcolor="#FFFFFF">
							<td class="left_title_footer" colspan="8"
								style="text-align: center;">
								<input type="button" value="提交" class="input_button" id="btnSubmit" runat="server" onserverclick="btnSubmit_ServerClick"/>
								<input type="button" value="返回" class="input_button" onclick="window.history.go(-1);"/>
							</td>
						</tr>
					</tfoot>
				</table>
			</div>
		</form>
	</body>


</html>

