namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000048")]
public class AdaptiveResolution : AdaptivePerformanceScaler
{
	[Token(Token = "0x4000127")]
	private static int instanceCount; //Field offset: 0x0

	[Address(RVA = "0x2F87890", Offset = "0x2F86C90", Length = "0x6D")]
	[Token(Token = "0x6000225")]
	public AdaptiveResolution() { }

	[Address(RVA = "0x2F95280", Offset = "0x2F94680", Length = "0x90")]
	[Token(Token = "0x600021D")]
	protected virtual void Awake() { }

	[Address(RVA = "0x13B0EC0", Offset = "0x13B02C0", Length = "0x5")]
	[Token(Token = "0x6000221")]
	private bool IsDynamicResolutionSupported() { }

	[Address(RVA = "0x2F95320", Offset = "0x2F94720", Length = "0xBA")]
	[Token(Token = "0x6000223")]
	private void OnDestroy() { }

	[Address(RVA = "0x2F95320", Offset = "0x2F94720", Length = "0xBA")]
	[Token(Token = "0x600021E")]
	protected virtual void OnDisabled() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600021F")]
	protected virtual void OnEnabled() { }

	[Address(RVA = "0x2F953E0", Offset = "0x2F947E0", Length = "0x491")]
	[Token(Token = "0x6000224")]
	protected virtual void OnLevel() { }

	[Address(RVA = "0x2F95880", Offset = "0x2F94C80", Length = "0x101")]
	[Token(Token = "0x6000220")]
	private void OnValidate() { }

	[Address(RVA = "0x2F95990", Offset = "0x2F94D90", Length = "0x9F")]
	[Token(Token = "0x6000222")]
	private void Start() { }

}

