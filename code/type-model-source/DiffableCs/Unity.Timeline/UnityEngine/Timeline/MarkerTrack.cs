namespace UnityEngine.Timeline;

[ExcludeFromPreset]
[HideInMenu]
[Token(Token = "0x2000046")]
[TrackBindingType(typeof(GameObject))]
public class MarkerTrack : TrackAsset
{

	[Token(Token = "0x170000BF")]
	public virtual IEnumerable<PlayableBinding> outputs
	{
		[Address(RVA = "0x2F2FAE0", Offset = "0x2F2EEE0", Length = "0x229")]
		[Token(Token = "0x6000292")]
		 get { } //Length: 553
	}

	[Address(RVA = "0x2F2FA90", Offset = "0x2F2EE90", Length = "0x49")]
	[Token(Token = "0x6000293")]
	public MarkerTrack() { }

	[Address(RVA = "0x2F2FAE0", Offset = "0x2F2EEE0", Length = "0x229")]
	[Token(Token = "0x6000292")]
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

}

