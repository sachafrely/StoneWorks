// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Authoritative grid gameplay data for mine terrain and occupancy.
// Rules: Represents cell state such as empty, stone, dirt, ore, occupied, and destroyed. Visual tiles are only a representation.
// Dependencies: ResourceType/domain data where terrain cells produce resources; World owns the grid.
// Communication: Mining/Terrain query and mutate the grid through controlled operations.
// Must not depend on: Godot tile rendering, UI, worker AI, or physics implementation.
