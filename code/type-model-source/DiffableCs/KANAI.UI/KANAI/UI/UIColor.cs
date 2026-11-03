namespace KANAI.UI;

[Token(Token = "0x2000012")]
public static class UIColor
{
	[Token(Token = "0x400003A")]
	public static readonly Color32 none32; //Field offset: 0x0
	[Token(Token = "0x400003B")]
	public static readonly Color32 white32; //Field offset: 0x4
	[Token(Token = "0x400003C")]
	public static readonly Color32 gray32; //Field offset: 0x8
	[Token(Token = "0x400003D")]
	public static readonly Color32 dimgray32; //Field offset: 0xC
	[Token(Token = "0x400003E")]
	public static readonly Color32 black32; //Field offset: 0x10
	[Token(Token = "0x400003F")]
	public static readonly Color32 red32; //Field offset: 0x14
	[Token(Token = "0x4000040")]
	public static readonly Color32 darkred32; //Field offset: 0x18
	[Token(Token = "0x4000041")]
	public static readonly Color32 blue32; //Field offset: 0x1C
	[Token(Token = "0x4000042")]
	public static readonly Color32 brown32; //Field offset: 0x20
	[Token(Token = "0x4000043")]
	public static readonly Color32 green32; //Field offset: 0x24
	[Token(Token = "0x4000044")]
	public static readonly Color32 darkgreen32; //Field offset: 0x28
	[Token(Token = "0x4000045")]
	public static readonly Color32 lightgreen32; //Field offset: 0x2C
	[Token(Token = "0x4000046")]
	public static readonly Color32 pink32; //Field offset: 0x30
	[Token(Token = "0x4000047")]
	public static readonly Color none; //Field offset: 0x34
	[Token(Token = "0x4000048")]
	public static readonly Color white; //Field offset: 0x44
	[Token(Token = "0x4000049")]
	public static readonly Color gray; //Field offset: 0x54
	[Token(Token = "0x400004A")]
	public static readonly Color dimgray; //Field offset: 0x64
	[Token(Token = "0x400004B")]
	public static readonly Color black; //Field offset: 0x74
	[Token(Token = "0x400004C")]
	public static readonly Color red; //Field offset: 0x84
	[Token(Token = "0x400004D")]
	public static readonly Color darkred; //Field offset: 0x94
	[Token(Token = "0x400004E")]
	public static readonly Color blue; //Field offset: 0xA4
	[Token(Token = "0x400004F")]
	public static readonly Color brown; //Field offset: 0xB4
	[Token(Token = "0x4000050")]
	public static readonly Color green; //Field offset: 0xC4
	[Token(Token = "0x4000051")]
	public static readonly Color darkgreen; //Field offset: 0xD4
	[Token(Token = "0x4000052")]
	public static readonly Color lightgreen; //Field offset: 0xE4
	[Token(Token = "0x4000053")]
	public static readonly Color pink; //Field offset: 0xF4
	[Token(Token = "0x4000054")]
	public static readonly Color half; //Field offset: 0x104
	[Token(Token = "0x4000055")]
	public static readonly Color halfAlpha; //Field offset: 0x114
	[Token(Token = "0x4000056")]
	public static readonly Color halfAlphaDark; //Field offset: 0x124
	[Token(Token = "0x4000057")]
	public static readonly Color upAlpha; //Field offset: 0x134
	[Token(Token = "0x4000058")]
	public static readonly Color downAlpha; //Field offset: 0x144
	[Token(Token = "0x4000059")]
	public static readonly Color noAlpha; //Field offset: 0x154

	[Address(RVA = "0x1E18F00", Offset = "0x1E18300", Length = "0x8A2")]
	[Token(Token = "0x6000070")]
	private static UIColor() { }

	[Address(RVA = "0x1E18EE0", Offset = "0x1E182E0", Length = "0x17")]
	[CompilerGenerated]
	[Token(Token = "0x6000071")]
	internal static int <IsSame>g__calcSub|5_0(byte a, byte b) { }

	[Address(RVA = "0x1E18B80", Offset = "0x1E17F80", Length = "0x61")]
	[Token(Token = "0x600006D")]
	public static Color Color32ToColor(Color32 c32) { }

	[Address(RVA = "0x1E18CA0", Offset = "0x1E180A0", Length = "0x84")]
	[Token(Token = "0x600006A")]
	public static Color IntToColor(uint value, float alpha = 1) { }

	[Address(RVA = "0x1E18C40", Offset = "0x1E18040", Length = "0x51")]
	[Token(Token = "0x600006B")]
	public static Color IntToColor(byte br, byte bg, byte bb, float alpha = 1) { }

	[Address(RVA = "0x1E18BF0", Offset = "0x1E17FF0", Length = "0x43")]
	[Token(Token = "0x600006C")]
	public static Color32 IntToColor32(uint value, byte alpha = 255) { }

	[Address(RVA = "0x1E18D30", Offset = "0x1E18130", Length = "0x149")]
	[Token(Token = "0x600006F")]
	public static bool IsSame(Color32 acolor, Color32 bcolor, int tsub = 4) { }

	[Address(RVA = "0x1E18E80", Offset = "0x1E18280", Length = "0x55")]
	[Token(Token = "0x600006E")]
	public static Color32 ToColor32(Color tcolor) { }

}

