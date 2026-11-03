namespace UnityEngine.LowLevel;

[MovedFrom("UnityEngine.Experimental.LowLevel")]
[Token(Token = "0x2000268")]
public struct PlayerLoopSystem
{
	[Token(Token = "0x2000269")]
	internal sealed class UpdateFunction : MulticastDelegate
	{

		[Address(RVA = "0x639280", Offset = "0x638680", Length = "0xA5")]
		[Token(Token = "0x600188A")]
		public UpdateFunction(object object, IntPtr method) { }

		[Address(RVA = "0x639270", Offset = "0x638670", Length = "0xF")]
		[Token(Token = "0x600188B")]
		public override void Invoke() { }

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40007E7")]
	public Type type; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40007E8")]
	public PlayerLoopSystem[] subSystemList; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007E9")]
	public UpdateFunction updateDelegate; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007EA")]
	public IntPtr updateFunction; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007EB")]
	public IntPtr loopConditionFunction; //Field offset: 0x20

	[Address(RVA = "0x3081060", Offset = "0x3080460", Length = "0x29")]
	[Token(Token = "0x6001889")]
	public virtual string ToString() { }

}

