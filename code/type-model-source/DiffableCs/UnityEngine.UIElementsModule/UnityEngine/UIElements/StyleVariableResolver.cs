namespace UnityEngine.UIElements;

[Token(Token = "0x2000497")]
internal class StyleVariableResolver
{
	[Token(Token = "0x2000499")]
	private struct ResolveContext
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000F38")]
		public StyleSheet sheet; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000F39")]
		public StyleValueHandle[] handles; //Field offset: 0x8

	}

	[Token(Token = "0x2000498")]
	private enum Result : int
	{
		Valid = 0,
		Invalid = 1,
		NotFound = 2,
	}

	[Token(Token = "0x4000F2B")]
	internal const int kMaxResolves = 100; //Field offset: 0x0
	[Token(Token = "0x4000F2C")]
	private static StyleSyntaxParser s_SyntaxParser; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000F2D")]
	private StylePropertyValueMatcher m_Matcher; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F2E")]
	private List<StylePropertyValue> m_ResolvedValues; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F2F")]
	private Stack<String> m_ResolvedVarStack; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000F30")]
	private StyleProperty m_Property; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000F31")]
	private Stack<ResolveContext> m_ContextStack; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000F32")]
	private ResolveContext m_CurrentContext; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000F33")]
	private StyleVariableContext <variableContext>k__BackingField; //Field offset: 0x48

	[Token(Token = "0x17000927")]
	private StyleValueHandle[] currentHandles
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x600225D")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000926")]
	private StyleSheet currentSheet
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x600225C")]
		private get { } //Length: 5
	}

	[Token(Token = "0x17000928")]
	public List<StylePropertyValue> resolvedValues
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x600225E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000929")]
	public StyleVariableContext variableContext
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600225F")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6002260")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x3292C50", Offset = "0x3292050", Length = "0x73")]
	[Token(Token = "0x600226C")]
	private static StyleVariableResolver() { }

	[Address(RVA = "0x3292CD0", Offset = "0x32920D0", Length = "0x138")]
	[Token(Token = "0x600226B")]
	public StyleVariableResolver() { }

	[Address(RVA = "0x3291CC0", Offset = "0x32910C0", Length = "0x117")]
	[Token(Token = "0x6002264")]
	public void AddValue(StyleValueHandle handle) { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x600225D")]
	private StyleValueHandle[] get_currentHandles() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x600225C")]
	private StyleSheet get_currentSheet() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x600225E")]
	public List<StylePropertyValue> get_resolvedValues() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600225F")]
	public StyleVariableContext get_variableContext() { }

	[Address(RVA = "0x3291DE0", Offset = "0x32911E0", Length = "0xC1")]
	[Token(Token = "0x6002261")]
	public void Init(StyleProperty property, StyleSheet sheet, StyleValueHandle[] handles) { }

	[Address(RVA = "0x3291EB0", Offset = "0x32912B0", Length = "0xE3")]
	[Token(Token = "0x600226A")]
	private static void ParseVarFunction(StyleSheet sheet, StyleValueHandle[] handles, ref int index, out int argCount, out string variableName) { }

	[Address(RVA = "0x3291FA0", Offset = "0x32913A0", Length = "0x83")]
	[Token(Token = "0x6002263")]
	private void PopContext() { }

	[Address(RVA = "0x3292030", Offset = "0x3291430", Length = "0xAD")]
	[Token(Token = "0x6002262")]
	private void PushContext(StyleSheet sheet, StyleValueHandle[] handles) { }

	[Address(RVA = "0x32920E0", Offset = "0x32914E0", Length = "0x2B3")]
	[Token(Token = "0x6002269")]
	private Result ResolveFallback(ref int index, bool appendValues) { }

	[Address(RVA = "0x32924E0", Offset = "0x32918E0", Length = "0x254")]
	[Token(Token = "0x6002265")]
	public bool ResolveVarFunction(ref int index) { }

	[Address(RVA = "0x32923A0", Offset = "0x32917A0", Length = "0x139")]
	[Token(Token = "0x6002266")]
	private Result ResolveVarFunction(ref int index, int argc, string varName) { }

	[Address(RVA = "0x3292740", Offset = "0x3291B40", Length = "0x37B")]
	[Token(Token = "0x6002268")]
	private Result ResolveVariable(string variableName) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6002260")]
	public void set_variableContext(StyleVariableContext value) { }

	[Address(RVA = "0x3292AC0", Offset = "0x3291EC0", Length = "0x18E")]
	[Token(Token = "0x6002267")]
	public bool ValidateResolvedValues() { }

}

