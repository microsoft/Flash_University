using System.Collections;
using GenericsPerf;

long numberOfElements = 100000000;
ValueTypePerfTest(numberOfElements);
ReferenceTypePerfTest(numberOfElements);


static void ValueTypePerfTest(long numberOfElements)
{
    using (new OperationTimer("List<Int32>"))
    {
        var list = new List<long>();
        for (var i = 0; i < numberOfElements; i++)
        {
            // 'No Boxing' 
            list.Add(i);
            var x = list[i];
        }

        // force gc, nice trick to remember
        list = null;
    }

    using (new OperationTimer("ArrayList<Int64>"))
    {
        var arrayList = new ArrayList();
        for (var i = 0; i < numberOfElements; i++)
        {
            // boxing
            arrayList.Add(i);

            // unboxing
            var x = (int)(arrayList[i] ?? 0);
        }

        // force gc, nice trick to remember
        arrayList = null;
    }
}

static void ReferenceTypePerfTest(long numberOfElements)
{
    using (new OperationTimer("List<String>"))
    {
        var list = new List<string>();
        for (var i = 0; i < numberOfElements; i++)
        {
            list.Add("X"); //boxing
            var x = list[i]; //no
        }

        // force gc, nice trick to remember
        list = null;
    }

    using (new OperationTimer("ArrayList<String>"))
    {
        var list = new ArrayList();
        for (var i = 0; i < numberOfElements; i++)
        {
            list.Add("X"); //boxing
            var x = (string)(list[i] ?? ""); //unboxing
        }

        // force gc, nice trick to remember
        list = null;
    }
}