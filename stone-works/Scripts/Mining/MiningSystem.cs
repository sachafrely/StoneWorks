// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Owns mining gameplay rules: available mining work, terrain destruction, and resource generation from mining.
// Rules: Mining creates logical resources; it does not own their physics. It should not decide worker selection.
// Dependencies: Mine, WorldGrid/Terrain, JobSystem/MiningJob, ResourceManager, EventBus.
// Communication: JobSystem assigns MiningJob; MiningSystem resolves it, changes terrain, creates resources, and emits relevant events.
// Must not depend on: Physics internals, Economy, UI, or worker movement implementation.
