var eded=document.querySelector("#eded");
var cavab=document.querySelector("#cavab");
var hesabla=document.querySelector("#hesabla");

hesabla.onclick=function(){
    var sum=0;
    var num=Number(eded.value);
    console.log(num);
    for (let index = 0; index < 4; index++) 
    {
        sum=(num%10)+sum;
        num =Math.floor(num / 10);
    }
    
    cavab.value=sum;
} 