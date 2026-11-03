namespace Unity.Mathematics;

[DebuggerTypeProxy(typeof(DebuggerProxy))]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[Token(Token = "0x200001E")]
public struct double3 : IEquatable<double3>, IFormattable
{
	[Token(Token = "0x200001F")]
	public sealed class DebuggerProxy
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000080")]
		public double x; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000081")]
		public double y; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000082")]
		public double z; //Field offset: 0x20

		[Address(RVA = "0x2AA0420", Offset = "0x2A9F820", Length = "0x39")]
		[Token(Token = "0x6000D12")]
		public DebuggerProxy(double3 v) { }

	}

	[Token(Token = "0x400007F")]
	public static readonly double3 zero; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400007C")]
	public double x; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400007D")]
	public double y; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400007E")]
	public double z; //Field offset: 0x10

	[Token(Token = "0x17000283")]
	public double Item
	{
		[Address(RVA = "0x9E0CD0", Offset = "0x9E00D0", Length = "0x9")]
		[Token(Token = "0x6000D0B")]
		 get { } //Length: 9
		[Address(RVA = "0x9E2040", Offset = "0x9E1440", Length = "0x9")]
		[Token(Token = "0x6000D0C")]
		 set { } //Length: 9
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700027A")]
	public double2 xx
	{
		[Address(RVA = "0x27FB7F0", Offset = "0x27FABF0", Length = "0xE")]
		[Token(Token = "0x6000CFC")]
		 get { } //Length: 14
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700025F")]
	public double3 xxx
	{
		[Address(RVA = "0x2AA4850", Offset = "0x2AA3C50", Length = "0x12")]
		[Token(Token = "0x6000CDB")]
		 get { } //Length: 18
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700020E")]
	public double4 xxxx
	{
		[Address(RVA = "0x2AA4870", Offset = "0x2AA3C70", Length = "0x16")]
		[Token(Token = "0x6000C8A")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700020F")]
	public double4 xxxy
	{
		[Address(RVA = "0x2AA4890", Offset = "0x2AA3C90", Length = "0x1A")]
		[Token(Token = "0x6000C8B")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000210")]
	public double4 xxxz
	{
		[Address(RVA = "0x2AAB170", Offset = "0x2AAA570", Length = "0x1A")]
		[Token(Token = "0x6000C8C")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000260")]
	public double3 xxy
	{
		[Address(RVA = "0x2AA48B0", Offset = "0x2AA3CB0", Length = "0x16")]
		[Token(Token = "0x6000CDC")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000211")]
	public double4 xxyx
	{
		[Address(RVA = "0x2AA48D0", Offset = "0x2AA3CD0", Length = "0x1D")]
		[Token(Token = "0x6000C8D")]
		 get { } //Length: 29
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000212")]
	public double4 xxyy
	{
		[Address(RVA = "0x2AA48F0", Offset = "0x2AA3CF0", Length = "0x1A")]
		[Token(Token = "0x6000C8E")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000213")]
	public double4 xxyz
	{
		[Address(RVA = "0x2AAB190", Offset = "0x2AAA590", Length = "0x1E")]
		[Token(Token = "0x6000C8F")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000261")]
	public double3 xxz
	{
		[Address(RVA = "0x2AAB1B0", Offset = "0x2AAA5B0", Length = "0x16")]
		[Token(Token = "0x6000CDD")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000214")]
	public double4 xxzx
	{
		[Address(RVA = "0x2AAB1D0", Offset = "0x2AAA5D0", Length = "0x1D")]
		[Token(Token = "0x6000C90")]
		 get { } //Length: 29
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000215")]
	public double4 xxzy
	{
		[Address(RVA = "0x2AAB1F0", Offset = "0x2AAA5F0", Length = "0x1E")]
		[Token(Token = "0x6000C91")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000216")]
	public double4 xxzz
	{
		[Address(RVA = "0x27EFAC0", Offset = "0x27EEEC0", Length = "0x1A")]
		[Token(Token = "0x6000C92")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700027B")]
	public double2 xy
	{
		[Address(RVA = "0x2AA4910", Offset = "0x2AA3D10", Length = "0x12")]
		[Token(Token = "0x6000CFD")]
		 get { } //Length: 18
		[Address(RVA = "0x289C960", Offset = "0x289BD60", Length = "0xF")]
		[Token(Token = "0x6000CFE")]
		 set { } //Length: 15
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000262")]
	public double3 xyx
	{
		[Address(RVA = "0x2AA4930", Offset = "0x2AA3D30", Length = "0x19")]
		[Token(Token = "0x6000CDE")]
		 get { } //Length: 25
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000217")]
	public double4 xyxx
	{
		[Address(RVA = "0x2AA4950", Offset = "0x2AA3D50", Length = "0x1D")]
		[Token(Token = "0x6000C93")]
		 get { } //Length: 29
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000218")]
	public double4 xyxy
	{
		[Address(RVA = "0x2AA4970", Offset = "0x2AA3D70", Length = "0x21")]
		[Token(Token = "0x6000C94")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000219")]
	public double4 xyxz
	{
		[Address(RVA = "0x2AAB210", Offset = "0x2AAA610", Length = "0x21")]
		[Token(Token = "0x6000C95")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000263")]
	public double3 xyy
	{
		[Address(RVA = "0x2AA49A0", Offset = "0x2AA3DA0", Length = "0x16")]
		[Token(Token = "0x6000CDF")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700021A")]
	public double4 xyyx
	{
		[Address(RVA = "0x2AA49C0", Offset = "0x2AA3DC0", Length = "0x1D")]
		[Token(Token = "0x6000C96")]
		 get { } //Length: 29
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700021B")]
	public double4 xyyy
	{
		[Address(RVA = "0x2AA49E0", Offset = "0x2AA3DE0", Length = "0x1A")]
		[Token(Token = "0x6000C97")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700021C")]
	public double4 xyyz
	{
		[Address(RVA = "0x2AAB240", Offset = "0x2AAA640", Length = "0x1E")]
		[Token(Token = "0x6000C98")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000264")]
	public double3 xyz
	{
		[Address(RVA = "0x2AAB260", Offset = "0x2AAA660", Length = "0x1A")]
		[Token(Token = "0x6000CE0")]
		 get { } //Length: 26
		[Address(RVA = "0x2AAB060", Offset = "0x2AAA460", Length = "0x17")]
		[Token(Token = "0x6000CE1")]
		 set { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700021D")]
	public double4 xyzx
	{
		[Address(RVA = "0x2AAB280", Offset = "0x2AAA680", Length = "0x21")]
		[Token(Token = "0x6000C99")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700021E")]
	public double4 xyzy
	{
		[Address(RVA = "0x2AAB2B0", Offset = "0x2AAA6B0", Length = "0x22")]
		[Token(Token = "0x6000C9A")]
		 get { } //Length: 34
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700021F")]
	public double4 xyzz
	{
		[Address(RVA = "0x2AAB2E0", Offset = "0x2AAA6E0", Length = "0x1E")]
		[Token(Token = "0x6000C9B")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700027C")]
	public double2 xz
	{
		[Address(RVA = "0x2AAB300", Offset = "0x2AAA700", Length = "0x12")]
		[Token(Token = "0x6000CFF")]
		 get { } //Length: 18
		[Address(RVA = "0x2AAC660", Offset = "0x2AABA60", Length = "0xF")]
		[Token(Token = "0x6000D00")]
		 set { } //Length: 15
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000265")]
	public double3 xzx
	{
		[Address(RVA = "0x2AAB320", Offset = "0x2AAA720", Length = "0x19")]
		[Token(Token = "0x6000CE2")]
		 get { } //Length: 25
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000220")]
	public double4 xzxx
	{
		[Address(RVA = "0x2AAB340", Offset = "0x2AAA740", Length = "0x1D")]
		[Token(Token = "0x6000C9C")]
		 get { } //Length: 29
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000221")]
	public double4 xzxy
	{
		[Address(RVA = "0x2AAB360", Offset = "0x2AAA760", Length = "0x21")]
		[Token(Token = "0x6000C9D")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000222")]
	public double4 xzxz
	{
		[Address(RVA = "0x2AAB390", Offset = "0x2AAA790", Length = "0x21")]
		[Token(Token = "0x6000C9E")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000266")]
	public double3 xzy
	{
		[Address(RVA = "0x2AAB3C0", Offset = "0x2AAA7C0", Length = "0x1A")]
		[Token(Token = "0x6000CE3")]
		 get { } //Length: 26
		[Address(RVA = "0x2AAC670", Offset = "0x2AABA70", Length = "0x17")]
		[Token(Token = "0x6000CE4")]
		 set { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000223")]
	public double4 xzyx
	{
		[Address(RVA = "0x2AAB3E0", Offset = "0x2AAA7E0", Length = "0x21")]
		[Token(Token = "0x6000C9F")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000224")]
	public double4 xzyy
	{
		[Address(RVA = "0x2AAB410", Offset = "0x2AAA810", Length = "0x1E")]
		[Token(Token = "0x6000CA0")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000225")]
	public double4 xzyz
	{
		[Address(RVA = "0x2AAB430", Offset = "0x2AAA830", Length = "0x22")]
		[Token(Token = "0x6000CA1")]
		 get { } //Length: 34
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000267")]
	public double3 xzz
	{
		[Address(RVA = "0x2AAB460", Offset = "0x2AAA860", Length = "0x16")]
		[Token(Token = "0x6000CE5")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000226")]
	public double4 xzzx
	{
		[Address(RVA = "0x2AAB480", Offset = "0x2AAA880", Length = "0x1D")]
		[Token(Token = "0x6000CA2")]
		 get { } //Length: 29
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000227")]
	public double4 xzzy
	{
		[Address(RVA = "0x2AAB4A0", Offset = "0x2AAA8A0", Length = "0x1E")]
		[Token(Token = "0x6000CA3")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000228")]
	public double4 xzzz
	{
		[Address(RVA = "0x2AAB4C0", Offset = "0x2AAA8C0", Length = "0x1A")]
		[Token(Token = "0x6000CA4")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700027D")]
	public double2 yx
	{
		[Address(RVA = "0x2AA4A00", Offset = "0x2AA3E00", Length = "0x12")]
		[Token(Token = "0x6000D01")]
		 get { } //Length: 18
		[Address(RVA = "0x2AA5180", Offset = "0x2AA4580", Length = "0xF")]
		[Token(Token = "0x6000D02")]
		 set { } //Length: 15
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000268")]
	public double3 yxx
	{
		[Address(RVA = "0x2AA4A20", Offset = "0x2AA3E20", Length = "0x16")]
		[Token(Token = "0x6000CE6")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000229")]
	public double4 yxxx
	{
		[Address(RVA = "0x2AA4A40", Offset = "0x2AA3E40", Length = "0x1A")]
		[Token(Token = "0x6000CA5")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700022A")]
	public double4 yxxy
	{
		[Address(RVA = "0x2AA4A60", Offset = "0x2AA3E60", Length = "0x1E")]
		[Token(Token = "0x6000CA6")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700022B")]
	public double4 yxxz
	{
		[Address(RVA = "0x2AAB4E0", Offset = "0x2AAA8E0", Length = "0x1E")]
		[Token(Token = "0x6000CA7")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000269")]
	public double3 yxy
	{
		[Address(RVA = "0x2AA4A80", Offset = "0x2AA3E80", Length = "0x1A")]
		[Token(Token = "0x6000CE7")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700022C")]
	public double4 yxyx
	{
		[Address(RVA = "0x2AA4AA0", Offset = "0x2AA3EA0", Length = "0x21")]
		[Token(Token = "0x6000CA8")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700022D")]
	public double4 yxyy
	{
		[Address(RVA = "0x2AA4AD0", Offset = "0x2AA3ED0", Length = "0x1E")]
		[Token(Token = "0x6000CA9")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700022E")]
	public double4 yxyz
	{
		[Address(RVA = "0x2AAB500", Offset = "0x2AAA900", Length = "0x22")]
		[Token(Token = "0x6000CAA")]
		 get { } //Length: 34
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700026A")]
	public double3 yxz
	{
		[Address(RVA = "0x2AAB530", Offset = "0x2AAA930", Length = "0x1A")]
		[Token(Token = "0x6000CE8")]
		 get { } //Length: 26
		[Address(RVA = "0x2AAC690", Offset = "0x2AABA90", Length = "0x17")]
		[Token(Token = "0x6000CE9")]
		 set { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700022F")]
	public double4 yxzx
	{
		[Address(RVA = "0x2AAB550", Offset = "0x2AAA950", Length = "0x21")]
		[Token(Token = "0x6000CAB")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000230")]
	public double4 yxzy
	{
		[Address(RVA = "0x2AAB580", Offset = "0x2AAA980", Length = "0x22")]
		[Token(Token = "0x6000CAC")]
		 get { } //Length: 34
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000231")]
	public double4 yxzz
	{
		[Address(RVA = "0x2AAB5B0", Offset = "0x2AAA9B0", Length = "0x1E")]
		[Token(Token = "0x6000CAD")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700027E")]
	public double2 yy
	{
		[Address(RVA = "0x2AA4AF0", Offset = "0x2AA3EF0", Length = "0xF")]
		[Token(Token = "0x6000D03")]
		 get { } //Length: 15
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700026B")]
	public double3 yyx
	{
		[Address(RVA = "0x2AA4B00", Offset = "0x2AA3F00", Length = "0x16")]
		[Token(Token = "0x6000CEA")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000232")]
	public double4 yyxx
	{
		[Address(RVA = "0x2AA4B20", Offset = "0x2AA3F20", Length = "0x1A")]
		[Token(Token = "0x6000CAE")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000233")]
	public double4 yyxy
	{
		[Address(RVA = "0x2AA4B40", Offset = "0x2AA3F40", Length = "0x1E")]
		[Token(Token = "0x6000CAF")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000234")]
	public double4 yyxz
	{
		[Address(RVA = "0x2AAB5D0", Offset = "0x2AAA9D0", Length = "0x1E")]
		[Token(Token = "0x6000CB0")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700026C")]
	public double3 yyy
	{
		[Address(RVA = "0x2AA4B60", Offset = "0x2AA3F60", Length = "0x13")]
		[Token(Token = "0x6000CEB")]
		 get { } //Length: 19
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000235")]
	public double4 yyyx
	{
		[Address(RVA = "0x2AA4B80", Offset = "0x2AA3F80", Length = "0x1A")]
		[Token(Token = "0x6000CB1")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000236")]
	public double4 yyyy
	{
		[Address(RVA = "0x2AA4BA0", Offset = "0x2AA3FA0", Length = "0x17")]
		[Token(Token = "0x6000CB2")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000237")]
	public double4 yyyz
	{
		[Address(RVA = "0x2AAB5F0", Offset = "0x2AAA9F0", Length = "0x1B")]
		[Token(Token = "0x6000CB3")]
		 get { } //Length: 27
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700026D")]
	public double3 yyz
	{
		[Address(RVA = "0x2AAB610", Offset = "0x2AAAA10", Length = "0x17")]
		[Token(Token = "0x6000CEC")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000238")]
	public double4 yyzx
	{
		[Address(RVA = "0x2AAB630", Offset = "0x2AAAA30", Length = "0x1E")]
		[Token(Token = "0x6000CB4")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000239")]
	public double4 yyzy
	{
		[Address(RVA = "0x2AAB650", Offset = "0x2AAAA50", Length = "0x1F")]
		[Token(Token = "0x6000CB5")]
		 get { } //Length: 31
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700023A")]
	public double4 yyzz
	{
		[Address(RVA = "0x2AAB670", Offset = "0x2AAAA70", Length = "0x1B")]
		[Token(Token = "0x6000CB6")]
		 get { } //Length: 27
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700027F")]
	public double2 yz
	{
		[Address(RVA = "0x2AAB690", Offset = "0x2AAAA90", Length = "0x13")]
		[Token(Token = "0x6000D04")]
		 get { } //Length: 19
		[Address(RVA = "0x2AAC6B0", Offset = "0x2AABAB0", Length = "0x10")]
		[Token(Token = "0x6000D05")]
		 set { } //Length: 16
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700026E")]
	public double3 yzx
	{
		[Address(RVA = "0x2AAB6B0", Offset = "0x2AAAAB0", Length = "0x1A")]
		[Token(Token = "0x6000CED")]
		 get { } //Length: 26
		[Address(RVA = "0x2AAC6C0", Offset = "0x2AABAC0", Length = "0x17")]
		[Token(Token = "0x6000CEE")]
		 set { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700023B")]
	public double4 yzxx
	{
		[Address(RVA = "0x2AAB6D0", Offset = "0x2AAAAD0", Length = "0x1E")]
		[Token(Token = "0x6000CB7")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700023C")]
	public double4 yzxy
	{
		[Address(RVA = "0x2AAB6F0", Offset = "0x2AAAAF0", Length = "0x22")]
		[Token(Token = "0x6000CB8")]
		 get { } //Length: 34
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700023D")]
	public double4 yzxz
	{
		[Address(RVA = "0x2AAB720", Offset = "0x2AAAB20", Length = "0x22")]
		[Token(Token = "0x6000CB9")]
		 get { } //Length: 34
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700026F")]
	public double3 yzy
	{
		[Address(RVA = "0x2AAB750", Offset = "0x2AAAB50", Length = "0x1B")]
		[Token(Token = "0x6000CEF")]
		 get { } //Length: 27
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700023E")]
	public double4 yzyx
	{
		[Address(RVA = "0x2AAB770", Offset = "0x2AAAB70", Length = "0x22")]
		[Token(Token = "0x6000CBA")]
		 get { } //Length: 34
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700023F")]
	public double4 yzyy
	{
		[Address(RVA = "0x2AAB7A0", Offset = "0x2AAABA0", Length = "0x1F")]
		[Token(Token = "0x6000CBB")]
		 get { } //Length: 31
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000240")]
	public double4 yzyz
	{
		[Address(RVA = "0x2AAB7C0", Offset = "0x2AAABC0", Length = "0x23")]
		[Token(Token = "0x6000CBC")]
		 get { } //Length: 35
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000270")]
	public double3 yzz
	{
		[Address(RVA = "0x2AAB7F0", Offset = "0x2AAABF0", Length = "0x17")]
		[Token(Token = "0x6000CF0")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000241")]
	public double4 yzzx
	{
		[Address(RVA = "0x2AAB810", Offset = "0x2AAAC10", Length = "0x1E")]
		[Token(Token = "0x6000CBD")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000242")]
	public double4 yzzy
	{
		[Address(RVA = "0x2AAB830", Offset = "0x2AAAC30", Length = "0x1F")]
		[Token(Token = "0x6000CBE")]
		 get { } //Length: 31
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000243")]
	public double4 yzzz
	{
		[Address(RVA = "0x2AAB850", Offset = "0x2AAAC50", Length = "0x1B")]
		[Token(Token = "0x6000CBF")]
		 get { } //Length: 27
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000280")]
	public double2 zx
	{
		[Address(RVA = "0x2AAB870", Offset = "0x2AAAC70", Length = "0x12")]
		[Token(Token = "0x6000D06")]
		 get { } //Length: 18
		[Address(RVA = "0x2AAC6E0", Offset = "0x2AABAE0", Length = "0xF")]
		[Token(Token = "0x6000D07")]
		 set { } //Length: 15
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000271")]
	public double3 zxx
	{
		[Address(RVA = "0x2AAB890", Offset = "0x2AAAC90", Length = "0x16")]
		[Token(Token = "0x6000CF1")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000244")]
	public double4 zxxx
	{
		[Address(RVA = "0x2AAB8B0", Offset = "0x2AAACB0", Length = "0x1A")]
		[Token(Token = "0x6000CC0")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000245")]
	public double4 zxxy
	{
		[Address(RVA = "0x2AAB8D0", Offset = "0x2AAACD0", Length = "0x1E")]
		[Token(Token = "0x6000CC1")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000246")]
	public double4 zxxz
	{
		[Address(RVA = "0x2AAB8F0", Offset = "0x2AAACF0", Length = "0x1E")]
		[Token(Token = "0x6000CC2")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000272")]
	public double3 zxy
	{
		[Address(RVA = "0x2AAB910", Offset = "0x2AAAD10", Length = "0x1A")]
		[Token(Token = "0x6000CF2")]
		 get { } //Length: 26
		[Address(RVA = "0x2AAC6F0", Offset = "0x2AABAF0", Length = "0x17")]
		[Token(Token = "0x6000CF3")]
		 set { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000247")]
	public double4 zxyx
	{
		[Address(RVA = "0x2AAB930", Offset = "0x2AAAD30", Length = "0x21")]
		[Token(Token = "0x6000CC3")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000248")]
	public double4 zxyy
	{
		[Address(RVA = "0x2AAB960", Offset = "0x2AAAD60", Length = "0x1E")]
		[Token(Token = "0x6000CC4")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000249")]
	public double4 zxyz
	{
		[Address(RVA = "0x2AAB980", Offset = "0x2AAAD80", Length = "0x22")]
		[Token(Token = "0x6000CC5")]
		 get { } //Length: 34
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000273")]
	public double3 zxz
	{
		[Address(RVA = "0x2AAB9B0", Offset = "0x2AAADB0", Length = "0x1A")]
		[Token(Token = "0x6000CF4")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700024A")]
	public double4 zxzx
	{
		[Address(RVA = "0x2AAB9D0", Offset = "0x2AAADD0", Length = "0x21")]
		[Token(Token = "0x6000CC6")]
		 get { } //Length: 33
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700024B")]
	public double4 zxzy
	{
		[Address(RVA = "0x2AABA00", Offset = "0x2AAAE00", Length = "0x22")]
		[Token(Token = "0x6000CC7")]
		 get { } //Length: 34
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700024C")]
	public double4 zxzz
	{
		[Address(RVA = "0x2AABA30", Offset = "0x2AAAE30", Length = "0x1E")]
		[Token(Token = "0x6000CC8")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000281")]
	public double2 zy
	{
		[Address(RVA = "0x2AABA50", Offset = "0x2AAAE50", Length = "0x13")]
		[Token(Token = "0x6000D08")]
		 get { } //Length: 19
		[Address(RVA = "0x2AAC710", Offset = "0x2AABB10", Length = "0x10")]
		[Token(Token = "0x6000D09")]
		 set { } //Length: 16
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000274")]
	public double3 zyx
	{
		[Address(RVA = "0x2AABA70", Offset = "0x2AAAE70", Length = "0x1A")]
		[Token(Token = "0x6000CF5")]
		 get { } //Length: 26
		[Address(RVA = "0x2AAC720", Offset = "0x2AABB20", Length = "0x17")]
		[Token(Token = "0x6000CF6")]
		 set { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700024D")]
	public double4 zyxx
	{
		[Address(RVA = "0x2AABA90", Offset = "0x2AAAE90", Length = "0x1E")]
		[Token(Token = "0x6000CC9")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700024E")]
	public double4 zyxy
	{
		[Address(RVA = "0x2AABAB0", Offset = "0x2AAAEB0", Length = "0x22")]
		[Token(Token = "0x6000CCA")]
		 get { } //Length: 34
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700024F")]
	public double4 zyxz
	{
		[Address(RVA = "0x2AABAE0", Offset = "0x2AAAEE0", Length = "0x22")]
		[Token(Token = "0x6000CCB")]
		 get { } //Length: 34
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000275")]
	public double3 zyy
	{
		[Address(RVA = "0x2AABB10", Offset = "0x2AAAF10", Length = "0x17")]
		[Token(Token = "0x6000CF7")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000250")]
	public double4 zyyx
	{
		[Address(RVA = "0x2AABB30", Offset = "0x2AAAF30", Length = "0x1E")]
		[Token(Token = "0x6000CCC")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000251")]
	public double4 zyyy
	{
		[Address(RVA = "0x2AABB50", Offset = "0x2AAAF50", Length = "0x1B")]
		[Token(Token = "0x6000CCD")]
		 get { } //Length: 27
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000252")]
	public double4 zyyz
	{
		[Address(RVA = "0x2AABB70", Offset = "0x2AAAF70", Length = "0x1F")]
		[Token(Token = "0x6000CCE")]
		 get { } //Length: 31
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000276")]
	public double3 zyz
	{
		[Address(RVA = "0x2AABB90", Offset = "0x2AAAF90", Length = "0x1B")]
		[Token(Token = "0x6000CF8")]
		 get { } //Length: 27
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000253")]
	public double4 zyzx
	{
		[Address(RVA = "0x2AABBB0", Offset = "0x2AAAFB0", Length = "0x22")]
		[Token(Token = "0x6000CCF")]
		 get { } //Length: 34
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000254")]
	public double4 zyzy
	{
		[Address(RVA = "0x2AABBE0", Offset = "0x2AAAFE0", Length = "0x23")]
		[Token(Token = "0x6000CD0")]
		 get { } //Length: 35
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000255")]
	public double4 zyzz
	{
		[Address(RVA = "0x2AABC10", Offset = "0x2AAB010", Length = "0x1F")]
		[Token(Token = "0x6000CD1")]
		 get { } //Length: 31
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000282")]
	public double2 zz
	{
		[Address(RVA = "0x2AABC30", Offset = "0x2AAB030", Length = "0xF")]
		[Token(Token = "0x6000D0A")]
		 get { } //Length: 15
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000277")]
	public double3 zzx
	{
		[Address(RVA = "0x2AABC40", Offset = "0x2AAB040", Length = "0x16")]
		[Token(Token = "0x6000CF9")]
		 get { } //Length: 22
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000256")]
	public double4 zzxx
	{
		[Address(RVA = "0x2AABC60", Offset = "0x2AAB060", Length = "0x1A")]
		[Token(Token = "0x6000CD2")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000257")]
	public double4 zzxy
	{
		[Address(RVA = "0x2AABC80", Offset = "0x2AAB080", Length = "0x1E")]
		[Token(Token = "0x6000CD3")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000258")]
	public double4 zzxz
	{
		[Address(RVA = "0x2AABCA0", Offset = "0x2AAB0A0", Length = "0x1E")]
		[Token(Token = "0x6000CD4")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000278")]
	public double3 zzy
	{
		[Address(RVA = "0x2AABCC0", Offset = "0x2AAB0C0", Length = "0x17")]
		[Token(Token = "0x6000CFA")]
		 get { } //Length: 23
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000259")]
	public double4 zzyx
	{
		[Address(RVA = "0x2AABCE0", Offset = "0x2AAB0E0", Length = "0x1E")]
		[Token(Token = "0x6000CD5")]
		 get { } //Length: 30
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700025A")]
	public double4 zzyy
	{
		[Address(RVA = "0x2AABD00", Offset = "0x2AAB100", Length = "0x1B")]
		[Token(Token = "0x6000CD6")]
		 get { } //Length: 27
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700025B")]
	public double4 zzyz
	{
		[Address(RVA = "0x2AABD20", Offset = "0x2AAB120", Length = "0x1F")]
		[Token(Token = "0x6000CD7")]
		 get { } //Length: 31
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x17000279")]
	public double3 zzz
	{
		[Address(RVA = "0x2AABD40", Offset = "0x2AAB140", Length = "0x13")]
		[Token(Token = "0x6000CFB")]
		 get { } //Length: 19
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700025C")]
	public double4 zzzx
	{
		[Address(RVA = "0x2AABD60", Offset = "0x2AAB160", Length = "0x1A")]
		[Token(Token = "0x6000CD8")]
		 get { } //Length: 26
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700025D")]
	public double4 zzzy
	{
		[Address(RVA = "0x2AABD80", Offset = "0x2AAB180", Length = "0x1B")]
		[Token(Token = "0x6000CD9")]
		 get { } //Length: 27
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Token(Token = "0x1700025E")]
	public double4 zzzz
	{
		[Address(RVA = "0x2AABDA0", Offset = "0x2AAB1A0", Length = "0x17")]
		[Token(Token = "0x6000CDA")]
		 get { } //Length: 23
	}

	[Address(RVA = "0x2AAB160", Offset = "0x2AAA560", Length = "0xF")]
	[Token(Token = "0x6000C4B")]
	public double3(double x, double y, double z) { }

	[Address(RVA = "0x2AAAFA0", Offset = "0x2AAA3A0", Length = "0x14")]
	[Token(Token = "0x6000C59")]
	public double3(float3 v) { }

	[Address(RVA = "0x2AAAFC0", Offset = "0x2AAA3C0", Length = "0x1A")]
	[Token(Token = "0x6000C58")]
	public double3(float v) { }

	[Address(RVA = "0x2A17AB0", Offset = "0x2A16EB0", Length = "0x14B")]
	[Token(Token = "0x6000C57")]
	public double3(half3 v) { }

	[Address(RVA = "0x2A17980", Offset = "0x2A16D80", Length = "0x12F")]
	[Token(Token = "0x6000C56")]
	public double3(half v) { }

	[Address(RVA = "0x2AAB130", Offset = "0x2AAA530", Length = "0x2F")]
	[Token(Token = "0x6000C55")]
	public double3(uint3 v) { }

	[Address(RVA = "0x2AAB000", Offset = "0x2AAA400", Length = "0x16")]
	[Token(Token = "0x6000C53")]
	public double3(int3 v) { }

	[Address(RVA = "0x2AAB100", Offset = "0x2AAA500", Length = "0x2D")]
	[Token(Token = "0x6000C54")]
	public double3(uint v) { }

	[Address(RVA = "0x2AAB080", Offset = "0x2AAA480", Length = "0x41")]
	[Token(Token = "0x6000C51")]
	public double3(bool3 v) { }

	[Address(RVA = "0x2AAB0E0", Offset = "0x2AAA4E0", Length = "0x20")]
	[Token(Token = "0x6000C50")]
	public double3(bool v) { }

	[Address(RVA = "0x2AAB0D0", Offset = "0x2AAA4D0", Length = "0xD")]
	[Token(Token = "0x6000C4F")]
	public double3(double v) { }

	[Address(RVA = "0x2AAB060", Offset = "0x2AAA460", Length = "0x17")]
	[Token(Token = "0x6000C4E")]
	public double3(double3 xyz) { }

	[Address(RVA = "0x2AAAFE0", Offset = "0x2AAA3E0", Length = "0x14")]
	[Token(Token = "0x6000C4D")]
	public double3(double2 xy, double z) { }

	[Address(RVA = "0x2AAB020", Offset = "0x2AAA420", Length = "0x14")]
	[Token(Token = "0x6000C4C")]
	public double3(double x, double2 yz) { }

	[Address(RVA = "0x2AAB040", Offset = "0x2AAA440", Length = "0x1E")]
	[Token(Token = "0x6000C52")]
	public double3(int v) { }

	[Address(RVA = "0x2AAAD30", Offset = "0x2AAA130", Length = "0xB4")]
	[Token(Token = "0x6000D0E")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x2AAADF0", Offset = "0x2AAA1F0", Length = "0x3A")]
	[Token(Token = "0x6000D0D")]
	public override bool Equals(double3 rhs) { }

	[Address(RVA = "0x9E0CD0", Offset = "0x9E00D0", Length = "0x9")]
	[Token(Token = "0x6000D0B")]
	public double get_Item(int index) { }

	[Address(RVA = "0x27FB7F0", Offset = "0x27FABF0", Length = "0xE")]
	[Token(Token = "0x6000CFC")]
	public double2 get_xx() { }

	[Address(RVA = "0x2AA4850", Offset = "0x2AA3C50", Length = "0x12")]
	[Token(Token = "0x6000CDB")]
	public double3 get_xxx() { }

	[Address(RVA = "0x2AA4870", Offset = "0x2AA3C70", Length = "0x16")]
	[Token(Token = "0x6000C8A")]
	public double4 get_xxxx() { }

	[Address(RVA = "0x2AA4890", Offset = "0x2AA3C90", Length = "0x1A")]
	[Token(Token = "0x6000C8B")]
	public double4 get_xxxy() { }

	[Address(RVA = "0x2AAB170", Offset = "0x2AAA570", Length = "0x1A")]
	[Token(Token = "0x6000C8C")]
	public double4 get_xxxz() { }

	[Address(RVA = "0x2AA48B0", Offset = "0x2AA3CB0", Length = "0x16")]
	[Token(Token = "0x6000CDC")]
	public double3 get_xxy() { }

	[Address(RVA = "0x2AA48D0", Offset = "0x2AA3CD0", Length = "0x1D")]
	[Token(Token = "0x6000C8D")]
	public double4 get_xxyx() { }

	[Address(RVA = "0x2AA48F0", Offset = "0x2AA3CF0", Length = "0x1A")]
	[Token(Token = "0x6000C8E")]
	public double4 get_xxyy() { }

	[Address(RVA = "0x2AAB190", Offset = "0x2AAA590", Length = "0x1E")]
	[Token(Token = "0x6000C8F")]
	public double4 get_xxyz() { }

	[Address(RVA = "0x2AAB1B0", Offset = "0x2AAA5B0", Length = "0x16")]
	[Token(Token = "0x6000CDD")]
	public double3 get_xxz() { }

	[Address(RVA = "0x2AAB1D0", Offset = "0x2AAA5D0", Length = "0x1D")]
	[Token(Token = "0x6000C90")]
	public double4 get_xxzx() { }

	[Address(RVA = "0x2AAB1F0", Offset = "0x2AAA5F0", Length = "0x1E")]
	[Token(Token = "0x6000C91")]
	public double4 get_xxzy() { }

	[Address(RVA = "0x27EFAC0", Offset = "0x27EEEC0", Length = "0x1A")]
	[Token(Token = "0x6000C92")]
	public double4 get_xxzz() { }

	[Address(RVA = "0x2AA4910", Offset = "0x2AA3D10", Length = "0x12")]
	[Token(Token = "0x6000CFD")]
	public double2 get_xy() { }

	[Address(RVA = "0x2AA4930", Offset = "0x2AA3D30", Length = "0x19")]
	[Token(Token = "0x6000CDE")]
	public double3 get_xyx() { }

	[Address(RVA = "0x2AA4950", Offset = "0x2AA3D50", Length = "0x1D")]
	[Token(Token = "0x6000C93")]
	public double4 get_xyxx() { }

	[Address(RVA = "0x2AA4970", Offset = "0x2AA3D70", Length = "0x21")]
	[Token(Token = "0x6000C94")]
	public double4 get_xyxy() { }

	[Address(RVA = "0x2AAB210", Offset = "0x2AAA610", Length = "0x21")]
	[Token(Token = "0x6000C95")]
	public double4 get_xyxz() { }

	[Address(RVA = "0x2AA49A0", Offset = "0x2AA3DA0", Length = "0x16")]
	[Token(Token = "0x6000CDF")]
	public double3 get_xyy() { }

	[Address(RVA = "0x2AA49C0", Offset = "0x2AA3DC0", Length = "0x1D")]
	[Token(Token = "0x6000C96")]
	public double4 get_xyyx() { }

	[Address(RVA = "0x2AA49E0", Offset = "0x2AA3DE0", Length = "0x1A")]
	[Token(Token = "0x6000C97")]
	public double4 get_xyyy() { }

	[Address(RVA = "0x2AAB240", Offset = "0x2AAA640", Length = "0x1E")]
	[Token(Token = "0x6000C98")]
	public double4 get_xyyz() { }

	[Address(RVA = "0x2AAB260", Offset = "0x2AAA660", Length = "0x1A")]
	[Token(Token = "0x6000CE0")]
	public double3 get_xyz() { }

	[Address(RVA = "0x2AAB280", Offset = "0x2AAA680", Length = "0x21")]
	[Token(Token = "0x6000C99")]
	public double4 get_xyzx() { }

	[Address(RVA = "0x2AAB2B0", Offset = "0x2AAA6B0", Length = "0x22")]
	[Token(Token = "0x6000C9A")]
	public double4 get_xyzy() { }

	[Address(RVA = "0x2AAB2E0", Offset = "0x2AAA6E0", Length = "0x1E")]
	[Token(Token = "0x6000C9B")]
	public double4 get_xyzz() { }

	[Address(RVA = "0x2AAB300", Offset = "0x2AAA700", Length = "0x12")]
	[Token(Token = "0x6000CFF")]
	public double2 get_xz() { }

	[Address(RVA = "0x2AAB320", Offset = "0x2AAA720", Length = "0x19")]
	[Token(Token = "0x6000CE2")]
	public double3 get_xzx() { }

	[Address(RVA = "0x2AAB340", Offset = "0x2AAA740", Length = "0x1D")]
	[Token(Token = "0x6000C9C")]
	public double4 get_xzxx() { }

	[Address(RVA = "0x2AAB360", Offset = "0x2AAA760", Length = "0x21")]
	[Token(Token = "0x6000C9D")]
	public double4 get_xzxy() { }

	[Address(RVA = "0x2AAB390", Offset = "0x2AAA790", Length = "0x21")]
	[Token(Token = "0x6000C9E")]
	public double4 get_xzxz() { }

	[Address(RVA = "0x2AAB3C0", Offset = "0x2AAA7C0", Length = "0x1A")]
	[Token(Token = "0x6000CE3")]
	public double3 get_xzy() { }

	[Address(RVA = "0x2AAB3E0", Offset = "0x2AAA7E0", Length = "0x21")]
	[Token(Token = "0x6000C9F")]
	public double4 get_xzyx() { }

	[Address(RVA = "0x2AAB410", Offset = "0x2AAA810", Length = "0x1E")]
	[Token(Token = "0x6000CA0")]
	public double4 get_xzyy() { }

	[Address(RVA = "0x2AAB430", Offset = "0x2AAA830", Length = "0x22")]
	[Token(Token = "0x6000CA1")]
	public double4 get_xzyz() { }

	[Address(RVA = "0x2AAB460", Offset = "0x2AAA860", Length = "0x16")]
	[Token(Token = "0x6000CE5")]
	public double3 get_xzz() { }

	[Address(RVA = "0x2AAB480", Offset = "0x2AAA880", Length = "0x1D")]
	[Token(Token = "0x6000CA2")]
	public double4 get_xzzx() { }

	[Address(RVA = "0x2AAB4A0", Offset = "0x2AAA8A0", Length = "0x1E")]
	[Token(Token = "0x6000CA3")]
	public double4 get_xzzy() { }

	[Address(RVA = "0x2AAB4C0", Offset = "0x2AAA8C0", Length = "0x1A")]
	[Token(Token = "0x6000CA4")]
	public double4 get_xzzz() { }

	[Address(RVA = "0x2AA4A00", Offset = "0x2AA3E00", Length = "0x12")]
	[Token(Token = "0x6000D01")]
	public double2 get_yx() { }

	[Address(RVA = "0x2AA4A20", Offset = "0x2AA3E20", Length = "0x16")]
	[Token(Token = "0x6000CE6")]
	public double3 get_yxx() { }

	[Address(RVA = "0x2AA4A40", Offset = "0x2AA3E40", Length = "0x1A")]
	[Token(Token = "0x6000CA5")]
	public double4 get_yxxx() { }

	[Address(RVA = "0x2AA4A60", Offset = "0x2AA3E60", Length = "0x1E")]
	[Token(Token = "0x6000CA6")]
	public double4 get_yxxy() { }

	[Address(RVA = "0x2AAB4E0", Offset = "0x2AAA8E0", Length = "0x1E")]
	[Token(Token = "0x6000CA7")]
	public double4 get_yxxz() { }

	[Address(RVA = "0x2AA4A80", Offset = "0x2AA3E80", Length = "0x1A")]
	[Token(Token = "0x6000CE7")]
	public double3 get_yxy() { }

	[Address(RVA = "0x2AA4AA0", Offset = "0x2AA3EA0", Length = "0x21")]
	[Token(Token = "0x6000CA8")]
	public double4 get_yxyx() { }

	[Address(RVA = "0x2AA4AD0", Offset = "0x2AA3ED0", Length = "0x1E")]
	[Token(Token = "0x6000CA9")]
	public double4 get_yxyy() { }

	[Address(RVA = "0x2AAB500", Offset = "0x2AAA900", Length = "0x22")]
	[Token(Token = "0x6000CAA")]
	public double4 get_yxyz() { }

	[Address(RVA = "0x2AAB530", Offset = "0x2AAA930", Length = "0x1A")]
	[Token(Token = "0x6000CE8")]
	public double3 get_yxz() { }

	[Address(RVA = "0x2AAB550", Offset = "0x2AAA950", Length = "0x21")]
	[Token(Token = "0x6000CAB")]
	public double4 get_yxzx() { }

	[Address(RVA = "0x2AAB580", Offset = "0x2AAA980", Length = "0x22")]
	[Token(Token = "0x6000CAC")]
	public double4 get_yxzy() { }

	[Address(RVA = "0x2AAB5B0", Offset = "0x2AAA9B0", Length = "0x1E")]
	[Token(Token = "0x6000CAD")]
	public double4 get_yxzz() { }

	[Address(RVA = "0x2AA4AF0", Offset = "0x2AA3EF0", Length = "0xF")]
	[Token(Token = "0x6000D03")]
	public double2 get_yy() { }

	[Address(RVA = "0x2AA4B00", Offset = "0x2AA3F00", Length = "0x16")]
	[Token(Token = "0x6000CEA")]
	public double3 get_yyx() { }

	[Address(RVA = "0x2AA4B20", Offset = "0x2AA3F20", Length = "0x1A")]
	[Token(Token = "0x6000CAE")]
	public double4 get_yyxx() { }

	[Address(RVA = "0x2AA4B40", Offset = "0x2AA3F40", Length = "0x1E")]
	[Token(Token = "0x6000CAF")]
	public double4 get_yyxy() { }

	[Address(RVA = "0x2AAB5D0", Offset = "0x2AAA9D0", Length = "0x1E")]
	[Token(Token = "0x6000CB0")]
	public double4 get_yyxz() { }

	[Address(RVA = "0x2AA4B60", Offset = "0x2AA3F60", Length = "0x13")]
	[Token(Token = "0x6000CEB")]
	public double3 get_yyy() { }

	[Address(RVA = "0x2AA4B80", Offset = "0x2AA3F80", Length = "0x1A")]
	[Token(Token = "0x6000CB1")]
	public double4 get_yyyx() { }

	[Address(RVA = "0x2AA4BA0", Offset = "0x2AA3FA0", Length = "0x17")]
	[Token(Token = "0x6000CB2")]
	public double4 get_yyyy() { }

	[Address(RVA = "0x2AAB5F0", Offset = "0x2AAA9F0", Length = "0x1B")]
	[Token(Token = "0x6000CB3")]
	public double4 get_yyyz() { }

	[Address(RVA = "0x2AAB610", Offset = "0x2AAAA10", Length = "0x17")]
	[Token(Token = "0x6000CEC")]
	public double3 get_yyz() { }

	[Address(RVA = "0x2AAB630", Offset = "0x2AAAA30", Length = "0x1E")]
	[Token(Token = "0x6000CB4")]
	public double4 get_yyzx() { }

	[Address(RVA = "0x2AAB650", Offset = "0x2AAAA50", Length = "0x1F")]
	[Token(Token = "0x6000CB5")]
	public double4 get_yyzy() { }

	[Address(RVA = "0x2AAB670", Offset = "0x2AAAA70", Length = "0x1B")]
	[Token(Token = "0x6000CB6")]
	public double4 get_yyzz() { }

	[Address(RVA = "0x2AAB690", Offset = "0x2AAAA90", Length = "0x13")]
	[Token(Token = "0x6000D04")]
	public double2 get_yz() { }

	[Address(RVA = "0x2AAB6B0", Offset = "0x2AAAAB0", Length = "0x1A")]
	[Token(Token = "0x6000CED")]
	public double3 get_yzx() { }

	[Address(RVA = "0x2AAB6D0", Offset = "0x2AAAAD0", Length = "0x1E")]
	[Token(Token = "0x6000CB7")]
	public double4 get_yzxx() { }

	[Address(RVA = "0x2AAB6F0", Offset = "0x2AAAAF0", Length = "0x22")]
	[Token(Token = "0x6000CB8")]
	public double4 get_yzxy() { }

	[Address(RVA = "0x2AAB720", Offset = "0x2AAAB20", Length = "0x22")]
	[Token(Token = "0x6000CB9")]
	public double4 get_yzxz() { }

	[Address(RVA = "0x2AAB750", Offset = "0x2AAAB50", Length = "0x1B")]
	[Token(Token = "0x6000CEF")]
	public double3 get_yzy() { }

	[Address(RVA = "0x2AAB770", Offset = "0x2AAAB70", Length = "0x22")]
	[Token(Token = "0x6000CBA")]
	public double4 get_yzyx() { }

	[Address(RVA = "0x2AAB7A0", Offset = "0x2AAABA0", Length = "0x1F")]
	[Token(Token = "0x6000CBB")]
	public double4 get_yzyy() { }

	[Address(RVA = "0x2AAB7C0", Offset = "0x2AAABC0", Length = "0x23")]
	[Token(Token = "0x6000CBC")]
	public double4 get_yzyz() { }

	[Address(RVA = "0x2AAB7F0", Offset = "0x2AAABF0", Length = "0x17")]
	[Token(Token = "0x6000CF0")]
	public double3 get_yzz() { }

	[Address(RVA = "0x2AAB810", Offset = "0x2AAAC10", Length = "0x1E")]
	[Token(Token = "0x6000CBD")]
	public double4 get_yzzx() { }

	[Address(RVA = "0x2AAB830", Offset = "0x2AAAC30", Length = "0x1F")]
	[Token(Token = "0x6000CBE")]
	public double4 get_yzzy() { }

	[Address(RVA = "0x2AAB850", Offset = "0x2AAAC50", Length = "0x1B")]
	[Token(Token = "0x6000CBF")]
	public double4 get_yzzz() { }

	[Address(RVA = "0x2AAB870", Offset = "0x2AAAC70", Length = "0x12")]
	[Token(Token = "0x6000D06")]
	public double2 get_zx() { }

	[Address(RVA = "0x2AAB890", Offset = "0x2AAAC90", Length = "0x16")]
	[Token(Token = "0x6000CF1")]
	public double3 get_zxx() { }

	[Address(RVA = "0x2AAB8B0", Offset = "0x2AAACB0", Length = "0x1A")]
	[Token(Token = "0x6000CC0")]
	public double4 get_zxxx() { }

	[Address(RVA = "0x2AAB8D0", Offset = "0x2AAACD0", Length = "0x1E")]
	[Token(Token = "0x6000CC1")]
	public double4 get_zxxy() { }

	[Address(RVA = "0x2AAB8F0", Offset = "0x2AAACF0", Length = "0x1E")]
	[Token(Token = "0x6000CC2")]
	public double4 get_zxxz() { }

	[Address(RVA = "0x2AAB910", Offset = "0x2AAAD10", Length = "0x1A")]
	[Token(Token = "0x6000CF2")]
	public double3 get_zxy() { }

	[Address(RVA = "0x2AAB930", Offset = "0x2AAAD30", Length = "0x21")]
	[Token(Token = "0x6000CC3")]
	public double4 get_zxyx() { }

	[Address(RVA = "0x2AAB960", Offset = "0x2AAAD60", Length = "0x1E")]
	[Token(Token = "0x6000CC4")]
	public double4 get_zxyy() { }

	[Address(RVA = "0x2AAB980", Offset = "0x2AAAD80", Length = "0x22")]
	[Token(Token = "0x6000CC5")]
	public double4 get_zxyz() { }

	[Address(RVA = "0x2AAB9B0", Offset = "0x2AAADB0", Length = "0x1A")]
	[Token(Token = "0x6000CF4")]
	public double3 get_zxz() { }

	[Address(RVA = "0x2AAB9D0", Offset = "0x2AAADD0", Length = "0x21")]
	[Token(Token = "0x6000CC6")]
	public double4 get_zxzx() { }

	[Address(RVA = "0x2AABA00", Offset = "0x2AAAE00", Length = "0x22")]
	[Token(Token = "0x6000CC7")]
	public double4 get_zxzy() { }

	[Address(RVA = "0x2AABA30", Offset = "0x2AAAE30", Length = "0x1E")]
	[Token(Token = "0x6000CC8")]
	public double4 get_zxzz() { }

	[Address(RVA = "0x2AABA50", Offset = "0x2AAAE50", Length = "0x13")]
	[Token(Token = "0x6000D08")]
	public double2 get_zy() { }

	[Address(RVA = "0x2AABA70", Offset = "0x2AAAE70", Length = "0x1A")]
	[Token(Token = "0x6000CF5")]
	public double3 get_zyx() { }

	[Address(RVA = "0x2AABA90", Offset = "0x2AAAE90", Length = "0x1E")]
	[Token(Token = "0x6000CC9")]
	public double4 get_zyxx() { }

	[Address(RVA = "0x2AABAB0", Offset = "0x2AAAEB0", Length = "0x22")]
	[Token(Token = "0x6000CCA")]
	public double4 get_zyxy() { }

	[Address(RVA = "0x2AABAE0", Offset = "0x2AAAEE0", Length = "0x22")]
	[Token(Token = "0x6000CCB")]
	public double4 get_zyxz() { }

	[Address(RVA = "0x2AABB10", Offset = "0x2AAAF10", Length = "0x17")]
	[Token(Token = "0x6000CF7")]
	public double3 get_zyy() { }

	[Address(RVA = "0x2AABB30", Offset = "0x2AAAF30", Length = "0x1E")]
	[Token(Token = "0x6000CCC")]
	public double4 get_zyyx() { }

	[Address(RVA = "0x2AABB50", Offset = "0x2AAAF50", Length = "0x1B")]
	[Token(Token = "0x6000CCD")]
	public double4 get_zyyy() { }

	[Address(RVA = "0x2AABB70", Offset = "0x2AAAF70", Length = "0x1F")]
	[Token(Token = "0x6000CCE")]
	public double4 get_zyyz() { }

	[Address(RVA = "0x2AABB90", Offset = "0x2AAAF90", Length = "0x1B")]
	[Token(Token = "0x6000CF8")]
	public double3 get_zyz() { }

	[Address(RVA = "0x2AABBB0", Offset = "0x2AAAFB0", Length = "0x22")]
	[Token(Token = "0x6000CCF")]
	public double4 get_zyzx() { }

	[Address(RVA = "0x2AABBE0", Offset = "0x2AAAFE0", Length = "0x23")]
	[Token(Token = "0x6000CD0")]
	public double4 get_zyzy() { }

	[Address(RVA = "0x2AABC10", Offset = "0x2AAB010", Length = "0x1F")]
	[Token(Token = "0x6000CD1")]
	public double4 get_zyzz() { }

	[Address(RVA = "0x2AABC30", Offset = "0x2AAB030", Length = "0xF")]
	[Token(Token = "0x6000D0A")]
	public double2 get_zz() { }

	[Address(RVA = "0x2AABC40", Offset = "0x2AAB040", Length = "0x16")]
	[Token(Token = "0x6000CF9")]
	public double3 get_zzx() { }

	[Address(RVA = "0x2AABC60", Offset = "0x2AAB060", Length = "0x1A")]
	[Token(Token = "0x6000CD2")]
	public double4 get_zzxx() { }

	[Address(RVA = "0x2AABC80", Offset = "0x2AAB080", Length = "0x1E")]
	[Token(Token = "0x6000CD3")]
	public double4 get_zzxy() { }

	[Address(RVA = "0x2AABCA0", Offset = "0x2AAB0A0", Length = "0x1E")]
	[Token(Token = "0x6000CD4")]
	public double4 get_zzxz() { }

	[Address(RVA = "0x2AABCC0", Offset = "0x2AAB0C0", Length = "0x17")]
	[Token(Token = "0x6000CFA")]
	public double3 get_zzy() { }

	[Address(RVA = "0x2AABCE0", Offset = "0x2AAB0E0", Length = "0x1E")]
	[Token(Token = "0x6000CD5")]
	public double4 get_zzyx() { }

	[Address(RVA = "0x2AABD00", Offset = "0x2AAB100", Length = "0x1B")]
	[Token(Token = "0x6000CD6")]
	public double4 get_zzyy() { }

	[Address(RVA = "0x2AABD20", Offset = "0x2AAB120", Length = "0x1F")]
	[Token(Token = "0x6000CD7")]
	public double4 get_zzyz() { }

	[Address(RVA = "0x2AABD40", Offset = "0x2AAB140", Length = "0x13")]
	[Token(Token = "0x6000CFB")]
	public double3 get_zzz() { }

	[Address(RVA = "0x2AABD60", Offset = "0x2AAB160", Length = "0x1A")]
	[Token(Token = "0x6000CD8")]
	public double4 get_zzzx() { }

	[Address(RVA = "0x2AABD80", Offset = "0x2AAB180", Length = "0x1B")]
	[Token(Token = "0x6000CD9")]
	public double4 get_zzzy() { }

	[Address(RVA = "0x2AABDA0", Offset = "0x2AAB1A0", Length = "0x17")]
	[Token(Token = "0x6000CDA")]
	public double4 get_zzzz() { }

	[Address(RVA = "0x2A3CAE0", Offset = "0x2A3BEE0", Length = "0x6C")]
	[Token(Token = "0x6000D0F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2AABDC0", Offset = "0x2AAB1C0", Length = "0x1E")]
	[Token(Token = "0x6000C6A")]
	public static double3 op_Addition(double lhs, double3 rhs) { }

	[Address(RVA = "0x2AABDE0", Offset = "0x2AAB1E0", Length = "0x1C")]
	[Token(Token = "0x6000C69")]
	public static double3 op_Addition(double3 lhs, double rhs) { }

	[Address(RVA = "0x2AABE00", Offset = "0x2AAB200", Length = "0x31")]
	[Token(Token = "0x6000C68")]
	public static double3 op_Addition(double3 lhs, double3 rhs) { }

	[Address(RVA = "0x2AABE40", Offset = "0x2AAB240", Length = "0x23")]
	[Token(Token = "0x6000C75")]
	public static double3 op_Decrement(double3 val) { }

	[Address(RVA = "0x2AABED0", Offset = "0x2AAB2D0", Length = "0x29")]
	[Token(Token = "0x6000C70")]
	public static double3 op_Division(double lhs, double3 rhs) { }

	[Address(RVA = "0x2AABE70", Offset = "0x2AAB270", Length = "0x31")]
	[Token(Token = "0x6000C6E")]
	public static double3 op_Division(double3 lhs, double3 rhs) { }

	[Address(RVA = "0x2AABEB0", Offset = "0x2AAB2B0", Length = "0x20")]
	[Token(Token = "0x6000C6F")]
	public static double3 op_Division(double3 lhs, double rhs) { }

	[Address(RVA = "0x2AABFC0", Offset = "0x2AAB3C0", Length = "0x49")]
	[Token(Token = "0x6000C86")]
	public static bool3 op_Equality(double lhs, double3 rhs) { }

	[Address(RVA = "0x2AABF60", Offset = "0x2AAB360", Length = "0x52")]
	[Token(Token = "0x6000C85")]
	public static bool3 op_Equality(double3 lhs, double rhs) { }

	[Address(RVA = "0x2AABF00", Offset = "0x2AAB300", Length = "0x57")]
	[Token(Token = "0x6000C84")]
	public static bool3 op_Equality(double3 lhs, double3 rhs) { }

	[Address(RVA = "0x2A2DD80", Offset = "0x2A2D180", Length = "0x4D")]
	[Token(Token = "0x6000C5C")]
	public static double3 op_Explicit(bool3 v) { }

	[Address(RVA = "0x2A2DED0", Offset = "0x2A2D2D0", Length = "0x23")]
	[Token(Token = "0x6000C5B")]
	public static double3 op_Explicit(bool v) { }

	[Address(RVA = "0x2AAC0B0", Offset = "0x2AAB4B0", Length = "0x2F")]
	[Token(Token = "0x6000C7D")]
	public static bool3 op_GreaterThan(double3 lhs, double rhs) { }

	[Address(RVA = "0x2AAC120", Offset = "0x2AAB520", Length = "0x26")]
	[Token(Token = "0x6000C7E")]
	public static bool3 op_GreaterThan(double lhs, double3 rhs) { }

	[Address(RVA = "0x2AAC0E0", Offset = "0x2AAB4E0", Length = "0x34")]
	[Token(Token = "0x6000C7C")]
	public static bool3 op_GreaterThan(double3 lhs, double3 rhs) { }

	[Address(RVA = "0x2AAC040", Offset = "0x2AAB440", Length = "0x34")]
	[Token(Token = "0x6000C7F")]
	public static bool3 op_GreaterThanOrEqual(double3 lhs, double3 rhs) { }

	[Address(RVA = "0x2AAC080", Offset = "0x2AAB480", Length = "0x2F")]
	[Token(Token = "0x6000C80")]
	public static bool3 op_GreaterThanOrEqual(double3 lhs, double rhs) { }

	[Address(RVA = "0x2AAC010", Offset = "0x2AAB410", Length = "0x26")]
	[Token(Token = "0x6000C81")]
	public static bool3 op_GreaterThanOrEqual(double lhs, double3 rhs) { }

	[Address(RVA = "0x2A2DB80", Offset = "0x2A2CF80", Length = "0x4E")]
	[Token(Token = "0x6000C5E")]
	public static double3 op_Implicit(int3 v) { }

	[Address(RVA = "0x2A2DD20", Offset = "0x2A2D120", Length = "0x30")]
	[Token(Token = "0x6000C5F")]
	public static double3 op_Implicit(uint v) { }

	[Address(RVA = "0x2A2DE80", Offset = "0x2A2D280", Length = "0x2A")]
	[Token(Token = "0x6000C5D")]
	public static double3 op_Implicit(int v) { }

	[Address(RVA = "0x2AAC150", Offset = "0x2AAB550", Length = "0x26")]
	[Token(Token = "0x6000C61")]
	public static double3 op_Implicit(half v) { }

	[Address(RVA = "0x2A2E040", Offset = "0x2A2D440", Length = "0x3B")]
	[Token(Token = "0x6000C64")]
	public static double3 op_Implicit(float3 v) { }

	[Address(RVA = "0x2A2DB50", Offset = "0x2A2CF50", Length = "0x27")]
	[Token(Token = "0x6000C63")]
	public static double3 op_Implicit(float v) { }

	[Address(RVA = "0x2AAC180", Offset = "0x2AAB580", Length = "0x3A")]
	[Token(Token = "0x6000C62")]
	public static double3 op_Implicit(half3 v) { }

	[Address(RVA = "0x2A2DD70", Offset = "0x2A2D170", Length = "0x10")]
	[Token(Token = "0x6000C5A")]
	public static double3 op_Implicit(double v) { }

	[Address(RVA = "0x2A2DDF0", Offset = "0x2A2D1F0", Length = "0x52")]
	[Token(Token = "0x6000C60")]
	public static double3 op_Implicit(uint3 v) { }

	[Address(RVA = "0x2AAC1C0", Offset = "0x2AAB5C0", Length = "0x23")]
	[Token(Token = "0x6000C74")]
	public static double3 op_Increment(double3 val) { }

	[Address(RVA = "0x2AAC1F0", Offset = "0x2AAB5F0", Length = "0x52")]
	[Token(Token = "0x6000C88")]
	public static bool3 op_Inequality(double3 lhs, double rhs) { }

	[Address(RVA = "0x2AAC250", Offset = "0x2AAB650", Length = "0x57")]
	[Token(Token = "0x6000C87")]
	public static bool3 op_Inequality(double3 lhs, double3 rhs) { }

	[Address(RVA = "0x2AAC2B0", Offset = "0x2AAB6B0", Length = "0x49")]
	[Token(Token = "0x6000C89")]
	public static bool3 op_Inequality(double lhs, double3 rhs) { }

	[Address(RVA = "0x2AAC3B0", Offset = "0x2AAB7B0", Length = "0x34")]
	[Token(Token = "0x6000C76")]
	public static bool3 op_LessThan(double3 lhs, double3 rhs) { }

	[Address(RVA = "0x2AAC420", Offset = "0x2AAB820", Length = "0x32")]
	[Token(Token = "0x6000C78")]
	public static bool3 op_LessThan(double lhs, double3 rhs) { }

	[Address(RVA = "0x2AAC3F0", Offset = "0x2AAB7F0", Length = "0x23")]
	[Token(Token = "0x6000C77")]
	public static bool3 op_LessThan(double3 lhs, double rhs) { }

	[Address(RVA = "0x2AAC300", Offset = "0x2AAB700", Length = "0x34")]
	[Token(Token = "0x6000C79")]
	public static bool3 op_LessThanOrEqual(double3 lhs, double3 rhs) { }

	[Address(RVA = "0x2AAC380", Offset = "0x2AAB780", Length = "0x23")]
	[Token(Token = "0x6000C7A")]
	public static bool3 op_LessThanOrEqual(double3 lhs, double rhs) { }

	[Address(RVA = "0x2AAC340", Offset = "0x2AAB740", Length = "0x32")]
	[Token(Token = "0x6000C7B")]
	public static bool3 op_LessThanOrEqual(double lhs, double3 rhs) { }

	[Address(RVA = "0x2A39290", Offset = "0x2A38690", Length = "0x65")]
	[Token(Token = "0x6000C71")]
	public static double3 op_Modulus(double3 lhs, double3 rhs) { }

	[Address(RVA = "0x2AAC4C0", Offset = "0x2AAB8C0", Length = "0x60")]
	[Token(Token = "0x6000C73")]
	public static double3 op_Modulus(double lhs, double3 rhs) { }

	[Address(RVA = "0x2AAC460", Offset = "0x2AAB860", Length = "0x5F")]
	[Token(Token = "0x6000C72")]
	public static double3 op_Modulus(double3 lhs, double rhs) { }

	[Address(RVA = "0x2AAC520", Offset = "0x2AAB920", Length = "0x1E")]
	[Token(Token = "0x6000C67")]
	public static double3 op_Multiply(double lhs, double3 rhs) { }

	[Address(RVA = "0x2AAC540", Offset = "0x2AAB940", Length = "0x1C")]
	[Token(Token = "0x6000C66")]
	public static double3 op_Multiply(double3 lhs, double rhs) { }

	[Address(RVA = "0x2AAC560", Offset = "0x2AAB960", Length = "0x31")]
	[Token(Token = "0x6000C65")]
	public static double3 op_Multiply(double3 lhs, double3 rhs) { }

	[Address(RVA = "0x2AAC600", Offset = "0x2AABA00", Length = "0x29")]
	[Token(Token = "0x6000C6D")]
	public static double3 op_Subtraction(double lhs, double3 rhs) { }

	[Address(RVA = "0x2AAC5A0", Offset = "0x2AAB9A0", Length = "0x20")]
	[Token(Token = "0x6000C6C")]
	public static double3 op_Subtraction(double3 lhs, double rhs) { }

	[Address(RVA = "0x2AAC5C0", Offset = "0x2AAB9C0", Length = "0x31")]
	[Token(Token = "0x6000C6B")]
	public static double3 op_Subtraction(double3 lhs, double3 rhs) { }

	[Address(RVA = "0x2AAC630", Offset = "0x2AABA30", Length = "0x21")]
	[Token(Token = "0x6000C82")]
	public static double3 op_UnaryNegation(double3 val) { }

	[Address(RVA = "0x2AAB260", Offset = "0x2AAA660", Length = "0x1A")]
	[Token(Token = "0x6000C83")]
	public static double3 op_UnaryPlus(double3 val) { }

	[Address(RVA = "0x9E2040", Offset = "0x9E1440", Length = "0x9")]
	[Token(Token = "0x6000D0C")]
	public void set_Item(int index, double value) { }

	[Address(RVA = "0x289C960", Offset = "0x289BD60", Length = "0xF")]
	[Token(Token = "0x6000CFE")]
	public void set_xy(double2 value) { }

	[Address(RVA = "0x2AAB060", Offset = "0x2AAA460", Length = "0x17")]
	[Token(Token = "0x6000CE1")]
	public void set_xyz(double3 value) { }

	[Address(RVA = "0x2AAC660", Offset = "0x2AABA60", Length = "0xF")]
	[Token(Token = "0x6000D00")]
	public void set_xz(double2 value) { }

	[Address(RVA = "0x2AAC670", Offset = "0x2AABA70", Length = "0x17")]
	[Token(Token = "0x6000CE4")]
	public void set_xzy(double3 value) { }

	[Address(RVA = "0x2AA5180", Offset = "0x2AA4580", Length = "0xF")]
	[Token(Token = "0x6000D02")]
	public void set_yx(double2 value) { }

	[Address(RVA = "0x2AAC690", Offset = "0x2AABA90", Length = "0x17")]
	[Token(Token = "0x6000CE9")]
	public void set_yxz(double3 value) { }

	[Address(RVA = "0x2AAC6B0", Offset = "0x2AABAB0", Length = "0x10")]
	[Token(Token = "0x6000D05")]
	public void set_yz(double2 value) { }

	[Address(RVA = "0x2AAC6C0", Offset = "0x2AABAC0", Length = "0x17")]
	[Token(Token = "0x6000CEE")]
	public void set_yzx(double3 value) { }

	[Address(RVA = "0x2AAC6E0", Offset = "0x2AABAE0", Length = "0xF")]
	[Token(Token = "0x6000D07")]
	public void set_zx(double2 value) { }

	[Address(RVA = "0x2AAC6F0", Offset = "0x2AABAF0", Length = "0x17")]
	[Token(Token = "0x6000CF3")]
	public void set_zxy(double3 value) { }

	[Address(RVA = "0x2AAC710", Offset = "0x2AABB10", Length = "0x10")]
	[Token(Token = "0x6000D09")]
	public void set_zy(double2 value) { }

	[Address(RVA = "0x2AAC720", Offset = "0x2AABB20", Length = "0x17")]
	[Token(Token = "0x6000CF6")]
	public void set_zyx(double3 value) { }

	[Address(RVA = "0x2AAAEF0", Offset = "0x2AAA2F0", Length = "0xA6")]
	[Token(Token = "0x6000D10")]
	public virtual string ToString() { }

	[Address(RVA = "0x2AAAE30", Offset = "0x2AAA230", Length = "0xB3")]
	[Token(Token = "0x6000D11")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

