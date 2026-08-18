// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Represents the mine area and its mining-specific state.
// Responsibilities: Define mine bounds/regions, provide mining targets, track progression/depth, and coordinate mine expansion/reset rules.
// Rules: Mine describes mining geography; MiningSystem performs mining actions and WorldGrid/Terrain owns the actual cell data.
// Dependencies: WorldGrid, Terrain, MiningSystem, GameState.
// Communication: MiningSystem queries mine targets and updates mine progression; workers receive jobs pointing into the mine.
// Planned functions: Initialize(), GetMiningArea(), GetNextMiningTarget(), GetDepth(), Expand(), ResetMine(), IsTargetValid(position).
// Future considerations: Resolve the long-term mine-extension model so the mine can feel effectively endless without creating unreasonable walking distances or unbounded world data.
