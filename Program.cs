using System;
using System.Collections;
using System.Collections.Specialized;

public class Palindrome {
    
    private bool palindrome = true;
    private Stack stack;
    private Queue queue;
    
    
    public Palindrome(string word) {
        this.stack = new Stack(word.Length);
        this.queue = new Queue(word.Length);
        
        for(int i = 0; i < word.Length; i++) {
            stack.Push(word.Substring(i, 1));
            queue.Enqueue(word.Substring(i, 1));
            }
}
public bool check() {
    if ( queue != null ) {
        while(queue.Count > 0 && palindrome) {
            string first = queue.Dequeue() as string;
            string second = stack.Pop() as string;
            palindrome = (first == second);
            }
            queue = null;
            stack = null;
            }
            return palindrome;
            }
private static void Main(string[] args) {
                if ( args.Length > 0 ) {
                    Console.WriteLine("Testing: " + args[0]);
                    Palindrome p = new Palindrome(args[0]);
                    Console.WriteLine("Results: " + p.check());
                    } else {
                        Console.WriteLine("Invalid input");
                        }
                        }
}