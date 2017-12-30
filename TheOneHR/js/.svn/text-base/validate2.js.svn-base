/*************************************************
	Validator v1.01
	code by �ҷ�ɽ��
	wfsr@cunite.com
	http://www.cunite.com
*************************************************/
 Validator = {
	Require : /.+/,
	Email : /^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/,
	Phone : /^((\(\d{3}\))|(\d{3}\-))?(\(0\d{2,3}\)|0\d{2,3}-)?[1-9]\d{6,7}$/,
	Mobile : /^((\(\d{3}\))|(\d{3}\-))?13\d{9}$/,
	Url : /^http:\/\/[A-Za-z0-9]+\.[A-Za-z0-9]+[\/=\?%\-&_~`@[\]\':+!]*([^<>\"\"])*$/,
	IdCard : /^\d{15}(\d{2}[A-Za-z0-9])?$/,
	Currency : /^\d+(\.\d+)?$/,
	Number : /^\d+$/,
	Zip : /^[1-9]\d{5}$/,
	QQ : /^[1-9]\d{4,8}$/,
	Integer : /^[-\+]?\d+$/,
	Double : /^[-\+]?\d+(\.\d+)?$/,
	English : /^[A-Za-z]+$/,
	Chinese :  /^[\u0391-\uFFE5]+$/,
	WkCENF : /^(?!_)(?!\')(?!.*?_$)[a-zA-Z0-9_\u4e00-\u9fa5,.?\;\:\'\"\ ]+$/,
	WkCEN : /^(?!_)(?!.*?_$)[a-zA-Z0-9_\u4e00-\u9fa5]+$/,
	WkEN : /^[a-zA-Z0-9]+$/,
	UnSafe : /^(([A-Z]*|[a-z]*|\d*|[-_\~!@#\$%\^&\*\.\(\)\[\]\{\}<>\?\\\/\'\"]*)|.{0,5})$|\s/,
	IsSafe : function(str){return this.UnSafe.test(str);},
	SafeString : "this.IsSafe(value)",
	IsSafeNotNull : function(str){return str==""?false:this.UnSafe.test(str);},
	SafeStringNotNull : "this.IsSafeNotNull(value)",
	IsChinese : function(str){return !this.Chinese.test(str);},
	ChineseString : "this.IsChinese(value)",
	WkIsCEN : function(str){return this.WkCEN.test(str);},
	WkCENString : "this.WkIsCEN(value)",
	WkIsCENNull : function(str){return str==""?true:this.WkCEN.test(str);},
	WkCENNull : "this.WkIsCENNull(value)",
	WkIsCENF : function(str,min,max){
		if(str.length<min||str.length>max)
			return false;
		return this.WkCENF.test(str);
	},
	WkCENFString : "this.WkIsCENF(value,getAttribute('min'),  getAttribute('max'))",
	WkIsEN : function(str){return this.WkEN.test(str);},
	WkENString : "this.WkIsEN(value)",
	Limit : "this.limit(value.length,getAttribute('min'),  getAttribute('max'))",
	WkLimit : "this.wklimit(value)",
	WkIsIdCard : function(str){return this.IdCard.test(str);},
	WkIdCardString : "this.WkIsIdCard(value)",
	WkIsEmail : function(str){return this.Email.test(str);},
	WkEmailString : "this.WkIsEmail(value)",
	LimitB : "this.limit(this.LenB(value), getAttribute('min'), getAttribute('max'))",
	Date : "this.IsDate(value, getAttribute('min'), getAttribute('format'))",
	Repeat : "value == document.getElementsByName(getAttribute('to'))[0].value",
	Range : "getAttribute('min') < value && value < getAttribute('max')",
	Compare : "this.compare(value,getAttribute('operator'),getAttribute('to'))",
	Custom : "this.Exec(value, getAttribute('regexp'))",
	Group : "this.MustChecked(getAttribute('name'), getAttribute('min'), getAttribute('max'))",
	ErrorItem : [document.forms[0]],
	ErrorMessage : ["����ԭ�����ύʧ�ܣ�\t\t\t\t"],
	Validate : function(theForm, mode){
		var obj = theForm || event.srcElement;
		var count = obj.elements.length;
		this.ErrorMessage.length = 1;
		this.ErrorItem.length = 1;
		this.ErrorItem[0] = obj;
		for(var i=0;i<count;i++){
			with(obj.elements[i]){
				var _dataType = getAttribute("dataType");
				if(typeof(_dataType) == "object" || typeof(this[_dataType]) == "undefined")  continue;
				this.ClearState(obj.elements[i]);
				if(getAttribute("require") == "false" && value == "") continue;
				switch(_dataType){
					case "Date" :
					case "Repeat" :
					case "Range" :
					case "Compare" :
					case "Custom" :
					case "Group" : 
					case "Limit" :
					case "WkLimit" :
					case "LimitB" :
					case "SafeString" :
					case "ChineseString" :
					case "WkCENString" :
					case "WkENString" :
					case "WkIdCardString" :
					case "WkEmailString" :
					case "WkCENNull" :
					case "SafeStringNotNull" :
					case "WkCENFString" :
						if(!eval(this[_dataType]))	{
							this.AddError(i, getAttribute("msg"));
						}
						break;
					default :
						if(!this[_dataType].test(value)){
							this.AddError(i, getAttribute("msg"));
						}
						break;
				}
			}
		}
		if(this.ErrorMessage.length > 1){
			mode = mode || 1;
			var errCount = this.ErrorItem.length;
			switch(mode){
			case 2 :
				for(var i=1;i<errCount;i++)
					this.ErrorItem[i].style.color = "red";
			case 1 :
				alert(this.ErrorMessage.join("\n"));
				this.ErrorItem[1].focus();
				break;
			case 3 :
				for(var i=1;i<errCount;i++){
				try{
					var span = document.createElement("SPAN");
					span.id = "__ErrorMessagePanel";
					span.style.color = "red";
					this.ErrorItem[i].parentNode.appendChild(span);
					span.innerHTML = this.ErrorMessage[i].replace(/\d+:/,"*");
					}
					catch(e){alert(e.description);}
				}
				this.ErrorItem[1].focus();
				break;
			default :
				alert(this.ErrorMessage.join("\n"));
				break;
			}
			return false;
		}
		return true;
	},
	limit : function(len,min, max){
		min = min || 0;
		max = max || Number.MAX_VALUE;
		return min <= len && len <= max;
	},
	wklimit : function(value){
		if(value==null||value==""||value=="0")
			return false;
		return true;
	},
	LenB : function(str){
		return str.replace(/[^\x00-\xff]/g,"**").length;
	},
	ClearState : function(elem){
		with(elem){
			if(style.color == "red")
				style.color = "";
			var lastNode = parentNode.childNodes[parentNode.childNodes.length-1];
			if(lastNode.id == "__ErrorMessagePanel")
				parentNode.removeChild(lastNode);
		}
	},
	AddError : function(index, str){
		this.ErrorItem[this.ErrorItem.length] = this.ErrorItem[0].elements[index];
		this.ErrorMessage[this.ErrorMessage.length] = this.ErrorMessage.length + ":" + str;
	},
	Exec : function(op, reg){
		return new RegExp(reg,"g").test(op);
	},
	compare : function(op1,operator,op2){
		switch (operator) {
			case "NotEqual":
				return (op1 != op2);
			case "GreaterThan":
				return (op1 > op2);
			case "GreaterThanEqual":
				return (op1 >= op2);
			case "LessThan":
				return (op1 < op2);
			case "LessThanEqual":
				return (op1 <= op2);
			default:
				return (op1 == op2);            
		}
	},
	MustChecked : function(name, min, max){
		var groups = document.getElementsByName(name);
		var hasChecked = 0;
		min = min || 1;
		max = max || groups.length;
		for(var i=groups.length-1;i>=0;i--)
			if(groups[i].checked) hasChecked++;
		return min <= hasChecked && hasChecked <= max;
	},
	IsDate : function(op, formatString){
		formatString = formatString || "ymd";
		var m, year, month, day;
		switch(formatString){
			case "ymd" :
				m = op.match(new RegExp("^((\\d{4})|(\\d{2}))([-./])(\\d{1,2})\\4(\\d{1,2})$"));
				if(m == null ) return false;
				day = m[6];
				month = m[5]--;
				year =  (m[2].length == 4) ? m[2] : GetFullYear(parseInt(m[3], 10));
				break;
			case "dmy" :
				m = op.match(new RegExp("^(\\d{1,2})([-./])(\\d{1,2})\\2((\\d{4})|(\\d{2}))$"));
				if(m == null ) return false;
				day = m[1];
				month = m[3]--;
				year = (m[5].length == 4) ? m[5] : GetFullYear(parseInt(m[6], 10));
				break;
			default :
				break;
		}
		if(!parseInt(month)) return false;
		month = month==12 ?0:month;
		var date = new Date(year, month, day);
        return (typeof(date) == "object" && year == date.getFullYear() && month == date.getMonth() && day == date.getDate());
		function GetFullYear(y){return ((y<30 ? "20" : "19") + y)|0;}
	}
 }
 
 	function build_validate(oName,sMsg,dataType,min,max){
  		var oCtl = document.forms[0].elements[oName];
		oCtl.msg=sMsg;
		if (dataType){
			oCtl.dataType = dataType;
		}
		if (min){
			oCtl.min = min;
		}
		if (max){
			oCtl.max = max;
		}	
  	}
  	function build_validate_compare(oName,sMsg,to){
  		var oCtl = document.forms[0].elements[oName];
		oCtl.msg=sMsg;
		oCtl.dataType="Repeat";
		oCtl.to=to;
  	}
  	function build_validate_MustChecked(oName,sMsg,dataType,min,max){
  		var oBox = document.getElementsByName(oName);
		for(var i =0;i<oBox.length;i++){
			oBox[i].msg=sMsg;
			if (dataType){
				oBox[i].dataType = dataType;
			}
			if (min){
				oBox[i].min = min;
			}
			if (max){
				oBox[i].max = max;
			}	
		}
  	}