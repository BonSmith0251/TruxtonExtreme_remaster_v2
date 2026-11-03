namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x200010A")]
public class ErrorContext
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000507")]
	private bool <Traced>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000508")]
	private readonly Exception <Error>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Nullable(2)]
	[Token(Token = "0x4000509")]
	private readonly object <OriginalObject>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Nullable(2)]
	[Token(Token = "0x400050A")]
	private readonly object <Member>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400050B")]
	private readonly string <Path>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400050C")]
	private bool <Handled>k__BackingField; //Field offset: 0x38

	[Token(Token = "0x170000F1")]
	public Exception Error
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007B6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000F5")]
	public bool Handled
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007BA")]
		 get { } //Length: 5
		[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007BB")]
		 set { } //Length: 4
	}

	[Nullable(2)]
	[Token(Token = "0x170000F3")]
	public object Member
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x60007B8")]
		 get { } //Length: 5
	}

	[Nullable(2)]
	[Token(Token = "0x170000F2")]
	public object OriginalObject
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[NullableContext(2)]
		[Token(Token = "0x60007B7")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000F4")]
	public string Path
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007B9")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000F0")]
	internal bool Traced
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60007B4")]
		internal get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60007B5")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x213E030", Offset = "0x213D430", Length = "0x7D")]
	[Token(Token = "0x60007B3")]
	internal ErrorContext(object originalObject, object member, string path, Exception error) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007B6")]
	public Exception get_Error() { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007BA")]
	public bool get_Handled() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[NullableContext(2)]
	[Token(Token = "0x60007B8")]
	public object get_Member() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[NullableContext(2)]
	[Token(Token = "0x60007B7")]
	public object get_OriginalObject() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007B9")]
	public string get_Path() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60007B4")]
	internal bool get_Traced() { }

	[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007BB")]
	public void set_Handled(bool value) { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60007B5")]
	internal void set_Traced(bool value) { }

}

