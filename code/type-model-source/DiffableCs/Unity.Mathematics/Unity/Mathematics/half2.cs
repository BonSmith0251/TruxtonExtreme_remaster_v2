namespace Unity.Mathematics;

[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x2000038")]
public struct half2 : IEquatable<half2>, IFormattable
{
	[Token(Token = "0x2000039")]
	public sealed class DebuggerProxy
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000E7")]
		public half x; //Field offset: 0x10
		[FieldOffset(Offset = "0x12")]
		[Token(Token = "0x40000E8")]
		public half y; //Field offset: 0x12

		[Address(RVA = "0x2AF00D0", Offset = "0x2AEF4D0", Length = "0x32")]
		[Token(Token = "0x6001631")]
		public DebuggerProxy(half2 v) { }

	}

	[Token(Token = "0x40000E6")]
	public static readonly half2 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000E4")]
	public half x; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x40000E5")]
	public half y; //Field offset: 0x2

	[Token(Token = "0x170005E8")]
	public half Item
	{
		[Address(RVA = "0x9E0BA0", Offset = "0x9DFFA0", Length = "0x8")]
		[Token(Token = "0x600162A")]
		 get { } //Length: 8
		[Address(RVA = "0x9E1F30", Offset = "0x9E1330", Length = "0x9")]
		[Token(Token = "0x600162B")]
		 set { } //Length: 9
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005E4")]
	public half2 xx
	{
		[Address(RVA = "0x2AF0510", Offset = "0x2AEF910", Length = "0x12")]
		[Token(Token = "0x6001624")]
		 get { } //Length: 18
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005DC")]
	public half3 xxx
	{
		[Address(RVA = "0x2AF0530", Offset = "0x2AEF930", Length = "0x12")]
		[Token(Token = "0x600161C")]
		 get { } //Length: 18
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005CC")]
	public half4 xxxx
	{
		[Address(RVA = "0x2AF0550", Offset = "0x2AEF950", Length = "0x1D")]
		[Token(Token = "0x600160C")]
		 get { } //Length: 29
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005CD")]
	public half4 xxxy
	{
		[Address(RVA = "0x2AF0570", Offset = "0x2AEF970", Length = "0x21")]
		[Token(Token = "0x600160D")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005DD")]
	public half3 xxy
	{
		[Address(RVA = "0x2AF05A0", Offset = "0x2AEF9A0", Length = "0x16")]
		[Token(Token = "0x600161D")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005CE")]
	public half4 xxyx
	{
		[Address(RVA = "0x2AF05C0", Offset = "0x2AEF9C0", Length = "0x24")]
		[Token(Token = "0x600160E")]
		 get { } //Length: 36
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005CF")]
	public half4 xxyy
	{
		[Address(RVA = "0x2AF05F0", Offset = "0x2AEF9F0", Length = "0x21")]
		[Token(Token = "0x600160F")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005E5")]
	public half2 xy
	{
		[Address(RVA = "0x2AF0620", Offset = "0x2AEFA20", Length = "0x16")]
		[Token(Token = "0x6001625")]
		 get { } //Length: 22
		[Address(RVA = "0x2AF04B0", Offset = "0x2AEF8B0", Length = "0xB")]
		[Token(Token = "0x6001626")]
		 set { } //Length: 11
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005DE")]
	public half3 xyx
	{
		[Address(RVA = "0x2AF0640", Offset = "0x2AEFA40", Length = "0x19")]
		[Token(Token = "0x600161E")]
		 get { } //Length: 25
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005D0")]
	public half4 xyxx
	{
		[Address(RVA = "0x2AF0660", Offset = "0x2AEFA60", Length = "0x24")]
		[Token(Token = "0x6001610")]
		 get { } //Length: 36
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005D1")]
	public half4 xyxy
	{
		[Address(RVA = "0x2AF0690", Offset = "0x2AEFA90", Length = "0x28")]
		[Token(Token = "0x6001611")]
		 get { } //Length: 40
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005DF")]
	public half3 xyy
	{
		[Address(RVA = "0x2AF06C0", Offset = "0x2AEFAC0", Length = "0x16")]
		[Token(Token = "0x600161F")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005D2")]
	public half4 xyyx
	{
		[Address(RVA = "0x2AF06E0", Offset = "0x2AEFAE0", Length = "0x24")]
		[Token(Token = "0x6001612")]
		 get { } //Length: 36
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005D3")]
	public half4 xyyy
	{
		[Address(RVA = "0x2AF0710", Offset = "0x2AEFB10", Length = "0x21")]
		[Token(Token = "0x6001613")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005E6")]
	public half2 yx
	{
		[Address(RVA = "0x2AF0740", Offset = "0x2AEFB40", Length = "0x16")]
		[Token(Token = "0x6001627")]
		 get { } //Length: 22
		[Address(RVA = "0x2AF0A30", Offset = "0x2AEFE30", Length = "0xB")]
		[Token(Token = "0x6001628")]
		 set { } //Length: 11
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005E0")]
	public half3 yxx
	{
		[Address(RVA = "0x2AF0760", Offset = "0x2AEFB60", Length = "0x16")]
		[Token(Token = "0x6001620")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005D4")]
	public half4 yxxx
	{
		[Address(RVA = "0x2AF0780", Offset = "0x2AEFB80", Length = "0x21")]
		[Token(Token = "0x6001614")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005D5")]
	public half4 yxxy
	{
		[Address(RVA = "0x2AF07B0", Offset = "0x2AEFBB0", Length = "0x25")]
		[Token(Token = "0x6001615")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005E1")]
	public half3 yxy
	{
		[Address(RVA = "0x2AF07E0", Offset = "0x2AEFBE0", Length = "0x1A")]
		[Token(Token = "0x6001621")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005D6")]
	public half4 yxyx
	{
		[Address(RVA = "0x2AF0800", Offset = "0x2AEFC00", Length = "0x28")]
		[Token(Token = "0x6001616")]
		 get { } //Length: 40
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005D7")]
	public half4 yxyy
	{
		[Address(RVA = "0x2AF0830", Offset = "0x2AEFC30", Length = "0x25")]
		[Token(Token = "0x6001617")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005E7")]
	public half2 yy
	{
		[Address(RVA = "0x2AF0860", Offset = "0x2AEFC60", Length = "0x13")]
		[Token(Token = "0x6001629")]
		 get { } //Length: 19
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005E2")]
	public half3 yyx
	{
		[Address(RVA = "0x2AF0880", Offset = "0x2AEFC80", Length = "0x16")]
		[Token(Token = "0x6001622")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005D8")]
	public half4 yyxx
	{
		[Address(RVA = "0x2AF08A0", Offset = "0x2AEFCA0", Length = "0x21")]
		[Token(Token = "0x6001618")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005D9")]
	public half4 yyxy
	{
		[Address(RVA = "0x2AF08D0", Offset = "0x2AEFCD0", Length = "0x25")]
		[Token(Token = "0x6001619")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005E3")]
	public half3 yyy
	{
		[Address(RVA = "0x2AF0900", Offset = "0x2AEFD00", Length = "0x13")]
		[Token(Token = "0x6001623")]
		 get { } //Length: 19
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005DA")]
	public half4 yyyx
	{
		[Address(RVA = "0x2AF0920", Offset = "0x2AEFD20", Length = "0x21")]
		[Token(Token = "0x600161A")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005DB")]
	public half4 yyyy
	{
		[Address(RVA = "0x2AF0950", Offset = "0x2AEFD50", Length = "0x1E")]
		[Token(Token = "0x600161B")]
		 get { } //Length: 30
	}

	[Address(RVA = "0x1F77C20", Offset = "0x1F77020", Length = "0x9")]
	[Token(Token = "0x60015FA")]
	public half2(half x, half y) { }

	[Address(RVA = "0x2AF04B0", Offset = "0x2AEF8B0", Length = "0xB")]
	[Token(Token = "0x60015FB")]
	public half2(half2 xy) { }

	[Address(RVA = "0x2AF0460", Offset = "0x2AEF860", Length = "0x8")]
	[Token(Token = "0x60015FC")]
	public half2(half v) { }

	[Address(RVA = "0x2AF0420", Offset = "0x2AEF820", Length = "0x37")]
	[Token(Token = "0x60015FD")]
	public half2(float v) { }

	[Address(RVA = "0x2AF0470", Offset = "0x2AEF870", Length = "0x35")]
	[Token(Token = "0x60015FE")]
	public half2(float2 v) { }

	[Address(RVA = "0x2AF03E0", Offset = "0x2AEF7E0", Length = "0x3F")]
	[Token(Token = "0x60015FF")]
	public half2(double v) { }

	[Address(RVA = "0x2AF04C0", Offset = "0x2AEF8C0", Length = "0x41")]
	[Token(Token = "0x6001600")]
	public half2(double2 v) { }

	[Address(RVA = "0x2AF01A0", Offset = "0x2AEF5A0", Length = "0x89")]
	[Token(Token = "0x600162D")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2AF0230", Offset = "0x2AEF630", Length = "0x13")]
	[Token(Token = "0x600162C")]
	public override bool Equals(half2 rhs) { }

	[Address(RVA = "0x9E0BA0", Offset = "0x9DFFA0", Length = "0x8")]
	[Token(Token = "0x600162A")]
	public half get_Item(int index) { }

	[Address(RVA = "0x2AF0510", Offset = "0x2AEF910", Length = "0x12")]
	[Token(Token = "0x6001624")]
	public half2 get_xx() { }

	[Address(RVA = "0x2AF0530", Offset = "0x2AEF930", Length = "0x12")]
	[Token(Token = "0x600161C")]
	public half3 get_xxx() { }

	[Address(RVA = "0x2AF0550", Offset = "0x2AEF950", Length = "0x1D")]
	[Token(Token = "0x600160C")]
	public half4 get_xxxx() { }

	[Address(RVA = "0x2AF0570", Offset = "0x2AEF970", Length = "0x21")]
	[Token(Token = "0x600160D")]
	public half4 get_xxxy() { }

	[Address(RVA = "0x2AF05A0", Offset = "0x2AEF9A0", Length = "0x16")]
	[Token(Token = "0x600161D")]
	public half3 get_xxy() { }

	[Address(RVA = "0x2AF05C0", Offset = "0x2AEF9C0", Length = "0x24")]
	[Token(Token = "0x600160E")]
	public half4 get_xxyx() { }

	[Address(RVA = "0x2AF05F0", Offset = "0x2AEF9F0", Length = "0x21")]
	[Token(Token = "0x600160F")]
	public half4 get_xxyy() { }

	[Address(RVA = "0x2AF0620", Offset = "0x2AEFA20", Length = "0x16")]
	[Token(Token = "0x6001625")]
	public half2 get_xy() { }

	[Address(RVA = "0x2AF0640", Offset = "0x2AEFA40", Length = "0x19")]
	[Token(Token = "0x600161E")]
	public half3 get_xyx() { }

	[Address(RVA = "0x2AF0660", Offset = "0x2AEFA60", Length = "0x24")]
	[Token(Token = "0x6001610")]
	public half4 get_xyxx() { }

	[Address(RVA = "0x2AF0690", Offset = "0x2AEFA90", Length = "0x28")]
	[Token(Token = "0x6001611")]
	public half4 get_xyxy() { }

	[Address(RVA = "0x2AF06C0", Offset = "0x2AEFAC0", Length = "0x16")]
	[Token(Token = "0x600161F")]
	public half3 get_xyy() { }

	[Address(RVA = "0x2AF06E0", Offset = "0x2AEFAE0", Length = "0x24")]
	[Token(Token = "0x6001612")]
	public half4 get_xyyx() { }

	[Address(RVA = "0x2AF0710", Offset = "0x2AEFB10", Length = "0x21")]
	[Token(Token = "0x6001613")]
	public half4 get_xyyy() { }

	[Address(RVA = "0x2AF0740", Offset = "0x2AEFB40", Length = "0x16")]
	[Token(Token = "0x6001627")]
	public half2 get_yx() { }

	[Address(RVA = "0x2AF0760", Offset = "0x2AEFB60", Length = "0x16")]
	[Token(Token = "0x6001620")]
	public half3 get_yxx() { }

	[Address(RVA = "0x2AF0780", Offset = "0x2AEFB80", Length = "0x21")]
	[Token(Token = "0x6001614")]
	public half4 get_yxxx() { }

	[Address(RVA = "0x2AF07B0", Offset = "0x2AEFBB0", Length = "0x25")]
	[Token(Token = "0x6001615")]
	public half4 get_yxxy() { }

	[Address(RVA = "0x2AF07E0", Offset = "0x2AEFBE0", Length = "0x1A")]
	[Token(Token = "0x6001621")]
	public half3 get_yxy() { }

	[Address(RVA = "0x2AF0800", Offset = "0x2AEFC00", Length = "0x28")]
	[Token(Token = "0x6001616")]
	public half4 get_yxyx() { }

	[Address(RVA = "0x2AF0830", Offset = "0x2AEFC30", Length = "0x25")]
	[Token(Token = "0x6001617")]
	public half4 get_yxyy() { }

	[Address(RVA = "0x2AF0860", Offset = "0x2AEFC60", Length = "0x13")]
	[Token(Token = "0x6001629")]
	public half2 get_yy() { }

	[Address(RVA = "0x2AF0880", Offset = "0x2AEFC80", Length = "0x16")]
	[Token(Token = "0x6001622")]
	public half3 get_yyx() { }

	[Address(RVA = "0x2AF08A0", Offset = "0x2AEFCA0", Length = "0x21")]
	[Token(Token = "0x6001618")]
	public half4 get_yyxx() { }

	[Address(RVA = "0x2AF08D0", Offset = "0x2AEFCD0", Length = "0x25")]
	[Token(Token = "0x6001619")]
	public half4 get_yyxy() { }

	[Address(RVA = "0x2AF0900", Offset = "0x2AEFD00", Length = "0x13")]
	[Token(Token = "0x6001623")]
	public half3 get_yyy() { }

	[Address(RVA = "0x2AF0920", Offset = "0x2AEFD20", Length = "0x21")]
	[Token(Token = "0x600161A")]
	public half4 get_yyyx() { }

	[Address(RVA = "0x2AF0950", Offset = "0x2AEFD50", Length = "0x1E")]
	[Token(Token = "0x600161B")]
	public half4 get_yyyy() { }

	[Address(RVA = "0x2AF0250", Offset = "0x2AEF650", Length = "0x65")]
	[Token(Token = "0x600162E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AF0970", Offset = "0x2AEFD70", Length = "0x19")]
	[Token(Token = "0x6001608")]
	public static bool2 op_Equality(half lhs, half2 rhs) { }

	[Address(RVA = "0x2AF09B0", Offset = "0x2AEFDB0", Length = "0x19")]
	[Token(Token = "0x6001607")]
	public static bool2 op_Equality(half2 lhs, half rhs) { }

	[Address(RVA = "0x2AF0990", Offset = "0x2AEFD90", Length = "0x1C")]
	[Token(Token = "0x6001606")]
	public static bool2 op_Equality(half2 lhs, half2 rhs) { }

	[Address(RVA = "0x2A39F90", Offset = "0x2A39390", Length = "0x40")]
	[Token(Token = "0x6001604")]
	public static half2 op_Explicit(double v) { }

	[Address(RVA = "0x2A39FD0", Offset = "0x2A393D0", Length = "0x44")]
	[Token(Token = "0x6001605")]
	public static half2 op_Explicit(double2 v) { }

	[Address(RVA = "0x2A3A030", Offset = "0x2A39430", Length = "0x35")]
	[Token(Token = "0x6001602")]
	public static half2 op_Explicit(float v) { }

	[Address(RVA = "0x2A3A070", Offset = "0x2A39470", Length = "0x36")]
	[Token(Token = "0x6001603")]
	public static half2 op_Explicit(float2 v) { }

	[Address(RVA = "0x2A3A020", Offset = "0x2A39420", Length = "0xF")]
	[Token(Token = "0x6001601")]
	public static half2 op_Implicit(half v) { }

	[Address(RVA = "0x2AF0A10", Offset = "0x2AEFE10", Length = "0x1C")]
	[Token(Token = "0x6001609")]
	public static bool2 op_Inequality(half2 lhs, half2 rhs) { }

	[Address(RVA = "0x2AF09D0", Offset = "0x2AEFDD0", Length = "0x19")]
	[Token(Token = "0x600160A")]
	public static bool2 op_Inequality(half2 lhs, half rhs) { }

	[Address(RVA = "0x2AF09F0", Offset = "0x2AEFDF0", Length = "0x19")]
	[Token(Token = "0x600160B")]
	public static bool2 op_Inequality(half lhs, half2 rhs) { }

	[Address(RVA = "0x9E1F30", Offset = "0x9E1330", Length = "0x9")]
	[Token(Token = "0x600162B")]
	public void set_Item(int index, half value) { }

	[Address(RVA = "0x2AF04B0", Offset = "0x2AEF8B0", Length = "0xB")]
	[Token(Token = "0x6001626")]
	public void set_xy(half2 value) { }

	[Address(RVA = "0x2AF0A30", Offset = "0x2AEFE30", Length = "0xB")]
	[Token(Token = "0x6001628")]
	public void set_yx(half2 value) { }

	[Address(RVA = "0x2AF0350", Offset = "0x2AEF750", Length = "0x8B")]
	[Token(Token = "0x600162F")]
	public virtual string ToString() { }

	[Address(RVA = "0x2AF02C0", Offset = "0x2AEF6C0", Length = "0x88")]
	[Token(Token = "0x6001630")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

