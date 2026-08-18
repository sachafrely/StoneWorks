// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Applies prestige/rebirth rules and manages permanent versus resettable progression.
// Responsibilities: Calculate prestige rewards, validate prestige requirements, reset temporary progression, and preserve permanent upgrades.
// Rules: Prestige owns reset/progression rules; it does not implement mining, economy, or worker behavior.
// Dependencies: GameState, Economy/Progression data, EventBus, SaveSystem.
// Communication: UI requests a prestige action; PrestigeSystem validates and applies it; EventBus announces PrestigePerformed.
// Planned functions: CanPrestige(), CalculatePrestigeReward(), PerformPrestige(), ResetRunState(), PreservePermanentProgression(), GetPrestigeCount().
// Future considerations: The persistent Sand Tower and permanent upgrades must be explicitly separated from resettable run state.
