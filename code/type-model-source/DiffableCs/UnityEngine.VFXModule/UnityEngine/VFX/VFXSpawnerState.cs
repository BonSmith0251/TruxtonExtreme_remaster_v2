namespace UnityEngine.VFX;

[NativeType(Header = "Modules/VFX/Public/VFXSpawnerState.h")]
[RequiredByNativeCode]
[Token(Token = "0x200000E")]
public sealed class VFXSpawnerState : IDisposable
{
	[Token(Token = "0x200000F")]
	public static class BindingsMarshaller
	{

		[Address(RVA = "0x60E3A0", Offset = "0x60D7A0", Length = "0x17")]
		[Token(Token = "0x600006C")]
		public static IntPtr ConvertToNative(VFXSpawnerState vfxSpawnerState) { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000022")]
	private IntPtr m_Ptr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000023")]
	private bool m_Owner; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000024")]
	private VFXEventAttribute m_WrapEventAttribute; //Field offset: 0x20

	[Token(Token = "0x17000009")]
	public float deltaTime
	{
		[Address(RVA = "0x34821E0", Offset = "0x34815E0", Length = "0x51")]
		[Token(Token = "0x600005F")]
		 get { } //Length: 81
	}

	[Token(Token = "0x17000007")]
	public VFXSpawnerLoopState loopState
	{
		[Address(RVA = "0x3482280", Offset = "0x3481680", Length = "0x51")]
		[Token(Token = "0x600005B")]
		 get { } //Length: 81
		[Address(RVA = "0x3482570", Offset = "0x3481970", Length = "0x58")]
		[Token(Token = "0x600005C")]
		 set { } //Length: 88
	}

	[Token(Token = "0x17000006")]
	public bool playing
	{
		[Address(RVA = "0x34822E0", Offset = "0x34816E0", Length = "0x57")]
		[Token(Token = "0x6000059")]
		 get { } //Length: 87
		[Address(RVA = "0x34825D0", Offset = "0x34819D0", Length = "0x5B")]
		[Token(Token = "0x600005A")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000008")]
	public float spawnCount
	{
		[Address(RVA = "0x3482380", Offset = "0x3481780", Length = "0x51")]
		[Token(Token = "0x600005D")]
		 get { } //Length: 81
		[Address(RVA = "0x3482680", Offset = "0x3481A80", Length = "0x61")]
		[Token(Token = "0x600005E")]
		 set { } //Length: 97
	}

	[Token(Token = "0x1700000A")]
	public float totalTime
	{
		[Address(RVA = "0x3482420", Offset = "0x3481820", Length = "0x51")]
		[Token(Token = "0x6000060")]
		 get { } //Length: 81
		[Address(RVA = "0x3482740", Offset = "0x3481B40", Length = "0x61")]
		[Token(Token = "0x6000061")]
		 set { } //Length: 97
	}

	[Token(Token = "0x1700000B")]
	public VFXEventAttribute vfxEventAttribute
	{
		[Address(RVA = "0x3482480", Offset = "0x3481880", Length = "0xAE")]
		[Token(Token = "0x6000063")]
		 get { } //Length: 174
	}

	[Address(RVA = "0x3482150", Offset = "0x3481550", Length = "0x4E")]
	[Token(Token = "0x600004E")]
	public VFXSpawnerState() { }

	[Address(RVA = "0x2FCC7B0", Offset = "0x2FCBBB0", Length = "0x38")]
	[Token(Token = "0x600004F")]
	internal VFXSpawnerState(IntPtr ptr, bool owner) { }

	[Address(RVA = "0x3481AE0", Offset = "0x3480EE0", Length = "0x10D")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000051")]
	internal static VFXSpawnerState CreateSpawnerStateWrapper() { }

	[Address(RVA = "0x3481BF0", Offset = "0x3480FF0", Length = "0x9D")]
	[Token(Token = "0x6000057")]
	public override void Dispose() { }

	[Address(RVA = "0x3481C90", Offset = "0x3481090", Length = "0xAC")]
	[Token(Token = "0x6000056")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x34821E0", Offset = "0x34815E0", Length = "0x51")]
	[Token(Token = "0x600005F")]
	public float get_deltaTime() { }

	[Address(RVA = "0x34821A0", Offset = "0x34815A0", Length = "0x33")]
	[Token(Token = "0x6000068")]
	private static float get_deltaTime_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3482280", Offset = "0x3481680", Length = "0x51")]
	[Token(Token = "0x600005B")]
	public VFXSpawnerLoopState get_loopState() { }

	[Address(RVA = "0x3482240", Offset = "0x3481640", Length = "0x33")]
	[Token(Token = "0x6000064")]
	private static VFXSpawnerLoopState get_loopState_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x34822E0", Offset = "0x34816E0", Length = "0x57")]
	[Token(Token = "0x6000059")]
	public bool get_playing() { }

	[Address(RVA = "0x3482380", Offset = "0x3481780", Length = "0x51")]
	[Token(Token = "0x600005D")]
	public float get_spawnCount() { }

	[Address(RVA = "0x3482340", Offset = "0x3481740", Length = "0x33")]
	[Token(Token = "0x6000066")]
	private static float get_spawnCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3482420", Offset = "0x3481820", Length = "0x51")]
	[Token(Token = "0x6000060")]
	public float get_totalTime() { }

	[Address(RVA = "0x34823E0", Offset = "0x34817E0", Length = "0x33")]
	[Token(Token = "0x6000069")]
	private static float get_totalTime_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3482480", Offset = "0x3481880", Length = "0xAE")]
	[Token(Token = "0x6000063")]
	public VFXEventAttribute get_vfxEventAttribute() { }

	[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
	[Token(Token = "0x6000054")]
	internal IntPtr GetPtr() { }

	[Address(RVA = "0x3481D40", Offset = "0x3481140", Length = "0x2A")]
	[Token(Token = "0x6000050")]
	internal static IntPtr Internal_Create() { }

	[Address(RVA = "0x3481D70", Offset = "0x3481170", Length = "0x33")]
	[NativeMethod(IsThreadSafe = True)]
	[Token(Token = "0x6000058")]
	private static void Internal_Destroy(IntPtr ptr) { }

	[Address(RVA = "0x3481DF0", Offset = "0x34811F0", Length = "0xA6")]
	[Token(Token = "0x6000062")]
	internal VFXEventAttribute Internal_GetVFXEventAttribute() { }

	[Address(RVA = "0x3481DB0", Offset = "0x34811B0", Length = "0x33")]
	[Token(Token = "0x600006B")]
	private static IntPtr Internal_GetVFXEventAttribute_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x3481EA0", Offset = "0x34812A0", Length = "0x116")]
	[Token(Token = "0x6000052")]
	private void PrepareWrapper() { }

	[Address(RVA = "0x3481FC0", Offset = "0x34813C0", Length = "0x62")]
	[Token(Token = "0x6000055")]
	private void Release() { }

	[Address(RVA = "0x3482570", Offset = "0x3481970", Length = "0x58")]
	[Token(Token = "0x600005C")]
	public void set_loopState(VFXSpawnerLoopState value) { }

	[Address(RVA = "0x3482530", Offset = "0x3481930", Length = "0x40")]
	[Token(Token = "0x6000065")]
	private static void set_loopState_Injected(IntPtr _unity_self, VFXSpawnerLoopState value) { }

	[Address(RVA = "0x34825D0", Offset = "0x34819D0", Length = "0x5B")]
	[Token(Token = "0x600005A")]
	public void set_playing(bool value) { }

	[Address(RVA = "0x3482680", Offset = "0x3481A80", Length = "0x61")]
	[Token(Token = "0x600005E")]
	public void set_spawnCount(float value) { }

	[Address(RVA = "0x3482630", Offset = "0x3481A30", Length = "0x43")]
	[Token(Token = "0x6000067")]
	private static void set_spawnCount_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x3482740", Offset = "0x3481B40", Length = "0x61")]
	[Token(Token = "0x6000061")]
	public void set_totalTime(float value) { }

	[Address(RVA = "0x34826F0", Offset = "0x3481AF0", Length = "0x43")]
	[Token(Token = "0x600006A")]
	private static void set_totalTime_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x3482030", Offset = "0x3481430", Length = "0x118")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000053")]
	internal void SetWrapValue(IntPtr ptrToSpawnerState, IntPtr ptrToEventAttribute) { }

}

