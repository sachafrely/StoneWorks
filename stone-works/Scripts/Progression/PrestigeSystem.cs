// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Calculates prestige rewards, resets temporary progression, preserves permanent progression, and starts a new run.
// Rules: Prestige is progression logic, not worker/mining/economy implementation. Reset boundaries must be explicit in GameState/SaveData.
// Dependencies: GameState, UpgradeSystem/UnlockSystem, Economy state, EventBus, SaveSystem boundary.
// Communication: UI requests prestige; system validates and applies reset/reward, then emits PrestigePerformed.
// Must not depend on: UI internals, physics, or worker implementation details.
