grammar RAQL;

raql: clause EOF;
clause:
	operation
	| '(' ' '? clause ' '? ')'
	| clause conjunction clause;
conjunction: CONJUNCTIONS;
operation:
	bool_array_operation
	| number_array_operation
	| string_array_operation
	| bool_operation
	| number_operation
	| string_operation;
string_array_operation: field array_operator string_array;
number_array_operation: field array_operator number_array;
bool_array_operation: field array_operator bool_array;
array_operator: IN;
string_operation: field string_operator (string | nullstring);
string_operator: BASE_OPERATOR | STRING_OPERATOR;
number_operation: field number_operator number;
number_operator: BASE_OPERATOR | NUMBER_OPERATOR;
bool_operation: field bool_operator bool;
bool_operator: BASE_OPERATOR;
field: (WORD)*;
nullstring: NULL;
string: STRING;
string_array: '[' string (',' string)* ']' | '[' ']';
number: NUMBER;
number_array: '[' number (',' number)* ']' | '[' ']';
bool: BOOLEAN;
bool_array: '[' bool (',' bool)* ']' | '[' ']';

fragment WS: [ \t\n\r];
fragment N: 'N' | 'n';
fragment O: 'O' | 'o';
fragment T: 'T' | 't';
fragment E: 'E' | 'e';
fragment Q: 'Q' | 'q';
fragment U: 'U' | 'u';
fragment A: 'A' | 'a';
fragment L: 'L' | 'l';
fragment S: 'S' | 's';
fragment I: 'I' | 'i';
fragment K: 'K' | 'k';
fragment G: 'G' | 'g';
fragment R: 'R' | 'r';
fragment H: 'H' | 'h';
fragment W: 'W' | 'h';
fragment D: 'D' | 'd';
fragment ESC: '\\' (['\\/bfnrt] | UNICODE);
fragment UNICODE: 'u' HEX HEX HEX HEX;
fragment HEX: [0-9a-fA-F];
fragment INT: '0' | [1-9] [0-9]*; // no leading zeros
fragment EXP:
	[Ee] [+\-]? INT; // \- since - means "range" inside [...]
fragment AND: WS A N D WS;
fragment OR: WS O R WS;
fragment SAFECODEPOINT: ~ ['\\\u0000-\u001F];
fragment NOT: '!' | N O T;
fragment EQUALS_SYMBOLS: '=' | E Q U A L S;
fragment EQUALS: WS? EQUALS_SYMBOLS WS?;
fragment NOT_EQUALS_SYMBOLS: '!=' | N O T WS E Q U A L S;
fragment NOT_EQUALS: WS? NOT_EQUALS_SYMBOLS WS?;
fragment MAJOR_SYMBOLS: '>' | G R E A T E R WS T H A N;
fragment MAJOR: WS? MAJOR_SYMBOLS WS?;
fragment MINOR_SYMBOLS: '<' | L O W E R WS T H A N;
fragment MINOR: WS? MINOR_SYMBOLS WS?;
fragment MAJOR_EQUALS: WS? MAJOR_EQUALS_SYMBOLS WS?;
fragment MAJOR_EQUALS_SYMBOLS: '>=';
fragment MINOR_EQUALS: WS? MINOR_EQUALS_SYMBOLS WS?;
fragment MINOR_EQUALS_SYMBOLS: '<=';
fragment LIKE: WS L I K E WS;
IN: WS I N WS;
BASE_OPERATOR: EQUALS | NOT_EQUALS;
STRING_OPERATOR: LIKE;
NUMBER_OPERATOR: MAJOR | MAJOR_EQUALS | MINOR | MINOR_EQUALS;
CONJUNCTIONS: AND | OR;
NUMBER:
	'-'? INT '.' [0-9]+ EXP? // 1.35, 1.35E-9, 0.3, -4.5
	| '-'? INT EXP // 1e10 -3e4
	| '-'? INT; // -3, 45
WORD: ESC | SAFECODEPOINT;
STRING: '\'' (WORD)* '\'';
BOOLEAN: 'true' | 'false';
NULL: 'null';
