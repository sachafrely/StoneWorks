// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Owns upgrade levels, costs, effects, and application of non-prestige upgrades.
// Responsibilities: Validate purchases, calculate costs/effects, apply upgrades, expose levels, and publish upgrade events.
// Rules: UpgradeSystem owns progression math; it does not directly implement mining, machines, or UI behavior.
// Dependencies: GameState, EconomySystem, UnlockSystem, upgrade data, EventBus.
// Communication: UI requests an upgrade; Economy validates spending; gameplay systems read resulting modifiers.
// Planned functions: GetLevel(id), GetCost(id), CanPurchase(id), Purchase(id), CalculateEffect(id, level), ApplyUpgrade(id), GetModifier(id).
// Future considerations: Support additive/multiplicative modifiers and clearly define whether each upgrade is temporary or permanent.
