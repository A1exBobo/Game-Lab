using Godot;

public partial class Ball : MeshInstance3D
{
	[Export]
	public float Speed = 5.0f;

	public override void _PhysicsProcess(double delta)
	{
		Vector3 direction = Vector3.Zero;

		if (Input.IsActionPressed("ui_left"))
			direction.X -= 1;

		if (Input.IsActionPressed("ui_right"))
			direction.X += 1;

		if (Input.IsActionPressed("ui_up"))
			direction.Z -= 1;

		if (Input.IsActionPressed("ui_down"))
			direction.Z += 1;

		direction = direction.Normalized();

		Position += direction * Speed * (float)delta;
	}
}
