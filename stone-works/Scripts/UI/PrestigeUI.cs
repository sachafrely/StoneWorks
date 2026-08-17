// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Displays prestige requirements/reward and provides the prestige command.
// Rules: UI cannot calculate or perform the reset; PrestigeSystem is authoritative.
// Dependencies: PrestigeSystem/UpgradeSystem/UnlockSystem read-only state, GameState view, EventBus.
// Communication: Prestige button → PrestigeSystem; PrestigePerformed → UI refresh.
// Must not depend on: worker, machine, economy, physics, or save internals.
