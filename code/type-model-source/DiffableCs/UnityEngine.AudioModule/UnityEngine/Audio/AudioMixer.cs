namespace UnityEngine.Audio;

[ExcludeFromObjectFactory]
[ExcludeFromPreset]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixer.bindings.h")]
[NativeHeader("Modules/Audio/Public/AudioMixer.h")]
[Token(Token = "0x2000027")]
public class AudioMixer : object
{

	[Address(RVA = "0x2FC7EB0", Offset = "0x2FC72B0", Length = "0x49")]
	[Token(Token = "0x60000B1")]
	internal AudioMixer() { }

	[Address(RVA = "0x2FC7840", Offset = "0x2FC6C40", Length = "0x1D0")]
	[NativeMethod("AudioMixerBindings::FindMatchingGroups", IsFreeFunction = True, HasExplicitThis = True)]
	[Token(Token = "0x60000B2")]
	public AudioMixerGroup[] FindMatchingGroups(string subPath) { }

	[Address(RVA = "0x2FC77F0", Offset = "0x2FC6BF0", Length = "0x42")]
	[Token(Token = "0x60000B5")]
	private static AudioMixerGroup[] FindMatchingGroups_Injected(IntPtr _unity_self, ref ManagedSpanWrapper subPath) { }

	[Address(RVA = "0x2FC7A80", Offset = "0x2FC6E80", Length = "0x1D0")]
	[NativeMethod]
	[Token(Token = "0x60000B4")]
	public bool GetFloat(string name, out float value) { }

	[Address(RVA = "0x2FC7A20", Offset = "0x2FC6E20", Length = "0x52")]
	[Token(Token = "0x60000B7")]
	private static bool GetFloat_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, out float value) { }

	[Address(RVA = "0x2FC7CC0", Offset = "0x2FC70C0", Length = "0x1E3")]
	[NativeMethod]
	[Token(Token = "0x60000B3")]
	public bool SetFloat(string name, float value) { }

	[Address(RVA = "0x2FC7C60", Offset = "0x2FC7060", Length = "0x52")]
	[Token(Token = "0x60000B6")]
	private static bool SetFloat_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, float value) { }

}

