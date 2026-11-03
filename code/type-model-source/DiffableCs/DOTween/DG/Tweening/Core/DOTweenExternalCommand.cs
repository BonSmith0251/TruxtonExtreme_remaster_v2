namespace DG.Tweening.Core;

[Token(Token = "0x20000AF")]
public static class DOTweenExternalCommand
{
	[CompilerGenerated]
	[Token(Token = "0x400020C")]
	private static Action<PathOptions, Tween, Quaternion, Transform> SetOrientationOnPath; //Field offset: 0x0

	[Token(Token = "0x14000001")]
	public static event Action<PathOptions, Tween, Quaternion, Transform> SetOrientationOnPath
	{
		[Address(RVA = "0x668650", Offset = "0x667A50", Length = "0xD7")]
		[CompilerGenerated]
		[Token(Token = "0x600040A")]
		 add { } //Length: 215
		[Address(RVA = "0x668730", Offset = "0x667B30", Length = "0xD7")]
		[CompilerGenerated]
		[Token(Token = "0x600040B")]
		 remove { } //Length: 215
	}

	[Address(RVA = "0x668650", Offset = "0x667A50", Length = "0xD7")]
	[CompilerGenerated]
	[Token(Token = "0x600040A")]
	public static void add_SetOrientationOnPath(Action<PathOptions, Tween, Quaternion, Transform> value) { }

	[Address(RVA = "0x668560", Offset = "0x667960", Length = "0xE4")]
	[Token(Token = "0x600040C")]
	internal static void Dispatch_SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans) { }

	[Address(RVA = "0x668730", Offset = "0x667B30", Length = "0xD7")]
	[CompilerGenerated]
	[Token(Token = "0x600040B")]
	public static void remove_SetOrientationOnPath(Action<PathOptions, Tween, Quaternion, Transform> value) { }

}

