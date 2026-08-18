// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Controls the scripted parallax movement of one visual background layer.
// Responsibilities: Apply a configurable depth factor and optionally wrap the layer for effectively continuous backgrounds.
// Rules: Presentation only; does not own gameplay state. A factor of 0 stays fixed, 1 follows the camera fully, and values between 0 and 1 create depth.
// Dependencies: Godot Node2D.

using Godot;

public partial class ParallaxLayerController : Node2D
{
    [Export(PropertyHint.Range, "0,1,0.01")]
    public float ParallaxFactor { get; set; } = 0.5f;

    [Export]
    public bool LoopX { get; set; }

    [Export]
    public bool LoopY { get; set; }

    [Export]
    public Vector2 LoopSize { get; set; } = Vector2.Zero;

    private Vector2 _initialPosition;
    private Vector2 _initialCameraPosition;
    private bool _initialized;

    public void Initialize(Vector2 initialCameraPosition)
    {
        _initialPosition = GlobalPosition;
        _initialCameraPosition = initialCameraPosition;
        _initialized = true;
        UpdateParallax(Vector2.Zero);
    }

    public void UpdateParallax(Vector2 cameraDelta)
    {
        if (!_initialized)
            return;

        Vector2 position = _initialPosition + cameraDelta * ParallaxFactor;

        if (LoopX && LoopSize.X > 0.0f)
            position.X = WrapPosition(position.X, _initialPosition.X, LoopSize.X);

        if (LoopY && LoopSize.Y > 0.0f)
            position.Y = WrapPosition(position.Y, _initialPosition.Y, LoopSize.Y);

        GlobalPosition = position;
    }

    private static float WrapPosition(float position, float origin, float size)
    {
        float relative = position - origin;
        relative %= size;

        if (relative < 0.0f)
            relative += size;

        return origin + relative;
    }
}
