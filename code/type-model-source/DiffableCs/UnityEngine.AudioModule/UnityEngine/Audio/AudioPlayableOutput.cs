namespace UnityEngine.Audio;

[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableOutput.bindings.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioPlayableOutput.h")]
[NativeHeader("Modules/Audio/Public/AudioSource.h")]
[RequiredByNativeCode]
[StaticAccessor("AudioPlayableOutputBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x200002D")]
public struct AudioPlayableOutput : IPlayableOutput
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400005B")]
	private PlayableOutputHandle m_Handle; //Field offset: 0x0

	[Token(Token = "0x17000021")]
	public static AudioPlayableOutput Null
	{
		[Address(RVA = "0x2FC8740", Offset = "0x2FC7B40", Length = "0x124")]
		[Token(Token = "0x60000C6")]
		 get { } //Length: 292
	}

	[Address(RVA = "0x2FC8660", Offset = "0x2FC7A60", Length = "0xDC")]
	[Token(Token = "0x60000C5")]
	internal AudioPlayableOutput(PlayableOutputHandle handle) { }

	[Address(RVA = "0x2FC8290", Offset = "0x2FC7690", Length = "0x2AF")]
	[Token(Token = "0x60000C4")]
	public static AudioPlayableOutput Create(PlayableGraph graph, string name, AudioSource target) { }

	[Address(RVA = "0x2FC8740", Offset = "0x2FC7B40", Length = "0x124")]
	[Token(Token = "0x60000C6")]
	public static AudioPlayableOutput get_Null() { }

	[Address(RVA = "0xF56090", Offset = "0xF55490", Length = "0xA")]
	[Token(Token = "0x60000C7")]
	public override PlayableOutputHandle GetHandle() { }

	[Address(RVA = "0x2FC8540", Offset = "0x2FC7940", Length = "0x42")]
	[NativeThrows]
	[Token(Token = "0x60000CD")]
	private static void InternalSetEvaluateOnSeek(ref PlayableOutputHandle output, bool value) { }

	[Address(RVA = "0x2FC85E0", Offset = "0x2FC79E0", Length = "0x7A")]
	[NativeThrows]
	[Token(Token = "0x60000CC")]
	private static void InternalSetTarget(ref PlayableOutputHandle output, AudioSource target) { }

	[Address(RVA = "0x2FC8590", Offset = "0x2FC7990", Length = "0x42")]
	[Token(Token = "0x60000CE")]
	private static void InternalSetTarget_Injected(ref PlayableOutputHandle output, IntPtr target) { }

	[Address(RVA = "0x2FC8870", Offset = "0x2FC7C70", Length = "0x134")]
	[Token(Token = "0x60000C9")]
	public static AudioPlayableOutput op_Explicit(PlayableOutput output) { }

	[Address(RVA = "0x2FAD840", Offset = "0x2FACC40", Length = "0x3F")]
	[Token(Token = "0x60000C8")]
	public static PlayableOutput op_Implicit(AudioPlayableOutput output) { }

	[Address(RVA = "0x2FC8540", Offset = "0x2FC7940", Length = "0x42")]
	[Token(Token = "0x60000CB")]
	public void SetEvaluateOnSeek(bool value) { }

	[Address(RVA = "0x2FC85E0", Offset = "0x2FC79E0", Length = "0x7A")]
	[Token(Token = "0x60000CA")]
	public void SetTarget(AudioSource value) { }

}

