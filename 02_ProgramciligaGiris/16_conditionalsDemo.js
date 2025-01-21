var sayi1 = 10
var sayi2 = 30
var sayi3 = 20

// En büyük sayıyı bulunuz.

// Benim Çözüm:
var enBuyukSayi = sayi1

if ((sayi1 < sayi2) || (sayi1 < sayi3)) {
    enBuyukSayi = sayi2
    if (sayi2 < sayi3) {
        enBuyukSayi = sayi3
    }
}
console.log("En büyük sayı: " + enBuyukSayi)

// Hocanın Çözüm:
var enBuyuk = sayi1
if (enBuyuk < sayi2) {
    enBuyuk = sayi2;
}
if (enBuyuk < sayi3) {
    enBuyuk = sayi3;
}
console.log("Bu sayıların içinde en büyük = " + enBuyuk)