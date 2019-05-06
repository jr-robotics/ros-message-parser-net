using Antlr4.Runtime;
using Joanneum.Robotics.Ros.MessageParser.Antlr;

namespace Joanneum.Robotics.Ros.MessageParser
{
    public abstract class AbstractParser<TDescriptor>
    {
        protected RosMessageParser Parser { get; }

        public AbstractParser(ICharStream input)
        {
            var messageLexer = new RosMessageLexer(input);
            var tokenStream = new CommonTokenStream(messageLexer);
            
            Parser = new RosMessageParser(tokenStream);
        }

        public abstract TDescriptor Parse();

        public abstract TDescriptor Parse(IRosMessageVisitorListener listener);
    }
}