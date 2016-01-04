using System;

namespace Decorator
{
    class AmbulanceCar : DecoratorCar
    {
        public AmbulanceCar(Car decoratedCar)
            : base(decoratedCar)
        {
        }
        public override void Go()
        {
            base.Go();
            Console.WriteLine("... beep-beep-beeeeeep ...");
        }
    }
}