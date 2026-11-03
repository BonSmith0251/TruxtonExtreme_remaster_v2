namespace UnityEngine.Playables;

[Extension]
[Token(Token = "0x2000329")]
public static class PlayableOutputExtensions
{

	[Address(RVA = "0x8AFED0", Offset = "0x8AF2D0", Length = "0xB5")]
	[Extension]
	[Token(Token = "0x6001996")]
	public static void AddNotificationReceiver(U output, INotificationReceiver receiver) { }

	[Address(RVA = "0x8AFF90", Offset = "0x8AF390", Length = "0x83")]
	[Extension]
	[Token(Token = "0x6001993")]
	public static int GetSourceOutputPort(U output) { }

	[Address(RVA = "0x8B0130", Offset = "0x8AF530", Length = "0xCA")]
	[Extension]
	[Token(Token = "0x6001990")]
	public static Playable GetSourcePlayable(U output) { }

	[Address(RVA = "0x8B0460", Offset = "0x8AF860", Length = "0xA4")]
	[Extension]
	[Token(Token = "0x600198E")]
	public static object GetUserData(U output) { }

	[Address(RVA = "0x8B0680", Offset = "0x8AFA80", Length = "0x128")]
	[Extension]
	[Token(Token = "0x6001995")]
	public static void PushNotification(U output, Playable origin, INotification notification, object context = null) { }

	[Address(RVA = "0x8B08D0", Offset = "0x8AFCD0", Length = "0xB5")]
	[Extension]
	[Token(Token = "0x600198D")]
	public static void SetReferenceObject(U output, object value) { }

	[Address(RVA = "0x8B0990", Offset = "0x8AFD90", Length = "0x13F")]
	[Extension]
	[Token(Token = "0x6001991")]
	public static void SetSourcePlayable(U output, V value) { }

	[Address(RVA = "0x8B0EA0", Offset = "0x8B02A0", Length = "0x110")]
	[Extension]
	[Token(Token = "0x6001992")]
	public static void SetSourcePlayable(U output, V value, int port) { }

	[Address(RVA = "0x8B10D0", Offset = "0x8B04D0", Length = "0xB5")]
	[Extension]
	[Token(Token = "0x600198F")]
	public static void SetUserData(U output, object value) { }

	[Address(RVA = "0x8B1190", Offset = "0x8B0590", Length = "0x94")]
	[Extension]
	[Token(Token = "0x6001994")]
	public static void SetWeight(U output, float value) { }

}

