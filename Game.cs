using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace tetris_dotnet;

public class Game
{
  private Pixel[,] frame;
  public int x,y;

  /* 
  INDEX:

  0 - null
  1 - fill
  2 - break line
  */

  public Piece L = new Piece([1, 2, 1, 2, 1, 1]);
  public Piece I = new Piece([1, 2, 1, 2, 1, 2, 1]);
  public Piece T = new Piece([1, 1, 1, 2, 0, 1]);
  public Piece S = new Piece([1, 2, 1, 1, 2, 0 , 1]);
  public Piece O = new Piece([1, 1, 2, 1, 1]);

  public Game(int y, int x) {

    this.x = x;
    this.y = y;

    frame = new Pixel[x, y];

    for (int i = 0; i < x; i++) {
      for (int j = 0; j < y; j++) {
        frame[i, j] = new Pixel(".");
      }
    }
  }

  public void Render() {
    Console.Clear();

    for (int i = 0; i < x; i++) {
      for (int j = 0; j < y; j++) {
        Console.Write(frame[i, j].Value);
      }
      Console.WriteLine();
    }
    
  }

  public void Draw(int x, int y, string value) {
    frame[x, y].Value = value;
  }

  public void DrawPiece(int x, int y, Piece piece) {

    int actualY = y;
    int actualX = x;

    for (int i = 0; i < piece.Form.Length; i++) { // each number in piece
      switch (piece.Form[i]) {
        case 0:
          Draw(actualX, actualY, "#");
          actualX++;
          break;
        case 1:
          Draw(actualX, actualY, "#");
          actualX++;
          break;
        case 2:
          actualX = x;
          actualY++;
          break;
      }
    }
  }
}
