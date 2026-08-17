// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Saves and loads authoritative game state.
// Rules: Serialize only stable game data; do not serialize transient scene/physics objects. Save/load must preserve explicit GameState boundaries.
// Dependencies: GameState, SaveData, filesystem/persistence layer, GameTime for timestamps/offline calculation where required.
// Communication: Game initializes/loads through SaveSystem; periodic/manual saves capture current state; loaded data is handed back to systems.
// Must not depend on: UI, rendering, or individual gameplay implementation details beyond serializable state contracts.
