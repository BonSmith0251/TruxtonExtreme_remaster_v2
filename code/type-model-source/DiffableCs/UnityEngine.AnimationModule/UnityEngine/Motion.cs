namespace UnityEngine;

[NativeHeader("Modules/Animation/Motion.h")]
[Token(Token = "0x2000026")]
public class Motion : object
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40000C8")]
	private readonly bool <isAnimatorMotion>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000050")]
	public bool isLooping
	{
		[Address(RVA = "0x2FC2130", Offset = "0x2FC1530", Length = "0x76")]
		[NativeMethod("IsLooping")]
		[Token(Token = "0x600021D")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x2FC20A0", Offset = "0x2FC14A0", Length = "0x49")]
	[Token(Token = "0x600021C")]
	protected Motion() { }

	[Address(RVA = "0x2FC2130", Offset = "0x2FC1530", Length = "0x76")]
	[NativeMethod("IsLooping")]
	[Token(Token = "0x600021D")]
	public bool get_isLooping() { }

	[Address(RVA = "0x2FC20F0", Offset = "0x2FC14F0", Length = "0x33")]
	[Token(Token = "0x600021E")]
	private static bool get_isLooping_Injected(IntPtr _unity_self) { }

}

