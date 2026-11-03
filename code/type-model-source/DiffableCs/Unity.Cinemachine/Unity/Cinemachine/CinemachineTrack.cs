namespace Unity.Cinemachine;

[Token(Token = "0x2000192")]
[TrackBindingType(typeof(CinemachineBrain), TrackBindingFlags::None (0))]
[TrackClipType(typeof(CinemachineShot))]
[TrackColor(0.53, 0, 0.08)]
public class CinemachineTrack : TrackAsset
{
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40006AB")]
	[Tooltip("The priority controls the precedence that this track takes over other CinemachineTracks.  Tracks with higher priority will override tracks with lower priority.  If two simultaneous tracks have the same priority, then the more-recently instanced track will take precedence.  Track priority is unrelated to Cinemachine Camera priority.")]
	public int TrackPriority; //Field offset: 0xA0

	[Address(RVA = "0x289EC80", Offset = "0x289E080", Length = "0x49")]
	[Token(Token = "0x6000861")]
	public CinemachineTrack() { }

	[Address(RVA = "0x289EB50", Offset = "0x289DF50", Length = "0x12B")]
	[Token(Token = "0x6000860")]
	public virtual Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount) { }

}

