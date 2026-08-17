// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Executes machine processing: transforms defined inputs into outputs after processing requirements are met.
// Rules: Produces outputs but does not decide where they go. Output creation should flow through ResourceManager and then physics/logistics as appropriate.
// Dependencies: Machine, MachineRecipe, ResourceManager, Storage/input state, GameTime/SimulationSystem, EventBus.
// Communication: Logistics supplies inputs; processing completion creates logical output and emits MachineFinished/GemProduced-style events.
// Must not depend on: UI, market pricing, or direct worker movement/physics manipulation.
