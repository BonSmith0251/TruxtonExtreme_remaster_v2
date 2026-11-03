namespace UnityEngine;

[Token(Token = "0x200000B")]
internal class SendMouseEvents
{
	[Token(Token = "0x200000C")]
	private struct HitInfo
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000038")]
		public GameObject target; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000039")]
		public Camera camera; //Field offset: 0x8

		[Address(RVA = "0x31106B0", Offset = "0x310FAB0", Length = "0x8E")]
		[Token(Token = "0x6000040")]
		public static bool Compare(HitInfo lhs, HitInfo rhs) { }

		[Address(RVA = "0x3110770", Offset = "0x310FB70", Length = "0x7A")]
		[Token(Token = "0x600003F")]
		public static bool op_Implicit(HitInfo exists) { }

		[Address(RVA = "0x3110740", Offset = "0x310FB40", Length = "0x2D")]
		[Token(Token = "0x600003E")]
		public void SendMessage(string name) { }

	}

	[Token(Token = "0x400002F")]
	private static bool s_MouseUsed; //Field offset: 0x0
	[Token(Token = "0x4000030")]
	private static readonly HitInfo[] m_LastHit; //Field offset: 0x8
	[Token(Token = "0x4000031")]
	private static readonly HitInfo[] m_MouseDownHit; //Field offset: 0x10
	[Token(Token = "0x4000032")]
	private static readonly HitInfo[] m_CurrentHit; //Field offset: 0x18
	[Token(Token = "0x4000033")]
	private static Camera[] m_Cameras; //Field offset: 0x20
	[Token(Token = "0x4000034")]
	public static Func<KeyValuePair`2<Int32, Vector2>> s_GetMouseState; //Field offset: 0x28
	[Token(Token = "0x4000035")]
	private static Vector2 s_MousePosition; //Field offset: 0x30
	[Token(Token = "0x4000036")]
	private static bool s_MouseButtonPressedThisFrame; //Field offset: 0x38
	[Token(Token = "0x4000037")]
	private static bool s_MouseButtonIsPressed; //Field offset: 0x39

	[Address(RVA = "0x31131A0", Offset = "0x31125A0", Length = "0xF8")]
	[Token(Token = "0x600003D")]
	private static SendMouseEvents() { }

	[Address(RVA = "0x3111910", Offset = "0x3110D10", Length = "0xC2F")]
	[RequiredByNativeCode]
	[Token(Token = "0x600003B")]
	private static void DoSendMouseEvents(int skipRTCameras) { }

	[Address(RVA = "0x3112540", Offset = "0x3111940", Length = "0x994")]
	[Token(Token = "0x600003C")]
	private static void SendEvents(int i, HitInfo hit) { }

	[Address(RVA = "0x3112EE0", Offset = "0x31122E0", Length = "0x4E")]
	[RequiredByNativeCode]
	[Token(Token = "0x600003A")]
	private static void SetMouseMoved() { }

	[Address(RVA = "0x3112F30", Offset = "0x3112330", Length = "0x264")]
	[Token(Token = "0x6000039")]
	private static void UpdateMouse() { }

}

