//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:/BRG/Projekte/RosMessageParser/Joanneum.Robotics.Ros.MessageParser\RosMessageParser.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace RobSharper.Ros.MessageParser.Antlr {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="RosMessageParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public interface IRosMessageParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.ros_file_input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRos_file_input([NotNull] RosMessageParser.Ros_file_inputContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.ros_message_input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRos_message_input([NotNull] RosMessageParser.Ros_message_inputContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.ros_action_input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRos_action_input([NotNull] RosMessageParser.Ros_action_inputContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.ros_service_input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRos_service_input([NotNull] RosMessageParser.Ros_service_inputContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.rosbag_input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRosbag_input([NotNull] RosMessageParser.Rosbag_inputContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.rosbag_nested_message"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRosbag_nested_message([NotNull] RosMessageParser.Rosbag_nested_messageContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.ros_message"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRos_message([NotNull] RosMessageParser.Ros_messageContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.field_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitField_declaration([NotNull] RosMessageParser.Field_declarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.constant_declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitConstant_declaration([NotNull] RosMessageParser.Constant_declarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.comment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComment([NotNull] RosMessageParser.CommentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.identifier"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifier([NotNull] RosMessageParser.IdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType([NotNull] RosMessageParser.TypeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.ros_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRos_type([NotNull] RosMessageParser.Ros_typeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.array_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitArray_type([NotNull] RosMessageParser.Array_typeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.variable_array_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariable_array_type([NotNull] RosMessageParser.Variable_array_typeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.fixed_array_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFixed_array_type([NotNull] RosMessageParser.Fixed_array_typeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.integral_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIntegral_type([NotNull] RosMessageParser.Integral_typeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.floating_point_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFloating_point_type([NotNull] RosMessageParser.Floating_point_typeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.temportal_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTemportal_type([NotNull] RosMessageParser.Temportal_typeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.string_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString_type([NotNull] RosMessageParser.String_typeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.boolean_type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolean_type([NotNull] RosMessageParser.Boolean_typeContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.sign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSign([NotNull] RosMessageParser.SignContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.integral_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIntegral_value([NotNull] RosMessageParser.Integral_valueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.floating_point_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFloating_point_value([NotNull] RosMessageParser.Floating_point_valueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.bool_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBool_value([NotNull] RosMessageParser.Bool_valueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RosMessageParser.string_value"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString_value([NotNull] RosMessageParser.String_valueContext context);
}
} // namespace Joanneum.Robotics.Ros.MessageParser.Antlr
