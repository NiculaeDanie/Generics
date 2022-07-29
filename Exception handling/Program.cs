
using Bookify.Domain.Generics;
char[] array = {'a','b','b'};
var arr = new GenericArray<char>(array);
arr.setItem(2, 'z');
Console.WriteLine(arr.getItem(2));
arr.setItem(1, 'd');
Console.WriteLine(arr.toString());
