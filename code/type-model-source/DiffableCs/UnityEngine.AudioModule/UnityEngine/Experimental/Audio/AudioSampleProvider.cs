namespace UnityEngine.Experimental.Audio;

[NativeType(Header = "Modules/Audio/Public/ScriptBindings/AudioSampleProvider.bindings.h")]
[StaticAccessor("AudioSampleProviderBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000010")]
public class AudioSampleProvider
{
	[Token(Token = "0x2000011")]
	internal sealed class SampleFramesHandler : MulticastDelegate
	{

		[Address(RVA = "0x1C4BDC0", Offset = "0x1C4B1C0", Length = "0x125")]
		[Token(Token = "0x6000087")]
		public SampleFramesHandler(object object, IntPtr method) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x6000088")]
		public override void Invoke(AudioSampleProvider provider, uint sampleFrameCount) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000028")]
	private SampleFramesHandler sampleFramesAvailable; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000029")]
	private SampleFramesHandler sampleFramesOverflow; //Field offset: 0x18

	[Address(RVA = "0x2FC8A00", Offset = "0x2FC7E00", Length = "0x21")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000085")]
	private void InvokeSampleFramesAvailable(int sampleFrameCount) { }

	[Address(RVA = "0x2FC8A30", Offset = "0x2FC7E30", Length = "0x21")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000086")]
	private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) { }

}

