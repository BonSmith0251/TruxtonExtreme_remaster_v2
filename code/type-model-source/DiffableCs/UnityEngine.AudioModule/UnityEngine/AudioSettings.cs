namespace UnityEngine;

[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
[StaticAccessor("GetAudioManager()", StaticAccessorType::Dot (0))]
[Token(Token = "0x2000008")]
public sealed class AudioSettings
{
	[Token(Token = "0x2000009")]
	internal sealed class AudioConfigurationChangeHandler : MulticastDelegate
	{

		[Address(RVA = "0x119B410", Offset = "0x119A810", Length = "0xA6")]
		[Token(Token = "0x6000004")]
		public AudioConfigurationChangeHandler(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6000005")]
		public override void Invoke(bool deviceWasChanged) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000023")]
	private static AudioConfigurationChangeHandler OnAudioConfigurationChanged; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000024")]
	private static Action OnAudioSystemShuttingDown; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000025")]
	private static Action OnAudioSystemStartedUp; //Field offset: 0x10

	[Address(RVA = "0x2FC8A60", Offset = "0x2FC7E60", Length = "0x59")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000001")]
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

	[Address(RVA = "0x2FC8AC0", Offset = "0x2FC7EC0", Length = "0x4F")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000002")]
	internal static void InvokeOnAudioSystemShuttingDown() { }

	[Address(RVA = "0x2FC8B10", Offset = "0x2FC7F10", Length = "0x4F")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000003")]
	internal static void InvokeOnAudioSystemStartedUp() { }

}

