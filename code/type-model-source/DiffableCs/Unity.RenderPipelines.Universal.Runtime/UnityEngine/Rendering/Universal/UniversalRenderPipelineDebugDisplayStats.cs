namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x200006F")]
internal class UniversalRenderPipelineDebugDisplayStats : DebugDisplayStats<URPProfileId>
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000228")]
	private DebugFrameTiming m_DebugFrameTiming; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000229")]
	private List<URPProfileId> m_RecordedSamplers; //Field offset: 0x38

	[Address(RVA = "0x2D8A8B0", Offset = "0x2D89CB0", Length = "0xDE")]
	[Token(Token = "0x60002A8")]
	public UniversalRenderPipelineDebugDisplayStats() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60002A9")]
	private bool <RegisterDebugUI>b__4_0() { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60002AA")]
	private void <RegisterDebugUI>b__4_1(bool value) { }

	[Address(RVA = "0x5BB2A0", Offset = "0x5BA6A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60002AB")]
	private bool <RegisterDebugUI>b__4_2() { }

	[Address(RVA = "0x2707C90", Offset = "0x2707090", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60002AC")]
	private void <RegisterDebugUI>b__4_3(bool value) { }

	[Address(RVA = "0x2D8A2F0", Offset = "0x2D896F0", Length = "0x159")]
	[Token(Token = "0x60002A5")]
	public virtual void DisableProfilingRecorders() { }

	[Address(RVA = "0x2D8A450", Offset = "0x2D89850", Length = "0x49")]
	[Token(Token = "0x60002A4")]
	public virtual void EnableProfilingRecorders() { }

	[Address(RVA = "0x2D8A4A0", Offset = "0x2D898A0", Length = "0x3AB")]
	[Token(Token = "0x60002A6")]
	public virtual void RegisterDebugUI(List<Widget> list) { }

	[Address(RVA = "0x2D8A850", Offset = "0x2D89C50", Length = "0x52")]
	[Token(Token = "0x60002A7")]
	public virtual void Update() { }

}

