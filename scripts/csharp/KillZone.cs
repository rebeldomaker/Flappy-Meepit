using Godot;
using System;

public partial class KillZone : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		base._Ready();
		BodyEntered += HandlePlayerOverlap;
	}

	private void HandlePlayerOverlap(Node2D body)
	{
		if (body is Player player)
		{
			GetTree().ReloadCurrentScene();
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
