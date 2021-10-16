namespace BehaviorPatterns.Strategy
{
    public class Car
    {
        protected int passengers; // кол-во пассажиров
        protected string model; // модель автомобиля

        public Car(int num, string model)
        {
            this.passengers = num;
            this.model = model;
        }
        public void Move(IMovable Movable)
        {
            Movable.Move();
        }
    }
}
