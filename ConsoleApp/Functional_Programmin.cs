
var show = Show;

Some(show, "Hi, its me");

string Show(string message){
   return message.ToUpper();
}

void Some(Func<string, string> fn, string message){
    Console.WriteLine("Algo q hacer al inicio");
    Console.WriteLine(fn(message));
    Console.WriteLine("Algo q hacer al final");
} 
