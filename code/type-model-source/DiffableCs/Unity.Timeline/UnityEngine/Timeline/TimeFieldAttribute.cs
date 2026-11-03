namespace UnityEngine.Timeline;

[Token(Token = "0x2000068")]
internal class TimeFieldAttribute : PropertyAttribute
{
	[Token(Token = "0x2000069")]
	internal enum UseEditMode : int
	{
		None = 0,
		ApplyEditMode = 1,
	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400016B")]
	private readonly UseEditMode <useEditMode>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170000D0")]
	public UseEditMode useEditMode
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000326")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2C5F130", Offset = "0x2C5E530", Length = "0x24")]
	[Token(Token = "0x6000327")]
	public TimeFieldAttribute(UseEditMode useEditMode = 1) { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000326")]
	public UseEditMode get_useEditMode() { }

}

