namespace UnityEngine.Timeline;

[AssetFileNameExtension("signal", new IL2CPP_TYPE_STRING[] {})]
[Token(Token = "0x2000048")]
public class SignalAsset : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x400012E")]
	private static Action<SignalAsset> OnEnableCallback; //Field offset: 0x0

	[Token(Token = "0x14000003")]
	internal static event Action<SignalAsset> OnEnableCallback
	{
		[Address(RVA = "0x2F31340", Offset = "0x2F30740", Length = "0xD7")]
		[CompilerGenerated]
		[Token(Token = "0x6000295")]
		internal add { } //Length: 215
		[Address(RVA = "0x2F31420", Offset = "0x2F30820", Length = "0xD7")]
		[CompilerGenerated]
		[Token(Token = "0x6000296")]
		internal remove { } //Length: 215
	}

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x6000298")]
	public SignalAsset() { }

	[Address(RVA = "0x2F31340", Offset = "0x2F30740", Length = "0xD7")]
	[CompilerGenerated]
	[Token(Token = "0x6000295")]
	internal static void add_OnEnableCallback(Action<SignalAsset> value) { }

	[Address(RVA = "0x2F312E0", Offset = "0x2F306E0", Length = "0x59")]
	[Token(Token = "0x6000297")]
	private void OnEnable() { }

	[Address(RVA = "0x2F31420", Offset = "0x2F30820", Length = "0xD7")]
	[CompilerGenerated]
	[Token(Token = "0x6000296")]
	internal static void remove_OnEnableCallback(Action<SignalAsset> value) { }

}

