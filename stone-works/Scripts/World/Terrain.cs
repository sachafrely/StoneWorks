// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Defines terrain rules/data and its relationship to the WorldGrid.
// Rules: Terrain state is gameplay data; destruction must be authoritative and reproducible. Do not own visual tile updates.
// Dependencies: WorldGrid, ResourceType/ResourceManager for resource-generation definitions.
// Communication: MiningSystem requests terrain destruction; terrain changes can emit events for dependent systems.
// Must not depend on: WorkerAI, Economy, UI, or physics internals.
