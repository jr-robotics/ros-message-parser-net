using Xunit;

namespace Joanneum.Robotics.Ros.MessageParser.Tests
{
    public class RosbagMessageDefinitionParserTests
    {
        [Fact]
        public void Can_parse_rosbag_message_without_nested_types()
        {
            var input = @"int8 x     # This is a really simple message";

            var actual = new RosbagMessageDefinitionParser(input).Parse();

            Assert.NotNull(actual);
            Assert.NotNull(actual.Message);
            Assert.Empty(actual.NestedMessages);
        }
        
        [Fact]
        public void Can_parse_rosbag_message_with_empty_message()
        {
            var input = string.Empty;

            var actual = new RosbagMessageDefinitionParser(input).Parse();

            Assert.NotNull(actual);
            Assert.NotNull(actual.Message);
            Assert.True(actual.Message.IsEmpty);
            Assert.Empty(actual.NestedMessages);
        }

        [Fact]
        public void Can_parse_rosbag_with_nested_message()
        {
            var input = @"byte DEBUG=1 
byte INFO=2 
byte WARN=4 
byte ERROR=8 
byte FATAL=16 
Header header
byte level
string name 
string msg 
string file 
string function 
uint32 line 
string[] topics 
================================================================================
MSG: std_msgs/Header
uint32 seq
time stamp
string frame_id";
            
            var actual = new RosbagMessageDefinitionParser(input).Parse();

            Assert.NotNull(actual);
            Assert.NotNull(actual.Message);
            Assert.Single(actual.NestedMessages);

            var nestedMessage = actual.NestedMessages[new RosTypeInfo("Header", "std_msgs")];

            Assert.NotNull(nestedMessage);
            Assert.False(nestedMessage.IsEmpty);
        }

        [Fact]
        public void Can_parse_rosbag_with_multiple_nested_messages()
        {
            var input = @"# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======

Header header
actionlib_msgs/GoalStatus status
MoveArmOnTrajectoryResult result

================================================================================
MSG: std_msgs/Header
# Standard metadata for higher-level stamped data types.
# This is generally used to communicate timestamped data 
# in a particular coordinate frame.
# 
# sequence ID: consecutively increasing ID 
uint32 seq
#Two-integer timestamp that is expressed as:
# * stamp.sec: seconds (stamp_secs) since epoch (in Python the variable is called 'secs')
# * stamp.nsec: nanoseconds since stamp_secs (in Python the variable is called 'nsecs')
# time-handling sugar is provided by the client library
time stamp
#Frame this data is associated with
# 0: no frame
# 1: global frame
string frame_id

================================================================================
MSG: actionlib_msgs/GoalStatus
GoalID goal_id
uint8 status
uint8 PENDING         = 0   # The goal has yet to be processed by the action server
uint8 ACTIVE          = 1   # The goal is currently being processed by the action server
uint8 PREEMPTED       = 2   # The goal received a cancel request after it started executing
                            #   and has since completed its execution (Terminal State)
uint8 SUCCEEDED       = 3   # The goal was achieved successfully by the action server (Terminal State)
uint8 ABORTED         = 4   # The goal was aborted during execution by the action server due
                            #    to some failure (Terminal State)
uint8 REJECTED        = 5   # The goal was rejected by the action server without being processed,
                            #    because the goal was unattainable or invalid (Terminal State)
uint8 PREEMPTING      = 6   # The goal received a cancel request after it started executing
                            #    and has not yet completed execution
uint8 RECALLING       = 7   # The goal received a cancel request before it started executing,
                            #    but the action server has not yet confirmed that the goal is canceled
uint8 RECALLED        = 8   # The goal received a cancel request before it started executing
                            #    and was successfully cancelled (Terminal State)
uint8 LOST            = 9   # An action client can determine that a goal is LOST. This should not be
                            #    sent over the wire by an action server

#Allow for the user to associate a string with GoalStatus for debugging
string text


================================================================================
MSG: actionlib_msgs/GoalID
# The stamp should store the time at which this goal was requested.
# It is used by an action server when it tries to preempt all
# goals that were requested before a certain time
time stamp

# The id provides a way to associate feedback and
# result message with specific goal requests. The id
# specified must be unique.
string id


================================================================================
MSG: robot_msgs/MoveArmOnTrajectoryResult
# ====== DO NOT MODIFY! AUTOGENERATED FROM AN ACTION DEFINITION ======
geometry_msgs/Pose resultPose
string resultMessage

================================================================================
MSG: geometry_msgs/Pose
# A representation of pose in free space, composed of position and orientation. 
Point position
Quaternion orientation

================================================================================
MSG: geometry_msgs/Point
# This contains the position of a point in free space
float64 x
float64 y
float64 z

================================================================================
MSG: geometry_msgs/Quaternion
# This represents an orientation in free space in quaternion form.

float64 x
float64 y
float64 z
float64 w";
            
            var actual = new RosbagMessageDefinitionParser(input).Parse();

            Assert.NotNull(actual);
            Assert.NotNull(actual.Message);
            Assert.Equal(7, actual.NestedMessages.Count);

            Assert.True(actual.NestedMessages.ContainsKey(new RosTypeInfo("Header", "std_msgs")), "Nested message std_msgs/Header not found");
            Assert.True(actual.NestedMessages.ContainsKey(new RosTypeInfo("GoalStatus", "actionlib_msgs")), "Nested message actionlib_msgs/GoalStatus not found");
            Assert.True(actual.NestedMessages.ContainsKey(new RosTypeInfo("GoalID", "actionlib_msgs")), "Nested message actionlib_msgs/GoalID not found");
            Assert.True(actual.NestedMessages.ContainsKey(new RosTypeInfo("MoveArmOnTrajectoryResult", "robot_msgs")), "Nested message robot_msgs/MoveArmOnTrajectoryResult not found");
            Assert.True(actual.NestedMessages.ContainsKey(new RosTypeInfo("Pose", "geometry_msgs")), "Nested message geometry_msgs/Pose not found");
            Assert.True(actual.NestedMessages.ContainsKey(new RosTypeInfo("Point", "geometry_msgs")), "Nested message geometry_msgs/Point not found");
            Assert.True(actual.NestedMessages.ContainsKey(new RosTypeInfo("Quaternion", "geometry_msgs")), "Nested message geometry_msgs/Quaternion not found");
        }
    }
}