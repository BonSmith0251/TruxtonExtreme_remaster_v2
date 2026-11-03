namespace UnityEngine.ResourceManagement.Util;

[Token(Token = "0x200002C")]
internal class DelayedActionManager : ComponentSingleton<DelayedActionManager>
{
	[Token(Token = "0x200002D")]
	private struct DelegateInfo
	{
		[Token(Token = "0x4000084")]
		private static int s_Id; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000085")]
		private int m_Id; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000086")]
		private Delegate m_Delegate; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000087")]
		private Object[] m_Target; //Field offset: 0x10
		[CompilerGenerated]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000088")]
		private float <InvocationTime>k__BackingField; //Field offset: 0x18

		[Token(Token = "0x17000025")]
		public private float InvocationTime
		{
			[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000126")]
			 get { } //Length: 6
			[Address(RVA = "0x1412590", Offset = "0x1411990", Length = "0x6")]
			[CompilerGenerated]
			[Token(Token = "0x6000127")]
			private set { } //Length: 6
		}

		[Address(RVA = "0x2E3E960", Offset = "0x2E3DD60", Length = "0x90")]
		[Token(Token = "0x6000125")]
		public DelegateInfo(Delegate d, float invocationTime, Object[] p) { }

		[Address(RVA = "0xABF7A0", Offset = "0xABEBA0", Length = "0x6")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000126")]
		public float get_InvocationTime() { }

		[Address(RVA = "0x2E3E430", Offset = "0x2E3D830", Length = "0x166")]
		[Token(Token = "0x6000129")]
		public void Invoke() { }

		[Address(RVA = "0x1412590", Offset = "0x1411990", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000127")]
		private void set_InvocationTime(float value) { }

		[Address(RVA = "0x2E3E5A0", Offset = "0x2E3D9A0", Length = "0x3B6")]
		[Token(Token = "0x6000128")]
		public virtual string ToString() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400007F")]
	private List<DelegateInfo>[] m_Actions; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000080")]
	private LinkedList<DelegateInfo> m_DelayedActions; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000081")]
	private Stack<LinkedListNode`1<DelegateInfo>> m_NodeCache; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000082")]
	private int m_CollectionIndex; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000083")]
	private bool m_DestroyOnCompletion; //Field offset: 0x3C

	[Token(Token = "0x17000024")]
	public static bool IsActive
	{
		[Address(RVA = "0x2E3E2F0", Offset = "0x2E3D6F0", Length = "0x13E")]
		[Token(Token = "0x600011F")]
		 get { } //Length: 318
	}

	[Address(RVA = "0x2E3E0E0", Offset = "0x2E3D4E0", Length = "0x203")]
	[Token(Token = "0x6000124")]
	public DelayedActionManager() { }

	[Address(RVA = "0x2E3D910", Offset = "0x2E3CD10", Length = "0x74")]
	[Token(Token = "0x600011D")]
	public static void AddAction(Delegate action, float delay = 0, Object[] parameters) { }

	[Address(RVA = "0x2E3D630", Offset = "0x2E3CA30", Length = "0x2D0")]
	[Token(Token = "0x600011E")]
	private void AddActionInternal(Delegate action, float delay, Object[] parameters) { }

	[Address(RVA = "0x2E3D990", Offset = "0x2E3CD90", Length = "0x5B")]
	[Token(Token = "0x600011B")]
	public static void Clear() { }

	[Address(RVA = "0x2E3D9F0", Offset = "0x2E3CDF0", Length = "0x5")]
	[Token(Token = "0x600011C")]
	private void DestroyWhenComplete() { }

	[Address(RVA = "0x2E3E2F0", Offset = "0x2E3D6F0", Length = "0x13E")]
	[Token(Token = "0x600011F")]
	public static bool get_IsActive() { }

	[Address(RVA = "0x2E3DA00", Offset = "0x2E3CE00", Length = "0x10E")]
	[Token(Token = "0x600011A")]
	private LinkedListNode<DelegateInfo> GetNode(ref DelegateInfo del) { }

	[Address(RVA = "0x2E3DB10", Offset = "0x2E3CF10", Length = "0x355")]
	[Token(Token = "0x6000122")]
	private void InternalLateUpdate(float t) { }

	[Address(RVA = "0x2E3DE70", Offset = "0x2E3D270", Length = "0x23")]
	[Token(Token = "0x6000121")]
	private void LateUpdate() { }

	[Address(RVA = "0x2E3DEA0", Offset = "0x2E3D2A0", Length = "0xA2")]
	[Token(Token = "0x6000123")]
	private void OnApplicationQuit() { }

	[Address(RVA = "0x2E3DF50", Offset = "0x2E3D350", Length = "0x182")]
	[Token(Token = "0x6000120")]
	public static bool Wait(float timeout = 0, float timeAdvanceAmount = 0) { }

}

