// StoneWorks — ROLE / RULES / DEPENDENCIES
// Role: Concrete logistics job describing movement of a resource from one location to another.
// Responsibilities: Store source, destination, resource, quantity, priority, and lifecycle state; validate that the job is still possible.
// Rules: TransportJob contains job data and validation; it does not move the worker itself.
// Dependencies: ResourceType/ResourceStack, source/destination storage or world locations, Worker role data.
// Communication: JobSystem creates and reserves the job; WorkerAI executes it; LogisticsSystem reacts to completion/failure.
// Planned functions: CanExecute(), Reserve(worker), GetSource(), GetDestination(), GetResource(), GetQuantity(), MarkComplete(), Cancel(reason).
// Future considerations: Support partial loads, interrupted jobs, unavailable destinations, and carrying limits.
