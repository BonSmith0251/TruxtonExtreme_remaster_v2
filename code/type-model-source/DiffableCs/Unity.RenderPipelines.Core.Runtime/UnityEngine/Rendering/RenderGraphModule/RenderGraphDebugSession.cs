namespace UnityEngine.Rendering.RenderGraphModule;

[Token(Token = "0x200025B")]
internal abstract class RenderGraphDebugSession : IDisposable
{
	[Token(Token = "0x200025C")]
	internal class DebugDataContainer
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000AD0")]
		private readonly Dictionary<String, Dictionary`2<EntityId, DebugData>> m_Container; //Field offset: 0x10

		[Address(RVA = "0x2C70450", Offset = "0x2C6F850", Length = "0x77")]
		[Token(Token = "0x60010E5")]
		public DebugDataContainer() { }

		[Address(RVA = "0x2C6F730", Offset = "0x2C6EB30", Length = "0x1D7")]
		[Token(Token = "0x60010DD")]
		public bool AddExecution(string graphName, EntityId executionId, string executionName) { }

		[Address(RVA = "0x2C6F910", Offset = "0x2C6ED10", Length = "0xD6")]
		[Token(Token = "0x60010DB")]
		public bool AddGraph(string graphName) { }

		[Address(RVA = "0x2C6F9F0", Offset = "0x2C6EDF0", Length = "0x44")]
		[Token(Token = "0x60010E3")]
		public void Clear() { }

		[Address(RVA = "0x2C6FA40", Offset = "0x2C6EE40", Length = "0x181")]
		[Token(Token = "0x60010E2")]
		public void DeleteExecutionIds(string renderGraph, List<EntityId> executionIds) { }

		[Address(RVA = "0x2C6FBD0", Offset = "0x2C6EFD0", Length = "0xD0")]
		[Token(Token = "0x60010E0")]
		public DebugData GetDebugData(string renderGraph, EntityId executionId) { }

		[Address(RVA = "0x2C6FCB0", Offset = "0x2C6F0B0", Length = "0x2F4")]
		[Token(Token = "0x60010DF")]
		public List<DebugExecutionItem> GetExecutions(string graphName) { }

		[Address(RVA = "0x2C6FFB0", Offset = "0x2C6F3B0", Length = "0x8E")]
		[Token(Token = "0x60010DE")]
		public List<String> GetRenderGraphs() { }

		[Address(RVA = "0x2C70040", Offset = "0x2C6F440", Length = "0x2F0")]
		[Token(Token = "0x60010E4")]
		public void Invalidate() { }

		[Address(RVA = "0x2C70340", Offset = "0x2C6F740", Length = "0x53")]
		[Token(Token = "0x60010DC")]
		public bool RemoveGraph(string graphName) { }

		[Address(RVA = "0x2C703A0", Offset = "0x2C6F7A0", Length = "0xA7")]
		[Token(Token = "0x60010E1")]
		public void SetDebugData(string renderGraph, EntityId executionId, DebugData data) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x4000ACB")]
	private static Action onRegisteredGraphsChanged; //Field offset: 0x0
	[CompilerGenerated]
	[Token(Token = "0x4000ACC")]
	private static Action<String, EntityId> onDebugDataUpdated; //Field offset: 0x8
	[Token(Token = "0x4000ACD")]
	private static RenderGraphDebugSession s_CurrentDebugSession; //Field offset: 0x10
	[Token(Token = "0x4000ACE")]
	public static List<String> s_EmptyRegisteredGraphs; //Field offset: 0x18
	[Token(Token = "0x4000ACF")]
	public static List<DebugExecutionItem> s_EmptyExecutions; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000ACA")]
	private readonly DebugDataContainer <debugDataContainer>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1400000E")]
	public static event Action<String, EntityId> onDebugDataUpdated
	{
		[Address(RVA = "0x2C79980", Offset = "0x2C78D80", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x60010CE")]
		 add { } //Length: 261
		[Address(RVA = "0x2C79C40", Offset = "0x2C79040", Length = "0x105")]
		[CompilerGenerated]
		[Token(Token = "0x60010CF")]
		 remove { } //Length: 261
	}

	[Token(Token = "0x1400000D")]
	public static event Action onRegisteredGraphsChanged
	{
		[Address(RVA = "0x2C79A90", Offset = "0x2C78E90", Length = "0xEE")]
		[CompilerGenerated]
		[Token(Token = "0x60010CC")]
		 add { } //Length: 238
		[Address(RVA = "0x2C79D50", Offset = "0x2C79150", Length = "0xEE")]
		[CompilerGenerated]
		[Token(Token = "0x60010CD")]
		 remove { } //Length: 238
	}

	[Token(Token = "0x17000225")]
	public static RenderGraphDebugSession currentDebugSession
	{
		[Address(RVA = "0x2C79B80", Offset = "0x2C78F80", Length = "0x4F")]
		[Token(Token = "0x60010D1")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000223")]
	private DebugDataContainer debugDataContainer
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60010C5")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000224")]
	public static bool hasActiveDebugSession
	{
		[Address(RVA = "0x2C79BD0", Offset = "0x2C78FD0", Length = "0x6E")]
		[Token(Token = "0x60010D0")]
		 get { } //Length: 110
	}

	[Token(Token = "0x17000222")]
	public abstract bool isActive
	{
		[Token(Token = "0x60010C4")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2C79370", Offset = "0x2C78770", Length = "0xEB")]
	[Token(Token = "0x60010DA")]
	private static RenderGraphDebugSession() { }

	[Address(RVA = "0x2C79460", Offset = "0x2C78860", Length = "0x512")]
	[Token(Token = "0x60010C6")]
	protected RenderGraphDebugSession() { }

	[Address(RVA = "0x2C79980", Offset = "0x2C78D80", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x60010CE")]
	public static void add_onDebugDataUpdated(Action<String, EntityId> value) { }

	[Address(RVA = "0x2C79A90", Offset = "0x2C78E90", Length = "0xEE")]
	[CompilerGenerated]
	[Token(Token = "0x60010CC")]
	public static void add_onRegisteredGraphsChanged(Action value) { }

	[Address(RVA = "0x8E6FC0", Offset = "0x8E63C0", Length = "0x84")]
	[Token(Token = "0x60010D2")]
	public static void Create() { }

	[Address(RVA = "0x2C77F50", Offset = "0x2C77350", Length = "0xA6")]
	[Token(Token = "0x60010D8")]
	public static void DeleteExecutionIds(string renderGraph, List<EntityId> executionIds) { }

	[Address(RVA = "0x2C78000", Offset = "0x2C77400", Length = "0x52F")]
	[Token(Token = "0x60010CA")]
	public override void Dispose() { }

	[Address(RVA = "0x2C78530", Offset = "0x2C77930", Length = "0xBF")]
	[Token(Token = "0x60010D3")]
	public static void EndSession() { }

	[Address(RVA = "0x2C79B80", Offset = "0x2C78F80", Length = "0x4F")]
	[Token(Token = "0x60010D1")]
	public static RenderGraphDebugSession get_currentDebugSession() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60010C5")]
	private DebugDataContainer get_debugDataContainer() { }

	[Address(RVA = "0x2C79BD0", Offset = "0x2C78FD0", Length = "0x6E")]
	[Token(Token = "0x60010D0")]
	public static bool get_hasActiveDebugSession() { }

	[Token(Token = "0x60010C4")]
	public abstract bool get_isActive() { }

	[Address(RVA = "0x2C785F0", Offset = "0x2C779F0", Length = "0x12A")]
	[Token(Token = "0x60010D6")]
	public static DebugData GetDebugData(string renderGraph, EntityId executionId) { }

	[Address(RVA = "0x2C78720", Offset = "0x2C77B20", Length = "0xE4")]
	[Token(Token = "0x60010D5")]
	public static List<DebugExecutionItem> GetExecutions(string graphName) { }

	[Address(RVA = "0x2C78810", Offset = "0x2C77C10", Length = "0x170")]
	[Token(Token = "0x60010D4")]
	public static List<String> GetRegisteredGraphs() { }

	[Address(RVA = "0x2C78990", Offset = "0x2C77D90", Length = "0x1D")]
	[Token(Token = "0x60010CB")]
	protected void InvalidateData() { }

	[Address(RVA = "0x2C789B0", Offset = "0x2C77DB0", Length = "0x442")]
	[Token(Token = "0x60010D9")]
	protected void RegisterAllLocallyKnownGraphsAndExecutions() { }

	[Address(RVA = "0x2C78E00", Offset = "0x2C78200", Length = "0x236")]
	[Token(Token = "0x60010C9")]
	protected void RegisterExecution(string graphName, EntityId executionId, string executionName) { }

	[Address(RVA = "0x2C79040", Offset = "0x2C78440", Length = "0x12B")]
	[Token(Token = "0x60010C7")]
	protected void RegisterGraph(string graphName) { }

	[Address(RVA = "0x2C79C40", Offset = "0x2C79040", Length = "0x105")]
	[CompilerGenerated]
	[Token(Token = "0x60010CF")]
	public static void remove_onDebugDataUpdated(Action<String, EntityId> value) { }

	[Address(RVA = "0x2C79D50", Offset = "0x2C79150", Length = "0xEE")]
	[CompilerGenerated]
	[Token(Token = "0x60010CD")]
	public static void remove_onRegisteredGraphsChanged(Action value) { }

	[Address(RVA = "0x2C79170", Offset = "0x2C78570", Length = "0x130")]
	[Token(Token = "0x60010D7")]
	public static void SetDebugData(string renderGraph, EntityId executionId, DebugData data) { }

	[Address(RVA = "0x2C792B0", Offset = "0x2C786B0", Length = "0xB9")]
	[Token(Token = "0x60010C8")]
	protected void UnregisterGraph(string graphName) { }

}

