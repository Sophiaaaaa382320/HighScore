int[] scores = { 20, 90, 100, 80, 30 };
float total=0, avarage;
int HighestScore = 0;
int lowest=0;

for(int i = 0; i< scores.Length; i++)
{
    Console.WriteLine($"Player {i + 1}: {scores[i]}");
    total += scores[i];
    lowest = scores[i];
    if (scores[i] > HighestScore)
    {
        HighestScore = scores[i];
    }
    if(scores[i] < lowest)
    {
        lowest = scores[i];
    }
}
avarage = total/scores.Length;
Console.WriteLine($"Avarage Score: {avarage}");
Console.WriteLine($"Highest Score: {HighestScore}");
Console.WriteLine($"Lowest score: {lowest}");