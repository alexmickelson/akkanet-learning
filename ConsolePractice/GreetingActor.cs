using Akka.Actor;

namespace HelloWorld;

public class GreetingActor : ReceiveActor
{
  public GreetingActor()
  {
    Receive<GreetMessage>(greet => Console.WriteLine($"Hello {greet.Who}"));
  }
  protected override void PreStart()
  {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Good Morning, we are awake!");
  }

  protected override void PostStop()
  {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Good Night, going to bed!");
  }
}
