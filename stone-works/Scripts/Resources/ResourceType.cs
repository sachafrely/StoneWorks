// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Enumerates the stable categories/types of resources used by StoneWorks.
// Responsibilities: Provide a single identifier for stones, six gem colors, sand, money, and future materials as the design evolves.
// Rules: ResourceType should remain stable because saves, data files, and systems may depend on these identifiers.
// Dependencies: None.
// Communication: ResourceData, ResourceManager, Economy, Machines, Storage, and UI use ResourceType to identify resources without hard-coded strings.
// Planned functions: IsGem(type), IsPhysical(type), IsCurrency(type), IsProcessable(type), GetDisplayName(type), GetDefaultData(type).
// Future considerations: Avoid changing enum values casually after saves exist; use explicit IDs if the project moves to external data files.
