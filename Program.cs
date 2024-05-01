using System.Text;
using tetris_dotnet;

Game game = new Game(20, 10);

bool isFalling = true;
int x = 1;
int y = 0;

while (isFalling) {

  if (y == 15) {
    return;
  }

  Refresh();

  HandleInput();
  await Ypp();

}

void HandleInput() {
  if (Console.KeyAvailable) {
    ConsoleKey key = Console.ReadKey().Key;
    switch (key) {
      case ConsoleKey.A:
        x--;
        return;
      case ConsoleKey.D:
        x++;
        return;
    }
  }
}

async Task Ypp() {
  y++;
  Thread.Sleep(500);
}

async Task Refresh(){
  await Task.Delay(TimeSpan.FromSeconds(0.1));
  game.DrawPiece(x, y, game.I);
  game.Render();
}