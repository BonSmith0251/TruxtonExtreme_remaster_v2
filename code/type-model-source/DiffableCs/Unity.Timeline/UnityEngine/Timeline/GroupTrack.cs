namespace UnityEngine.Timeline;

[ExcludeFromPreset]
[SupportsChildTracks((Type) null, 2147483647)]
[Token(Token = "0x200004F")]
[TrackClipType(typeof(TrackAsset))]
public class GroupTrack : TrackAsset
{

	[Token(Token = "0x170000C7")]
	public virtual IEnumerable<PlayableBinding> outputs
	{
		[Address(RVA = "0x2F2ECF0", Offset = "0x2F2E0F0", Length = "0x4E")]
		[Token(Token = "0x60002BD")]
		 get { } //Length: 78
	}

	[Address(RVA = "0x2F2ECA0", Offset = "0x2F2E0A0", Length = "0x49")]
	[Token(Token = "0x60002BE")]
	public GroupTrack() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60002BC")]
	internal virtual bool CanCompileClips() { }

	[Address(RVA = "0x2F2ECF0", Offset = "0x2F2E0F0", Length = "0x4E")]
	[Token(Token = "0x60002BD")]
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

}

