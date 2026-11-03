namespace Unity.Cinemachine;

[Token(Token = "0x20000F7")]
internal class UpdateTracker
{
	[Token(Token = "0x20000F8")]
	internal enum UpdateClock : int
	{
		Fixed = 1,
		Late = 2,
	}

	[Token(Token = "0x20000F9")]
	private class UpdateStatus
	{
		[Token(Token = "0x4000398")]
		private const int kWindowSize = 30; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000399")]
		private int m_WindowStart; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400039A")]
		private int m_NumWindowLateUpdateMoves; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400039B")]
		private int m_NumWindowFixedUpdateMoves; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400039C")]
		private int m_NumWindows; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400039D")]
		private int m_LastFrameUpdated; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400039E")]
		private Matrix4x4 m_LastPos; //Field offset: 0x24
		[CompilerGenerated]
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x400039F")]
		private UpdateClock <PreferredUpdate>k__BackingField; //Field offset: 0x64

		[Token(Token = "0x170000F9")]
		public private UpdateClock PreferredUpdate
		{
			[Address(RVA = "0x121E530", Offset = "0x121D930", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000497")]
			 get { } //Length: 4
			[Address(RVA = "0x121E600", Offset = "0x121DA00", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000498")]
			private set { } //Length: 4
		}

		[Address(RVA = "0x2868380", Offset = "0x2867780", Length = "0x61")]
		[Token(Token = "0x6000499")]
		public UpdateStatus(int currentFrame, Matrix4x4 pos) { }

		[Address(RVA = "0x121E530", Offset = "0x121D930", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000497")]
		public UpdateClock get_PreferredUpdate() { }

		[Address(RVA = "0x2868250", Offset = "0x2867650", Length = "0x121")]
		[Token(Token = "0x600049A")]
		public void OnUpdate(int currentFrame, UpdateClock currentClock, Matrix4x4 pos) { }

		[Address(RVA = "0x121E600", Offset = "0x121DA00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000498")]
		private void set_PreferredUpdate(UpdateClock value) { }

	}

	[Token(Token = "0x4000392")]
	private static Dictionary<Transform, UpdateStatus> s_UpdateStatus; //Field offset: 0x0
	[Token(Token = "0x4000393")]
	private static List<Transform> s_ToDelete; //Field offset: 0x8
	[Token(Token = "0x4000394")]
	private static object s_LastUpdateContext; //Field offset: 0x10

	[Address(RVA = "0x2868BA0", Offset = "0x2867FA0", Length = "0xE6")]
	[Token(Token = "0x6000496")]
	private static UpdateTracker() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000495")]
	public UpdateTracker() { }

	[Address(RVA = "0x28683F0", Offset = "0x28677F0", Length = "0x96")]
	[Token(Token = "0x6000494")]
	public static void ForgetContext(object context) { }

	[Address(RVA = "0x2868490", Offset = "0x2867890", Length = "0x23A")]
	[Token(Token = "0x6000492")]
	public static UpdateClock GetPreferredUpdate(Transform target) { }

	[Address(RVA = "0x28686D0", Offset = "0x2867AD0", Length = "0x6F")]
	[RuntimeInitializeOnLoadMethod]
	[Token(Token = "0x6000490")]
	private static void InitializeModule() { }

	[Address(RVA = "0x2868740", Offset = "0x2867B40", Length = "0xC5")]
	[Token(Token = "0x6000493")]
	public static void OnUpdate(UpdateClock currentClock, object context) { }

	[Address(RVA = "0x2868810", Offset = "0x2867C10", Length = "0x388")]
	[Token(Token = "0x6000491")]
	private static void UpdateTargets(UpdateClock currentClock) { }

}

