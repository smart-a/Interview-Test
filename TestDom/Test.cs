using System;

public class DriverExam
{
    public static void ExecuteExercise(IExercise exercise)
    {
        try
        {
            exercise.Start();
            exercise.Execute();
        }
        catch (Exception ex)
        {
            exercise.MarkNegativePoints();
        }
        finally
        {
            exercise.End();
        }
        
        throw new InvalidOperationException("Waiting to be implemented.");
    }
}

public interface IExercise
{
    void Start();
    void Execute();
    void MarkNegativePoints();
    void End();
}

public class Exercise : IExercise
{
    public void Start() { Console.WriteLine("Start"); }
    public void Execute() { Console.WriteLine("Execute"); }
    public void MarkNegativePoints() { Console.WriteLine("MarkNegativePoints"); }
    public void End() { Console.WriteLine("End"); }
}

public class Program
{
    public static void Main(string[] args)
    {
        DriverExam.ExecuteExercise(new Exercise());
    }
}