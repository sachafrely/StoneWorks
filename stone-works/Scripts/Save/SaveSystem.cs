// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Owns saving/loading of persistent game state and save-file lifecycle.
// Responsibilities: Save, load, validate, version, migrate, and recover save data; expose safe save/load operations to Game.
// Rules: SaveSystem serializes state; it does not own gameplay rules and must never save scene/node references.
// Dependencies: SaveData, GameState, filesystem/serialization layer, EventBus if save notifications are needed.
// Communication: Game requests load/save; SaveSystem returns validated state; UI may request manual save but does not manipulate files directly.
// Planned functions: Save(), Load(), HasSave(), DeleteSave(), ValidateSave(), MigrateSave(), CreateBackup(), GetSavePath().
// Future considerations: Auto-save timing, crash-safe writes, corruption recovery, multiple slots, and offline timestamp handling should be explicit.
