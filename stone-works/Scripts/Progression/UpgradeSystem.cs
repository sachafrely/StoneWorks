// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Applies upgrade rules for mining, workers, logistics, machines, and warehouse progression.
// Rules: Owns upgrade effects/cost validation; upgrades must be data-driven where practical and must not contain the underlying system's gameplay logic.
// Dependencies: GameState, economy/money interface, UnlockSystem, upgrade data.
// Communication: UI issues upgrade commands; UpgradeSystem validates/applies them and emits upgrade events.
// Must not depend on: UI presentation, physics, or worker/machine internals beyond defined interfaces.
