<%@ Page Language="C#" AutoEventWireup="true" CodeFile="examTestBuild.aspx.cs" Inherits="main_jobManager_examTestManager_examTestBuild" %>

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
		<div id="man_zone">
		    <form id="form1" runat="server">
            &nbsp;<table width="70%" border="0" align="center" cellpadding="3"
				cellspacing="1" class="table_style">
				<thead>
					<tr>
						<td class="left_title_header" colspan="4">
							考试出题
						</td>
					</tr>
				</thead>
				<tbody>
					<tr>
						<td width="25%" class="left_title_1" style="text-align: center;">
							职位分类
						</td>
						<td width="25%" class="left_title_2" style="text-align: center;">
							<asp:Label ID="lblMajorKind" runat="server" Text="Label"></asp:Label>
						</td>
						<td width="25%" class="left_title_1" style="text-align: center;">
							职位名称
						</td>
						<td width="25%" class="left_title_2" style="text-align: center;">
							<asp:Label ID="lblMajorName" runat="server" Text="Label"></asp:Label>
						</td>
					</tr>
					<tr>
						<td width="25%" class="left_title_1" style="text-align: center;">
							登记
						</td>
						<td width="25%" class="left_title_2" style="text-align: center;">
							<asp:Label ID="lblRegister" runat="server" Text="Label"></asp:Label>
						</td>
						<td width="25%" class="left_title_1" style="text-align: center;">
							登记时间
						</td>
						<td width="25%" class="left_title_2" style="text-align: center;">
							<asp:Label ID="lblRegTime" runat="server" Text="Label"></asp:Label>
						</td>
					</tr>
				</tbody>
			</table>
			<br />
			<asp:GridView ID="gvExamDetail" Width="99%"  runat="server" AutoGenerateColumns="False" DataSourceID="odsSubject" HorizontalAlign="Center" align="center">
                <Columns>
                    <asp:BoundField DataField="First_kind_name" HeaderText="I级分类" />
                    <asp:BoundField DataField="Second_kind_name" HeaderText="II级分类" />
                    <asp:BoundField DataField="Number" HeaderText="可用试题数量" />
                    <asp:TemplateField HeaderText="出题数量">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:TextBox ID="txtNumber" runat="server" CssClass="input_text"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

			</asp:GridView>
			    <asp:ObjectDataSource ID="odsSubject" runat="server" SelectMethod="GetEngageSubjectList" TypeName="TheOneHRBLL.Engage_subjectManager"></asp:ObjectDataSource>
			<table width="99%" border="0" align="center" cellpadding="3"
				cellspacing="1" class="table_style">
				
				<tbody>					
					<tr>
						<td width="25%" class="left_title_2" style="text-align: center;">
							&nbsp;
						</td>
						<td width="25%" class="left_title_1" style="text-align: center;">
							答题限时(分钟)
						</td>
						<td width="25%" class="left_title_2" style="text-align: center;">
							<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;</td>
						<td width="25%" class="left_title_2" style="text-align: center;">
							&nbsp;
						</td>
					</tr>
				</tbody>
				<tfoot>
					<tr bgcolor="#FFFFFF">
						<td class="left_title_1" colspan="4" style="text-align: center;">
							<asp:Button Text="出卷" ID="btnSubmit" runat="server" CssClass="input_button" OnClick="btnSubmit_Click" />
                       		<input type="button" value="返回" onclick="window.history.go(-1);" class="input_button"/>
						</td>
					</tr>
				</tfoot>
			</table>
			</form>
		</div>
	</body>

</html>
