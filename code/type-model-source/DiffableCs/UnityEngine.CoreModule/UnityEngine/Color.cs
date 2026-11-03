namespace UnityEngine;

[DefaultMember("Item")]
[NativeClass("ColorRGBAf")]
[NativeHeader("Runtime/Math/Color.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Token(Token = "0x200014C")]
public struct Color : IEquatable<Color>, IFormattable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000575")]
	public float r; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000576")]
	public float g; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000577")]
	public float b; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000578")]
	public float a; //Field offset: 0xC

	[Token(Token = "0x17000278")]
	public static Color black
	{
		[Address(RVA = "0x3047EC0", Offset = "0x30472C0", Length = "0x13")]
		[Token(Token = "0x6000FF5")]
		 get { } //Length: 19
	}

	[Token(Token = "0x17000279")]
	public static Color blue
	{
		[Address(RVA = "0x3047EE0", Offset = "0x30472E0", Length = "0x17")]
		[Token(Token = "0x6000FF6")]
		 get { } //Length: 23
	}

	[Token(Token = "0x1700027A")]
	public static Color clear
	{
		[Address(RVA = "0x3047F00", Offset = "0x3047300", Length = "0xD")]
		[Token(Token = "0x6000FF7")]
		 get { } //Length: 13
	}

	[Token(Token = "0x17000276")]
	public Color gamma
	{
		[Address(RVA = "0x3047F10", Offset = "0x3047310", Length = "0xBC")]
		[IsReadOnly]
		[Token(Token = "0x6000FF1")]
		 get { } //Length: 188
	}

	[Token(Token = "0x1700027B")]
	public static Color gray
	{
		[Address(RVA = "0x3047FF0", Offset = "0x30473F0", Length = "0xF")]
		[Token(Token = "0x6000FF8")]
		 get { } //Length: 15
	}

	[Token(Token = "0x1700027D")]
	public static Color gray5
	{
		[Address(RVA = "0x3047FD0", Offset = "0x30473D0", Length = "0x1F")]
		[Token(Token = "0x6000FFA")]
		 get { } //Length: 31
	}

	[Token(Token = "0x1700027E")]
	public static Color green
	{
		[Address(RVA = "0x3048000", Offset = "0x3047400", Length = "0x17")]
		[Token(Token = "0x6000FFB")]
		 get { } //Length: 23
	}

	[Token(Token = "0x1700027C")]
	public static Color grey
	{
		[Address(RVA = "0x3047FF0", Offset = "0x30473F0", Length = "0xF")]
		[Token(Token = "0x6000FF9")]
		 get { } //Length: 15
	}

	[Token(Token = "0x17000275")]
	public Color linear
	{
		[Address(RVA = "0x3048020", Offset = "0x3047420", Length = "0xBC")]
		[IsReadOnly]
		[Token(Token = "0x6000FF0")]
		 get { } //Length: 188
	}

	[Token(Token = "0x1700027F")]
	public static Color magenta
	{
		[Address(RVA = "0x30480E0", Offset = "0x30474E0", Length = "0x19")]
		[Token(Token = "0x6000FFC")]
		 get { } //Length: 25
	}

	[Token(Token = "0x17000277")]
	public float maxColorComponent
	{
		[Address(RVA = "0x3048100", Offset = "0x3047500", Length = "0x11")]
		[IsReadOnly]
		[Token(Token = "0x6000FF2")]
		 get { } //Length: 17
	}

	[Token(Token = "0x17000280")]
	public static Color red
	{
		[Address(RVA = "0x3048120", Offset = "0x3047520", Length = "0x17")]
		[Token(Token = "0x6000FFD")]
		 get { } //Length: 23
	}

	[Token(Token = "0x17000281")]
	public static Color white
	{
		[Address(RVA = "0x3048140", Offset = "0x3047540", Length = "0x1F")]
		[Token(Token = "0x6000FFE")]
		 get { } //Length: 31
	}

	[Token(Token = "0x17000282")]
	public static Color yellow
	{
		[Address(RVA = "0x3048160", Offset = "0x3047560", Length = "0x1F")]
		[Token(Token = "0x6000FFF")]
		 get { } //Length: 31
	}

	[Address(RVA = "0x27F69A0", Offset = "0x27F5DA0", Length = "0x1A")]
	[Token(Token = "0x6000FDE")]
	public Color(float r, float g, float b, float a) { }

	[Address(RVA = "0x3047EA0", Offset = "0x30472A0", Length = "0x16")]
	[Token(Token = "0x6000FDF")]
	public Color(float r, float g, float b) { }

	[Address(RVA = "0x30479D0", Offset = "0x3046DD0", Length = "0xF5")]
	[IsReadOnly]
	[Token(Token = "0x6000FE3")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x6BE170", Offset = "0x6BD570", Length = "0x72")]
	[IsReadOnly]
	[Token(Token = "0x6000FE4")]
	public override bool Equals(Color other) { }

	[Address(RVA = "0x6BE170", Offset = "0x6BD570", Length = "0x72")]
	[IsReadOnly]
	[Token(Token = "0x6000FE5")]
	public bool Equals(in Color other) { }

	[Address(RVA = "0x3047EC0", Offset = "0x30472C0", Length = "0x13")]
	[Token(Token = "0x6000FF5")]
	public static Color get_black() { }

	[Address(RVA = "0x3047EE0", Offset = "0x30472E0", Length = "0x17")]
	[Token(Token = "0x6000FF6")]
	public static Color get_blue() { }

	[Address(RVA = "0x3047F00", Offset = "0x3047300", Length = "0xD")]
	[Token(Token = "0x6000FF7")]
	public static Color get_clear() { }

	[Address(RVA = "0x3047F10", Offset = "0x3047310", Length = "0xBC")]
	[IsReadOnly]
	[Token(Token = "0x6000FF1")]
	public Color get_gamma() { }

	[Address(RVA = "0x3047FF0", Offset = "0x30473F0", Length = "0xF")]
	[Token(Token = "0x6000FF8")]
	public static Color get_gray() { }

	[Address(RVA = "0x3047FD0", Offset = "0x30473D0", Length = "0x1F")]
	[Token(Token = "0x6000FFA")]
	public static Color get_gray5() { }

	[Address(RVA = "0x3048000", Offset = "0x3047400", Length = "0x17")]
	[Token(Token = "0x6000FFB")]
	public static Color get_green() { }

	[Address(RVA = "0x3047FF0", Offset = "0x30473F0", Length = "0xF")]
	[Token(Token = "0x6000FF9")]
	public static Color get_grey() { }

	[Address(RVA = "0x3048020", Offset = "0x3047420", Length = "0xBC")]
	[IsReadOnly]
	[Token(Token = "0x6000FF0")]
	public Color get_linear() { }

	[Address(RVA = "0x30480E0", Offset = "0x30474E0", Length = "0x19")]
	[Token(Token = "0x6000FFC")]
	public static Color get_magenta() { }

	[Address(RVA = "0x3048100", Offset = "0x3047500", Length = "0x11")]
	[IsReadOnly]
	[Token(Token = "0x6000FF2")]
	public float get_maxColorComponent() { }

	[Address(RVA = "0x3048120", Offset = "0x3047520", Length = "0x17")]
	[Token(Token = "0x6000FFD")]
	public static Color get_red() { }

	[Address(RVA = "0x3048140", Offset = "0x3047540", Length = "0x1F")]
	[Token(Token = "0x6000FFE")]
	public static Color get_white() { }

	[Address(RVA = "0x3048160", Offset = "0x3047560", Length = "0x1F")]
	[Token(Token = "0x6000FFF")]
	public static Color get_yellow() { }

	[Address(RVA = "0x80AFF0", Offset = "0x80A3F0", Length = "0x6B")]
	[IsReadOnly]
	[Token(Token = "0x6000FE2")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3047B40", Offset = "0x3046F40", Length = "0x98")]
	[Token(Token = "0x6000FED")]
	public static Color Lerp(Color a, Color b, float t) { }

	[Address(RVA = "0x3047AD0", Offset = "0x3046ED0", Length = "0x64")]
	[Token(Token = "0x6000FEE")]
	public static Color LerpUnclamped(Color a, Color b, float t) { }

	[Address(RVA = "0x2AE0900", Offset = "0x2ADFD00", Length = "0x41")]
	[Token(Token = "0x6000FE6")]
	public static Color op_Addition(Color a, Color b) { }

	[Address(RVA = "0x3048180", Offset = "0x3047580", Length = "0x51")]
	[Token(Token = "0x6000FEB")]
	public static bool op_Equality(Color lhs, Color rhs) { }

	[Address(RVA = "0x2880350", Offset = "0x287F750", Length = "0x5CC")]
	[Token(Token = "0x6000FF3")]
	public static Vector4 op_Implicit(Color c) { }

	[Address(RVA = "0x2880350", Offset = "0x287F750", Length = "0x5CC")]
	[Token(Token = "0x6000FF4")]
	public static Color op_Implicit(Vector4 v) { }

	[Address(RVA = "0x30481E0", Offset = "0x30475E0", Length = "0x68")]
	[Token(Token = "0x6000FEC")]
	public static bool op_Inequality(Color lhs, Color rhs) { }

	[Address(RVA = "0x2AE1170", Offset = "0x2AE0570", Length = "0x12")]
	[Token(Token = "0x6000FEA")]
	public static Color op_Multiply(float b, Color a) { }

	[Address(RVA = "0x2AE1150", Offset = "0x2AE0550", Length = "0x11")]
	[Token(Token = "0x6000FE9")]
	public static Color op_Multiply(Color a, float b) { }

	[Address(RVA = "0x2AE1100", Offset = "0x2AE0500", Length = "0x41")]
	[Token(Token = "0x6000FE8")]
	public static Color op_Multiply(Color a, Color b) { }

	[Address(RVA = "0x2AE11F0", Offset = "0x2AE05F0", Length = "0x41")]
	[Token(Token = "0x6000FE7")]
	public static Color op_Subtraction(Color a, Color b) { }

	[Address(RVA = "0x3047BE0", Offset = "0x3046FE0", Length = "0x2C")]
	[IsReadOnly]
	[Token(Token = "0x6000FEF")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal Color RGBMultiplied(float multiplier) { }

	[Address(RVA = "0x3047C20", Offset = "0x3047020", Length = "0x279")]
	[IsReadOnly]
	[Token(Token = "0x6000FE1")]
	public override string ToString(string format, IFormatProvider formatProvider) { }

	[Address(RVA = "0x3047C10", Offset = "0x3047010", Length = "0xD")]
	[IsReadOnly]
	[Token(Token = "0x6000FE0")]
	public virtual string ToString() { }

}

