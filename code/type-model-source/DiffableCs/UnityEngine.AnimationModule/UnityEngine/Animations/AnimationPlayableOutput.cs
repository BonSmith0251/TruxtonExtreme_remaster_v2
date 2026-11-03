namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableOutput.bindings.h")]
[NativeHeader("Modules/Animation/Animator.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Modules/Animation/Director/AnimationPlayableOutput.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimationPlayableOutputBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000036")]
public struct AnimationPlayableOutput : IPlayableOutput
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000D9")]
	private PlayableOutputHandle m_Handle; //Field offset: 0x0

	[Token(Token = "0x1700005E")]
	public static AnimationPlayableOutput Null
	{
		[Address(RVA = "0x2FB32D0", Offset = "0x2FB26D0", Length = "0x124")]
		[Token(Token = "0x60002A8")]
		 get { } //Length: 292
	}

	[Address(RVA = "0x2FB31F0", Offset = "0x2FB25F0", Length = "0xDC")]
	[Token(Token = "0x60002A7")]
	internal AnimationPlayableOutput(PlayableOutputHandle handle) { }

	[Address(RVA = "0x2FB2DD0", Offset = "0x2FB21D0", Length = "0x2AF")]
	[Token(Token = "0x60002A6")]
	public static AnimationPlayableOutput Create(PlayableGraph graph, string name, Animator target) { }

	[Address(RVA = "0x2FB32D0", Offset = "0x2FB26D0", Length = "0x124")]
	[Token(Token = "0x60002A8")]
	public static AnimationPlayableOutput get_Null() { }

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x60002A9")]
	public override PlayableOutputHandle GetHandle() { }

	[Address(RVA = "0x2FB3080", Offset = "0x2FB2480", Length = "0x5D")]
	[Token(Token = "0x60002AC")]
	public Animator GetTarget() { }

	[Address(RVA = "0x2FB3080", Offset = "0x2FB2480", Length = "0x5D")]
	[NativeThrows]
	[Token(Token = "0x60002AE")]
	private static Animator InternalGetTarget(ref PlayableOutputHandle handle) { }

	[Address(RVA = "0x2FB30E0", Offset = "0x2FB24E0", Length = "0x33")]
	[Token(Token = "0x60002B0")]
	private static IntPtr InternalGetTarget_Injected(ref PlayableOutputHandle handle) { }

	[Address(RVA = "0x2FB3170", Offset = "0x2FB2570", Length = "0x7A")]
	[NativeThrows]
	[Token(Token = "0x60002AF")]
	private static void InternalSetTarget(ref PlayableOutputHandle handle, Animator target) { }

	[Address(RVA = "0x2FB3120", Offset = "0x2FB2520", Length = "0x42")]
	[Token(Token = "0x60002B1")]
	private static void InternalSetTarget_Injected(ref PlayableOutputHandle handle, IntPtr target) { }

	[Address(RVA = "0x2FB3400", Offset = "0x2FB2800", Length = "0x134")]
	[Token(Token = "0x60002AB")]
	public static AnimationPlayableOutput op_Explicit(PlayableOutput output) { }

	[Address(RVA = "0x2FAD840", Offset = "0x2FACC40", Length = "0x3F")]
	[Token(Token = "0x60002AA")]
	public static PlayableOutput op_Implicit(AnimationPlayableOutput output) { }

	[Address(RVA = "0x2FB3170", Offset = "0x2FB2570", Length = "0x7A")]
	[Token(Token = "0x60002AD")]
	public void SetTarget(Animator value) { }

}

