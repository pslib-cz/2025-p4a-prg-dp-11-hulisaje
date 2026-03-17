public class GrindingState : ICoffeeMachineState
{
    public void HandleButton(CoffeeMachine machine)
    {
        machine.CancelGrinding();
        machine.SetState(new IdleState());
    }
}