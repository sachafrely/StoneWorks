// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Defines machine processing inputs, outputs, quantities, and processing duration/requirements.
// Rules: Data/definition only; it must not execute processing or move resources.
// Dependencies: ResourceType/ResourceData; may load definitions from Data/Machines.
// Communication: ProcessingMachine consumes recipes to determine valid transformations.
// Must not depend on: Workers, Economy, UI, physics, or scene nodes.
