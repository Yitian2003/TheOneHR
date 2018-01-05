<%@ Page Language="C#" AutoEventWireup="true" CodeFile="interviewReg.aspx.cs" Inherits="main_jobManager_InterviewManager_interviewReg" %>

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
		<style type="text/css">
			table td{
				font-size:12px;
			}
			.input_text{
				width:80px;
			}
		</style>
		<link rel="stylesheet" href="/css/common.css"
			type="text/css" />
		


		<script type="text/javascript">
		
		function toBack(){
			window.history.go(-1);
			
		}
	
	</script>
	</head>

	<body>

		<form id="engFaceresultForm" runat="server">
            
			<div id="man_zone" style="height: 500px;">
				<table width="99%" border="0" align="center" cellpadding="3"
					cellspacing="1" class="table_style">
					<thead>
						<tr>
							<td class="left_title_header" colspan="8">
								面试登记
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
								<span>
                                    <asp:Label ID="lblMajor" runat="server"></asp:Label></span></td>
							<td width="12%" class="left_title_1" style="text-align: center;">
								招聘类型
							</td>
							<td width="13%" class="left_title_2" style="text-align: left;">
								<span>
                                    <asp:Label ID="lblJobType" runat="server"></asp:Label></span></td>
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
								<span>
                                    <asp:Label ID="lblName" runat="server"></asp:Label></span></td>
							<td class="left_title_1" style="text-align: center;">
								性别
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
								出生地
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span></span>
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
								注册时间
							</td>
							<td class="left_title_2" style="text-align: left;">
								<span>
                                    <asp:Label ID="lblRegTime" runat="server"></asp:Label></span></td>
						</tr>

						
						<tr>
							<td class="left_title_1" style="text-align: center;">
								个人履历
							</td>
							<td class="left_title_2" style="text-align: left;" colspan="7">
								<span></span>
							</td>
						</tr>
						<tr>
							<td class="left_title_1" style="text-align: center;">
								备注
							</td>
							<td class="left_title_2" style="text-align: left;" colspan="7">
								<span></span>
							</td>
						</tr>
						<tr>
							<td class="left_title_1" style="text-align: center;">
								筛选推荐意见
							</td>
							<td class="left_title_2" style="text-align: left;" colspan="7">
								<span>
                                    <asp:Label ID="lblSuggest" runat="server" Width="672px"></asp:Label></span></td>
						</tr>
						
						
						
						<tr>
							<td class="left_title_1" style="text-align: center; height: 34px;">
								面试次数
							</td>
							<td class="left_title_2" style="text-align: left; height: 34px;">
								<span>
                                    <asp:Label ID="lblInterviewCount" runat="server"></asp:Label></span></td>
							<td class="left_title_1" style="text-align: center; height: 34px;">
								形象评价
							</td>
							<td class="left_title_2" style="text-align: left; height: 34px;">
                                <asp:DropDownList ID="ddlimage_degree" runat="server" Width="54px">
                                    <asp:ListItem>A</asp:ListItem>
                                    <asp:ListItem>B</asp:ListItem>
                                    <asp:ListItem>C</asp:ListItem>
                                </asp:DropDownList></td>
							<td class="left_title_1" style="text-align: center; height: 34px;">
								口才评价
							</td>
							<td class="left_title_2" style="text-align: left; height: 34px;">
                                <asp:DropDownList ID="ddlanguage_degree" runat="server" Width="54px">
                                    <asp:ListItem>A</asp:ListItem>
                                    <asp:ListItem>B</asp:ListItem>
                                    <asp:ListItem>C</asp:ListItem>
                                </asp:DropDownList></td>
							<td width="12%" class="left_title_1" style="text-align: center; height: 34px;">
								外语口语能力
							</td>
							<td width="13%" class="left_title_2" style="text-align: left; height: 34px;">
                                <asp:DropDownList ID="ddlforeign_language_degree" runat="server" Width="54px">
                                    <asp:ListItem>A</asp:ListItem>
                                    <asp:ListItem>B</asp:ListItem>
                                    <asp:ListItem>C</asp:ListItem>
                                </asp:DropDownList></td>
						</tr>

						<tr>
							<td class="left_title_1" style="text-align: center;">
								应变能力
							</td>
							<td class="left_title_2" style="text-align: left;">
                                <asp:DropDownList ID="ddlresponse_speed_degree" runat="server" Width="54px">
                                    <asp:ListItem>A</asp:ListItem>
                                    <asp:ListItem>B</asp:ListItem>
                                    <asp:ListItem>C</asp:ListItem>
                                </asp:DropDownList></td>
							<td class="left_title_1" style="text-align: center;">
								EQ
							</td>
							<td class="left_title_2" style="text-align: left;">
                                <asp:DropDownList ID="ddlEQ" runat="server" Width="54px">
                                    <asp:ListItem>A</asp:ListItem>
                                    <asp:ListItem>B</asp:ListItem>
                                    <asp:ListItem>C</asp:ListItem>
                                </asp:DropDownList></td>
							<td class="left_title_1" style="text-align: center;">
								IQ
							</td>
							<td class="left_title_2" style="text-align: left;">
                                <asp:DropDownList ID="ddlIQ" runat="server" Width="54px">
                                    <asp:ListItem>A</asp:ListItem>
                                    <asp:ListItem>B</asp:ListItem>
                                    <asp:ListItem>C</asp:ListItem>
                                </asp:DropDownList></td>
							<td class="left_title_1" style="text-align: center;">
								综合素质
							</td>
							<td class="left_title_2" style="text-align: left;">
                                <asp:DropDownList ID="ddlmulti_quality" runat="server" Width="54px">
                                    <asp:ListItem>A</asp:ListItem>
                                    <asp:ListItem>B</asp:ListItem>
                                    <asp:ListItem>C</asp:ListItem>
                                </asp:DropDownList></td>
						</tr>

						<tr>
							<td class="left_title_1" style="text-align: center; height: 22px;">
								面试人
							</td>
							<td class="left_title_2" style="text-align: left; height: 22px;">
								<span>
                                    <asp:Label ID="lblInterviewer" runat="server"></asp:Label></span></td>
							<td class="left_title_1" style="text-align: center; height: 22px;">
								面试时间
							</td>
							<td class="left_title_2" style="text-align: left; height: 22px;">
								<span>
                                    <asp:Label ID="lblInterviewTime" runat="server"></asp:Label></span></td>
							<td class="left_title_1" style="text-align: center; height: 22px;">
							推荐人
							</td>
							<td class="left_title_2" style="text-align: left; height: 22px;" >
							 <span>
                                 <asp:Label ID="lblChecker" runat="server"></asp:Label></span></td>
							
							<td class="left_title_1" style="text-align: center; height: 22px;">
							推荐时间
							</td>
							<td class="left_title_2" style="text-align: left; height: 22px;">
							<span>
                                <asp:Label ID="lblCheckTime" runat="server"></asp:Label></span></td>
						</tr>
						
						<tr>
							<td class="left_title_1" style="text-align: center;">
								面试评价
							</td>
							<td class="left_title_2" style="text-align: left;" colspan="7">
								<textarea id="txtSuggest" cols="80" rows="3" class="input_textarea" runat="server" ></textarea>
							</td>
						</tr>
						
						
					</tbody>
					<tfoot>
						<tr bgcolor="#FFFFFF">
							<td class="left_title_footer" colspan="8"
								style="text-align: center;">
                                &nbsp;<asp:Button ID="btnSubmit" runat="server" Text="提交" CssClass="input_button" OnClick="btnSubmit_Click"  />
								<input type="reset" value="清除" class="input_button" />
							</td>
						</tr>
					</tfoot>
				</table>
			</div>
		</form>

	</body>
</html>
