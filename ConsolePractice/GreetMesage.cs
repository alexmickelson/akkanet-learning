namespace HelloWorld;

public class GreetMessage
{
  public string Who { get; private set; }

  public GreetMessage(string who)
  {
    Who = who;
  }
}
