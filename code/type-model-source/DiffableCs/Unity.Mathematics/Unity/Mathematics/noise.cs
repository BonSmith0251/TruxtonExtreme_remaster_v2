namespace Unity.Mathematics;

[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200004E")]
public static class noise
{

	[Address(RVA = "0x2B11BA0", Offset = "0x2B10FA0", Length = "0xAAC")]
	[Token(Token = "0x6001E5C")]
	public static float2 cellular(float2 P) { }

	[Address(RVA = "0x2B12650", Offset = "0x2B11A50", Length = "0x2CC8")]
	[Token(Token = "0x6001E5F")]
	public static float2 cellular(float3 P) { }

	[Address(RVA = "0x2B108A0", Offset = "0x2B0FCA0", Length = "0x4F1")]
	[Token(Token = "0x6001E5D")]
	public static float2 cellular2x2(float2 P) { }

	[Address(RVA = "0x2B10DA0", Offset = "0x2B101A0", Length = "0xDF1")]
	[Token(Token = "0x6001E5E")]
	public static float2 cellular2x2x2(float3 P) { }

	[Address(RVA = "0x2B17F80", Offset = "0x2B17380", Length = "0x1267")]
	[Token(Token = "0x6001E62")]
	public static float cnoise(float3 P) { }

	[Address(RVA = "0x2B15320", Offset = "0x2B14720", Length = "0x2C60")]
	[Token(Token = "0x6001E64")]
	public static float cnoise(float4 P) { }

	[Address(RVA = "0x2B191F0", Offset = "0x2B185F0", Length = "0x668")]
	[Token(Token = "0x6001E60")]
	public static float cnoise(float2 P) { }

	[Address(RVA = "0x2B19860", Offset = "0x2B18C60", Length = "0x1B2")]
	[Token(Token = "0x6001E73")]
	private static float4 fade(float4 t) { }

	[Address(RVA = "0x2B19AB0", Offset = "0x2B18EB0", Length = "0xF8")]
	[Token(Token = "0x6001E72")]
	private static float3 fade(float3 t) { }

	[Address(RVA = "0x2B19A20", Offset = "0x2B18E20", Length = "0x86")]
	[Token(Token = "0x6001E71")]
	private static float2 fade(float2 t) { }

	[Address(RVA = "0x2B19BB0", Offset = "0x2B18FB0", Length = "0x26B")]
	[Token(Token = "0x6001E74")]
	private static float4 grad4(float j, float4 ip) { }

	[Address(RVA = "0x2B19E20", Offset = "0x2B19220", Length = "0x7E")]
	[Token(Token = "0x6001E66")]
	private static float mod289(float x) { }

	[Address(RVA = "0x2B19F60", Offset = "0x2B19360", Length = "0x84")]
	[Token(Token = "0x6001E67")]
	private static float2 mod289(float2 x) { }

	[Address(RVA = "0x2B19EA0", Offset = "0x2B192A0", Length = "0xB4")]
	[Token(Token = "0x6001E68")]
	private static float3 mod289(float3 x) { }

	[Address(RVA = "0x2B19FF0", Offset = "0x2B193F0", Length = "0xF4")]
	[Token(Token = "0x6001E69")]
	private static float4 mod289(float4 x) { }

	[Address(RVA = "0x2B1A0F0", Offset = "0x2B194F0", Length = "0xF4")]
	[Token(Token = "0x6001E6B")]
	private static float4 mod7(float4 x) { }

	[Address(RVA = "0x2B1A1F0", Offset = "0x2B195F0", Length = "0xB4")]
	[Token(Token = "0x6001E6A")]
	private static float3 mod7(float3 x) { }

	[Address(RVA = "0x2B1A2B0", Offset = "0x2B196B0", Length = "0xB4")]
	[Token(Token = "0x6001E6E")]
	private static float4 permute(float4 x) { }

	[Address(RVA = "0x2B1A480", Offset = "0x2B19880", Length = "0x92")]
	[Token(Token = "0x6001E6C")]
	private static float permute(float x) { }

	[Address(RVA = "0x2B1A370", Offset = "0x2B19770", Length = "0x106")]
	[Token(Token = "0x6001E6D")]
	private static float3 permute(float3 x) { }

	[Address(RVA = "0x2B1AC10", Offset = "0x2B1A010", Length = "0x2DAC")]
	[Token(Token = "0x6001E65")]
	public static float pnoise(float4 P, float4 rep) { }

	[Address(RVA = "0x2B1D9C0", Offset = "0x2B1CDC0", Length = "0x12EC")]
	[Token(Token = "0x6001E63")]
	public static float pnoise(float3 P, float3 rep) { }

	[Address(RVA = "0x2B1A520", Offset = "0x2B19920", Length = "0x6E9")]
	[Token(Token = "0x6001E61")]
	public static float pnoise(float2 P, float2 rep) { }

	[Address(RVA = "0x2B1ECB0", Offset = "0x2B1E0B0", Length = "0x560")]
	[Token(Token = "0x6001E7A")]
	public static float3 psrdnoise(float2 pos, float2 per, float rot) { }

	[Address(RVA = "0x2B1F210", Offset = "0x2B1E610", Length = "0x36")]
	[Token(Token = "0x6001E7B")]
	public static float3 psrdnoise(float2 pos, float2 per) { }

	[Address(RVA = "0x2B1F260", Offset = "0x2B1E660", Length = "0x3AA")]
	[Token(Token = "0x6001E7C")]
	public static float psrnoise(float2 pos, float2 per, float rot) { }

	[Address(RVA = "0x2B1F250", Offset = "0x2B1E650", Length = "0xB")]
	[Token(Token = "0x6001E7D")]
	public static float psrnoise(float2 pos, float2 per) { }

	[Address(RVA = "0x2B1F610", Offset = "0x2B1EA10", Length = "0x1AC")]
	[Token(Token = "0x6001E75")]
	private static float2 rgrad2(float2 p, float rot) { }

	[Address(RVA = "0x2B22050", Offset = "0x2B21450", Length = "0xF49")]
	[Token(Token = "0x6001E77")]
	public static float snoise(float3 v) { }

	[Address(RVA = "0x2B21B00", Offset = "0x2B20F00", Length = "0x542")]
	[Token(Token = "0x6001E76")]
	public static float snoise(float2 v) { }

	[Address(RVA = "0x2B209A0", Offset = "0x2B1FDA0", Length = "0x115A")]
	[Token(Token = "0x6001E78")]
	public static float snoise(float3 v, out float3 gradient) { }

	[Address(RVA = "0x2B1F7C0", Offset = "0x2B1EBC0", Length = "0x11D5")]
	[Token(Token = "0x6001E79")]
	public static float snoise(float4 v) { }

	[Address(RVA = "0x2B22FA0", Offset = "0x2B223A0", Length = "0x30")]
	[Token(Token = "0x6001E7F")]
	public static float3 srdnoise(float2 pos) { }

	[Address(RVA = "0x2B22FD0", Offset = "0x2B223D0", Length = "0x60B")]
	[Token(Token = "0x6001E7E")]
	public static float3 srdnoise(float2 pos, float rot) { }

	[Address(RVA = "0x2B235F0", Offset = "0x2B229F0", Length = "0x464")]
	[Token(Token = "0x6001E80")]
	public static float srnoise(float2 pos, float rot) { }

	[Address(RVA = "0x2B235E0", Offset = "0x2B229E0", Length = "0xB")]
	[Token(Token = "0x6001E81")]
	public static float srnoise(float2 pos) { }

	[Address(RVA = "0x2B23A60", Offset = "0x2B22E60", Length = "0x86")]
	[Token(Token = "0x6001E70")]
	private static float4 taylorInvSqrt(float4 r) { }

	[Address(RVA = "0x2B23AF0", Offset = "0x2B22EF0", Length = "0x18")]
	[Token(Token = "0x6001E6F")]
	private static float taylorInvSqrt(float r) { }

}

