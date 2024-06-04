using DesafioPOO.Models;

// Instâncias de Nokia usando o construtor
var nokia = new Nokia("1234567890", "Nokia 3310", "356789123456789", 16);

// Instâncias de iPhone usando o construtor
var iphone = new Iphone("5556667777", "iPhone 12", "123456789012345", 128);

nokia.InstalarAplicativo("WhatsApp");
nokia.InstalarAplicativo("Instagram");
nokia.InstalarAplicativo("Telegram");

iphone.InstalarAplicativo("WhatsApp");
iphone.InstalarAplicativo("Instagram");
iphone.InstalarAplicativo("Telegram");