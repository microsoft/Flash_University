//Hashcodes are used for a lot of things, but fundamentally they are used to be able to be placed into a hashtable
using HashCode;

int a = 1;
int b = 1;

//creating 2 classes in the stack
Console.WriteLine(a.GetHashCode().Equals(b.GetHashCode()));
//what is the significance of this?

//hashcode being equal does not mean two objects are equal, but it should be way, way more often than not
SimpleClass sc1 = new SimpleClass();
Console.WriteLine("The unchanged hashcode value {0}", sc1.GetHashCode());
sc1.x = 1;
sc1.y = 2;
Console.WriteLine("The changed hashcode value {0}", sc1.GetHashCode());
SimpleClass sc2 = new SimpleClass();
sc2.x = 1;
sc2.y = 2;
Console.WriteLine("The hashcode value for identical objects {0}", sc2.GetHashCode());
Console.WriteLine("are shc 1 and shc equal? {0} ==? {1}", sc1.Equals(sc2), sc1 ==sc2);
sc2 = sc1;
Console.WriteLine("After forcing equality {0} ==? {1}, hashcodes{2}", sc1.Equals(sc2), sc1 == sc2, sc1.GetHashCode().Equals(sc2.GetHashCode()));

//Is this the behavior we want?
//ideally, equal object values gets object equality and equal hashcodes
//uncomment out the fix in simplehashcode

BetterEquals be1 = new BetterEquals();
BetterEquals be2 = new BetterEquals();

Console.WriteLine(be1.x==be2.x&&be1.y==be2.y);
Console.WriteLine(be1.x);
Console.WriteLine(be1.Equals(be2));
be1.x = 1;
be1.y = 2;
Console.WriteLine(be1.Equals(be2));
Console.WriteLine(be1.GetHashCode().Equals(be2.GetHashCode()));

BetterHashCode bhc1 = new BetterHashCode();
BetterHashCode bhc2 = new BetterHashCode();
Console.WriteLine(bhc1.GetHashCode());//all values should be 0, so I expect this to return equivalent of all 1s
Console.WriteLine(bhc1.GetHashCode().Equals(bhc2.GetHashCode()));
Console.WriteLine(bhc1.Equals(bhc2));

bhc1.y = Int32.MaxValue;

Console.WriteLine(bhc1.GetHashCode());

bhc2.x = Int32.MinValue;

Console.WriteLine(bhc2.x);


Console.WriteLine(bhc1.GetHashCode().Equals(bhc2.GetHashCode()));
//can you break this hashcode to get a value stt equals is not true but hashcodes are?




