
	//三级机构三级级联
		var xmlHttpRequest;
		var flag=0;
		var selIndex=0;
		function doSearch(leave,obj){
			
			selIndex=obj.value;
			flag=leave;
			var mac1=obj.value;
			if(mac1==null || mac1==""){
				return;
			}
			var url="engMachine.do?op=doSearch&macLeave="+leave+"&macParentId="+mac1+"&date="+new Date();
			//JUser.doLogin(username,password,callback);
			xmlHttpRequest = createXmlHttpRequest();
			xmlHttpRequest.onreadystatechange=callback;
			xmlHttpRequest.open("post",url,true);
			xmlHttpRequest.send(null);
		}
		
		
		function createXmlHttpRequest(){
				if(window.ActiveXObject){ //IE浏览器
					return new ActiveXObject("Microsoft.XMLHTTP");
				}else if(window.xmlHttpRequest){  //非IE浏览器
					return new XMLHttpRequest();
				}
			}
			
		var arr; 
		function callback(){
		
			if(xmlHttpRequest.readyState == 4){
					if(xmlHttpRequest.status == 200){
					var str = xmlHttpRequest.responseText;
					
					arr = str.parseJSON();
					
					if(flag==2){
						a(selIndex);
					}
					else{
						b(selIndex);
					}
				}
			}
		}
	
	
	
	
	
		var one;
		var two;
		var three;
		var four;
		var five;
		//用来设置 select 的初始大小
		window.attachEvent("onload",initCallPurposeDetailPage);
		function initCallPurposeDetailPage()//初始化页面
		{
			one=document.getElementById("machine1"); 
			two=document.getElementById("machine2");
			three=document.getElementById("machine3");
			four = document.getElementById("jobType");
			five = document.getElementById("item.engJob.jobId");
		}
			
		//一级机构掉此函数刷新二级列表	
		function a(tValue)
		{
		
			two.selectedIndex=0;
			three.selectedIndex=0;
			if(tValue == 0){
				two.length=1;//当我们选择“请选择”时设置全部 select 的大小
				three.length=1;
			}
			else{
				two.length=1;
				three.length=1;
				
				for(i=0 ; i < arr.macList.length;i++)
				{	
					two.options[two.length]=new Option(arr.macList[i].macName,arr.macList[i].macId);
					
				}
			}
		}
				
	//二级机构掉此函数刷新三级列表	
		function b(tValue)
		{
			three.selectedIndex=0;
			if(tValue == "0")
			{
				three.length=1;//当我们选择“请选择”时设置全部 select 的大小
			}
			else
			{
				three.length=1;
				for(i=0 ; i < arr.macList.length;i++)
				{
					three.options[three.length]=new Option(arr.macList[i].macName,arr.macList[i].macId);
					
				}
			}
		}
		
		
		
		
	
	
	//职位类型和职位名称二级级联
		function doSearchJob(obj){
			five.selectedIndex=0;
			var jobTypeId=obj.value;
			if(jobTypeId==null || jobTypeId==""){
				return;
			}
			if(jobTypeId=="0"){
				five.length=1;
				return;
			}
			var url="engJob.do?op=doSearch&jboTypeId="+jobTypeId+"&date="+new Date();
			//JUser.doLogin(username,password,callback);
			xmlHttpRequest = createXmlHttpRequest();
			xmlHttpRequest.onreadystatechange=callbackJob;
			xmlHttpRequest.open("post",url,true);
			xmlHttpRequest.send(null);
		}
		
		//职位名称查询回调，刷新职位名称下拉列表
		function callbackJob(){
			if(xmlHttpRequest.readyState == 4){
				if(xmlHttpRequest.status == 200){
					var str = xmlHttpRequest.responseText;
					var jobs = str.parseJSON();
					five.length=1;
					for(i=0 ; i < jobs.jobList.length;i++)
					{
						five.options[five.length]=new Option(jobs.jobList[i].jobName,jobs.jobList[i].jobId);
						
					}
				}
			}
		}
	
	
	//向服务器请求数据
function checkByGetUrl(){
   xmlHttpRequest=createXmlHttpRequest();    //得到XmlHttpRequrst
   //3 设置回调函数
   var inceptDate=document.forms[0].elements["inceptDate1"].value;
   var finishDate=document.forms[0].elements["finishDate1"].value;
	xmlHttpRequest.onreadystatechange = callbackd;
	url="arcArchive.do";		
//4 初始化组件
	xmlHttpRequest.open("POST",url,true);
				
//设置头信息
	xmlHttpRequest.setRequestHeader("Content-Type","application/x-www-form-urlencoded;charset=UTF-8");
//5 发送请求
	xmlHttpRequest.send("op=doSeach&inceptDate1="+inceptDate+"&finishDate1="+finishDate);
}
function callbackd(){
   if(xmlHttpRequest.readyState == 4){
					if(xmlHttpRequest.status == 200){
						var str = xmlHttpRequest.responseText;
						window.location.href=str;
	}
}
}
	
		function toBack(){
			window.history.go(-1);
			
		}
	