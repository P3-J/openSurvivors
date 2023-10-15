using Godot;
using System;
using System.Diagnostics;

public partial class player : CharacterBody2D
{
	
	[Export]
	public int Speed { get; set; } = 400;

	public string currentDire = ""; 


	public override void _Input(InputEvent @event)
	{
		if (@event.IsActionPressed("left"))
		{
			Position   += Vector2.Left * 128 / 2;
			currentDire = "left";  
		}
		if (@event.IsActionPressed("right"))
		{
			Position += Vector2.Right * 128 / 2;
			currentDire = "right";
		}
		if (@event.IsActionPressed("up"))
		{
			Position += Vector2.Up * 128 / 2;
			currentDire = "up";
		}
		if (@event.IsActionReleased("down"))
		{
			Position += Vector2.Down * 128 / 2;
			currentDire = "down";
			Trace.WriteLine(currentDire);
		}

	}

	
}
