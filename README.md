# DeepReader
High-performance streaming- and history-solution for EOSIO-based chains leveraging deep-ming-loggging while reducing the overhead of hosting dfuse or firehose

#### WORK IN PROGRESS
The project contained is not fully working yet
 - [x] Deserializationa and re-construction of blocks 
 - [x] Postprocessing
 - [x] Data-Storage using Microsoft Faster 

## Description
Deepreader reads and deserializes deep-mind logs (actions, traces, deltas, permission-operations, limit-ops etc.) and re-constructs eosio-blocks similar to dfuse.

Deepreader postprocesses and "flattens" blocks and transactions to serialize and store the relevant data while reducing storage size and increasing performance (only value types/blittable types stored on the stack are used). 

Postprocessed data is serialized and highly compressed to reduce the storage-consumption.

Currently planned storage-backends are 

 - Microsoft Faster (https://github.com/microsoft/FASTER) with Microsoft Fishstore integration for predicate subset function based indexing https://github.com/microsoft/FishStore . 
 - Elasticsearch (https://github.com/elastic/elasticsearch-net) (while storing highly compressed data while indexing full objects to reduce storage-consumption)

to offer powerful ingestion layers and query-capabilites for the stored data.

Currently planned APIs are

 - REST (ASP.NET Web API)
 - GraphQl Queries and Subscriptrions using ChilliCreams HotChocolate (https://github.com/ChilliCream/hotchocolate) 
