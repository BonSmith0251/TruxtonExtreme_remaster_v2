namespace Unity.Cinemachine;

[Token(Token = "0x2000190")]
public sealed class CinemachineShot : PlayableAsset, IPropertyPreview
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006A8")]
	[Tooltip("The name to display on the track.  If empty, the CmCamera's name will be used.")]
	public string DisplayName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006A9")]
	[Tooltip("The Cinemachine camera to use for this shot")]
	public ExposedReference<CinemachineVirtualCameraBase> VirtualCamera; //Field offset: 0x20

	[Address(RVA = "0x1D308B0", Offset = "0x1D2FCB0", Length = "0x7")]
	[Token(Token = "0x600085D")]
	public CinemachineShot() { }

	[Address(RVA = "0x289E860", Offset = "0x289DC60", Length = "0x14C")]
	[Token(Token = "0x600085B")]
	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	[Address(RVA = "0x289E9B0", Offset = "0x289DDB0", Length = "0x19C")]
	[Token(Token = "0x600085C")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

}

