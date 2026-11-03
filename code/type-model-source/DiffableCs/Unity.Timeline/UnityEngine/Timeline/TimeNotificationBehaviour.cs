namespace UnityEngine.Timeline;

[Token(Token = "0x200005D")]
public class TimeNotificationBehaviour : PlayableBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x200005F")]
	private sealed class <>c
	{
		[Token(Token = "0x400015E")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400015F")]
		public static Comparison<NotificationEntry> <>9__12_0; //Field offset: 0x8

		[Address(RVA = "0x2F4A740", Offset = "0x2F49B40", Length = "0x67")]
		[Token(Token = "0x6000319")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600031A")]
		public <>c() { }

		[Address(RVA = "0x2F4A600", Offset = "0x2F49A00", Length = "0x1B")]
		[Token(Token = "0x600031B")]
		internal int <SortNotifications>b__12_0(NotificationEntry x, NotificationEntry y) { }

	}

	[Token(Token = "0x200005E")]
	private struct NotificationEntry
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400015A")]
		public double time; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400015B")]
		public INotification payload; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400015C")]
		public bool notificationFired; //Field offset: 0x10
		[FieldOffset(Offset = "0x12")]
		[Token(Token = "0x400015D")]
		public NotificationFlags flags; //Field offset: 0x12

		[Token(Token = "0x170000CE")]
		public bool prewarm
		{
			[Address(RVA = "0x2F41240", Offset = "0x2F40640", Length = "0x8")]
			[Token(Token = "0x6000317")]
			 get { } //Length: 8
		}

		[Token(Token = "0x170000CD")]
		public bool triggerInEditor
		{
			[Address(RVA = "0x23DA930", Offset = "0x23D9D30", Length = "0x7")]
			[Token(Token = "0x6000316")]
			 get { } //Length: 7
		}

		[Token(Token = "0x170000CF")]
		public bool triggerOnce
		{
			[Address(RVA = "0x2F41250", Offset = "0x2F40650", Length = "0x8")]
			[Token(Token = "0x6000318")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x2F41240", Offset = "0x2F40640", Length = "0x8")]
		[Token(Token = "0x6000317")]
		public bool get_prewarm() { }

		[Address(RVA = "0x23DA930", Offset = "0x23D9D30", Length = "0x7")]
		[Token(Token = "0x6000316")]
		public bool get_triggerInEditor() { }

		[Address(RVA = "0x2F41250", Offset = "0x2F40650", Length = "0x8")]
		[Token(Token = "0x6000318")]
		public bool get_triggerOnce() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000156")]
	private readonly List<NotificationEntry> m_Notifications; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000157")]
	private double m_PreviousTime; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000158")]
	private bool m_NeedSortNotifications; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000159")]
	private Playable m_TimeSource; //Field offset: 0x28

	[Token(Token = "0x170000CC")]
	public Playable timeSource
	{
		[Address(RVA = "0x1FF5900", Offset = "0x1FF4D00", Length = "0x8")]
		[Token(Token = "0x6000309")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x2F43FA0", Offset = "0x2F433A0", Length = "0x77")]
	[Token(Token = "0x6000315")]
	public TimeNotificationBehaviour() { }

	[Address(RVA = "0x2F42E10", Offset = "0x2F42210", Length = "0x16D")]
	[Token(Token = "0x600030B")]
	public void AddNotification(double time, INotification payload, NotificationFlags flags = 2) { }

	[Address(RVA = "0x2F42F80", Offset = "0x2F42380", Length = "0x74")]
	[Token(Token = "0x6000310")]
	private static bool CanRestoreNotification(NotificationEntry e, FrameData info, double currentTime, double previousTime) { }

	[Address(RVA = "0x2F43000", Offset = "0x2F42400", Length = "0x118")]
	[Token(Token = "0x600030A")]
	public static ScriptPlayable<TimeNotificationBehaviour> Create(PlayableGraph graph, double duration, DirectorWrapMode loopMode) { }

	[Address(RVA = "0x2F43120", Offset = "0x2F42520", Length = "0x223")]
	[Token(Token = "0x600030D")]
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	[Address(RVA = "0x2F43350", Offset = "0x2F42750", Length = "0x1BC")]
	[Token(Token = "0x600030C")]
	public virtual void OnGraphStart(Playable playable) { }

	[Address(RVA = "0x2F43510", Offset = "0x2F42910", Length = "0x4E7")]
	[Token(Token = "0x600030E")]
	public virtual void PrepareFrame(Playable playable, FrameData info) { }

	[Address(RVA = "0x2170560", Offset = "0x216F960", Length = "0x5")]
	[Token(Token = "0x6000314")]
	private static void Restore_internal(ref NotificationEntry e) { }

	[Address(RVA = "0x1FF5900", Offset = "0x1FF4D00", Length = "0x8")]
	[Token(Token = "0x6000309")]
	public void set_timeSource(Playable value) { }

	[Address(RVA = "0x2F43A00", Offset = "0x2F42E00", Length = "0x135")]
	[Token(Token = "0x600030F")]
	private void SortNotifications() { }

	[Address(RVA = "0x2F43B40", Offset = "0x2F42F40", Length = "0xF0")]
	[Token(Token = "0x6000312")]
	private void SyncDurationWithExternalSource(Playable playable) { }

	[Address(RVA = "0x2F43F20", Offset = "0x2F43320", Length = "0x7A")]
	[Token(Token = "0x6000313")]
	private static void Trigger_internal(Playable playable, PlayableOutput output, ref NotificationEntry e) { }

	[Address(RVA = "0x2F43C30", Offset = "0x2F43030", Length = "0x2E4")]
	[Token(Token = "0x6000311")]
	private void TriggerNotificationsInRange(double start, double end, FrameData info, Playable playable, bool checkState) { }

}

