using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexExample;

namespace RegexExampleTests
{
    [TestClass]
    public class Test1
    {
        private IRegularExpression _regExpMock;

        string[] database = { "david.jones@prosewa+re.com", "d.j@server1.proseware.com",
                                    "jones@ms1.proseware.com", "j.@server1.proseware.com",
                                    "j@proseware.com9", "js#internal@proseware.com",
                                    "j_9@[129.126.118.1]", "j..s@proseware.com",
                                    "js*@proseware.com", "js@proseware..com",
                                    "js@proseware.com9", "j.s@server1.proseware.com",
                                    "\"j\\\"s\\\"\"@proseware.com", "js@contoso.中国" };        
        // This will get executed fiIrst before test methods
        [TestInitialize]
        public void Initialize()
        {
            _regExpMock = new RegexUtilities();
        }
                   
        [TestMethod]
        public void FindMatchTest1()
        {
            // Reference Link
            // https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference
            string pattern = @"(?:^|\W)com(?:$|\d)";
            _regExpMock.Validate(database, pattern);            
        }

        [TestMethod]
        public void FindMatchTest2()
        {
            string pattern = @"(?:^|\W)com(?:$|\W)";
            _regExpMock.Validate(database, pattern);
        }
    }
}
