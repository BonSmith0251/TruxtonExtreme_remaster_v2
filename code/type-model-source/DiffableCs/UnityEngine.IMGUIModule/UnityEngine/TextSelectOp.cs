namespace UnityEngine;

[Token(Token = "0x200002E")]
internal enum TextSelectOp : int
{
	SelectLeft = 0,
	SelectRight = 1,
	SelectUp = 2,
	SelectDown = 3,
	SelectTextStart = 4,
	SelectTextEnd = 5,
	SelectPageUp = 6,
	SelectPageDown = 7,
	ExpandSelectGraphicalLineStart = 8,
	ExpandSelectGraphicalLineEnd = 9,
	SelectGraphicalLineStart = 10,
	SelectGraphicalLineEnd = 11,
	SelectWordLeft = 12,
	SelectWordRight = 13,
	SelectToEndOfPreviousWord = 14,
	SelectToStartOfNextWord = 15,
	SelectParagraphBackward = 16,
	SelectParagraphForward = 17,
	Copy = 18,
	SelectAll = 19,
	SelectNone = 20,
}

