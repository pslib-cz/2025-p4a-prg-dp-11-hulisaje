CoffeeMachine machine = new CoffeeMachine();
machine.PressButton();
machine.SetState(new GrindingState());
machine.PressButton();
machine.SetState(new PouringWaterState());
machine.PressButton();