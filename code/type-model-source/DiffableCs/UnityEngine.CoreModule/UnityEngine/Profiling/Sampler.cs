namespace UnityEngine.Profiling;

[NativeHeader("Runtime/Profiler/ScriptBindings/Sampler.bindings.h")]
[Token(Token = "0x2000203")]
[UsedByNativeCode]
public class Sampler
{
	[Token(Token = "0x4000739")]
	internal static Sampler s_InvalidSampler; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000738")]
	internal IntPtr m_Ptr; //Field offset: 0x10

	[Token(Token = "0x17000374")]
	public bool isValid
	{
		[Address(RVA = "0x3069AF0", Offset = "0x3068EF0", Length = "0xB")]
		[Token(Token = "0x6001719")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x30863F0", Offset = "0x30857F0", Length = "0x67")]
	[Token(Token = "0x600171B")]
	private static Sampler() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001717")]
	internal Sampler() { }

	[Address(RVA = "0x2B7F420", Offset = "0x2B7E820", Length = "0x26")]
	[Token(Token = "0x6001718")]
	internal Sampler(IntPtr ptr) { }

	[Address(RVA = "0x3069AF0", Offset = "0x3068EF0", Length = "0xB")]
	[Token(Token = "0x6001719")]
	public bool get_isValid() { }

	[Address(RVA = "0x30862C0", Offset = "0x30856C0", Length = "0x125")]
	[Token(Token = "0x600171A")]
	public Recorder GetRecorder() { }

}

