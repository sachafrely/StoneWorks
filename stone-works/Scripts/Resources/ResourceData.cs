// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Static/data definition describing a resource type and its properties.
// Responsibilities: Store display identity, category, base value, physical properties, processing behavior, and storage rules.
// Rules: ResourceData is configuration, not runtime state. Keep it independent from individual Resource instances.
// Dependencies: ResourceType and serializable primitive data only.
// Communication: ResourceManager, ResourcePhysics, machines, markets, and UI read this data through stable accessors.
// Planned functions: Validate(), GetBaseValue(), GetMass(), GetFriction(), GetBounciness(), IsPhysical(), IsSellable(), IsProcessable().
// Future considerations: Keep balance values data-driven so economy and physics tuning do not require rewriting gameplay systems.
