using System;
using System.Collections;

namespace _191088_Lab_task_2
{    
    public class Program
    {
        static int[] arr= new int[5];
        static int front=-1;
        static int rear=-1;

        public static bool isEmpty(){
            if(front==-1 && rear==-1){
                return true;
            }
            else{
                return false;
            }
        }
        public static bool isFull(){
            if(front==rear){
                return true;
            }
            else{
                return false;
            }
        }

        public static void Enque(int x){
            if(isEmpty()){
                front=rear=0;
            }
            else{
                rear=rear+1;
            }
            arr[rear]=x;
        }

        public static void Deque(){
            if(isFull()){
                Console.WriteLine(arr[front]);
                front=rear=-1;
            }
            else{
            Console.WriteLine(arr[front]);
            arr[front]=0;
            front=front+1;
            }
        }

        static void Main(string[] args)
        {
            Enque(10);
            Enque(11);
            Enque(12);
            Deque();
            Deque();
            Deque();

        }
    }
}
