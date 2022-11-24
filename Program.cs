// Given two integers, write a method that returns their multiplication if they are both divisible by 2 or 3, otherwise returns thier sum.
using System;

namespace Divisibleby2or3{
class Divisible23{


static int Divisible2OR3(int int1 , int int2){
    //int resultat;

return ((((int1 % 2) == 0  | (int1 % 3) == 0) &  ((int2 % 2) == 0  | (int2 % 3) == 0)) ? int1 * int2 : int1 + int2);

}

static void Main (string[] args){

   Console.WriteLine( Divisible2OR3(15,30));
   Console.WriteLine( Divisible2OR3(2,90));
   Console.WriteLine( Divisible2OR3(7,12));
}

}}