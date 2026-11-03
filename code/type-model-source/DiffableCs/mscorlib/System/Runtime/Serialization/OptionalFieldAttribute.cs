namespace System.Runtime.Serialization;

[AttributeUsage(AttributeTargets::Field (256), Inherited = False)]
[ComVisible(True)]
[Token(Token = "0x20003F4")]
public sealed class OptionalFieldAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F74")]
	private int versionAdded; //Field offset: 0x10

	[Token(Token = "0x170003CB")]
	public int VersionAdded
	{
		[Address(RVA = "0x1F26790", Offset = "0x1F25B90", Length = "0x7A")]
		[Token(Token = "0x6001E4C")]
		 set { } //Length: 122
	}

	[Address(RVA = "0x1F26780", Offset = "0x1F25B80", Length = "0xE")]
	[Token(Token = "0x6001E4B")]
	public OptionalFieldAttribute() { }

	[Address(RVA = "0x1F26790", Offset = "0x1F25B90", Length = "0x7A")]
	[Token(Token = "0x6001E4C")]
	public void set_VersionAdded(int value) { }

}

