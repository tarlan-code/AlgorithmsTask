var monthname=document.querySelector("#monthname");
var answer=document.querySelector("#answer");
var search=document.querySelector("#search");

search.onclick=function(){
    var day;
    var month=String(monthname.value).toLowerCase(); 
    console.log(month);
    
    switch (month)
    {
    case "january":
        day = 31;
        break;
    case "february":
        day = "28(29)"
        break;
    case "march":
        day = 31;
        break;
    case "april":
        day = 30;
        break;
    case "may":
        day = 31;
        break;
    case "june":
        day = 30;
        break;
    case "july":
        day = 31;
        break;
    case "august":
        day = 31;
        break;
    case "september":
        day = 30;
        break;
    case "october":
        day = 31;
        break;
    case "november":
        day = 30;
        break;
    case "december":
        day = 31;
        break;
    default:
        day = "Xeta!\nAy adi duzgun daxil edilmeyib";
        break;
}
    
    
    answer.value=day;
} 

