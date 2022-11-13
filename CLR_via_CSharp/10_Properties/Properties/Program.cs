Console.WriteLine("Hello, this is 'common way of doing things. Across Languages");

Employee e = new Employee();
e.Name = "Jeff The Richter";
e.Age = 48;

Console.WriteLine(e.Name);

//What is the problem with this?

e.Age = -5;

//giving direct access (as we've seen in OO, allows for some unconstrained behavior)

EncapsulatedEmployee encEmployee = new EncapsulatedEmployee();
encEmployee.SetName("Jeff of Richter");
Console.WriteLine(encEmployee.GetName());

PropertyEmployee propEmployee = new PropertyEmployee();
propEmployee.Age = 4;

Console.WriteLine(System.DateTime.Now.Ticks);
Console.WriteLine(System.DateTime.Now.Ticks);
Console.WriteLine(System.DateTime.Now.Ticks);
Console.WriteLine(System.DateTime.Now.Ticks);


//OCI

Employee donkey = new Employee() { Name = "donkey", Age = 50 };
//Equivalent to:
Employee cat = new Employee();
cat.Name = "kitten";
cat.Age = 3;


Employee realCat = cat;


//Console.WriteLine(donkey.Name);

//string s = new Employee{Name = "srikar", Age = 28 }.GetHashCode().ToString();


//Console.WriteLine(s);

//String m = new LazyEmployee { _name = "srikar", _age = 28 }.GetHashCode().ToString();
//Console.WriteLine(m);

public sealed class Employee
{
    public String Name;
    public Int32 Age;
}


//downlsides, more methods to implement
//more code to write


public sealed class EncapsulatedEmployee
{
    private String Name;
    private Int32 Age;

    public String GetName()
    {
        return Name;
    }
    public  void SetName(String name)
    { 
        Name = name;
    }
    public int GetAge()
    {
        return Age;
    }
    public void SetAge(int newAge)
    {
        Age = newAge;
    }
}

public sealed class PropertyEmployee
{
    private String m_name;
    private Int32 m_age;

    //value = the value passed in
    //equivalent to set(value){}
    public String Name
    {
        get { return m_name; }
        set { m_name = value; }
    }

    public Int32 Age
    {
        get { return m_age; }
        set {
            if (m_age < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                m_age = value;
            } }
    }
}

public sealed class LazyEmployee
{
    public String _name { get;  private set; }
    private Int32 _age { get;  set; }

    public LazyEmployee()
    {
        _name = "filler";
    }
}