//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:/BRG/Projekte/RosMessageParser/Joanneum.Robotics.Ros.MessageParser\RosMessage.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Joanneum.Robotics.Ros.MessageParser {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="RosMessageParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public interface IRosMessageListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.ros_file_input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRos_file_input([NotNull] RosMessageParser.Ros_file_inputContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.ros_file_input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRos_file_input([NotNull] RosMessageParser.Ros_file_inputContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.ros_message"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRos_message([NotNull] RosMessageParser.Ros_messageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.ros_message"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRos_message([NotNull] RosMessageParser.Ros_messageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.ros_action"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRos_action([NotNull] RosMessageParser.Ros_actionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.ros_action"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRos_action([NotNull] RosMessageParser.Ros_actionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.ros_service"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRos_service([NotNull] RosMessageParser.Ros_serviceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.ros_service"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRos_service([NotNull] RosMessageParser.Ros_serviceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.rosbag_input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRosbag_input([NotNull] RosMessageParser.Rosbag_inputContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.rosbag_input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRosbag_input([NotNull] RosMessageParser.Rosbag_inputContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.rosbag_nested_message"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRosbag_nested_message([NotNull] RosMessageParser.Rosbag_nested_messageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.rosbag_nested_message"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRosbag_nested_message([NotNull] RosMessageParser.Rosbag_nested_messageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.field_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterField_declaration([NotNull] RosMessageParser.Field_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.field_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitField_declaration([NotNull] RosMessageParser.Field_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.constant_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant_declaration([NotNull] RosMessageParser.Constant_declarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.constant_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant_declaration([NotNull] RosMessageParser.Constant_declarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComment([NotNull] RosMessageParser.CommentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComment([NotNull] RosMessageParser.CommentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifier([NotNull] RosMessageParser.IdentifierContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifier([NotNull] RosMessageParser.IdentifierContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType([NotNull] RosMessageParser.TypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType([NotNull] RosMessageParser.TypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.base_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBase_type([NotNull] RosMessageParser.Base_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.base_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBase_type([NotNull] RosMessageParser.Base_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.ros_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRos_type([NotNull] RosMessageParser.Ros_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.ros_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRos_type([NotNull] RosMessageParser.Ros_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.array_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArray_type([NotNull] RosMessageParser.Array_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.array_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArray_type([NotNull] RosMessageParser.Array_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.variable_array_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariable_array_type([NotNull] RosMessageParser.Variable_array_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.variable_array_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariable_array_type([NotNull] RosMessageParser.Variable_array_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.fixed_array_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFixed_array_type([NotNull] RosMessageParser.Fixed_array_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.fixed_array_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFixed_array_type([NotNull] RosMessageParser.Fixed_array_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.numeric_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumeric_type([NotNull] RosMessageParser.Numeric_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.numeric_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumeric_type([NotNull] RosMessageParser.Numeric_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.integral_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntegral_type([NotNull] RosMessageParser.Integral_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.integral_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntegral_type([NotNull] RosMessageParser.Integral_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.floating_point_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFloating_point_type([NotNull] RosMessageParser.Floating_point_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.floating_point_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFloating_point_type([NotNull] RosMessageParser.Floating_point_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.temportal_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTemportal_type([NotNull] RosMessageParser.Temportal_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.temportal_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTemportal_type([NotNull] RosMessageParser.Temportal_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.string_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterString_type([NotNull] RosMessageParser.String_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.string_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitString_type([NotNull] RosMessageParser.String_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.boolean_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolean_type([NotNull] RosMessageParser.Boolean_typeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.boolean_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolean_type([NotNull] RosMessageParser.Boolean_typeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.sign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSign([NotNull] RosMessageParser.SignContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.sign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSign([NotNull] RosMessageParser.SignContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.integral_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIntegral_value([NotNull] RosMessageParser.Integral_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.integral_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIntegral_value([NotNull] RosMessageParser.Integral_valueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.floating_point_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFloating_point_value([NotNull] RosMessageParser.Floating_point_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.floating_point_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFloating_point_value([NotNull] RosMessageParser.Floating_point_valueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="RosMessageParser.bool_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBool_value([NotNull] RosMessageParser.Bool_valueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="RosMessageParser.bool_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBool_value([NotNull] RosMessageParser.Bool_valueContext context);
}
} // namespace Joanneum.Robotics.Ros.MessageParser
