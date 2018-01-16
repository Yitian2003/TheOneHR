<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<html>

	<head>
        <%--<--!-->--%>
		<title>人力资源管理系统</title>
		<%--<script type="text/javascript">
		function doLogin(){
			document.forms[0].submit();
		}
		
		//清除表单的值
		function doClear(){
			document.forms[0].reset();
			document.getElementsByName("sysUser.userLoginName")[0].focus();
		}
		</script>--%>
		<script type='text/javascript'
			src='/TheOneHR/dwr/interface/JSysUser.js'></script>
		<script type='text/javascript' src='/TheOneHR/dwr/engine.js'></script>
		<script type='text/javascript' src='/TheOneHR/dwr/util.js'></script>
		<META content="MSHTML 6.00.6000.16705" name=GENERATOR>
		<style type="text/css">
		TD {
			FONT-SIZE: 11px; COLOR: #000000; FONT-FAMILY: Verdana, Arial, Helvetica, sans-serIf; TEXT-DECORATION: none
		}
		.input_1 {
			BORDER-RIGHT: #999999 1px solid; PADDING-RIGHT: 2px; BORDER-TOP: #999999 1px solid; PADDING-LEFT: 2px; LIST-STYLE-POSITION: inside; FONT-SIZE: 12px; PADDING-BOTTOM: 2px; MARGIN-LEFT: 10px; BORDER-LEFT: #999999 1px solid; COLOR: #333333; PADDING-TOP: 2px; BORDER-BOTTOM: #999999 1px solid; FONT-FAMILY: Arial, Helvetica, sans-serIf; LIST-STYLE-TYPE: none; HEIGHT: 18px; BACKGROUND-COLOR: #dadedf
		}
		</style>

	</head>

	<BODY>
		<TABLE cellSpacing="0" cellPadding="0" width="651" align="center"
			border="0">
			<TBODY>
				<TR>
					<TD height="50"></TD>
				</TR>
				<TR>
					<TD height="351">
						<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TBODY>
								<TR>
									<TD width="15" background="/images/login/ileft.gif" height="43"></TD>
									<TD width="620" background="/images/login/i_topbg2.gif"><IMG height="43" src="/images/login/i_top1.gif" width="43"></TD>
									<TD width="16"><IMG height="43" src="/images/login/iright.gif" width="16"></TD>
								</TR>
								<TR>
									<TD background="/images/login/ileftbg.gif"></TD>
									<TD vAlign="middle" background="/images/login/bg.gif"
										height="279">
										<TABLE height="109" cellSpacing="0" cellPadding="0"
											width="369" align="center" border="0">
											<TBODY>
												<TR>
													<TD width="155">
														<IMG height="140" src="/images/login/logo.jpg" width="155"
															border="0" id="logoImg">
													</TD>
													<TD vAlign="top" align="left" width="214">
														<TABLE cellSpacing="0" cellPadding="0" width="197"
															border="0" align="left">
															<TBODY>
																<TR>
																	<TD vAlign="bottom" width="197" height="30">
																		<IMG height="19" src="/images/login/adminsyteam.gif"
																			width="154" border="0">
																	</TD>
																</TR>
																<TR>
																	<TD height="123">
																		<TABLE height="109" cellSpacing="0" cellPadding="0"
																			align="center" border="0">


																			
																			<form id="sysUserForm" runat="server">
																				<input type="hidden" name="op" value="doLogin" />
																				
																				<TR>
																					<TD vAlign="bottom" align="left" width="44"
																						height="28">
																						<DIV align="right">
																							<IMG height="14" src="/images/login/id.gif"
																								width="43">
																						</DIV>
																					</TD>
																					<TD vAlign="bottom" align="left" width="144"
																						height="28">
																						<input type="text" id="txtUser" maxlength="8" size="15" value="" class="input_1" runat="server">
																					</TD>
																				</TR>
																				<TR>
																					<TD align="left" height="20">
																						<DIV align="right">
																							<IMG height="14" src="/images/login/pass.gif"
																								width="43">
																						</DIV>
																					</TD>
																					<TD height="20">
																						<input type="password" id="txtPwd" maxlength="16" size="15" value="" class="input_1" runat="server">
																					</TD>
																				</TR>
																				<TR>
																					<TD vAlign="middle" colSpan="2" height="25">
																						<DIV align="left">
																							<%--<img src="/images/login/b_login.gif" style="cursor:hand;height:21px;width:73px;" onclick="formSubmit();">--%>
																							<asp:ImageButton ID="btnLogin" runat="server" ImageUrl="/images/login/b_login.gif" style="cursor:hand;height:21px;width:73px;" OnClick="btnLogin_Click" />
                                                                                            <asp:ImageButton ID="btnReset" runat="server" ImageUrl="/images/login/b_clean.gif" style="cursor:hand;height:21px;width:73px;" />
                                                                                            <%--<img src="/images/login/b_clean.gif" style="cursor:hand;height:21px;width:73px;" onclick="doClear()">--%>
																						</DIV>
																					</TD>
																				</TR>
																			</form>
																			
																		</TABLE>
																	</TD>
																</TR>
															</TBODY>
														</TABLE>
													</TD>
												</TR>
											</TBODY>
										</TABLE>
									</TD>
									<TD background="/images/login/irightbg.gif"></TD>
								</TR>
								<TR>
									<TD><IMG height="29" src="/images/login/i_bottom_left.gif"
											width="15"></TD>
									<TD background="/images/login/i_bottom_bg.gif"></TD>
									<TD width="16"><IMG height="29" src="/images/login/i_bottom_right.gif"
											width="16"></TD>
								</TR>
							</TBODY>
						</TABLE>
					</TD>
				</TR>
				<TR>
					<TD height="1"></TD>
				</TR>
				<TR>
					<TD background="/images/login/footer.gif" height="49">
						&nbsp;
					</TD>
				</TR>
			</TBODY>
		</TABLE>
	</BODY>
	<%--<script type="text/javascript">
	window.onload=function(){
		document.getElementsByName("sysUser.userLoginName")[0].focus();
	}	
	</script>
	<script type="text/javascript" src="/Web/js/validate2.js"></script>
	<script type="text/javascript">
	build_validate("sysUser.userLoginName","","WkCENString");
	build_validate("sysUser.userPassword","","WkENString");
	var oSrc;
	var boolFlage = false;;
	//提交到ajax验证
	function formSubmit() {
	    location.href = "/Web/main/test.jsp.htm";
//		if(jsCheckForm()){
//			var oName = document.getElementsByName("sysUser.userLoginName")[0];
//			var oPass = document.getElementsByName("sysUser.userPassword")[0];
//			if(oName&&oPass){
//				boolFlage=true;//发送数据到服务端,不给用户继续点击
//				checkLoginName(oName.value,oPass.value);
//			}
//		}
	}
	//使用JS验证表单是否为空
	function jsCheckForm(){
		if(boolFlage){//若不给用户继续点击,则返回
			return;
		}
		if (Validator.Validate(document.forms[0],3))
			return true;
		return false;
	}
	//调用dwr验证用户名是否存在
	function checkLoginName(oName,oPass){
		var oImg = logoImg;
		oSrc = oImg.src;
		oImg.src="/Web/images/login/doit.gif";//设置一个会动的图片
		//alert(JSysUser);
		//alert(1);
		JSysUser.checkName(oName,oPass,callback);
	}
	//处理
	function callback(data){
		boolFlage=false;//给用户继续提交的权力
		if(data==false){
			alert('用户名或密码不正确!');
			var oImg = logoImg;
			oImg.src=oSrc;
			document.getElementsByName("sysUser.userLoginName")[0].focus();
			return false;
		}
		document.forms[0].submit();
		
	}
	function doOnKeyDown(){
		if(event.keyCode==13){
			formSubmit();
		}
	}
	</script>--%>
</html>