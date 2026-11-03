namespace UnityEngine.TextCore.Text;

[Token(Token = "0x200005C")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
internal static class TextGenerationInfo
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000381")]
	private static int <CurrentGenerationIteration>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000075")]
	public private static int CurrentGenerationIteration
	{
		[Address(RVA = "0x31B5B80", Offset = "0x31B4F80", Length = "0x35")]
		[CompilerGenerated]
		[Token(Token = "0x600028F")]
		 get { } //Length: 53
		[Address(RVA = "0x31B5BC0", Offset = "0x31B4FC0", Length = "0x3A")]
		[CompilerGenerated]
		[Token(Token = "0x6000290")]
		private set { } //Length: 58
	}

	[Address(RVA = "0x31B5A40", Offset = "0x31B4E40", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x6000291")]
	public static IntPtr Create(bool isPermanent) { }

	[Address(RVA = "0x31B5AB0", Offset = "0x31B4EB0", Length = "0x33")]
	[ThreadSafe]
	[Token(Token = "0x6000292")]
	public static void Destroy(IntPtr ptr) { }

	[Address(RVA = "0x31B5A80", Offset = "0x31B4E80", Length = "0x2A")]
	[Token(Token = "0x6000294")]
	private static void DestroyAllTempAllocations() { }

	[Address(RVA = "0x31B5B80", Offset = "0x31B4F80", Length = "0x35")]
	[CompilerGenerated]
	[Token(Token = "0x600028F")]
	public static int get_CurrentGenerationIteration() { }

	[Address(RVA = "0x31B5AF0", Offset = "0x31B4EF0", Length = "0x87")]
	[Token(Token = "0x6000293")]
	public static void OnRepaintEnd() { }

	[Address(RVA = "0x31B5BC0", Offset = "0x31B4FC0", Length = "0x3A")]
	[CompilerGenerated]
	[Token(Token = "0x6000290")]
	private static void set_CurrentGenerationIteration(int value) { }

}

