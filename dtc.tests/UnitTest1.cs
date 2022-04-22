using PactNet.Matchers;
using System.Dynamic;
using Xunit;

namespace dtc.tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var obj = new Customer()
        {
            Id = 0,
            Name = "Wolf",
            Dob = "11/01/2018"
        };

        dynamic dObj = new ExpandoObject();
        dObj.id = Match.Type(obj.Id);
        dObj.Name = obj.Name;
        dObj.Dob = Match.Type(obj.Dob);
    }
}