namespace UnityEngine.Timeline;

[ExcludeFromPreset]
[Token(Token = "0x2000030")]
[TrackBindingType(typeof(AudioSource))]
[TrackClipType(typeof(AudioPlayableAsset), False)]
public class AudioTrack : TrackAsset
{
	[CompilerGenerated]
	[Token(Token = "0x2000031")]
	private sealed class <get_outputs>d__4 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000E2")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000E3")]
		private PlayableBinding <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000E4")]
		private int <>l__initialThreadId; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000E5")]
		public AudioTrack <>4__this; //Field offset: 0x40

		[Token(Token = "0x17000094")]
		private override PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current
		{
			[Address(RVA = "0xABEC80", Offset = "0xABE080", Length = "0x13")]
			[DebuggerHidden]
			[Token(Token = "0x60001E2")]
			private get { } //Length: 19
		}

		[Token(Token = "0x17000095")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2F3FD10", Offset = "0x2F3F110", Length = "0x4E")]
			[DebuggerHidden]
			[Token(Token = "0x60001E4")]
			private get { } //Length: 78
		}

		[Address(RVA = "0x2F3F240", Offset = "0x2F3E640", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x60001DF")]
		public <get_outputs>d__4(int <>1__state) { }

		[Address(RVA = "0x2F3F080", Offset = "0x2F3E480", Length = "0x8D")]
		[Token(Token = "0x60001E1")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2F3FC30", Offset = "0x2F3F030", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x60001E5")]
		private override IEnumerator<PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }

		[Address(RVA = "0xABEC80", Offset = "0xABE080", Length = "0x13")]
		[DebuggerHidden]
		[Token(Token = "0x60001E2")]
		private override PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current() { }

		[Address(RVA = "0x2F3FC30", Offset = "0x2F3F030", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x60001E6")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2F3FD10", Offset = "0x2F3F110", Length = "0x4E")]
		[DebuggerHidden]
		[Token(Token = "0x60001E4")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2F3FCD0", Offset = "0x2F3F0D0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60001E3")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60001E0")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x40000E1")]
	private AudioMixerProperties m_TrackProperties; //Field offset: 0xA0

	[Token(Token = "0x17000093")]
	public virtual IEnumerable<PlayableBinding> outputs
	{
		[Address(RVA = "0x2F28BA0", Offset = "0x2F27FA0", Length = "0x71")]
		[IteratorStateMachine(typeof(<get_outputs>d__4))]
		[Token(Token = "0x60001DC")]
		 get { } //Length: 113
	}

	[Address(RVA = "0x2F28B00", Offset = "0x2F27F00", Length = "0x94")]
	[Token(Token = "0x60001DE")]
	public AudioTrack() { }

	[Address(RVA = "0x2F28070", Offset = "0x2F27470", Length = "0x872")]
	[Token(Token = "0x60001DB")]
	internal virtual Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree) { }

	[Address(RVA = "0x2F288F0", Offset = "0x2F27CF0", Length = "0x162")]
	[Token(Token = "0x60001DA")]
	public TimelineClip CreateClip(AudioClip clip) { }

	[Address(RVA = "0x2F28BA0", Offset = "0x2F27FA0", Length = "0x71")]
	[IteratorStateMachine(typeof(<get_outputs>d__4))]
	[Token(Token = "0x60001DC")]
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	[Address(RVA = "0x2F28A60", Offset = "0x2F27E60", Length = "0x93")]
	[Token(Token = "0x60001DD")]
	private void OnValidate() { }

}

