// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: World entity representing the mine and its mining area/state.
// Rules: Provides mine context; does not choose workers, run economy logic, or create physics bodies directly.
// Dependencies: WorldGrid/Terrain and mining domain data.
// Communication: MiningSystem uses Mine as the world-side target for mining operations.
// Must not depend on: WorkerAI, Market, UI, or physics implementation details.
