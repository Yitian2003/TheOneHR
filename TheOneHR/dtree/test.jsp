<%@ page language="java" pageEncoding="GBK"
	contentType="text/html; charset=GBK" isELIgnored="false"%>
<%@ page import="java.util.*"%>
<%@ taglib prefix="html" uri="/WEB-INF/struts-html.tld"%>
<%@ taglib prefix="logic" uri="/WEB-INF/struts-logic.tld"%>
<%@ taglib prefix="bean" uri="/WEB-INF/struts-bean.tld"%>
<%
	//============================================================
	// Author:Wk
	// Date:
	// Description:
	//============================================================
%>
<%
	StringBuffer sb = new StringBuffer(request.getScheme());
	sb.append("://");
	sb.append(request.getServerName());
	sb.append(":");
	sb.append(request.getServerPort());
	sb.append(request.getContextPath());
	sb.append("/");
	pageContext.setAttribute("basePath", sb.toString());
	request.setCharacterEncoding("GBK");
	response.setContentType("text/html;charset=GBK;");
%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>

	<head>

		<title>test.jsp</title>

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
		<link href="${basePath }dtree/dtree.css" type="text/css">
		<script type="text/javascript" src="${basePath }dtree/dtree.js"></script>

	</head>

	<body>
		<script language="javascript">
d = new dTree('d','.','testForm');
d.add('0','-1','基金');
d.add('0401','0','基金市场类');
d.add('040101','0401','上证封闭式基金','javascript:gotoUrl("blockcode=040101&blocktype=6");');
d.add('04010101','040101','上证','javascript:gotoUrl("blockcode=040101&blocktype=6");');
d.add('04010102','040101','上证','javascript:gotoUrl("blockcode=040101&blocktype=6");');
d.add('04010103','040101','上证','javascript:gotoUrl("blockcode=040101&blocktype=6");');
d.add('04010104','040101','上证','javascript:gotoUrl("blockcode=040101&blocktype=6");');
d.add('040102','0401','深证封闭式基金','javascript:gotoUrl("blockcode=040102&blocktype=6");');
document.write(d);

</script>
	</body>

</html>
