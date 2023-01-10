using System.Runtime.InteropServices;
using static System.Reflection.Metadata.BlobBuilder;

class Program
{
    public static void Main(string[] args)
    {
        PosibilityController posibilityController = new PosibilityController(10);
        posibilityController.SetProbabilities(new float[] { 0.5f, 0.25f, 0.2f,0.05f });
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(posibilityController.GetRandomValue());
        }
        Console.ReadLine();
    }
    public class PosibilityController
    {
        private int Length = 0;
        public float[] Probabilities { get; private set; }
        public PosibilityController(int length)
        {
            Length = length;
            Probabilities = new float[Length];
        }
        public void SetProbabilities(float[] probabilities)
        {
            if (probabilities.Sum() > 1) throw new Exception("Probability can't be more than 1");
            if (probabilities.Sum() < 1) throw new Exception("Probability can't be less than 1");
            Probabilities = probabilities;
        }
        public float GetRandomValue()
        {
            float total = 0;
            foreach (float elem in Probabilities)
            {
                total += elem;
            }
            float randomPoint = Convert.ToSingle(new Random().NextDouble()) * total;
            for (int i = 0; i < Probabilities.Length; i++)
            {
                if (randomPoint < Probabilities[i])
                {
                    return i;
                }
                else
                {
                    randomPoint -= Probabilities[i];
                }
            }
            return Probabilities.Length - 1;
        }

    }
}

