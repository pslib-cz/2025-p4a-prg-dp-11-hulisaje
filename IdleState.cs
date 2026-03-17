public class IdleState : ICoffeeMachineState
{
    public void HandleButton(CoffeeMachine machine)
    {
        machine.ShowDrinkMenu();
    }
}