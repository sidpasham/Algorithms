There are 10 Billion URL, how do you detech duplicate URls?

for 10 Billion URLs, we needTB of data. we cannot store 4TB of data in memory. 

Solution 1:
we can use mapreduce here with distributed file storage system.
Map:
	we can reduce the URLs into different chunks and store it text file which has the hashvalue as the name. Ex: filename<x>.txt where x => hash(u) % 4000.
Reduce:	
	Then we can get that chunk and store it in dictionary and find the duplicates if exists or not.

Solution 2:
	Here instead of using different files, we have the same concept of MapReduce, but we would send the chunks to different machines.
	We can parallelize the finding in these chunks accross multiple machine, which can be faster.
	We need to carefully consider how to handle failure in this solution




