namespace DG.Tweening.Plugins.Core;

[Token(Token = "0x2000096")]
internal static class PluginsManager
{
	[Token(Token = "0x400018C")]
	private static ITweenPlugin _floatPlugin; //Field offset: 0x0
	[Token(Token = "0x400019C")]
	private const int _MaxCustomPlugins = 20; //Field offset: 0x0
	[Token(Token = "0x400018D")]
	private static ITweenPlugin _doublePlugin; //Field offset: 0x8
	[Token(Token = "0x400018E")]
	private static ITweenPlugin _intPlugin; //Field offset: 0x10
	[Token(Token = "0x400018F")]
	private static ITweenPlugin _uintPlugin; //Field offset: 0x18
	[Token(Token = "0x4000190")]
	private static ITweenPlugin _longPlugin; //Field offset: 0x20
	[Token(Token = "0x4000191")]
	private static ITweenPlugin _ulongPlugin; //Field offset: 0x28
	[Token(Token = "0x4000192")]
	private static ITweenPlugin _vector2Plugin; //Field offset: 0x30
	[Token(Token = "0x4000193")]
	private static ITweenPlugin _vector3Plugin; //Field offset: 0x38
	[Token(Token = "0x4000194")]
	private static ITweenPlugin _vector4Plugin; //Field offset: 0x40
	[Token(Token = "0x4000195")]
	private static ITweenPlugin _quaternionPlugin; //Field offset: 0x48
	[Token(Token = "0x4000196")]
	private static ITweenPlugin _colorPlugin; //Field offset: 0x50
	[Token(Token = "0x4000197")]
	private static ITweenPlugin _rectPlugin; //Field offset: 0x58
	[Token(Token = "0x4000198")]
	private static ITweenPlugin _rectOffsetPlugin; //Field offset: 0x60
	[Token(Token = "0x4000199")]
	private static ITweenPlugin _stringPlugin; //Field offset: 0x68
	[Token(Token = "0x400019A")]
	private static ITweenPlugin _vector3ArrayPlugin; //Field offset: 0x70
	[Token(Token = "0x400019B")]
	private static ITweenPlugin _color2Plugin; //Field offset: 0x78
	[Token(Token = "0x400019D")]
	private static Dictionary<Type, ITweenPlugin> _customPlugins; //Field offset: 0x80

	[Address(RVA = "0x8B1C10", Offset = "0x8B1010", Length = "0x1DF")]
	[Token(Token = "0x6000374")]
	public static ABSTweenPlugin<T1, T2, TPlugOptions> GetCustomPlugin() { }

	[Address(RVA = "0x8B1DF0", Offset = "0x8B11F0", Length = "0xC67")]
	[Token(Token = "0x6000373")]
	internal static ABSTweenPlugin<T1, T2, TPlugOptions> GetDefaultPlugin() { }

	[Address(RVA = "0x66EEF0", Offset = "0x66E2F0", Length = "0x2E5")]
	[Token(Token = "0x6000375")]
	internal static void PurgeAll() { }

}

