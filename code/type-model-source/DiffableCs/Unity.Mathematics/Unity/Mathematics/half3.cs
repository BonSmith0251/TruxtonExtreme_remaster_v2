namespace Unity.Mathematics;

[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200003A")]
public struct half3 : IEquatable<half3>, IFormattable
{
	[Token(Token = "0x200003B")]
	public sealed class DebuggerProxy
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40000ED")]
		public half x; //Field offset: 0x10
		[FieldOffset(Offset = "0x12")]
		[Token(Token = "0x40000EE")]
		public half y; //Field offset: 0x12
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40000EF")]
		public half z; //Field offset: 0x14

		[Address(RVA = "0x2AF0090", Offset = "0x2AEF490", Length = "0x39")]
		[Token(Token = "0x60016CE")]
		public DebuggerProxy(half3 v) { }

	}

	[Token(Token = "0x40000EC")]
	public static readonly half3 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40000E9")]
	public half x; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x40000EA")]
	public half y; //Field offset: 0x2
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40000EB")]
	public half z; //Field offset: 0x4

	[Token(Token = "0x1700065E")]
	public half Item
	{
		[Address(RVA = "0x9E0BA0", Offset = "0x9DFFA0", Length = "0x8")]
		[Token(Token = "0x60016C7")]
		 get { } //Length: 8
		[Address(RVA = "0x9E1F30", Offset = "0x9E1330", Length = "0x9")]
		[Token(Token = "0x60016C8")]
		 set { } //Length: 9
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000655")]
	public half2 xx
	{
		[Address(RVA = "0x2AF0510", Offset = "0x2AEF910", Length = "0x12")]
		[Token(Token = "0x60016B8")]
		 get { } //Length: 18
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700063A")]
	public half3 xxx
	{
		[Address(RVA = "0x2AF0530", Offset = "0x2AEF930", Length = "0x12")]
		[Token(Token = "0x6001697")]
		 get { } //Length: 18
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005E9")]
	public half4 xxxx
	{
		[Address(RVA = "0x2AF0550", Offset = "0x2AEF950", Length = "0x1D")]
		[Token(Token = "0x6001646")]
		 get { } //Length: 29
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005EA")]
	public half4 xxxy
	{
		[Address(RVA = "0x2AF0570", Offset = "0x2AEF970", Length = "0x21")]
		[Token(Token = "0x6001647")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005EB")]
	public half4 xxxz
	{
		[Address(RVA = "0x2AF0E80", Offset = "0x2AF0280", Length = "0x21")]
		[Token(Token = "0x6001648")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700063B")]
	public half3 xxy
	{
		[Address(RVA = "0x2AF05A0", Offset = "0x2AEF9A0", Length = "0x16")]
		[Token(Token = "0x6001698")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005EC")]
	public half4 xxyx
	{
		[Address(RVA = "0x2AF05C0", Offset = "0x2AEF9C0", Length = "0x24")]
		[Token(Token = "0x6001649")]
		 get { } //Length: 36
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005ED")]
	public half4 xxyy
	{
		[Address(RVA = "0x2AF05F0", Offset = "0x2AEF9F0", Length = "0x21")]
		[Token(Token = "0x600164A")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005EE")]
	public half4 xxyz
	{
		[Address(RVA = "0x2AF0EB0", Offset = "0x2AF02B0", Length = "0x25")]
		[Token(Token = "0x600164B")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700063C")]
	public half3 xxz
	{
		[Address(RVA = "0x2AF0EE0", Offset = "0x2AF02E0", Length = "0x16")]
		[Token(Token = "0x6001699")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005EF")]
	public half4 xxzx
	{
		[Address(RVA = "0x2AF0F00", Offset = "0x2AF0300", Length = "0x24")]
		[Token(Token = "0x600164C")]
		 get { } //Length: 36
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005F0")]
	public half4 xxzy
	{
		[Address(RVA = "0x2AF0F30", Offset = "0x2AF0330", Length = "0x25")]
		[Token(Token = "0x600164D")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005F1")]
	public half4 xxzz
	{
		[Address(RVA = "0x2AF0F60", Offset = "0x2AF0360", Length = "0x21")]
		[Token(Token = "0x600164E")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000656")]
	public half2 xy
	{
		[Address(RVA = "0x2AF0620", Offset = "0x2AEFA20", Length = "0x16")]
		[Token(Token = "0x60016B9")]
		 get { } //Length: 22
		[Address(RVA = "0x2AF04B0", Offset = "0x2AEF8B0", Length = "0xB")]
		[Token(Token = "0x60016BA")]
		 set { } //Length: 11
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700063D")]
	public half3 xyx
	{
		[Address(RVA = "0x2AF0640", Offset = "0x2AEFA40", Length = "0x19")]
		[Token(Token = "0x600169A")]
		 get { } //Length: 25
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005F2")]
	public half4 xyxx
	{
		[Address(RVA = "0x2AF0660", Offset = "0x2AEFA60", Length = "0x24")]
		[Token(Token = "0x600164F")]
		 get { } //Length: 36
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005F3")]
	public half4 xyxy
	{
		[Address(RVA = "0x2AF0690", Offset = "0x2AEFA90", Length = "0x28")]
		[Token(Token = "0x6001650")]
		 get { } //Length: 40
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005F4")]
	public half4 xyxz
	{
		[Address(RVA = "0x2AF0F90", Offset = "0x2AF0390", Length = "0x28")]
		[Token(Token = "0x6001651")]
		 get { } //Length: 40
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700063E")]
	public half3 xyy
	{
		[Address(RVA = "0x2AF06C0", Offset = "0x2AEFAC0", Length = "0x16")]
		[Token(Token = "0x600169B")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005F5")]
	public half4 xyyx
	{
		[Address(RVA = "0x2AF06E0", Offset = "0x2AEFAE0", Length = "0x24")]
		[Token(Token = "0x6001652")]
		 get { } //Length: 36
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005F6")]
	public half4 xyyy
	{
		[Address(RVA = "0x2AF0710", Offset = "0x2AEFB10", Length = "0x21")]
		[Token(Token = "0x6001653")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005F7")]
	public half4 xyyz
	{
		[Address(RVA = "0x2AF0FC0", Offset = "0x2AF03C0", Length = "0x25")]
		[Token(Token = "0x6001654")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700063F")]
	public half3 xyz
	{
		[Address(RVA = "0x2AF0FF0", Offset = "0x2AF03F0", Length = "0x1A")]
		[Token(Token = "0x600169C")]
		 get { } //Length: 26
		[Address(RVA = "0x2AF0E00", Offset = "0x2AF0200", Length = "0x17")]
		[Token(Token = "0x600169D")]
		 set { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005F8")]
	public half4 xyzx
	{
		[Address(RVA = "0x2AF1010", Offset = "0x2AF0410", Length = "0x28")]
		[Token(Token = "0x6001655")]
		 get { } //Length: 40
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005F9")]
	public half4 xyzy
	{
		[Address(RVA = "0x2AF1040", Offset = "0x2AF0440", Length = "0x29")]
		[Token(Token = "0x6001656")]
		 get { } //Length: 41
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005FA")]
	public half4 xyzz
	{
		[Address(RVA = "0x2AF1070", Offset = "0x2AF0470", Length = "0x25")]
		[Token(Token = "0x6001657")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000657")]
	public half2 xz
	{
		[Address(RVA = "0x2AF10A0", Offset = "0x2AF04A0", Length = "0x16")]
		[Token(Token = "0x60016BB")]
		 get { } //Length: 22
		[Address(RVA = "0x2AF1EC0", Offset = "0x2AF12C0", Length = "0xB")]
		[Token(Token = "0x60016BC")]
		 set { } //Length: 11
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000640")]
	public half3 xzx
	{
		[Address(RVA = "0x2AF10C0", Offset = "0x2AF04C0", Length = "0x19")]
		[Token(Token = "0x600169E")]
		 get { } //Length: 25
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005FB")]
	public half4 xzxx
	{
		[Address(RVA = "0x2AF10E0", Offset = "0x2AF04E0", Length = "0x24")]
		[Token(Token = "0x6001658")]
		 get { } //Length: 36
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005FC")]
	public half4 xzxy
	{
		[Address(RVA = "0x2AF1110", Offset = "0x2AF0510", Length = "0x28")]
		[Token(Token = "0x6001659")]
		 get { } //Length: 40
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005FD")]
	public half4 xzxz
	{
		[Address(RVA = "0x2AF1140", Offset = "0x2AF0540", Length = "0x28")]
		[Token(Token = "0x600165A")]
		 get { } //Length: 40
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000641")]
	public half3 xzy
	{
		[Address(RVA = "0x2AF1170", Offset = "0x2AF0570", Length = "0x1A")]
		[Token(Token = "0x600169F")]
		 get { } //Length: 26
		[Address(RVA = "0x2AF1ED0", Offset = "0x2AF12D0", Length = "0x17")]
		[Token(Token = "0x60016A0")]
		 set { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005FE")]
	public half4 xzyx
	{
		[Address(RVA = "0x2AF1190", Offset = "0x2AF0590", Length = "0x28")]
		[Token(Token = "0x600165B")]
		 get { } //Length: 40
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x170005FF")]
	public half4 xzyy
	{
		[Address(RVA = "0x2AF11C0", Offset = "0x2AF05C0", Length = "0x25")]
		[Token(Token = "0x600165C")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000600")]
	public half4 xzyz
	{
		[Address(RVA = "0x2AF11F0", Offset = "0x2AF05F0", Length = "0x29")]
		[Token(Token = "0x600165D")]
		 get { } //Length: 41
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000642")]
	public half3 xzz
	{
		[Address(RVA = "0x2AF1220", Offset = "0x2AF0620", Length = "0x16")]
		[Token(Token = "0x60016A1")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000601")]
	public half4 xzzx
	{
		[Address(RVA = "0x2AF1240", Offset = "0x2AF0640", Length = "0x24")]
		[Token(Token = "0x600165E")]
		 get { } //Length: 36
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000602")]
	public half4 xzzy
	{
		[Address(RVA = "0x2AF1270", Offset = "0x2AF0670", Length = "0x25")]
		[Token(Token = "0x600165F")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000603")]
	public half4 xzzz
	{
		[Address(RVA = "0x2AF12A0", Offset = "0x2AF06A0", Length = "0x21")]
		[Token(Token = "0x6001660")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000658")]
	public half2 yx
	{
		[Address(RVA = "0x2AF0740", Offset = "0x2AEFB40", Length = "0x16")]
		[Token(Token = "0x60016BD")]
		 get { } //Length: 22
		[Address(RVA = "0x2AF0A30", Offset = "0x2AEFE30", Length = "0xB")]
		[Token(Token = "0x60016BE")]
		 set { } //Length: 11
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000643")]
	public half3 yxx
	{
		[Address(RVA = "0x2AF0760", Offset = "0x2AEFB60", Length = "0x16")]
		[Token(Token = "0x60016A2")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000604")]
	public half4 yxxx
	{
		[Address(RVA = "0x2AF0780", Offset = "0x2AEFB80", Length = "0x21")]
		[Token(Token = "0x6001661")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000605")]
	public half4 yxxy
	{
		[Address(RVA = "0x2AF07B0", Offset = "0x2AEFBB0", Length = "0x25")]
		[Token(Token = "0x6001662")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000606")]
	public half4 yxxz
	{
		[Address(RVA = "0x2AF12D0", Offset = "0x2AF06D0", Length = "0x25")]
		[Token(Token = "0x6001663")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000644")]
	public half3 yxy
	{
		[Address(RVA = "0x2AF07E0", Offset = "0x2AEFBE0", Length = "0x1A")]
		[Token(Token = "0x60016A3")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000607")]
	public half4 yxyx
	{
		[Address(RVA = "0x2AF0800", Offset = "0x2AEFC00", Length = "0x28")]
		[Token(Token = "0x6001664")]
		 get { } //Length: 40
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000608")]
	public half4 yxyy
	{
		[Address(RVA = "0x2AF0830", Offset = "0x2AEFC30", Length = "0x25")]
		[Token(Token = "0x6001665")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000609")]
	public half4 yxyz
	{
		[Address(RVA = "0x2AF1300", Offset = "0x2AF0700", Length = "0x29")]
		[Token(Token = "0x6001666")]
		 get { } //Length: 41
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000645")]
	public half3 yxz
	{
		[Address(RVA = "0x2AF1330", Offset = "0x2AF0730", Length = "0x1A")]
		[Token(Token = "0x60016A4")]
		 get { } //Length: 26
		[Address(RVA = "0x2AF1EF0", Offset = "0x2AF12F0", Length = "0x17")]
		[Token(Token = "0x60016A5")]
		 set { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700060A")]
	public half4 yxzx
	{
		[Address(RVA = "0x2AF1350", Offset = "0x2AF0750", Length = "0x28")]
		[Token(Token = "0x6001667")]
		 get { } //Length: 40
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700060B")]
	public half4 yxzy
	{
		[Address(RVA = "0x2AF1380", Offset = "0x2AF0780", Length = "0x29")]
		[Token(Token = "0x6001668")]
		 get { } //Length: 41
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700060C")]
	public half4 yxzz
	{
		[Address(RVA = "0x2AF13B0", Offset = "0x2AF07B0", Length = "0x25")]
		[Token(Token = "0x6001669")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000659")]
	public half2 yy
	{
		[Address(RVA = "0x2AF0860", Offset = "0x2AEFC60", Length = "0x13")]
		[Token(Token = "0x60016BF")]
		 get { } //Length: 19
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000646")]
	public half3 yyx
	{
		[Address(RVA = "0x2AF0880", Offset = "0x2AEFC80", Length = "0x16")]
		[Token(Token = "0x60016A6")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700060D")]
	public half4 yyxx
	{
		[Address(RVA = "0x2AF08A0", Offset = "0x2AEFCA0", Length = "0x21")]
		[Token(Token = "0x600166A")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700060E")]
	public half4 yyxy
	{
		[Address(RVA = "0x2AF08D0", Offset = "0x2AEFCD0", Length = "0x25")]
		[Token(Token = "0x600166B")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700060F")]
	public half4 yyxz
	{
		[Address(RVA = "0x2AF13E0", Offset = "0x2AF07E0", Length = "0x25")]
		[Token(Token = "0x600166C")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000647")]
	public half3 yyy
	{
		[Address(RVA = "0x2AF0900", Offset = "0x2AEFD00", Length = "0x13")]
		[Token(Token = "0x60016A7")]
		 get { } //Length: 19
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000610")]
	public half4 yyyx
	{
		[Address(RVA = "0x2AF0920", Offset = "0x2AEFD20", Length = "0x21")]
		[Token(Token = "0x600166D")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000611")]
	public half4 yyyy
	{
		[Address(RVA = "0x2AF0950", Offset = "0x2AEFD50", Length = "0x1E")]
		[Token(Token = "0x600166E")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000612")]
	public half4 yyyz
	{
		[Address(RVA = "0x2AF1410", Offset = "0x2AF0810", Length = "0x22")]
		[Token(Token = "0x600166F")]
		 get { } //Length: 34
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000648")]
	public half3 yyz
	{
		[Address(RVA = "0x2AF1440", Offset = "0x2AF0840", Length = "0x17")]
		[Token(Token = "0x60016A8")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000613")]
	public half4 yyzx
	{
		[Address(RVA = "0x2AF1460", Offset = "0x2AF0860", Length = "0x25")]
		[Token(Token = "0x6001670")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000614")]
	public half4 yyzy
	{
		[Address(RVA = "0x2AF1490", Offset = "0x2AF0890", Length = "0x26")]
		[Token(Token = "0x6001671")]
		 get { } //Length: 38
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000615")]
	public half4 yyzz
	{
		[Address(RVA = "0x2AF14C0", Offset = "0x2AF08C0", Length = "0x22")]
		[Token(Token = "0x6001672")]
		 get { } //Length: 34
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700065A")]
	public half2 yz
	{
		[Address(RVA = "0x2AF14F0", Offset = "0x2AF08F0", Length = "0x17")]
		[Token(Token = "0x60016C0")]
		 get { } //Length: 23
		[Address(RVA = "0x2AF1F10", Offset = "0x2AF1310", Length = "0xC")]
		[Token(Token = "0x60016C1")]
		 set { } //Length: 12
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000649")]
	public half3 yzx
	{
		[Address(RVA = "0x2AF1510", Offset = "0x2AF0910", Length = "0x1A")]
		[Token(Token = "0x60016A9")]
		 get { } //Length: 26
		[Address(RVA = "0x2AF1F20", Offset = "0x2AF1320", Length = "0x17")]
		[Token(Token = "0x60016AA")]
		 set { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000616")]
	public half4 yzxx
	{
		[Address(RVA = "0x2AF1530", Offset = "0x2AF0930", Length = "0x25")]
		[Token(Token = "0x6001673")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000617")]
	public half4 yzxy
	{
		[Address(RVA = "0x2AF1560", Offset = "0x2AF0960", Length = "0x29")]
		[Token(Token = "0x6001674")]
		 get { } //Length: 41
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000618")]
	public half4 yzxz
	{
		[Address(RVA = "0x2AF1590", Offset = "0x2AF0990", Length = "0x29")]
		[Token(Token = "0x6001675")]
		 get { } //Length: 41
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700064A")]
	public half3 yzy
	{
		[Address(RVA = "0x2AF15C0", Offset = "0x2AF09C0", Length = "0x1B")]
		[Token(Token = "0x60016AB")]
		 get { } //Length: 27
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000619")]
	public half4 yzyx
	{
		[Address(RVA = "0x2AF15E0", Offset = "0x2AF09E0", Length = "0x29")]
		[Token(Token = "0x6001676")]
		 get { } //Length: 41
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700061A")]
	public half4 yzyy
	{
		[Address(RVA = "0x2AF1610", Offset = "0x2AF0A10", Length = "0x26")]
		[Token(Token = "0x6001677")]
		 get { } //Length: 38
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700061B")]
	public half4 yzyz
	{
		[Address(RVA = "0x2AF1640", Offset = "0x2AF0A40", Length = "0x2A")]
		[Token(Token = "0x6001678")]
		 get { } //Length: 42
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700064B")]
	public half3 yzz
	{
		[Address(RVA = "0x2AF1670", Offset = "0x2AF0A70", Length = "0x17")]
		[Token(Token = "0x60016AC")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700061C")]
	public half4 yzzx
	{
		[Address(RVA = "0x2AF1690", Offset = "0x2AF0A90", Length = "0x25")]
		[Token(Token = "0x6001679")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700061D")]
	public half4 yzzy
	{
		[Address(RVA = "0x2AF16C0", Offset = "0x2AF0AC0", Length = "0x26")]
		[Token(Token = "0x600167A")]
		 get { } //Length: 38
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700061E")]
	public half4 yzzz
	{
		[Address(RVA = "0x2AF16F0", Offset = "0x2AF0AF0", Length = "0x22")]
		[Token(Token = "0x600167B")]
		 get { } //Length: 34
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700065B")]
	public half2 zx
	{
		[Address(RVA = "0x2AF1720", Offset = "0x2AF0B20", Length = "0x16")]
		[Token(Token = "0x60016C2")]
		 get { } //Length: 22
		[Address(RVA = "0x2AF1F40", Offset = "0x2AF1340", Length = "0xB")]
		[Token(Token = "0x60016C3")]
		 set { } //Length: 11
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700064C")]
	public half3 zxx
	{
		[Address(RVA = "0x2AF1740", Offset = "0x2AF0B40", Length = "0x16")]
		[Token(Token = "0x60016AD")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700061F")]
	public half4 zxxx
	{
		[Address(RVA = "0x2AF1760", Offset = "0x2AF0B60", Length = "0x21")]
		[Token(Token = "0x600167C")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000620")]
	public half4 zxxy
	{
		[Address(RVA = "0x2AF1790", Offset = "0x2AF0B90", Length = "0x25")]
		[Token(Token = "0x600167D")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000621")]
	public half4 zxxz
	{
		[Address(RVA = "0x2AF17C0", Offset = "0x2AF0BC0", Length = "0x25")]
		[Token(Token = "0x600167E")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700064D")]
	public half3 zxy
	{
		[Address(RVA = "0x2AF17F0", Offset = "0x2AF0BF0", Length = "0x1A")]
		[Token(Token = "0x60016AE")]
		 get { } //Length: 26
		[Address(RVA = "0x2AF1F50", Offset = "0x2AF1350", Length = "0x17")]
		[Token(Token = "0x60016AF")]
		 set { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000622")]
	public half4 zxyx
	{
		[Address(RVA = "0x2AF1810", Offset = "0x2AF0C10", Length = "0x28")]
		[Token(Token = "0x600167F")]
		 get { } //Length: 40
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000623")]
	public half4 zxyy
	{
		[Address(RVA = "0x2AF1840", Offset = "0x2AF0C40", Length = "0x25")]
		[Token(Token = "0x6001680")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000624")]
	public half4 zxyz
	{
		[Address(RVA = "0x2AF1870", Offset = "0x2AF0C70", Length = "0x29")]
		[Token(Token = "0x6001681")]
		 get { } //Length: 41
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700064E")]
	public half3 zxz
	{
		[Address(RVA = "0x2AF18A0", Offset = "0x2AF0CA0", Length = "0x1A")]
		[Token(Token = "0x60016B0")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000625")]
	public half4 zxzx
	{
		[Address(RVA = "0x2AF18C0", Offset = "0x2AF0CC0", Length = "0x28")]
		[Token(Token = "0x6001682")]
		 get { } //Length: 40
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000626")]
	public half4 zxzy
	{
		[Address(RVA = "0x2AF18F0", Offset = "0x2AF0CF0", Length = "0x29")]
		[Token(Token = "0x6001683")]
		 get { } //Length: 41
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000627")]
	public half4 zxzz
	{
		[Address(RVA = "0x2AF1920", Offset = "0x2AF0D20", Length = "0x25")]
		[Token(Token = "0x6001684")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700065C")]
	public half2 zy
	{
		[Address(RVA = "0x2AF1950", Offset = "0x2AF0D50", Length = "0x17")]
		[Token(Token = "0x60016C4")]
		 get { } //Length: 23
		[Address(RVA = "0x2AF1F70", Offset = "0x2AF1370", Length = "0xC")]
		[Token(Token = "0x60016C5")]
		 set { } //Length: 12
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700064F")]
	public half3 zyx
	{
		[Address(RVA = "0x2AF1970", Offset = "0x2AF0D70", Length = "0x1A")]
		[Token(Token = "0x60016B1")]
		 get { } //Length: 26
		[Address(RVA = "0x2AF1F80", Offset = "0x2AF1380", Length = "0x17")]
		[Token(Token = "0x60016B2")]
		 set { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000628")]
	public half4 zyxx
	{
		[Address(RVA = "0x2AF1990", Offset = "0x2AF0D90", Length = "0x25")]
		[Token(Token = "0x6001685")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000629")]
	public half4 zyxy
	{
		[Address(RVA = "0x2AF19C0", Offset = "0x2AF0DC0", Length = "0x29")]
		[Token(Token = "0x6001686")]
		 get { } //Length: 41
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700062A")]
	public half4 zyxz
	{
		[Address(RVA = "0x2AF19F0", Offset = "0x2AF0DF0", Length = "0x29")]
		[Token(Token = "0x6001687")]
		 get { } //Length: 41
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000650")]
	public half3 zyy
	{
		[Address(RVA = "0x2AF1A20", Offset = "0x2AF0E20", Length = "0x17")]
		[Token(Token = "0x60016B3")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700062B")]
	public half4 zyyx
	{
		[Address(RVA = "0x2AF1A40", Offset = "0x2AF0E40", Length = "0x25")]
		[Token(Token = "0x6001688")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700062C")]
	public half4 zyyy
	{
		[Address(RVA = "0x2AF1A70", Offset = "0x2AF0E70", Length = "0x22")]
		[Token(Token = "0x6001689")]
		 get { } //Length: 34
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700062D")]
	public half4 zyyz
	{
		[Address(RVA = "0x2AF1AA0", Offset = "0x2AF0EA0", Length = "0x26")]
		[Token(Token = "0x600168A")]
		 get { } //Length: 38
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000651")]
	public half3 zyz
	{
		[Address(RVA = "0x2AF1AD0", Offset = "0x2AF0ED0", Length = "0x1B")]
		[Token(Token = "0x60016B4")]
		 get { } //Length: 27
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700062E")]
	public half4 zyzx
	{
		[Address(RVA = "0x2AF1AF0", Offset = "0x2AF0EF0", Length = "0x29")]
		[Token(Token = "0x600168B")]
		 get { } //Length: 41
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700062F")]
	public half4 zyzy
	{
		[Address(RVA = "0x2AF1B20", Offset = "0x2AF0F20", Length = "0x2A")]
		[Token(Token = "0x600168C")]
		 get { } //Length: 42
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000630")]
	public half4 zyzz
	{
		[Address(RVA = "0x2AF1B50", Offset = "0x2AF0F50", Length = "0x26")]
		[Token(Token = "0x600168D")]
		 get { } //Length: 38
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700065D")]
	public half2 zz
	{
		[Address(RVA = "0x2AF1B80", Offset = "0x2AF0F80", Length = "0x13")]
		[Token(Token = "0x60016C6")]
		 get { } //Length: 19
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000652")]
	public half3 zzx
	{
		[Address(RVA = "0x2AF1BA0", Offset = "0x2AF0FA0", Length = "0x16")]
		[Token(Token = "0x60016B5")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000631")]
	public half4 zzxx
	{
		[Address(RVA = "0x2AF1BC0", Offset = "0x2AF0FC0", Length = "0x21")]
		[Token(Token = "0x600168E")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000632")]
	public half4 zzxy
	{
		[Address(RVA = "0x2AF1BF0", Offset = "0x2AF0FF0", Length = "0x25")]
		[Token(Token = "0x600168F")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000633")]
	public half4 zzxz
	{
		[Address(RVA = "0x2AF1C20", Offset = "0x2AF1020", Length = "0x25")]
		[Token(Token = "0x6001690")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000653")]
	public half3 zzy
	{
		[Address(RVA = "0x2AF1C50", Offset = "0x2AF1050", Length = "0x17")]
		[Token(Token = "0x60016B6")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000634")]
	public half4 zzyx
	{
		[Address(RVA = "0x2AF1C70", Offset = "0x2AF1070", Length = "0x25")]
		[Token(Token = "0x6001691")]
		 get { } //Length: 37
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000635")]
	public half4 zzyy
	{
		[Address(RVA = "0x2AF1CA0", Offset = "0x2AF10A0", Length = "0x22")]
		[Token(Token = "0x6001692")]
		 get { } //Length: 34
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000636")]
	public half4 zzyz
	{
		[Address(RVA = "0x2AF1CD0", Offset = "0x2AF10D0", Length = "0x26")]
		[Token(Token = "0x6001693")]
		 get { } //Length: 38
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000654")]
	public half3 zzz
	{
		[Address(RVA = "0x2AF1D00", Offset = "0x2AF1100", Length = "0x13")]
		[Token(Token = "0x60016B7")]
		 get { } //Length: 19
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000637")]
	public half4 zzzx
	{
		[Address(RVA = "0x2AF1D20", Offset = "0x2AF1120", Length = "0x21")]
		[Token(Token = "0x6001694")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000638")]
	public half4 zzzy
	{
		[Address(RVA = "0x2AF1D50", Offset = "0x2AF1150", Length = "0x22")]
		[Token(Token = "0x6001695")]
		 get { } //Length: 34
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000639")]
	public half4 zzzz
	{
		[Address(RVA = "0x2AF1D80", Offset = "0x2AF1180", Length = "0x1E")]
		[Token(Token = "0x6001696")]
		 get { } //Length: 30
	}

	[Address(RVA = "0x2A75FC0", Offset = "0x2A753C0", Length = "0xE")]
	[Token(Token = "0x6001632")]
	public half3(half x, half y, half z) { }

	[Address(RVA = "0x2AF0D20", Offset = "0x2AF0120", Length = "0x12")]
	[Token(Token = "0x6001633")]
	public half3(half x, half2 yz) { }

	[Address(RVA = "0x2AF0DA0", Offset = "0x2AF01A0", Length = "0x10")]
	[Token(Token = "0x6001634")]
	public half3(half2 xy, half z) { }

	[Address(RVA = "0x2AF0E00", Offset = "0x2AF0200", Length = "0x17")]
	[Token(Token = "0x6001635")]
	public half3(half3 xyz) { }

	[Address(RVA = "0x2AF0E70", Offset = "0x2AF0270", Length = "0xC")]
	[Token(Token = "0x6001636")]
	public half3(half v) { }

	[Address(RVA = "0x2AF0DB0", Offset = "0x2AF01B0", Length = "0x45")]
	[Token(Token = "0x6001637")]
	public half3(float v) { }

	[Address(RVA = "0x2AF0E20", Offset = "0x2AF0220", Length = "0x49")]
	[Token(Token = "0x6001638")]
	public half3(float3 v) { }

	[Address(RVA = "0x2AF0CC0", Offset = "0x2AF00C0", Length = "0x51")]
	[Token(Token = "0x6001639")]
	public half3(double v) { }

	[Address(RVA = "0x2AF0D40", Offset = "0x2AF0140", Length = "0x55")]
	[Token(Token = "0x600163A")]
	public half3(double3 v) { }

	[Address(RVA = "0x2AF0A70", Offset = "0x2AEFE70", Length = "0x9D")]
	[Token(Token = "0x60016CA")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2AF0A40", Offset = "0x2AEFE40", Length = "0x21")]
	[Token(Token = "0x60016C9")]
	public override bool Equals(half3 rhs) { }

	[Address(RVA = "0x9E0BA0", Offset = "0x9DFFA0", Length = "0x8")]
	[Token(Token = "0x60016C7")]
	public half get_Item(int index) { }

	[Address(RVA = "0x2AF0510", Offset = "0x2AEF910", Length = "0x12")]
	[Token(Token = "0x60016B8")]
	public half2 get_xx() { }

	[Address(RVA = "0x2AF0530", Offset = "0x2AEF930", Length = "0x12")]
	[Token(Token = "0x6001697")]
	public half3 get_xxx() { }

	[Address(RVA = "0x2AF0550", Offset = "0x2AEF950", Length = "0x1D")]
	[Token(Token = "0x6001646")]
	public half4 get_xxxx() { }

	[Address(RVA = "0x2AF0570", Offset = "0x2AEF970", Length = "0x21")]
	[Token(Token = "0x6001647")]
	public half4 get_xxxy() { }

	[Address(RVA = "0x2AF0E80", Offset = "0x2AF0280", Length = "0x21")]
	[Token(Token = "0x6001648")]
	public half4 get_xxxz() { }

	[Address(RVA = "0x2AF05A0", Offset = "0x2AEF9A0", Length = "0x16")]
	[Token(Token = "0x6001698")]
	public half3 get_xxy() { }

	[Address(RVA = "0x2AF05C0", Offset = "0x2AEF9C0", Length = "0x24")]
	[Token(Token = "0x6001649")]
	public half4 get_xxyx() { }

	[Address(RVA = "0x2AF05F0", Offset = "0x2AEF9F0", Length = "0x21")]
	[Token(Token = "0x600164A")]
	public half4 get_xxyy() { }

	[Address(RVA = "0x2AF0EB0", Offset = "0x2AF02B0", Length = "0x25")]
	[Token(Token = "0x600164B")]
	public half4 get_xxyz() { }

	[Address(RVA = "0x2AF0EE0", Offset = "0x2AF02E0", Length = "0x16")]
	[Token(Token = "0x6001699")]
	public half3 get_xxz() { }

	[Address(RVA = "0x2AF0F00", Offset = "0x2AF0300", Length = "0x24")]
	[Token(Token = "0x600164C")]
	public half4 get_xxzx() { }

	[Address(RVA = "0x2AF0F30", Offset = "0x2AF0330", Length = "0x25")]
	[Token(Token = "0x600164D")]
	public half4 get_xxzy() { }

	[Address(RVA = "0x2AF0F60", Offset = "0x2AF0360", Length = "0x21")]
	[Token(Token = "0x600164E")]
	public half4 get_xxzz() { }

	[Address(RVA = "0x2AF0620", Offset = "0x2AEFA20", Length = "0x16")]
	[Token(Token = "0x60016B9")]
	public half2 get_xy() { }

	[Address(RVA = "0x2AF0640", Offset = "0x2AEFA40", Length = "0x19")]
	[Token(Token = "0x600169A")]
	public half3 get_xyx() { }

	[Address(RVA = "0x2AF0660", Offset = "0x2AEFA60", Length = "0x24")]
	[Token(Token = "0x600164F")]
	public half4 get_xyxx() { }

	[Address(RVA = "0x2AF0690", Offset = "0x2AEFA90", Length = "0x28")]
	[Token(Token = "0x6001650")]
	public half4 get_xyxy() { }

	[Address(RVA = "0x2AF0F90", Offset = "0x2AF0390", Length = "0x28")]
	[Token(Token = "0x6001651")]
	public half4 get_xyxz() { }

	[Address(RVA = "0x2AF06C0", Offset = "0x2AEFAC0", Length = "0x16")]
	[Token(Token = "0x600169B")]
	public half3 get_xyy() { }

	[Address(RVA = "0x2AF06E0", Offset = "0x2AEFAE0", Length = "0x24")]
	[Token(Token = "0x6001652")]
	public half4 get_xyyx() { }

	[Address(RVA = "0x2AF0710", Offset = "0x2AEFB10", Length = "0x21")]
	[Token(Token = "0x6001653")]
	public half4 get_xyyy() { }

	[Address(RVA = "0x2AF0FC0", Offset = "0x2AF03C0", Length = "0x25")]
	[Token(Token = "0x6001654")]
	public half4 get_xyyz() { }

	[Address(RVA = "0x2AF0FF0", Offset = "0x2AF03F0", Length = "0x1A")]
	[Token(Token = "0x600169C")]
	public half3 get_xyz() { }

	[Address(RVA = "0x2AF1010", Offset = "0x2AF0410", Length = "0x28")]
	[Token(Token = "0x6001655")]
	public half4 get_xyzx() { }

	[Address(RVA = "0x2AF1040", Offset = "0x2AF0440", Length = "0x29")]
	[Token(Token = "0x6001656")]
	public half4 get_xyzy() { }

	[Address(RVA = "0x2AF1070", Offset = "0x2AF0470", Length = "0x25")]
	[Token(Token = "0x6001657")]
	public half4 get_xyzz() { }

	[Address(RVA = "0x2AF10A0", Offset = "0x2AF04A0", Length = "0x16")]
	[Token(Token = "0x60016BB")]
	public half2 get_xz() { }

	[Address(RVA = "0x2AF10C0", Offset = "0x2AF04C0", Length = "0x19")]
	[Token(Token = "0x600169E")]
	public half3 get_xzx() { }

	[Address(RVA = "0x2AF10E0", Offset = "0x2AF04E0", Length = "0x24")]
	[Token(Token = "0x6001658")]
	public half4 get_xzxx() { }

	[Address(RVA = "0x2AF1110", Offset = "0x2AF0510", Length = "0x28")]
	[Token(Token = "0x6001659")]
	public half4 get_xzxy() { }

	[Address(RVA = "0x2AF1140", Offset = "0x2AF0540", Length = "0x28")]
	[Token(Token = "0x600165A")]
	public half4 get_xzxz() { }

	[Address(RVA = "0x2AF1170", Offset = "0x2AF0570", Length = "0x1A")]
	[Token(Token = "0x600169F")]
	public half3 get_xzy() { }

	[Address(RVA = "0x2AF1190", Offset = "0x2AF0590", Length = "0x28")]
	[Token(Token = "0x600165B")]
	public half4 get_xzyx() { }

	[Address(RVA = "0x2AF11C0", Offset = "0x2AF05C0", Length = "0x25")]
	[Token(Token = "0x600165C")]
	public half4 get_xzyy() { }

	[Address(RVA = "0x2AF11F0", Offset = "0x2AF05F0", Length = "0x29")]
	[Token(Token = "0x600165D")]
	public half4 get_xzyz() { }

	[Address(RVA = "0x2AF1220", Offset = "0x2AF0620", Length = "0x16")]
	[Token(Token = "0x60016A1")]
	public half3 get_xzz() { }

	[Address(RVA = "0x2AF1240", Offset = "0x2AF0640", Length = "0x24")]
	[Token(Token = "0x600165E")]
	public half4 get_xzzx() { }

	[Address(RVA = "0x2AF1270", Offset = "0x2AF0670", Length = "0x25")]
	[Token(Token = "0x600165F")]
	public half4 get_xzzy() { }

	[Address(RVA = "0x2AF12A0", Offset = "0x2AF06A0", Length = "0x21")]
	[Token(Token = "0x6001660")]
	public half4 get_xzzz() { }

	[Address(RVA = "0x2AF0740", Offset = "0x2AEFB40", Length = "0x16")]
	[Token(Token = "0x60016BD")]
	public half2 get_yx() { }

	[Address(RVA = "0x2AF0760", Offset = "0x2AEFB60", Length = "0x16")]
	[Token(Token = "0x60016A2")]
	public half3 get_yxx() { }

	[Address(RVA = "0x2AF0780", Offset = "0x2AEFB80", Length = "0x21")]
	[Token(Token = "0x6001661")]
	public half4 get_yxxx() { }

	[Address(RVA = "0x2AF07B0", Offset = "0x2AEFBB0", Length = "0x25")]
	[Token(Token = "0x6001662")]
	public half4 get_yxxy() { }

	[Address(RVA = "0x2AF12D0", Offset = "0x2AF06D0", Length = "0x25")]
	[Token(Token = "0x6001663")]
	public half4 get_yxxz() { }

	[Address(RVA = "0x2AF07E0", Offset = "0x2AEFBE0", Length = "0x1A")]
	[Token(Token = "0x60016A3")]
	public half3 get_yxy() { }

	[Address(RVA = "0x2AF0800", Offset = "0x2AEFC00", Length = "0x28")]
	[Token(Token = "0x6001664")]
	public half4 get_yxyx() { }

	[Address(RVA = "0x2AF0830", Offset = "0x2AEFC30", Length = "0x25")]
	[Token(Token = "0x6001665")]
	public half4 get_yxyy() { }

	[Address(RVA = "0x2AF1300", Offset = "0x2AF0700", Length = "0x29")]
	[Token(Token = "0x6001666")]
	public half4 get_yxyz() { }

	[Address(RVA = "0x2AF1330", Offset = "0x2AF0730", Length = "0x1A")]
	[Token(Token = "0x60016A4")]
	public half3 get_yxz() { }

	[Address(RVA = "0x2AF1350", Offset = "0x2AF0750", Length = "0x28")]
	[Token(Token = "0x6001667")]
	public half4 get_yxzx() { }

	[Address(RVA = "0x2AF1380", Offset = "0x2AF0780", Length = "0x29")]
	[Token(Token = "0x6001668")]
	public half4 get_yxzy() { }

	[Address(RVA = "0x2AF13B0", Offset = "0x2AF07B0", Length = "0x25")]
	[Token(Token = "0x6001669")]
	public half4 get_yxzz() { }

	[Address(RVA = "0x2AF0860", Offset = "0x2AEFC60", Length = "0x13")]
	[Token(Token = "0x60016BF")]
	public half2 get_yy() { }

	[Address(RVA = "0x2AF0880", Offset = "0x2AEFC80", Length = "0x16")]
	[Token(Token = "0x60016A6")]
	public half3 get_yyx() { }

	[Address(RVA = "0x2AF08A0", Offset = "0x2AEFCA0", Length = "0x21")]
	[Token(Token = "0x600166A")]
	public half4 get_yyxx() { }

	[Address(RVA = "0x2AF08D0", Offset = "0x2AEFCD0", Length = "0x25")]
	[Token(Token = "0x600166B")]
	public half4 get_yyxy() { }

	[Address(RVA = "0x2AF13E0", Offset = "0x2AF07E0", Length = "0x25")]
	[Token(Token = "0x600166C")]
	public half4 get_yyxz() { }

	[Address(RVA = "0x2AF0900", Offset = "0x2AEFD00", Length = "0x13")]
	[Token(Token = "0x60016A7")]
	public half3 get_yyy() { }

	[Address(RVA = "0x2AF0920", Offset = "0x2AEFD20", Length = "0x21")]
	[Token(Token = "0x600166D")]
	public half4 get_yyyx() { }

	[Address(RVA = "0x2AF0950", Offset = "0x2AEFD50", Length = "0x1E")]
	[Token(Token = "0x600166E")]
	public half4 get_yyyy() { }

	[Address(RVA = "0x2AF1410", Offset = "0x2AF0810", Length = "0x22")]
	[Token(Token = "0x600166F")]
	public half4 get_yyyz() { }

	[Address(RVA = "0x2AF1440", Offset = "0x2AF0840", Length = "0x17")]
	[Token(Token = "0x60016A8")]
	public half3 get_yyz() { }

	[Address(RVA = "0x2AF1460", Offset = "0x2AF0860", Length = "0x25")]
	[Token(Token = "0x6001670")]
	public half4 get_yyzx() { }

	[Address(RVA = "0x2AF1490", Offset = "0x2AF0890", Length = "0x26")]
	[Token(Token = "0x6001671")]
	public half4 get_yyzy() { }

	[Address(RVA = "0x2AF14C0", Offset = "0x2AF08C0", Length = "0x22")]
	[Token(Token = "0x6001672")]
	public half4 get_yyzz() { }

	[Address(RVA = "0x2AF14F0", Offset = "0x2AF08F0", Length = "0x17")]
	[Token(Token = "0x60016C0")]
	public half2 get_yz() { }

	[Address(RVA = "0x2AF1510", Offset = "0x2AF0910", Length = "0x1A")]
	[Token(Token = "0x60016A9")]
	public half3 get_yzx() { }

	[Address(RVA = "0x2AF1530", Offset = "0x2AF0930", Length = "0x25")]
	[Token(Token = "0x6001673")]
	public half4 get_yzxx() { }

	[Address(RVA = "0x2AF1560", Offset = "0x2AF0960", Length = "0x29")]
	[Token(Token = "0x6001674")]
	public half4 get_yzxy() { }

	[Address(RVA = "0x2AF1590", Offset = "0x2AF0990", Length = "0x29")]
	[Token(Token = "0x6001675")]
	public half4 get_yzxz() { }

	[Address(RVA = "0x2AF15C0", Offset = "0x2AF09C0", Length = "0x1B")]
	[Token(Token = "0x60016AB")]
	public half3 get_yzy() { }

	[Address(RVA = "0x2AF15E0", Offset = "0x2AF09E0", Length = "0x29")]
	[Token(Token = "0x6001676")]
	public half4 get_yzyx() { }

	[Address(RVA = "0x2AF1610", Offset = "0x2AF0A10", Length = "0x26")]
	[Token(Token = "0x6001677")]
	public half4 get_yzyy() { }

	[Address(RVA = "0x2AF1640", Offset = "0x2AF0A40", Length = "0x2A")]
	[Token(Token = "0x6001678")]
	public half4 get_yzyz() { }

	[Address(RVA = "0x2AF1670", Offset = "0x2AF0A70", Length = "0x17")]
	[Token(Token = "0x60016AC")]
	public half3 get_yzz() { }

	[Address(RVA = "0x2AF1690", Offset = "0x2AF0A90", Length = "0x25")]
	[Token(Token = "0x6001679")]
	public half4 get_yzzx() { }

	[Address(RVA = "0x2AF16C0", Offset = "0x2AF0AC0", Length = "0x26")]
	[Token(Token = "0x600167A")]
	public half4 get_yzzy() { }

	[Address(RVA = "0x2AF16F0", Offset = "0x2AF0AF0", Length = "0x22")]
	[Token(Token = "0x600167B")]
	public half4 get_yzzz() { }

	[Address(RVA = "0x2AF1720", Offset = "0x2AF0B20", Length = "0x16")]
	[Token(Token = "0x60016C2")]
	public half2 get_zx() { }

	[Address(RVA = "0x2AF1740", Offset = "0x2AF0B40", Length = "0x16")]
	[Token(Token = "0x60016AD")]
	public half3 get_zxx() { }

	[Address(RVA = "0x2AF1760", Offset = "0x2AF0B60", Length = "0x21")]
	[Token(Token = "0x600167C")]
	public half4 get_zxxx() { }

	[Address(RVA = "0x2AF1790", Offset = "0x2AF0B90", Length = "0x25")]
	[Token(Token = "0x600167D")]
	public half4 get_zxxy() { }

	[Address(RVA = "0x2AF17C0", Offset = "0x2AF0BC0", Length = "0x25")]
	[Token(Token = "0x600167E")]
	public half4 get_zxxz() { }

	[Address(RVA = "0x2AF17F0", Offset = "0x2AF0BF0", Length = "0x1A")]
	[Token(Token = "0x60016AE")]
	public half3 get_zxy() { }

	[Address(RVA = "0x2AF1810", Offset = "0x2AF0C10", Length = "0x28")]
	[Token(Token = "0x600167F")]
	public half4 get_zxyx() { }

	[Address(RVA = "0x2AF1840", Offset = "0x2AF0C40", Length = "0x25")]
	[Token(Token = "0x6001680")]
	public half4 get_zxyy() { }

	[Address(RVA = "0x2AF1870", Offset = "0x2AF0C70", Length = "0x29")]
	[Token(Token = "0x6001681")]
	public half4 get_zxyz() { }

	[Address(RVA = "0x2AF18A0", Offset = "0x2AF0CA0", Length = "0x1A")]
	[Token(Token = "0x60016B0")]
	public half3 get_zxz() { }

	[Address(RVA = "0x2AF18C0", Offset = "0x2AF0CC0", Length = "0x28")]
	[Token(Token = "0x6001682")]
	public half4 get_zxzx() { }

	[Address(RVA = "0x2AF18F0", Offset = "0x2AF0CF0", Length = "0x29")]
	[Token(Token = "0x6001683")]
	public half4 get_zxzy() { }

	[Address(RVA = "0x2AF1920", Offset = "0x2AF0D20", Length = "0x25")]
	[Token(Token = "0x6001684")]
	public half4 get_zxzz() { }

	[Address(RVA = "0x2AF1950", Offset = "0x2AF0D50", Length = "0x17")]
	[Token(Token = "0x60016C4")]
	public half2 get_zy() { }

	[Address(RVA = "0x2AF1970", Offset = "0x2AF0D70", Length = "0x1A")]
	[Token(Token = "0x60016B1")]
	public half3 get_zyx() { }

	[Address(RVA = "0x2AF1990", Offset = "0x2AF0D90", Length = "0x25")]
	[Token(Token = "0x6001685")]
	public half4 get_zyxx() { }

	[Address(RVA = "0x2AF19C0", Offset = "0x2AF0DC0", Length = "0x29")]
	[Token(Token = "0x6001686")]
	public half4 get_zyxy() { }

	[Address(RVA = "0x2AF19F0", Offset = "0x2AF0DF0", Length = "0x29")]
	[Token(Token = "0x6001687")]
	public half4 get_zyxz() { }

	[Address(RVA = "0x2AF1A20", Offset = "0x2AF0E20", Length = "0x17")]
	[Token(Token = "0x60016B3")]
	public half3 get_zyy() { }

	[Address(RVA = "0x2AF1A40", Offset = "0x2AF0E40", Length = "0x25")]
	[Token(Token = "0x6001688")]
	public half4 get_zyyx() { }

	[Address(RVA = "0x2AF1A70", Offset = "0x2AF0E70", Length = "0x22")]
	[Token(Token = "0x6001689")]
	public half4 get_zyyy() { }

	[Address(RVA = "0x2AF1AA0", Offset = "0x2AF0EA0", Length = "0x26")]
	[Token(Token = "0x600168A")]
	public half4 get_zyyz() { }

	[Address(RVA = "0x2AF1AD0", Offset = "0x2AF0ED0", Length = "0x1B")]
	[Token(Token = "0x60016B4")]
	public half3 get_zyz() { }

	[Address(RVA = "0x2AF1AF0", Offset = "0x2AF0EF0", Length = "0x29")]
	[Token(Token = "0x600168B")]
	public half4 get_zyzx() { }

	[Address(RVA = "0x2AF1B20", Offset = "0x2AF0F20", Length = "0x2A")]
	[Token(Token = "0x600168C")]
	public half4 get_zyzy() { }

	[Address(RVA = "0x2AF1B50", Offset = "0x2AF0F50", Length = "0x26")]
	[Token(Token = "0x600168D")]
	public half4 get_zyzz() { }

	[Address(RVA = "0x2AF1B80", Offset = "0x2AF0F80", Length = "0x13")]
	[Token(Token = "0x60016C6")]
	public half2 get_zz() { }

	[Address(RVA = "0x2AF1BA0", Offset = "0x2AF0FA0", Length = "0x16")]
	[Token(Token = "0x60016B5")]
	public half3 get_zzx() { }

	[Address(RVA = "0x2AF1BC0", Offset = "0x2AF0FC0", Length = "0x21")]
	[Token(Token = "0x600168E")]
	public half4 get_zzxx() { }

	[Address(RVA = "0x2AF1BF0", Offset = "0x2AF0FF0", Length = "0x25")]
	[Token(Token = "0x600168F")]
	public half4 get_zzxy() { }

	[Address(RVA = "0x2AF1C20", Offset = "0x2AF1020", Length = "0x25")]
	[Token(Token = "0x6001690")]
	public half4 get_zzxz() { }

	[Address(RVA = "0x2AF1C50", Offset = "0x2AF1050", Length = "0x17")]
	[Token(Token = "0x60016B6")]
	public half3 get_zzy() { }

	[Address(RVA = "0x2AF1C70", Offset = "0x2AF1070", Length = "0x25")]
	[Token(Token = "0x6001691")]
	public half4 get_zzyx() { }

	[Address(RVA = "0x2AF1CA0", Offset = "0x2AF10A0", Length = "0x22")]
	[Token(Token = "0x6001692")]
	public half4 get_zzyy() { }

	[Address(RVA = "0x2AF1CD0", Offset = "0x2AF10D0", Length = "0x26")]
	[Token(Token = "0x6001693")]
	public half4 get_zzyz() { }

	[Address(RVA = "0x2AF1D00", Offset = "0x2AF1100", Length = "0x13")]
	[Token(Token = "0x60016B7")]
	public half3 get_zzz() { }

	[Address(RVA = "0x2AF1D20", Offset = "0x2AF1120", Length = "0x21")]
	[Token(Token = "0x6001694")]
	public half4 get_zzzx() { }

	[Address(RVA = "0x2AF1D50", Offset = "0x2AF1150", Length = "0x22")]
	[Token(Token = "0x6001695")]
	public half4 get_zzzy() { }

	[Address(RVA = "0x2AF1D80", Offset = "0x2AF1180", Length = "0x1E")]
	[Token(Token = "0x6001696")]
	public half4 get_zzzz() { }

	[Address(RVA = "0x2AF0B10", Offset = "0x2AEFF10", Length = "0x37")]
	[Token(Token = "0x60016CB")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AF1E00", Offset = "0x2AF1200", Length = "0x23")]
	[Token(Token = "0x6001642")]
	public static bool3 op_Equality(half lhs, half3 rhs) { }

	[Address(RVA = "0x2AF1DA0", Offset = "0x2AF11A0", Length = "0x2E")]
	[Token(Token = "0x6001640")]
	public static bool3 op_Equality(half3 lhs, half3 rhs) { }

	[Address(RVA = "0x2AF1DD0", Offset = "0x2AF11D0", Length = "0x23")]
	[Token(Token = "0x6001641")]
	public static bool3 op_Equality(half3 lhs, half rhs) { }

	[Address(RVA = "0x2A3A220", Offset = "0x2A39620", Length = "0x48")]
	[Token(Token = "0x600163C")]
	public static half3 op_Explicit(float v) { }

	[Address(RVA = "0x2A3A0B0", Offset = "0x2A394B0", Length = "0x54")]
	[Token(Token = "0x600163E")]
	public static half3 op_Explicit(double v) { }

	[Address(RVA = "0x2A3A140", Offset = "0x2A39540", Length = "0x64")]
	[Token(Token = "0x600163F")]
	public static half3 op_Explicit(double3 v) { }

	[Address(RVA = "0x2A3A1B0", Offset = "0x2A395B0", Length = "0x5A")]
	[Token(Token = "0x600163D")]
	public static half3 op_Explicit(float3 v) { }

	[Address(RVA = "0x2A3A210", Offset = "0x2A39610", Length = "0xF")]
	[Token(Token = "0x600163B")]
	public static half3 op_Implicit(half v) { }

	[Address(RVA = "0x2AF1E90", Offset = "0x2AF1290", Length = "0x23")]
	[Token(Token = "0x6001644")]
	public static bool3 op_Inequality(half3 lhs, half rhs) { }

	[Address(RVA = "0x2AF1E60", Offset = "0x2AF1260", Length = "0x2E")]
	[Token(Token = "0x6001643")]
	public static bool3 op_Inequality(half3 lhs, half3 rhs) { }

	[Address(RVA = "0x2AF1E30", Offset = "0x2AF1230", Length = "0x23")]
	[Token(Token = "0x6001645")]
	public static bool3 op_Inequality(half lhs, half3 rhs) { }

	[Address(RVA = "0x9E1F30", Offset = "0x9E1330", Length = "0x9")]
	[Token(Token = "0x60016C8")]
	public void set_Item(int index, half value) { }

	[Address(RVA = "0x2AF04B0", Offset = "0x2AEF8B0", Length = "0xB")]
	[Token(Token = "0x60016BA")]
	public void set_xy(half2 value) { }

	[Address(RVA = "0x2AF0E00", Offset = "0x2AF0200", Length = "0x17")]
	[Token(Token = "0x600169D")]
	public void set_xyz(half3 value) { }

	[Address(RVA = "0x2AF1EC0", Offset = "0x2AF12C0", Length = "0xB")]
	[Token(Token = "0x60016BC")]
	public void set_xz(half2 value) { }

	[Address(RVA = "0x2AF1ED0", Offset = "0x2AF12D0", Length = "0x17")]
	[Token(Token = "0x60016A0")]
	public void set_xzy(half3 value) { }

	[Address(RVA = "0x2AF0A30", Offset = "0x2AEFE30", Length = "0xB")]
	[Token(Token = "0x60016BE")]
	public void set_yx(half2 value) { }

	[Address(RVA = "0x2AF1EF0", Offset = "0x2AF12F0", Length = "0x17")]
	[Token(Token = "0x60016A5")]
	public void set_yxz(half3 value) { }

	[Address(RVA = "0x2AF1F10", Offset = "0x2AF1310", Length = "0xC")]
	[Token(Token = "0x60016C1")]
	public void set_yz(half2 value) { }

	[Address(RVA = "0x2AF1F20", Offset = "0x2AF1320", Length = "0x17")]
	[Token(Token = "0x60016AA")]
	public void set_yzx(half3 value) { }

	[Address(RVA = "0x2AF1F40", Offset = "0x2AF1340", Length = "0xB")]
	[Token(Token = "0x60016C3")]
	public void set_zx(half2 value) { }

	[Address(RVA = "0x2AF1F50", Offset = "0x2AF1350", Length = "0x17")]
	[Token(Token = "0x60016AF")]
	public void set_zxy(half3 value) { }

	[Address(RVA = "0x2AF1F70", Offset = "0x2AF1370", Length = "0xC")]
	[Token(Token = "0x60016C5")]
	public void set_zy(half2 value) { }

	[Address(RVA = "0x2AF1F80", Offset = "0x2AF1380", Length = "0x17")]
	[Token(Token = "0x60016B2")]
	public void set_zyx(half3 value) { }

	[Address(RVA = "0x2AF0C10", Offset = "0x2AF0010", Length = "0xAC")]
	[Token(Token = "0x60016CC")]
	public virtual string ToString() { }

	[Address(RVA = "0x2AF0B50", Offset = "0x2AEFF50", Length = "0xB3")]
	[Token(Token = "0x60016CD")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

