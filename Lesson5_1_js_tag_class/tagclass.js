function Degistir() {
    //document.getElementById(""); //değer seçimi Id ile yapıyor
    //değer seçimi class ile yapıyor ama class birden fazla elemente sahip olabilir bu yüzden index numarası ile hangi elementin seçileceği belirtilir
    // var element1 = document.getElementsByClassName("alan1")[0];
    //element1.className = "alan2";

    // element1.classList.add("alan3"); //classList.add() ile var olan class'lara yeni class eklenebilir

    // var element2 = document.getElementsByClassName("alan1")[2];
    // element2.className = "alanlabel1";
    var elementList = document.getElementsByClassName("alan1");

    //for (var i = 0; i < elementList.length; i++) {
    //    elementList[i].classList.add("alan3");
    //}

    //for ile yapılan işlemi Array.from() ile de yapabiliriz. Array.from() ile HTMLCollection'ı array'e çevirip forEach() ile her bir elemente istediğimiz class'ı ekleyebiliriz, yeni class'lar ekleyebiliriz, istenilen css özellikleri toplu bir şekilde verebiliriz.

    Array.from(elementList).forEach(function (item) {
        item.classList.add("alan4");
    })
}
function TagNameFunction() {

    //var tagElement = document.getElementByTagName("input")[1];
    //tagElement.setAttribute("type", "button");

    var tagList = document.getElementsByTagName("input");

    for (var i = 0; i < tagList.length; i++) {
        //setAttribute() ile istediğimiz tag'e istediğimiz özelliği verebiliriz, değiştirebiliriz.
        //Örneğin type'ı button yapabiliriz.
        //setAttribute 2 parametre alır, ilk parametre hangi özelliği değiştireceğimizi belirtir(tag attribute adı), ikinci parametre ise o özelliğin ne olacağını belirtir.)
        tagList[i].setAttribute("class", "alan2");
    }
}



