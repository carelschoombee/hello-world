using System;

public class Class1
{
    public Class1()
    {
        Console.WriteLine();

        try
        {

        }
        catch (Exception)
        {

                throw;
        }

                try
                {

                }
                finally
                {

        }

        for (int i = 0; i < length; i++)
        {

        }

        for (int i = length - 1; i >= 0; i--)
        {

        }

        foreach (var item in collection)
        {

        }

        var names = new List<string>();
        foreach (var name in collection)
        {

        }

        while (true)
        {

        }

        do
        {

        } while (true);
    }

    private int myVar;

    // override object.Equals
    public override bool Equals(object obj)
    {
        //       
        // See the full list of guidelines at
        //   http://go.microsoft.com/fwlink/?LinkID=85237  
        // and also the guidance for operator== at
        //   http://go.microsoft.com/fwlink/?LinkId=85238
        //

        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        // TODO: write your implementation of Equals() here
        throw new NotImplementedException();
        return base.Equals(obj);
    }

    // override object.GetHashCode
    public override int GetHashCode()
    {
        // TODO: write your implementation of GetHashCode() here
        throw new NotImplementedException();
        return base.GetHashCode();
    }

    public int MyProperty
    {
        get { return myVar; }
        set { myVar = value; }
    }

}
