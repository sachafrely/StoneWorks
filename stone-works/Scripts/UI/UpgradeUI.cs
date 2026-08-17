// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Displays available upgrades, costs, levels, and upgrade controls.
// Rules: UI only requests upgrades; UpgradeSystem validates costs and applies effects.
// Dependencies: UpgradeSystem/UnlockSystem read-only state, economy/money view, EventBus.
// Communication: Upgrade button → UpgradeSystem command; upgrade/unlock events → UI refresh.
// Must not depend on: direct worker/machine/mining internals or physics.
