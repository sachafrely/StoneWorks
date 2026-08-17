// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Owns the collection/lifecycle of machine instances.
// Rules: Registers, spawns, removes, and exposes machines; does not implement each machine's processing rules.
// Dependencies: Machine, MachineRecipe, World/placement data, GameState.
// Communication: ProcessingMachine performs transformations; logistics supplies inputs; completion events notify other systems.
// Must not depend on: UI presentation or Economy implementation.
