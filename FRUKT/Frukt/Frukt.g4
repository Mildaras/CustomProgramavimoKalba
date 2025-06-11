grammar Frukt;

/*
--------------- Parser rules ----------------
      Should be written in lower case
*/

program                 : line* EOF;

line                    : functionStatement | statement | ifBlock | whileBlock;

statement               : (assignment | functionCall | arrayDeclaration) '.';

block                   : '{' line* '}';

//---Variables
      assignment              : IDENTIFIER '=' expression;

      constant                : NUMBER | FLOAT | BOOL | TEXT;

//---If 
      ifBlock                 : 'if' expression block (elseifBlock | elseBlock)?;

      elseifBlock             : 'else' expression block (elseifBlock | elseBlock)?;

      elseBlock               : 'else' block;

//---While
      whileBlock              : WHILE expression block;

//---Function
      functionStatement       : IDENTIFIER '(' (expression (',' expression)*)? ')' block;

      functionCall            : IDENTIFIER '(' (expression (',' expression)*)? ')';

//---Array
      arrayAccess             : IDENTIFIER '[' expression ']';

      arrayDeclaration        : IDENTIFIER '=' '[' expressionList ']';

      expressionList          : expression (',' expression)*;

expression
    : constant                                              #constantExpression
    | IDENTIFIER                                            #identifierExpression
    | functionCall                                          #functionCallExpression
    | arrayAccess                                           #arrayAccessExpression
    | '(' expression ')'                                    #parenthesesExpression
    | expression multdivOp expression                       #multdivExpression
    | expression addsubOp expression                        #addsubExpression
    | expression compareOp expression compareOp expression  #multipleComparisonExpression
    | expression compareOp expression                       #comparisonExpression
    ;

multdivOp               : '*' | '/';

addsubOp                : '+' | '-';

compareOp               : '==' | '!=' | '<' | '>' | '<=' | '>=';

/*
---------------- Lexer rules ----------------
      Should be written in upper case
*/

fragment DIGIT          : [0-9];

fragment T              : ('t' | 'T');
fragment R              : ('r' | 'R');
fragment U              : ('u' | 'U');
fragment E              : ('e' | 'E');
fragment F              : ('f' | 'F');
fragment A              : ('a' | 'A');
fragment L              : ('l' | 'L');
fragment S              : ('s' | 'S');
fragment W              : ('w' | 'W');
fragment H              : ('h' | 'H');
fragment I              : ('i' | 'I');

WHILE                   : W H I L E;

NUMBER                  : DIGIT+;

FLOAT                   : DIGIT+ ',' DIGIT+;

TEXT                    : ('"' ~'"'* '"');

BOOL                    : (T R U E) | (F A L S E);

WHITESPACE              : ( ' ' | '\t' ) -> skip;

IDENTIFIER              : [a-zA-Z_][a-zA-Z0-9_]*;


