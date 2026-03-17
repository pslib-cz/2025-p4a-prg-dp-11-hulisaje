public class CoffeeMachine
{
    private ICoffeeMachineState _state;

    public CoffeeMachine()
    {
        _state = new IdleState();
    }

    public void SetState(ICoffeeMachineState state)
    {
        _state = state;
    }

    public void PressButton()
    {
        _state.HandleButton(this);
    }

    public void ShowDrinkMenu()
    {
        Console.WriteLine("Zobrazení nabídky nápojů...");
    }

    public void CancelGrinding()
    {
        Console.WriteLine("Mletí zrušeno!");
    }
}