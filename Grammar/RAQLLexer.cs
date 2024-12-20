//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:/github/raql-dotnet/Grammar/RAQL.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

/// <summary>
/// The raql lexer class
/// </summary>
/// <seealso cref="Lexer"/>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public partial class RAQLLexer : Lexer {
	/// <summary>
	/// The decision to dfa
	/// </summary>
	protected static DFA[] decisionToDFA;
	/// <summary>
	/// The prediction context cache
	/// </summary>
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	/// <summary>
	/// The null
	/// </summary>
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, IN=7, BASE_OPERATOR=8, 
		STRING_OPERATOR=9, NUMBER_OPERATOR=10, CONJUNCTIONS=11, NUMBER=12, WORD=13, 
		STRING=14, BOOLEAN=15, NULL=16;
	/// <summary>
	/// The channel names
	/// </summary>
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	/// <summary>
	/// The mode names
	/// </summary>
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	/// <summary>
	/// The rule names
	/// </summary>
	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "WS", "N", "O", "T", "E", 
		"Q", "U", "A", "L", "S", "I", "K", "G", "R", "H", "W", "D", "ESC", "UNICODE", 
		"HEX", "INT", "EXP", "AND", "OR", "SAFECODEPOINT", "NOT", "EQUALS_SYMBOLS", 
		"EQUALS", "NOT_EQUALS_SYMBOLS", "NOT_EQUALS", "MAJOR_SYMBOLS", "MAJOR", 
		"MINOR_SYMBOLS", "MINOR", "MAJOR_EQUALS", "MAJOR_EQUALS_SYMBOLS", "MINOR_EQUALS", 
		"MINOR_EQUALS_SYMBOLS", "LIKE", "IN", "BASE_OPERATOR", "STRING_OPERATOR", 
		"NUMBER_OPERATOR", "CONJUNCTIONS", "NUMBER", "WORD", "STRING", "BOOLEAN", 
		"NULL"
	};


	/// <summary>
	/// Initializes a new instance of the <see cref="RAQLLexer"/> class
	/// </summary>
	/// <param name="input">The input</param>
	public RAQLLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="RAQLLexer"/> class
	/// </summary>
	/// <param name="input">The input</param>
	/// <param name="output">The output</param>
	/// <param name="errorOutput">The error output</param>
	public RAQLLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	/// <summary>
	/// The literal names
	/// </summary>
	private static readonly string[] _LiteralNames = {
		null, "'('", "' '", "')'", "'['", "','", "']'", null, null, null, null, 
		null, null, null, null, null, "'null'"
	};
	/// <summary>
	/// The symbolic names
	/// </summary>
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, "IN", "BASE_OPERATOR", "STRING_OPERATOR", 
		"NUMBER_OPERATOR", "CONJUNCTIONS", "NUMBER", "WORD", "STRING", "BOOLEAN", 
		"NULL"
	};
	/// <summary>
	/// The symbolic names
	/// </summary>
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	/// <summary>
	/// Gets the value of the vocabulary
	/// </summary>
	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	/// <summary>
	/// Gets the value of the grammar file name
	/// </summary>
	public override string GrammarFileName { get { return "RAQL.g4"; } }

	/// <summary>
	/// Gets the value of the rule names
	/// </summary>
	public override string[] RuleNames { get { return ruleNames; } }

	/// <summary>
	/// Gets the value of the channel names
	/// </summary>
	public override string[] ChannelNames { get { return channelNames; } }

	/// <summary>
	/// Gets the value of the mode names
	/// </summary>
	public override string[] ModeNames { get { return modeNames; } }

	/// <summary>
	/// Gets the value of the serialized atn
	/// </summary>
	public override int[] SerializedAtn { get { return _serializedATN; } }

	/// <summary>
	/// Initializes a new instance of the <see cref="RAQLLexer"/> class
	/// </summary>
	static RAQLLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	/// <summary>
	/// The serialized atn
	/// </summary>
	private static int[] _serializedATN = {
		4,0,16,391,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,2,16,7,16,2,17,7,17,2,18,7,18,2,19,7,19,2,20,7,20,2,21,
		7,21,2,22,7,22,2,23,7,23,2,24,7,24,2,25,7,25,2,26,7,26,2,27,7,27,2,28,
		7,28,2,29,7,29,2,30,7,30,2,31,7,31,2,32,7,32,2,33,7,33,2,34,7,34,2,35,
		7,35,2,36,7,36,2,37,7,37,2,38,7,38,2,39,7,39,2,40,7,40,2,41,7,41,2,42,
		7,42,2,43,7,43,2,44,7,44,2,45,7,45,2,46,7,46,2,47,7,47,2,48,7,48,2,49,
		7,49,2,50,7,50,2,51,7,51,2,52,7,52,2,53,7,53,2,54,7,54,1,0,1,0,1,1,1,1,
		1,2,1,2,1,3,1,3,1,4,1,4,1,5,1,5,1,6,1,6,1,7,1,7,1,8,1,8,1,9,1,9,1,10,1,
		10,1,11,1,11,1,12,1,12,1,13,1,13,1,14,1,14,1,15,1,15,1,16,1,16,1,17,1,
		17,1,18,1,18,1,19,1,19,1,20,1,20,1,21,1,21,1,22,1,22,1,23,1,23,1,23,3,
		23,161,8,23,1,24,1,24,1,24,1,24,1,24,1,24,1,25,1,25,1,26,1,26,1,26,5,26,
		174,8,26,10,26,12,26,177,9,26,3,26,179,8,26,1,27,1,27,3,27,183,8,27,1,
		27,1,27,1,28,1,28,1,28,1,28,1,28,1,28,1,29,1,29,1,29,1,29,1,29,1,30,1,
		30,1,31,1,31,1,31,1,31,1,31,3,31,205,8,31,1,32,1,32,1,32,1,32,1,32,1,32,
		1,32,1,32,3,32,215,8,32,1,33,3,33,218,8,33,1,33,1,33,3,33,222,8,33,1,34,
		1,34,1,34,1,34,1,34,1,34,1,34,1,34,1,34,1,34,1,34,1,34,1,34,3,34,237,8,
		34,1,35,3,35,240,8,35,1,35,1,35,3,35,244,8,35,1,36,1,36,1,36,1,36,1,36,
		1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,1,36,3,36,260,8,36,1,37,3,37,263,
		8,37,1,37,1,37,3,37,267,8,37,1,38,1,38,1,38,1,38,1,38,1,38,1,38,1,38,1,
		38,1,38,1,38,1,38,3,38,281,8,38,1,39,3,39,284,8,39,1,39,1,39,3,39,288,
		8,39,1,40,3,40,291,8,40,1,40,1,40,3,40,295,8,40,1,41,1,41,1,41,1,42,3,
		42,301,8,42,1,42,1,42,3,42,305,8,42,1,43,1,43,1,43,1,44,1,44,1,44,1,44,
		1,44,1,44,1,44,1,45,1,45,1,45,1,45,1,45,1,46,1,46,3,46,324,8,46,1,47,1,
		47,1,48,1,48,1,48,1,48,3,48,332,8,48,1,49,1,49,3,49,336,8,49,1,50,3,50,
		339,8,50,1,50,1,50,1,50,4,50,344,8,50,11,50,12,50,345,1,50,3,50,349,8,
		50,1,50,3,50,352,8,50,1,50,1,50,1,50,1,50,3,50,358,8,50,1,50,3,50,361,
		8,50,1,51,1,51,3,51,365,8,51,1,52,1,52,5,52,369,8,52,10,52,12,52,372,9,
		52,1,52,1,52,1,53,1,53,1,53,1,53,1,53,1,53,1,53,1,53,1,53,3,53,385,8,53,
		1,54,1,54,1,54,1,54,1,54,0,0,55,1,1,3,2,5,3,7,4,9,5,11,6,13,0,15,0,17,
		0,19,0,21,0,23,0,25,0,27,0,29,0,31,0,33,0,35,0,37,0,39,0,41,0,43,0,45,
		0,47,0,49,0,51,0,53,0,55,0,57,0,59,0,61,0,63,0,65,0,67,0,69,0,71,0,73,
		0,75,0,77,0,79,0,81,0,83,0,85,0,87,0,89,0,91,7,93,8,95,9,97,10,99,11,101,
		12,103,13,105,14,107,15,109,16,1,0,23,3,0,9,10,13,13,32,32,2,0,78,78,110,
		110,2,0,79,79,111,111,2,0,84,84,116,116,2,0,69,69,101,101,2,0,81,81,113,
		113,2,0,85,85,117,117,2,0,65,65,97,97,2,0,76,76,108,108,2,0,83,83,115,
		115,2,0,73,73,105,105,2,0,75,75,107,107,2,0,71,71,103,103,2,0,82,82,114,
		114,2,0,72,72,104,104,2,0,87,87,104,104,2,0,68,68,100,100,8,0,39,39,47,
		47,92,92,98,98,102,102,110,110,114,114,116,116,3,0,48,57,65,70,97,102,
		1,0,49,57,1,0,48,57,2,0,43,43,45,45,3,0,0,31,39,39,92,92,387,0,1,1,0,0,
		0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,0,0,91,1,
		0,0,0,0,93,1,0,0,0,0,95,1,0,0,0,0,97,1,0,0,0,0,99,1,0,0,0,0,101,1,0,0,
		0,0,103,1,0,0,0,0,105,1,0,0,0,0,107,1,0,0,0,0,109,1,0,0,0,1,111,1,0,0,
		0,3,113,1,0,0,0,5,115,1,0,0,0,7,117,1,0,0,0,9,119,1,0,0,0,11,121,1,0,0,
		0,13,123,1,0,0,0,15,125,1,0,0,0,17,127,1,0,0,0,19,129,1,0,0,0,21,131,1,
		0,0,0,23,133,1,0,0,0,25,135,1,0,0,0,27,137,1,0,0,0,29,139,1,0,0,0,31,141,
		1,0,0,0,33,143,1,0,0,0,35,145,1,0,0,0,37,147,1,0,0,0,39,149,1,0,0,0,41,
		151,1,0,0,0,43,153,1,0,0,0,45,155,1,0,0,0,47,157,1,0,0,0,49,162,1,0,0,
		0,51,168,1,0,0,0,53,178,1,0,0,0,55,180,1,0,0,0,57,186,1,0,0,0,59,192,1,
		0,0,0,61,197,1,0,0,0,63,204,1,0,0,0,65,214,1,0,0,0,67,217,1,0,0,0,69,236,
		1,0,0,0,71,239,1,0,0,0,73,259,1,0,0,0,75,262,1,0,0,0,77,280,1,0,0,0,79,
		283,1,0,0,0,81,290,1,0,0,0,83,296,1,0,0,0,85,300,1,0,0,0,87,306,1,0,0,
		0,89,309,1,0,0,0,91,316,1,0,0,0,93,323,1,0,0,0,95,325,1,0,0,0,97,331,1,
		0,0,0,99,335,1,0,0,0,101,360,1,0,0,0,103,364,1,0,0,0,105,366,1,0,0,0,107,
		384,1,0,0,0,109,386,1,0,0,0,111,112,5,40,0,0,112,2,1,0,0,0,113,114,5,32,
		0,0,114,4,1,0,0,0,115,116,5,41,0,0,116,6,1,0,0,0,117,118,5,91,0,0,118,
		8,1,0,0,0,119,120,5,44,0,0,120,10,1,0,0,0,121,122,5,93,0,0,122,12,1,0,
		0,0,123,124,7,0,0,0,124,14,1,0,0,0,125,126,7,1,0,0,126,16,1,0,0,0,127,
		128,7,2,0,0,128,18,1,0,0,0,129,130,7,3,0,0,130,20,1,0,0,0,131,132,7,4,
		0,0,132,22,1,0,0,0,133,134,7,5,0,0,134,24,1,0,0,0,135,136,7,6,0,0,136,
		26,1,0,0,0,137,138,7,7,0,0,138,28,1,0,0,0,139,140,7,8,0,0,140,30,1,0,0,
		0,141,142,7,9,0,0,142,32,1,0,0,0,143,144,7,10,0,0,144,34,1,0,0,0,145,146,
		7,11,0,0,146,36,1,0,0,0,147,148,7,12,0,0,148,38,1,0,0,0,149,150,7,13,0,
		0,150,40,1,0,0,0,151,152,7,14,0,0,152,42,1,0,0,0,153,154,7,15,0,0,154,
		44,1,0,0,0,155,156,7,16,0,0,156,46,1,0,0,0,157,160,5,92,0,0,158,161,7,
		17,0,0,159,161,3,49,24,0,160,158,1,0,0,0,160,159,1,0,0,0,161,48,1,0,0,
		0,162,163,5,117,0,0,163,164,3,51,25,0,164,165,3,51,25,0,165,166,3,51,25,
		0,166,167,3,51,25,0,167,50,1,0,0,0,168,169,7,18,0,0,169,52,1,0,0,0,170,
		179,5,48,0,0,171,175,7,19,0,0,172,174,7,20,0,0,173,172,1,0,0,0,174,177,
		1,0,0,0,175,173,1,0,0,0,175,176,1,0,0,0,176,179,1,0,0,0,177,175,1,0,0,
		0,178,170,1,0,0,0,178,171,1,0,0,0,179,54,1,0,0,0,180,182,7,4,0,0,181,183,
		7,21,0,0,182,181,1,0,0,0,182,183,1,0,0,0,183,184,1,0,0,0,184,185,3,53,
		26,0,185,56,1,0,0,0,186,187,3,13,6,0,187,188,3,27,13,0,188,189,3,15,7,
		0,189,190,3,45,22,0,190,191,3,13,6,0,191,58,1,0,0,0,192,193,3,13,6,0,193,
		194,3,17,8,0,194,195,3,39,19,0,195,196,3,13,6,0,196,60,1,0,0,0,197,198,
		8,22,0,0,198,62,1,0,0,0,199,205,5,33,0,0,200,201,3,15,7,0,201,202,3,17,
		8,0,202,203,3,19,9,0,203,205,1,0,0,0,204,199,1,0,0,0,204,200,1,0,0,0,205,
		64,1,0,0,0,206,215,5,61,0,0,207,208,3,21,10,0,208,209,3,23,11,0,209,210,
		3,25,12,0,210,211,3,27,13,0,211,212,3,29,14,0,212,213,3,31,15,0,213,215,
		1,0,0,0,214,206,1,0,0,0,214,207,1,0,0,0,215,66,1,0,0,0,216,218,3,13,6,
		0,217,216,1,0,0,0,217,218,1,0,0,0,218,219,1,0,0,0,219,221,3,65,32,0,220,
		222,3,13,6,0,221,220,1,0,0,0,221,222,1,0,0,0,222,68,1,0,0,0,223,224,5,
		33,0,0,224,237,5,61,0,0,225,226,3,15,7,0,226,227,3,17,8,0,227,228,3,19,
		9,0,228,229,3,13,6,0,229,230,3,21,10,0,230,231,3,23,11,0,231,232,3,25,
		12,0,232,233,3,27,13,0,233,234,3,29,14,0,234,235,3,31,15,0,235,237,1,0,
		0,0,236,223,1,0,0,0,236,225,1,0,0,0,237,70,1,0,0,0,238,240,3,13,6,0,239,
		238,1,0,0,0,239,240,1,0,0,0,240,241,1,0,0,0,241,243,3,69,34,0,242,244,
		3,13,6,0,243,242,1,0,0,0,243,244,1,0,0,0,244,72,1,0,0,0,245,260,5,62,0,
		0,246,247,3,37,18,0,247,248,3,39,19,0,248,249,3,21,10,0,249,250,3,27,13,
		0,250,251,3,19,9,0,251,252,3,21,10,0,252,253,3,39,19,0,253,254,3,13,6,
		0,254,255,3,19,9,0,255,256,3,41,20,0,256,257,3,27,13,0,257,258,3,15,7,
		0,258,260,1,0,0,0,259,245,1,0,0,0,259,246,1,0,0,0,260,74,1,0,0,0,261,263,
		3,13,6,0,262,261,1,0,0,0,262,263,1,0,0,0,263,264,1,0,0,0,264,266,3,73,
		36,0,265,267,3,13,6,0,266,265,1,0,0,0,266,267,1,0,0,0,267,76,1,0,0,0,268,
		281,5,60,0,0,269,270,3,29,14,0,270,271,3,17,8,0,271,272,3,43,21,0,272,
		273,3,21,10,0,273,274,3,39,19,0,274,275,3,13,6,0,275,276,3,19,9,0,276,
		277,3,41,20,0,277,278,3,27,13,0,278,279,3,15,7,0,279,281,1,0,0,0,280,268,
		1,0,0,0,280,269,1,0,0,0,281,78,1,0,0,0,282,284,3,13,6,0,283,282,1,0,0,
		0,283,284,1,0,0,0,284,285,1,0,0,0,285,287,3,77,38,0,286,288,3,13,6,0,287,
		286,1,0,0,0,287,288,1,0,0,0,288,80,1,0,0,0,289,291,3,13,6,0,290,289,1,
		0,0,0,290,291,1,0,0,0,291,292,1,0,0,0,292,294,3,83,41,0,293,295,3,13,6,
		0,294,293,1,0,0,0,294,295,1,0,0,0,295,82,1,0,0,0,296,297,5,62,0,0,297,
		298,5,61,0,0,298,84,1,0,0,0,299,301,3,13,6,0,300,299,1,0,0,0,300,301,1,
		0,0,0,301,302,1,0,0,0,302,304,3,87,43,0,303,305,3,13,6,0,304,303,1,0,0,
		0,304,305,1,0,0,0,305,86,1,0,0,0,306,307,5,60,0,0,307,308,5,61,0,0,308,
		88,1,0,0,0,309,310,3,13,6,0,310,311,3,29,14,0,311,312,3,33,16,0,312,313,
		3,35,17,0,313,314,3,21,10,0,314,315,3,13,6,0,315,90,1,0,0,0,316,317,3,
		13,6,0,317,318,3,33,16,0,318,319,3,15,7,0,319,320,3,13,6,0,320,92,1,0,
		0,0,321,324,3,67,33,0,322,324,3,71,35,0,323,321,1,0,0,0,323,322,1,0,0,
		0,324,94,1,0,0,0,325,326,3,89,44,0,326,96,1,0,0,0,327,332,3,75,37,0,328,
		332,3,81,40,0,329,332,3,79,39,0,330,332,3,85,42,0,331,327,1,0,0,0,331,
		328,1,0,0,0,331,329,1,0,0,0,331,330,1,0,0,0,332,98,1,0,0,0,333,336,3,57,
		28,0,334,336,3,59,29,0,335,333,1,0,0,0,335,334,1,0,0,0,336,100,1,0,0,0,
		337,339,5,45,0,0,338,337,1,0,0,0,338,339,1,0,0,0,339,340,1,0,0,0,340,341,
		3,53,26,0,341,343,5,46,0,0,342,344,7,20,0,0,343,342,1,0,0,0,344,345,1,
		0,0,0,345,343,1,0,0,0,345,346,1,0,0,0,346,348,1,0,0,0,347,349,3,55,27,
		0,348,347,1,0,0,0,348,349,1,0,0,0,349,361,1,0,0,0,350,352,5,45,0,0,351,
		350,1,0,0,0,351,352,1,0,0,0,352,353,1,0,0,0,353,354,3,53,26,0,354,355,
		3,55,27,0,355,361,1,0,0,0,356,358,5,45,0,0,357,356,1,0,0,0,357,358,1,0,
		0,0,358,359,1,0,0,0,359,361,3,53,26,0,360,338,1,0,0,0,360,351,1,0,0,0,
		360,357,1,0,0,0,361,102,1,0,0,0,362,365,3,47,23,0,363,365,3,61,30,0,364,
		362,1,0,0,0,364,363,1,0,0,0,365,104,1,0,0,0,366,370,5,39,0,0,367,369,3,
		103,51,0,368,367,1,0,0,0,369,372,1,0,0,0,370,368,1,0,0,0,370,371,1,0,0,
		0,371,373,1,0,0,0,372,370,1,0,0,0,373,374,5,39,0,0,374,106,1,0,0,0,375,
		376,5,116,0,0,376,377,5,114,0,0,377,378,5,117,0,0,378,385,5,101,0,0,379,
		380,5,102,0,0,380,381,5,97,0,0,381,382,5,108,0,0,382,383,5,115,0,0,383,
		385,5,101,0,0,384,375,1,0,0,0,384,379,1,0,0,0,385,108,1,0,0,0,386,387,
		5,110,0,0,387,388,5,117,0,0,388,389,5,108,0,0,389,390,5,108,0,0,390,110,
		1,0,0,0,34,0,160,175,178,182,204,214,217,221,236,239,243,259,262,266,280,
		283,287,290,294,300,304,323,331,335,338,345,348,351,357,360,364,370,384,
		0
	};

	/// <summary>
	/// The serialized atn
	/// </summary>
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
