<%@ Page Language="C#" AutoEventWireup="true" CodeFile="interviewConfirm.aspx.cs" Inherits="main_jobManager_interviewManager_interviewConfirm" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>

	<head>

		<title>面试登记</title>

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
			.input_text{
				width:80px;
			}
		    .auto-style1 {
                color: #73938E;
                font-weight: bold;
                line-height: 20px;
                text-align: right;
                font-size: 11px;
                height: 27px;
                background-color: #F3F8F7;
            }
            .auto-style2 {
                color: #73938E;
                font-weight: bold;
                line-height: 20px;
                text-align: right;
                font-size: 11px;
                height: 27px;
                background-color: #fff;
            }
		</style>
		<link rel="stylesheet" href="/css/common.css"
			type="text/css" />
	</head>

	<body>

		<form id="engResumehandleForm" runat="server">
			
			
			<div id="man_zone" style="height: 637px;">
				<table width="99%" border="0" align="center" cellpadding="3"
					cellspacing="1" class="table_style">
					<thead>
						<tr>
							<td class="left_title_header" colspan="8">
								面试审核
							</td>
						</tr>
					</thead>
					<tbody>
						<tr>
							<td width="12%" class="left_title_1" style="text-align: center;">
								职位类型
							</td>
							<td width="13%" class="left_title_2" style="text-align: left;">
								<span>软件编程</span>
							</td>
							<td width="12%" class="left_title_1" style="text-align: center;">
								职位名称
							</td>
							<td width="13%" class="left_title_2" style="text-align: left;">
								<asp:Label ID="lblMajor" runat="server" Text="Label"></asp:Label>
							</td>
							<td width="12%" class="left_title_1" style="text-align: center;">
								招聘类型
							</td>
							<td width="13%" class="left_title_2" style="text-align: left;">
								<asp:Label ID="lblJobType" runat="server" Text="Label"></asp:Label>
							</td>
							<td width="25%" class="left_title_2" style="text-align: center;"
								colspan="2" rowspan="4">
								<img id="showImg" style="width: 100px;height: 100px"
									 src="/pic/null">
							</td>
						</tr>

						<tr>
							<td class="left_title_1" style="text-align: center;">
								姓名
							</td>
							<td class="left_title_2" style="text-align: left;">
								<asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
							</td>
							<td class="left_title_1" style="text-align: center;">
								性别
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span>?</span>
							</td>
							<td class="left_title_1" style="text-align: center;">
								生日
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span>1989-10-10</span>
							</td>
						</tr>

						<tr>
							<td class="left_title_1" style="text-align: center;">
								民族
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span>?</span>
							</td>
							<td class="left_title_1" style="text-align: center;">
								宗教信仰
							</td>
							<td class="left_title_2" style="text-align: left;">
								<asp:Label ID="lblReligion" runat="server" Text="Label"></asp:Label>
							</td>
							<td class="left_title_1" style="text-align: center;">
								政治面貌
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span>??</span>
							</td>
						</tr>

						<tr>
							<td class="left_title_1" style="text-align: center;">
								身份证号码
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span>123456789011111</span>
							</td>
							<td class="left_title_1" style="text-align: center;">
								年龄
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span>20</span>
							</td>
							<td class="left_title_1" style="text-align: center;">
								出生地
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span>xxx</span>
							</td>
						</tr>

						<tr>
							<td class="left_title_1" style="text-align: center;">
								教育年限
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span>4</span>
							</td>
							<td class="left_title_1" style="text-align: center;">
								学历专业
							</td>
							<td class="left_title_2" style="text-align: left;">
								<asp:Label ID="lblSpecial" runat="server" Text="Label"></asp:Label>
							</td>
							<td class="left_title_1" style="text-align: center;">
								薪酬要求
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span>2000</span>
							</td>
							<td class="left_title_1" style="text-align: center;">
								注册时间
							</td>
							<td class="left_title_2" style="text-align: left;">
								<asp:Label ID="lblRegistTime" runat="server" Text="Label"></asp:Label>
&nbsp;</td>
						</tr>

						
						<tr>
							<td class="left_title_1" style="text-align: center;">
								个人履历
							</td>
							<td class="left_title_2" style="text-align: left;" colspan="7">
								<textarea rows="3" cols="80" class="input_textarea2" readonly="readonly" >sss</textarea>
							</td>
						</tr>
						<tr>
							<td class="left_title_1" style="text-align: center;">
								备注
							</td>
							<td class="left_title_2" style="text-align: left;" colspan="7">
								<textarea rows="3" cols="80" class="input_textarea2" readonly="readonly" >sss</textarea>
							</td>
						</tr>
							<tr>
							<td class="left_title_1" style="text-align: center;">
								面试评价
							</td>
							<td class="left_title_2" style="text-align: left;" colspan="7">
								<textarea name="engFaceresult.faceAppraise" cols="80" rows="3" readonly="readonly" class="input_textarea2">Very Good</textarea>
							</td>
						</tr>
						
						
						
						<tr>
							<td class="left_title_1" style="text-align: center;">
								面试次数
							</td>
							<td class="left_title_2" style="text-align: left;">
								<asp:Label ID="lblInterviewCount" runat="server" Text="Label"></asp:Label>
							</td>
							<td class="left_title_1" style="text-align: center;">
								形象评价
							</td>
							<td class="left_title_2" style="text-align: left;">
								<asp:Label ID="lblImageDegree" runat="server" Text="Label"></asp:Label>
							</td>
							<td class="left_title_1" style="text-align: center;">
								口才评价
							</td>
							<td class="left_title_2" style="text-align: left;">
								<asp:Label ID="lblNativeLan" runat="server" Text="Label"></asp:Label>
							</td>
							<td width="12%" class="left_title_1" style="text-align: center;">
								外语口语能力
							</td>
							<td width="13%" class="left_title_2" style="text-align: left;">
								<asp:Label ID="lblForeignLan" runat="server" Text="Label"></asp:Label>
							</td>
						</tr>

						<tr>
							<td class="auto-style1" style="text-align: center;">
								应变能力
							</td>
							<td class="auto-style2" style="text-align: left;">
							    <asp:Label ID="lblResponse" runat="server" Text="Label"></asp:Label>
							</td>
							<td class="auto-style1" style="text-align: center;">
								EQ
							</td>
							<td class="auto-style2" style="text-align: left;">
								<asp:Label ID="lblEq" runat="server" Text="Label"></asp:Label>
							</td>
							<td class="auto-style1" style="text-align: center;">
								IQ
							</td>
							<td class="auto-style2" style="text-align: left;">
								<asp:Label ID="lblIq" runat="server" Text="Label"></asp:Label>
							</td>
							<td class="auto-style1" style="text-align: center;">
								综合素质
							</td>
							<td class="auto-style2" style="text-align: left;">
								<asp:Label ID="lblMulti" runat="server" Text="Label"></asp:Label>
							</td>
						</tr>

						<tr>
							<td class="left_title_1" style="text-align: center;">
								面试人
							</td>
							<td class="left_title_2" style="text-align: left;">
								<asp:Label ID="lblInterviewer" runat="server" Text="Label"></asp:Label>
							</td>
							<td class="left_title_1" style="text-align: center;">
								面试时间
							</td>
							<td class="left_title_2" style="text-align: left;">
								<asp:Label ID="lblInterviewTime" runat="server" Text="Label"></asp:Label>
							</td>
							<td class="left_title_1" style="text-align: center;">
							推荐人
							</td>
							<td class="left_title_2" style="text-align: left;" >
							    <asp:Label ID="lblChecker" runat="server" Text="Label"></asp:Label>
							</td>
							
							<td class="left_title_1" style="text-align: center;">
							推荐时间
							</td>
							<td class="left_title_2" style="text-align: left;">
							    <asp:Label ID="lblCheckTime" runat="server" Text="Label"></asp:Label>
							</td>
						</tr>
						<tr>
							<td class="left_title_1" style="text-align: center;">
								筛选推荐意见
							</td>
							<td class="left_title_2" style="text-align: left;" colspan="7">
								<textarea name="handleAuditing" cols="80" rows="3" class="input_textarea"></textarea>
							<div id="timeErro" style="position:absolute;display: none"  ><font color="red">限长度为200</font></div>
							</td>
						</tr>
						<tr>
							<td class="left_title_1" style="text-align: center;" colspan="8">
								<asp:RadioButtonList ID="rdSuggest" runat="server" RepeatDirection="Horizontal" Width="454px">
                                    <asp:ListItem Value="1">建议面试</asp:ListItem>
                                    <asp:ListItem Selected="True" Value="2">建议笔试</asp:ListItem>
                                    <asp:ListItem Value="3">建议录用</asp:ListItem>
                                    <asp:ListItem Value="-1">删除简历</asp:ListItem>
                                </asp:RadioButtonList>
							</td>
							
						</tr>
					
						
					</tbody>
					<tfoot>
						<tr bgcolor="#FFFFFF">
							<td class="left_title_footer" colspan="8"
								style="text-align: center;">
                                <asp:Button ID="btnSubmit" Text="提交" CssClass="input_button" runat="server" OnClick="btnSubmit_Click" />
                                    								
								<input type="button" value="返回" class="input_button" onclick="window.history.go(-1);"/>
							</td>
						</tr>
					</tfoot>
				</table>
			</div>
		</form>
	</body>

</html>