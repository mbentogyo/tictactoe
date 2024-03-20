using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
        class Program 
    {
        // This code was made by me when I was only first starting out with C#. Yes, I didn't know about arrays back then, nor making correct loops.
        string a11 = "-";
        string a21 = "-";
        string a31 = "-";
        string b11 = "-";
        string b21 = "-";
        string b31 = "-";
        string c11 = "-";
        string c21 = "-";
        string c31 = "-";
        int Tictactoe = 0;

           //Player 2
           
            void Player2turn(){
              
           //Win Checker
            void wincheckerx()
           {
             if(
             ((a11 == "X") && (a21 == "X") && (a31=="X")) || 
             ((b11 == "X") && (b21 == "X") && (b31=="X")) || 
             ((c11 == "X") && (c21 == "X") && (c31=="X")) || 
             ((a11 == "X") && (b11 == "X") && (c11=="X")) || 
             ((a21 == "X") && (b21 == "X") && (c21=="X")) ||  
             ((a31 == "X") && (b31 == "X") && (c31=="X")) || 
             ((a11 == "X") && (b21 == "X") && (c31=="X")) || 
             ((a31 == "X") && (b21 == "X") && (c11=="X")))
           {
               Console.WriteLine("Player 1 won the game!");
               Tictactoe++;
           }
           }
           
            void wincheckero()
           {
             if(
             ((a11 == "O") && (a21 == "O") && (a31=="O")) || 
             ((b11 == "O") && (b21 == "O") && (b31=="O")) || 
             ((c11 == "O") && (c21 == "O") && (c31=="O")) || 
             ((a11 == "O") && (b11 == "O") && (c11=="O")) || 
             ((a21 == "O") && (b21 == "O") && (c21=="O")) ||  
             ((a31 == "O") && (b31 == "O") && (c31=="O")) || 
             ((a11 == "O") && (b21 == "O") && (c31=="O")) || 
             ((a31 == "O") && (b21 == "O") && (c11=="O")))
           {
               Console.WriteLine("Player 1 won the game!");
               Tictactoe++;
           }
           
           }
        
        static void Main(string args) 
        {
            Console.WriteLine("Welcome to TicTacToe \n Player 1 will be playing as the X piece. \n Player 2 will be playing as the O piece.");
            
            
            Console.WriteLine("Coordinates are A1 A2 A3 \n B1 B2 B3 \n C1 C2 C3");
            
            //p1
                          int p1inc = 0;
              do{
           Console.WriteLine("Player 1, Its now your turn.");
          string p1turn = Console.ReadLine();
           
           //aone
           if (p1turn == "a1"){
               if (a11 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   a11 = "X";
                   p1inc++;
               }
           }
           //aone
           //atwo
           else if (p1turn == "a2"){
               if (a21 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   a21 = "X";
                   p1inc++;
               }
           }
               //atwo
               //athree
               else if (p1turn == "a3"){
               if (a31 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   a31 = "X";
                   p1inc++;
               }
           }
           //athree
           //bone
           else if (p1turn == "b1"){
               if (b11 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   b11 = "X";
                   p1inc++;
               }
           }
           //bone
           //btwo
           else if (p1turn == "b2"){
               if (b21 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   b21 = "X";
                   p1inc++;
               }
           }
           //btwo
           //bthree
           else if (p1turn == "b3"){
               if (b31 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   b31 = "X";
                   p1inc++;
               }
           }
           //bthree
           //cone
           else if (p1turn == "c1"){
               if (c11 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   c11 = "X";
                   p1inc++;
               }
           }
           //cone
           //ctwo
           else if (p1turn == "c2"){
               if (c21 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   c21 = "X";
                   p1inc++;
               }
           }
           //ctwo
           //cthree
           else if (p1turn == "c3"){
               if (c31 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   c31 = "X";
                   p1inc++;
               }
           }
           else {
               Console.WriteLine("You need to input a valid coordinate.");
           }
           //cthree
           //the blocks
           if (p1turn == "a1" || p1turn == "a2" || p1turn == "a3" || p1turn == "b1" || p1turn == "b2" || p1turn == "b3" || p1turn == "c1" || p1turn == "c2" || p1turn == "c3"){
           Console.WriteLine(a11 + a21 + a31);
           Console.WriteLine(b11 + b21 + b31);
           Console.WriteLine(c11 + c21 + c31);
           }
              }while (p1inc != 1);
           }
           //p1
//p2
                          int p2inc = 0;
              do{
           Console.WriteLine("Player 2, Its now your turn.");
           string p2turn = Console.ReadLine();
           
           //aone
           if (p2turn == "a1"){
               if (a11 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   a11 = "O";
                   p2inc++;
               }
           }
           //aone
           //atwo
           else if (p2turn == "a2"){
               if (a21 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   a21 = "O";
                   p2inc++;
               }
           }
               //atwo
               //athree
               else if (p2turn == "a3"){
               if (a31 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   a31 = "O";
                   p2inc++;
               }
           }
           //athree
           //bone
           else if (p2turn == "b1"){
               if (b11 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   b11 = "O";
                   p2inc++;
               }
           }
           //bone
           //btwo
           else if (p2turn == "b2"){
               if (b21 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   b21 = "O";
                   p2inc++;
               }
           }
           //btwo
           //bthree
           else if (p2turn == "b3"){
               if (b31 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   b31 = "O";
                   p2inc++;
               }
           }
           //bthree
           //cone
           else if (p2turn == "c1"){
               if (c11 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   c11 = "O";
                   p2inc++;
               }
           }
           //cone
           //ctwo
           else if (p2turn == "c2"){
               if (c21 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   c21 = "O";
                   p2inc++;
               }
           }
           //ctwo
           //cthree
           else if (p2turn == "c3"){
               if (c31 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   c31 = "O";
                   p2inc++;
               }
           }
           else {
               Console.WriteLine("You need to input a valid coordinate.");
           }
           //cthree
           //the blocks
           if (p2turn == "a1" || p2turn == "a2" || p2turn == "a3" || p2turn == "b1" || p2turn == "b2" || p2turn == "b3" || p2turn == "c1" || p2turn == "c2" || p2turn == "c3"){
           Console.WriteLine(a11 + a21 + a31);
           Console.WriteLine(b11 + b21 + b31);
           Console.WriteLine(c11 + c21 + c31);
           }
              }while (p2inc != 1);
           }
            //p2
//p1
                          p1inc = 0;
              do{
           Console.WriteLine("Player 1, Its now your turn.");
           p1turn = Console.ReadLine();
           
           //aone
           if (p1turn == "a1"){
               if (a11 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   a11 = "X";
                   p1inc++;
               }
           }
           //aone
           //atwo
           else if (p1turn == "a2"){
               if (a21 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   a21 = "X";
                   p1inc++;
               }
           }
               //atwo
               //athree
               else if (p1turn == "a3"){
               if (a31 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   a31 = "X";
                   p1inc++;
               }
           }
           //athree
           //bone
           else if (p1turn == "b1"){
               if (b11 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   b11 = "X";
                   p1inc++;
               }
           }
           //bone
           //btwo
           else if (p1turn == "b2"){
               if (b21 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   b21 = "X";
                   p1inc++;
               }
           }
           //btwo
           //bthree
           else if (p1turn == "b3"){
               if (b31 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   b31 = "X";
                   p1inc++;
               }
           }
           //bthree
           //cone
           else if (p1turn == "c1"){
               if (c11 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   c11 = "X";
                   p1inc++;
               }
           }
           //cone
           //ctwo
           else if (p1turn == "c2"){
               if (c21 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   c21 = "X";
                   p1inc++;
               }
           }
           //ctwo
           //cthree
           else if (p1turn == "c3"){
               if (c31 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   c31 = "X";
                   p1inc++;
               }
           }
           else {
               Console.WriteLine("You need to input a valid coordinate.");
           }
           //cthree
           //the blocks
           if (p1turn == "a1" || p1turn == "a2" || p1turn == "a3" || p1turn == "b1" || p1turn == "b2" || p1turn == "b3" || p1turn == "c1" || p1turn == "c2" || p1turn == "c3"){
           Console.WriteLine(a11 + a21 + a31);
           Console.WriteLine(b11 + b21 + b31);
           Console.WriteLine(c11 + c21 + c31);
           }
              }while (p1inc != 1);
           }
           //p1
           //p2
                         p2inc = 0;
              do{
           Console.WriteLine("Player 2, Its now your turn.");
           p2turn = Console.ReadLine();
           
           //aone
           if (p2turn == "a1"){
               if (a11 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   a11 = "O";
                   p2inc++;
               }
           }
           //aone
           //atwo
           else if (p2turn == "a2"){
               if (a21 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   a21 = "O";
                   p2inc++;
               }
           }
               //atwo
               //athree
               else if (p2turn == "a3"){
               if (a31 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   a31 = "O";
                   p2inc++;
               }
           }
           //athree
           //bone
           else if (p2turn == "b1"){
               if (b11 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   b11 = "O";
                   p2inc++;
               }
           }
           //bone
           //btwo
           else if (p2turn == "b2"){
               if (b21 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   b21 = "O";
                   p2inc++;
               }
           }
           //btwo
           //bthree
           else if (p2turn == "b3"){
               if (b31 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   b31 = "O";
                   p2inc++;
               }
           }
           //bthree
           //cone
           else if (p2turn == "c1"){
               if (c11 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   c11 = "O";
                   p2inc++;
               }
           }
           //cone
           //ctwo
           else if (p2turn == "c2"){
               if (c21 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   c21 = "O";
                   p2inc++;
               }
           }
           //ctwo
           //cthree
           else if (p2turn == "c3"){
               if (c31 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   c31 = "O";
                   p2inc++;
               }
           }
           else {
               Console.WriteLine("You need to input a valid coordinate.");
           }
           //cthree
           //the blocks
           if (p2turn == "a1" || p2turn == "a2" || p2turn == "a3" || p2turn == "b1" || p2turn == "b2" || p2turn == "b3" || p2turn == "c1" || p2turn == "c2" || p2turn == "c3"){
           Console.WriteLine(a11 + a21 + a31);
           Console.WriteLine(b11 + b21 + b31);
           Console.WriteLine(c11 + c21 + c31);
           }
              }while (p2inc != 1);
           }
            //p2
           //p1
                           p1inc = 0;
              do{
           Console.WriteLine("Player 1, Its now your turn.");
            p1turn = Console.ReadLine();
           
           //aone
           if (p1turn == "a1"){
               if (a11 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   a11 = "X";
                   p1inc++;
               }
           }
           //aone
           //atwo
           else if (p1turn == "a2"){
               if (a21 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   a21 = "X";
                   p1inc++;
               }
           }
               //atwo
               //athree
               else if (p1turn == "a3"){
               if (a31 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   a31 = "X";
                   p1inc++;
               }
           }
           //athree
           //bone
           else if (p1turn == "b1"){
               if (b11 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   b11 = "X";
                   p1inc++;
               }
           }
           //bone
           //btwo
           else if (p1turn == "b2"){
               if (b21 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   b21 = "X";
                   p1inc++;
               }
           }
           //btwo
           //bthree
           else if (p1turn == "b3"){
               if (b31 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   b31 = "X";
                   p1inc++;
               }
           }
           //bthree
           //cone
           else if (p1turn == "c1"){
               if (c11 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   c11 = "X";
                   p1inc++;
               }
           }
           //cone
           //ctwo
           else if (p1turn == "c2"){
               if (c21 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   c21 = "X";
                   p1inc++;
               }
           }
           //ctwo
           //cthree
           else if (p1turn == "c3"){
               if (c31 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   c31 = "X";
                   p1inc++;
               }
           }
           else {
               Console.WriteLine("You need to input a valid coordinate.");
           }
           //cthree
           //the blocks
           if (p1turn == "a1" || p1turn == "a2" || p1turn == "a3" || p1turn == "b1" || p1turn == "b2" || p1turn == "b3" || p1turn == "c1" || p1turn == "c2" || p1turn == "c3"){
           Console.WriteLine(a11 + a21 + a31);
           Console.WriteLine(b11 + b21 + b31);
           Console.WriteLine(c11 + c21 + c31);
           }
              }while (p1inc != 1);
           }
           //p1
            
            wincheckerx();
            if (Tictactoe != 1){
            Player2turn();
            
            wincheckero();
            }
            if (Tictactoe != 1){
                          int p1inc = 0;
              do{
           Console.WriteLine("Player 1, Its now your turn.");
           string p1turn = Console.ReadLine();
           
           //aone
           if (p1turn == "a1"){
               if (a11 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   a11 = "X";
                   p1inc++;
               }
           }
           //aone
           //atwo
           else if (p1turn == "a2"){
               if (a21 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   a21 = "X";
                   p1inc++;
               }
           }
               //atwo
               //athree
               else if (p1turn == "a3"){
               if (a31 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   a31 = "X";
                   p1inc++;
               }
           }
           //athree
           //bone
           else if (p1turn == "b1"){
               if (b11 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   b11 = "X";
                   p1inc++;
               }
           }
           //bone
           //btwo
           else if (p1turn == "b2"){
               if (b21 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   b21 = "X";
                   p1inc++;
               }
           }
           //btwo
           //bthree
           else if (p1turn == "b3"){
               if (b31 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   b31 = "X";
                   p1inc++;
               }
           }
           //bthree
           //cone
           else if (p1turn == "c1"){
               if (c11 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   c11 = "X";
                   p1inc++;
               }
           }
           //cone
           //ctwo
           else if (p1turn == "c2"){
               if (c21 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   c21 = "X";
                   p1inc++;
               }
           }
           //ctwo
           //cthree
           else if (p1turn == "c3"){
               if (c31 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   c31 = "X";
                   p1inc++;
               }
           }
           else {
               Console.WriteLine("You need to input a valid coordinate.");
           }
           //cthree
           //the blocks
           if (p1turn == "a1" || p1turn == "a2" || p1turn == "a3" || p1turn == "b1" || p1turn == "b2" || p1turn == "b3" || p1turn == "c1" || p1turn == "c2" || p1turn == "c3"){
           Console.WriteLine(a11 + a21 + a31);
           Console.WriteLine(b11 + b21 + b31);
           Console.WriteLine(c11 + c21 + c31);
           }
              }while (p1inc != 1);
           }
           
            
            wincheckerx();
            }
            if (Tictactoe != 1){
            Player2turn();
            
            wincheckero();
            }
            if (Tictactoe != 1){
                          int p1inc = 0;
              do{
           Console.WriteLine("Player 1, Its now your turn.");
           string p1turn = Console.ReadLine();
           
           //aone
           if (p1turn == "a1"){
               if (a11 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   a11 = "X";
                   p1inc++;
               }
           }
           //aone
           //atwo
           else if (p1turn == "a2"){
               if (a21 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   a21 = "X";
                   p1inc++;
               }
           }
               //atwo
               //athree
               else if (p1turn == "a3"){
               if (a31 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   a31 = "X";
                   p1inc++;
               }
           }
           //athree
           //bone
           else if (p1turn == "b1"){
               if (b11 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   b11 = "X";
                   p1inc++;
               }
           }
           //bone
           //btwo
           else if (p1turn == "b2"){
               if (b21 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   b21 = "X";
                   p1inc++;
               }
           }
           //btwo
           //bthree
           else if (p1turn == "b3"){
               if (b31 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   b31 = "X";
                   p1inc++;
               }
           }
           //bthree
           //cone
           else if (p1turn == "c1"){
               if (c11 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   c11 = "X";
                   p1inc++;
               }
           }
           //cone
           //ctwo
           else if (p1turn == "c2"){
               if (c21 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   c21 = "X";
                   p1inc++;
               }
           }
           //ctwo
           //cthree
           else if (p1turn == "c3"){
               if (c31 != "-"){
                   Console.WriteLine("Sorry, this coordinate is already occupied.");
                   
               }
               else {
                   c31 = "X";
                   p1inc++;
               }
           }
           else {
               Console.WriteLine("You need to input a valid coordinate.");
           }
           //cthree
           //the blocks
           if (p1turn == "a1" || p1turn == "a2" || p1turn == "a3" || p1turn == "b1" || p1turn == "b2" || p1turn == "b3" || p1turn == "c1" || p1turn == "c2" || p1turn == "c3"){
           Console.WriteLine(a11 + a21 + a31);
           Console.WriteLine(b11 + b21 + b31);
           Console.WriteLine(c11 + c21 + c31);
           }
              }while (p1inc != 1);
           }
           
            
            wincheckerx();
            } else {Console.WriteLine("Its a draw!");}
        }
    }
}
