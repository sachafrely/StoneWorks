// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Logical physics body representing position, velocity, collision state, and physical properties of a simulated object.
// Responsibilities: Store/update physical state and expose the minimum data PhysicsWorld needs for simulation.
// Rules: PhysicsBody is not responsible for gameplay meaning, inventory, selling, or rendering.
// Dependencies: Basic math/physics data only; optionally stable resource identity.
// Communication: PhysicsWorld updates bodies; ResourcePhysics maps logical resources to bodies.
// Planned functions: Integrate(delta), ApplyForce(force), SetPosition(position), SetVelocity(velocity), ResolveCollision(other), Sleep(), Wake().
// Future considerations: Keep this abstraction lightweight enough to support an optimized custom resource-physics implementation on Android.
