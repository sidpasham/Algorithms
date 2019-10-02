Design a Cache for a system to update and delete new data and old data respectively.

We can use linkedlist to insert new data at front of the list, so that the old data will be in last node. we can later clean up the last node to remove stale information.
for efficient lookups we use hashtable.

so, we combine hashtable with linkedlist to form a new datastrucuture.

Class Cache
	LinkedList Node
	hashtable<string,node>
	MoveNodestoFront
	RemovenodesfromList
	Insert results into hashtable and linkedlist
	getresults from hashtable

Optimization:
we can expand this cache objects to multiple machines. based on the hash value each machine stores a particular set of cache. If machine i wants to get results
then it calculate the hashfunction, search for the matching hash value machine and asks the machine to return the object if present

we can set a timeout on the cache, so that regardless of the common result, cache is periodically refreshes.


	