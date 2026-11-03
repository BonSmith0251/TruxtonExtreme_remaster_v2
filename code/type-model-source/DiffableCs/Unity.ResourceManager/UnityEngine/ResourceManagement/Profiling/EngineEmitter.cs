namespace UnityEngine.ResourceManagement.Profiling;

[Token(Token = "0x2000071")]
public class EngineEmitter : IProfilerEmitter
{

	[Token(Token = "0x1700007A")]
	public override bool IsEnabled
	{
		[Address(RVA = "0x2E3EC30", Offset = "0x2E3E030", Length = "0x7")]
		[Token(Token = "0x600028E")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000291")]
	public EngineEmitter() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600028F")]
	public override void EmitFrameMetaData(Guid id, int tag, Array data) { }

	[Address(RVA = "0x2E3EC30", Offset = "0x2E3E030", Length = "0x7")]
	[Token(Token = "0x600028E")]
	public override bool get_IsEnabled() { }

	[Address(RVA = "0x2E3EB40", Offset = "0x2E3DF40", Length = "0xE6")]
	[Token(Token = "0x6000290")]
	public override void InitialiseCallbacks(Action<Single> d) { }

}

