// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Inventory owned by an individual worker for temporary resource carrying.
// Responsibilities: Add/remove carried resources, enforce carrying capacity, expose contents, and support transfer to storage or machines.
// Rules: WorkerInventory owns carried quantities, not warehouse storage and not market value.
// Dependencies: ResourceStack, ResourceType/ResourceManager.
// Communication: WorkerAI/logistics requests pickup/drop-off; Storage receives delivered stacks; ResourceManager validates resource identity when needed.
// Planned functions: Add(stack), Remove(type, amount), Has(type, amount), GetAmount(type), GetCapacity(), GetFreeCapacity(), Clear(), TransferTo(destination).
// Future considerations: Keep capacity small and explicit; support mixed-resource carrying only if the gameplay design requires it.
