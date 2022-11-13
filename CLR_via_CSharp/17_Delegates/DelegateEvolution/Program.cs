ThreadPool.QueueUserWorkItem(SomeAsyncTask, 5);
ThreadPool.QueueUserWorkItem(obj => Console.WriteLine(obj), 7);

void SomeAsyncTask(object o)
{
    Console.WriteLine(o);
}