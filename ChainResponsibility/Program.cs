using ChainResponsibility.Сheck;

Password pass = new Password("hG+f3");

var upper = new UpperCh();
var symbol = new SymbolCh();
var num = new NumberCh();
var lenght = new LengthCh();

upper.SetNext(symbol).SetNext(num).SetNext(lenght);

pass.ClientCode(upper);

