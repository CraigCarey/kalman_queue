# ProducerConsumerBlocking

A simple C# console app demonstrating implementation of a thread-safe single-producer, single-consumer lock-free FIFO queue.

Uses BlockingCollection<T>, a collection that can encapsulate certain other collections and provide addition services, such as blocking a thread until there's an item on the queue to be processed.
BlockingCollection<T> can wrap anything that implements the IProducerConsumerCollection<T> Interface, i.e. ConcurrentQueue, ConcurrentStack and ConcurrentBag

### Version
1.0.0

### Todos

 - Add XML documentation?

### License

The MIT License (MIT)

Copyright (c) 2015 Craig Carey

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.