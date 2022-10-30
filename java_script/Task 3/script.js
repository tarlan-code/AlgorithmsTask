var langname=document.querySelector("#langname");
var answer=document.querySelector("#answer");
var search=document.querySelector("#search");

search.onclick=function(){

    var language;
    var lang=String(langname.value)


    
    switch (lang)
    {
    case "a":
        language = "Azərbaycan dili seçildi";
        break;
    case "A":
        language = "AZ dili seçildi"
        break;
    case "r":
        language = "Rus dili seçildi";
        break;
    case "R":
        language = "RU dili seçildi";
        break;
    
    default:
        language = "Yanlış sorğu";
        break;
}
    
    
    answer.value=language;
} 

