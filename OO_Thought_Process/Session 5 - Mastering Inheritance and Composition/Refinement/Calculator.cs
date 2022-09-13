namespace Session_5.Refinement;

/*
 * This example demonstrates Refinement inheritance
 */

/**
 * The Calculator base class is simple;
 * it has a current value, and methods to add and multiply
 * (subtraction and division were omitted for brevity)
 */
public class Calculator
{
    public decimal Value { get; protected set; }

    public virtual decimal Add(decimal num)
    {
        Value += num;
        return Value;
    }

    public virtual decimal Mult(decimal num)
    {
        Value *= num;
        return Value;
    }

    // other operations (sub, divide, omitted for brevity)
}

/**
 * The RoundingCalculator subclass refines the behavior of
 * the base class - it automatically rounds the result value
 *
 * More specifically:
 *
 * The Calculator class performs arithmetic operations on a value
 *
 * The RoundingCalculator subclass performs arithmetic operations
 * on a value _rounded to a specific level_
 *
 * Here RoundingCalculator's behavior is more specific/refined than
 * the base Calculator's behavior
 */
public class RoundingCalculator : Calculator
{
    public RoundingCalculator(int roundingLevel)
    {
        RoundingLevel = roundingLevel;
        RoundValue();
    }

    public int RoundingLevel { get; }

    private decimal RoundValue()
    {
        Value = Math.Round(Value, RoundingLevel, MidpointRounding.AwayFromZero);
        return Value;
    }

    public override decimal Add(decimal num)
    {
        base.Add(num);
        return RoundValue();
    }

    public override decimal Mult(decimal num)
    {
        base.Mult(num);
        return RoundValue();
    }
}