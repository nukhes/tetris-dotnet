namespace tetris_dotnet;

public class Piece
{
  private bool state;
  private int[] form = [];

  public bool State { get => state; set => state = value; }
  public int[] Form { get => form; set => form = value; }

  public Piece(int[] form) { this.form = form; }
}
