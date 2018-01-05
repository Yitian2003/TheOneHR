<%@ Page Language="C#" AutoEventWireup="true" CodeFile="resumeRigster.aspx.cs" Inherits="main_jobManager_resumeManager_ResumeRister" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
<head>

    <title>简历登记</title>

    <meta http-equiv="pragma" content="no-cache">
    <meta http-equiv="cache-control" content="no-cache">
    <meta http-equiv="expires" content="0">
    <meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
    <meta http-equiv="description" content="This is my page">

    <script type="text/javascript" src="/cal/calenderJS.js"></script>
    <link rel="stylesheet" href="/css/common.css"
        type="text/css" />
    <style type="text/css">
        .input_text {
            width: 80px;
        }

        .input_button {
            width: 40px;
        }

        #txtArchiveAge {
            width: 80px;
        }
        #arcArchiveForm {
            height: 2471px;
            margin-bottom: 0px;
        }
    </style>

</head>

<body>
    <div id="man_zone" style="height: auto;">
        <form id="arcArchiveForm" runat="server">
            &nbsp;
				<table border="0" align="center" cellpadding="3"
                    cellspacing="1" class="table_style">
                    <thead>
                        <tr>
                            <td class="left_title_header" colspan="8" style="height: 24px">简历登记
                            </td>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td class="left_title_1" style="text-align: center; width: 158px;">职位分类
                            </td>
                            <td class="left_title_2" style="text-align: left;">
                                <asp:DropDownList ID="ddlPost" runat="server" AppendDataBoundItems="True"
                                    DataSourceID="odsPost" DataTextField="Post_name" DataValueField="Id">
                                    <asp:ListItem Value="-1">请选择</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;
&nbsp;<asp:Label ID="Label2" runat="server" ForeColor="#FF3300" Text="*"></asp:Label>&nbsp;
                                <asp:ObjectDataSource ID="odsPost" runat="server"
                                    SelectMethod="GetAllConfig_posts" TypeName="TheOneHRBLL.Config_postManager"></asp:ObjectDataSource>
                            </td>
                            <td class="left_title_1" style="text-align: center; width: 51px;">职位名称
                            </td>
                            <td class="left_title_2" style="text-align: left; width: 230px;">&nbsp; &nbsp;<asp:DropDownList ID="ddlMajor" runat="server" AppendDataBoundItems="True"
                                DataSourceID="odsMajor" DataTextField="Major_name" DataValueField="Id">
                                <asp:ListItem Value="-1">请选择</asp:ListItem>
                            </asp:DropDownList>&nbsp;
                                <asp:Label ID="Label3" runat="server" ForeColor="#FF3300" Text="*"></asp:Label>
                                <asp:ObjectDataSource ID="odsMajor" runat="server" SelectMethod="GetAllConfig_majors"
                                    TypeName="TheOneHRBLL.Config_majorManager"></asp:ObjectDataSource>
                            </td>
                            <td class="left_title_1" style="text-align: center;">招聘类型</td>
                            <td class="left_title_2" style="text-align: left; width: 6px;">&nbsp;<asp:DropDownList ID="ddlRequestType" runat="server" Width="71px">
                                <asp:ListItem Value="-1">请选择...</asp:ListItem>
                                <asp:ListItem>社会招聘</asp:ListItem>
                                <asp:ListItem>校园招聘</asp:ListItem>
                            </asp:DropDownList></td>
                            <td width="25%" class="left_title_2" style="text-align: center;"
                                colspan="2" rowspan="4">&nbsp;
							    <asp:Image ID="imgPhoto" runat="server" ImageUrl="~/images/Photo/nophoto.jpg" Width="100" Height="100" />
                                <asp:FileUpload ID="fnPhoto" runat="server" />
                            </td>
                        </tr>

                        <tr>
                            <td class="left_title_1" style="text-align: center; width: 158px; height: 26px;">姓名
                            </td>
                            <td class="left_title_2" style="text-align: left; height: 26px;">
                                <input type="text" id="txtResumeName" maxlength="10" value="" runat="server" class="input_text" />
                                <asp:Label ID="Label4" runat="server" ForeColor="#FF3300" Text="*"></asp:Label>
                                &nbsp;</td>
                            <td class="left_title_1" style="text-align: center; width: 51px; height: 26px;">性别
                            </td>
                            <td class="left_title_2" style="text-align: left; width: 230px; height: 26px;">
                                <select name="item.archiveSex">
                                    <option value="男" selected="selected">男</option>
                                    <option value="女">女</option>
                                </select>
                            </td>
                            <td class="left_title_1" style="text-align: center; height: 26px;">Email
                            </td>
                            <td class="left_title_2" style="text-align: left; height: 26px; width: 6px;">
                                <input type="text" name="item.archiveEmail" maxlength="30" value="" class="input_text">
                            </td>
                        </tr>

                        <tr>
                            <td class="left_title_1" style="text-align: center; width: 158px;">电话
                            </td>
                            <td class="left_title_2" style="text-align: left;">
                                <input type="text" name="record.recordTel" maxlength="13" value="" onkeydown="return checkNumkey(this)" class="input_text">
                            </td>
                            <td class="left_title_1" style="text-align: center; width: 51px;">手机
                            </td>
                            <td class="left_title_2" style="text-align: left; width: 230px;">
                                <input type="text" name="item.archiveMobile" maxlength="13" value="" onkeydown="return checkNumkey(this)" class="input_text">
                            <td class="left_title_1" style="text-align: center;">邮编
                            </td>
                            <td class="left_title_2" style="text-align: left; width: 6px;">
                                <input type="text" name="record.recordPostboy" maxlength="6" value="" onkeydown="return checkNumkey(this)" class="input_text">
                            </td>
                        </tr>

                        <tr>
                            <td class="left_title_1" style="text-align: center; width: 158px; height: 31px;">国籍
                            </td>
                            <td class="left_title_2" style="text-align: left; height: 31px;">
                                <asp:DropDownList ID="ddlCountry" runat="server" AppendDataBoundItems="True"
                                    DataSourceID="odsCountry" DataTextField="Country_name" DataValueField="Id">
                                    <asp:ListItem Value="-1">请选择</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;<asp:Label ID="Label5" runat="server" ForeColor="#FF3300" Text="*"></asp:Label>
                                <asp:ObjectDataSource ID="odsCountry" runat="server"
                                    SelectMethod="GetAllConfig_countries" TypeName="TheOneHRBLL.Config_countryManager"></asp:ObjectDataSource>
                            </td>
                            <td class="left_title_1" style="text-align: center; width: 51px; height: 31px;">出生地
                            </td>
                            <td class="left_title_2" style="text-align: left; width: 230px; height: 31px;">
                                <input type="text" name="record.recordHomepalce" maxlength="25" value="" class="input_text">
                            </td>
                            <td class="left_title_1" style="text-align: center; height: 31px;">生日
                            </td>
                            <td class="left_title_2" style="text-align: left; height: 31px; width: 6px;">
                                <input type="text" name="item.archiveBirthday" maxlength="10" value="" onclick="HS_setDate(this)" readonly="readonly" class="input_text">
                            </td>

                        </tr>

                        <tr>
                            <td class="left_title_1" style="text-align: center; width: 158px;">学历
                            </td>
                            <td class="left_title_2" style="text-align: left;">
                                <asp:DropDownList ID="ddlEducation" runat="server" AppendDataBoundItems="True"
                                    DataSourceID="odsEducation" DataTextField="Educated_degree_name"
                                    DataValueField="Id">
                                    <asp:ListItem Value="-1">请选择</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;<asp:Label ID="Label6" runat="server" ForeColor="#FF3300" Text="*"></asp:Label>
                                <asp:ObjectDataSource ID="odsEducation" runat="server"
                                    SelectMethod="GetAllConfig_educated_degrees"
                                    TypeName="TheOneHRBLL.Config_educated_degreeManager"></asp:ObjectDataSource>
                                &nbsp;</td>
                            <td class="left_title_1" style="text-align: center; width: 51px;">宗教信仰
                            </td>
                            <td class="left_title_2" style="text-align: left; width: 230px;">
                                <asp:DropDownList ID="ddlReligion" runat="server" AppendDataBoundItems="True"
                                    DataSourceID="odsReligion" DataTextField="Religion_name" DataValueField="Id">
                                    <asp:ListItem Value="-1">请选择</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="Label7" runat="server" ForeColor="#FF3300" Text="*"></asp:Label>
                                &nbsp;<asp:ObjectDataSource ID="odsReligion" runat="server"
                                    SelectMethod="GetAllConfig_religions" TypeName="TheOneHRBLL.Config_religionManager"></asp:ObjectDataSource>
                            </td>
                            <td class="left_title_1" style="text-align: center;">政治面貌
                            </td>
                            <td class="left_title_2" style="text-align: left; width: 6px;">

                                <select name="polity">
                                    <option value="-1">请选择
                                    </option>
                                    <option value="群众">群众
                                    </option>
                                    <option value="党员">党员
                                    </option>
                                </select>
                            </td>
                            <td class="left_title_1" style="text-align: center;">民族
                            </td>
                            <td class="left_title_2" style="text-align: left;">
                                <asp:DropDownList ID="ddlNation" runat="server" AppendDataBoundItems="True"
                                    DataSourceID="odsNation" DataTextField="Nation_name" DataValueField="Id">
                                    <asp:ListItem Value="-1">请选择</asp:ListItem>
                                </asp:DropDownList>
                                <asp:ObjectDataSource ID="odsNation" runat="server"
                                    SelectMethod="GetAllConfig_nations" TypeName="TheOneHRBLL.Config_nationManager"></asp:ObjectDataSource>
                                <asp:Label ID="Label8" runat="server" ForeColor="#FF3300" Text="*"></asp:Label>
                                &nbsp;</td>
                        </tr>


                        <tr>
                            <td class="left_title_1" style="text-align: center; width: 158px;">身份证号
                            </td>
                            <td class="left_title_2" style="text-align: left;">
                                <input type="text" name="item.archiveCard" maxlength="18" value="" onkeydown="return checkNumkey(this)" class="input_text">
                            </td>
                            <td class="left_title_1" style="text-align: center; width: 51px;">年龄
                            </td>
                            <td class="left_title_2" style="text-align: left; width: 230px;">
                                <input type="text" id="txtArchiveAge" maxlength="2" value="" runat="server" class="input_text" />
                                <asp:Label ID="Label14" runat="server" ForeColor="#FF3300" Text="*"></asp:Label>
                            </td>

                            <td width="12%" class="left_title_1" style="text-align: center;">薪酬要求</td>
                            <td class="left_title_2" style="text-align: left; width: 6px;">&nbsp;<input type="text" id="txtSalary" maxlength="2" value="" runat="server" class="input_text" /></td>
                            <td class="left_title_1" style="text-align: center;">注册时间
                            </td>
                            <td class="left_title_2" style="text-align: left;">
                                <asp:Label ID="lblRegist_time" runat="server" Font-Bold="True"></asp:Label>
                            </td>
                        </tr>

                        <tr>
                            <td class="left_title_1" style="text-align: center; width: 158px; height: 78px;">教育年限
                            </td>
                            <td class="left_title_2" style="text-align: left; height: 78px;">
                                <select name="record.recordEducate">
                                    <option value="-1">请选择</option>
                                    <option value="1">1</option>
                                    <option value="2">2</option>
                                    <option value="3">3</option>
                                    <option value="4">4</option>
                                    <option value="5">5</option>
                                    <option value="6">6</option>
                                    <option value="7">7</option>
                                    <option value="8">8</option>
                                    <option value="9">9</option>
                                    <option value="10">10</option>
                                    <option value="20">20</option>
                                    <option value="30">30</option>
                                </select>
                            </td>
                            <td class="left_title_1" style="text-align: center; width: 51px; height: 78px;">学历专业
                            </td>
                            <td class="left_title_2" style="text-align: left; width: 230px; height: 78px;">
                                <asp:DropDownList ID="ddlSpeciality" runat="server" AppendDataBoundItems="True"
                                    DataSourceID="odsSpeciality" DataTextField="Speciality_name"
                                    DataValueField="Id">
                                    <asp:ListItem Value="-1">请选择</asp:ListItem>
                                </asp:DropDownList>
                                &nbsp;<asp:Label ID="Label9" runat="server" ForeColor="#FF3300" Text="*"></asp:Label>
                                <asp:ObjectDataSource ID="odsSpeciality" runat="server"
                                    SelectMethod="GetAllConfig_specialities"
                                    TypeName="TheOneHRBLL.Config_specialityManager"></asp:ObjectDataSource>
                                &nbsp;</td>
                            <td class="left_title_1" style="text-align: center; height: 78px;">&nbsp;特长</td>
                            <td class="left_title_2" style="text-align: left; width: 6px; height: 78px;">&nbsp;<asp:DropDownList ID="ddlGoodat" runat="server" AppendDataBoundItems="True"
                                DataSourceID="odsGoodate" DataTextField="Goodat_name" DataValueField="Id">
                                <asp:ListItem Value="-1">请选择</asp:ListItem>
                            </asp:DropDownList><asp:Label ID="Label11" runat="server" ForeColor="#FF3300" Text="*"></asp:Label><asp:ObjectDataSource ID="odsGoodate" runat="server"
                                SelectMethod="GetAllConfig_goodats" TypeName="TheOneHRBLL.Config_goodatManager"></asp:ObjectDataSource>
                            </td>
                            <td class="left_title_1" style="text-align: center; height: 78px;">爱好&nbsp;</td>
                            <td class="left_title_2" style="text-align: left; height: 78px;">&nbsp;<select name="record.recordLike">
                                <option value="请选择">请选择</option>
                                <option value="唱歌">唱歌</option>
                                <option value="篮球">篮球</option>
                                <option value="足球">足球</option>
                                <option value="看书">看书</option>
                            </select>&nbsp;
                                <asp:Label ID="Label12" runat="server" ForeColor="#FF3300" Text="*"></asp:Label>

                            </td>
                        </tr>

                        <tr>
                            <td class="left_title_1" style="text-align: center; width: 158px; height: 16px;">住址
                            </td>
                            <td class="left_title_2" style="text-align: left; height: 16px;" colspan="7">
                                <input type="text" name="record.recordAddress" maxlength="50" value="" style="width: 580px;" class="input_text">
                            </td>
                        </tr>
                        <tr>
                            <td class="left_title_1" style="text-align: center; width: 158px;">个人履历
                            </td>
                            <td class="left_title_2" style="text-align: left;" colspan="7">
                                <textarea name="record.recordRec" cols="80" rows="3" class="input_textarea"></textarea>
                            </td>
                        </tr>
                        <tr>
                            <td class="left_title_1" style="text-align: center; width: 158px;">备注
                            </td>
                            <td class="left_title_2" style="text-align: left;" colspan="7">
                                <textarea name="record.recordRemark" cols="80" rows="3" class="input_textarea"></textarea>
                            </td>
                        </tr>
                    </tbody>
                    <tfoot>
                        <tr bgcolor="#FFFFFF">
                            <td class="left_title_1" colspan="8" style="text-align: center;">
                                <asp:Button ID="btnSave" runat="server" CssClass="input_button" Text="提交"
                                    OnClick="btnSave_Click" />
                                <input type="reset" value="重置" class="input_button" />
                            </td>
                        </tr>
                    </tfoot>
                </table>
        </form>
    </div>
</body>

</html>
