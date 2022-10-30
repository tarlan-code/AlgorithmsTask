var eded=document.querySelector("#eded");
var cavab=document.querySelector("#cavab");
var hesabla=document.querySelector("#hesabla");

hesabla.onclick=function(){
    var sum=0;
    var num=Number(eded.value);
    console.log(num);
    while(num != 0)
    {
        sum=(num%10)+sum;
        num =Math.floor(num / 10);
    }
    
    cavab.value=sum;
} 