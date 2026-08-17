// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Base representation of a machine entity and its common state.
// Rules: Machine describes state/capabilities; processing rules belong to ProcessingMachine/recipes and machine systems.
// Dependencies: MachineRecipe where applicable; Resource/Storage interfaces for inputs/outputs.
// Communication: MachineManager owns lifecycle; ProcessingMachine executes transformation; completion is reported via EventBus.
// Must not depend on: UI, Economy, worker AI, or direct physics internals.
