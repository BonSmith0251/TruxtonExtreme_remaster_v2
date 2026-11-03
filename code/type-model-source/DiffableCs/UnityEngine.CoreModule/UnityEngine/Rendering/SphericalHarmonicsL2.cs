namespace UnityEngine.Rendering;

[DefaultMember("Item")]
[NativeHeader("Runtime/Export/Math/SphericalHarmonicsL2.bindings.h")]
[Token(Token = "0x2000396")]
[UsedByNativeCode]
public struct SphericalHarmonicsL2 : IEquatable<SphericalHarmonicsL2>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000AB7")]
	private float shr0; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000AB8")]
	private float shr1; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000AB9")]
	private float shr2; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000ABA")]
	private float shr3; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000ABB")]
	private float shr4; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000ABC")]
	private float shr5; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000ABD")]
	private float shr6; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000ABE")]
	private float shr7; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000ABF")]
	private float shr8; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000AC0")]
	private float shg0; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000AC1")]
	private float shg1; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000AC2")]
	private float shg2; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000AC3")]
	private float shg3; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000AC4")]
	private float shg4; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000AC5")]
	private float shg5; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000AC6")]
	private float shg6; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000AC7")]
	private float shg7; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000AC8")]
	private float shg8; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000AC9")]
	private float shb0; //Field offset: 0x48
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000ACA")]
	private float shb1; //Field offset: 0x4C
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000ACB")]
	private float shb2; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000ACC")]
	private float shb3; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000ACD")]
	private float shb4; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000ACE")]
	private float shb5; //Field offset: 0x5C
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000ACF")]
	private float shb6; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000AD0")]
	private float shb7; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000AD1")]
	private float shb8; //Field offset: 0x68

	[Token(Token = "0x170003ED")]
	public float Item
	{
		[Address(RVA = "0x30B7780", Offset = "0x30B6B80", Length = "0x1B0")]
		[IsReadOnly]
		[Token(Token = "0x6001CD0")]
		 get { } //Length: 432
		[Address(RVA = "0x30B7A60", Offset = "0x30B6E60", Length = "0x1B0")]
		[Token(Token = "0x6001CD1")]
		 set { } //Length: 432
	}

	[Address(RVA = "0x30B7450", Offset = "0x30B6850", Length = "0x154")]
	[IsReadOnly]
	[Token(Token = "0x6001CD3")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6CC190", Offset = "0x6CB590", Length = "0xB4")]
	[IsReadOnly]
	[Token(Token = "0x6001CD4")]
	public override bool Equals(SphericalHarmonicsL2 other) { }

	[Address(RVA = "0x6CC190", Offset = "0x6CB590", Length = "0xB4")]
	[IsReadOnly]
	[Token(Token = "0x6001CD5")]
	public bool Equals(in SphericalHarmonicsL2 other) { }

	[Address(RVA = "0x30B7780", Offset = "0x30B6B80", Length = "0x1B0")]
	[IsReadOnly]
	[Token(Token = "0x6001CD0")]
	public float get_Item(int rgb, int coefficient) { }

	[Address(RVA = "0x30B75B0", Offset = "0x30B69B0", Length = "0x1C6")]
	[IsReadOnly]
	[Token(Token = "0x6001CD2")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x6CC250", Offset = "0x6CB650", Length = "0x216")]
	[Token(Token = "0x6001CD6")]
	public static bool op_Equality(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs) { }

	[Address(RVA = "0x30B79A0", Offset = "0x30B6DA0", Length = "0xB6")]
	[Token(Token = "0x6001CD7")]
	public static bool op_Inequality(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs) { }

	[Address(RVA = "0x30B7A60", Offset = "0x30B6E60", Length = "0x1B0")]
	[Token(Token = "0x6001CD1")]
	public void set_Item(int rgb, int coefficient, float value) { }

}

