# ProbabilityVariable
# Usage
```C#
  PosibilityController posibilityController = new PosibilityController(10);
  posibilityController.SetProbabilities(new float[] { 0.5f, 0.25f, 0.2f,0.05f });
  for (int i = 0; i < 100; i++)
  {
      Console.WriteLine(posibilityController.GetRandomValue());
  }
  Console.ReadLine();
```
1. Create object of class PosibilityController
2. Set probabilities (0 < P <= 1)
3. You can use method 'GetRandomValue' to generate some array index as probability you set
