namespace UnityEngine.Playables;

[AssetFileNameExtension("playable", new IL2CPP_TYPE_STRING[] {})]
[RequiredByNativeCode]
[Token(Token = "0x200031E")]
public abstract class PlayableAsset : ScriptableObject, IPlayableAsset
{

	[Token(Token = "0x170003AE")]
	public override double duration
	{
		[Address(RVA = "0x307BFA0", Offset = "0x307B3A0", Length = "0x50")]
		[Token(Token = "0x600190A")]
		 get { } //Length: 80
	}

	[Token(Token = "0x170003AF")]
	public override IEnumerable<PlayableBinding> outputs
	{
		[Address(RVA = "0x307BFF0", Offset = "0x307B3F0", Length = "0x4E")]
		[Token(Token = "0x600190B")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x600190E")]
	protected PlayableAsset() { }

	[Token(Token = "0x6001909")]
	public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	[Address(RVA = "0x307BFA0", Offset = "0x307B3A0", Length = "0x50")]
	[Token(Token = "0x600190A")]
	public override double get_duration() { }

	[Address(RVA = "0x307BFF0", Offset = "0x307B3F0", Length = "0x4E")]
	[Token(Token = "0x600190B")]
	public override IEnumerable<PlayableBinding> get_outputs() { }

	[Address(RVA = "0x307BE30", Offset = "0x307B230", Length = "0x122")]
	[RequiredByNativeCode]
	[Token(Token = "0x600190C")]
	internal static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr) { }

	[Address(RVA = "0x307BF60", Offset = "0x307B360", Length = "0x30")]
	[RequiredByNativeCode]
	[Token(Token = "0x600190D")]
	internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble) { }

}

