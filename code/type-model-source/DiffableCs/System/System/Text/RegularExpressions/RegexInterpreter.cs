namespace System.Text.RegularExpressions;

[Token(Token = "0x20000EC")]
internal sealed class RegexInterpreter : RegexRunner
{
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40003F8")]
	private readonly RegexCode _code; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40003F9")]
	private readonly CultureInfo _culture; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40003FA")]
	private int _operator; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x40003FB")]
	private int _codepos; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40003FC")]
	private bool _rightToLeft; //Field offset: 0x98
	[FieldOffset(Offset = "0x99")]
	[Token(Token = "0x40003FD")]
	private bool _caseInsensitive; //Field offset: 0x99

	[Address(RVA = "0x2627610", Offset = "0x2626A10", Length = "0x5A")]
	[Token(Token = "0x6000555")]
	public RegexInterpreter(RegexCode code, CultureInfo culture) { }

	[Address(RVA = "0x2624470", Offset = "0x2623870", Length = "0x76")]
	[Token(Token = "0x6000557")]
	private void Advance(int i) { }

	[Address(RVA = "0x26244F0", Offset = "0x26238F0", Length = "0xD3")]
	[Token(Token = "0x6000564")]
	private void Backtrack() { }

	[Address(RVA = "0x26245D0", Offset = "0x26239D0", Length = "0x1A")]
	[Token(Token = "0x6000579")]
	private void Backwardnext() { }

	[Address(RVA = "0x26245F0", Offset = "0x26239F0", Length = "0x15")]
	[Token(Token = "0x6000574")]
	private int Bump() { }

	[Address(RVA = "0x2624610", Offset = "0x2623A10", Length = "0x1E")]
	[Token(Token = "0x600057A")]
	private char CharAt(int j) { }

	[Address(RVA = "0x2624630", Offset = "0x2623A30", Length = "0x5E6")]
	[Token(Token = "0x600057B")]
	protected virtual bool FindFirstChar() { }

	[Address(RVA = "0x2624C20", Offset = "0x2624020", Length = "0x92")]
	[Token(Token = "0x6000576")]
	private char Forwardcharnext() { }

	[Address(RVA = "0x2624CC0", Offset = "0x26240C0", Length = "0x17")]
	[Token(Token = "0x6000575")]
	private int Forwardchars() { }

	[Address(RVA = "0x2624CE0", Offset = "0x26240E0", Length = "0x1400")]
	[Token(Token = "0x600057C")]
	protected virtual void Go() { }

	[Address(RVA = "0x2626C90", Offset = "0x2626090", Length = "0x80")]
	[Token(Token = "0x6000558")]
	private void Goto(int newpos) { }

	[Address(RVA = "0x2626D20", Offset = "0x2626120", Length = "0x20")]
	[Token(Token = "0x6000556")]
	protected virtual void InitTrackCount() { }

	[Address(RVA = "0x2626D50", Offset = "0x2626150", Length = "0x7")]
	[Token(Token = "0x6000572")]
	private int Leftchars() { }

	[Address(RVA = "0x2626D60", Offset = "0x2626160", Length = "0x41")]
	[Token(Token = "0x6000571")]
	private int Operand(int i) { }

	[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
	[Token(Token = "0x6000570")]
	private int Operator() { }

	[Address(RVA = "0x2626DB0", Offset = "0x26261B0", Length = "0x1C8")]
	[Token(Token = "0x6000578")]
	private bool Refmatch(int index, int len) { }

	[Address(RVA = "0x2626F80", Offset = "0x2626380", Length = "0x7")]
	[Token(Token = "0x6000573")]
	private int Rightchars() { }

	[Address(RVA = "0x2626F90", Offset = "0x2626390", Length = "0x28")]
	[Token(Token = "0x6000565")]
	private void SetOperator(int op) { }

	[Address(RVA = "0x2626FF0", Offset = "0x26263F0", Length = "0x32")]
	[Token(Token = "0x600056F")]
	private int StackPeek(int i) { }

	[Address(RVA = "0x2626FC0", Offset = "0x26263C0", Length = "0x2D")]
	[Token(Token = "0x600056E")]
	private int StackPeek() { }

	[Address(RVA = "0x2627030", Offset = "0x2626430", Length = "0x4")]
	[Token(Token = "0x600056C")]
	private void StackPop() { }

	[Address(RVA = "0x2627040", Offset = "0x2626440", Length = "0x4")]
	[Token(Token = "0x600056D")]
	private void StackPop(int framesize) { }

	[Address(RVA = "0x26270B0", Offset = "0x26264B0", Length = "0x37")]
	[Token(Token = "0x600056A")]
	private void StackPush(int I1) { }

	[Address(RVA = "0x2627050", Offset = "0x2626450", Length = "0x5B")]
	[Token(Token = "0x600056B")]
	private void StackPush(int I1, int I2) { }

	[Address(RVA = "0x26270F0", Offset = "0x26264F0", Length = "0x15C")]
	[Token(Token = "0x6000577")]
	private bool Stringmatch(string str) { }

	[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
	[Token(Token = "0x600055C")]
	private int Textpos() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x600055B")]
	private int Textstart() { }

	[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
	[Token(Token = "0x6000559")]
	private void Textto(int newpos) { }

	[Address(RVA = "0x2627290", Offset = "0x2626690", Length = "0x2D")]
	[Token(Token = "0x6000568")]
	private int TrackPeek() { }

	[Address(RVA = "0x2627250", Offset = "0x2626650", Length = "0x32")]
	[Token(Token = "0x6000569")]
	private int TrackPeek(int i) { }

	[Address(RVA = "0x26272D0", Offset = "0x26266D0", Length = "0x4")]
	[Token(Token = "0x6000567")]
	private void TrackPop(int framesize) { }

	[Address(RVA = "0x26272C0", Offset = "0x26266C0", Length = "0x4")]
	[Token(Token = "0x6000566")]
	private void TrackPop() { }

	[Address(RVA = "0x26275D0", Offset = "0x26269D0", Length = "0x1D")]
	[Token(Token = "0x600055D")]
	private int Trackpos() { }

	[Address(RVA = "0x26273E0", Offset = "0x26267E0", Length = "0xAD")]
	[Token(Token = "0x6000561")]
	private void TrackPush(int I1, int I2, int I3) { }

	[Address(RVA = "0x2627490", Offset = "0x2626890", Length = "0x85")]
	[Token(Token = "0x6000560")]
	private void TrackPush(int I1, int I2) { }

	[Address(RVA = "0x2627590", Offset = "0x2626990", Length = "0x3D")]
	[Token(Token = "0x600055E")]
	private void TrackPush() { }

	[Address(RVA = "0x2627520", Offset = "0x2626920", Length = "0x60")]
	[Token(Token = "0x600055F")]
	private void TrackPush(int I1) { }

	[Address(RVA = "0x26272E0", Offset = "0x26266E0", Length = "0x87")]
	[Token(Token = "0x6000563")]
	private void TrackPush2(int I1, int I2) { }

	[Address(RVA = "0x2627370", Offset = "0x2626770", Length = "0x60")]
	[Token(Token = "0x6000562")]
	private void TrackPush2(int I1) { }

	[Address(RVA = "0x26275F0", Offset = "0x26269F0", Length = "0x1F")]
	[Token(Token = "0x600055A")]
	private void Trackto(int newpos) { }

}

