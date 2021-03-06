//判断用户名是否输入正确
function checkByName(str){
   var strName=str.value;
   var req = /^[0-9A-Za-z\u0391-\uFFE5]+$/g;  //只能输入数字、字母、中文 
   var divName=document.getElementById("name");
   if(!req.test(strName)){     //判断用户名是否为空
					divName.innerHTML="只能输入数字、字母、中文";
					str.value = "";
					str.focus();
					return;
		}else{
		   divName.innerHTML="√";
	}
}
//验证Email
function checkByEmail(str){
  var email=str.value;
  var req=/^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/;
   var mailTo=document.getElementById("emailto");
   if(!req.exec(email)){
      mailTo.innerHTML="E-mail输入错误!";
      str.value = "";
		return;
   }else{
      mailTo.innerHTML="√";
   }
}
  //验证手机
  function checkByMobile(str){
    var mobile=str.value;
    var req=/^[+]{0,1}(\d){1,3}[ ]?([-]?((\d)|[ ]){1,12})+$/;
    var mobileTo=document.getElementById("mobile");
    if(!req.exec(mobile)){
        mobileTo.innerHTML="手机号输入错误!";
         str.value = "";
	     str.focus();
		return;
    }else{
       mobileTo.innerHTML="√";
    }
  }
 //验证年龄 
 function checkByAge(str){
 var age=str.value;
 var ageTo=document.getElementById("age");
   if(isNaN(age)){
        ageTo.innerHTML="年龄只能输入数字";
         str.value = "";
	     str.focus();
		return;
   }else{
      ageTo.innerHTML="√";
   }
 }
 //验证身份证号码
 function checkByCard(str){
    var card=str.value;
    var cardTo=document.getElementById("cardTo");
     if(!(/(^\d{15}$)|(^\d{17}([0-9]|X)$)/.test(card))){
       cardTo.innerHTML="身份证号码输入错误!";
       str.value="";
       str.focus();
       return;
    }else{
      cardTo.innerHTML="√";
    }
 }  
 //验证出生日期
 function checkByBirthday(str){
    var birthday=str.value;
	var req=/^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-8]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-))$/;
	var birthdayTo=document.getElementById("birthday");
	if(!req.exec(birthday)){
	    birthdayTo.innerHTML="生日输入错误!(yyyy-MM-dd)";
		str.value="";
       str.focus();
       return;
	}else{
	    birthdayTo.innerHTML="√";
	}
 }
//验证表单提交
 function checkBySubmit(){
    var name=document.forms[0].elements["item.archiveName"].value;   //用户名
     var req = /^\s*$/g;
      var divName=document.getElementById("name");
     if(req.exec(name)){
        divName.innerHTML="用户名不能为空！";
        name="";
        return false;
     }
     //验证Email是否为空
     var email=document.forms[0].elements["item.archiveEmail"].value;
      var mailTo=document.getElementById("emailto");
      if(req.exec(email)){
        mailTo.innerHTML="Email不能为空!";
        email="";
        return false;
      }
      //手机是否为空
      var mobile=document.forms[0].elements["item.archiveMobile"].value;
       var mobileTo=document.getElementById("mobile");
       if(req.exec(mobile)){
         mobileTo.innerHTML="手机号不能为空!";
         mobile="";
         return false;
       }
     //  年龄是否为空
     var age=document.forms[0].elements["item.archiveAge"].value;
     var ageTo=document.getElementById("age");
     if(req.exec(age)){
        ageTo.innerHTML="年龄不能为空!";
        age="";
        return false;
     }
    //验证身份证号是否为空
    var card=document.forms[0].elements["item.archiveCard"].value;
      var cardTo=document.getElementById("cardTo");
      if(req.exec(card)){
         cardTo.innerHTML="身份证号不能为空!";
         card="";
         return false;
      }
    //判断出生日期是否为空
    var birthday=document.forms[0].elements["item.archiveBirthday"].value;
    var birthdayTo=document.getElementById("birthday");
    if(req.exec(birthday)){
         birthdayTo.innerHTML="生日不能为空!";
         birthday="";
         return false;
    }
    //判断职位名称
    var jobId=document.forms[0].elements["item.engJob.jobId"].value;
    var jobIdTo=document.getElementById("jobIds");
    if(jobId=="0"){
    jobIdTo.innerHTML="请选择职位名称!";
      return false;
    }
   return true; 
 }
 //设置键盘只能输入数字
function checkNumkey(obj) {
		var key = event.keyCode;
		if ((key > 95 && key < 106) || (key > 47 && key < 60) || (key == 110 && obj.value.indexOf(".") > -1)) {
		} else {
			if (key != 8) {
				event.returnValue = false;
			}
		}
		} 
		//验证电话
function checkByPhone(obj){
var req=/^((\(\d{3}\))|(\d{3}\-))?(\(0\d{2,3}\)|0\d{2,3}-)?[1-9]\d{6,7}$/;
var phone=document.getElementById("phone");
	if(!req.exec(obj.value)){
	  phone.innerHTML="请输入正确的电话号码";
	  obj="";
	  return;
	}else{
	  phone.innerHTML="√";
	}
}
//验证社会电话号码
function checkByCommunityTel(obj){
var req=/^((\(\d{3}\))|(\d{3}\-))?(\(0\d{2,3}\)|0\d{2,3}-)?[1-9]\d{6,7}$/;
 var communityTel=document.getElementById("CommunityTel");
 if(!req.exec(obj.value)){
	  communityTel.innerHTML="请输入正确的社会保障号码";
	  obj="";
	  return;
	}else{
	  communityTel.innerHTML="√";
	}
}
