int n=0;
void KeyAsk()
{var x=Console.ReadLine();

if (x!=$"") 
{   
    int z=Convert.ToInt32(x);
    if (z>0)  
   {
        n=n+1;
      KeyAsk();
   }
   else KeyAsk();
}    
else Console.WriteLine(n);
}
Console.WriteLine("Введите число или нажмите ввод");
KeyAsk();