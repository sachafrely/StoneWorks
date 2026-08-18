// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Displays prestige information and provides the player with the prestige action.
// Responsibilities: Show requirements/reward, confirm the reset, request prestige, and refresh persistent progression afterward.
// Rules: PrestigeUI never performs the reset itself; it sends a command to PrestigeSystem.
// Dependencies: PrestigeSystem read/command interface, GameState read model, EventBus, MainUI.
// Communication: Reads prestige state and reacts to PrestigePerformed.
// Planned functions: Refresh(), ShowRequirements(), ShowReward(), CanPrestige(), HandlePrestigePressed(), OnPrestigePerformed().
// Future considerations: Clearly communicate what is reset and what is permanently kept, especially the Sand Tower and permanent upgrades.
