namespace Unity.Properties;

[AttributeUsage(384)]
[Token(Token = "0x200000A")]
public class CreatePropertyAttribute : RequiredMemberAttribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000015")]
	private bool <ReadOnly>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000002")]
	public bool ReadOnly
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000019")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600001A")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x3141FA0", Offset = "0x31413A0", Length = "0xB")]
	[Token(Token = "0x600001B")]
	public CreatePropertyAttribute() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000019")]
	public bool get_ReadOnly() { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600001A")]
	public void set_ReadOnly(bool value) { }

}

