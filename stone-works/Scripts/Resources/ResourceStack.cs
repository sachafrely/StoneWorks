// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Represents a stack/quantity of one resource type, especially useful for inventories and storage.
// Responsibilities: Track type and amount, combine compatible stacks, split quantities, and validate capacity constraints.
// Rules: ResourceStack is logical inventory data; it is not a physical pile of objects.
// Dependencies: ResourceType/ResourceData.
// Communication: WorkerInventory and Storage use stacks for efficient transfers; ResourceManager may convert between stacks and individual resources.
// Planned functions: Add(amount), Remove(amount), Split(amount), Merge(other), CanMerge(other), IsEmpty(), GetAmount(), GetType().
// Future considerations: Use stacks for warehouses/offline calculations so thousands of individual physical objects do not need to remain simulated.
