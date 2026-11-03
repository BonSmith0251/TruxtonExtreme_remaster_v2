namespace Newtonsoft.Json;

[AttributeUsage(384, AllowMultiple = False)]
[Token(Token = "0x2000021")]
public class JsonExtensionDataAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000041")]
	private bool <WriteData>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4000042")]
	private bool <ReadData>k__BackingField; //Field offset: 0x11

	[Token(Token = "0x17000018")]
	public bool ReadData
	{
		[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600009C")]
		 get { } //Length: 5
		[Address(RVA = "0x1FD5130", Offset = "0x1FD4530", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600009D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000017")]
	public bool WriteData
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600009A")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600009B")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x20CD170", Offset = "0x20CC570", Length = "0x1C")]
	[Token(Token = "0x600009E")]
	public JsonExtensionDataAttribute() { }

	[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600009C")]
	public bool get_ReadData() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600009A")]
	public bool get_WriteData() { }

	[Address(RVA = "0x1FD5130", Offset = "0x1FD4530", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600009D")]
	public void set_ReadData(bool value) { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600009B")]
	public void set_WriteData(bool value) { }

}

