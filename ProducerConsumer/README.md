# ProducerConsumerBlocking

A simple C# console app demonstrating implementation of a thread-safe single-producer, single-consumer lock-free FIFO queue.

Uses BlockingCollection<T>, a collection that can encapsulate certain other collections and provide addition services, such as blocking a thread until there's an item on the queue to be processed.
BlockingCollection<T> can wrap anything that implements the IProducerConsumerCollection<T> Interface, i.e. ConcurrentQueue, ConcurrentStack and ConcurrentBag

### Version
1.0.0

### Todos

 - Write Unit Tests
 - Add XML documentation?

### License

The MIT License (MIT)

Copyright (c) 2015 Craig Carey

Permission is hereby granted, fre