namespace System.Xml.Schema;

[Token(Token = "0x20001DB")]
internal sealed class SchemaEntity : IDtdEntityInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40008FE")]
	private XmlQualifiedName qname; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008FF")]
	private string url; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000900")]
	private string pubid; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000901")]
	private string text; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000902")]
	private XmlQualifiedName ndata; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000903")]
	private int lineNumber; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000904")]
	private int linePosition; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000905")]
	private bool isParameter; //Field offset: 0x40
	[FieldOffset(Offset = "0x41")]
	[Token(Token = "0x4000906")]
	private bool isExternal; //Field offset: 0x41
	[FieldOffset(Offset = "0x42")]
	[Token(Token = "0x4000907")]
	private bool parsingInProgress; //Field offset: 0x42
	[FieldOffset(Offset = "0x43")]
	[Token(Token = "0x4000908")]
	private bool isDeclaredInExternal; //Field offset: 0x43
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000909")]
	private string baseURI; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400090A")]
	private string declaredURI; //Field offset: 0x50

	[Token(Token = "0x1700051F")]
	internal string BaseURI
	{
		[Address(RVA = "0x2470490", Offset = "0x246F890", Length = "0x1E")]
		[Token(Token = "0x60012EC")]
		internal get { } //Length: 30
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x60012ED")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700051A")]
	internal bool DeclaredInExternal
	{
		[Address(RVA = "0x1FDC510", Offset = "0x1FDB910", Length = "0x5")]
		[Token(Token = "0x60012E2")]
		internal get { } //Length: 5
		[Address(RVA = "0x24704D0", Offset = "0x246F8D0", Length = "0x4")]
		[Token(Token = "0x60012E3")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000521")]
	internal string DeclaredURI
	{
		[Address(RVA = "0x24704B0", Offset = "0x246F8B0", Length = "0x1E")]
		[Token(Token = "0x60012F0")]
		internal get { } //Length: 30
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x60012F1")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000519")]
	internal bool IsExternal
	{
		[Address(RVA = "0x1DDDDB0", Offset = "0x1DDD1B0", Length = "0x5")]
		[Token(Token = "0x60012E0")]
		internal get { } //Length: 5
		[Address(RVA = "0x1DDDAB0", Offset = "0x1DDCEB0", Length = "0x4")]
		[Token(Token = "0x60012E1")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700051D")]
	internal int Line
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x60012E8")]
		internal get { } //Length: 4
		[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
		[Token(Token = "0x60012E9")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000516")]
	internal XmlQualifiedName Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60012DB")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700051B")]
	internal XmlQualifiedName NData
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60012E4")]
		internal get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x60012E5")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000520")]
	internal bool ParsingInProgress
	{
		[Address(RVA = "0x1DDDDC0", Offset = "0x1DDD1C0", Length = "0x5")]
		[Token(Token = "0x60012EE")]
		internal get { } //Length: 5
		[Address(RVA = "0x1DDDAC0", Offset = "0x1DDCEC0", Length = "0x4")]
		[Token(Token = "0x60012EF")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x1700051E")]
	internal int Pos
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x60012EA")]
		internal get { } //Length: 4
		[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
		[Token(Token = "0x60012EB")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000518")]
	internal string Pubid
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60012DE")]
		internal get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60012DF")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700050F")]
	private override string System.Xml.IDtdEntityInfo.BaseUriString
	{
		[Address(RVA = "0x2470380", Offset = "0x246F780", Length = "0x1E")]
		[Token(Token = "0x60012D3")]
		private get { } //Length: 30
	}

	[Token(Token = "0x17000510")]
	private override string System.Xml.IDtdEntityInfo.DeclaredUriString
	{
		[Address(RVA = "0x24703A0", Offset = "0x246F7A0", Length = "0x1E")]
		[Token(Token = "0x60012D4")]
		private get { } //Length: 30
	}

	[Token(Token = "0x1700050C")]
	private override bool System.Xml.IDtdEntityInfo.IsDeclaredInExternal
	{
		[Address(RVA = "0x1FDC510", Offset = "0x1FDB910", Length = "0x5")]
		[Token(Token = "0x60012D0")]
		private get { } //Length: 5
	}

	[Token(Token = "0x1700050B")]
	private override bool System.Xml.IDtdEntityInfo.IsExternal
	{
		[Address(RVA = "0x1DDDDB0", Offset = "0x1DDD1B0", Length = "0x5")]
		[Token(Token = "0x60012CF")]
		private get { } //Length: 5
	}

	[Token(Token = "0x1700050E")]
	private override bool System.Xml.IDtdEntityInfo.IsParameterEntity
	{
		[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
		[Token(Token = "0x60012D2")]
		private get { } //Length: 5
	}

	[Token(Token = "0x1700050D")]
	private override bool System.Xml.IDtdEntityInfo.IsUnparsedEntity
	{
		[Address(RVA = "0x24703C0", Offset = "0x246F7C0", Length = "0x20")]
		[Token(Token = "0x60012D1")]
		private get { } //Length: 32
	}

	[Token(Token = "0x17000514")]
	private override int System.Xml.IDtdEntityInfo.LineNumber
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x60012D8")]
		private get { } //Length: 4
	}

	[Token(Token = "0x17000515")]
	private override int System.Xml.IDtdEntityInfo.LinePosition
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x60012D9")]
		private get { } //Length: 4
	}

	[Token(Token = "0x1700050A")]
	private override string System.Xml.IDtdEntityInfo.Name
	{
		[Address(RVA = "0x141B2F0", Offset = "0x141A6F0", Length = "0x1B")]
		[Token(Token = "0x60012CE")]
		private get { } //Length: 27
	}

	[Token(Token = "0x17000512")]
	private override string System.Xml.IDtdEntityInfo.PublicId
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60012D6")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000511")]
	private override string System.Xml.IDtdEntityInfo.SystemId
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60012D5")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000513")]
	private override string System.Xml.IDtdEntityInfo.Text
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60012D7")]
		private get { } //Length: 5
	}

	[Token(Token = "0x1700051C")]
	internal string Text
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60012E6")]
		internal get { } //Length: 5
		[Address(RVA = "0x24704F0", Offset = "0x246F8F0", Length = "0x20")]
		[Token(Token = "0x60012E7")]
		internal set { } //Length: 32
	}

	[Token(Token = "0x17000517")]
	internal string Url
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60012DC")]
		internal get { } //Length: 5
		[Address(RVA = "0x2470510", Offset = "0x246F910", Length = "0x20")]
		[Token(Token = "0x60012DD")]
		internal set { } //Length: 32
	}

	[Address(RVA = "0x24703F0", Offset = "0x246F7F0", Length = "0x9A")]
	[Token(Token = "0x60012CD")]
	internal SchemaEntity(XmlQualifiedName qname, bool isParameter) { }

	[Address(RVA = "0x2470490", Offset = "0x246F890", Length = "0x1E")]
	[Token(Token = "0x60012EC")]
	internal string get_BaseURI() { }

	[Address(RVA = "0x1FDC510", Offset = "0x1FDB910", Length = "0x5")]
	[Token(Token = "0x60012E2")]
	internal bool get_DeclaredInExternal() { }

	[Address(RVA = "0x24704B0", Offset = "0x246F8B0", Length = "0x1E")]
	[Token(Token = "0x60012F0")]
	internal string get_DeclaredURI() { }

	[Address(RVA = "0x1DDDDB0", Offset = "0x1DDD1B0", Length = "0x5")]
	[Token(Token = "0x60012E0")]
	internal bool get_IsExternal() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x60012E8")]
	internal int get_Line() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60012DB")]
	internal XmlQualifiedName get_Name() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60012E4")]
	internal XmlQualifiedName get_NData() { }

	[Address(RVA = "0x1DDDDC0", Offset = "0x1DDD1C0", Length = "0x5")]
	[Token(Token = "0x60012EE")]
	internal bool get_ParsingInProgress() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x60012EA")]
	internal int get_Pos() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60012DE")]
	internal string get_Pubid() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60012E6")]
	internal string get_Text() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60012DC")]
	internal string get_Url() { }

	[Address(RVA = "0x24702B0", Offset = "0x246F6B0", Length = "0xCC")]
	[Token(Token = "0x60012DA")]
	internal static bool IsPredefinedEntity(string n) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x60012ED")]
	internal void set_BaseURI(string value) { }

	[Address(RVA = "0x24704D0", Offset = "0x246F8D0", Length = "0x4")]
	[Token(Token = "0x60012E3")]
	internal void set_DeclaredInExternal(bool value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x60012F1")]
	internal void set_DeclaredURI(string value) { }

	[Address(RVA = "0x1DDDAB0", Offset = "0x1DDCEB0", Length = "0x4")]
	[Token(Token = "0x60012E1")]
	internal void set_IsExternal(bool value) { }

	[Address(RVA = "0x1E08FD0", Offset = "0x1E083D0", Length = "0x4")]
	[Token(Token = "0x60012E9")]
	internal void set_Line(int value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x60012E5")]
	internal void set_NData(XmlQualifiedName value) { }

	[Address(RVA = "0x1DDDAC0", Offset = "0x1DDCEC0", Length = "0x4")]
	[Token(Token = "0x60012EF")]
	internal void set_ParsingInProgress(bool value) { }

	[Address(RVA = "0x24704E0", Offset = "0x246F8E0", Length = "0x4")]
	[Token(Token = "0x60012EB")]
	internal void set_Pos(int value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60012DF")]
	internal void set_Pubid(string value) { }

	[Address(RVA = "0x24704F0", Offset = "0x246F8F0", Length = "0x20")]
	[Token(Token = "0x60012E7")]
	internal void set_Text(string value) { }

	[Address(RVA = "0x2470510", Offset = "0x246F910", Length = "0x20")]
	[Token(Token = "0x60012DD")]
	internal void set_Url(string value) { }

	[Address(RVA = "0x2470380", Offset = "0x246F780", Length = "0x1E")]
	[Token(Token = "0x60012D3")]
	private override string System.Xml.IDtdEntityInfo.get_BaseUriString() { }

	[Address(RVA = "0x24703A0", Offset = "0x246F7A0", Length = "0x1E")]
	[Token(Token = "0x60012D4")]
	private override string System.Xml.IDtdEntityInfo.get_DeclaredUriString() { }

	[Address(RVA = "0x1FDC510", Offset = "0x1FDB910", Length = "0x5")]
	[Token(Token = "0x60012D0")]
	private override bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal() { }

	[Address(RVA = "0x1DDDDB0", Offset = "0x1DDD1B0", Length = "0x5")]
	[Token(Token = "0x60012CF")]
	private override bool System.Xml.IDtdEntityInfo.get_IsExternal() { }

	[Address(RVA = "0x1116920", Offset = "0x1115D20", Length = "0x5")]
	[Token(Token = "0x60012D2")]
	private override bool System.Xml.IDtdEntityInfo.get_IsParameterEntity() { }

	[Address(RVA = "0x24703C0", Offset = "0x246F7C0", Length = "0x20")]
	[Token(Token = "0x60012D1")]
	private override bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x60012D8")]
	private override int System.Xml.IDtdEntityInfo.get_LineNumber() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x60012D9")]
	private override int System.Xml.IDtdEntityInfo.get_LinePosition() { }

	[Address(RVA = "0x141B2F0", Offset = "0x141A6F0", Length = "0x1B")]
	[Token(Token = "0x60012CE")]
	private override string System.Xml.IDtdEntityInfo.get_Name() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60012D6")]
	private override string System.Xml.IDtdEntityInfo.get_PublicId() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60012D5")]
	private override string System.Xml.IDtdEntityInfo.get_SystemId() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60012D7")]
	private override string System.Xml.IDtdEntityInfo.get_Text() { }

}

