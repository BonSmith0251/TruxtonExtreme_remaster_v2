namespace Cysharp.Threading.Tasks;

[Token(Token = "0x200000A")]
internal sealed class PooledTweenCallback
{
	[Token(Token = "0x4000025")]
	private static readonly ConcurrentQueue<PooledTweenCallback> pool; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000026")]
	private readonly TweenCallback runDelegate; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000027")]
	private Action continuation; //Field offset: 0x18

	[Address(RVA = "0x274F8E0", Offset = "0x274ECE0", Length = "0x84")]
	[Token(Token = "0x6000023")]
	private static PooledTweenCallback() { }

	[Address(RVA = "0x274F970", Offset = "0x274ED70", Length = "0x7D")]
	[Token(Token = "0x6000020")]
	private PooledTweenCallback() { }

	[Address(RVA = "0x274F750", Offset = "0x274EB50", Length = "0xDA")]
	[Token(Token = "0x6000021")]
	public static TweenCallback Create(Action continuation) { }

	[Address(RVA = "0x274F830", Offset = "0x274EC30", Length = "0xAC")]
	[Token(Token = "0x6000022")]
	private void Run() { }

}

