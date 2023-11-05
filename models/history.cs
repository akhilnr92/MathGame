namespace Models;

internal class History
{
    public int Score{get; set;}
    public DateTime Date{get; set;}
    public GameType Type{get; set;}

}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}