namespace tetris_dotnet;

public class Pixel
{
  private string fill;
  public string Value { set => fill = value; get => fill; }
  public Pixel(string value) {
    this.fill = value;
  }
}
