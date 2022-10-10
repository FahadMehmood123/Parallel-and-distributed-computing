using System;
using System.Threading;
using System.Random;


public class ExThread {
    
   public int temp=0;
   public bool chec=false; 
   public  void mythread1()
    {
        
        Random rnd = new Random();
        temp=rnd;
        if(rnd.Next(10)%2==0){ 
            chec=true;
        }
        
    }
    
    public void mythread2()
    {
        if(chec==true){
        Console.WriteLine(temp*temp);
        }
    }
    
    public void mythread3()
    {
        if(chec==false){
    
        Console.WriteLine(temp*temp*temp);
        }
    }
}


public class GFG {
  
    
    public static void Main()
    {
       
        ExThread obj = new ExThread();

        while(true)
        {
            Thread thr1 = new Thread(new ThreadStart(obj.mythread1));
            thr1.Start();
        
        Thread thr2 = new Thread(new ThreadStart(obj.mythread2));
        thr2.Start();
        Thread thr3 = new Thread(new ThreadStart(obj.mythread3));
        thr3.Start();
        Thread.Sleep(1000);
        }
    
    }
}

//we made two varaibke one is chec and other is temp=0 by default we made chec  false
//In thread1 we have generated random number and made temp=random number generated
//Now checking whether temp is even or odd if even then we made chec variable=true
//In thread2 if chec variable value is true then we have taken its sqaure else if chec is false then it will do nothing
//In thread3 if chec variable value is false then we have taken its cube else if chec is false then it will do nothing
//In main we have called main thread after 1000ms





