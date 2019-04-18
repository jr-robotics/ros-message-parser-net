//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from D:/BRG/Projekte/RosMessageParser/Joanneum.Robotics.Ros.MessageParser\RosMessageLexer.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Joanneum.Robotics.Ros.MessageParser.Antlr {
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class RosMessageLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		BOOL=1, INT8=2, UINT8=3, BYTE=4, CHAR=5, INT16=6, UINT16=7, INT32=8, UINT32=9, 
		INT64=10, UINT64=11, FLOAT32=12, FLOAT64=13, STRING=14, TIME=15, DURATION=16, 
		SLASH=17, OPEN_BRACKET=18, CLOSE_BRACKET=19, ASSIGNMENT=20, PLUS=21, MINUS=22, 
		HASH=23, MESSAGE_SEPARATOR=24, INTEGER_LITERAL=25, REAL_LITERAL=26, TRUE=27, 
		FALSE=28, IDENTIFIER=29, ROSBAG_MESSAGE_SEPARATOR=30, WHITESPACES=31, 
		NEWLINES=32, NEWLINE=33, STRING_IDENTIFIER=34, STRING_OPEN_BRACKET=35, 
		STRING_CLOSE_BRACKET=36, STRING_INTEGER_LITERAL=37, STRING_ASSIGNMENT=38, 
		STRING_HASH=39, STRING_WHITESPACES=40, STRING_NEWLINE=41, STRING_VALUE=42, 
		STRIN_ASSIGNMENT_NEWLINE=43, COMMENT=44, COMMENT_NEWLINE=45;
	public const int
		STRING_DECLARATION_MODE=1, STRING_ASSIGNMENT_MODE=2, COMMENT_MODE=3;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE", "STRING_DECLARATION_MODE", "STRING_ASSIGNMENT_MODE", "COMMENT_MODE"
	};

	public static readonly string[] ruleNames = {
		"BOOL", "INT8", "UINT8", "BYTE", "CHAR", "INT16", "UINT16", "INT32", "UINT32", 
		"INT64", "UINT64", "FLOAT32", "FLOAT64", "STRING", "TIME", "DURATION", 
		"SLASH", "OPEN_BRACKET", "CLOSE_BRACKET", "ASSIGNMENT", "PLUS", "MINUS", 
		"HASH", "MESSAGE_SEPARATOR", "INTEGER_LITERAL", "REAL_LITERAL", "TRUE", 
		"FALSE", "IDENTIFIER", "ROSBAG_MESSAGE_SEPARATOR", "WHITESPACES", "NEWLINES", 
		"NEWLINE", "STRING_IDENTIFIER", "STRING_OPEN_BRACKET", "STRING_CLOSE_BRACKET", 
		"STRING_INTEGER_LITERAL", "STRING_ASSIGNMENT", "STRING_HASH", "STRING_WHITESPACES", 
		"STRING_NEWLINE", "STRING_VALUE", "STRIN_ASSIGNMENT_NEWLINE", "COMMENT", 
		"COMMENT_NEWLINE", "Lowercase", "Uppercase", "Digit", "InputCharacter", 
		"Assignment", "OpenBracket", "CloseBracket", "Hash", "NewLine", "Whitespace", 
		"UnicodeClassZS"
	};


	public RosMessageLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public RosMessageLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'bool'", "'int8'", "'uint8'", "'byte'", "'char'", "'int16'", "'uint16'", 
		"'int32'", "'uint32'", "'int64'", "'uint64'", "'float32'", "'float64'", 
		"'string'", "'time'", "'duration'", "'/'", null, null, null, "'+'", "'-'", 
		null, "'---'", null, null, "'True'", "'False'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "BOOL", "INT8", "UINT8", "BYTE", "CHAR", "INT16", "UINT16", "INT32", 
		"UINT32", "INT64", "UINT64", "FLOAT32", "FLOAT64", "STRING", "TIME", "DURATION", 
		"SLASH", "OPEN_BRACKET", "CLOSE_BRACKET", "ASSIGNMENT", "PLUS", "MINUS", 
		"HASH", "MESSAGE_SEPARATOR", "INTEGER_LITERAL", "REAL_LITERAL", "TRUE", 
		"FALSE", "IDENTIFIER", "ROSBAG_MESSAGE_SEPARATOR", "WHITESPACES", "NEWLINES", 
		"NEWLINE", "STRING_IDENTIFIER", "STRING_OPEN_BRACKET", "STRING_CLOSE_BRACKET", 
		"STRING_INTEGER_LITERAL", "STRING_ASSIGNMENT", "STRING_HASH", "STRING_WHITESPACES", 
		"STRING_NEWLINE", "STRING_VALUE", "STRIN_ASSIGNMENT_NEWLINE", "COMMENT", 
		"COMMENT_NEWLINE"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "RosMessageLexer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static RosMessageLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '/', '\x184', '\b', '\x1', '\b', '\x1', '\b', '\x1', 
		'\b', '\x1', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', '\t', '\x3', '\x4', 
		'\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', '\x6', '\t', '\x6', 
		'\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', '\x4', '\t', '\t', '\t', 
		'\x4', '\n', '\t', '\n', '\x4', '\v', '\t', '\v', '\x4', '\f', '\t', '\f', 
		'\x4', '\r', '\t', '\r', '\x4', '\xE', '\t', '\xE', '\x4', '\xF', '\t', 
		'\xF', '\x4', '\x10', '\t', '\x10', '\x4', '\x11', '\t', '\x11', '\x4', 
		'\x12', '\t', '\x12', '\x4', '\x13', '\t', '\x13', '\x4', '\x14', '\t', 
		'\x14', '\x4', '\x15', '\t', '\x15', '\x4', '\x16', '\t', '\x16', '\x4', 
		'\x17', '\t', '\x17', '\x4', '\x18', '\t', '\x18', '\x4', '\x19', '\t', 
		'\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', '\x1B', '\t', '\x1B', '\x4', 
		'\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', '\x1D', '\x4', '\x1E', '\t', 
		'\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', ' ', '\t', ' ', '\x4', '!', 
		'\t', '!', '\x4', '\"', '\t', '\"', '\x4', '#', '\t', '#', '\x4', '$', 
		'\t', '$', '\x4', '%', '\t', '%', '\x4', '&', '\t', '&', '\x4', '\'', 
		'\t', '\'', '\x4', '(', '\t', '(', '\x4', ')', '\t', ')', '\x4', '*', 
		'\t', '*', '\x4', '+', '\t', '+', '\x4', ',', '\t', ',', '\x4', '-', '\t', 
		'-', '\x4', '.', '\t', '.', '\x4', '/', '\t', '/', '\x4', '\x30', '\t', 
		'\x30', '\x4', '\x31', '\t', '\x31', '\x4', '\x32', '\t', '\x32', '\x4', 
		'\x33', '\t', '\x33', '\x4', '\x34', '\t', '\x34', '\x4', '\x35', '\t', 
		'\x35', '\x4', '\x36', '\t', '\x36', '\x4', '\x37', '\t', '\x37', '\x4', 
		'\x38', '\t', '\x38', '\x4', '\x39', '\t', '\x39', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', 
		'\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', 
		'\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', 
		'\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', 
		'\r', '\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', 
		'\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', 
		'\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x13', '\x3', '\x13', '\x3', '\x14', '\x3', '\x14', '\x3', '\x15', 
		'\x3', '\x15', '\x3', '\x16', '\x3', '\x16', '\x3', '\x17', '\x3', '\x17', 
		'\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x19', 
		'\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', '\x6', '\x1A', 
		'\xF4', '\n', '\x1A', '\r', '\x1A', '\xE', '\x1A', '\xF5', '\x3', '\x1B', 
		'\a', '\x1B', '\xF9', '\n', '\x1B', '\f', '\x1B', '\xE', '\x1B', '\xFC', 
		'\v', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x6', '\x1B', '\x100', '\n', 
		'\x1B', '\r', '\x1B', '\xE', '\x1B', '\x101', '\x3', '\x1C', '\x3', '\x1C', 
		'\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1D', '\x3', '\x1D', 
		'\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1E', 
		'\x3', '\x1E', '\x5', '\x1E', '\x111', '\n', '\x1E', '\x3', '\x1E', '\x3', 
		'\x1E', '\x3', '\x1E', '\x3', '\x1E', '\a', '\x1E', '\x117', '\n', '\x1E', 
		'\f', '\x1E', '\xE', '\x1E', '\x11A', '\v', '\x1E', '\x3', '\x1F', '\x6', 
		'\x1F', '\x11D', '\n', '\x1F', '\r', '\x1F', '\xE', '\x1F', '\x11E', '\x3', 
		'\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', 
		'\x1F', '\x3', ' ', '\x6', ' ', '\x128', '\n', ' ', '\r', ' ', '\xE', 
		' ', '\x129', '\x3', ' ', '\x3', ' ', '\x3', '!', '\x6', '!', '\x12F', 
		'\n', '!', '\r', '!', '\xE', '!', '\x130', '\x3', '!', '\x3', '!', '\x3', 
		'\"', '\x3', '\"', '\x3', '#', '\x3', '#', '\x3', '$', '\x3', '$', '\x3', 
		'%', '\x3', '%', '\x3', '&', '\x6', '&', '\x13E', '\n', '&', '\r', '&', 
		'\xE', '&', '\x13F', '\x3', '\'', '\x3', '\'', '\x3', '\'', '\x3', '\'', 
		'\x3', '(', '\x3', '(', '\x3', '(', '\x3', '(', '\x3', ')', '\x6', ')', 
		'\x14B', '\n', ')', '\r', ')', '\xE', ')', '\x14C', '\x3', ')', '\x3', 
		')', '\x3', '*', '\x3', '*', '\x3', '*', '\x3', '*', '\x3', '*', '\x3', 
		'+', '\x6', '+', '\x157', '\n', '+', '\r', '+', '\xE', '+', '\x158', '\x3', 
		',', '\x3', ',', '\x3', ',', '\x3', ',', '\x3', ',', '\x3', '-', '\x6', 
		'-', '\x161', '\n', '-', '\r', '-', '\xE', '-', '\x162', '\x3', '.', '\x3', 
		'.', '\x3', '.', '\x3', '.', '\x3', '.', '\x3', '/', '\x3', '/', '\x3', 
		'\x30', '\x3', '\x30', '\x3', '\x31', '\x3', '\x31', '\x3', '\x32', '\x3', 
		'\x32', '\x3', '\x33', '\x3', '\x33', '\x3', '\x34', '\x3', '\x34', '\x3', 
		'\x35', '\x3', '\x35', '\x3', '\x36', '\x3', '\x36', '\x3', '\x37', '\x3', 
		'\x37', '\x3', '\x37', '\x5', '\x37', '\x17D', '\n', '\x37', '\x3', '\x38', 
		'\x3', '\x38', '\x5', '\x38', '\x181', '\n', '\x38', '\x3', '\x39', '\x3', 
		'\x39', '\x2', '\x2', ':', '\x6', '\x3', '\b', '\x4', '\n', '\x5', '\f', 
		'\x6', '\xE', '\a', '\x10', '\b', '\x12', '\t', '\x14', '\n', '\x16', 
		'\v', '\x18', '\f', '\x1A', '\r', '\x1C', '\xE', '\x1E', '\xF', ' ', '\x10', 
		'\"', '\x11', '$', '\x12', '&', '\x13', '(', '\x14', '*', '\x15', ',', 
		'\x16', '.', '\x17', '\x30', '\x18', '\x32', '\x19', '\x34', '\x1A', '\x36', 
		'\x1B', '\x38', '\x1C', ':', '\x1D', '<', '\x1E', '>', '\x1F', '@', ' ', 
		'\x42', '!', '\x44', '\"', '\x46', '#', 'H', '$', 'J', '%', 'L', '&', 
		'N', '\'', 'P', '(', 'R', ')', 'T', '*', 'V', '+', 'X', ',', 'Z', '-', 
		'\\', '.', '^', '/', '`', '\x2', '\x62', '\x2', '\x64', '\x2', '\x66', 
		'\x2', 'h', '\x2', 'j', '\x2', 'l', '\x2', 'n', '\x2', 'p', '\x2', 'r', 
		'\x2', 't', '\x2', '\x6', '\x2', '\x3', '\x4', '\x5', '\b', '\x3', '\x2', 
		'\x32', ';', '\x3', '\x2', '\x63', '|', '\x3', '\x2', '\x43', '\\', '\x6', 
		'\x2', '\f', '\f', '\xF', '\xF', '\x87', '\x87', '\x202A', '\x202B', '\x4', 
		'\x2', '\v', '\v', '\r', '\xE', '\v', '\x2', '\"', '\"', '\xA2', '\xA2', 
		'\x1682', '\x1682', '\x1810', '\x1810', '\x2002', '\x2008', '\x200A', 
		'\x200C', '\x2031', '\x2031', '\x2061', '\x2061', '\x3002', '\x3002', 
		'\x2', '\x186', '\x2', '\x6', '\x3', '\x2', '\x2', '\x2', '\x2', '\b', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\n', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\f', '\x3', '\x2', '\x2', '\x2', '\x2', '\xE', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x10', '\x3', '\x2', '\x2', '\x2', '\x2', '\x12', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x14', '\x3', '\x2', '\x2', '\x2', '\x2', '\x16', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x18', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1C', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1E', '\x3', '\x2', '\x2', '\x2', '\x2', ' ', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\"', '\x3', '\x2', '\x2', '\x2', '\x2', '$', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '&', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'(', '\x3', '\x2', '\x2', '\x2', '\x2', '*', '\x3', '\x2', '\x2', '\x2', 
		'\x2', ',', '\x3', '\x2', '\x2', '\x2', '\x2', '.', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x30', '\x3', '\x2', '\x2', '\x2', '\x2', '\x32', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x34', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x36', '\x3', '\x2', '\x2', '\x2', '\x2', '\x38', '\x3', '\x2', '\x2', 
		'\x2', '\x2', ':', '\x3', '\x2', '\x2', '\x2', '\x2', '<', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '>', '\x3', '\x2', '\x2', '\x2', '\x2', '@', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x42', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x44', '\x3', '\x2', '\x2', '\x2', '\x2', '\x46', '\x3', '\x2', '\x2', 
		'\x2', '\x3', 'H', '\x3', '\x2', '\x2', '\x2', '\x3', 'J', '\x3', '\x2', 
		'\x2', '\x2', '\x3', 'L', '\x3', '\x2', '\x2', '\x2', '\x3', 'N', '\x3', 
		'\x2', '\x2', '\x2', '\x3', 'P', '\x3', '\x2', '\x2', '\x2', '\x3', 'R', 
		'\x3', '\x2', '\x2', '\x2', '\x3', 'T', '\x3', '\x2', '\x2', '\x2', '\x3', 
		'V', '\x3', '\x2', '\x2', '\x2', '\x4', 'X', '\x3', '\x2', '\x2', '\x2', 
		'\x4', 'Z', '\x3', '\x2', '\x2', '\x2', '\x5', '\\', '\x3', '\x2', '\x2', 
		'\x2', '\x5', '^', '\x3', '\x2', '\x2', '\x2', '\x6', 'v', '\x3', '\x2', 
		'\x2', '\x2', '\b', '{', '\x3', '\x2', '\x2', '\x2', '\n', '\x80', '\x3', 
		'\x2', '\x2', '\x2', '\f', '\x86', '\x3', '\x2', '\x2', '\x2', '\xE', 
		'\x8B', '\x3', '\x2', '\x2', '\x2', '\x10', '\x90', '\x3', '\x2', '\x2', 
		'\x2', '\x12', '\x96', '\x3', '\x2', '\x2', '\x2', '\x14', '\x9D', '\x3', 
		'\x2', '\x2', '\x2', '\x16', '\xA3', '\x3', '\x2', '\x2', '\x2', '\x18', 
		'\xAA', '\x3', '\x2', '\x2', '\x2', '\x1A', '\xB0', '\x3', '\x2', '\x2', 
		'\x2', '\x1C', '\xB7', '\x3', '\x2', '\x2', '\x2', '\x1E', '\xBF', '\x3', 
		'\x2', '\x2', '\x2', ' ', '\xC7', '\x3', '\x2', '\x2', '\x2', '\"', '\xD0', 
		'\x3', '\x2', '\x2', '\x2', '$', '\xD5', '\x3', '\x2', '\x2', '\x2', '&', 
		'\xDE', '\x3', '\x2', '\x2', '\x2', '(', '\xE0', '\x3', '\x2', '\x2', 
		'\x2', '*', '\xE2', '\x3', '\x2', '\x2', '\x2', ',', '\xE4', '\x3', '\x2', 
		'\x2', '\x2', '.', '\xE6', '\x3', '\x2', '\x2', '\x2', '\x30', '\xE8', 
		'\x3', '\x2', '\x2', '\x2', '\x32', '\xEA', '\x3', '\x2', '\x2', '\x2', 
		'\x34', '\xEE', '\x3', '\x2', '\x2', '\x2', '\x36', '\xF3', '\x3', '\x2', 
		'\x2', '\x2', '\x38', '\xFA', '\x3', '\x2', '\x2', '\x2', ':', '\x103', 
		'\x3', '\x2', '\x2', '\x2', '<', '\x108', '\x3', '\x2', '\x2', '\x2', 
		'>', '\x110', '\x3', '\x2', '\x2', '\x2', '@', '\x11C', '\x3', '\x2', 
		'\x2', '\x2', '\x42', '\x127', '\x3', '\x2', '\x2', '\x2', '\x44', '\x12E', 
		'\x3', '\x2', '\x2', '\x2', '\x46', '\x134', '\x3', '\x2', '\x2', '\x2', 
		'H', '\x136', '\x3', '\x2', '\x2', '\x2', 'J', '\x138', '\x3', '\x2', 
		'\x2', '\x2', 'L', '\x13A', '\x3', '\x2', '\x2', '\x2', 'N', '\x13D', 
		'\x3', '\x2', '\x2', '\x2', 'P', '\x141', '\x3', '\x2', '\x2', '\x2', 
		'R', '\x145', '\x3', '\x2', '\x2', '\x2', 'T', '\x14A', '\x3', '\x2', 
		'\x2', '\x2', 'V', '\x150', '\x3', '\x2', '\x2', '\x2', 'X', '\x156', 
		'\x3', '\x2', '\x2', '\x2', 'Z', '\x15A', '\x3', '\x2', '\x2', '\x2', 
		'\\', '\x160', '\x3', '\x2', '\x2', '\x2', '^', '\x164', '\x3', '\x2', 
		'\x2', '\x2', '`', '\x169', '\x3', '\x2', '\x2', '\x2', '\x62', '\x16B', 
		'\x3', '\x2', '\x2', '\x2', '\x64', '\x16D', '\x3', '\x2', '\x2', '\x2', 
		'\x66', '\x16F', '\x3', '\x2', '\x2', '\x2', 'h', '\x171', '\x3', '\x2', 
		'\x2', '\x2', 'j', '\x173', '\x3', '\x2', '\x2', '\x2', 'l', '\x175', 
		'\x3', '\x2', '\x2', '\x2', 'n', '\x177', '\x3', '\x2', '\x2', '\x2', 
		'p', '\x17C', '\x3', '\x2', '\x2', '\x2', 'r', '\x180', '\x3', '\x2', 
		'\x2', '\x2', 't', '\x182', '\x3', '\x2', '\x2', '\x2', 'v', 'w', '\a', 
		'\x64', '\x2', '\x2', 'w', 'x', '\a', 'q', '\x2', '\x2', 'x', 'y', '\a', 
		'q', '\x2', '\x2', 'y', 'z', '\a', 'n', '\x2', '\x2', 'z', '\a', '\x3', 
		'\x2', '\x2', '\x2', '{', '|', '\a', 'k', '\x2', '\x2', '|', '}', '\a', 
		'p', '\x2', '\x2', '}', '~', '\a', 'v', '\x2', '\x2', '~', '\x7F', '\a', 
		':', '\x2', '\x2', '\x7F', '\t', '\x3', '\x2', '\x2', '\x2', '\x80', '\x81', 
		'\a', 'w', '\x2', '\x2', '\x81', '\x82', '\a', 'k', '\x2', '\x2', '\x82', 
		'\x83', '\a', 'p', '\x2', '\x2', '\x83', '\x84', '\a', 'v', '\x2', '\x2', 
		'\x84', '\x85', '\a', ':', '\x2', '\x2', '\x85', '\v', '\x3', '\x2', '\x2', 
		'\x2', '\x86', '\x87', '\a', '\x64', '\x2', '\x2', '\x87', '\x88', '\a', 
		'{', '\x2', '\x2', '\x88', '\x89', '\a', 'v', '\x2', '\x2', '\x89', '\x8A', 
		'\a', 'g', '\x2', '\x2', '\x8A', '\r', '\x3', '\x2', '\x2', '\x2', '\x8B', 
		'\x8C', '\a', '\x65', '\x2', '\x2', '\x8C', '\x8D', '\a', 'j', '\x2', 
		'\x2', '\x8D', '\x8E', '\a', '\x63', '\x2', '\x2', '\x8E', '\x8F', '\a', 
		't', '\x2', '\x2', '\x8F', '\xF', '\x3', '\x2', '\x2', '\x2', '\x90', 
		'\x91', '\a', 'k', '\x2', '\x2', '\x91', '\x92', '\a', 'p', '\x2', '\x2', 
		'\x92', '\x93', '\a', 'v', '\x2', '\x2', '\x93', '\x94', '\a', '\x33', 
		'\x2', '\x2', '\x94', '\x95', '\a', '\x38', '\x2', '\x2', '\x95', '\x11', 
		'\x3', '\x2', '\x2', '\x2', '\x96', '\x97', '\a', 'w', '\x2', '\x2', '\x97', 
		'\x98', '\a', 'k', '\x2', '\x2', '\x98', '\x99', '\a', 'p', '\x2', '\x2', 
		'\x99', '\x9A', '\a', 'v', '\x2', '\x2', '\x9A', '\x9B', '\a', '\x33', 
		'\x2', '\x2', '\x9B', '\x9C', '\a', '\x38', '\x2', '\x2', '\x9C', '\x13', 
		'\x3', '\x2', '\x2', '\x2', '\x9D', '\x9E', '\a', 'k', '\x2', '\x2', '\x9E', 
		'\x9F', '\a', 'p', '\x2', '\x2', '\x9F', '\xA0', '\a', 'v', '\x2', '\x2', 
		'\xA0', '\xA1', '\a', '\x35', '\x2', '\x2', '\xA1', '\xA2', '\a', '\x34', 
		'\x2', '\x2', '\xA2', '\x15', '\x3', '\x2', '\x2', '\x2', '\xA3', '\xA4', 
		'\a', 'w', '\x2', '\x2', '\xA4', '\xA5', '\a', 'k', '\x2', '\x2', '\xA5', 
		'\xA6', '\a', 'p', '\x2', '\x2', '\xA6', '\xA7', '\a', 'v', '\x2', '\x2', 
		'\xA7', '\xA8', '\a', '\x35', '\x2', '\x2', '\xA8', '\xA9', '\a', '\x34', 
		'\x2', '\x2', '\xA9', '\x17', '\x3', '\x2', '\x2', '\x2', '\xAA', '\xAB', 
		'\a', 'k', '\x2', '\x2', '\xAB', '\xAC', '\a', 'p', '\x2', '\x2', '\xAC', 
		'\xAD', '\a', 'v', '\x2', '\x2', '\xAD', '\xAE', '\a', '\x38', '\x2', 
		'\x2', '\xAE', '\xAF', '\a', '\x36', '\x2', '\x2', '\xAF', '\x19', '\x3', 
		'\x2', '\x2', '\x2', '\xB0', '\xB1', '\a', 'w', '\x2', '\x2', '\xB1', 
		'\xB2', '\a', 'k', '\x2', '\x2', '\xB2', '\xB3', '\a', 'p', '\x2', '\x2', 
		'\xB3', '\xB4', '\a', 'v', '\x2', '\x2', '\xB4', '\xB5', '\a', '\x38', 
		'\x2', '\x2', '\xB5', '\xB6', '\a', '\x36', '\x2', '\x2', '\xB6', '\x1B', 
		'\x3', '\x2', '\x2', '\x2', '\xB7', '\xB8', '\a', 'h', '\x2', '\x2', '\xB8', 
		'\xB9', '\a', 'n', '\x2', '\x2', '\xB9', '\xBA', '\a', 'q', '\x2', '\x2', 
		'\xBA', '\xBB', '\a', '\x63', '\x2', '\x2', '\xBB', '\xBC', '\a', 'v', 
		'\x2', '\x2', '\xBC', '\xBD', '\a', '\x35', '\x2', '\x2', '\xBD', '\xBE', 
		'\a', '\x34', '\x2', '\x2', '\xBE', '\x1D', '\x3', '\x2', '\x2', '\x2', 
		'\xBF', '\xC0', '\a', 'h', '\x2', '\x2', '\xC0', '\xC1', '\a', 'n', '\x2', 
		'\x2', '\xC1', '\xC2', '\a', 'q', '\x2', '\x2', '\xC2', '\xC3', '\a', 
		'\x63', '\x2', '\x2', '\xC3', '\xC4', '\a', 'v', '\x2', '\x2', '\xC4', 
		'\xC5', '\a', '\x38', '\x2', '\x2', '\xC5', '\xC6', '\a', '\x36', '\x2', 
		'\x2', '\xC6', '\x1F', '\x3', '\x2', '\x2', '\x2', '\xC7', '\xC8', '\a', 
		'u', '\x2', '\x2', '\xC8', '\xC9', '\a', 'v', '\x2', '\x2', '\xC9', '\xCA', 
		'\a', 't', '\x2', '\x2', '\xCA', '\xCB', '\a', 'k', '\x2', '\x2', '\xCB', 
		'\xCC', '\a', 'p', '\x2', '\x2', '\xCC', '\xCD', '\a', 'i', '\x2', '\x2', 
		'\xCD', '\xCE', '\x3', '\x2', '\x2', '\x2', '\xCE', '\xCF', '\b', '\xF', 
		'\x2', '\x2', '\xCF', '!', '\x3', '\x2', '\x2', '\x2', '\xD0', '\xD1', 
		'\a', 'v', '\x2', '\x2', '\xD1', '\xD2', '\a', 'k', '\x2', '\x2', '\xD2', 
		'\xD3', '\a', 'o', '\x2', '\x2', '\xD3', '\xD4', '\a', 'g', '\x2', '\x2', 
		'\xD4', '#', '\x3', '\x2', '\x2', '\x2', '\xD5', '\xD6', '\a', '\x66', 
		'\x2', '\x2', '\xD6', '\xD7', '\a', 'w', '\x2', '\x2', '\xD7', '\xD8', 
		'\a', 't', '\x2', '\x2', '\xD8', '\xD9', '\a', '\x63', '\x2', '\x2', '\xD9', 
		'\xDA', '\a', 'v', '\x2', '\x2', '\xDA', '\xDB', '\a', 'k', '\x2', '\x2', 
		'\xDB', '\xDC', '\a', 'q', '\x2', '\x2', '\xDC', '\xDD', '\a', 'p', '\x2', 
		'\x2', '\xDD', '%', '\x3', '\x2', '\x2', '\x2', '\xDE', '\xDF', '\a', 
		'\x31', '\x2', '\x2', '\xDF', '\'', '\x3', '\x2', '\x2', '\x2', '\xE0', 
		'\xE1', '\x5', 'j', '\x34', '\x2', '\xE1', ')', '\x3', '\x2', '\x2', '\x2', 
		'\xE2', '\xE3', '\x5', 'l', '\x35', '\x2', '\xE3', '+', '\x3', '\x2', 
		'\x2', '\x2', '\xE4', '\xE5', '\x5', 'h', '\x33', '\x2', '\xE5', '-', 
		'\x3', '\x2', '\x2', '\x2', '\xE6', '\xE7', '\a', '-', '\x2', '\x2', '\xE7', 
		'/', '\x3', '\x2', '\x2', '\x2', '\xE8', '\xE9', '\a', '/', '\x2', '\x2', 
		'\xE9', '\x31', '\x3', '\x2', '\x2', '\x2', '\xEA', '\xEB', '\x5', 'n', 
		'\x36', '\x2', '\xEB', '\xEC', '\x3', '\x2', '\x2', '\x2', '\xEC', '\xED', 
		'\b', '\x18', '\x3', '\x2', '\xED', '\x33', '\x3', '\x2', '\x2', '\x2', 
		'\xEE', '\xEF', '\a', '/', '\x2', '\x2', '\xEF', '\xF0', '\a', '/', '\x2', 
		'\x2', '\xF0', '\xF1', '\a', '/', '\x2', '\x2', '\xF1', '\x35', '\x3', 
		'\x2', '\x2', '\x2', '\xF2', '\xF4', '\t', '\x2', '\x2', '\x2', '\xF3', 
		'\xF2', '\x3', '\x2', '\x2', '\x2', '\xF4', '\xF5', '\x3', '\x2', '\x2', 
		'\x2', '\xF5', '\xF3', '\x3', '\x2', '\x2', '\x2', '\xF5', '\xF6', '\x3', 
		'\x2', '\x2', '\x2', '\xF6', '\x37', '\x3', '\x2', '\x2', '\x2', '\xF7', 
		'\xF9', '\t', '\x2', '\x2', '\x2', '\xF8', '\xF7', '\x3', '\x2', '\x2', 
		'\x2', '\xF9', '\xFC', '\x3', '\x2', '\x2', '\x2', '\xFA', '\xF8', '\x3', 
		'\x2', '\x2', '\x2', '\xFA', '\xFB', '\x3', '\x2', '\x2', '\x2', '\xFB', 
		'\xFD', '\x3', '\x2', '\x2', '\x2', '\xFC', '\xFA', '\x3', '\x2', '\x2', 
		'\x2', '\xFD', '\xFF', '\a', '\x30', '\x2', '\x2', '\xFE', '\x100', '\t', 
		'\x2', '\x2', '\x2', '\xFF', '\xFE', '\x3', '\x2', '\x2', '\x2', '\x100', 
		'\x101', '\x3', '\x2', '\x2', '\x2', '\x101', '\xFF', '\x3', '\x2', '\x2', 
		'\x2', '\x101', '\x102', '\x3', '\x2', '\x2', '\x2', '\x102', '\x39', 
		'\x3', '\x2', '\x2', '\x2', '\x103', '\x104', '\a', 'V', '\x2', '\x2', 
		'\x104', '\x105', '\a', 't', '\x2', '\x2', '\x105', '\x106', '\a', 'w', 
		'\x2', '\x2', '\x106', '\x107', '\a', 'g', '\x2', '\x2', '\x107', ';', 
		'\x3', '\x2', '\x2', '\x2', '\x108', '\x109', '\a', 'H', '\x2', '\x2', 
		'\x109', '\x10A', '\a', '\x63', '\x2', '\x2', '\x10A', '\x10B', '\a', 
		'n', '\x2', '\x2', '\x10B', '\x10C', '\a', 'u', '\x2', '\x2', '\x10C', 
		'\x10D', '\a', 'g', '\x2', '\x2', '\x10D', '=', '\x3', '\x2', '\x2', '\x2', 
		'\x10E', '\x111', '\x5', '`', '/', '\x2', '\x10F', '\x111', '\x5', '\x62', 
		'\x30', '\x2', '\x110', '\x10E', '\x3', '\x2', '\x2', '\x2', '\x110', 
		'\x10F', '\x3', '\x2', '\x2', '\x2', '\x111', '\x118', '\x3', '\x2', '\x2', 
		'\x2', '\x112', '\x117', '\x5', '`', '/', '\x2', '\x113', '\x117', '\x5', 
		'\x62', '\x30', '\x2', '\x114', '\x117', '\x5', '\x64', '\x31', '\x2', 
		'\x115', '\x117', '\a', '\x61', '\x2', '\x2', '\x116', '\x112', '\x3', 
		'\x2', '\x2', '\x2', '\x116', '\x113', '\x3', '\x2', '\x2', '\x2', '\x116', 
		'\x114', '\x3', '\x2', '\x2', '\x2', '\x116', '\x115', '\x3', '\x2', '\x2', 
		'\x2', '\x117', '\x11A', '\x3', '\x2', '\x2', '\x2', '\x118', '\x116', 
		'\x3', '\x2', '\x2', '\x2', '\x118', '\x119', '\x3', '\x2', '\x2', '\x2', 
		'\x119', '?', '\x3', '\x2', '\x2', '\x2', '\x11A', '\x118', '\x3', '\x2', 
		'\x2', '\x2', '\x11B', '\x11D', '\a', '?', '\x2', '\x2', '\x11C', '\x11B', 
		'\x3', '\x2', '\x2', '\x2', '\x11D', '\x11E', '\x3', '\x2', '\x2', '\x2', 
		'\x11E', '\x11C', '\x3', '\x2', '\x2', '\x2', '\x11E', '\x11F', '\x3', 
		'\x2', '\x2', '\x2', '\x11F', '\x120', '\x3', '\x2', '\x2', '\x2', '\x120', 
		'\x121', '\x5', '\x46', '\"', '\x2', '\x121', '\x122', '\a', 'O', '\x2', 
		'\x2', '\x122', '\x123', '\a', 'U', '\x2', '\x2', '\x123', '\x124', '\a', 
		'I', '\x2', '\x2', '\x124', '\x125', '\a', '<', '\x2', '\x2', '\x125', 
		'\x41', '\x3', '\x2', '\x2', '\x2', '\x126', '\x128', '\x5', 'r', '\x38', 
		'\x2', '\x127', '\x126', '\x3', '\x2', '\x2', '\x2', '\x128', '\x129', 
		'\x3', '\x2', '\x2', '\x2', '\x129', '\x127', '\x3', '\x2', '\x2', '\x2', 
		'\x129', '\x12A', '\x3', '\x2', '\x2', '\x2', '\x12A', '\x12B', '\x3', 
		'\x2', '\x2', '\x2', '\x12B', '\x12C', '\b', ' ', '\x4', '\x2', '\x12C', 
		'\x43', '\x3', '\x2', '\x2', '\x2', '\x12D', '\x12F', '\x5', 'p', '\x37', 
		'\x2', '\x12E', '\x12D', '\x3', '\x2', '\x2', '\x2', '\x12F', '\x130', 
		'\x3', '\x2', '\x2', '\x2', '\x130', '\x12E', '\x3', '\x2', '\x2', '\x2', 
		'\x130', '\x131', '\x3', '\x2', '\x2', '\x2', '\x131', '\x132', '\x3', 
		'\x2', '\x2', '\x2', '\x132', '\x133', '\b', '!', '\x4', '\x2', '\x133', 
		'\x45', '\x3', '\x2', '\x2', '\x2', '\x134', '\x135', '\x5', 'p', '\x37', 
		'\x2', '\x135', 'G', '\x3', '\x2', '\x2', '\x2', '\x136', '\x137', '\x5', 
		'>', '\x1E', '\x2', '\x137', 'I', '\x3', '\x2', '\x2', '\x2', '\x138', 
		'\x139', '\x5', 'j', '\x34', '\x2', '\x139', 'K', '\x3', '\x2', '\x2', 
		'\x2', '\x13A', '\x13B', '\x5', 'l', '\x35', '\x2', '\x13B', 'M', '\x3', 
		'\x2', '\x2', '\x2', '\x13C', '\x13E', '\t', '\x2', '\x2', '\x2', '\x13D', 
		'\x13C', '\x3', '\x2', '\x2', '\x2', '\x13E', '\x13F', '\x3', '\x2', '\x2', 
		'\x2', '\x13F', '\x13D', '\x3', '\x2', '\x2', '\x2', '\x13F', '\x140', 
		'\x3', '\x2', '\x2', '\x2', '\x140', 'O', '\x3', '\x2', '\x2', '\x2', 
		'\x141', '\x142', '\x5', 'h', '\x33', '\x2', '\x142', '\x143', '\x3', 
		'\x2', '\x2', '\x2', '\x143', '\x144', '\b', '\'', '\x5', '\x2', '\x144', 
		'Q', '\x3', '\x2', '\x2', '\x2', '\x145', '\x146', '\x5', 'n', '\x36', 
		'\x2', '\x146', '\x147', '\x3', '\x2', '\x2', '\x2', '\x147', '\x148', 
		'\b', '(', '\x3', '\x2', '\x148', 'S', '\x3', '\x2', '\x2', '\x2', '\x149', 
		'\x14B', '\x5', 'r', '\x38', '\x2', '\x14A', '\x149', '\x3', '\x2', '\x2', 
		'\x2', '\x14B', '\x14C', '\x3', '\x2', '\x2', '\x2', '\x14C', '\x14A', 
		'\x3', '\x2', '\x2', '\x2', '\x14C', '\x14D', '\x3', '\x2', '\x2', '\x2', 
		'\x14D', '\x14E', '\x3', '\x2', '\x2', '\x2', '\x14E', '\x14F', '\b', 
		')', '\x4', '\x2', '\x14F', 'U', '\x3', '\x2', '\x2', '\x2', '\x150', 
		'\x151', '\x5', 'p', '\x37', '\x2', '\x151', '\x152', '\x3', '\x2', '\x2', 
		'\x2', '\x152', '\x153', '\b', '*', '\x4', '\x2', '\x153', '\x154', '\b', 
		'*', '\x6', '\x2', '\x154', 'W', '\x3', '\x2', '\x2', '\x2', '\x155', 
		'\x157', '\x5', '\x66', '\x32', '\x2', '\x156', '\x155', '\x3', '\x2', 
		'\x2', '\x2', '\x157', '\x158', '\x3', '\x2', '\x2', '\x2', '\x158', '\x156', 
		'\x3', '\x2', '\x2', '\x2', '\x158', '\x159', '\x3', '\x2', '\x2', '\x2', 
		'\x159', 'Y', '\x3', '\x2', '\x2', '\x2', '\x15A', '\x15B', '\x5', 'p', 
		'\x37', '\x2', '\x15B', '\x15C', '\x3', '\x2', '\x2', '\x2', '\x15C', 
		'\x15D', '\b', ',', '\x4', '\x2', '\x15D', '\x15E', '\b', ',', '\x6', 
		'\x2', '\x15E', '[', '\x3', '\x2', '\x2', '\x2', '\x15F', '\x161', '\x5', 
		'\x66', '\x32', '\x2', '\x160', '\x15F', '\x3', '\x2', '\x2', '\x2', '\x161', 
		'\x162', '\x3', '\x2', '\x2', '\x2', '\x162', '\x160', '\x3', '\x2', '\x2', 
		'\x2', '\x162', '\x163', '\x3', '\x2', '\x2', '\x2', '\x163', ']', '\x3', 
		'\x2', '\x2', '\x2', '\x164', '\x165', '\x5', 'p', '\x37', '\x2', '\x165', 
		'\x166', '\x3', '\x2', '\x2', '\x2', '\x166', '\x167', '\b', '.', '\x4', 
		'\x2', '\x167', '\x168', '\b', '.', '\x6', '\x2', '\x168', '_', '\x3', 
		'\x2', '\x2', '\x2', '\x169', '\x16A', '\t', '\x3', '\x2', '\x2', '\x16A', 
		'\x61', '\x3', '\x2', '\x2', '\x2', '\x16B', '\x16C', '\t', '\x4', '\x2', 
		'\x2', '\x16C', '\x63', '\x3', '\x2', '\x2', '\x2', '\x16D', '\x16E', 
		'\t', '\x2', '\x2', '\x2', '\x16E', '\x65', '\x3', '\x2', '\x2', '\x2', 
		'\x16F', '\x170', '\n', '\x5', '\x2', '\x2', '\x170', 'g', '\x3', '\x2', 
		'\x2', '\x2', '\x171', '\x172', '\a', '?', '\x2', '\x2', '\x172', 'i', 
		'\x3', '\x2', '\x2', '\x2', '\x173', '\x174', '\a', ']', '\x2', '\x2', 
		'\x174', 'k', '\x3', '\x2', '\x2', '\x2', '\x175', '\x176', '\a', '_', 
		'\x2', '\x2', '\x176', 'm', '\x3', '\x2', '\x2', '\x2', '\x177', '\x178', 
		'\a', '%', '\x2', '\x2', '\x178', 'o', '\x3', '\x2', '\x2', '\x2', '\x179', 
		'\x17A', '\a', '\xF', '\x2', '\x2', '\x17A', '\x17D', '\a', '\f', '\x2', 
		'\x2', '\x17B', '\x17D', '\t', '\x5', '\x2', '\x2', '\x17C', '\x179', 
		'\x3', '\x2', '\x2', '\x2', '\x17C', '\x17B', '\x3', '\x2', '\x2', '\x2', 
		'\x17D', 'q', '\x3', '\x2', '\x2', '\x2', '\x17E', '\x181', '\x5', 't', 
		'\x39', '\x2', '\x17F', '\x181', '\t', '\x6', '\x2', '\x2', '\x180', '\x17E', 
		'\x3', '\x2', '\x2', '\x2', '\x180', '\x17F', '\x3', '\x2', '\x2', '\x2', 
		'\x181', 's', '\x3', '\x2', '\x2', '\x2', '\x182', '\x183', '\t', '\a', 
		'\x2', '\x2', '\x183', 'u', '\x3', '\x2', '\x2', '\x2', '\x15', '\x2', 
		'\x3', '\x4', '\x5', '\xF5', '\xFA', '\x101', '\x110', '\x116', '\x118', 
		'\x11E', '\x129', '\x130', '\x13F', '\x14C', '\x158', '\x162', '\x17C', 
		'\x180', '\a', '\x4', '\x3', '\x2', '\x4', '\x5', '\x2', '\x2', '\x3', 
		'\x2', '\x4', '\x4', '\x2', '\x4', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace Joanneum.Robotics.Ros.MessageParser.Antlr
