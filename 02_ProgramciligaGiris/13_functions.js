function sayiUret(ustLimit){
    return Math.ceil(Math.random() * ustLimit)
}

var sayi1 = sayiUret(49)
var sayi2 = sayiUret(49)
var sayi3 = sayiUret(49)
var sayi4 = sayiUret(49)
var sayi5 = sayiUret(49)
var sayi6 = sayiUret(49)

console.log("Kolon: " + sayi1 + " " + sayi2 + " " + sayi3 + " " + sayi4 + " " + sayi5 + " " + sayi6)

function sayiUret1(ustLimit=49){
    return Math.ceil(Math.random() * ustLimit)
}

sayi1 = sayiUret1()  // default değer olduğu için, parametre tanımlamak zorunda değilsin. default değer olmasaydı NaN döner
sayi2 = sayiUret1()
sayi3 = sayiUret1()
sayi4 = sayiUret1()
sayi5 = sayiUret1(600)
sayi6 = sayiUret1()

console.log("Kolon: " + sayi1 + " " + sayi2 + " " + sayi3 + " " + sayi4 + " " + sayi5 + " " + sayi6)