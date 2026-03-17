public class PouringWaterState : ICoffeeMachineState
{
    public void HandleButton(CoffeeMachine machine)
    {
        Console.WriteLine("Tlačítko je během nalévání vody deaktivováno.");
    }
}