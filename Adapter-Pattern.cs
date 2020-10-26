using System;

namespace Design_Pattern
{/*
  * The adapter pattern convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn’t otherwise because of incompatible interfaces.
   */
    public interface IBird
    {
        public void fly();
        public void MakeSound();
    }
    public class sparow : IBird
    {
        public void fly()
        {
            Console.WriteLine("Fly");
        }

        public void MakeSound()
        {
            Console.WriteLine("Chip Chip");
        }
    }

    public interface IToyBird
    {
        public void Squeak();
    }
    public class ToyBird : IToyBird
    {
        public void Squeak()
        {
            Console.WriteLine("Squeak Squeak");
        }
    }

    public class birdAdapter : IToyBird
    {
        private IBird Bird;
        public birdAdapter(IBird bird)
        {
            this.Bird = bird;
        }
        public void Squeak()
        {
            this.Bird.MakeSound();
        }

    }
    

    public class MainAdapterPattern
    {
        public MainAdapterPattern()
        {

        }
       
        public void caller()
        {
            birdAdapter BirdAdapter = new birdAdapter(new sparow());
            BirdAdapter.Squeak();

            IToyBird toyBird = new ToyBird();
            toyBird.Squeak();
        }
       
    }
}
