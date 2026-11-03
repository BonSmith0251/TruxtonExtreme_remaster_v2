//Type is in global namespace

[Token(Token = "0x2000004")]
public class SRPFogPass : ScriptableRenderPass
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000007")]
	private SRPFogData _fogData; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000008")]
	private List<Single> _params; //Field offset: 0x68

	[Address(RVA = "0x2228900", Offset = "0x2227D00", Length = "0x39")]
	[Token(Token = "0x6000005")]
	public SRPFogPass(SRPFogData _data) { }

	[Address(RVA = "0x2228550", Offset = "0x2227950", Length = "0x3A7")]
	[Token(Token = "0x6000006")]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

}

