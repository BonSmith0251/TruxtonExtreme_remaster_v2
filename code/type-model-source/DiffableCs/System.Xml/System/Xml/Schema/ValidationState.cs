namespace System.Xml.Schema;

[Token(Token = "0x20001E7")]
internal sealed class ValidationState
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000A49")]
	public bool IsNill; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4000A4A")]
	public bool IsDefault; //Field offset: 0x11
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x4000A4B")]
	public bool NeedValidateChildren; //Field offset: 0x12
	[FieldOffset(Offset = "0x13")]
	[Token(Token = "0x4000A4C")]
	public bool CheckRequiredAttribute; //Field offset: 0x13
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000A4D")]
	public bool ValidationSkipped; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A4E")]
	public XmlSchemaContentProcessing ProcessContents; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000A4F")]
	public XmlSchemaValidity Validity; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000A50")]
	public SchemaElementDecl ElementDecl; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000A51")]
	public SchemaElementDecl ElementDeclBeforeXsi; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000A52")]
	public string LocalName; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A53")]
	public string Namespace; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A54")]
	public ConstraintStruct[] Constr; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000A55")]
	public StateUnion CurrentState; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000A56")]
	public bool HasMatched; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000A57")]
	public BitSet[] CurPos; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000A58")]
	public BitSet AllElementsSet; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000A59")]
	public List<RangePositionInfo> RunningPositions; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000A5A")]
	public bool TooComplex; //Field offset: 0x68

	[Address(RVA = "0x24789E0", Offset = "0x2477DE0", Length = "0x55")]
	[Token(Token = "0x6001371")]
	public ValidationState() { }

}

