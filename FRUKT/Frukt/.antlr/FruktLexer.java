// Generated from c:\Users\milda\OneDrive\Stalinis kompiuteris\pktProjektas\projektas2023\Frukt\Frukt.g4 by ANTLR 4.9.2
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class FruktLexer extends Lexer {
	static { RuntimeMetaData.checkVersion("4.9.2", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, WHILE=22, NUMBER=23, FLOAT=24, 
		TEXT=25, BOOL=26, WHITESPACE=27, IDENTIFIER=28;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
			"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
			"T__17", "T__18", "T__19", "T__20", "DIGIT", "T", "R", "U", "E", "F", 
			"A", "L", "S", "W", "H", "I", "WHILE", "NUMBER", "FLOAT", "TEXT", "BOOL", 
			"WHITESPACE", "IDENTIFIER"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
			null, "'.'", "'{'", "'}'", "'='", "'if'", "'else'", "'('", "','", "')'", 
			"'['", "']'", "'*'", "'/'", "'+'", "'-'", "'=='", "'!='", "'<'", "'>'", 
			"'<='", "'>='"
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, null, null, null, null, null, null, null, null, null, null, null, 
			null, null, null, null, null, null, null, null, null, null, "WHILE", 
			"NUMBER", "FLOAT", "TEXT", "BOOL", "WHITESPACE", "IDENTIFIER"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}


	public FruktLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "Frukt.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2\36\u00d4\b\1\4\2"+
		"\t\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4"+
		"\13\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22"+
		"\t\22\4\23\t\23\4\24\t\24\4\25\t\25\4\26\t\26\4\27\t\27\4\30\t\30\4\31"+
		"\t\31\4\32\t\32\4\33\t\33\4\34\t\34\4\35\t\35\4\36\t\36\4\37\t\37\4 \t"+
		" \4!\t!\4\"\t\"\4#\t#\4$\t$\4%\t%\4&\t&\4\'\t\'\4(\t(\4)\t)\3\2\3\2\3"+
		"\3\3\3\3\4\3\4\3\5\3\5\3\6\3\6\3\6\3\7\3\7\3\7\3\7\3\7\3\b\3\b\3\t\3\t"+
		"\3\n\3\n\3\13\3\13\3\f\3\f\3\r\3\r\3\16\3\16\3\17\3\17\3\20\3\20\3\21"+
		"\3\21\3\21\3\22\3\22\3\22\3\23\3\23\3\24\3\24\3\25\3\25\3\25\3\26\3\26"+
		"\3\26\3\27\3\27\3\30\3\30\3\31\3\31\3\32\3\32\3\33\3\33\3\34\3\34\3\35"+
		"\3\35\3\36\3\36\3\37\3\37\3 \3 \3!\3!\3\"\3\"\3#\3#\3#\3#\3#\3#\3$\6$"+
		"\u00a5\n$\r$\16$\u00a6\3%\6%\u00aa\n%\r%\16%\u00ab\3%\3%\6%\u00b0\n%\r"+
		"%\16%\u00b1\3&\3&\7&\u00b6\n&\f&\16&\u00b9\13&\3&\3&\3\'\3\'\3\'\3\'\3"+
		"\'\3\'\3\'\3\'\3\'\3\'\3\'\5\'\u00c8\n\'\3(\3(\3(\3(\3)\3)\7)\u00d0\n"+
		")\f)\16)\u00d3\13)\2\2*\3\3\5\4\7\5\t\6\13\7\r\b\17\t\21\n\23\13\25\f"+
		"\27\r\31\16\33\17\35\20\37\21!\22#\23%\24\'\25)\26+\27-\2/\2\61\2\63\2"+
		"\65\2\67\29\2;\2=\2?\2A\2C\2E\30G\31I\32K\33M\34O\35Q\36\3\2\22\3\2\62"+
		";\4\2VVvv\4\2TTtt\4\2WWww\4\2GGgg\4\2HHhh\4\2CCcc\4\2NNnn\4\2UUuu\4\2"+
		"YYyy\4\2JJjj\4\2KKkk\3\2$$\4\2\13\13\"\"\5\2C\\aac|\6\2\62;C\\aac|\2\u00cd"+
		"\2\3\3\2\2\2\2\5\3\2\2\2\2\7\3\2\2\2\2\t\3\2\2\2\2\13\3\2\2\2\2\r\3\2"+
		"\2\2\2\17\3\2\2\2\2\21\3\2\2\2\2\23\3\2\2\2\2\25\3\2\2\2\2\27\3\2\2\2"+
		"\2\31\3\2\2\2\2\33\3\2\2\2\2\35\3\2\2\2\2\37\3\2\2\2\2!\3\2\2\2\2#\3\2"+
		"\2\2\2%\3\2\2\2\2\'\3\2\2\2\2)\3\2\2\2\2+\3\2\2\2\2E\3\2\2\2\2G\3\2\2"+
		"\2\2I\3\2\2\2\2K\3\2\2\2\2M\3\2\2\2\2O\3\2\2\2\2Q\3\2\2\2\3S\3\2\2\2\5"+
		"U\3\2\2\2\7W\3\2\2\2\tY\3\2\2\2\13[\3\2\2\2\r^\3\2\2\2\17c\3\2\2\2\21"+
		"e\3\2\2\2\23g\3\2\2\2\25i\3\2\2\2\27k\3\2\2\2\31m\3\2\2\2\33o\3\2\2\2"+
		"\35q\3\2\2\2\37s\3\2\2\2!u\3\2\2\2#x\3\2\2\2%{\3\2\2\2\'}\3\2\2\2)\177"+
		"\3\2\2\2+\u0082\3\2\2\2-\u0085\3\2\2\2/\u0087\3\2\2\2\61\u0089\3\2\2\2"+
		"\63\u008b\3\2\2\2\65\u008d\3\2\2\2\67\u008f\3\2\2\29\u0091\3\2\2\2;\u0093"+
		"\3\2\2\2=\u0095\3\2\2\2?\u0097\3\2\2\2A\u0099\3\2\2\2C\u009b\3\2\2\2E"+
		"\u009d\3\2\2\2G\u00a4\3\2\2\2I\u00a9\3\2\2\2K\u00b3\3\2\2\2M\u00c7\3\2"+
		"\2\2O\u00c9\3\2\2\2Q\u00cd\3\2\2\2ST\7\60\2\2T\4\3\2\2\2UV\7}\2\2V\6\3"+
		"\2\2\2WX\7\177\2\2X\b\3\2\2\2YZ\7?\2\2Z\n\3\2\2\2[\\\7k\2\2\\]\7h\2\2"+
		"]\f\3\2\2\2^_\7g\2\2_`\7n\2\2`a\7u\2\2ab\7g\2\2b\16\3\2\2\2cd\7*\2\2d"+
		"\20\3\2\2\2ef\7.\2\2f\22\3\2\2\2gh\7+\2\2h\24\3\2\2\2ij\7]\2\2j\26\3\2"+
		"\2\2kl\7_\2\2l\30\3\2\2\2mn\7,\2\2n\32\3\2\2\2op\7\61\2\2p\34\3\2\2\2"+
		"qr\7-\2\2r\36\3\2\2\2st\7/\2\2t \3\2\2\2uv\7?\2\2vw\7?\2\2w\"\3\2\2\2"+
		"xy\7#\2\2yz\7?\2\2z$\3\2\2\2{|\7>\2\2|&\3\2\2\2}~\7@\2\2~(\3\2\2\2\177"+
		"\u0080\7>\2\2\u0080\u0081\7?\2\2\u0081*\3\2\2\2\u0082\u0083\7@\2\2\u0083"+
		"\u0084\7?\2\2\u0084,\3\2\2\2\u0085\u0086\t\2\2\2\u0086.\3\2\2\2\u0087"+
		"\u0088\t\3\2\2\u0088\60\3\2\2\2\u0089\u008a\t\4\2\2\u008a\62\3\2\2\2\u008b"+
		"\u008c\t\5\2\2\u008c\64\3\2\2\2\u008d\u008e\t\6\2\2\u008e\66\3\2\2\2\u008f"+
		"\u0090\t\7\2\2\u00908\3\2\2\2\u0091\u0092\t\b\2\2\u0092:\3\2\2\2\u0093"+
		"\u0094\t\t\2\2\u0094<\3\2\2\2\u0095\u0096\t\n\2\2\u0096>\3\2\2\2\u0097"+
		"\u0098\t\13\2\2\u0098@\3\2\2\2\u0099\u009a\t\f\2\2\u009aB\3\2\2\2\u009b"+
		"\u009c\t\r\2\2\u009cD\3\2\2\2\u009d\u009e\5? \2\u009e\u009f\5A!\2\u009f"+
		"\u00a0\5C\"\2\u00a0\u00a1\5;\36\2\u00a1\u00a2\5\65\33\2\u00a2F\3\2\2\2"+
		"\u00a3\u00a5\5-\27\2\u00a4\u00a3\3\2\2\2\u00a5\u00a6\3\2\2\2\u00a6\u00a4"+
		"\3\2\2\2\u00a6\u00a7\3\2\2\2\u00a7H\3\2\2\2\u00a8\u00aa\5-\27\2\u00a9"+
		"\u00a8\3\2\2\2\u00aa\u00ab\3\2\2\2\u00ab\u00a9\3\2\2\2\u00ab\u00ac\3\2"+
		"\2\2\u00ac\u00ad\3\2\2\2\u00ad\u00af\7.\2\2\u00ae\u00b0\5-\27\2\u00af"+
		"\u00ae\3\2\2\2\u00b0\u00b1\3\2\2\2\u00b1\u00af\3\2\2\2\u00b1\u00b2\3\2"+
		"\2\2\u00b2J\3\2\2\2\u00b3\u00b7\7$\2\2\u00b4\u00b6\n\16\2\2\u00b5\u00b4"+
		"\3\2\2\2\u00b6\u00b9\3\2\2\2\u00b7\u00b5\3\2\2\2\u00b7\u00b8\3\2\2\2\u00b8"+
		"\u00ba\3\2\2\2\u00b9\u00b7\3\2\2\2\u00ba\u00bb\7$\2\2\u00bbL\3\2\2\2\u00bc"+
		"\u00bd\5/\30\2\u00bd\u00be\5\61\31\2\u00be\u00bf\5\63\32\2\u00bf\u00c0"+
		"\5\65\33\2\u00c0\u00c8\3\2\2\2\u00c1\u00c2\5\67\34\2\u00c2\u00c3\59\35"+
		"\2\u00c3\u00c4\5;\36\2\u00c4\u00c5\5=\37\2\u00c5\u00c6\5\65\33\2\u00c6"+
		"\u00c8\3\2\2\2\u00c7\u00bc\3\2\2\2\u00c7\u00c1\3\2\2\2\u00c8N\3\2\2\2"+
		"\u00c9\u00ca\t\17\2\2\u00ca\u00cb\3\2\2\2\u00cb\u00cc\b(\2\2\u00ccP\3"+
		"\2\2\2\u00cd\u00d1\t\20\2\2\u00ce\u00d0\t\21\2\2\u00cf\u00ce\3\2\2\2\u00d0"+
		"\u00d3\3\2\2\2\u00d1\u00cf\3\2\2\2\u00d1\u00d2\3\2\2\2\u00d2R\3\2\2\2"+
		"\u00d3\u00d1\3\2\2\2\t\2\u00a6\u00ab\u00b1\u00b7\u00c7\u00d1\3\b\2\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}