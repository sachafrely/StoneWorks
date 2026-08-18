// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Serializable representation of all persistent game data required to restore a save.
// Responsibilities: Store player economy, progression, workers, upgrades, world progression, prestige state, market state, and save metadata.
// Rules: SaveData contains data only; it must not execute gameplay or reference scene nodes.
// Dependencies: Serializable domain structures such as GameState, ResourceStack, upgrade data, and worker state.
// Communication: SaveSystem creates/loads SaveData; GameState applies the loaded values.
// Planned functions: CreateFromGameState(state), ApplyToGameState(state), ValidateVersion(), Migrate(oldVersion), GetSaveVersion().
// Future considerations: Version the schema from the beginning so future changes can migrate old saves safely.
