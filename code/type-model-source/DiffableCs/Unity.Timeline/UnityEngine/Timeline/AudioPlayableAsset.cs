namespace UnityEngine.Timeline;

[Token(Token = "0x200002E")]
public class AudioPlayableAsset : PlayableAsset, ITimelineClipAsset
{
	[CompilerGenerated]
	[Token(Token = "0x200002F")]
	private sealed class <get_outputs>d__16 : IEnumerable<PlayableBinding>, IEnumerable, IEnumerator<PlayableBinding>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000DD")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000DE")]
		private PlayableBinding <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40000DF")]
		private int <>l__initialThreadId; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40000E0")]
		public AudioPlayableAsset <>4__this; //Field offset: 0x40

		[Token(Token = "0x17000091")]
		private override PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.Current
		{
			[Address(RVA = "0xABEC80", Offset = "0xABE080", Length = "0x13")]
			[DebuggerHidden]
			[Token(Token = "0x60001D5")]
			private get { } //Length: 19
		}

		[Token(Token = "0x17000092")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x2F3F1F0", Offset = "0x2F3E5F0", Length = "0x4E")]
			[DebuggerHidden]
			[Token(Token = "0x60001D7")]
			private get { } //Length: 78
		}

		[Address(RVA = "0x2F3F240", Offset = "0x2F3E640", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x60001D2")]
		public <get_outputs>d__16(int <>1__state) { }

		[Address(RVA = "0x2F3F080", Offset = "0x2F3E480", Length = "0x8D")]
		[Token(Token = "0x60001D4")]
		private override bool MoveNext() { }

		[Address(RVA = "0x2F3F110", Offset = "0x2F3E510", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x60001D8")]
		private override IEnumerator<PlayableBinding> System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding>.GetEnumerator() { }

		[Address(RVA = "0xABEC80", Offset = "0xABE080", Length = "0x13")]
		[DebuggerHidden]
		[Token(Token = "0x60001D5")]
		private override PlayableBinding System.Collections.Generic.IEnumerator<UnityEngine.Playables.PlayableBinding>.get_Current() { }

		[Address(RVA = "0x2F3F110", Offset = "0x2F3E510", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x60001D9")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x2F3F1F0", Offset = "0x2F3E5F0", Length = "0x4E")]
		[DebuggerHidden]
		[Token(Token = "0x60001D7")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x2F3F1B0", Offset = "0x2F3E5B0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x60001D6")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x60001D3")]
		private override void System.IDisposable.Dispose() { }

	}

	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40000D9")]
	private AudioClip m_Clip; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40000DA")]
	private bool m_Loop; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40000DB")]
	private float m_bufferingTime; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40000DC")]
	private AudioClipProperties m_ClipProperties; //Field offset: 0x28

	[Token(Token = "0x1700008B")]
	internal float bufferingTime
	{
		[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
		[Token(Token = "0x60001C7")]
		internal get { } //Length: 6
		[Address(RVA = "0x1C1AA50", Offset = "0x1C19E50", Length = "0x6")]
		[Token(Token = "0x60001C8")]
		internal set { } //Length: 6
	}

	[Token(Token = "0x1700008C")]
	public AudioClip clip
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60001C9")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x60001CA")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000090")]
	public override ClipCaps clipCaps
	{
		[Address(RVA = "0x2F27F20", Offset = "0x2F27320", Length = "0xE")]
		[Token(Token = "0x60001D0")]
		 get { } //Length: 14
	}

	[Token(Token = "0x1700008E")]
	public virtual double duration
	{
		[Address(RVA = "0x2F27F30", Offset = "0x2F27330", Length = "0xB4")]
		[Token(Token = "0x60001CD")]
		 get { } //Length: 180
	}

	[Token(Token = "0x1700008D")]
	public bool loop
	{
		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x60001CB")]
		 get { } //Length: 5
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[Token(Token = "0x60001CC")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700008F")]
	public virtual IEnumerable<PlayableBinding> outputs
	{
		[Address(RVA = "0x2F27FF0", Offset = "0x2F273F0", Length = "0x71")]
		[IteratorStateMachine(typeof(<get_outputs>d__16))]
		[Token(Token = "0x60001CE")]
		 get { } //Length: 113
	}

	[Address(RVA = "0x2F27EA0", Offset = "0x2F272A0", Length = "0x74")]
	[Token(Token = "0x60001D1")]
	public AudioPlayableAsset() { }

	[Address(RVA = "0x2F27D10", Offset = "0x2F27110", Length = "0x187")]
	[Token(Token = "0x60001CF")]
	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject go) { }

	[Address(RVA = "0x1C1AA40", Offset = "0x1C19E40", Length = "0x6")]
	[Token(Token = "0x60001C7")]
	internal float get_bufferingTime() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60001C9")]
	public AudioClip get_clip() { }

	[Address(RVA = "0x2F27F20", Offset = "0x2F27320", Length = "0xE")]
	[Token(Token = "0x60001D0")]
	public override ClipCaps get_clipCaps() { }

	[Address(RVA = "0x2F27F30", Offset = "0x2F27330", Length = "0xB4")]
	[Token(Token = "0x60001CD")]
	public virtual double get_duration() { }

	[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
	[Token(Token = "0x60001CB")]
	public bool get_loop() { }

	[Address(RVA = "0x2F27FF0", Offset = "0x2F273F0", Length = "0x71")]
	[IteratorStateMachine(typeof(<get_outputs>d__16))]
	[Token(Token = "0x60001CE")]
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	[Address(RVA = "0x1C1AA50", Offset = "0x1C19E50", Length = "0x6")]
	[Token(Token = "0x60001C8")]
	internal void set_bufferingTime(float value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x60001CA")]
	public void set_clip(AudioClip value) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[Token(Token = "0x60001CC")]
	public void set_loop(bool value) { }

}

