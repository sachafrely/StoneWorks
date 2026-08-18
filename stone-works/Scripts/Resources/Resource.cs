// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Logical definition of a resource that exists in the game.
// Responsibilities: Identify resource type, quantity/quality where applicable, lifecycle state, and ownership/location metadata.
// Rules: Resource represents gameplay data; it does not know how it is rendered or physically simulated.
// Dependencies: ResourceType and ResourceData.
// Communication: ResourceManager owns collections of resources; ResourcePhysics may create a physical body; Storage/Inventory may hold logical resources.
// Planned functions: Initialize(data), SetAmount(amount), AddAmount(amount), RemoveAmount(amount), GetType(), GetAmount(), CanMergeWith(other), MarkDestroyed().
// Future considerations: Distinguish individual physical stones/gems from abstract stored quantities so idle/offline calculations remain efficient.
