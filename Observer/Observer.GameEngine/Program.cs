
using Observer.GameEngine;

Player player = new();

player.Attach(new GameOver(player));
player.Attach(new HealthBar(player));
player.Attach(new Score(player));

player.SetState(2,100);
player.SetState(20, 100);
player.SetState(50, 100);
player.SetState(30, 80);
player.SetState(20, 10);
player.SetState(30, 0);

