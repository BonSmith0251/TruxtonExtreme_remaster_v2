namespace Unity.Mathematics;

[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200002D")]
public struct float3 : IEquatable<float3>, IFormattable
{
	[Token(Token = "0x200002E")]
	public sealed class DebuggerProxy
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000BC")]
		public float x; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40000BD")]
		public float y; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40000BE")]
		public float z; //Field offset: 0x18

		[Address(RVA = "0x2ACAF60", Offset = "0x2ACA360", Length = "0x33")]
		[Token(Token = "0x6001256")]
		public DebuggerProxy(float3 v) { }

	}

	[Token(Token = "0x40000BB")]
	public static readonly float3 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000B8")]
	public float x; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000B9")]
	public float y; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40000BA")]
	public float z; //Field offset: 0x8

	[Token(Token = "0x17000470")]
	public float Item
	{
		[Address(RVA = "0x9E1650", Offset = "0x9E0A50", Length = "0x9")]
		[Token(Token = "0x600124D")]
		 get { } //Length: 9
		[Address(RVA = "0x9E29E0", Offset = "0x9E1DE0", Length = "0x9")]
		[Token(Token = "0x600124E")]
		 set { } //Length: 9
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000467")]
	public float2 xx
	{
		[Address(RVA = "0x2ACB360", Offset = "0x2ACA760", Length = "0x10")]
		[Token(Token = "0x600123E")]
		 get { } //Length: 16
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700044C")]
	public float3 xxx
	{
		[Address(RVA = "0x2A8C8E0", Offset = "0x2A8BCE0", Length = "0xE")]
		[Token(Token = "0x600121D")]
		 get { } //Length: 14
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170003FB")]
	public float4 xxxx
	{
		[Address(RVA = "0x2A8C910", Offset = "0x2A8BD10", Length = "0x11")]
		[Token(Token = "0x60011CC")]
		 get { } //Length: 17
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170003FC")]
	public float4 xxxy
	{
		[Address(RVA = "0x2A8C930", Offset = "0x2A8BD30", Length = "0x14")]
		[Token(Token = "0x60011CD")]
		 get { } //Length: 20
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170003FD")]
	public float4 xxxz
	{
		[Address(RVA = "0x2A8C950", Offset = "0x2A8BD50", Length = "0x14")]
		[Token(Token = "0x60011CE")]
		 get { } //Length: 20
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700044D")]
	public float3 xxy
	{
		[Address(RVA = "0x2A8C970", Offset = "0x2A8BD70", Length = "0x11")]
		[Token(Token = "0x600121E")]
		 get { } //Length: 17
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170003FE")]
	public float4 xxyx
	{
		[Address(RVA = "0x2A8C9B0", Offset = "0x2A8BDB0", Length = "0x16")]
		[Token(Token = "0x60011CF")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170003FF")]
	public float4 xxyy
	{
		[Address(RVA = "0x2A8C9D0", Offset = "0x2A8BDD0", Length = "0x14")]
		[Token(Token = "0x60011D0")]
		 get { } //Length: 20
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000400")]
	public float4 xxyz
	{
		[Address(RVA = "0x2A8C9F0", Offset = "0x2A8BDF0", Length = "0x17")]
		[Token(Token = "0x60011D1")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700044E")]
	public float3 xxz
	{
		[Address(RVA = "0x2A8CA10", Offset = "0x2A8BE10", Length = "0x11")]
		[Token(Token = "0x600121F")]
		 get { } //Length: 17
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000401")]
	public float4 xxzx
	{
		[Address(RVA = "0x2A8CA50", Offset = "0x2A8BE50", Length = "0x16")]
		[Token(Token = "0x60011D2")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000402")]
	public float4 xxzy
	{
		[Address(RVA = "0x2A8CA70", Offset = "0x2A8BE70", Length = "0x17")]
		[Token(Token = "0x60011D3")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000403")]
	public float4 xxzz
	{
		[Address(RVA = "0x27FB820", Offset = "0x27FAC20", Length = "0x14")]
		[Token(Token = "0x60011D4")]
		 get { } //Length: 20
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000468")]
	public float2 xy
	{
		[Address(RVA = "0x2ACB370", Offset = "0x2ACA770", Length = "0x12")]
		[Token(Token = "0x600123F")]
		 get { } //Length: 18
		[Address(RVA = "0x2ACB260", Offset = "0x2ACA660", Length = "0x1B")]
		[Token(Token = "0x6001240")]
		 set { } //Length: 27
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700044F")]
	public float3 xyx
	{
		[Address(RVA = "0x2A8CB50", Offset = "0x2A8BF50", Length = "0x13")]
		[Token(Token = "0x6001220")]
		 get { } //Length: 19
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000404")]
	public float4 xyxx
	{
		[Address(RVA = "0x2A8CB90", Offset = "0x2A8BF90", Length = "0x16")]
		[Token(Token = "0x60011D5")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000405")]
	public float4 xyxy
	{
		[Address(RVA = "0x2A8CBB0", Offset = "0x2A8BFB0", Length = "0x19")]
		[Token(Token = "0x60011D6")]
		 get { } //Length: 25
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000406")]
	public float4 xyxz
	{
		[Address(RVA = "0x2A8CBD0", Offset = "0x2A8BFD0", Length = "0x19")]
		[Token(Token = "0x60011D7")]
		 get { } //Length: 25
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000450")]
	public float3 xyy
	{
		[Address(RVA = "0x2A8CBF0", Offset = "0x2A8BFF0", Length = "0x11")]
		[Token(Token = "0x6001221")]
		 get { } //Length: 17
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000407")]
	public float4 xyyx
	{
		[Address(RVA = "0x2A8CC30", Offset = "0x2A8C030", Length = "0x16")]
		[Token(Token = "0x60011D8")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000408")]
	public float4 xyyy
	{
		[Address(RVA = "0x2A8CC50", Offset = "0x2A8C050", Length = "0x14")]
		[Token(Token = "0x60011D9")]
		 get { } //Length: 20
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000409")]
	public float4 xyyz
	{
		[Address(RVA = "0x2A8CC70", Offset = "0x2A8C070", Length = "0x17")]
		[Token(Token = "0x60011DA")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000451")]
	public float3 xyz
	{
		[Address(RVA = "0x2A8CC90", Offset = "0x2A8C090", Length = "0x14")]
		[Token(Token = "0x6001222")]
		 get { } //Length: 20
		[Address(RVA = "0x2A8EFC0", Offset = "0x2A8E3C0", Length = "0x11")]
		[Token(Token = "0x6001223")]
		 set { } //Length: 17
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700040A")]
	public float4 xyzx
	{
		[Address(RVA = "0x2A8CCB0", Offset = "0x2A8C0B0", Length = "0x19")]
		[Token(Token = "0x60011DB")]
		 get { } //Length: 25
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700040B")]
	public float4 xyzy
	{
		[Address(RVA = "0x2A8CCD0", Offset = "0x2A8C0D0", Length = "0x1A")]
		[Token(Token = "0x60011DC")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700040C")]
	public float4 xyzz
	{
		[Address(RVA = "0x2A8CCF0", Offset = "0x2A8C0F0", Length = "0x17")]
		[Token(Token = "0x60011DD")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000469")]
	public float2 xz
	{
		[Address(RVA = "0x2AD1FB0", Offset = "0x2AD13B0", Length = "0x12")]
		[Token(Token = "0x6001241")]
		 get { } //Length: 18
		[Address(RVA = "0x2AD2850", Offset = "0x2AD1C50", Length = "0x1B")]
		[Token(Token = "0x6001242")]
		 set { } //Length: 27
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000452")]
	public float3 xzx
	{
		[Address(RVA = "0x2A8CDD0", Offset = "0x2A8C1D0", Length = "0x13")]
		[Token(Token = "0x6001224")]
		 get { } //Length: 19
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700040D")]
	public float4 xzxx
	{
		[Address(RVA = "0x2A8CE10", Offset = "0x2A8C210", Length = "0x16")]
		[Token(Token = "0x60011DE")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700040E")]
	public float4 xzxy
	{
		[Address(RVA = "0x2A8CE30", Offset = "0x2A8C230", Length = "0x19")]
		[Token(Token = "0x60011DF")]
		 get { } //Length: 25
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700040F")]
	public float4 xzxz
	{
		[Address(RVA = "0x2A8CE50", Offset = "0x2A8C250", Length = "0x19")]
		[Token(Token = "0x60011E0")]
		 get { } //Length: 25
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000453")]
	public float3 xzy
	{
		[Address(RVA = "0x2A8CE70", Offset = "0x2A8C270", Length = "0x14")]
		[Token(Token = "0x6001225")]
		 get { } //Length: 20
		[Address(RVA = "0x2A8F030", Offset = "0x2A8E430", Length = "0x11")]
		[Token(Token = "0x6001226")]
		 set { } //Length: 17
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000410")]
	public float4 xzyx
	{
		[Address(RVA = "0x2A8CEB0", Offset = "0x2A8C2B0", Length = "0x19")]
		[Token(Token = "0x60011E1")]
		 get { } //Length: 25
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000411")]
	public float4 xzyy
	{
		[Address(RVA = "0x2A8CED0", Offset = "0x2A8C2D0", Length = "0x17")]
		[Token(Token = "0x60011E2")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000412")]
	public float4 xzyz
	{
		[Address(RVA = "0x2A8CEF0", Offset = "0x2A8C2F0", Length = "0x1A")]
		[Token(Token = "0x60011E3")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000454")]
	public float3 xzz
	{
		[Address(RVA = "0x2A8CF10", Offset = "0x2A8C310", Length = "0x11")]
		[Token(Token = "0x6001227")]
		 get { } //Length: 17
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000413")]
	public float4 xzzx
	{
		[Address(RVA = "0x2A8CF50", Offset = "0x2A8C350", Length = "0x16")]
		[Token(Token = "0x60011E4")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000414")]
	public float4 xzzy
	{
		[Address(RVA = "0x2A8CF70", Offset = "0x2A8C370", Length = "0x17")]
		[Token(Token = "0x60011E5")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000415")]
	public float4 xzzz
	{
		[Address(RVA = "0x2A8CF90", Offset = "0x2A8C390", Length = "0x14")]
		[Token(Token = "0x60011E6")]
		 get { } //Length: 20
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700046A")]
	public float2 yx
	{
		[Address(RVA = "0x2ACB390", Offset = "0x2ACA790", Length = "0x12")]
		[Token(Token = "0x6001243")]
		 get { } //Length: 18
		[Address(RVA = "0x2ACBB80", Offset = "0x2ACAF80", Length = "0x1B")]
		[Token(Token = "0x6001244")]
		 set { } //Length: 27
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000455")]
	public float3 yxx
	{
		[Address(RVA = "0x2A8D310", Offset = "0x2A8C710", Length = "0x11")]
		[Token(Token = "0x6001228")]
		 get { } //Length: 17
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000416")]
	public float4 yxxx
	{
		[Address(RVA = "0x2A8D350", Offset = "0x2A8C750", Length = "0x14")]
		[Token(Token = "0x60011E7")]
		 get { } //Length: 20
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000417")]
	public float4 yxxy
	{
		[Address(RVA = "0x2A8D370", Offset = "0x2A8C770", Length = "0x17")]
		[Token(Token = "0x60011E8")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000418")]
	public float4 yxxz
	{
		[Address(RVA = "0x2A8D390", Offset = "0x2A8C790", Length = "0x17")]
		[Token(Token = "0x60011E9")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000456")]
	public float3 yxy
	{
		[Address(RVA = "0x2A8D3B0", Offset = "0x2A8C7B0", Length = "0x14")]
		[Token(Token = "0x6001229")]
		 get { } //Length: 20
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000419")]
	public float4 yxyx
	{
		[Address(RVA = "0x2A8D3F0", Offset = "0x2A8C7F0", Length = "0x19")]
		[Token(Token = "0x60011EA")]
		 get { } //Length: 25
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700041A")]
	public float4 yxyy
	{
		[Address(RVA = "0x2A8D410", Offset = "0x2A8C810", Length = "0x17")]
		[Token(Token = "0x60011EB")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700041B")]
	public float4 yxyz
	{
		[Address(RVA = "0x2A8D430", Offset = "0x2A8C830", Length = "0x1A")]
		[Token(Token = "0x60011EC")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000457")]
	public float3 yxz
	{
		[Address(RVA = "0x2A8D450", Offset = "0x2A8C850", Length = "0x14")]
		[Token(Token = "0x600122A")]
		 get { } //Length: 20
		[Address(RVA = "0x2A8F150", Offset = "0x2A8E550", Length = "0x11")]
		[Token(Token = "0x600122B")]
		 set { } //Length: 17
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700041C")]
	public float4 yxzx
	{
		[Address(RVA = "0x2A8D490", Offset = "0x2A8C890", Length = "0x19")]
		[Token(Token = "0x60011ED")]
		 get { } //Length: 25
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700041D")]
	public float4 yxzy
	{
		[Address(RVA = "0x2A8D4B0", Offset = "0x2A8C8B0", Length = "0x1A")]
		[Token(Token = "0x60011EE")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700041E")]
	public float4 yxzz
	{
		[Address(RVA = "0x2A8D4D0", Offset = "0x2A8C8D0", Length = "0x17")]
		[Token(Token = "0x60011EF")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700046B")]
	public float2 yy
	{
		[Address(RVA = "0x2ACB3B0", Offset = "0x2ACA7B0", Length = "0x11")]
		[Token(Token = "0x6001245")]
		 get { } //Length: 17
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000458")]
	public float3 yyx
	{
		[Address(RVA = "0x2A8D590", Offset = "0x2A8C990", Length = "0x11")]
		[Token(Token = "0x600122C")]
		 get { } //Length: 17
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700041F")]
	public float4 yyxx
	{
		[Address(RVA = "0x2A8D5D0", Offset = "0x2A8C9D0", Length = "0x14")]
		[Token(Token = "0x60011F0")]
		 get { } //Length: 20
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000420")]
	public float4 yyxy
	{
		[Address(RVA = "0x2A8D5F0", Offset = "0x2A8C9F0", Length = "0x17")]
		[Token(Token = "0x60011F1")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000421")]
	public float4 yyxz
	{
		[Address(RVA = "0x2A8D610", Offset = "0x2A8CA10", Length = "0x17")]
		[Token(Token = "0x60011F2")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000459")]
	public float3 yyy
	{
		[Address(RVA = "0x2A8D630", Offset = "0x2A8CA30", Length = "0xF")]
		[Token(Token = "0x600122D")]
		 get { } //Length: 15
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000422")]
	public float4 yyyx
	{
		[Address(RVA = "0x2A8D660", Offset = "0x2A8CA60", Length = "0x14")]
		[Token(Token = "0x60011F3")]
		 get { } //Length: 20
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000423")]
	public float4 yyyy
	{
		[Address(RVA = "0x2A8D680", Offset = "0x2A8CA80", Length = "0x12")]
		[Token(Token = "0x60011F4")]
		 get { } //Length: 18
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000424")]
	public float4 yyyz
	{
		[Address(RVA = "0x2A8D6A0", Offset = "0x2A8CAA0", Length = "0x15")]
		[Token(Token = "0x60011F5")]
		 get { } //Length: 21
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700045A")]
	public float3 yyz
	{
		[Address(RVA = "0x2A8D6C0", Offset = "0x2A8CAC0", Length = "0x12")]
		[Token(Token = "0x600122E")]
		 get { } //Length: 18
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000425")]
	public float4 yyzx
	{
		[Address(RVA = "0x2A8D700", Offset = "0x2A8CB00", Length = "0x17")]
		[Token(Token = "0x60011F6")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000426")]
	public float4 yyzy
	{
		[Address(RVA = "0x2A8D720", Offset = "0x2A8CB20", Length = "0x18")]
		[Token(Token = "0x60011F7")]
		 get { } //Length: 24
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000427")]
	public float4 yyzz
	{
		[Address(RVA = "0x2A8D740", Offset = "0x2A8CB40", Length = "0x15")]
		[Token(Token = "0x60011F8")]
		 get { } //Length: 21
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700046C")]
	public float2 yz
	{
		[Address(RVA = "0xAEF320", Offset = "0xAEE720", Length = "0x13")]
		[Token(Token = "0x6001246")]
		 get { } //Length: 19
		[Address(RVA = "0x2AD2870", Offset = "0x2AD1C70", Length = "0x1C")]
		[Token(Token = "0x6001247")]
		 set { } //Length: 28
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700045B")]
	public float3 yzx
	{
		[Address(RVA = "0x2A8D820", Offset = "0x2A8CC20", Length = "0x14")]
		[Token(Token = "0x600122F")]
		 get { } //Length: 20
		[Address(RVA = "0x2A8F1E0", Offset = "0x2A8E5E0", Length = "0x11")]
		[Token(Token = "0x6001230")]
		 set { } //Length: 17
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000428")]
	public float4 yzxx
	{
		[Address(RVA = "0x2A8D860", Offset = "0x2A8CC60", Length = "0x17")]
		[Token(Token = "0x60011F9")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000429")]
	public float4 yzxy
	{
		[Address(RVA = "0x2A8D880", Offset = "0x2A8CC80", Length = "0x1A")]
		[Token(Token = "0x60011FA")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700042A")]
	public float4 yzxz
	{
		[Address(RVA = "0x2A8D8A0", Offset = "0x2A8CCA0", Length = "0x1A")]
		[Token(Token = "0x60011FB")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700045C")]
	public float3 yzy
	{
		[Address(RVA = "0x2A8D8C0", Offset = "0x2A8CCC0", Length = "0x15")]
		[Token(Token = "0x6001231")]
		 get { } //Length: 21
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700042B")]
	public float4 yzyx
	{
		[Address(RVA = "0x2A8D900", Offset = "0x2A8CD00", Length = "0x1A")]
		[Token(Token = "0x60011FC")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700042C")]
	public float4 yzyy
	{
		[Address(RVA = "0x2A8D920", Offset = "0x2A8CD20", Length = "0x18")]
		[Token(Token = "0x60011FD")]
		 get { } //Length: 24
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700042D")]
	public float4 yzyz
	{
		[Address(RVA = "0x2A8D940", Offset = "0x2A8CD40", Length = "0x1B")]
		[Token(Token = "0x60011FE")]
		 get { } //Length: 27
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700045D")]
	public float3 yzz
	{
		[Address(RVA = "0x2A8D960", Offset = "0x2A8CD60", Length = "0x12")]
		[Token(Token = "0x6001232")]
		 get { } //Length: 18
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700042E")]
	public float4 yzzx
	{
		[Address(RVA = "0x2A8D9A0", Offset = "0x2A8CDA0", Length = "0x17")]
		[Token(Token = "0x60011FF")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700042F")]
	public float4 yzzy
	{
		[Address(RVA = "0x2A8D9C0", Offset = "0x2A8CDC0", Length = "0x18")]
		[Token(Token = "0x6001200")]
		 get { } //Length: 24
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000430")]
	public float4 yzzz
	{
		[Address(RVA = "0x2A8D9E0", Offset = "0x2A8CDE0", Length = "0x15")]
		[Token(Token = "0x6001201")]
		 get { } //Length: 21
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700046D")]
	public float2 zx
	{
		[Address(RVA = "0x2AD1FD0", Offset = "0x2AD13D0", Length = "0x12")]
		[Token(Token = "0x6001248")]
		 get { } //Length: 18
		[Address(RVA = "0x2AD2890", Offset = "0x2AD1C90", Length = "0x1B")]
		[Token(Token = "0x6001249")]
		 set { } //Length: 27
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700045E")]
	public float3 zxx
	{
		[Address(RVA = "0x2A8DD40", Offset = "0x2A8D140", Length = "0x11")]
		[Token(Token = "0x6001233")]
		 get { } //Length: 17
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000431")]
	public float4 zxxx
	{
		[Address(RVA = "0x2A8DD80", Offset = "0x2A8D180", Length = "0x14")]
		[Token(Token = "0x6001202")]
		 get { } //Length: 20
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000432")]
	public float4 zxxy
	{
		[Address(RVA = "0x2A8DDA0", Offset = "0x2A8D1A0", Length = "0x17")]
		[Token(Token = "0x6001203")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000433")]
	public float4 zxxz
	{
		[Address(RVA = "0x2A8DDC0", Offset = "0x2A8D1C0", Length = "0x17")]
		[Token(Token = "0x6001204")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700045F")]
	public float3 zxy
	{
		[Address(RVA = "0x2A8DDE0", Offset = "0x2A8D1E0", Length = "0x14")]
		[Token(Token = "0x6001234")]
		 get { } //Length: 20
		[Address(RVA = "0x2A8F300", Offset = "0x2A8E700", Length = "0x11")]
		[Token(Token = "0x6001235")]
		 set { } //Length: 17
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000434")]
	public float4 zxyx
	{
		[Address(RVA = "0x2A8DE20", Offset = "0x2A8D220", Length = "0x19")]
		[Token(Token = "0x6001205")]
		 get { } //Length: 25
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000435")]
	public float4 zxyy
	{
		[Address(RVA = "0x2A8DE40", Offset = "0x2A8D240", Length = "0x17")]
		[Token(Token = "0x6001206")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000436")]
	public float4 zxyz
	{
		[Address(RVA = "0x2A8DE60", Offset = "0x2A8D260", Length = "0x1A")]
		[Token(Token = "0x6001207")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000460")]
	public float3 zxz
	{
		[Address(RVA = "0x2A8DE80", Offset = "0x2A8D280", Length = "0x14")]
		[Token(Token = "0x6001236")]
		 get { } //Length: 20
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000437")]
	public float4 zxzx
	{
		[Address(RVA = "0x2A8DEC0", Offset = "0x2A8D2C0", Length = "0x19")]
		[Token(Token = "0x6001208")]
		 get { } //Length: 25
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000438")]
	public float4 zxzy
	{
		[Address(RVA = "0x2A8DEE0", Offset = "0x2A8D2E0", Length = "0x1A")]
		[Token(Token = "0x6001209")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000439")]
	public float4 zxzz
	{
		[Address(RVA = "0x2A8DF00", Offset = "0x2A8D300", Length = "0x17")]
		[Token(Token = "0x600120A")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700046E")]
	public float2 zy
	{
		[Address(RVA = "0x2AD1FF0", Offset = "0x2AD13F0", Length = "0x13")]
		[Token(Token = "0x600124A")]
		 get { } //Length: 19
		[Address(RVA = "0x2AD28B0", Offset = "0x2AD1CB0", Length = "0x1C")]
		[Token(Token = "0x600124B")]
		 set { } //Length: 28
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000461")]
	public float3 zyx
	{
		[Address(RVA = "0x2A8DFE0", Offset = "0x2A8D3E0", Length = "0x14")]
		[Token(Token = "0x6001237")]
		 get { } //Length: 20
		[Address(RVA = "0x2A8F390", Offset = "0x2A8E790", Length = "0x11")]
		[Token(Token = "0x6001238")]
		 set { } //Length: 17
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700043A")]
	public float4 zyxx
	{
		[Address(RVA = "0x2A8E020", Offset = "0x2A8D420", Length = "0x17")]
		[Token(Token = "0x600120B")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700043B")]
	public float4 zyxy
	{
		[Address(RVA = "0x2A8E040", Offset = "0x2A8D440", Length = "0x1A")]
		[Token(Token = "0x600120C")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700043C")]
	public float4 zyxz
	{
		[Address(RVA = "0x2A8E060", Offset = "0x2A8D460", Length = "0x1A")]
		[Token(Token = "0x600120D")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000462")]
	public float3 zyy
	{
		[Address(RVA = "0x2A8E080", Offset = "0x2A8D480", Length = "0x12")]
		[Token(Token = "0x6001239")]
		 get { } //Length: 18
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700043D")]
	public float4 zyyx
	{
		[Address(RVA = "0x2A8E0C0", Offset = "0x2A8D4C0", Length = "0x17")]
		[Token(Token = "0x600120E")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700043E")]
	public float4 zyyy
	{
		[Address(RVA = "0x2A8E0E0", Offset = "0x2A8D4E0", Length = "0x15")]
		[Token(Token = "0x600120F")]
		 get { } //Length: 21
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700043F")]
	public float4 zyyz
	{
		[Address(RVA = "0x2A8E100", Offset = "0x2A8D500", Length = "0x18")]
		[Token(Token = "0x6001210")]
		 get { } //Length: 24
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000463")]
	public float3 zyz
	{
		[Address(RVA = "0x2A8E120", Offset = "0x2A8D520", Length = "0x15")]
		[Token(Token = "0x600123A")]
		 get { } //Length: 21
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000440")]
	public float4 zyzx
	{
		[Address(RVA = "0x2A8E160", Offset = "0x2A8D560", Length = "0x1A")]
		[Token(Token = "0x6001211")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000441")]
	public float4 zyzy
	{
		[Address(RVA = "0x2A8E180", Offset = "0x2A8D580", Length = "0x1B")]
		[Token(Token = "0x6001212")]
		 get { } //Length: 27
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000442")]
	public float4 zyzz
	{
		[Address(RVA = "0x2A8E1A0", Offset = "0x2A8D5A0", Length = "0x18")]
		[Token(Token = "0x6001213")]
		 get { } //Length: 24
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700046F")]
	public float2 zz
	{
		[Address(RVA = "0x2AD2010", Offset = "0x2AD1410", Length = "0x11")]
		[Token(Token = "0x600124C")]
		 get { } //Length: 17
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000464")]
	public float3 zzx
	{
		[Address(RVA = "0x2A8E280", Offset = "0x2A8D680", Length = "0x11")]
		[Token(Token = "0x600123B")]
		 get { } //Length: 17
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000443")]
	public float4 zzxx
	{
		[Address(RVA = "0x2A8E2C0", Offset = "0x2A8D6C0", Length = "0x14")]
		[Token(Token = "0x6001214")]
		 get { } //Length: 20
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000444")]
	public float4 zzxy
	{
		[Address(RVA = "0x2A8E2E0", Offset = "0x2A8D6E0", Length = "0x17")]
		[Token(Token = "0x6001215")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000445")]
	public float4 zzxz
	{
		[Address(RVA = "0x2A8E300", Offset = "0x2A8D700", Length = "0x17")]
		[Token(Token = "0x6001216")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000465")]
	public float3 zzy
	{
		[Address(RVA = "0x2A8E320", Offset = "0x2A8D720", Length = "0x12")]
		[Token(Token = "0x600123C")]
		 get { } //Length: 18
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000446")]
	public float4 zzyx
	{
		[Address(RVA = "0x2A8E360", Offset = "0x2A8D760", Length = "0x17")]
		[Token(Token = "0x6001217")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000447")]
	public float4 zzyy
	{
		[Address(RVA = "0x2A8E380", Offset = "0x2A8D780", Length = "0x15")]
		[Token(Token = "0x6001218")]
		 get { } //Length: 21
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000448")]
	public float4 zzyz
	{
		[Address(RVA = "0x2A8E3A0", Offset = "0x2A8D7A0", Length = "0x18")]
		[Token(Token = "0x6001219")]
		 get { } //Length: 24
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000466")]
	public float3 zzz
	{
		[Address(RVA = "0x2A8E3C0", Offset = "0x2A8D7C0", Length = "0xF")]
		[Token(Token = "0x600123D")]
		 get { } //Length: 15
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000449")]
	public float4 zzzx
	{
		[Address(RVA = "0x2A8E3F0", Offset = "0x2A8D7F0", Length = "0x14")]
		[Token(Token = "0x600121A")]
		 get { } //Length: 20
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700044A")]
	public float4 zzzy
	{
		[Address(RVA = "0x2A8E410", Offset = "0x2A8D810", Length = "0x15")]
		[Token(Token = "0x600121B")]
		 get { } //Length: 21
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700044B")]
	public float4 zzzz
	{
		[Address(RVA = "0x2A8E430", Offset = "0x2A8D830", Length = "0x12")]
		[Token(Token = "0x600121C")]
		 get { } //Length: 18
	}

	[Address(RVA = "0x1DB7900", Offset = "0x1DB6D00", Length = "0xF")]
	[Token(Token = "0x600118D")]
	public float3(float x, float y, float z) { }

	[Address(RVA = "0x2AD1F60", Offset = "0x2AD1360", Length = "0x20")]
	[Token(Token = "0x600118E")]
	public float3(float x, float2 yz) { }

	[Address(RVA = "0x2AD1E10", Offset = "0x2AD1210", Length = "0x20")]
	[Token(Token = "0x600118F")]
	public float3(float2 xy, float z) { }

	[Address(RVA = "0x2A8EFC0", Offset = "0x2A8E3C0", Length = "0x11")]
	[Token(Token = "0x6001190")]
	public float3(float3 xyz) { }

	[Address(RVA = "0x2AD1F20", Offset = "0x2AD1320", Length = "0xF")]
	[Token(Token = "0x6001191")]
	public float3(float v) { }

	[Address(RVA = "0x2AD1E30", Offset = "0x2AD1230", Length = "0x2D")]
	[Token(Token = "0x6001192")]
	public float3(bool v) { }

	[Address(RVA = "0x2AD1EA0", Offset = "0x2AD12A0", Length = "0x41")]
	[Token(Token = "0x6001193")]
	public float3(bool3 v) { }

	[Address(RVA = "0x2AD1DA0", Offset = "0x2AD11A0", Length = "0x24")]
	[Token(Token = "0x6001194")]
	public float3(int v) { }

	[Address(RVA = "0x2AD1F30", Offset = "0x2AD1330", Length = "0x26")]
	[Token(Token = "0x6001195")]
	public float3(int3 v) { }

	[Address(RVA = "0x2AD1E60", Offset = "0x2AD1260", Length = "0x39")]
	[Token(Token = "0x6001196")]
	public float3(uint v) { }

	[Address(RVA = "0x2AD1DD0", Offset = "0x2AD11D0", Length = "0x3B")]
	[Token(Token = "0x6001197")]
	public float3(uint3 v) { }

	[Address(RVA = "0x2A19010", Offset = "0x2A18410", Length = "0x114")]
	[Token(Token = "0x6001198")]
	public float3(half v) { }

	[Address(RVA = "0x2A18EE0", Offset = "0x2A182E0", Length = "0x130")]
	[Token(Token = "0x6001199")]
	public float3(half3 v) { }

	[Address(RVA = "0x2AD1EF0", Offset = "0x2AD12F0", Length = "0x24")]
	[Token(Token = "0x600119A")]
	public float3(double v) { }

	[Address(RVA = "0x2AD1F80", Offset = "0x2AD1380", Length = "0x29")]
	[Token(Token = "0x600119B")]
	public float3(double3 v) { }

	[Address(RVA = "0x2AD1B50", Offset = "0x2AD0F50", Length = "0x2B")]
	[Token(Token = "0x600124F")]
	public override bool Equals(float3 rhs) { }

	[Address(RVA = "0x2AD1B80", Offset = "0x2AD0F80", Length = "0xAA")]
	[Token(Token = "0x6001250")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x9E1650", Offset = "0x9E0A50", Length = "0x9")]
	[Token(Token = "0x600124D")]
	public float get_Item(int index) { }

	[Address(RVA = "0x2ACB360", Offset = "0x2ACA760", Length = "0x10")]
	[Token(Token = "0x600123E")]
	public float2 get_xx() { }

	[Address(RVA = "0x2A8C8E0", Offset = "0x2A8BCE0", Length = "0xE")]
	[Token(Token = "0x600121D")]
	public float3 get_xxx() { }

	[Address(RVA = "0x2A8C910", Offset = "0x2A8BD10", Length = "0x11")]
	[Token(Token = "0x60011CC")]
	public float4 get_xxxx() { }

	[Address(RVA = "0x2A8C930", Offset = "0x2A8BD30", Length = "0x14")]
	[Token(Token = "0x60011CD")]
	public float4 get_xxxy() { }

	[Address(RVA = "0x2A8C950", Offset = "0x2A8BD50", Length = "0x14")]
	[Token(Token = "0x60011CE")]
	public float4 get_xxxz() { }

	[Address(RVA = "0x2A8C970", Offset = "0x2A8BD70", Length = "0x11")]
	[Token(Token = "0x600121E")]
	public float3 get_xxy() { }

	[Address(RVA = "0x2A8C9B0", Offset = "0x2A8BDB0", Length = "0x16")]
	[Token(Token = "0x60011CF")]
	public float4 get_xxyx() { }

	[Address(RVA = "0x2A8C9D0", Offset = "0x2A8BDD0", Length = "0x14")]
	[Token(Token = "0x60011D0")]
	public float4 get_xxyy() { }

	[Address(RVA = "0x2A8C9F0", Offset = "0x2A8BDF0", Length = "0x17")]
	[Token(Token = "0x60011D1")]
	public float4 get_xxyz() { }

	[Address(RVA = "0x2A8CA10", Offset = "0x2A8BE10", Length = "0x11")]
	[Token(Token = "0x600121F")]
	public float3 get_xxz() { }

	[Address(RVA = "0x2A8CA50", Offset = "0x2A8BE50", Length = "0x16")]
	[Token(Token = "0x60011D2")]
	public float4 get_xxzx() { }

	[Address(RVA = "0x2A8CA70", Offset = "0x2A8BE70", Length = "0x17")]
	[Token(Token = "0x60011D3")]
	public float4 get_xxzy() { }

	[Address(RVA = "0x27FB820", Offset = "0x27FAC20", Length = "0x14")]
	[Token(Token = "0x60011D4")]
	public float4 get_xxzz() { }

	[Address(RVA = "0x2ACB370", Offset = "0x2ACA770", Length = "0x12")]
	[Token(Token = "0x600123F")]
	public float2 get_xy() { }

	[Address(RVA = "0x2A8CB50", Offset = "0x2A8BF50", Length = "0x13")]
	[Token(Token = "0x6001220")]
	public float3 get_xyx() { }

	[Address(RVA = "0x2A8CB90", Offset = "0x2A8BF90", Length = "0x16")]
	[Token(Token = "0x60011D5")]
	public float4 get_xyxx() { }

	[Address(RVA = "0x2A8CBB0", Offset = "0x2A8BFB0", Length = "0x19")]
	[Token(Token = "0x60011D6")]
	public float4 get_xyxy() { }

	[Address(RVA = "0x2A8CBD0", Offset = "0x2A8BFD0", Length = "0x19")]
	[Token(Token = "0x60011D7")]
	public float4 get_xyxz() { }

	[Address(RVA = "0x2A8CBF0", Offset = "0x2A8BFF0", Length = "0x11")]
	[Token(Token = "0x6001221")]
	public float3 get_xyy() { }

	[Address(RVA = "0x2A8CC30", Offset = "0x2A8C030", Length = "0x16")]
	[Token(Token = "0x60011D8")]
	public float4 get_xyyx() { }

	[Address(RVA = "0x2A8CC50", Offset = "0x2A8C050", Length = "0x14")]
	[Token(Token = "0x60011D9")]
	public float4 get_xyyy() { }

	[Address(RVA = "0x2A8CC70", Offset = "0x2A8C070", Length = "0x17")]
	[Token(Token = "0x60011DA")]
	public float4 get_xyyz() { }

	[Address(RVA = "0x2A8CC90", Offset = "0x2A8C090", Length = "0x14")]
	[Token(Token = "0x6001222")]
	public float3 get_xyz() { }

	[Address(RVA = "0x2A8CCB0", Offset = "0x2A8C0B0", Length = "0x19")]
	[Token(Token = "0x60011DB")]
	public float4 get_xyzx() { }

	[Address(RVA = "0x2A8CCD0", Offset = "0x2A8C0D0", Length = "0x1A")]
	[Token(Token = "0x60011DC")]
	public float4 get_xyzy() { }

	[Address(RVA = "0x2A8CCF0", Offset = "0x2A8C0F0", Length = "0x17")]
	[Token(Token = "0x60011DD")]
	public float4 get_xyzz() { }

	[Address(RVA = "0x2AD1FB0", Offset = "0x2AD13B0", Length = "0x12")]
	[Token(Token = "0x6001241")]
	public float2 get_xz() { }

	[Address(RVA = "0x2A8CDD0", Offset = "0x2A8C1D0", Length = "0x13")]
	[Token(Token = "0x6001224")]
	public float3 get_xzx() { }

	[Address(RVA = "0x2A8CE10", Offset = "0x2A8C210", Length = "0x16")]
	[Token(Token = "0x60011DE")]
	public float4 get_xzxx() { }

	[Address(RVA = "0x2A8CE30", Offset = "0x2A8C230", Length = "0x19")]
	[Token(Token = "0x60011DF")]
	public float4 get_xzxy() { }

	[Address(RVA = "0x2A8CE50", Offset = "0x2A8C250", Length = "0x19")]
	[Token(Token = "0x60011E0")]
	public float4 get_xzxz() { }

	[Address(RVA = "0x2A8CE70", Offset = "0x2A8C270", Length = "0x14")]
	[Token(Token = "0x6001225")]
	public float3 get_xzy() { }

	[Address(RVA = "0x2A8CEB0", Offset = "0x2A8C2B0", Length = "0x19")]
	[Token(Token = "0x60011E1")]
	public float4 get_xzyx() { }

	[Address(RVA = "0x2A8CED0", Offset = "0x2A8C2D0", Length = "0x17")]
	[Token(Token = "0x60011E2")]
	public float4 get_xzyy() { }

	[Address(RVA = "0x2A8CEF0", Offset = "0x2A8C2F0", Length = "0x1A")]
	[Token(Token = "0x60011E3")]
	public float4 get_xzyz() { }

	[Address(RVA = "0x2A8CF10", Offset = "0x2A8C310", Length = "0x11")]
	[Token(Token = "0x6001227")]
	public float3 get_xzz() { }

	[Address(RVA = "0x2A8CF50", Offset = "0x2A8C350", Length = "0x16")]
	[Token(Token = "0x60011E4")]
	public float4 get_xzzx() { }

	[Address(RVA = "0x2A8CF70", Offset = "0x2A8C370", Length = "0x17")]
	[Token(Token = "0x60011E5")]
	public float4 get_xzzy() { }

	[Address(RVA = "0x2A8CF90", Offset = "0x2A8C390", Length = "0x14")]
	[Token(Token = "0x60011E6")]
	public float4 get_xzzz() { }

	[Address(RVA = "0x2ACB390", Offset = "0x2ACA790", Length = "0x12")]
	[Token(Token = "0x6001243")]
	public float2 get_yx() { }

	[Address(RVA = "0x2A8D310", Offset = "0x2A8C710", Length = "0x11")]
	[Token(Token = "0x6001228")]
	public float3 get_yxx() { }

	[Address(RVA = "0x2A8D350", Offset = "0x2A8C750", Length = "0x14")]
	[Token(Token = "0x60011E7")]
	public float4 get_yxxx() { }

	[Address(RVA = "0x2A8D370", Offset = "0x2A8C770", Length = "0x17")]
	[Token(Token = "0x60011E8")]
	public float4 get_yxxy() { }

	[Address(RVA = "0x2A8D390", Offset = "0x2A8C790", Length = "0x17")]
	[Token(Token = "0x60011E9")]
	public float4 get_yxxz() { }

	[Address(RVA = "0x2A8D3B0", Offset = "0x2A8C7B0", Length = "0x14")]
	[Token(Token = "0x6001229")]
	public float3 get_yxy() { }

	[Address(RVA = "0x2A8D3F0", Offset = "0x2A8C7F0", Length = "0x19")]
	[Token(Token = "0x60011EA")]
	public float4 get_yxyx() { }

	[Address(RVA = "0x2A8D410", Offset = "0x2A8C810", Length = "0x17")]
	[Token(Token = "0x60011EB")]
	public float4 get_yxyy() { }

	[Address(RVA = "0x2A8D430", Offset = "0x2A8C830", Length = "0x1A")]
	[Token(Token = "0x60011EC")]
	public float4 get_yxyz() { }

	[Address(RVA = "0x2A8D450", Offset = "0x2A8C850", Length = "0x14")]
	[Token(Token = "0x600122A")]
	public float3 get_yxz() { }

	[Address(RVA = "0x2A8D490", Offset = "0x2A8C890", Length = "0x19")]
	[Token(Token = "0x60011ED")]
	public float4 get_yxzx() { }

	[Address(RVA = "0x2A8D4B0", Offset = "0x2A8C8B0", Length = "0x1A")]
	[Token(Token = "0x60011EE")]
	public float4 get_yxzy() { }

	[Address(RVA = "0x2A8D4D0", Offset = "0x2A8C8D0", Length = "0x17")]
	[Token(Token = "0x60011EF")]
	public float4 get_yxzz() { }

	[Address(RVA = "0x2ACB3B0", Offset = "0x2ACA7B0", Length = "0x11")]
	[Token(Token = "0x6001245")]
	public float2 get_yy() { }

	[Address(RVA = "0x2A8D590", Offset = "0x2A8C990", Length = "0x11")]
	[Token(Token = "0x600122C")]
	public float3 get_yyx() { }

	[Address(RVA = "0x2A8D5D0", Offset = "0x2A8C9D0", Length = "0x14")]
	[Token(Token = "0x60011F0")]
	public float4 get_yyxx() { }

	[Address(RVA = "0x2A8D5F0", Offset = "0x2A8C9F0", Length = "0x17")]
	[Token(Token = "0x60011F1")]
	public float4 get_yyxy() { }

	[Address(RVA = "0x2A8D610", Offset = "0x2A8CA10", Length = "0x17")]
	[Token(Token = "0x60011F2")]
	public float4 get_yyxz() { }

	[Address(RVA = "0x2A8D630", Offset = "0x2A8CA30", Length = "0xF")]
	[Token(Token = "0x600122D")]
	public float3 get_yyy() { }

	[Address(RVA = "0x2A8D660", Offset = "0x2A8CA60", Length = "0x14")]
	[Token(Token = "0x60011F3")]
	public float4 get_yyyx() { }

	[Address(RVA = "0x2A8D680", Offset = "0x2A8CA80", Length = "0x12")]
	[Token(Token = "0x60011F4")]
	public float4 get_yyyy() { }

	[Address(RVA = "0x2A8D6A0", Offset = "0x2A8CAA0", Length = "0x15")]
	[Token(Token = "0x60011F5")]
	public float4 get_yyyz() { }

	[Address(RVA = "0x2A8D6C0", Offset = "0x2A8CAC0", Length = "0x12")]
	[Token(Token = "0x600122E")]
	public float3 get_yyz() { }

	[Address(RVA = "0x2A8D700", Offset = "0x2A8CB00", Length = "0x17")]
	[Token(Token = "0x60011F6")]
	public float4 get_yyzx() { }

	[Address(RVA = "0x2A8D720", Offset = "0x2A8CB20", Length = "0x18")]
	[Token(Token = "0x60011F7")]
	public float4 get_yyzy() { }

	[Address(RVA = "0x2A8D740", Offset = "0x2A8CB40", Length = "0x15")]
	[Token(Token = "0x60011F8")]
	public float4 get_yyzz() { }

	[Address(RVA = "0xAEF320", Offset = "0xAEE720", Length = "0x13")]
	[Token(Token = "0x6001246")]
	public float2 get_yz() { }

	[Address(RVA = "0x2A8D820", Offset = "0x2A8CC20", Length = "0x14")]
	[Token(Token = "0x600122F")]
	public float3 get_yzx() { }

	[Address(RVA = "0x2A8D860", Offset = "0x2A8CC60", Length = "0x17")]
	[Token(Token = "0x60011F9")]
	public float4 get_yzxx() { }

	[Address(RVA = "0x2A8D880", Offset = "0x2A8CC80", Length = "0x1A")]
	[Token(Token = "0x60011FA")]
	public float4 get_yzxy() { }

	[Address(RVA = "0x2A8D8A0", Offset = "0x2A8CCA0", Length = "0x1A")]
	[Token(Token = "0x60011FB")]
	public float4 get_yzxz() { }

	[Address(RVA = "0x2A8D8C0", Offset = "0x2A8CCC0", Length = "0x15")]
	[Token(Token = "0x6001231")]
	public float3 get_yzy() { }

	[Address(RVA = "0x2A8D900", Offset = "0x2A8CD00", Length = "0x1A")]
	[Token(Token = "0x60011FC")]
	public float4 get_yzyx() { }

	[Address(RVA = "0x2A8D920", Offset = "0x2A8CD20", Length = "0x18")]
	[Token(Token = "0x60011FD")]
	public float4 get_yzyy() { }

	[Address(RVA = "0x2A8D940", Offset = "0x2A8CD40", Length = "0x1B")]
	[Token(Token = "0x60011FE")]
	public float4 get_yzyz() { }

	[Address(RVA = "0x2A8D960", Offset = "0x2A8CD60", Length = "0x12")]
	[Token(Token = "0x6001232")]
	public float3 get_yzz() { }

	[Address(RVA = "0x2A8D9A0", Offset = "0x2A8CDA0", Length = "0x17")]
	[Token(Token = "0x60011FF")]
	public float4 get_yzzx() { }

	[Address(RVA = "0x2A8D9C0", Offset = "0x2A8CDC0", Length = "0x18")]
	[Token(Token = "0x6001200")]
	public float4 get_yzzy() { }

	[Address(RVA = "0x2A8D9E0", Offset = "0x2A8CDE0", Length = "0x15")]
	[Token(Token = "0x6001201")]
	public float4 get_yzzz() { }

	[Address(RVA = "0x2AD1FD0", Offset = "0x2AD13D0", Length = "0x12")]
	[Token(Token = "0x6001248")]
	public float2 get_zx() { }

	[Address(RVA = "0x2A8DD40", Offset = "0x2A8D140", Length = "0x11")]
	[Token(Token = "0x6001233")]
	public float3 get_zxx() { }

	[Address(RVA = "0x2A8DD80", Offset = "0x2A8D180", Length = "0x14")]
	[Token(Token = "0x6001202")]
	public float4 get_zxxx() { }

	[Address(RVA = "0x2A8DDA0", Offset = "0x2A8D1A0", Length = "0x17")]
	[Token(Token = "0x6001203")]
	public float4 get_zxxy() { }

	[Address(RVA = "0x2A8DDC0", Offset = "0x2A8D1C0", Length = "0x17")]
	[Token(Token = "0x6001204")]
	public float4 get_zxxz() { }

	[Address(RVA = "0x2A8DDE0", Offset = "0x2A8D1E0", Length = "0x14")]
	[Token(Token = "0x6001234")]
	public float3 get_zxy() { }

	[Address(RVA = "0x2A8DE20", Offset = "0x2A8D220", Length = "0x19")]
	[Token(Token = "0x6001205")]
	public float4 get_zxyx() { }

	[Address(RVA = "0x2A8DE40", Offset = "0x2A8D240", Length = "0x17")]
	[Token(Token = "0x6001206")]
	public float4 get_zxyy() { }

	[Address(RVA = "0x2A8DE60", Offset = "0x2A8D260", Length = "0x1A")]
	[Token(Token = "0x6001207")]
	public float4 get_zxyz() { }

	[Address(RVA = "0x2A8DE80", Offset = "0x2A8D280", Length = "0x14")]
	[Token(Token = "0x6001236")]
	public float3 get_zxz() { }

	[Address(RVA = "0x2A8DEC0", Offset = "0x2A8D2C0", Length = "0x19")]
	[Token(Token = "0x6001208")]
	public float4 get_zxzx() { }

	[Address(RVA = "0x2A8DEE0", Offset = "0x2A8D2E0", Length = "0x1A")]
	[Token(Token = "0x6001209")]
	public float4 get_zxzy() { }

	[Address(RVA = "0x2A8DF00", Offset = "0x2A8D300", Length = "0x17")]
	[Token(Token = "0x600120A")]
	public float4 get_zxzz() { }

	[Address(RVA = "0x2AD1FF0", Offset = "0x2AD13F0", Length = "0x13")]
	[Token(Token = "0x600124A")]
	public float2 get_zy() { }

	[Address(RVA = "0x2A8DFE0", Offset = "0x2A8D3E0", Length = "0x14")]
	[Token(Token = "0x6001237")]
	public float3 get_zyx() { }

	[Address(RVA = "0x2A8E020", Offset = "0x2A8D420", Length = "0x17")]
	[Token(Token = "0x600120B")]
	public float4 get_zyxx() { }

	[Address(RVA = "0x2A8E040", Offset = "0x2A8D440", Length = "0x1A")]
	[Token(Token = "0x600120C")]
	public float4 get_zyxy() { }

	[Address(RVA = "0x2A8E060", Offset = "0x2A8D460", Length = "0x1A")]
	[Token(Token = "0x600120D")]
	public float4 get_zyxz() { }

	[Address(RVA = "0x2A8E080", Offset = "0x2A8D480", Length = "0x12")]
	[Token(Token = "0x6001239")]
	public float3 get_zyy() { }

	[Address(RVA = "0x2A8E0C0", Offset = "0x2A8D4C0", Length = "0x17")]
	[Token(Token = "0x600120E")]
	public float4 get_zyyx() { }

	[Address(RVA = "0x2A8E0E0", Offset = "0x2A8D4E0", Length = "0x15")]
	[Token(Token = "0x600120F")]
	public float4 get_zyyy() { }

	[Address(RVA = "0x2A8E100", Offset = "0x2A8D500", Length = "0x18")]
	[Token(Token = "0x6001210")]
	public float4 get_zyyz() { }

	[Address(RVA = "0x2A8E120", Offset = "0x2A8D520", Length = "0x15")]
	[Token(Token = "0x600123A")]
	public float3 get_zyz() { }

	[Address(RVA = "0x2A8E160", Offset = "0x2A8D560", Length = "0x1A")]
	[Token(Token = "0x6001211")]
	public float4 get_zyzx() { }

	[Address(RVA = "0x2A8E180", Offset = "0x2A8D580", Length = "0x1B")]
	[Token(Token = "0x6001212")]
	public float4 get_zyzy() { }

	[Address(RVA = "0x2A8E1A0", Offset = "0x2A8D5A0", Length = "0x18")]
	[Token(Token = "0x6001213")]
	public float4 get_zyzz() { }

	[Address(RVA = "0x2AD2010", Offset = "0x2AD1410", Length = "0x11")]
	[Token(Token = "0x600124C")]
	public float2 get_zz() { }

	[Address(RVA = "0x2A8E280", Offset = "0x2A8D680", Length = "0x11")]
	[Token(Token = "0x600123B")]
	public float3 get_zzx() { }

	[Address(RVA = "0x2A8E2C0", Offset = "0x2A8D6C0", Length = "0x14")]
	[Token(Token = "0x6001214")]
	public float4 get_zzxx() { }

	[Address(RVA = "0x2A8E2E0", Offset = "0x2A8D6E0", Length = "0x17")]
	[Token(Token = "0x6001215")]
	public float4 get_zzxy() { }

	[Address(RVA = "0x2A8E300", Offset = "0x2A8D700", Length = "0x17")]
	[Token(Token = "0x6001216")]
	public float4 get_zzxz() { }

	[Address(RVA = "0x2A8E320", Offset = "0x2A8D720", Length = "0x12")]
	[Token(Token = "0x600123C")]
	public float3 get_zzy() { }

	[Address(RVA = "0x2A8E360", Offset = "0x2A8D760", Length = "0x17")]
	[Token(Token = "0x6001217")]
	public float4 get_zzyx() { }

	[Address(RVA = "0x2A8E380", Offset = "0x2A8D780", Length = "0x15")]
	[Token(Token = "0x6001218")]
	public float4 get_zzyy() { }

	[Address(RVA = "0x2A8E3A0", Offset = "0x2A8D7A0", Length = "0x18")]
	[Token(Token = "0x6001219")]
	public float4 get_zzyz() { }

	[Address(RVA = "0x2A8E3C0", Offset = "0x2A8D7C0", Length = "0xF")]
	[Token(Token = "0x600123D")]
	public float3 get_zzz() { }

	[Address(RVA = "0x2A8E3F0", Offset = "0x2A8D7F0", Length = "0x14")]
	[Token(Token = "0x600121A")]
	public float4 get_zzzx() { }

	[Address(RVA = "0x2A8E410", Offset = "0x2A8D810", Length = "0x15")]
	[Token(Token = "0x600121B")]
	public float4 get_zzzy() { }

	[Address(RVA = "0x2A8E430", Offset = "0x2A8D830", Length = "0x12")]
	[Token(Token = "0x600121C")]
	public float4 get_zzzz() { }

	[Address(RVA = "0x2A3CED0", Offset = "0x2A3C2D0", Length = "0x41")]
	[Token(Token = "0x6001251")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x5AA9D0", Offset = "0x5A9DD0", Length = "0x31")]
	[Token(Token = "0x60011AA")]
	public static float3 op_Addition(float3 lhs, float3 rhs) { }

	[Address(RVA = "0x2AD2030", Offset = "0x2AD1430", Length = "0x26")]
	[Token(Token = "0x60011AB")]
	public static float3 op_Addition(float3 lhs, float rhs) { }

	[Address(RVA = "0x2AD2060", Offset = "0x2AD1460", Length = "0x29")]
	[Token(Token = "0x60011AC")]
	public static float3 op_Addition(float lhs, float3 rhs) { }

	[Address(RVA = "0x2AD2090", Offset = "0x2AD1490", Length = "0x34")]
	[Token(Token = "0x60011B7")]
	public static float3 op_Decrement(float3 val) { }

	[Address(RVA = "0x2AD20D0", Offset = "0x2AD14D0", Length = "0x31")]
	[Token(Token = "0x60011B0")]
	public static float3 op_Division(float3 lhs, float3 rhs) { }

	[Address(RVA = "0x1CFA4E0", Offset = "0x1CF98E0", Length = "0x2C")]
	[Token(Token = "0x60011B1")]
	public static float3 op_Division(float3 lhs, float rhs) { }

	[Address(RVA = "0x2AD2110", Offset = "0x2AD1510", Length = "0x29")]
	[Token(Token = "0x60011B2")]
	public static float3 op_Division(float lhs, float3 rhs) { }

	[Address(RVA = "0x2AD21F0", Offset = "0x2AD15F0", Length = "0x46")]
	[Token(Token = "0x60011C8")]
	public static bool3 op_Equality(float lhs, float3 rhs) { }

	[Address(RVA = "0x2AD21A0", Offset = "0x2AD15A0", Length = "0x4F")]
	[Token(Token = "0x60011C7")]
	public static bool3 op_Equality(float3 lhs, float rhs) { }

	[Address(RVA = "0x2AD2140", Offset = "0x2AD1540", Length = "0x54")]
	[Token(Token = "0x60011C6")]
	public static bool3 op_Equality(float3 lhs, float3 rhs) { }

	[Address(RVA = "0x2A35690", Offset = "0x2A34A90", Length = "0x27")]
	[Token(Token = "0x60011A5")]
	public static float3 op_Explicit(double v) { }

	[Address(RVA = "0x2A35500", Offset = "0x2A34900", Length = "0x38")]
	[Token(Token = "0x60011A6")]
	public static float3 op_Explicit(double3 v) { }

	[Address(RVA = "0x2A359A0", Offset = "0x2A34DA0", Length = "0x4D")]
	[Token(Token = "0x600119E")]
	public static float3 op_Explicit(bool3 v) { }

	[Address(RVA = "0x2A354D0", Offset = "0x2A348D0", Length = "0x30")]
	[Token(Token = "0x600119D")]
	public static float3 op_Explicit(bool v) { }

	[Address(RVA = "0x2AD2350", Offset = "0x2AD1750", Length = "0x2C")]
	[Token(Token = "0x60011BF")]
	public static bool3 op_GreaterThan(float3 lhs, float rhs) { }

	[Address(RVA = "0x2AD22E0", Offset = "0x2AD16E0", Length = "0x31")]
	[Token(Token = "0x60011BE")]
	public static bool3 op_GreaterThan(float3 lhs, float3 rhs) { }

	[Address(RVA = "0x2AD2320", Offset = "0x2AD1720", Length = "0x23")]
	[Token(Token = "0x60011C0")]
	public static bool3 op_GreaterThan(float lhs, float3 rhs) { }

	[Address(RVA = "0x2AD2240", Offset = "0x2AD1640", Length = "0x31")]
	[Token(Token = "0x60011C1")]
	public static bool3 op_GreaterThanOrEqual(float3 lhs, float3 rhs) { }

	[Address(RVA = "0x2AD2280", Offset = "0x2AD1680", Length = "0x2C")]
	[Token(Token = "0x60011C2")]
	public static bool3 op_GreaterThanOrEqual(float3 lhs, float rhs) { }

	[Address(RVA = "0x2AD22B0", Offset = "0x2AD16B0", Length = "0x23")]
	[Token(Token = "0x60011C3")]
	public static bool3 op_GreaterThanOrEqual(float lhs, float3 rhs) { }

	[Address(RVA = "0x2A35880", Offset = "0x2A34C80", Length = "0x5E")]
	[Token(Token = "0x60011A2")]
	public static float3 op_Implicit(uint3 v) { }

	[Address(RVA = "0x2A35540", Offset = "0x2A34940", Length = "0x27")]
	[Token(Token = "0x600119F")]
	public static float3 op_Implicit(int v) { }

	[Address(RVA = "0x2AD2380", Offset = "0x2AD1780", Length = "0x22")]
	[Token(Token = "0x60011A3")]
	public static float3 op_Implicit(half v) { }

	[Address(RVA = "0x2A35910", Offset = "0x2A34D10", Length = "0x3C")]
	[Token(Token = "0x60011A1")]
	public static float3 op_Implicit(uint v) { }

	[Address(RVA = "0x2A35950", Offset = "0x2A34D50", Length = "0x4B")]
	[Token(Token = "0x60011A0")]
	public static float3 op_Implicit(int3 v) { }

	[Address(RVA = "0x2A359F0", Offset = "0x2A34DF0", Length = "0x12")]
	[Token(Token = "0x600119C")]
	public static float3 op_Implicit(float v) { }

	[Address(RVA = "0x2A8CC90", Offset = "0x2A8C090", Length = "0x14")]
	[Token(Token = "0x6001255")]
	public static float3 op_Implicit(Vector3 v) { }

	[Address(RVA = "0x2AD23B0", Offset = "0x2AD17B0", Length = "0x36")]
	[Token(Token = "0x60011A4")]
	public static float3 op_Implicit(half3 v) { }

	[Address(RVA = "0x2A8CC90", Offset = "0x2A8C090", Length = "0x14")]
	[Token(Token = "0x6001254")]
	public static Vector3 op_Implicit(float3 v) { }

	[Address(RVA = "0x2AD23F0", Offset = "0x2AD17F0", Length = "0x34")]
	[Token(Token = "0x60011B6")]
	public static float3 op_Increment(float3 val) { }

	[Address(RVA = "0x2AD24E0", Offset = "0x2AD18E0", Length = "0x4F")]
	[Token(Token = "0x60011CA")]
	public static bool3 op_Inequality(float3 lhs, float rhs) { }

	[Address(RVA = "0x2AD2430", Offset = "0x2AD1830", Length = "0x46")]
	[Token(Token = "0x60011CB")]
	public static bool3 op_Inequality(float lhs, float3 rhs) { }

	[Address(RVA = "0x2AD2480", Offset = "0x2AD1880", Length = "0x54")]
	[Token(Token = "0x60011C9")]
	public static bool3 op_Inequality(float3 lhs, float3 rhs) { }

	[Address(RVA = "0x2AD2630", Offset = "0x2AD1A30", Length = "0x20")]
	[Token(Token = "0x60011B9")]
	public static bool3 op_LessThan(float3 lhs, float rhs) { }

	[Address(RVA = "0x2AD25F0", Offset = "0x2AD19F0", Length = "0x31")]
	[Token(Token = "0x60011B8")]
	public static bool3 op_LessThan(float3 lhs, float3 rhs) { }

	[Address(RVA = "0x2AD25C0", Offset = "0x2AD19C0", Length = "0x2F")]
	[Token(Token = "0x60011BA")]
	public static bool3 op_LessThan(float lhs, float3 rhs) { }

	[Address(RVA = "0x2AD2530", Offset = "0x2AD1930", Length = "0x31")]
	[Token(Token = "0x60011BB")]
	public static bool3 op_LessThanOrEqual(float3 lhs, float3 rhs) { }

	[Address(RVA = "0x2AD25A0", Offset = "0x2AD19A0", Length = "0x20")]
	[Token(Token = "0x60011BC")]
	public static bool3 op_LessThanOrEqual(float3 lhs, float rhs) { }

	[Address(RVA = "0x2AD2570", Offset = "0x2AD1970", Length = "0x2F")]
	[Token(Token = "0x60011BD")]
	public static bool3 op_LessThanOrEqual(float lhs, float3 rhs) { }

	[Address(RVA = "0x2AD2650", Offset = "0x2AD1A50", Length = "0x60")]
	[Token(Token = "0x60011B5")]
	public static float3 op_Modulus(float lhs, float3 rhs) { }

	[Address(RVA = "0x2A39220", Offset = "0x2A38620", Length = "0x65")]
	[Token(Token = "0x60011B3")]
	public static float3 op_Modulus(float3 lhs, float3 rhs) { }

	[Address(RVA = "0x2AD26B0", Offset = "0x2AD1AB0", Length = "0x5F")]
	[Token(Token = "0x60011B4")]
	public static float3 op_Modulus(float3 lhs, float rhs) { }

	[Address(RVA = "0x2AD2710", Offset = "0x2AD1B10", Length = "0x31")]
	[Token(Token = "0x60011A7")]
	public static float3 op_Multiply(float3 lhs, float3 rhs) { }

	[Address(RVA = "0x2AD2750", Offset = "0x2AD1B50", Length = "0x29")]
	[Token(Token = "0x60011A9")]
	public static float3 op_Multiply(float lhs, float3 rhs) { }

	[Address(RVA = "0x2AD2780", Offset = "0x2AD1B80", Length = "0x26")]
	[Token(Token = "0x60011A8")]
	public static float3 op_Multiply(float3 lhs, float rhs) { }

	[Address(RVA = "0x2AD27E0", Offset = "0x2AD1BE0", Length = "0x29")]
	[Token(Token = "0x60011AF")]
	public static float3 op_Subtraction(float lhs, float3 rhs) { }

	[Address(RVA = "0x2AD27B0", Offset = "0x2AD1BB0", Length = "0x2C")]
	[Token(Token = "0x60011AE")]
	public static float3 op_Subtraction(float3 lhs, float rhs) { }

	[Address(RVA = "0x5D2F70", Offset = "0x5D2370", Length = "0x31")]
	[Token(Token = "0x60011AD")]
	public static float3 op_Subtraction(float3 lhs, float3 rhs) { }

	[Address(RVA = "0x2AD2810", Offset = "0x2AD1C10", Length = "0x31")]
	[Token(Token = "0x60011C4")]
	public static float3 op_UnaryNegation(float3 val) { }

	[Address(RVA = "0x2A8CC90", Offset = "0x2A8C090", Length = "0x14")]
	[Token(Token = "0x60011C5")]
	public static float3 op_UnaryPlus(float3 val) { }

	[Address(RVA = "0x9E29E0", Offset = "0x9E1DE0", Length = "0x9")]
	[Token(Token = "0x600124E")]
	public void set_Item(int index, float value) { }

	[Address(RVA = "0x2ACB260", Offset = "0x2ACA660", Length = "0x1B")]
	[Token(Token = "0x6001240")]
	public void set_xy(float2 value) { }

	[Address(RVA = "0x2A8EFC0", Offset = "0x2A8E3C0", Length = "0x11")]
	[Token(Token = "0x6001223")]
	public void set_xyz(float3 value) { }

	[Address(RVA = "0x2AD2850", Offset = "0x2AD1C50", Length = "0x1B")]
	[Token(Token = "0x6001242")]
	public void set_xz(float2 value) { }

	[Address(RVA = "0x2A8F030", Offset = "0x2A8E430", Length = "0x11")]
	[Token(Token = "0x6001226")]
	public void set_xzy(float3 value) { }

	[Address(RVA = "0x2ACBB80", Offset = "0x2ACAF80", Length = "0x1B")]
	[Token(Token = "0x6001244")]
	public void set_yx(float2 value) { }

	[Address(RVA = "0x2A8F150", Offset = "0x2A8E550", Length = "0x11")]
	[Token(Token = "0x600122B")]
	public void set_yxz(float3 value) { }

	[Address(RVA = "0x2AD2870", Offset = "0x2AD1C70", Length = "0x1C")]
	[Token(Token = "0x6001247")]
	public void set_yz(float2 value) { }

	[Address(RVA = "0x2A8F1E0", Offset = "0x2A8E5E0", Length = "0x11")]
	[Token(Token = "0x6001230")]
	public void set_yzx(float3 value) { }

	[Address(RVA = "0x2AD2890", Offset = "0x2AD1C90", Length = "0x1B")]
	[Token(Token = "0x6001249")]
	public void set_zx(float2 value) { }

	[Address(RVA = "0x2A8F300", Offset = "0x2A8E700", Length = "0x11")]
	[Token(Token = "0x6001235")]
	public void set_zxy(float3 value) { }

	[Address(RVA = "0x2AD28B0", Offset = "0x2AD1CB0", Length = "0x1C")]
	[Token(Token = "0x600124B")]
	public void set_zy(float2 value) { }

	[Address(RVA = "0x2A8F390", Offset = "0x2A8E790", Length = "0x11")]
	[Token(Token = "0x6001238")]
	public void set_zyx(float3 value) { }

	[Address(RVA = "0x2AD1C30", Offset = "0x2AD1030", Length = "0xA6")]
	[Token(Token = "0x6001252")]
	public virtual string ToString() { }

	[Address(RVA = "0x2AD1CE0", Offset = "0x2AD10E0", Length = "0xB3")]
	[Token(Token = "0x6001253")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

