// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Owns the collection and lifecycle of machines placed in the world.
// Responsibilities: Register/spawn machines, find machines by type/location, remove machines, and coordinate machine-wide updates.
// Rules: MachineManager manages machine instances; it does not implement individual processing recipes.
// Dependencies: Machine, ProcessingMachine, GameState/World, EventBus.
// Communication: Mining/logistics systems request machine access; UI sends high-level machine commands.
// Must not depend on: Individual worker movement details or market pricing.
// Planned functions: RegisterMachine(machine), RemoveMachine(machine), GetMachine(id), FindMachine(type), CreateMachine(data), Update(delta).
// Future considerations: Machine placement and upgrades should remain data-driven and compatible with save/load.
