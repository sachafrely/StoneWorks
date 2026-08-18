// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Specialized machine that transforms resource inputs into outputs over time.
// Responsibilities: Accept valid inputs, run a recipe, track processing progress, create outputs, and report completion.
// Rules: ProcessingMachine owns processing timing, not resource physics or worker movement.
// Dependencies: Machine, MachineRecipe, ResourceManager/Storage, GameTime, EventBus.
// Communication: Logistics supplies inputs; completion creates logical resources and publishes MachineFinished/GemProduced events; physics may then create physical output bodies.
// Must not depend on: UI implementation or market logic.
// Planned functions: StartProcessing(), CanProcess(), ConsumeInputs(), AdvanceProcessing(delta), CompleteProcessing(), CreateOutputs(), CancelProcessing().
// Future considerations: Support machine speed upgrades, queues, multiple recipes, and offline simulation without running every physics frame.
