// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Determines which workers, machines, mine features, upgrades, and other content are unlocked.
// Rules: Unlock state is authoritative progression data; it does not instantiate or implement the unlocked feature.
// Dependencies: GameState, UpgradeSystem/progression data, economy/progression requirements, EventBus.
// Communication: Systems query unlock state; successful unlocks emit WorkerUnlocked/content-unlocked events.
// Must not depend on: UI implementation or concrete worker/machine gameplay logic.
