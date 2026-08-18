// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Data definition for a machine processing recipe.
// Responsibilities: Describe required inputs, output resources, processing duration, quantities, and future efficiency modifiers.
// Rules: Recipes are data, not execution logic. ProcessingMachine interprets them.
// Dependencies: ResourceType/ResourceData only.
// Communication: ProcessingMachine reads recipes; upgrades may modify effective duration/throughput without changing the base recipe.
// Must not depend on: Workers, UI, physics, or economy.
// Planned functions: Validate(), GetInputRequirements(), GetOutputDefinition(), GetProcessingDuration(), GetOutputAmount().
// Future considerations: Keep recipes serializable/data-driven so new machines can be added without changing core code.
