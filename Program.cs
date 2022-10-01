using System;
using System.Collections;

namespace _191088_Lab_task_2
{    
    public class Program
    {
        static int[] myStack= new int[5];
        static int top=-1;

        public static void push(int number){
            top=top+1;
            myStack[top]=number;
        }
        public static void pop(){
            Console.WriteLine(myStack[top]);   
            myStack[top]=0;
            top=top-1;
        }
        static void Main(string[] args)
        {
           push(1);
           push(2);
           push(3);
           push(4);
           push(5);
           pop();
           pop();
           pop();
           pop();
           pop();
        }
    }
}
