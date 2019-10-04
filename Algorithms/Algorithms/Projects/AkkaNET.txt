I wanted to use it in the new ETL Process, and implement different actors for each part of the workflows (pricing and surveillance).
 
My thinking at the time was to create a number of Akka.net "child" actors that would (individually) do specific things such as:
 
* Download Freddie Performance data from their website (automatically)
* Download Fannie Performance data from their website (automatically)
* Load a Freddie Performance file to the database (using the Freddie parsers that we built)
* Load a Fannie Performance file to the database (using the Fannie parsers that we built)
* Load a Fannie Premium file to the database (using the Fannie parsers that we built)
* Upload loan data to SAS via SFTP (to be processed by MIP)
* Download modeling results from SAS via SFTP (to be post-processed)
* Apply post-processing on modeling results (calling the Python API that was being developed)
* Generate / refresh data for GSE CRT Composition report
* Generate / refresh data for GSE CRT Portfolios report
* Refresh a Power BI report data set (using the Power BI Rest API)
* Publish Power BI reports to the cloud (using Power BI REST API)
etc...
 
Each bullet point above would be a different micro-service (or "child" actor in Akka.net terms), and they would be all independent of each other 
and with a well-defined messaging API for data input and output.
 
With those components, you can then create "coordinator" actors, that do the orchestration, for example, to execute a specific workflow (or part of it).
So basically actors that calls the necessary "child" actors in some order, to achieve a goal... 
For example, if you just received a Freddie pricing loan tape, and want to have it appear in the GSE CRT Composition report in Power BI, you would have an actor that:
 
* Sends a message to the actor that knows how to "Load a Freddie Performance file to the database"
* Then sends a message to the actor that knows how to "Generate / refresh data for GSE CRT Composition report"
* Then sends a message to the actor that knows how to "Refresh a Power BI report data set" to get the data for the GSE CRT Composition refreshed
* Finally, sends a message to the actor that knows how to "Publish Power BI reports to the cloud" to get the GSE CRT Composition updated for everybody


How to scale the application?

* You can choose how many instances of a single actor you have, and scale based on the throughput you need vs the resources you have available.
 
For example, if you have 5 Freddie files to import, you can spin up 5 instances of the "FreddieDBLoadActor" and each instance will take care of loading a single file. 
With all 5 files being loaded in parallel.
So 6 actors total - 1 coordinator actor to coordinate + 5 actors to execute the work, all reporting progress to the coordinator actor.
 
Of course, for optimal performance, you'd configure in Akka the maximum number of instances of an actor that you want to have at the same time, 
based on the resources you have (Cpu, Memory, Disk) for optimal performance.
 
For example, If you have 1000 files to import, you might not want to have 1000 actors running at the same time 
and competing for CPU/Memory/Disk... 
If you tell Akka to only have 10 actors of a specific type, then the 1000 files will be imported through the 10 actors and 
files would be waiting in the queue until there's an actor available to process them.
 
Every actor's process is synchronous and single-threaded... So whenever you need to scale, you just spin more actors of the same type.
Basically almost every activity that a user does, ends up spinning a dedicated actor just for that action - or re-using an existing actor from a defined pool of actors.
