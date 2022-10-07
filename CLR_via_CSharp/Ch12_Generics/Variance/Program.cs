Func<object, ArgumentException> fn1 = null;
Func<string, Exception> fn2 = fn1;

var e = fn2("");

public delegate TResult Func<in T, out TResult>(T arg);