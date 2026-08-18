// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Container for the current persistent and runtime game state.
// Responsibilities: Hold progression, currencies, worker assignments, resources, upgrades, prestige state, and other data that must survive simulation changes.
// Rules: Store data; do not perform gameplay logic. Systems modify state through clear APIs rather than reaching into unrelated fields.
// Dependencies: Domain data types only; should not depend on UI or rendering.
// Communication: Systems read/write the state through controlled interfaces; SaveSystem serializes the persistent subset.
// Must not depend on: WorkerAI, machine visuals, UI controls, or scene-specific nodes.
// Planned functions: CreateDefaultState(), ResetRunState(), ApplyLoadedState(data), GetPersistentData(), ValidateState().
// Future considerations: Clearly separate persistent state from temporary simulation state so prestige and saving are predictable.
