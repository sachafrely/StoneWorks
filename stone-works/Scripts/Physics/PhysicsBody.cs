// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Physics abstraction for a simulated physical body.
// Rules: Encapsulates position, velocity, collision, and sleep/rest state. Keep the abstraction replaceable for Android optimization.
// Dependencies: PhysicsWorld-level collision/time interfaces; may later implement IPhysicsBody-style contract.
// Communication: PhysicsWorld owns/upgrades bodies; gameplay systems should not manipulate raw physics internals.
// Must not depend on: Economy, UI, worker AI, or rendering-specific code.
