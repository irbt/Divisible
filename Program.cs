// Given two integers, write a method that returns their multiplication if they are both divisible by 2 or 3, otherwise returns thier sum.
using System;

namespace Divisibleby2or3{
class Divisible23{


static int Divisible(int int1 , int int2){
    int resultat;

if (((int1 % 2) == 0  | (int1 % 3) == 0) &  ((int2 % 2) == 0  | (int2 % 3) == 0)){
    resultat = int1 * int2 ;
    Console.WriteLine(int1 + " et " + int2 + "sont divisibles par 2 ou 3 donc on multiplie ->" + resultat) ;
    return resultat;
}else{
    resultat = int1 + int2 ;
    Console.WriteLine(int1 + " et " + int2 + "ne sont pas  divisibles par 2 ou 3 donc on ajoute  ->" + resultat) ;
    return resultat;
}

}

static void Main (string[] args){

    Divisible(15,30);
    Divisible(2,90);
    Divisible(7,12);
}

}}