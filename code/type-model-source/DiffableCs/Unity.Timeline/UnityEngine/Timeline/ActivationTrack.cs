namespace UnityEngine.Timeline;

[ExcludeFromPreset]
[Token(Token = "0x2000006")]
[TrackBindingType(typeof(GameObject))]
[TrackClipType(typeof(ActivationPlayableAsset))]
public class ActivationTrack : TrackAsset
{
	[Token(Token = "0x2000007")]
	internal enum PostPlaybackState : int
	{
		Active = 0,
		Inactive = 1,
		Revert = 2,
		LeaveAsIs = 3,
	}

	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x4000009")]
	private PostPlaybackState m_PostPlaybackState; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400000A")]
	private ActivationMixerPlayable m_ActivationMixer; //Field offset: 0xA8

	[Token(Token = "0x17000003")]
	public PostPlaybackState postPlaybackState
	{
		[Address(RVA = "0x1D59130", Offset = "0x1D58530", Length = "0x7")]
		[Token(Token = "0x600000D")]
		 get { } //Length: 7
		[Address(RVA = "0x2F21D80", Offset = "0x2F21180", Length = "0x1B")]
		[Token(Token = "0x600000E")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x2F21D20", Offset = "0x2F21120", Length = "0x53")]
	[Token(Token = "0x6000013")]
	public ActivationTrack() { }

	[Address(RVA = "0x2F219F0", Offset = "0x2F20DF0", Length = "0x84")]
	[Token(Token = "0x600000C")]
	internal virtual bool CanCompileClips() { }

	[Address(RVA = "0x2F21A80", Offset = "0x2F20E80", Length = "0x154")]
	[Token(Token = "0x600000F")]
	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

	[Address(RVA = "0x2F21BE0", Offset = "0x2F20FE0", Length = "0xC0")]
	[Token(Token = "0x6000011")]
	public virtual void GatherProperties(PlayableDirector director, IPropertyCollector driver) { }

	[Address(RVA = "0x1D59130", Offset = "0x1D58530", Length = "0x7")]
	[Token(Token = "0x600000D")]
	public PostPlaybackState get_postPlaybackState() { }

	[Address(RVA = "0x2F21CB0", Offset = "0x2F210B0", Length = "0x4E")]
	[Token(Token = "0x6000012")]
	protected virtual void OnCreateClip(TimelineClip clip) { }

	[Address(RVA = "0x2F21D80", Offset = "0x2F21180", Length = "0x1B")]
	[Token(Token = "0x600000E")]
	public void set_postPlaybackState(PostPlaybackState value) { }

	[Address(RVA = "0x2F21D00", Offset = "0x2F21100", Length = "0x1B")]
	[Token(Token = "0x6000010")]
	internal void UpdateTrackMode() { }

}

