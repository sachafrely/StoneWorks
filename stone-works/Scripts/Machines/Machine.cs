// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Base logical representation of a machine in the game world.
// Responsibilities: Store machine identity/state, input/output interfaces, operational status, and upgrade-relevant properties.
// Rules: A machine describes what it is; processing rules belong in ProcessingMachine and recipes.
// Dependencies: MachineRecipe, ResourceType/ResourceManager, EventBus.
// Communication: MachineManager controls machine instances; processing completion publishes events for resources/statistics/UI.
// Must not depend on: Worker movement, market logic, or UI controls.
// Planned functions: Initialize(), CanOperate(), SetEnabled(enabled), GetInputState(), GetOutputState(), ApplyUpgrade(upgrade), GetStatus().
// Future considerations: Keep machine logic independent from its visual scene so machines can be simulated and tested without rendering.
