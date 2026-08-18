// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Displays available upgrades, their costs, levels, effects, and unlock state.
// Responsibilities: Build/refresh upgrade entries, show affordability, and send purchase commands.
// Rules: UpgradeUI does not calculate authoritative costs/effects and never edits progression state directly.
// Dependencies: UpgradeSystem, EconomySystem read/command interfaces, UnlockSystem, EventBus.
// Communication: Reads upgrade state and reacts to UpgradePurchased, MoneyChanged, and Unlock events.
// Planned functions: Refresh(), RefreshUpgrade(id), ShowCost(id), ShowEffect(id), IsAffordable(id), HandlePurchase(id), OnUpgradePurchased().
// Future considerations: Keep UI generic so new upgrades can be added from data without new hard-coded controls.
