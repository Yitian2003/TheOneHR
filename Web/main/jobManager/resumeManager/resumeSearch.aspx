<%@ Page Language="C#" AutoEventWireup="true" CodeFile="resumeSearch.aspx.cs" Inherits="main_jobManager_resumeManager_resumeSearch" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
	<head>
		<title>简历查询</title>
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
		<script type="text/javascript" src="/Web/cal/calenderJS.js"></script>
		<style type="text/css">
			table td{
				font-size:12px;
			}
			.inputText{
				width:80px;
			}
		</style>
	</head>

	<body>
		<div id="man_zone">
			<form id="engResumeForm" runat="server">
                <table width="99%" border="0" align="center" cellpadding="3"
					cellspacing="1" class="table_style">
					<thead>
						<tr>
							<td class="left_title_header" colspan="4">
								简历查询
							</td>
						</tr>
					</thead>
					<tbody>
						<tr>
							<td width="25%" class="left_title_2" style="text-align: center;"
								rowspan="2">
								职位分类
							</td>
							<td width="25%" class="left_title_2" style="text-align: left;">
								职位类型
							</td>
							<td width="25%" class="left_title_2" style="text-align: left;">
								职位名称
							</td>
							<td width="25%" class="left_title_2" style="text-align: left;">
								简历状态
							</td>
							
						</tr>
						<tr>
							<td class="left_title_2" style="text-align: left;">
                                <asp:DropDownList ID="ddlPost" runat="server" AppendDataBoundItems="True" DataSourceID="odsPost"
                                    DataTextField="Post_name" DataValueField="Id">
                                    <asp:ListItem Value="-1">请选择</asp:ListItem>
                                </asp:DropDownList><asp:ObjectDataSource ID="odsPost" runat="server" SelectMethod="GetAllConfig_posts"
                                    TypeName="TheOneHRBLL.Config_postManager"></asp:ObjectDataSource>
							</td>
							<td class="left_title_2" style="text-align: left;">
                                &nbsp;<asp:DropDownList ID="ddlMajor" runat="server" AppendDataBoundItems="True"
                                    DataSourceID="odsMajor" DataTextField="Major_name" DataValueField="Id">
                                    <asp:ListItem Value="-1">请选择</asp:ListItem>
                                </asp:DropDownList><asp:ObjectDataSource ID="odsMajor" runat="server" SelectMethod="GetAllConfig_majors"
                                    TypeName="TheOneHRBLL.Config_majorManager"></asp:ObjectDataSource>
							</td>
							<td class="left_title_2" style="text-align: left;">
                                <asp:DropDownList ID="ddlintreviewStatus" runat="server">
                                    <asp:ListItem Value="-1">请选择...</asp:ListItem>
                                    <asp:ListItem Value="-2">简历初审</asp:ListItem>
                                    <asp:ListItem Value="1">面试登记</asp:ListItem>
                                    <asp:ListItem Value="2">待笔试</asp:ListItem>
                                    <asp:ListItem Value="9">面试待审</asp:ListItem>
                                    <asp:ListItem Value="5">笔试待审</asp:ListItem>
                                    <asp:ListItem Value="3">推荐录用</asp:ListItem>
                                    <asp:ListItem Value="4">录用申请</asp:ListItem>
                                    <asp:ListItem Value="6">已录用</asp:ListItem>
                                    <asp:ListItem Value="7">未录用</asp:ListItem>
                                    <asp:ListItem Value="8">待清除</asp:ListItem>
                                    <asp:ListItem Value="10">已登记</asp:ListItem>
                                </asp:DropDownList></td>
						</tr>
						<tr>
							<td class="left_title_2" style="text-align: center; height: 29px;">
								关键字
							</td>
							<td class="left_title_2" style="text-align: left; height: 29px;" colspan="3">
                                <asp:TextBox ID="txtKey" runat="server" Width="279px"></asp:TextBox></td>
						</tr>
						
		
						
						<tr>
							<td class="left_title_2" style="text-align: center;">
								登记时间
							</td>
							<td class="left_title_2" style="text-align: left;">
                                <input id="beginTime" runat="server" class="input_text" onclick="HS_setDate(this);"
                                    readonly="readonly" type="text" /></td>
							<td class="left_title_2" style="text-align: left;" colspan="2">
                                &nbsp;<input id="endTime" runat="server" class="input_text" onclick="HS_setDate(this);"
                                    readonly="readonly" type="text" />
							</td>
						</tr>
					</tbody>
					<tfoot>
						<tr bgcolor="#FFFFFF">
							<td class="left_title_1" colspan="4" style="text-align: center;">
                                &nbsp;<asp:Button ID="btnSearch" runat="server" CssClass="input_button" Text="查询" OnClick="btnSearch_Click" />
								<input type="reset" value="清除"  class="input_button" /></td>
						</tr>
					</tfoot>
				</table>
				<br />
                <asp:GridView ID="gvResume" runat="server" align="center" AllowPaging="True" AutoGenerateColumns="False"
                    CssClass="GridView"  PageSize="5" Width="99%" DataSourceID="odsResume" OnRowDataBound="gvResume_RowDataBound">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="序号" SortExpression="Id" />
                        <asp:BoundField DataField="Human_name" HeaderText="姓名" SortExpression="Human_name" />
                        <asp:BoundField DataField="Human_sex" HeaderText="性别" SortExpression="Human_sex" />
                        <asp:TemplateField HeaderText="专业" SortExpression="Cs_no">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Cs_no") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("Cs_no.Speciality_name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="特长" SortExpression="Cg_no">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Cg_no") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("Cg_no.Goodat_name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="学历" SortExpression="Ced_no">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Ced_no") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("Ced_no.Educated_degree_name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="应聘职位" SortExpression="Emr_no">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Emr_no") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label4" runat="server" Text='<%# Eval("Emr_no.Cm.Major_name") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="Demand_salary_standard" HeaderText="薪酬要求"
                            SortExpression="Demand_salary_standard" />
                        <asp:BoundField DataField="Regist_time" HeaderText="登记时间" SortExpression="Regist_time" DataFormatString="{0:d}" />
                        <asp:TemplateField HeaderText="审核状态">
                            <ItemTemplate>
                                &nbsp;<asp:LinkButton ID="linkModify" runat="server" CommandArgument='<%# Eval("Id") %>'
                                    OnCommand="linkModify_Command" Text='<%# GetResumStatus(Eval("Interview_status")) %>'></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>

                </asp:GridView>
                <asp:ObjectDataSource ID="odsResume" runat="server" SelectMethod="ResumeAdvSearch"
                    TypeName="TheOneHRBLL.Engage_resumeManager">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="-1" Name="majorid" Type="Int32" />
                        <asp:Parameter DefaultValue="-1" Name="resumestatus" Type="Int32" />
                        <asp:Parameter DefaultValue="" Name="key" Type="String" />
                        <asp:Parameter Name="beginTime" Type="String" />
                        <asp:Parameter Name="endTime" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
			</form>
		</div>
</body>

</html>
