using System.IO;
using Antlr4.Runtime;

namespace Joanneum.Robotics.Ros.MessageParser
{
    public class ActionParser : DescriptorParser<ActionDescriptor>
    {
        public ActionParser(ICharStream input) : base(input)
        {
        }

        public override ActionDescriptor ParseDescriptor()
        {
            var visitor = new RosMessageVisitor();
            var context = Parser.ros_action();

            return (ActionDescriptor) visitor.Visit(context);
        }
        
        public static ActionDescriptor Parse(string input)
        {
            return new ActionParser(new AntlrInputStream(input)).ParseDescriptor();
        }

        public static ActionDescriptor Parse(Stream input)
        {
            return new ActionParser(new AntlrInputStream(input)).ParseDescriptor();
        }
    }
}