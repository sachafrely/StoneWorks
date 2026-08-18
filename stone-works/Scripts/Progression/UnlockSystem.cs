// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Controls feature and content unlock conditions.
// Responsibilities: Check requirements, record unlocked features, expose unlock state, and publish unlock events.
// Rules: UnlockSystem decides whether something is unlocked; it does not implement the unlocked feature.
// Dependencies: GameState, progression/resource data, EventBus.
// Communication: Progression/economy systems provide current values; UI queries unlock state and reacts to unlock events.
// Planned functions: IsUnlocked(id), CanUnlock(id), Unlock(id), EvaluateUnlocks(), GetUnlockRequirement(id), ResetTemporaryUnlocks().
// Future considerations: Make requirements data-driven so new machines, worker counts, resources, and UI features can be added without code changes.
