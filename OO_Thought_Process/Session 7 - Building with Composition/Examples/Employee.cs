namespace Session_7.Examples;

/**
 * This class showcases the different kinds & cardinalities of composition.
 *
 * There are 4 fields of interest: _department, _jobs, Spouse, and Children
 *
 * ## Kinds
 *
 * _department uses *aggregation* (the underlying object is not exposed)
 * Spouse and Children use *association* (the linked object is directly exposed)
 *
 * _jobs is pseudo-aggregation (?); the top job is exposed (through GetCurrentJob),
 * but the Stack and the rest of the jobs are not exposed
 *
 * ## Cardinalities
 *
 * _department: 1
 * _jobs: 1-n
 * Spouse: 0-1
 * Children: 0-n
 */
public class Employee : Person
{
    public Employee(string name, string company, string departmentName, Job job)
        : base(name)
    {
        Company = company;
        _department = new Department(departmentName);

        _jobs = new Stack<Job>();
        _jobs.Push(job);

        Spouse = null;
        Children = new List<Person>();
    }

    public string Company { get; }

    public DateOnly StartDate => _jobs.Last().StartDate;

    // -------------------------
    // fields using composition

    // type: aggregation (the Department object is not directly exposed)
    // cardinality: single, required 
    private readonly Department _department;

    #region department methods

    public string GetDepartment()
    {
        return _department.Name;
    }

    #endregion

    // type: pseudo-aggregation (the Stack object is not directly exposed, but the top contained jobs is)
    // cardinality: multiple, required 
    private readonly Stack<Job> _jobs;

    #region job methods

    public Job GetCurrentJob()
    {
        return _jobs.Peek();
    }

    public void ChangeJob(Job job)
    {
        _jobs.Push(job);
    }

    #endregion

    // type: association (the linked Person object is directly exposed)
    // cardinality: single, optional 
    public Person? Spouse { get; private set; }

    #region spouse methods

    public void SetSpouse(Person? spouse)
    {
        Spouse = spouse;
    }

    #endregion

    // type: association (the linked List/Person objects are directly exposed)
    // cardinality: multiple, optional 
    public List<Person> Children { get; }

    public override string ToString()
    {
        return string.Format(
            "[Employee] {0}\n  (Company: {1}, Department: {2}, Current Job: {3}, Spouse: {4}, # Children: {5})",
            Name, Company, _department.Name, GetCurrentJob().Description, Spouse?.Name ?? "N/A", Children.Count);
    }
}

public class Department
{
    public string Name { get; }

    public Department(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return "[Department] " + Name;
    }
}

public class Job
{
    public string Description { get; }
    public DateOnly StartDate { get; }

    public Job(string description, DateOnly? startDate = null)
    {
        Description = description;
        StartDate = startDate ?? DateOnlyUtils.Today;
    }

    public override string ToString()
    {
        return "[Job] " + Description;
    }
}

public class Person
{
    public string Name { get; }

    public Person(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return "[Person] " + Name;
    }
}

public static class DateOnlyUtils
{
    public static DateOnly Today => DateOnly.FromDateTime(DateTime.Today);
}