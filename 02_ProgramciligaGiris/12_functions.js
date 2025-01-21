function sayiUret(){
    console.log(Math.ceil(Math.random() * 49))
}

sayiUret()

function sayiUret1(){
    return Math.ceil(Math.random() * 60)
}

var sayi1 = sayiUret1()
var sayi2 = sayiUret1()
var sayi3 = sayiUret1()
var sayi4 = sayiUret1()
var sayi5 = sayiUret1()
var sayi6 = sayiUret1()

console.log("Kolon: " + sayi1 + " " + sayi2 + " " + sayi3 + " " + sayi4 + " " + sayi5 + " " + sayi6)

