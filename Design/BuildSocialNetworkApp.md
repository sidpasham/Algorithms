Build a Social Network App

Graph --> By treating each person as node and edge between nodes indicating the two users are frnds

If I wanted a path between two frnds, start with one person and do BFS for graph. for optimisation we can do bi-directional BFS on graph.
this means one searches from the source and another searches from the destination, when searches collide we know that the we have found the path.

Class and functions:

Class Person --> with all person IDs
- For each friend ID: int machine index =  getMachineIDForUser( person ID);
- Go to machine #machine_index
- On that machine, do: Person friend =  getPersonWithID( person_id);

Class BFSData --> Queue --> tovisit
				  Dictionary --> visited

Function : Find Bi-Directional BFS (Dictionary People, int source, int destination)
```
	while(not source.isFinished and not dest.isFinished)

	search from source for each level
		if search found then merge paths

	search from destination for reach level
		if search found then merge paths
```

Function:
* searching at each level(ictionary People, BFSData primary, BFSData secondary)
* get count as primary size
```
for each primary level
	get person id and check if secondary contains that ID
		if contains then return the person

		add frnds to the queue
```



Bi-Directinal BFS is generally fast than traditional BFS, but we need to know about the source and destination nodes

when there are lot of machines, then try to do batch jumps to find the machine ID and associated Person ID
We can do sharding for the machines with their lastnames or countries or states and so on,. this will reduce the jumps
we can put all the nodes in hashtable and check if node is visited or not in multiple server environment

